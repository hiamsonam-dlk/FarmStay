using System;
using System.Collections.Generic;
using System.Linq;
using API.Areas.Admin.Models.DocumentRefers;
using API.Areas.Admin.Models.DocumentRefersCategories;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class DocumentRefersController : Controller
    {
        public IActionResult Index([FromQuery] SearchDocumentRefers dto)
        {
            int TotalItems = 0;
            dto.ItemsPerPage = 30;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentRefersModel data = new DocumentRefersModel() { SearchData = dto };
            data.SearchData.Status = 0;
            data.ListItems = DocumentRefersService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.ListDocumentsCategories = DocumentRefersCategoriesService.GetListSelectItems();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
           
            return View(data);
        }
    }
}