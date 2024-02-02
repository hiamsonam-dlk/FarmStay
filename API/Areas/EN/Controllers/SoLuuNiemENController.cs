using API.Areas.Admin.Models.Booking;
using API.Areas.EN.Models.MyHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API.Areas.EN.Controllers
{
    [Area("EN")]
    public class SoLuuNiemENController : Controller
    {
        private IConfiguration Configuration;
        private IHostingEnvironment _hostingEnvironment;
        public SoLuuNiemENController(IConfiguration config, IHostingEnvironment environment)
        {
            Configuration = config;
            _hostingEnvironment = environment;
        }
        public IActionResult Index([FromQuery] SearchBooking dto, string btn = "search")
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int TotalItems = 0;

            BookingModel data = new BookingModel() { SearchData = dto };
            data.ListItems = BookingService.GetListPaginationClient(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.ListItemsStatus = BookingService.GetListItemsStatus();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            HttpContext.Session.SetString("STR_Action_Link_" + ControllerName, Request.QueryString.ToString());
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public ActionResult SaveItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SaveItem(Booking data)
        {
            BookingModel model = new BookingModel() { Item = data };
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            //Google Google = new Google();
            Boolean CheckGoogle = Google.CheckGoogle(Configuration["RecaptchaSettings:SecretKey"], data.TokenRecaptcha);
            //Boolean CheckGoogle = true;
            if (CheckGoogle)
            {
                if (ModelState.IsValid)
                {

                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "CMS/Content/FromUser/ViengTham");

                    if (data.IListImage != null)
                    {
                        model.Item.ListHinhAnh = new List<HinhAnh>();
                        for (int i = 0; i < data.IListImage.Count(); i++)
                        {
                            HinhAnh hinhanh = new HinhAnh() { };
                            string HinhAnhCCCDFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(model.Item.IListImage[i].FileName.ToString().Trim());
                            var HinhAnhCCCDFilePath = Path.Combine(uploads, HinhAnhCCCDFileName);
                            using (var fileStream = new FileStream(HinhAnhCCCDFilePath, FileMode.Create))
                            {
                                await model.Item.IListImage[i].CopyToAsync(fileStream);
                            }
                            hinhanh.URL = "/CMS/Content/FromUser/ViengTham/" + HinhAnhCCCDFileName;
                            model.Item.ListHinhAnh.Add(hinhanh);
                        }
                        model.Item.StrListHinhAnh = JsonConvert.SerializeObject(model.Item.ListHinhAnh);
                    }

                    model.Item.CreatedBy = data.SoDT;
                    model.Item.CreatedAt = DateTime.Now;
                    try
                    {
                        BookingService.SaveItem(model.Item);
                        TempData["MessageSuccess"] = "Sent your though successful, thanks!";
                        return View("~/Areas/EN/Views/HomeEN/Index.cshtml");
                        //return RedirectToAction("Index", "HomeEN", new { area = "EN" });
                    }
                    catch
                    {
                        TempData["MessageSuccess"] = "Error, Please try again!";
                        return View("~/Areas/EN/Views/HomeEN/Index.cshtml");
                        //return RedirectToAction("Index", "HomeEN", new { area = "EN" });
                    }
                }
            }
            else
            {
                TempData["MessageSuccess"] = "Error occured while verification, Please try again!";
            }
            return View(model);
        }
    }
}
