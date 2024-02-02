using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.USMenu;
using API.Models;
using Newtonsoft.Json;


namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class USMenuController : Controller
    {        
        public IActionResult Index([FromQuery] SearchUSMenu dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            USMenuModel data = new USMenuModel() { SearchData = dto};            
            data.ListItems = US_USERS_CATService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);            
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult SaveItem(string Id=null)
        {
            USMenuModel data = new USMenuModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());            
            data.SearchData = new SearchUSMenu() { CurrentPage = 0, ItemsPerPage = 10, Keyword = ""};
            data.ListItemsMenus = US_USERS_CATService.GetListItems(true);

            if (IdDC == 0)
            {
                data.Item = new US_USERS_CAT();
            }
            else {
                data.Item = US_USERS_CATService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            
           
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(US_USERS_CAT model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            USMenuModel data = new USMenuModel() { Item = model};            
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedBy = model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    US_USERS_CATService.SaveItem(model);
                    if (model.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Update successfully";
                    }
                    else
                    {
                        TempData["MessageSuccess"] = "Insert successfully";
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
            US_USERS_CAT item = new US_USERS_CAT() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };            
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    US_USERS_CATService.DeleteItem(item);
                    TempData["MessageSuccess"] = "Delete successfully";
                    return Json(new MsgSuccess());
                }
                else {
                    TempData["MessageError"] = "Delete unsuccessfully";
                    return Json(new MsgError());
                }
                
            }
            catch {
                TempData["MessageSuccess"] = "Delete unsuccessfully";
                return Json(new MsgError());
            }
            

        }


   
    }
}
