using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Articles;
using API.Areas.Admin.Models.DuThaoVanBan;
using API.Areas.Admin.Models.DuThaoVanBanGopY;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace API.Areas.Admin.Models.DuThaoVanBan
{
    public class DuThaoVanBanService
    {

        public static List<DuThaoVanBan> GetListPagination(SearchDuThaoVanBan dto, string SecretId, Boolean flagFE = false)
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
            string sql = "GetListPagination";
            if (flagFE)
            {
                sql = "GetListPaginationFE";
            }
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@FieldId" },
                new object[] { sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword,dto.FieldId });
            if (tabl == null)
            {
                return new List<DuThaoVanBan>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new DuThaoVanBan
                        {
                            Id = (int)r["Id"],
                            numGopY = (int)r["numGopY"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? "" : r["Title"]),
                            Status = (bool)r["Status"],
                            TitleField = (string)((r["TitleField"] == System.DBNull.Value) ? "" : r["TitleField"]),                            
                            Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? "" : r["Introtext"]),                            
                            Link = (string)((r["Link"] == System.DBNull.Value) ? "" : r["Link"]),
                            ExpiresDate = (DateTime)((r["ExpiresDate"] == System.DBNull.Value) ? null : r["ExpiresDate"]),
                            ExpiresDateShow = (string)((r["ExpiresDate"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["ExpiresDate"]).ToString("dd/MM/yyyy")),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }


        }

        public static List<DuThaoVanBan> GetList(Boolean Selected = true)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Selected });
            return (from r in tabl.AsEnumerable()
                    select new DuThaoVanBan
                    {
                        Id = (int)r["Id"],
                        Title = (string)r["Title"],                        
                        Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? "" : r["Introtext"])                   
                    }).ToList();

        }

     
        public static DuThaoVanBan GetItem(int Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            DuThaoVanBan item=(from r in tabl.AsEnumerable()
                    select new DuThaoVanBan
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? "" : r["Title"]),
                        Status = (bool)r["Status"],
                        Link = (string)((r["Link"] == System.DBNull.Value) ? "" : r["Link"]),
                        Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? "" : r["Introtext"]),
                        Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),
                        FieldId = (int)((r["FieldId"] == System.DBNull.Value) ? 0 : r["FieldId"]),
                        ExpiresDate = (DateTime)((r["ExpiresDate"] == System.DBNull.Value) ? null : r["ExpiresDate"]),
                        ExpiresDateShow = (string)((r["ExpiresDate"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["ExpiresDate"]).ToString("dd/MM/yyyy")),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();

            if (item.Str_ListFile != null && item.Str_ListFile != "")
            {
                item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(item.Str_ListFile);
            }



            return item;
        }


        public static DuThaoVanBanModel GetItemFront(int Id, string SecretId = null,int currentPage=1)
        {

            DuThaoVanBanModel data = new DuThaoVanBanModel();

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
            new string[] { "@flag", "@Id" }, new object[] { "GetItemFront", Id });
            data.Item= (from r in tabl.AsEnumerable()
                    select new DuThaoVanBan
                    {
                        Id = (int)r["Id"],
                        Title = (string)((r["Title"] == System.DBNull.Value) ? "" : r["Title"]),
                        Status = (bool)r["Status"],
                        Link = (string)((r["Link"] == System.DBNull.Value) ? "" : r["Link"]),
                        Introtext = (string)((r["Introtext"] == System.DBNull.Value) ? "" : r["Introtext"]),
                        FieldId = (int)((r["FieldId"] == System.DBNull.Value) ? 0 : r["FieldId"]),
                        Str_ListFile = (string)((r["Str_ListFile"] == System.DBNull.Value) ? null : r["Str_ListFile"]),
                        FieldTitle = (string)((r["FieldTitle"] == System.DBNull.Value) ? "" : r["FieldTitle"]),
                        ExpiresDate = (DateTime)((r["ExpiresDate"] == System.DBNull.Value) ? null : r["ExpiresDate"]),
                        ExpiresDateShow = (string)((r["ExpiresDate"] == System.DBNull.Value) ? DateTime.Now.ToString("dd/MM/yyyy") : (string)((DateTime)r["ExpiresDate"]).ToString("dd/MM/yyyy")),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();

            if (data.Item.Str_ListFile != null && data.Item.Str_ListFile != "")
            {
                data.Item.ListFile = JsonConvert.DeserializeObject<List<FileArticle>>(data.Item.Str_ListFile);
            }

            SearchDuThaoVanBanGopY dto = new SearchDuThaoVanBanGopY() {ItemsPerPage=10, CurrentPage = currentPage,IdDuThao=data.Item.Id};
            data.Item.ListGopY = DuThaoVanBanGopYService.GetListPagination(dto, "", true);
            return data;
        }

        public static dynamic SaveItem(DuThaoVanBan dto)
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


            DateTime ExpiresDate = DateTime.ParseExact(dto.ExpiresDateShow, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
            new string[] { "@flag","@Id", "@Title", "@Status", "@Introtext", "@FieldId", "@Link", "@CreatedBy", "@ModifiedBy", "ExpiresDate", "@Str_ListFile" },
            new object[] { "SaveItem", dto.Id, dto.Title, dto.Status, dto.Introtext, dto.FieldId,dto.Link,dto.CreatedBy,dto.ModifiedBy, ExpiresDate, Str_ListFile });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(DuThaoVanBan dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
            new string[] { "@flag", "@Id","@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id,dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic DeleteItem(DuThaoVanBan dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DuThaoVanBan",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


    }
}
