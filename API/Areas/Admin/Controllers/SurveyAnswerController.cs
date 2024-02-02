using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.SurveyAnswer;
using API.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SurveyAnswerController : Controller
    {
        private string controllerName = "SurveyAnswerController";
        private string controllerSecret;
        public SurveyAnswerController(IConfiguration config)
        {

            controllerSecret = config["Security:SecretId"] + controllerName;
        }

        public IActionResult Index([FromQuery] SearchSurveyAnswer dto)
        {
            int TotalItems = 0;
            
            SurveyAnswerModel data = new SurveyAnswerModel() { SearchData = dto};
            
            
            data.ListItems = SurveyAnswerService.GetListPagination(data.SearchData, controllerSecret + HttpContext.Request.Headers["UserName"]);            
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            SurveyAnswer item = new SurveyAnswer() { Id = Int32.Parse(MyModels.Decode(Id, controllerSecret + HttpContext.Request.Headers["UserName"]).ToString()) };            
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);

                    dynamic DataDelete = SurveyAnswerService.DeleteItem(item);
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

        
    }
}