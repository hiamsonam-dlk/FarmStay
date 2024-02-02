using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.Banners;
using API.Areas.Admin.Models.BannersCategories;
using API.Models;
using Newtonsoft.Json;
using API.Areas.Admin.Models.DMCoQuan;
using API.Areas.Admin.Models.CategoriesArticles;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannersController : Controller
    {
        string LangId = "VI";
        public IActionResult Index([FromQuery] SearchBanners dto)
        {
            LangId = HttpContext.Session.GetString("LangId");
            int TotalItems = 0;
            if (dto.IdCoQuan == 0) { dto.IdCoQuan = 1; }
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            BannersModel data = new BannersModel() { SearchData = dto};
            data.ListItems = BannersService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName,LangId);            
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.ListDMCoQuan = DMCoQuanService.GetListByLoaiCoQuan(0, 1);
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListItemsCategories = BannersCategoriesService.GetListSelectItems();
            return View(data);
        }

        public IActionResult SaveItem(string Id=null,int CatId = 0,int IdCoQuan = 1)
        {
            LangId = HttpContext.Session.GetString("LangId");
            BannersModel data = new BannersModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());            
            data.SearchData = new SearchBanners() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "", CatId  = CatId, IdCoQuan = IdCoQuan};
            data.ListItemsCategories = BannersCategoriesService.GetListSelectItems();
            data.ListItemsArticlesCategories= CategoriesArticlesService.GetListItems(true, LangId);
            data.ListDMCoQuan = DMCoQuanService.GetListByLoaiCoQuan(0, 1);
            if (IdDC == 0)
            {
                data.Item = new Banners() { CatId = CatId ,Status=true};
            }
            else {
                data.Item = BannersService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            
           
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(Banners model)
        {
            LangId = HttpContext.Session.GetString("LangId");
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());            
            BannersModel data = new BannersModel() { Item = model};
            
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.LangId = LangId;
                    BannersService.SaveItem(model);
                    if (model.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                    }
                    else
                    {
                        TempData["MessageSuccess"] = "Thêm mới thành công";
                    }
                    return RedirectToAction("Index", new { CatId = model.CatId, IdCoQuan = model.IdCoQuan });
                }
            }
            else {
                data.ListItemsCategories = BannersCategoriesService.GetListSelectItems();
                data.ListDMCoQuan = DMCoQuanService.GetListByLoaiCoQuan(0, 1);
            }
            return View(data);
        }
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            Banners model = new Banners() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };            
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    BannersService.DeleteItem(model);
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
            Banners item = new Banners() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = BannersService.UpdateStatus(item);
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
