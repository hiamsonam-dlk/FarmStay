using System;
using System.Collections.Generic;
using System.Linq;
using API.Areas.Admin.Models.Documents;
using API.Areas.Admin.Models.DocumentsType;
using API.Areas.Admin.Models.DocumentsField;
using API.Areas.Admin.Models.DocumentsLevel;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.CategoriesDocuments;

namespace API.Controllers
{
    public class DocumentsController : Controller
    {
        public IActionResult Index(string alias, int id,[FromQuery] SearchDocuments dto)
        {
            int TotalItems = 0;
            dto.ItemsPerPage = 30;
            dto.CatId = id;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentsModel data = new DocumentsModel() { SearchData = dto };
            data.SearchData.Status = -1;


            data.ListItems = DocumentsService.GetListPaginationStatus(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.Category = CategoriesDocumentsService.GetItem(id);

            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListDocumentsCategories = CategoriesDocumentsService.GetListItems();
            data.ListDocumentsType = DocumentsTypeService.GetListSelectItems();
            data.ListDocumentsField = DocumentsFieldService.GetListSelectItems();
            data.ListDocumentsLevel = DocumentsLevelService.GetListSelectItems();
            return View(data);
        }

        public IActionResult Detail(int id)
        {

            DocumentsModel data = new DocumentsModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();          
            data.Item = DocumentsService.GetItemFront(id, API.Models.Settings.SecretId + ControllerName);
            data.Category = CategoriesDocumentsService.GetItem(data.Item.CatId);

            if (data.Item == null)
                return RedirectToAction("Index", "Home");

            return View(data);
        }
    }
}