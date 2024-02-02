using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.Videos;
using API.Models;


namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VideosController : Controller
    {        
        public IActionResult Index([FromQuery] SearchVideos dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            VideosModel data = new VideosModel() { SearchData = dto};
            data.ListItems = VideosService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);            
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListItemsType = VideosService.GetListSelectItemsType();
            return View(data);
        }

        public IActionResult SaveItem(string Id=null)
        {
            VideosModel data = new VideosModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());            
            data.SearchData = new SearchVideos() { CurrentPage = 0, ItemsPerPage = 10, Keyword = ""};
            data.ListItemsType = VideosService.GetListSelectItemsType();
            if (IdDC == 0)
            {
                data.Item = new Videos() {Featured=true,Status= true };
            }
            else {
                data.Item = VideosService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            
           
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(Videos model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            VideosModel data = new VideosModel() { Item = model};
            data.ListItemsType = VideosService.GetListSelectItemsType();
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    if (model.Alias == null || model.Alias == "")
                    {
                        model.Alias = API.Models.MyHelper.StringHelper.UrlFriendly(model.Title);
                    }
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    VideosService.SaveItem(model);
                    if (model.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                    }
                    else {
                        TempData["MessageSuccess"] = "Thêm mới thành công";
                    }
                    return RedirectToAction("Index");
                }
            }
            return View(data);
        }
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            Videos model = new Videos() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };            
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    VideosService.DeleteItem(model);
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
            Videos item = new Videos() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = VideosService.UpdateStatus(item);
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


        [ValidateAntiForgeryToken]
        public ActionResult UpdateFeatured([FromQuery] string Ids, Boolean Featured)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            Videos item = new Videos() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Featured = Featured };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateFeatured = VideosService.UpdateFeatured(item);
                    TempData["MessageSuccess"] = "Cập nhật Nổi Bật thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật Nổi Bật Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageError"] = "Cập nhật Nổi Bật không thành công";
                return Json(new MsgError());
            }
        }

    }
}
