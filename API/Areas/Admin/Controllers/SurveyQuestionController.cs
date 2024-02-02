using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.SurveyQuestion;
using API.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using API.Areas.Admin.Models.Survey;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SurveyQuestionController : Controller
    {
        private string controllerName = "SurveyQuestionController";
        private string controllerSecret;
		
        public SurveyQuestionController(IConfiguration config)
        {
            controllerSecret = config["Security:SecretId"] + controllerName;
        }

        public IActionResult Index([FromQuery] SearchSurveyQuestion dto)
        {
            int TotalItems = 0;
            
            SurveyQuestionModel data = new SurveyQuestionModel() { SearchData = dto};
            
            
            data.ListItems = SurveyQuestionService.GetListPagination(data.SearchData, controllerSecret + HttpContext.Request.Headers["UserName"]);            
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListSurvey = SurveyService.GetListSelectItems();
            return View(data);
        }

        public IActionResult SaveItem(string Id=null, int SurveyId=0)
        {
            SurveyQuestionModel data = new SurveyQuestionModel();
            
            int IdDC = Int32.Parse(MyModels.Decode(Id, controllerSecret + HttpContext.Request.Headers["UserName"]).ToString());            
            data.SearchData = new SearchSurveyQuestion() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "", SurveyId= SurveyId };
            
            if (IdDC == 0)
            {
                data.Item = new SurveyQuestion() { SurveyId = SurveyId };
            }
            else {
                data.Item = SurveyQuestionService.GetItem(IdDC, controllerSecret + HttpContext.Request.Headers["UserName"]);
            }

            data.ListSurvey = SurveyService.GetListSelectItems();
            return View(data);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(SurveyQuestion model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, controllerSecret + HttpContext.Request.Headers["UserName"]).ToString());
            SurveyQuestionModel data = new SurveyQuestionModel() { Item = model};            
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedBy = model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic DataSave = SurveyQuestionService.SaveItem(model);
                    if (model.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                    }
                    else
                    {
                        TempData["MessageSuccess"] = "Thêm mới thành công";
                    }
                    return RedirectToAction("Index",new {SurveyId=model.SurveyId });
                }
            }
            data.ListSurvey = SurveyService.GetListSelectItems();
            return View(data);
        }
        
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            SurveyQuestion item = new SurveyQuestion() { Id = Int32.Parse(MyModels.Decode(Id, controllerSecret + HttpContext.Request.Headers["UserName"]).ToString()) };            
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);

                    dynamic DataDelete = SurveyQuestionService.DeleteItem(item);
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
            SurveyQuestion item = new SurveyQuestion() { Id = Int32.Parse(MyModels.Decode(Ids, controllerSecret + HttpContext.Request.Headers["UserName"]).ToString()) ,Status = Status};
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = SurveyQuestionService.UpdateStatus(item);
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