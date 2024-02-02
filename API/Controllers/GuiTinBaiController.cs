using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.GuiTinBai;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reCAPTCHA.AspNetCore;

namespace API.Controllers
{

    public class GuiTinBaiController : Controller
    {
        private readonly IRecaptchaService _recaptcha;
        private IHostingEnvironment _hostingEnvironment;
        public GuiTinBaiController(IRecaptchaService recaptcha, IHostingEnvironment environment)
        {
            _recaptcha = recaptcha;
            _hostingEnvironment = environment;
        }
             

        public IActionResult List([FromQuery] SearchGuiTinBai dto,int EventId = 0)
        {
            dto.Type = 1;
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            GuiTinBaiModel data = new GuiTinBaiModel() { SearchData = dto };
            data.ListItems = GuiTinBaiService.GetListPaginationFront(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.eID = EventId;

            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            return View(data);
        }

        public IActionResult Index()
        {
            GuiTinBaiModel data = new GuiTinBaiModel() {
                SearchData = new SearchGuiTinBai() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" },
                Item = new GuiTinBai()
            };                        
            return View(data);            
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(GuiTinBai model, IEnumerable<IFormFile> FileAttached)
        {
            //string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            var recaptcha = await _recaptcha.Validate(Request);
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "guitinbai");
            GuiTinBaiModel data = new GuiTinBaiModel() { Item = model };
            data.Item.Type = 1;
            data.Item.Status = false;
            data.Item.CreatedDate = DateTime.Now;
            if (!recaptcha.success)
            {
                ModelState.AddModelError("Recaptcha", "Mã Captcha không chính xác. Vui lòng thử lại!");
            }
            else
            {
                if (ModelState.IsValid)
                {

                //Thêm file
                foreach (var file in FileAttached)
                {
                    if (file != null && file.Length > 0)
                    {
                        if (API.Models.Utilities.FileHelpers.CheckFileAttach(file.FileName))
                        {
                            if(file.Length < 36700160)
                            {
                                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(file.FileName.TrimEnd());
                                var filePath = Path.Combine(uploads, filename);
                                using (var fileStream = new FileStream(filePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                }
                                data.Item.Link = filename;
                            }
                            else
                            {
                                TempData["MessageError"] = "File không được quá 30Mb";
                                return View(data);
                            }
                            
                        }
                        else
                        {
                            TempData["MessageError"] = "File không hợp lệ";
                            return View(data);
                        }
                    }

                }
                //Thêm file

                       model.Id = 0;
                    model.CreatedBy = 0;
                    model.ModifiedBy = 0;
                    model.Type = 1;
                    model.CreatedBy = 1;
                    try
                    {
                        GuiTinBaiService.SaveItem(model);
                        TempData["MessageSuccess"] = "Gửi thông tin thành công. Cảm ơn bạn đã đóng góp bài viết !";                       
                    }
                    catch {
                        TempData["MessageError"] = "Gửi thông tin thất bại. Xin vui lòng gửi lại";
                        
                    }
                    return RedirectToAction("Index");

                }
            }

            return View(data);
        }

    }
}