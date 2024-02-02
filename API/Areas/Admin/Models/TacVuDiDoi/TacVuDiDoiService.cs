using API.Areas.Admin.Models.Contacts;
using API.Models;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.TacVuDiDoi
{
    public class TacVuDiDoiService
    {
        public static List<TacVuDiDoi> GetListPagination(SearchTacVuDiDoi dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword"},
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword});
            if (tabl == null)
            {
                return new List<TacVuDiDoi>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new TacVuDiDoi
                        {
                            Id = (int)r["Id"],
                            TenTacVuDiDoi = (string)r["TenTrangThai"],
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }
        }

        public static List<SelectListItem> GetListTacVuDiDoi(Boolean Selected = true, int IdTacVu = 0)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
                new string[] { "@flag", "@Selected"}, new object[] { "GetList", Convert.ToDecimal(Selected)});
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["TenTrangThai"] == System.DBNull.Value) ? null : r["TenTrangThai"]),
                                                  Selected = (int)((r["Id"] == System.DBNull.Value) ? null : r["Id"]) == IdTacVu,
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn yêu cầu", Value = "0" }));
            return ListItems;

        }

        public static List<TacVuDiDoi> GetList(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            if (tabl == null)
            {
                return new List<TacVuDiDoi>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new TacVuDiDoi
                        {
                            Id = (int)r["Id"],
                            TenTacVuDiDoi = (string)r["TenTrangThai"],
                            Status = (Boolean)r["Status"]
                        }).ToList();
            }

        }

        public static TacVuDiDoi GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new TacVuDiDoi
                    {
                        Id = (int)r["Id"],
                        TenTacVuDiDoi = (string)r["TenTrangThai"],
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(TacVuDiDoi dto)
        {
            if (dto.CreatedAt == null)
            {
                dto.CreatedAt = DateTime.Now;
            }

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
            new string[] { "@flag", "@Id", "@TenTrangThai", "@Status","@CreatedBy", "@CreatedAt", "@UpdatedBy", "@UpdatedAt" },
            new object[] { "SaveItem", dto.Id, dto.TenTacVuDiDoi,dto.Status, dto.CreatedBy, dto.CreatedAt, dto.UpdatedBy ,dto.UpdatedAt});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(TacVuDiDoi dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(TacVuDiDoi dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_TrangThai",
            new string[] { "@flag", "@Id", "@Status", "@UpdatedBy" },
            new object[] { "UpdateStatus", dto.Id, dto.Status, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();
        }
    }
}
