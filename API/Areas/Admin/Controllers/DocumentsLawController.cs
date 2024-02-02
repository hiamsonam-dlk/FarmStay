using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.DocumentsLaw;
using API.Areas.Admin.Models.DocumentsType;
using API.Models;
using Newtonsoft.Json;
using API.Areas.Admin.Models.CategoriesDocumentsLaw;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DocumentsLawController : Controller
    {
        public IActionResult Index([FromQuery] SearchDocumentsLaw dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentsLawModel data = new DocumentsLawModel() { SearchData = dto };
            data.ListItems = DocumentsLawService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListDocumentsType = CategoriesDocumentsLawService.GetListItems();
            data.ListItemsStatus = DocumentsLawService.GetListItemsStatus();
            return View(data);
        }

        public IActionResult SaveItem(string Id = null)
        {
            DocumentsLawModel data = new DocumentsLawModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchDocumentsLaw() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            data.ListDocumentsType = CategoriesDocumentsLawService.GetListItems();
            DocumentsLaw Item = new DocumentsLaw() {
                IssuedDateShow = DateTime.Now.ToString("dd/MM/yyyy"),
                Year=DateTime.Now.Year
            };
            if (IdDC > 0)
            {
                Item = DocumentsLawService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
          
            data.Item = Item;

            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(DocumentsLaw model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            DocumentsLawModel data = new DocumentsLawModel() { Item = model };          
            data.ListDocumentsType = DocumentsTypeService.GetListSelectItems();
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    try
                    {
                        DocumentsLawService.SaveItem(model);
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
                    catch
                    {
                        TempData["MessageError"] = "Lỗi khi lưu dữ liệu";
                    }

                }
            }
            return View(data);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentsLaw model = new DocumentsLaw() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    DocumentsLawService.DeleteItem(model);
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

        [ValidateAntiForgeryToken]
        public ActionResult UpdateStatus([FromQuery] string Ids, Boolean Status)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentsLaw item = new DocumentsLaw() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = DocumentsLawService.UpdateStatus(item);
                    TempData["MessageSuccess"] = "Cập nhật Trạng Thái thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật Trạng Thái Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật Trạng Thái không thành công";
                return Json(new MsgError());
            }
        }
    }
}
