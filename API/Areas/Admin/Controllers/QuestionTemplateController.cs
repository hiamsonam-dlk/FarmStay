using API.Areas.Admin.Models.QuestionTemplate;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using API.Areas.Admin.Models.Banners;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionTemplateController : Controller
    {
        public IActionResult Index([FromQuery] SearchQuestionTemplate dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            QuestionTemplateModel data = new QuestionTemplateModel() { SearchData = dto };
            data.ListItems = QuestionTemplateService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListService = BannersService.GetListItemsByCatForQuestionTemplate(13);
            return View(data);
        }

        public IActionResult SaveItem(string Id = null, int CatId = 13, int IdCoQuan = 1)
        {
            QuestionTemplateModel data = new QuestionTemplateModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchQuestionTemplate() { CurrentPage = 0, ItemsPerPage = 10, Keyword = ""};
            data.ListService = BannersService.GetListItemsByCatForQuestionTemplate(13);
            if (IdDC == 0)
            {
                data.Item = new QuestionTemplate() {};
            }
            else
            {
                data.Item = QuestionTemplateService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(QuestionTemplate model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            QuestionTemplateModel data = new QuestionTemplateModel() { Item = model };

            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    QuestionTemplateService.SaveItem(model);
                    if (model.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                    }
                    else
                    {
                        TempData["MessageSuccess"] = "Thêm mới thành công";
                    }
                    return RedirectToAction("Index");
                }
            }
            else
            {
                data.ListService = BannersService.GetListItemsByCatForQuestionTemplate(13);
            }
            return View(data);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            QuestionTemplate model = new QuestionTemplate() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    QuestionTemplateService.DeleteItem(model);
                    TempData["MessageSuccess"] = "Xóa thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Xóa Không thành công";
                    return Json(new MsgError());
                }

            }
            catch
            {
                TempData["MessageSuccess"] = "Xóa không thành công";
                return Json(new MsgError());
            }
        }
    }
}
