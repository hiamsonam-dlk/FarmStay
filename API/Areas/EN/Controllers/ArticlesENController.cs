using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using API.Areas.Admin.Models.Articles;
using API.Areas.Admin.Models.CategoriesArticles;
using API.Areas.Admin.Models.DMCoQuan;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace API.Areas.EN.Controllers
{
    [Area("EN")]
    public class ArticlesENController : Controller
    {
        private string controllerName = "ArticlesENController";
        private string controllerSecret;
        private IConfiguration Configuration;
        public ArticlesENController(IConfiguration config)
        {
            controllerSecret = config["Security:SecretId"] + controllerName;
            Configuration = config;
        }
        public IActionResult Index(string alias)
        {
            return View();
        }

        //[ValidateAntiForgeryToken]
        //public ActionResult GetAudio([FromQuery] string Ids, int Id)
        //{

        //    DMCoQuan ItemCoQuan = JsonConvert.DeserializeObject<DMCoQuan>(HttpContext.Session.GetString("ThongTinCoQuan"));
        //    string Msg = "";
        //    int IdDC = Int32.Parse(MyModels.Decode(Ids, controllerSecret).ToString());
        //    Articles item = new Articles() { Id = 0 };
        //    if (IdDC == Id && IdDC > 0)
        //    {
        //        item = ArticlesService.GetItem(IdDC);
        //    }

        //    try
        //    {
        //        if (item.Id > 0)
        //        {

        //            try
        //            {
        //                string Fu = API.Models.MyHelper.StringHelper.RemoveHtmlTags(item.FullText).Replace("\r", "").Trim();
        //                if (item.NoiDung != null && item.NoiDung != "")
        //                {
        //                    string Fu_EN = API.Models.MyHelper.StringHelper.RemoveHtmlTags(item.NoiDung).Replace("\r", "").Trim();
        //                    item.NoiDung = HttpUtility.HtmlDecode(Fu_EN);
        //                }

        //                item.FullText = HttpUtility.HtmlDecode(Fu);


        //                item.FileItem = API.Models.MyHelper.SmartVoiceService.GetFileVoice(ItemCoQuan, item);
        //                item.FileItem_EN = API.Models.MyHelper.SmartVoiceService.GetFileVoiceEN(ItemCoQuan, item);

        //                dynamic UpdateFeatured = ArticlesService.UpdateFileAudio(item.Id, item.FileItem, item.FileItem_EN);
        //                if (item.FileItem == "" && item.FileItem_EN == "")
        //                {
        //                    return Json(new MsgError() { Msg = "Tạo file âm thanh Lỗi" });

        //                }
        //                else
        //                {
        //                    if (item.FileItem_EN == "")
        //                    {
        //                        return Json(new MsgSuccess() { Msg = "Tạo file âm thanh bài viết tiếng Việt thành công" });
        //                    }
        //                    else
        //                    {
        //                        return Json(new MsgSuccess() { Msg = "Tạo file âm thanh thành công" });
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Msg = "Tạo file âm thanh Không thành công";
        //                return Json(new MsgError() { Msg = Msg, Data = ItemCoQuan.Code });
        //            }

        //        }
        //        else
        //        {
        //            Msg = "Tạo file âm thanh Không thành công";
        //            return Json(new MsgError() { Msg = Msg });
        //        }
        //    }
        //    catch
        //    {
        //        Msg = "Cập nhật Like không thành công";
        //        return Json(new MsgError() { Msg = Msg });
        //    }
        //}


        public IActionResult GetByCat(string alias,int id, [FromQuery] SearchArticles dto)
        {
            int TotalItems = 0;
            int IdCoQuan = 1;
            if (HttpContext.Session.GetString("IdCoQuan") != null && HttpContext.Session.GetString("IdCoQuan") != "") {
                IdCoQuan = int.Parse(HttpContext.Session.GetString("IdCoQuan"));
            }
            
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesArticles categories = CategoriesArticlesService.GetItem(id, API.Models.Settings.SecretId + ControllerName);
            
            dto.CatId = id;
            dto.IdCoQuan = IdCoQuan;
            dto.ShowStartDate = "01/01/2000";
            dto.Status = 1;
            dto.ItemsPerPage = 15;
            ArticlesModel data = new ArticlesModel() { SearchData = dto, Categories = categories  };
            data.ListItems = ArticlesService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);



            //data.ListItemsDanhMuc = CategoriesArticlesService.GetListItems();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult GetListChildCat(string alias, int id, [FromQuery] SearchArticles dto)
        {
            
            int IdCoQuan = 1;
            if (HttpContext.Session.GetString("IdCoQuan") != null && HttpContext.Session.GetString("IdCoQuan") != "")
            {
                IdCoQuan = int.Parse(HttpContext.Session.GetString("IdCoQuan"));
            }

            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            CategoriesArticles categories = CategoriesArticlesService.GetItem(id, API.Models.Settings.SecretId + ControllerName);

            dto.CatId = id;
            dto.IdCoQuan = IdCoQuan;
            dto.ShowStartDate = "01/01/2010";
            ArticlesModel data = new ArticlesModel() { SearchData = dto, Categories = categories };
          
            return View(data);
        }


        public IActionResult Detail(string alias,int id)
        {
            ArticlesModel data = new ArticlesModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            data.SearchData = new SearchArticles() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            data.ListItemsDanhMuc = CategoriesArticlesService.GetListItems();
            data.Item = ArticlesService.GetItem(id, API.Models.Settings.SecretId + ControllerName);
            CategoriesArticles categories = CategoriesArticlesService.GetItem(data.Item.CatId);
            var hit = ArticlesService.UpdateHit(id);

            data.Categories = categories;
            if (categories.Id != 0) {
                data.ListItems = ArticlesService.GetListRelativeNews(alias, categories.Id,"EN");
            }
            
            return View(data);
        }


        public IActionResult GetDetailJS(int id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            var Item = ArticlesService.GetItem(id, API.Models.Settings.SecretId + ControllerName); 
            return Json(Item);
        }


        public IActionResult GetListByCatSimple([FromQuery]int CatId)
        {
            var list = ArticlesService.GetListByCatSimple(CatId, 10);
            return Json(list);
           
        }
    }
}