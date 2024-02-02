using System;
using System.Collections.Generic;
using System.Linq;
using API.Areas.Admin.Models.CategoriesDocumentsLaw;
using API.Areas.Admin.Models.DocumentsLaw;
using API.Areas.Admin.Models.DocumentsType;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class DocumentsLawController : Controller
    {
        public IActionResult Index([FromQuery] SearchDocumentsLaw dto)
        {
            int TotalItems = 0;
            dto.ItemsPerPage = 30;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentsLawModel data = new DocumentsLawModel() { SearchData = dto };
            data.SearchData.Status = 0;
            data.ListItems = DocumentsLawService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            data.ListDocumentsType = CategoriesDocumentsLawService.GetListItems();
            return View(data);
        }

        public IActionResult Detail(int id)
        {

            DocumentsLawModel data = new DocumentsLawModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();          
            
            data.Item = DocumentsLawService.GetItemFront(id, API.Models.Settings.SecretId + ControllerName);

            if (data.Item == null)
                return RedirectToAction("Index", "Home");

            return View(data);
        }
    }
}