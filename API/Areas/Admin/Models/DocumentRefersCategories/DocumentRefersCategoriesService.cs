using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.DocumentRefersCategories;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.DocumentRefersCategories
{
    public class DocumentRefersCategoriesService
    {
        public static List<DocumentRefersCategories> GetListPagination(SearchDocumentRefersCategories dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword });
            if (tabl == null)
            {
                return new List<DocumentRefersCategories>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new DocumentRefersCategories
					{
						Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						Status = (Boolean)r["Status"], 						
						Ids = MyModels.Encode((int)r["Id"], SecretId),
						TotalRows = (int)r["TotalRows"],
					}).ToList();
            }


        }

        public static List<DocumentRefersCategories> GetList(Boolean Selected = true)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            if (tabl == null)
            {
                return new List<DocumentRefersCategories>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new DocumentRefersCategories
					{
						Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						Status = (Boolean)r["Status"] 						
					}).ToList();
            }

        }

        public static List<SelectListItem> GetListSelectItems(int IdTinhThanh = 0)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", true });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "--- Chọn danh mục  ---", Value = "0" }));
            return ListItems;

        }

        public static DocumentRefersCategories GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new DocumentRefersCategories
                    {
                        Id = (int)r["Id"],
 						Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						Status = (Boolean)r["Status"], 						
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(DocumentRefersCategories dto)
        {
            if (dto.Alias == null || dto.Alias == "")
            {
                dto.Alias = API.Models.MyHelper.StringHelper.UrlFriendly(dto.Title);
            }
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
            new string[] { "@flag","@Id","@Title", "@Alias", "@Description","@Status","@CreatedBy","@ModifiedBy" },
            new object[] { "SaveItem",dto.Id,dto.Title,dto.Alias,dto.Description,dto.Status,dto.CreatedBy,dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(DocumentRefersCategories dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
		
		public static dynamic UpdateStatus(DocumentRefersCategories dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentRefersCategories",
            new string[] { "@flag", "@Id","@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id,dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


    }
}
