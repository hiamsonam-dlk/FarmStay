using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Menus;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Areas.Admin.Models.Menus
{
    public class MenusService
    {
        

        public static List<Menus> GetListPagination(SearchMenus dto, string SecretId,string LangId = "VI")
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@IdCoQuan","@Position","@LangId" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword ,dto.IdCoQuan,dto.Position,LangId});
            if (tabl == null)
            {
                return new List<Menus>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new Menus
					{
						Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        CatId = (int)r["CatId"],
                        Level = (int)r["Level"],
                        Position = (int)r["Position"],
                        StaticId = (int)r["StaticId"],
 						Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
 						IdCoQuan = (int)((r["IdCoQuan"] == System.DBNull.Value) ? 0 : r["IdCoQuan"]),
 						TenCoQuan = (string)((r["TenCoQuan"] == System.DBNull.Value) ? 0 : r["TenCoQuan"]),
 						ParentId = (int)r["ParentId"],
                        Type = (int)r["Type"],
                        Status = (Boolean?)((r["Status"] == System.DBNull.Value) ? null : r["Status"]), 						
 						Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                        Icon = (string)((r["Icon"] == System.DBNull.Value) ? null : r["Icon"]),
                        Target = (string)((r["Target"] == System.DBNull.Value) ? null : r["Target"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),						
					}).ToList();
            }


        }

        public static List<Menus> GetList(Boolean Selected = true,int IdCoQuan = 1, string LangId = "VI")
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
                new string[] { "@flag", "@Selected", "@IdCoQuan", "@LangId" }, new object[] { "GetList", Convert.ToDecimal(Selected),IdCoQuan, LangId });
            if (tabl == null)
            {
                return new List<Menus>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new Menus
					{
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                        Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
                        LinkEN = (string)((r["LinkEN"] == System.DBNull.Value) ? null : r["LinkEN"]),
                        IdCoQuan = (int)((r["IdCoQuan"] == System.DBNull.Value) ? 0 : r["IdCoQuan"]),                        
                        ParentId = (int)r["ParentId"],
                        Type = (int)r["Type"],
                        Icon = (string)((r["Icon"] == System.DBNull.Value) ? null : r["Icon"]),
                        Target = (string)((r["Target"] == System.DBNull.Value) ? null : r["Target"]),
                    }).ToList();
            }

        }
        public static List<Menus> GetListByParrent(int ParentId = 0,int IdCoQuan=1,int Position=0, string LangId = "VI")
        {
            List<Menus> menus = new List<Menus>();

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
                new string[] { "@flag", "@ParentId", "@IdCoQuan","@Position","@LangId"}, new object[] { "GetListByParrent", ParentId, IdCoQuan,Position,LangId});
            if (tabl == null)
            {
                menus = new List<Menus>();
            }
            else
            {
                menus = (from r in tabl.AsEnumerable()
                        select new Menus
                        {
                            Id = (int)r["Id"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                            CatId = (int)r["CatId"],
                            IdCoQuan = (int)r["IdCoQuan"],
                            Position = (int)r["Position"],
                            StaticId = (int)r["StaticId"],
                            Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
                            LinkEN = (string)((r["LinkEN"] == System.DBNull.Value) ? null : r["LinkEN"]),
                            ParentId = (int)r["ParentId"],
                            Type = (int)r["Type"],
                            ArticleId = (int?)((r["ArticleId"] == System.DBNull.Value) ? null : r["ArticleId"]),
                            Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                            Icon = (string)((r["Icon"] == System.DBNull.Value) ? null : r["Icon"]),
                            ChildCount = (int)((r["ChildCount"] == System.DBNull.Value) ? null : r["ChildCount"]),
                            Target = (string)((r["Target"] == System.DBNull.Value) ? null : r["Target"]),
                        }).ToList();
            }
            for(int i = 0; i < menus.Count; i++)
            {
                if(menus[i].ChildCount > 0)
                {
                    menus[i].ListMenus = GetListByParrent(menus[i].Id, menus[i].IdCoQuan,0,LangId);
                }
            }
            return menus;
        }
        public static List<SelectListItem> GetListItems(Boolean Selected = true, int IdCoQuan=1,int Position=0, string LangId = "VI")
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
                new string[] { "@flag", "@Selected", "@IdCoQuan","@Position","@LangId" }, new object[] { "GetList", Convert.ToDecimal(Selected), IdCoQuan, Position, LangId });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn Menu", Value = "0" }));
            return ListItems;

        }

        public static Menus GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new Menus
                    {
                        Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                        CatId = (int)r["CatId"],
                        Position = (int)r["Position"],
                        StaticId = (int)r["StaticId"],
 						Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
                        LinkEN = (string)((r["LinkEN"] == System.DBNull.Value) ? null : r["LinkEN"]),
                        IdCoQuan = (int)((r["IdCoQuan"] == System.DBNull.Value) ? 0 : r["IdCoQuan"]),
 						ParentId = (int)r["ParentId"],
                        Type = (int)r["Type"],
                        ModifiedBy = (int?)((r["ModifiedBy"] == System.DBNull.Value) ? null : r["ModifiedBy"]),
 						Status = (Boolean?)((r["Status"] == System.DBNull.Value) ? null : r["Status"]),
 						Deleted = (Boolean?)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
 						ModifiedDate = (DateTime?)((r["ModifiedDate"] == System.DBNull.Value) ? null : r["ModifiedDate"]),
 						ArticleId = (int?)((r["ArticleId"] == System.DBNull.Value) ? null : r["ArticleId"]),
 						Ordering = (int?)((r["Ordering"] == System.DBNull.Value) ? null : r["Ordering"]),
                        Icon = (string)((r["Icon"] == System.DBNull.Value) ? null : r["Icon"]),
                        LangId = (string)((r["LangId"] == System.DBNull.Value) ? null : r["LangId"]),
                        Target = (string)((r["Target"] == System.DBNull.Value) ? null : r["Target"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(Menus dto)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
            new string[] { "@flag","@Id","@Title","@CatId","@StaticId","@Link","@ParentId","@ModifiedBy","@Status","@Deleted","@ModifiedDate","@ArticleId","@Ordering","@Icon", "@IdCoQuan","@Type","@Position","@LangId","@Target", "@Ten","@LinkEN"},
            new object[] { "SaveItem",dto.Id,dto.Title,dto.CatId,dto.StaticId,dto.Link,dto.ParentId,dto.ModifiedBy,dto.Status,dto.Deleted,dto.ModifiedDate,dto.ArticleId,dto.Ordering,dto.Icon,dto.IdCoQuan,dto.Type,dto.Position,dto.LangId,dto.Target, dto.Ten ,dto.LinkEN});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(Menus dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
		
		public static dynamic UpdateStatus(Menus dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Menus",
            new string[] { "@flag", "@Id","@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id,dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static List<SelectListItem> GetListType()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "Direct link", Value = "1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Danh mục bài viết", Value = "2" }));
            ListItems.Insert(2, (new SelectListItem { Text = "Danh mục văn bản", Value = "3" }));

            return ListItems;
        }

        public static List<SelectListItem> GetListPositon()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "Menu ngang", Value = "1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Menu dọc", Value = "2" }));

            return ListItems;
        }


    }
}
