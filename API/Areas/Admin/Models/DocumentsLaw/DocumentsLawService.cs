using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Articles;
using API.Areas.Admin.Models.DocumentsLaw;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace API.Areas.Admin.Models.DocumentsLaw
{
    public class DocumentsLawService
    {
        public static List<DocumentsLaw> GetListPagination(SearchDocumentsLaw dto, string SecretId)
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


            string str_sql = "GetListPagination";
            if (dto.Status != -1)
            {
                str_sql = "GetListPagination_Status";
            }

            string StartDate = "";
            if(!string.IsNullOrEmpty(dto.ShowStartDate))
            StartDate = DateTime.ParseExact(dto.ShowStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");

            string EndDate = "";
            if (!string.IsNullOrEmpty(dto.ShowEndDate))                
            EndDate = DateTime.ParseExact(dto.ShowEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");

            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLaw",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@TypeId",  "@StartDate", "@EndDate" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.TypeId, StartDate, EndDate });
            if (tabl == null)
            {
                return new List<DocumentsLaw>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new DocumentsLaw
                        {
                            Id = (int)r["Id"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                            Code = (string)((r["Code"] == System.DBNull.Value) ? null : r["Code"]),
                            Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
                            Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? null : r["Introtext"]),
                            Status = (Boolean)r["Status"],
                            IssuedDate = (DateTime)((r["IssuedDate"] == System.DBNull.Value) ? DateTime.Now : r["IssuedDate"]),                            
                            IssuedDateShow = (string)((r["IssuedDate"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["IssuedDate"]).ToString("dd/MM/yyyy")), 
                            TypeId = (int)r["TypeId"],
                            TypeTitle= (string)((r["TypeTitle"] == System.DBNull.Value) ? null : r["TypeTitle"]),
                            FieldName = (string)((r["FieldName"] == System.DBNull.Value) ? null : r["FieldName"]),
                            Year = (int)r["Year"],
                            Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),                            
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();


            }


        }

        public static List<SelectListItem> GetListItemsStatus()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "--- Trạng Thái ---", Value = "-1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Ẩn", Value = "0" }));
            ListItems.Insert(2, (new SelectListItem { Text = "Hiện", Value = "1" }));
            return ListItems;
        }

        

        public static DocumentsLaw GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLaw",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            var item= (from r in tabl.AsEnumerable()
                    select new DocumentsLaw
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Code = (string)((r["Code"] == System.DBNull.Value) ? null : r["Code"]),
                        Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
                        Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? null : r["Introtext"]),
                        FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                        Status = (Boolean)r["Status"],
                        IssuedDate = (DateTime)((r["IssuedDate"] == System.DBNull.Value) ? DateTime.Now : r["IssuedDate"]),                        
                        IssuedDateShow = (string)((r["IssuedDate"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["IssuedDate"]).ToString("dd/MM/yyyy")),
                        TypeId = (int)r["TypeId"],
                        FieldName = (string)((r["FieldName"] == System.DBNull.Value) ? null : r["FieldName"]),
                        Year = (int)r["Year"],
                        Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),                        
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();

            if (item.Str_ListFile != null && item.Str_ListFile != "")
            {
                item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(item.Str_ListFile);
            }

            return item;
        }

        public static DocumentsLaw GetItemFront(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLaw",
            new string[] { "@flag", "@Id" }, new object[] { "GetItemFront", Id });
            var item= (from r in tabl.AsEnumerable()
                    select new DocumentsLaw
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Code = (string)((r["Code"] == System.DBNull.Value) ? null : r["Code"]),
                        Link = (string)((r["Link"] == System.DBNull.Value) ? null : r["Link"]),
                        Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? null : r["Introtext"]),
                        FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                        Status = (Boolean)r["Status"],
                        IssuedDate = (DateTime)((r["IssuedDate"] == System.DBNull.Value) ? DateTime.Now : r["IssuedDate"]),                        
                        IssuedDateShow = (string)((r["IssuedDate"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["IssuedDate"]).ToString("dd/MM/yyyy")),                                                
                        TypeId = (int)r["TypeId"],
                        FieldName = (string)((r["FieldName"] == System.DBNull.Value) ? null : r["FieldName"]),
                        Year = (int)r["Year"],
                        TypeTitle = (string)((r["TypeTitle"] == System.DBNull.Value) ? null : r["TypeTitle"]),
                        Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();


            if (item.Str_ListFile != null && item.Str_ListFile != "")
            {
                item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(item.Str_ListFile);
            }

            return item;
        }


        public static dynamic SaveItem(DocumentsLaw dto)
        {

            string Str_ListFile = null;
            List<FileArticle> ListFileArticle = new List<FileArticle>();
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

            if (dto.Alias == null || dto.Alias == "")
            {
                dto.Alias = API.Models.MyHelper.StringHelper.UrlFriendly(dto.Title);
            }
            DateTime IssuedDate = DateTime.ParseExact(dto.IssuedDateShow, "dd/MM/yyyy", CultureInfo.InvariantCulture);            

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLaw",
            new string[] { "@flag", "@Id", "@Title", "@Code", "@Link", "@Alias", "@Introtext", "@FullText", "@Status", "@CreatedBy", "@ModifiedBy", "@IssuedDate","@TypeId", "@FieldName",  "@Str_ListFile","@Year"},
            new object[] { "SaveItem", dto.Id, dto.Title, dto.Code, dto.Link, dto.Alias, dto.Introtext, dto.FullText, dto.Status, dto.CreatedBy, dto.ModifiedBy, IssuedDate, dto.TypeId, dto.FieldName,Str_ListFile,dto.Year});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(DocumentsLaw dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLaw",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(DocumentsLaw dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLaw",
            new string[] { "@flag", "@Id", "@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id, dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


    }
}
