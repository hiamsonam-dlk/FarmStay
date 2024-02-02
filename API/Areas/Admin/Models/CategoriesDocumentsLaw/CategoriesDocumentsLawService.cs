using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.CategoriesDocumentsLaw;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.CategoriesDocumentsLaw
{
    public class CategoriesDocumentsLawService
    {
        public static List<CategoriesDocumentsLaw> GetListPagination(SearchCategoriesDocumentsLaw dto, string SecretId,string LangId="VI")
        {
			if (dto.CurrentPage <= 0)
            {
                dto.CurrentPage = 1;
            }
            if (dto.ItemsPerPage <= 0)
            {
                dto.ItemsPerPage = 10;
            }
            if (dto.Keyword == null)
            {
                dto.Keyword = "";
            }
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword","@LangId","@Level" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword,LangId,dto.Level});
            if (tabl == null)
            {
                return new List<CategoriesDocumentsLaw>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new CategoriesDocumentsLaw
					{
						Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
 						Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]), 						
 						ParentId = (int?)((r["ParentId"] == System.DBNull.Value) ? null : r["ParentId"]),
 						Status = (Boolean)r["Status"],
                        NoDelete = (Boolean)r["NoDelete"],
                        Level = (int?)((r["alevel"] == System.DBNull.Value) ? null : r["alevel"]),
                        FeaturedHome = (Boolean)((r["FeaturedHome"] == System.DBNull.Value) ? false : r["FeaturedHome"]),
                        Hits = (int?)((r["Hits"] == System.DBNull.Value) ? null : r["Hits"]),
                        Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                        Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                        Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),						
					}).ToList();
            }


        }

        public static List<CategoriesDocumentsLaw> GetList(Boolean Selected = true, string LangId = "VI")
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
                new string[] { "@flag", "@Selected","@LangId" }, new object[] { "GetList", Convert.ToDecimal(Selected),LangId});
            if (tabl == null)
            {
                return new List<CategoriesDocumentsLaw>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new CategoriesDocumentsLaw
					{
						Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
 						Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
 						//Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						ParentId = (int?)((r["ParentId"] == System.DBNull.Value) ? null : r["ParentId"]),
                        Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"])
                    }).ToList();
            }

        }


        public static List<SelectListItem> GetListItemType()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "Layout 1", Value = "1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Layout 2", Value = "2" }));
            return ListItems;
        }

        public static List<SelectListItem> GetListItemLevel()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "Menu cấp 1", Value = "0" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Tất cả các cấp", Value = "-1" }));
            return ListItems;
        }

        public static List<CategoriesDocumentsLaw> GetListFeaturedHome(string LangId = "VI")
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
                new string[] { "@flag","@LangId" }, new object[] { "GetListFeaturedHome",LangId });
            if (tabl == null)
            {
                return new List<CategoriesDocumentsLaw>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new CategoriesDocumentsLaw
                        {
                            Id = (int)r["Id"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),                            
                            ParentId = (int?)((r["ParentId"] == System.DBNull.Value) ? null : r["ParentId"]),
                            Type=(int)r["Type"]
                        }).ToList();
            }

        }
        public static List<SelectListItem> GetListItems(Boolean Selected = true, string LangId = "VI",int UserId=0)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
                new string[] { "@flag", "@Selected","@LangId","@UserId" }, new object[] { "GetList", Convert.ToDecimal(Selected),LangId,UserId});
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn Danh mục", Value = "0" }));
            return ListItems;

        }


        public static List<CategoriesDocumentsLawDropDown> GetListItemsDropDown(int ParentId=0,string LangId = "VI", int UserId = 0)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
                new string[] { "@flag", "@ParentId", "@LangId", "@UserId" }, new object[] { "GetListDropDown", ParentId,LangId,UserId });
            List<CategoriesDocumentsLawDropDown> ListItems = (from r in tabl.AsEnumerable()
                                              select new CategoriesDocumentsLawDropDown
                                              {
                                                  Id = (int)r["Id"],
                                                  Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                                  CountChild = (int)r["CountChild"],
                                              }).ToList();

            return ListItems;

        }



        public static CategoriesDocumentsLaw GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new CategoriesDocumentsLaw
                    {
                        Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
 						Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Type = (int)r["Type"],
                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						ParentId = (int?)((r["ParentId"] == System.DBNull.Value) ? null : r["ParentId"]),
 						Status = (Boolean)r["Status"],
                        FeaturedHome = (Boolean)((r["FeaturedHome"] == System.DBNull.Value) ? false : r["FeaturedHome"]),
                        Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
 						Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
 						Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                        Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                        Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                        Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                        Hits = (int?)((r["Hits"] == System.DBNull.Value) ? null : r["Hits"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static CategoriesDocumentsLaw GetItembyName(string Name)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Title" }, new object[] { "GetItembyName", Name });
            return (from r in tabl.AsEnumerable()
                    select new CategoriesDocumentsLaw
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"])                        
                    }).FirstOrDefault();
        }

        public static CategoriesDocumentsLaw GetItemByAlias(string Alias, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Alias" }, new object[] { "GetItemByAlias", Alias });
            return (from r in tabl.AsEnumerable()
                    select new CategoriesDocumentsLaw
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                        ParentId = (int?)((r["ParentId"] == System.DBNull.Value) ? null : r["ParentId"]),
                        Status = (Boolean)r["Status"],
                        FeaturedHome = (Boolean)((r["FeaturedHome"] == System.DBNull.Value) ? false : r["FeaturedHome"]),
                        Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                        Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                        Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                        Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                        Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                        Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                        Hits = (int?)((r["Hits"] == System.DBNull.Value) ? null : r["Hits"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static List<CategoriesDocumentsLaw> GetListChild(int Id,int limit=100)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Id","@Limit" }, new object[] { "GetListChild", Id,limit});
            return (from r in tabl.AsEnumerable()
                    select new CategoriesDocumentsLaw
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                        ParentId = (int?)((r["ParentId"] == System.DBNull.Value) ? null : r["ParentId"]),
                        Status = (Boolean)r["Status"],
                        FeaturedHome = (Boolean)((r["FeaturedHome"] == System.DBNull.Value) ? false : r["FeaturedHome"]),
                        Metadesc = (string)((r["Metadesc"] == System.DBNull.Value) ? null : r["Metadesc"]),
                        Metakey = (string)((r["Metakey"] == System.DBNull.Value) ? null : r["Metakey"]),
                        Metadata = (string)((r["Metadata"] == System.DBNull.Value) ? null : r["Metadata"]),
                        Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                        Params = (string)((r["Params"] == System.DBNull.Value) ? null : r["Params"]),
                        Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                        Hits = (int?)((r["Hits"] == System.DBNull.Value) ? null : r["Hits"]),                        
                    }).ToList();
        }

        public static dynamic SaveItem(CategoriesDocumentsLaw dto)
        {
            if (dto.Alias == null || dto.Alias == "")
            {
                dto.Alias = API.Models.MyHelper.StringHelper.UrlFriendly(dto.Title);
            }
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag","@Id","@Title","@Alias","@Description","@ParentId","@Status","@Deleted","@CreatedBy","@ModifiedBy","@Metadesc","@Metakey","@Metadata","@Images","@Params","@Ordering","@Hits", "@FeaturedHome","@Type", "@LangId" },
            new object[] { "SaveItem",dto.Id,dto.Title,dto.Alias,dto.Description,dto.ParentId,dto.Status,dto.Deleted,dto.CreatedBy,dto.ModifiedBy,dto.Metadesc,dto.Metakey,dto.Metadata,dto.Images,dto.Params,dto.Ordering,dto.Hits ,dto.FeaturedHome,dto.Type,dto.LangId});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(CategoriesDocumentsLaw dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
		
		public static dynamic UpdateStatus(CategoriesDocumentsLaw dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Id","@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id,dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateAlias(int Id, string Alias)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_CategoriesDocumentsLaw",
            new string[] { "@flag", "@Id", "@Alias" },
            new object[] { "UpdateAlias", Id, Alias });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }



    }
}
