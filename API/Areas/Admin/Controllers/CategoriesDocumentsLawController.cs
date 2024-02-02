using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.CategoriesDocumentsLaw;
using API.Models;
using API.Models.Utilities;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesDocumentsLawController : Controller
    {
        string LangId = "VI";
        public IActionResult Index([FromQuery] SearchCategoriesDocumentsLaw dto)
        {
            LangId = HttpContext.Session.GetString("LangId");
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesDocumentsLawModel data = new CategoriesDocumentsLawModel() { SearchData = dto};
            data.ListItems = CategoriesDocumentsLawService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName,LangId);
            data.ListItemLevel = CategoriesDocumentsLawService.GetListItemLevel();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult SaveItem(string Id=null)
        {
            LangId = HttpContext.Session.GetString("LangId");
            CategoriesDocumentsLawModel data = new CategoriesDocumentsLawModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.ListItemsDanhMuc = CategoriesDocumentsLawService.GetListItems(true,LangId);
            data.ListItemType = CategoriesDocumentsLawService.GetListItemType();
            data.SearchData = new SearchCategoriesDocumentsLaw() { CurrentPage = 0, ItemsPerPage = 10, Keyword = ""};            
            if (IdDC == 0)
            {
                data.Item = new CategoriesDocumentsLaw() { Status = true };
            }
            else {
                data.Item = CategoriesDocumentsLawService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            
           
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveItem(CategoriesDocumentsLawModel model)
        {
            LangId = HttpContext.Session.GetString("LangId");
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Item.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            CategoriesDocumentsLawModel data = model;            
            if (ModelState.IsValid)
            {
                if(model.Item.Icon != null)
                {
                    var Image =
                    await FileHelpers.ProcessFormFile(model.Item.Icon, ModelState);
                    if (Image.Length > 0)
                        model.Item.Images = Image;
                }
                
                if (model.Item.Id == IdDC)
                {
                    model.Item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.Item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.Item.LangId = LangId;
                    var Obj = CategoriesDocumentsLawService.SaveItem(model.Item);
                    if (Obj.N == -2)
                    {
                        TempData["MessageError"] = "Chọn danh mục cha không hợp lệ";
                        data.ListItemsDanhMuc = CategoriesDocumentsLawService.GetListItems();
                        return View(data);
                    }
                    TempData["MessageSuccess"] = "Cập nhật thành công";
                    return RedirectToAction("Index");
                }
            }
            data.ListItemsDanhMuc = CategoriesDocumentsLawService.GetListItems();
            data.ListItemType = CategoriesDocumentsLawService.GetListItemType();
           
            return View(data);
        }
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesDocumentsLaw model = new CategoriesDocumentsLaw() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };            
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    CategoriesDocumentsLawService.DeleteItem(model);
                    TempData["MessageSuccess"] = "Xóa thành công";
                    return Json(new MsgSuccess());
                }
                else {
                    TempData["MessageError"] = "Xóa Không thành công";
                    return Json(new MsgError());
                }
                
            }
            catch {
                TempData["MessageSuccess"] = "Xóa không thành công";
                return Json(new MsgError());
            }
            

        }
		
		[ValidateAntiForgeryToken]
        public ActionResult UpdateStatus([FromQuery] string Ids, Boolean Status)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesDocumentsLaw item = new CategoriesDocumentsLaw() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = CategoriesDocumentsLawService.UpdateStatus(item);
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
