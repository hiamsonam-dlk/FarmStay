using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.Articles;
using API.Models;
using API.Areas.Admin.Models.CategoriesArticles;
using API.Models.Utilities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using API.Areas.Admin.Models.ImportDBOld;
using API.Areas.Admin.Models.DMCoQuan;
using Newtonsoft.Json;
using System.Web;
using API.Areas.Admin.Models.SYSParams;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticlesController : Controller
    {
        string LangId = "VI";
        private IHostingEnvironment _hostingEnvironment;
        public ArticlesController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }


        public IActionResult UpdateAlias()
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ImportDBOldModel data = new ImportDBOldModel() { };
            data.ListItems = ImportDBOldService.GetList();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                for (int i = 0; i < data.ListItems.Count(); i++)
                {
                    string Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.ListItems[i].Title);
                    var k = API.Areas.Admin.Models.Articles.ArticlesService.UpdateAlias(data.ListItems[i].Id, Alias);
                }
            }
            return Json(1);
        }

        public IActionResult ViewLog(string Id = null)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            ArticlesModel data = new ArticlesModel() { };
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.ListItems = ArticlesService.GetListLogArticles(IdDC, API.Models.Settings.SecretId + ControllerName);
            return View(data);
        }

        public IActionResult Index([FromQuery] SearchArticles dto,string btn="search")
        {
            int IDUSER = int.Parse(HttpContext.Request.Headers["Id"]);
            LangId = HttpContext.Session.GetString("LangId");
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int TotalItems = 0;
            dto.IdCoQuan = int.Parse(HttpContext.Request.Headers["IdCoQuan"]);
            if (btn == "excel")
            {
                //Export Excel
                var ListExcel = ArticlesService.GetListExcel(dto, API.Models.Settings.SecretId + ControllerName, LangId, IDUSER);
                var stream = new MemoryStream();
                using (var package = new ExcelPackage(stream))
                {
                    var workSheet = package.Workbook.Worksheets.Add("List");
                    workSheet.Cells.LoadFromCollection(ListExcel, true);
                    package.Save();
                }
                stream.Position = 0;
                string excelName = $"DanhSachBaiViet-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";


                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);

            }

            
         
            ArticlesModel data = new ArticlesModel() { SearchData = dto };
            data.ListItems = ArticlesService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName,LangId, IDUSER);
            data.ListItemsDanhMuc = CategoriesArticlesService.GetListItems(true,LangId, IDUSER);
            data.ListItemsAuthors = API.Areas.Admin.Models.USUsers.USUsersService.GetListItemsAuthor(4);
            data.ListItemsCreatedBy = API.Areas.Admin.Models.USUsers.USUsersService.GetListItemsAuthor(3);
            data.ListItemsStatus = ArticlesService.GetListItemsStatus();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            HttpContext.Session.SetString("STR_Action_Link_" + ControllerName, Request.QueryString.ToString());
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult GetItemLogArticle(string Id = null)
        {
            Articles Item = new Articles();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC > 0)
            {
                Item = ArticlesService.GetItemLogArticle(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return Json(Item);
        }

        public IActionResult GetItem(string Id = null)
        {
            Articles Item = new Articles();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC > 0)
            {
                Item = ArticlesService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return Json(Item);
        }

        public IActionResult SaveItem(string Id = null)
        {
            int IDUSER = int.Parse(HttpContext.Request.Headers["Id"]);
            LangId = HttpContext.Session.GetString("LangId");
            ArticlesModel data = new ArticlesModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchArticles() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            data.ListItemsDanhMuc = CategoriesArticlesService.GetListItems(true,LangId,IDUSER);
            data.ListItemsAuthors = API.Areas.Admin.Models.USUsers.USUsersService.GetListItemsAuthor(4);
            Articles Item = new Articles() { PublishUp = DateTime.Now, PublishUpShow = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") ,Status=true};
            if (IdDC > 0)
            {
                Item = ArticlesService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }

            data.Item = Item;
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveItem(Articles data, IFormFile FileItem, IFormFile FileItem_EN)
        {
            LangId = HttpContext.Session.GetString("LangId");
            ArticlesModel model = new ArticlesModel() { Item = data };
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(model.Item.Ids, API.Models.Settings.SecretId + ControllerName).ToString());

            if (ModelState.IsValid)
            {
                if (data.Alias == null || data.Alias == "")
                {
                    model.Item.Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.Title);
                }
                if (model.Item.Icon != null)
                {
                    var Image = await FileHelpers.ProcessFormFile(model.Item.Icon, ModelState);
                    if (Image.Length > 0)
                    { model.Item.Images = Image; }
                }
                if (model.Item.Id == IdDC)
                {
                    model.Item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.Item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.Item.IdCoQuan = int.Parse(HttpContext.Request.Headers["IdCoQuan"]);
                    model.Item.LangId = LangId;
                    try
                    {

                        // Them file
                        var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "CMS/Audios");
                     
                        if (FileItem != null && FileItem.Length > 0)
                        {
                            if (API.Models.Utilities.FileHelpers.CheckFileTypeAudio(FileItem.FileName))
                            {
                                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(FileItem.FileName.TrimEnd());
                                var filePath = Path.Combine(uploads, filename);
                                using (var fileStream = new FileStream(filePath, FileMode.Create))
                                {
                                    await FileItem.CopyToAsync(fileStream);
                                }
                                model.Item.AudioFile = filename;
                            }
                            else
                            {
                                TempData["MessageError"] = "Không hỗ trợ loại file " + System.IO.Path.GetExtension(FileItem.FileName);
                                model.SearchData = new SearchArticles() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
                                model.ListItemsDanhMuc = CategoriesArticlesService.GetListItems();
                                model.ListItemsAuthors = API.Areas.Admin.Models.USUsers.USUsersService.GetListItemsAuthor(4);
                                return View(data);
                            }
                        }

                        if (FileItem_EN != null && FileItem_EN.Length > 0)
                        {
                            if (API.Models.Utilities.FileHelpers.CheckFileTypeAudio(FileItem_EN.FileName))
                            {
                                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(FileItem_EN.FileName.TrimEnd());
                                var filePath = Path.Combine(uploads, filename);
                                using (var fileStream = new FileStream(filePath, FileMode.Create))
                                {
                                    await FileItem_EN.CopyToAsync(fileStream);
                                }
                                model.Item.AudioFile_EN = filename;
                            }
                            else
                            {
                                TempData["MessageError"] = "Không hỗ trợ loại file " + System.IO.Path.GetExtension(FileItem_EN.FileName);
                                model.SearchData = new SearchArticles() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
                                model.ListItemsDanhMuc = CategoriesArticlesService.GetListItems();
                                model.ListItemsAuthors = API.Areas.Admin.Models.USUsers.USUsersService.GetListItemsAuthor(4);
                                return View(data);
                            }
                        }
                        // End them file

                        ArticlesService.SaveItem(model.Item);
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                        string Str_Url = HttpContext.Session.GetString("STR_Action_Link_" + ControllerName);
                        if (Str_Url != null && Str_Url != "")
                        {
                            return Redirect("/Admin/"+ this.ControllerContext.RouteData.Values["controller"].ToString() + "/Index" + Str_Url);
                        }
                        else
                        {
                            return RedirectToAction("Index");
                        }
                    }
                    catch
                    {
                        throw;
                    }

                }
            }
            model.SearchData = new SearchArticles() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            model.ListItemsDanhMuc = CategoriesArticlesService.GetListItems();
            model.ListItemsAuthors = API.Areas.Admin.Models.USUsers.USUsersService.GetListItemsAuthor(4);
            return View(model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Articles model = new Articles() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    ArticlesService.DeleteItem(model);
                    TempData["MessageSuccess"] = "Xóa thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Xóa Không thành công";
                    return Json(new MsgError());
                }

            }
            catch
            {
                TempData["MessageSuccess"] = "Xóa không thành công";
                return Json(new MsgError());
            }


        }

        [ValidateAntiForgeryToken]
        public ActionResult UpdateStatus([FromQuery] string Ids, Boolean Status)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Articles item = new Articles() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = ArticlesService.UpdateStatus(item);
                    if (item.Status == true)
                    {
                        TempData["MessageSuccess"] = "Cập nhật Trạng Thái duyệt bài thành công";
                    }
                    else {
                        TempData["MessageSuccess"] = "Cập nhật Trạng Thái Hủy duyệt bài thành công";
                    }
                    
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật Trạng Thái duyệt bài Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật Trạng Thái không thành công";
                return Json(new MsgError());
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult UpdateStaticPage([FromQuery] string Ids, Boolean StaticPage)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Articles item = new Articles() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), StaticPage = StaticPage };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStaticPage = ArticlesService.UpdateStaticPage(item);
                    TempData["MessageSuccess"] = "Cập nhật StaticPage thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật StaticPage Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật StaticPage không thành công";
                return Json(new MsgError());
            }
        }
        [ValidateAntiForgeryToken]
        public ActionResult UpdateFeatured([FromQuery] string Ids, Boolean Featured)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Articles item = new Articles() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Featured = Featured };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateFeatured = ArticlesService.UpdateFeatured(item);
                    TempData["MessageSuccess"] = "Cập nhật Featured thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật Featured Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật Featured không thành công";
                return Json(new MsgError());
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult UpdateNotification([FromQuery] string Ids, Boolean Notification)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Articles item = new Articles() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Notification = Notification };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateFeatured = ArticlesService.UpdateNotification(item);
                    TempData["MessageSuccess"] = "Cập nhật thông báo thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật thông báo Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật thông báo không thành công";
                return Json(new MsgError());
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult UpdateFeaturedHome([FromQuery] string Ids, Boolean FeaturedHome)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Articles item = new Articles() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), FeaturedHome = FeaturedHome };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateFeatured = ArticlesService.UpdateFeaturedHome(item);
                    TempData["MessageSuccess"] = "Cập nhật Featured Home thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật Featured Home Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật Featured không thành công";
                return Json(new MsgError());
            }
        }

        public ActionResult CreateAudio([FromQuery] int Id, string Ids)
        {
            //int IdDC = Int32.Parse(MyModels.Decode(Ids, controllerSecret + HttpContext.Request.Headers["UserName"]).ToString());
            string ThongTinCoQuan = HttpContext.Session.GetString("ThongTinCoQuan");
            SYSConfig ItemCoQuan = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();
            Articles Item = ArticlesService.GetItem(Id);
            try
            {
                if (Item.Id > 0)
                {
                    string Fu = API.Models.MyHelper.StringHelper.RemoveHtmlTags(Item.FullText).Replace("\r", "").Trim();
                    if (Item.NoiDung != null && Item.NoiDung != "")
                    {
                        string Fu_EN = API.Models.MyHelper.StringHelper.RemoveHtmlTags(Item.NoiDung).Replace("\r", "").Trim();
                        Item.NoiDung = HttpUtility.HtmlDecode(Fu_EN);
                        Item.AudioFile_EN = API.Models.MyHelper.SmartVoiceService.GetFileVoiceEN(ItemCoQuan, Item);
                    }
                    Item.FullText = HttpUtility.HtmlDecode(Fu);
                    Item.AudioFile = API.Models.MyHelper.SmartVoiceService.GetFileVoice(ItemCoQuan, Item);

                    dynamic UpdateFeatured = ArticlesService.UpdateFileAudio(Item.Id, Item.AudioFile, Item.AudioFile_EN);
                    if (Item.AudioFile == "" && Item.AudioFile_EN == "")
                    {
                        return Json(new MsgError() { Msg = "Tạo file âm thanh Lỗi" });

                    }
                    else
                    {
                        if (Item.AudioFile_EN == "")
                        {
                            return Json(new MsgSuccess() { Msg = "Tạo file âm thanh bài viết tiếng việt thành công" });
                        }
                        else
                        {
                            return Json(new MsgSuccess() { Msg = "Tạo file âm thanh thành công" });
                        }

                    }

                }
                else
                {
                    return Json(new MsgError() { Msg = "Cập nhật file âm thanh thất bại. Xin vui lòng tạo lại" });
                }
            }
            catch (Exception e)
            {
                //TempData["MessageSuccess"] = "";
                return Json(new MsgError() { Msg = "Tạo file không thành công" + e.Message });
            }
        }
    }
}
