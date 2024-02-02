using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Articles;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace API.Areas.Admin.Models.Articles
{
    public class ArticlesService
    {
        public static dynamic UpdateFileAudio(int Id, string AudioFile, string AudioFile_EN)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@AudioFile", "@AudioFile_EN" },
            new object[] { "UpdateFileAudio", Id, AudioFile, AudioFile_EN });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        //public static List<Articles> GetList(string LangId = "VI")
        //{

        //    string str_sql = "GetList";           
        //    var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
        //        new string[] { "@flag","@LangId" },
        //        new object[] { str_sql,LangId});
        //    if (tabl == null)
        //    {
        //        return new List<Articles>();
        //    }
        //    else
        //    {
        //        return (from r in tabl.AsEnumerable()
        //                select new Articles
        //                {
        //                    Id = (int)r["Id"],
        //                    Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
        //                    CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
        //                    Params= (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"])

        //                }).ToList();
        //    }


        //}

        public static List<ArticlesExcel> GetListExcel(SearchArticles dto, string SecretId, string LangId = "VI", int UserId = 0)
        {
            dto.CurrentPage = 1;
            dto.ItemsPerPage = 99999;
            if (dto.Keyword == null)
            {
                dto.Keyword = "";
            }
            string StartDate = DateTime.ParseExact(dto.ShowStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string EndDate = DateTime.ParseExact(dto.ShowEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string str_sql = "GetListPagination";
            Boolean Status = true;

            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@CatId", "@IdCoQuan", "@AuthorId", "@StartDate", "@EndDate", "@CreatedBy", "@Status", "@LangId", "@UserId" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.CatId, dto.IdCoQuan, dto.AuthorId, StartDate, EndDate, dto.CreatedBy, Status, LangId, UserId });
            if (tabl == null)
            {
                return new List<ArticlesExcel>();
            }
            else
            {
                var list = (from r in tabl.AsEnumerable()
                            select new ArticlesExcel
                            {

                                Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                                PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss")),
                                PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                            }).ToList();

                list = list.OrderBy(x => x.PublishUp).ToList();
                return list;

            }


        }

        public static List<Articles> GetListPagination(SearchArticles dto, string SecretId, string LangId = "VI", int UserId = 0)
        {
            if (dto.CurrentPage <= 0)
            {
                dto.CurrentPage = 1;
            }
            if (dto.ItemsPerPage <= 0)
            {
                dto.ItemsPerPage = 15;
            }
            if (dto.Keyword == null)
            {
                dto.Keyword = "";
            }
            string StartDate = DateTime.ParseExact(dto.ShowStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string EndDate = DateTime.ParseExact(dto.ShowEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string str_sql = "GetListPagination_Status";
            Boolean Status = true;
            if (dto.Status == -1)
            {
                str_sql = "GetListPagination";
            }
            else if (dto.Status == 0)
            {
                Status = false;
            }
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@CatId", "@StartDate", "@EndDate", "@Status", "@LangId", "@UserId" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.CatId, StartDate, EndDate, Status, LangId, UserId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                            MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                            NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
                            Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Status = (Boolean)((r["Status"] == System.DBNull.Value) ? 0 : r["Status"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                            AudioFile_EN = (string)((r["AudioFile_EN"] == System.DBNull.Value) ? null : r["AudioFile_EN"]),
                            AudioFile = (string)((r["AudioFile"] == System.DBNull.Value) ? null : r["AudioFile"]),
                            PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss")),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],

                        }).ToList();
            }

        }

        public static List<SelectListItem> GetListItemsStatus()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "--- Trạng Thái ---", Value = "-1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Chưa Duyệt", Value = "0" }));
            ListItems.Insert(2, (new SelectListItem { Text = "Đã Duyệt", Value = "1" }));
            return ListItems;
        }

        public static List<Articles> GetListPaginationByCat(string alias, SearchArticles dto, string SecretId, string LangId = "VI")
        {
            if (dto.CurrentPage <= 0)
            {
                dto.CurrentPage = 1;
            }
            if (dto.ItemsPerPage <= 0)
            {
                dto.ItemsPerPage = 15;
            }
            if (dto.Keyword == null)
            {
                dto.Keyword = "";
            }
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@CatAlias", "@LangId" },
                new object[] { "GetListPaginationByCat", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, alias, LangId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                            MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                            NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                            Id = (int)r["Id"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
                            Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Status = (Boolean)((r["Status"] == System.DBNull.Value) ? 0 : r["Status"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                            PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss")),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"]
                        }).ToList();
            }


        }


        public static List<Articles> GetListArticle_Files(int Id)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@Id" }, new object[] { "GetListArticle_Files", Id });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            CatId = (int)r["IdArticle"],
                            Images = (string)((r["FileName"] == System.DBNull.Value) ? null : r["FileName"])
                        }).ToList();
            }

        }
        public static List<Articles> GetListLogArticles(int Id, string SecretId)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LogArticles",
                new string[] { "@flag", "@Id" }, new object[] { "GetList", Id });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            Title = (string)r["Title"],
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            CatId = (int)r["CatId"],
                            Category = (string)r["Category"],
                            AuthorId = (int)((r["AuthorId"] == System.DBNull.Value) ? 0 : r["AuthorId"]),
                            AuthorName = (string)((r["AuthorName"] == System.DBNull.Value) ? null : r["AuthorName"]),
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                            Status = (Boolean)r["Status"],
                            CreatedBy = (int?)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                            CreatedByName = (string)((r["CreatedByName"] == System.DBNull.Value) ? "" : r["CreatedByName"]),
                            CreatedByFullName = (string)((r["CreatedByFullName"] == System.DBNull.Value) ? "" : r["CreatedByFullName"]),
                            ModifiedBy = (int?)((r["ModifiedBy"] == System.DBNull.Value) ? null : r["ModifiedBy"]),
                            CreatedDate = (DateTime?)((r["CreatedDate"] == System.DBNull.Value) ? null : r["CreatedDate"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now : r["PublishUp"]),
                            PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy")),
                            ModifiedDate = (DateTime?)((r["ModifiedDate"] == System.DBNull.Value) ? null : r["ModifiedDate"]),
                            Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                            Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                            Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                            Language = (string)((r["Language"] == System.DBNull.Value) ? null : r["Language"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            FeaturedHome = (Boolean)((r["FeaturedHome"] == System.DBNull.Value) ? null : r["FeaturedHome"]),
                            StaticPage = (Boolean)((r["StaticPage"] == System.DBNull.Value) ? null : r["StaticPage"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                        }).ToList();
            }

        }
        public static List<SelectListItem> GetListItems(Boolean Selected = true, string LangId = "VI")
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@Selected", "@LangId" }, new object[] { "GetList", Convert.ToDecimal(Selected), LangId });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn bài đăng", Value = "0" }));
            return ListItems;

        }
        public static List<SelectListItem> GetListStaticArticle(Boolean Selected = true, string LangId = "VI")
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@Selected", "@LangId" }, new object[] { "GetListStaticArticle", Convert.ToDecimal(Selected), LangId });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn bài đăng", Value = "0" }));
            return ListItems;

        }




        public static List<Articles> GetList(Boolean Selected = true, string LangId = "VI")
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@Selected", "@LangId" }, new object[] { "GetList", Convert.ToDecimal(Selected), LangId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            Title = (string)r["Title"],
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            CatId = (int)r["CatId"],
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                            Status = (Boolean)r["Status"],
                            CreatedBy = (int?)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                            ModifiedBy = (int?)((r["ModifiedBy"] == System.DBNull.Value) ? null : r["ModifiedBy"]),
                            CreatedDate = (DateTime?)((r["CreatedDate"] == System.DBNull.Value) ? null : r["CreatedDate"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now : r["PublishUp"]),
                            ModifiedDate = (DateTime?)((r["ModifiedDate"] == System.DBNull.Value) ? null : r["ModifiedDate"]),
                            Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                            Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                            Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                            Language = (string)((r["Language"] == System.DBNull.Value) ? null : r["Language"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            FeaturedHome = (Boolean)((r["FeaturedHome"] == System.DBNull.Value) ? null : r["FeaturedHome"]),
                            StaticPage = (Boolean)((r["StaticPage"] == System.DBNull.Value) ? null : r["StaticPage"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                            Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                            Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                            Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                            //TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }

        }

        public static List<Articles> GetListRelativeNews(string Alias, int CatId, string LangId = "VI")
        {
            if (Alias == null || Alias == "" || CatId == null)
            {
                return new List<Articles>();
            }
            else
            {
                DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@Alias", "@CatId", "@LangId" }, new object[] { "GetListRelativeNews", Alias, CatId, LangId });
                if (tabl == null)
                {
                    return new List<Articles>();
                }
                else
                {
                    return (from r in tabl.AsEnumerable()
                            select new Articles
                            {
                                Id = (int)r["Id"],
                                Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                                Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                                MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                                NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                                IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                                CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
                                Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                                Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                                Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                                Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                                Status = (Boolean)((r["Status"] == System.DBNull.Value) ? 0 : r["Status"]),
                                PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                                PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss"))
                            }).ToList();
                }
            }


        }
        public static List<Articles> GetListHot(int IdCoQuan = 0, int Limit = 5, string LangId = "VI")
        {
            if (IdCoQuan == 0)
            {
                IdCoQuan = 1;
            }
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@IdCoQuan", "@Limit", "@LangId" }, new object[] { "GetListHot", IdCoQuan, Limit, LangId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                            MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                            NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
                            Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Status = (Boolean)((r["Status"] == System.DBNull.Value) ? 0 : r["Status"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                            PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss"))
                        }).ToList();
            }

        }

        public static List<Articles> GetListNotification(SearchArticles dto, string LangId = "VI")
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@LangId" }, new object[] { "GetListNotification", dto.CurrentPage, dto.ItemsPerPage, LangId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                            MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                            NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
                            Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Status = (Boolean)((r["Status"] == System.DBNull.Value) ? 0 : r["Status"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                            PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss"))
                        }).ToList();
            }

        }



        public static List<Articles> GetListNew(int CatId = 0, int Limit = 5, int IdCoQuan = 1, string LangId = "VI")
        {


            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@CatId", "@IdCoQuan", "@Limit", "@LangId" }, new object[] { "GetListNew", CatId, IdCoQuan, Limit, LangId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles
                        {
                            Id = (int)r["Id"],
                            Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                            MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                            NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                            CatId = (int)((r["CatId"] == System.DBNull.Value) ? 0 : r["CatId"]),
                            Category = (string)((r["Category"] == System.DBNull.Value) ? "" : r["Category"]),
                            Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                            Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Status = (Boolean)((r["Status"] == System.DBNull.Value) ? 0 : r["Status"]),
                            PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                            PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss"))
                        }).ToList();
            }

        }

        public static List<Articles> GetListByCatSimple(int CatId = 0, int Limit = 5, string LangId = "VI")
        {


            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
                new string[] { "@flag", "@CatId", "@Limit", "@LangId" }, new object[] { "GetListByCatSimple", CatId, Limit, LangId });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                var list = (from r in tabl.AsEnumerable()
                            select new Articles
                            {
                                Id = (int)r["Id"],
                                Title = (string)r["Title"],
                                Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                                Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                                PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now : r["PublishUp"]),
                                Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                                Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"])
                            }).ToList();

                foreach (var Item in list)
                {
                    if (Item.Str_ListFile != null && Item.Str_ListFile != "")
                    {
                        Item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(Item.Str_ListFile);
                    }
                }
                return list;
            }

        }


        public static Articles GetItem(decimal Id, string SecretId = null, string LangId = "VI")
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@LangId" }, new object[] { "GetItem", Id, LangId });
            Articles Item = (from r in tabl.AsEnumerable()
                             select new Articles
                             {
                                 Id = (int)r["Id"],
                                 Title = (string)r["Title"],
                                 Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                                 MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                                 NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                                 Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),
                                 Str_Link = (string)((r["Str_Link"] == System.DBNull.Value) ? null : r["Str_Link"]),
                                 Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                                 CatId = (int)r["CatId"],
                                 IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                                 FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                                 Status = (Boolean)r["Status"],
                                 CreatedBy = (int?)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                 ModifiedBy = (int?)((r["ModifiedBy"] == System.DBNull.Value) ? null : r["ModifiedBy"]),
                                 CreatedDate = (DateTime?)((r["CreatedDate"] == System.DBNull.Value) ? null : r["CreatedDate"]),
                                 PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                                 PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy HH:mm:ss")),
                                 ModifiedDate = (DateTime?)((r["ModifiedDate"] == System.DBNull.Value) ? null : r["ModifiedDate"]),
                                 Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                                 Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                                 Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                                 Language = (string)((r["Language"] == System.DBNull.Value) ? null : r["Language"]),
                                 Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                                 Notification = (Boolean)((r["Notification"] == System.DBNull.Value) ? null : r["Notification"]),
                                 StaticPage = (Boolean)((r["StaticPage"] == System.DBNull.Value) ? null : r["StaticPage"]),
                                 Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                                 Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                                 Author = (string)((r["Author"] == System.DBNull.Value) ? null : r["Author"]),
                                 Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                                 Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                 IdCoQuan = (int)((r["IdCoQuan"] == System.DBNull.Value) ? 0 : r["IdCoQuan"]),
                                 AuthorId = (int)((r["AuthorId"] == System.DBNull.Value) ? 0 : r["AuthorId"]),
                                 Ids = MyModels.Encode((int)r["Id"], SecretId),
                                 Hit = (int)((r["Hit"] == System.DBNull.Value) ? 0 : r["Hit"]),
                                 AudioFile = (string)((r["AudioFile"] == System.DBNull.Value) ? null : r["AudioFile"]),
                                 AudioFile_EN = (string)((r["AudioFile_EN"] == System.DBNull.Value) ? null : r["AudioFile_EN"]),
                                 ExternalLink = (string)((r["ExternalLink"] == System.DBNull.Value) ? null : r["ExternalLink"])
                             }).FirstOrDefault();
            if (Item.Str_ListFile != null && Item.Str_ListFile != "")
            {
                Item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(Item.Str_ListFile);
            }
            if (Item.Str_Link != null && Item.Str_Link != "")
            {
                Item.ListLinkArticle = JsonConvert.DeserializeObject<List<LinkArticle>>(Item.Str_Link);
            }
            return Item;
        }

        public static Articles GetItemLogArticle(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LogArticles",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            Articles Item = (from r in tabl.AsEnumerable()
                             select new Articles
                             {
                                 Id = (int)r["Id"],
                                 Title = (string)r["Title"],
                                 Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),
                                 Str_Link = (string)((r["Str_Link"] == System.DBNull.Value) ? null : r["Str_Link"]),
                                 Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                                 CatId = (int)r["CatId"],
                                 IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                                 FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                                 Status = (Boolean)r["Status"],
                                 CreatedBy = (int?)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                 ModifiedBy = (int?)((r["ModifiedBy"] == System.DBNull.Value) ? null : r["ModifiedBy"]),
                                 CreatedDate = (DateTime?)((r["CreatedDate"] == System.DBNull.Value) ? null : r["CreatedDate"]),
                                 PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                                 PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy")),
                                 ModifiedDate = (DateTime?)((r["ModifiedDate"] == System.DBNull.Value) ? null : r["ModifiedDate"]),
                                 Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                                 Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                                 Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                                 Language = (string)((r["Language"] == System.DBNull.Value) ? null : r["Language"]),
                                 Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                                 StaticPage = (Boolean)((r["StaticPage"] == System.DBNull.Value) ? null : r["StaticPage"]),
                                 Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                                 Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                                 Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                                 IdCoQuan = (int)((r["IdCoQuan"] == System.DBNull.Value) ? 0 : r["IdCoQuan"]),
                                 AuthorId = (int)((r["AuthorId"] == System.DBNull.Value) ? 0 : r["AuthorId"]),
                                 Ids = MyModels.Encode((int)r["Id"], SecretId)
                             }).FirstOrDefault();
            if (Item.Str_ListFile != null && Item.Str_ListFile != "")
            {
                Item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(Item.Str_ListFile);
            }
            if (Item.Str_Link != null && Item.Str_Link != "")
            {
                Item.ListLinkArticle = JsonConvert.DeserializeObject<List<LinkArticle>>(Item.Str_Link);
            }
            return Item;
        }
        public static Articles GetItemByAlias(string Alias, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Alias" }, new object[] { "GetItemByAlias", Alias });
            Articles Item = (from r in tabl.AsEnumerable()
                             select new Articles
                             {
                                 Id = (int)r["Id"],
                                 Title = (string)r["Title"],
                                 Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                                 MoDau = (string)((r["MoDau"] == System.DBNull.Value) ? null : r["MoDau"]),
                                 NoiDung = (string)((r["NoiDung"] == System.DBNull.Value) ? null : r["NoiDung"]),
                                 Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                                 Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),
                                 Str_Link = (string)((r["Str_Link"] == System.DBNull.Value) ? null : r["Str_Link"]),
                                 CatId = (int)r["CatId"],
                                 IntroText = (string)((r["IntroText"] == System.DBNull.Value) ? null : r["IntroText"]),
                                 FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                                 Status = (Boolean)r["Status"],
                                 CreatedBy = (int?)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                 ModifiedBy = (int?)((r["ModifiedBy"] == System.DBNull.Value) ? null : r["ModifiedBy"]),
                                 CreatedDate = (DateTime?)((r["CreatedDate"] == System.DBNull.Value) ? null : r["CreatedDate"]),
                                 PublishUp = (DateTime)((r["PublishUp"] == System.DBNull.Value) ? null : r["PublishUp"]),
                                 PublishUpShow = (string)((r["PublishUp"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["PublishUp"]).ToString("dd/MM/yyyy")),
                                 ModifiedDate = (DateTime?)((r["ModifiedDate"] == System.DBNull.Value) ? null : r["ModifiedDate"]),
                                 Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                                 Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                                 Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                                 Language = (string)((r["Language"] == System.DBNull.Value) ? null : r["Language"]),
                                 Featured = (Boolean)((r["Featured"] == System.DBNull.Value) ? null : r["Featured"]),
                                 StaticPage = (Boolean)((r["StaticPage"] == System.DBNull.Value) ? null : r["StaticPage"]),
                                 Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                                 Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                                 Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                                 Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                 AuthorId = (int)((r["AuthorId"] == System.DBNull.Value) ? 0 : r["AuthorId"]),
                                 Ids = MyModels.Encode((int)r["Id"], SecretId),
                                 Hit = (int)r["Hit"],
                                 AudioFile = (string)((r["AudioFile"] == System.DBNull.Value) ? null : r["AudioFile"]),
                                 AudioFile_EN = (string)((r["AudioFile_EN"] == System.DBNull.Value) ? null : r["AudioFile_EN"]),
                                 ExternalLink = (string)((r["ExternalLink"] == System.DBNull.Value) ? null : r["ExternalLink"])
                             }).FirstOrDefault();

            if (Item.Str_ListFile != null && Item.Str_ListFile != "")
            {
                Item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(Item.Str_ListFile);
            }

            if (Item.Str_Link != null && Item.Str_Link != "")
            {
                Item.ListLinkArticle = JsonConvert.DeserializeObject<List<LinkArticle>>(Item.Str_Link);
            }
            return Item;
        }

        public static dynamic SaveItem(Articles dto)
        {
            string Str_ListFile = null;
            string Str_Link = null;
            List<FileArticle> ListFileArticle = new List<FileArticle>();
            List<LinkArticle> ListLinkArticle = new List<LinkArticle>();

            if (dto.ListFile != null && dto.ListFile.Count() > 0)
            {
                for (int i = 0; i < dto.ListFile.Count(); i++)
                {
                    if (dto.ListFile[i].FilePath != null && dto.ListFile[i].FilePath.Trim() != "")
                    {
                        ListFileArticle.Add(dto.ListFile[i]);
                    }
                }
                if (ListFileArticle != null && ListFileArticle.Count() > 0)
                {
                    Str_ListFile = JsonConvert.SerializeObject(ListFileArticle);
                }

            }


            if (dto.ListLinkArticle != null && dto.ListLinkArticle.Count() > 0)
            {
                for (int i = 0; i < dto.ListLinkArticle.Count(); i++)
                {
                    if (dto.ListLinkArticle[i].Title != null && dto.ListLinkArticle[i].Title.Trim() != "" && dto.ListLinkArticle[i].Status == true)
                    {
                        ListLinkArticle.Add(dto.ListLinkArticle[i]);
                    }
                }
                if (ListLinkArticle != null && ListLinkArticle.Count() > 0)
                {
                    Str_Link = JsonConvert.SerializeObject(ListLinkArticle);
                }

            }
            DateTime NgayDang = DateTime.ParseExact(dto.PublishUpShow, "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Title", "@Alias", "@CatId", "@IntroText", "@FullText", "@Status", "@CreatedBy", "@ModifiedBy", "@CreatedDate", "@ModifiedDate", "@Metadesc", "@Metakey", "@Metadata", "@Language", "@Featured", "@StaticPage", "@Images", "@Params", "@Ordering", "@Deleted", "@IdCoQuan", "@FeaturedHome", "@PublishUp", "@Str_ListFile", "@Str_Link", "@AuthorId", "@Notification", "@AudioFile", "@LangId", "@ExternalLink","@Author" , "@Ten", "@MoDau", "@NoiDung", "@AudioFile_EN" },
            new object[] { "SaveItem", dto.Id, dto.Title, dto.Alias, dto.CatId, dto.IntroText, dto.FullText, dto.Status, dto.CreatedBy, dto.ModifiedBy, dto.CreatedDate, dto.ModifiedDate, dto.Metadesc, dto.Metakey, dto.Metadata, dto.Language, dto.Featured, dto.StaticPage, dto.Images, dto.Params, dto.Ordering, dto.Deleted, dto.IdCoQuan, dto.FeaturedHome, NgayDang, Str_ListFile, Str_Link, dto.AuthorId, dto.Notification, dto.AudioFile, dto.LangId, dto.ExternalLink,dto.Author, dto.Ten, dto.MoDau, dto.NoiDung, dto.AudioFile_EN });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id, dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateImage(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Images" },
            new object[] { "UpdateImage", dto.Id, dto.Images });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateHit(int id)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id" },
            new object[] { "UpdateHit", id });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


        public static dynamic UpdateStaticPage(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@StaticPage", "@ModifiedBy" },
            new object[] { "UpdateStaticPage", dto.Id, dto.StaticPage, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic UpdateFeatured(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Featured", "@ModifiedBy" },
            new object[] { "UpdateFeatured", dto.Id, dto.Featured, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateNotification(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Notification", "@ModifiedBy" },
            new object[] { "UpdateNotification", dto.Id, dto.Notification, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateFeaturedHome(Articles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@FeaturedHome", "@ModifiedBy" },
            new object[] { "UpdateFeaturedHome", dto.Id, dto.FeaturedHome, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateAlias(int Id, string Alias)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Alias" },
            new object[] { "UpdateAlias", Id, Alias });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateFulltext(int Id, string FullText)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@FullText" },
            new object[] { "UpdateFullText", Id, FullText });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


        public static dynamic UpdateUpdateStr_ListFile(int Id, string Str_ListFile)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Articles",
            new string[] { "@flag", "@Id", "@Str_ListFile" },
            new object[] { "UpdateStr_ListFile", Id, Str_ListFile });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }



    }
}
