using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.DuThaoVanBan;
using API.Models;
using Newtonsoft.Json;
using API.Areas.Admin.Models.DocumentsField;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DuThaoVanBanController : Controller
    {        
        public IActionResult Index([FromQuery] SearchDuThaoVanBan dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DuThaoVanBanModel data = new DuThaoVanBanModel() { SearchData = dto};
            
            //HttpContext.Session.SetString(ControllerName + "_Search", JsonConvert.SerializeObject(data.SearchData));
            data.ListItems = DuThaoVanBanService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);            
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListDocumentsField = DocumentsFieldService.GetListSelectItems();
            return View(data);
        }

        public IActionResult SaveItem(string Id=null)
        {
            DuThaoVanBanModel data = new DuThaoVanBanModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            
            data.SearchData = new SearchDuThaoVanBan() { CurrentPage = 0, ItemsPerPage = 10, Keyword = ""};
            data.ListDocumentsField = DocumentsFieldService.GetListSelectItems();
            if (IdDC == 0)
            {
                data.Item = new DuThaoVanBan() {ExpiresDate=DateTime.Now.AddMonths(3),ExpiresDateShow= DateTime.Now.AddMonths(3).ToString("dd/MM/yyyy HH:mm:ss")};
            }
            else {
                data.Item = DuThaoVanBanService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }            
           
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(DuThaoVanBan model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            DuThaoVanBanModel data = new DuThaoVanBanModel() { Item = model};            
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedBy = model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic DataSave = DuThaoVanBanService.SaveItem(model);
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
            data.ListDocumentsField = DocumentsFieldService.GetListSelectItems();
            return View(data);
        }
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DuThaoVanBan item = new DuThaoVanBan() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };            
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);

                    dynamic DataDelete = DuThaoVanBanService.DeleteItem(item);
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
            DuThaoVanBan item = new DuThaoVanBan() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()) ,Status = Status};
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = DuThaoVanBanService.UpdateStatus(item);
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