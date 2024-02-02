using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.Videos;
using API.Models;
using Newtonsoft.Json;
namespace API.Controllers
{
    public class VideosController : Controller
    {
        public IActionResult Index([FromQuery] SearchVideos dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            if(dto == null)
            {
                dto.CurrentPage = 1;
                dto.ItemsPerPage = 10;
                dto.Keyword = "";
            }

            VideosModel data = new VideosModel() { SearchData = dto };
            data.ListItems = VideosService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName,true);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new API.Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            return View(data);
        }

        public IActionResult Detail(int id)
        {
            VideosModel data = new VideosModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            data.Item = VideosService.GetItem(id, API.Models.Settings.SecretId + ControllerName);
            data.ListItems = VideosService.GetListFeatured();
            return View(data);
        }

    }
}