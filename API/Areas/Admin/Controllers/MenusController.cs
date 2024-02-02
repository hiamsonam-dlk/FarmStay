using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.Menus;
using API.Models;
using Newtonsoft.Json;
using API.Areas.Admin.Models.Articles;
using API.Areas.Admin.Models.CategoriesArticles;
using API.Areas.Admin.Models.DMCoQuan;
using API.Areas.Admin.Models.ProductsCategories;
using API.Areas.Admin.Models.CategoriesDocuments;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenusController : Controller
    {

        string LangId = "VI";    
        public MenusController()
        {

        }
        public IActionResult Index([FromQuery] SearchMenus dto)
        {

            LangId = HttpContext.Session.GetString("LangId");
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            MenusModel data = new MenusModel() { SearchData = dto};
            data.ListItems = MenusService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName,LangId);
            data.ListDMCoQuan = DMCoQuanService.GetListByLoaiCoQuan(0,1);
            data.ListPosition = MenusService.GetListPositon();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult SaveItem(string Id=null, int IdCoQuan = 1,int Position=0)
        {
            LangId = HttpContext.Session.GetString("LangId");
            MenusModel data = new MenusModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());            
            data.SearchData = new SearchMenus() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "",IdCoQuan = IdCoQuan };
            data.ListItemsArticle = ArticlesService.GetListStaticArticle();
            data.ListType = MenusService.GetListType();
            data.ListCategoriesArticles = CategoriesArticlesService.GetList(true,LangId);
            data.ListCategoriesProducts = CategoriesDocumentsService.GetList();
            data.ListItemsMenus = MenusService.GetListItems(true,IdCoQuan,Position,LangId);
            data.ListPosition = MenusService.GetListPositon();

            if (IdDC == 0)
            {
                data.Item = new Menus();
                if (Position != 0)
                    data.Item.Position = Position;
            }
            else {
                data.Item = MenusService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);

            }

            
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(MenusModel model)
        {
            LangId = HttpContext.Session.GetString("LangId");
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Item.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            MenusModel data = model;            
            if (ModelState.IsValid)
            {
                if (model.Item.Id == IdDC)
                {
                    
                    model.Item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.Item.LangId = LangId;
                    MenusService.SaveItem(model.Item);
                    if (model.Item.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                    }
                    else {
                        TempData["MessageSuccess"] = "Thêm mới thành công";
                    }
                    return RedirectToAction("Index", new { IdCoQuan = model.Item.IdCoQuan,Position=model.Item.Position });
                }
            }
            data.ListItemsArticle = ArticlesService.GetListStaticArticle();
            data.ListType = MenusService.GetListType();
            data.ListCategoriesArticles = CategoriesArticlesService.GetList();
            data.ListCategoriesProducts = CategoriesDocumentsService.GetList();
            data.ListPosition = MenusService.GetListPositon();
            return View(data);
        }
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            Menus model = new Menus() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };            
            try
            {
                if (model.Id > 0)
                {
                    
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    MenusService.DeleteItem(model);
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
            Menus item = new Menus() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = MenusService.UpdateStatus(item);
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
