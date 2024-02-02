using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.ImportDBOld;
using API.Areas.Admin.Models.ImportVB;
using API.Areas.Admin.Models.Import;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using API.Areas.Admin.Models.Articles;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using API.Areas.Admin.Models.Documents;
using API.Areas.Admin.Models.DocumentsType;
using API.Areas.Admin.Models.DocumentsField;
using API.Areas.Admin.Models.DocumentsLevel;

namespace API.Controllers
{
    public class ImportController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;


        public ImportController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }


        public IActionResult ImportVB([FromQuery] SearchImportVB dto, string btn = "search")

        {
            ImportVBModel data = new ImportVBModel() { SearchData = dto };

            if (dto.Link != null)
            {
               
                data.ListItems = new List<ImportVB>();

                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(dto.Link);


                //Get Danh sách văn bản                     
                var ProductsNodes = htmlDoc.DocumentNode.SelectNodes("//table[@class='taglib-search-iterator']//tr");
                var count = 0;
                foreach (HtmlNode node in ProductsNodes)
                {
                    try
                    {

                        if(count>1)
                        {
                            try
                            {

                            
                            var childLink= node.SelectSingleNode(".//a").GetAttributeValue("href", "");
                            var item = new ImportVB()
                            {
                                IssuedDateShow = DateTime.Now.ToString("dd/MM/yyyy"),
                                EffectiveDateShow = DateTime.Now.ToString("dd/MM/yyyy"),
                                CatId = dto.CatId,
                                CreatedBy = 1,
                                ModifiedBy = 1,
                                ListFile = new List<Areas.Admin.Models.Articles.FileArticle>()
                              };

                            var htmlDoc2 = web.Load(childLink);
                            var RowNodes = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr");
                            item.Code = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[1]/td[2]").FirstOrDefault().InnerText;
                            item.Introtext = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[2]/td[2]").FirstOrDefault().InnerText;
                            item.TypeTitle = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[3]/td[2]").FirstOrDefault().InnerText;
                            item.FieldTitle = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[4]/td[2]").FirstOrDefault().InnerText;
                            item.LevelTitle = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[5]/td[2]").FirstOrDefault().InnerText;
                            item.IssuedDateShow = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[6]/td[2]").FirstOrDefault().InnerText ;
                            item.EffectiveDateShow = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[7]/td[2]").FirstOrDefault().InnerText ;
                            item.ExpriedStatus = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[8]/td[2]").FirstOrDefault().InnerText;
                            item.OrganizationName = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[9]/td[2]").FirstOrDefault().InnerText;
                            item.SignBy = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[10]/td[2]").FirstOrDefault().InnerText;                            
                            var myfile = new Areas.Admin.Models.Articles.FileArticle();
                            myfile.FilePath = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[11]/td[2]//a").FirstOrDefault().GetAttributeValue("href", "");
                            item.ListFile.Add(myfile);
                            item.FullText = htmlDoc2.DocumentNode.SelectNodes("//table[@class='fr_tbcore']//tr[13]/td[1]").FirstOrDefault().InnerText;                        
                           

                 

                            //Clone
                            var vanban = new Documents()
                            {
                                IssuedDateShow = DateTime.Now.ToString("dd/MM/yyyy"),
                                EffectiveDateShow = DateTime.Now.ToString("dd/MM/yyyy"),
                                CatId = dto.CatId,
                                Title=item.Introtext,
                                Code=item.Code,
                                Introtext=item.Introtext,
                                ExpriedStatus=item.ExpriedStatus,
                                OrganizationName=item.OrganizationName,
                                SignBy=item.SignBy,
                                ListFile=item.ListFile,
                                Status=true,
                                CreatedBy=1,
                                ModifiedBy=1,
                                FullText=item.FullText
                                
                            };
                            if(!string.IsNullOrEmpty(item.IssuedDateShow))
                            vanban.IssuedDateShow = item.IssuedDateShow;
                            if (!string.IsNullOrEmpty(item.EffectiveDateShow))
                                vanban.EffectiveDateShow = item.EffectiveDateShow;

                            //Loai vanban
                            var loaivanban = DocumentsTypeService.GetItemByTitle(item.TypeTitle);
                            if (loaivanban == null)
                            {
                                DocumentsType LoaiVanBanItem = new DocumentsType() {Title=item.TypeTitle, Alias= API.Models.MyHelper.StringHelper.UrlFriendly(item.TypeTitle),IdParent=0,Status=true,CreatedBy=1,ModifiedBy=1} ;
                                var rsLoaiVanBan = DocumentsTypeService.SaveItem(LoaiVanBanItem);
                                vanban.TypeId = rsLoaiVanBan.N;
                            }
                            else
                            {
                                vanban.TypeId = loaivanban.Id;
                            }


                            //Linh Vuc vanban
                            var linhvucvanban = DocumentsFieldService.GetItemByTitle(item.TypeTitle);
                            if (linhvucvanban == null)
                            {
                                DocumentsField LVVanBanItem = new DocumentsField() { Title = item.FieldTitle, Alias = API.Models.MyHelper.StringHelper.UrlFriendly(item.FieldTitle),CreatedBy = 1, ModifiedBy = 1 };
                                var rslvVanBan = DocumentsFieldService.SaveItem(LVVanBanItem);
                                vanban.FieldId = rslvVanBan.N;
                            }
                            else
                            {
                                vanban.FieldId = linhvucvanban.Id;
                            }

                            //Co quan ban hanh
                            var coquanbanhanh = DocumentsLevelService.GetItemByTitle(item.TypeTitle);
                            if (coquanbanhanh == null)
                            {
                                DocumentsLevel CQBHItem = new DocumentsLevel() { Title = item.LevelTitle, Alias = API.Models.MyHelper.StringHelper.UrlFriendly(item.LevelTitle)};
                                var rscqVanBan = DocumentsLevelService.SaveItem(CQBHItem);
                                vanban.LevelId = rscqVanBan.N;
                            }
                            else
                            {
                                vanban.LevelId = coquanbanhanh.Id;
                            }


                            try
                            {
                                DocumentsService.SaveItem(vanban);

                                data.ListItems.Add(item);
                            }
                            catch { }

                            }
                            catch
                            {

                            }
                        }

                        count = count + 1;
                    }
                    catch
                    {
                        throw;
                    }


                }
                //End 
            }

            
            return View(data);
        }

        public IActionResult Index([FromQuery]SearchImport dto, string btn = "search")

        {
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Thumbs");
        


            ImportModel data = new ImportModel() { SearchData = dto };
            data.ListItems = new List<Import>();

            if (dto.Link != null)
            {
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(dto.Link);

                //var path = @""+dto.Link;
                //var path= @"D:/LDLD-BCK/ldld.daklak.gov.vn/ldld.daklak.gov.vn/web/guest/tong-lien-doan-lao-dong-vn.html";
                //var htmlDoc = new HtmlDocument();
                //htmlDoc.Load(path);


                //Get Danh sách bài viết                         
                var ProductsNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='nd_detail']");

                foreach (HtmlNode node in ProductsNodes)
                {
                    try
                    {

                        var item = new Import() { PublishUp = DateTime.Now, PublishUpShow = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), Status = true, LangId = "VI", CreatedBy = 1, IdCoQuan = 1, ModifiedBy = 1 };

                        item.Str_Link = node.SelectSingleNode("./h2/a").GetAttributeValue("href", "");
                        item.Title = node.SelectSingleNode("./h2/a").InnerText;
                        var ngay = node.SelectSingleNode("./h2/span").InnerText;
                        ngay = ngay.Replace("(","");
                        ngay = ngay.Replace(")","");
                        item.PublishUpShow = ngay;
                        item.IntroText= node.SelectSingleNode("./p").InnerText;
                        if(node.SelectSingleNode("./img")!=null)
                        item.Images = node.SelectSingleNode("./img").GetAttributeValue("src", "");



                        //DownloadFile
                        if(!string.IsNullOrEmpty(item.Images))
                        {
                            string url = "https://ldld.daklak.gov.vn/"+item.Images;
                            string ticknow = DateTime.Now.Ticks.ToString() + ".jpg";
                            string file_name = Path.Combine(uploads, ticknow );
                            save_file_from_url(file_name, url);
                            item.Images = "/Thumbs/" + ticknow;
                        }


                        //Lấy chi tiết
                        try
                        {
                            var htmlDoc2 = web.Load("https://ldld.daklak.gov.vn/" + item.Str_Link);
                            item.FullText = htmlDoc2.DocumentNode.SelectSingleNode("//div[@class='journal-content-article']").InnerHtml;
                        }
                        catch
                        {
                            
                        }

                        //Clone
                        var baiviet = new ArticlesModel() { Item = new Articles() { PublishUp = DateTime.Now, PublishUpShow = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), Status = true } };
                        baiviet.Item.Title = item.Title;
                        baiviet.Item.CatId = dto.CatId;
                        baiviet.Item.Str_Link = item.Str_Link;
                        baiviet.Item.PublishUpShow = item.PublishUpShow + " 00:00:00";
                        baiviet.Item.IntroText = item.IntroText;
                        baiviet.Item.FullText = item.FullText;
                        baiviet.Item.Alias = API.Models.MyHelper.StringHelper.UrlFriendly(item.Title);
                        baiviet.Item.Status = true;
                        baiviet.Item.LangId = "Vi";
                        baiviet.Item.CreatedBy = 1;
                        baiviet.Item.ModifiedBy = 1;
                        baiviet.Item.IdCoQuan = 1;
                        baiviet.Item.Images = item.Images;
                        ArticlesService.SaveItem(baiviet.Item);


                        data.ListItems.Add(item);


                    }
                    catch
                    {
                        throw;
                    }


                }
                //End 

            }



            return View(data);
        }

        public void save_file_from_url(string file_name, string url)
        {
            byte[] content;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();

            using (BinaryReader br = new BinaryReader(stream))
            {
                content = br.ReadBytes(500000);
                br.Close();
            }
            response.Close();

            FileStream fs = new FileStream(file_name, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            try
            {
                bw.Write(content);
            }
            finally
            {
                fs.Close();
                bw.Close();
            }
        }

        public IActionResult Index2()
        {
            //string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            //ImportDBOldModel data = new ImportDBOldModel() { };
            //data.ListItems = ImportDBOldService.GetList();
            //if (data.ListItems != null && data.ListItems.Count() > 0)
            //{
            //    for (int i = 0; i < data.ListItems.Count(); i++)
            //    {
            //        string Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.ListItems[i].Title);
            //        var k = API.Areas.Admin.Models.Articles.ArticlesService.UpdateAlias(data.ListItems[i].Id, Alias);
            //    }
            //}

            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ImportDBOldModel data = new ImportDBOldModel() { };
            data.ListItems = ImportDBOldService.GetDocumentsList();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                for (int i = 0; i < data.ListItems.Count(); i++)
                {
                    string Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.ListItems[i].Title);
                    var k = API.Areas.Admin.Models.Documents.DocumentsService.UpdatAlias(data.ListItems[i].Id, Alias);
                }
            }
            return View();
        }

        public IActionResult UpdateCategory()
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ImportDBOldModel data = new ImportDBOldModel() { };
            data.ListItems = ImportDBOldService.GetCategoryList();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                for (int i = 0; i < data.ListItems.Count(); i++)
                {
                    string Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.ListItems[i].Title);
                    var k = API.Areas.Admin.Models.CategoriesArticles.CategoriesArticlesService.UpdateAlias(data.ListItems[i].Id, Alias);
                }
            }
            return View();
        }

        public IActionResult UpdateDocumentsForm()
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ImportDBOldModel data = new ImportDBOldModel() { };
            data.ListItems = ImportDBOldService.GetCategoryList();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                for (int i = 0; i < data.ListItems.Count(); i++)
                {
                    string Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.ListItems[i].Title);
                    var k = API.Areas.Admin.Models.CategoriesArticles.CategoriesArticlesService.UpdateAlias(data.ListItems[i].Id, Alias);
                }
            }
            return View();
        }

        public IActionResult UpdateDocuments()
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ImportDBOldModel data = new ImportDBOldModel() { };
            data.ListItems = ImportDBOldService.GetDocumentsList();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                for (int i = 0; i < data.ListItems.Count(); i++)
                {
                    string Alias = API.Models.MyHelper.StringHelper.UrlFriendly(data.ListItems[i].Title);
                    var k = API.Areas.Admin.Models.Documents.DocumentsService.UpdatAlias(data.ListItems[i].Id, Alias);
                }
            }
            return Json(1);
        }
    }
}