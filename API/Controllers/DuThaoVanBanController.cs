using API.Areas.Admin.Models.DocumentsField;
using API.Areas.Admin.Models.DuThaoVanBan;
using API.Areas.Admin.Models.DuThaoVanBanGopY;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using reCAPTCHA.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class DuThaoVanBanController : Controller
    {
      
        private readonly IRecaptchaService _recaptcha;
        public DuThaoVanBanController(IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
        }

        public IActionResult Index([FromQuery] SearchDuThaoVanBan dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DuThaoVanBanModel data = new DuThaoVanBanModel() { SearchData = dto };
            
            data.ListItems = DuThaoVanBanService.GetListPagination(data.SearchData, ControllerName,true);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListDocumentsField = DocumentsFieldService.GetListSelectItems();

            return View(data);
        }

        public IActionResult Detail(int id,int page=1)
        {

            DuThaoVanBanModel data = new DuThaoVanBanModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            data= DuThaoVanBanService.GetItemFront(id, API.Models.Settings.SecretId + ControllerName);
         
            if (data.Item == null)
                return RedirectToAction("Index", "Home");

            int TotalItems = 0;
            if (data.Item.ListGopY!= null && data.Item.ListGopY.Count() > 0)
            {
                TotalItems = data.Item.ListGopY[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = page, ItemsPerPage = 10, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }


        public IActionResult DuThaoVanBanGopY(int Id, string Ids)
        {
            DuThaoVanBanGopYModel data = new DuThaoVanBanGopYModel()
            {
                SearchData = new SearchDuThaoVanBanGopY() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "",IdDuThao= Id, IdsDuThao=Ids },
                Item = new DuThaoVanBanGopY() { IdDuThao = Id, IdsDuThao = Ids }

            };
            data.vb = DuThaoVanBanService.GetItem(Id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DuThaoVanBanGopY(DuThaoVanBanGopY model)
        {
            var recaptcha = await _recaptcha.Validate(Request);
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            DuThaoVanBanGopYModel data = new DuThaoVanBanGopYModel()
            {
                SearchData = new SearchDuThaoVanBanGopY() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" },
                Item = model
            };


            if (!recaptcha.success)
            {
                ModelState.AddModelError("Recaptcha", "Mã Captcha không chính xác. Vui lòng thử lại!");
            }
            else
            {
                if (ModelState.IsValid)
            {
                model.Id = 0;
                model.CreatedBy = 0;
                model.ModifiedBy = 0;

                int IdDC = Int32.Parse(MyModels.Decode(model.IdsDuThao, ControllerName).ToString());
                if (IdDC > 0)
                {

                    try
                    {
                        DuThaoVanBanGopYService.SaveItem(model);
                        TempData["MessageSuccess"] = "Gửi dự thảo văn bản thành công";
                    }
                    catch
                    {
                        TempData["MessageError"] = "Gửi dự thảo văn bản Thất bại. Xin vui lòng gửi lại";
                    }
                }
                else
                {
                    TempData["MessageError"] = "Gửi dự thảo văn bản Thất bại. Xin vui lòng gửi lại ...";
                }

                return RedirectToAction("Index");

            }
            }
            data.vb = DuThaoVanBanService.GetItem(model.IdDuThao);
            return View(data);
        }
    }
}
