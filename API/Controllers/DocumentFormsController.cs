using System;
using System.Collections.Generic;
using System.Linq;
using API.Areas.Admin.Models.DocumentForms;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class DocumentFormsController : Controller
    {
        public IActionResult Index([FromQuery] SearchDocumentForms dto)
        {
            int TotalItems = 0;
            dto.ItemsPerPage = 16;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentFormsModel data = new DocumentFormsModel() { SearchData = dto };
            data.SearchData.Status = 0;
            data.ListItems = DocumentFormsService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
           
            return View(data);
        }

        public IActionResult Detail(int id)
        {

            DocumentFormsModel data = new DocumentFormsModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            data.Item = DocumentFormsService.GetItem(id, API.Models.Settings.SecretId + ControllerName);

            if (data.Item == null)
                return RedirectToAction("Index", "Home");

            return View(data);
        }
    }
}