using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Ablums;
using API.Areas.Admin.Models.CategoriesAblums;
using API.Models;
using EnvDTE;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index([FromQuery] SearchCategoriesAblums dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesAblumsModel data = new CategoriesAblumsModel() { SearchData = dto };
            data.ListItemsAlbums = AblumsService.GetListPagination(new SearchAblums(),true);
            List<CategoriesAblums> ListCatAblum = new List<CategoriesAblums>();
            ListCatAblum = CategoriesAblumsService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName,true);



            for (int i = 0; i < ListCatAblum.Count(); i++)
            {
                List<Ablums> tmp = new List<Ablums>();
                for (int j = 0; j < data.ListItemsAlbums.Count(); j++)
                {
                    if (ListCatAblum[i].Id == data.ListItemsAlbums[j].CatId)
                    {
                        tmp.Add(data.ListItemsAlbums[j]);
                    }
                }
                ListCatAblum[i].ListItemsAlbums = tmp;
            }

            data.ListItems = ListCatAblum;
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public ActionResult Detail(int Id) {

            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesAblumsModel data = new CategoriesAblumsModel() { };
            data.ListItemsAlbums = AblumsService.GetListByParrent(Id);
            data.Item = CategoriesAblumsService.GetItem(Id);
            List<CategoriesAblums> ListCatAblum = new List<CategoriesAblums>();
            
            List<Ablums> tmp = new List<Ablums>();
            for (int j = 0; j < data.ListItemsAlbums.Count(); j++)
            {
                if (data.Item.Id == data.ListItemsAlbums[j].CatId)
                {
                    tmp.Add(data.ListItemsAlbums[j]);
                }
            }
            data.Item.ListItemsAlbums = tmp;

            data.ListItems = ListCatAblum;

            return View(data);
        }
    }
}