using API.Models;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.ChiNhanhCapNuoc
{
    public class ChiNhanhCapNuocService
    {
        public static List<ChiNhanhCapNuoc> GetListPagination(SearchChiNhanhCapNuoc dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword });
            if (tabl == null)
            {
                return new List<ChiNhanhCapNuoc>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new ChiNhanhCapNuoc
                        {
                            Id = (int)r["Id"],
                            TenChiNhanh = (string)r["TenChiNhanh"],
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }
        }

        public static List<SelectListItem> GetListChiNhanhDanhMuc(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["TenChiNhanh"] == System.DBNull.Value) ? null : r["TenChiNhanh"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn Danh mục", Value = "0" }));
            return ListItems;

        }

        public static List<ChiNhanhCapNuoc> GetList(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            if (tabl == null)
            {
                return new List<ChiNhanhCapNuoc>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new ChiNhanhCapNuoc
                        {
                            Id = (int)r["Id"],
                            TenChiNhanh = (string)((r["TenChiNhanh"] == System.DBNull.Value) ? null : r["TenChiNhanh"]),
                            DiaChi = (string)((r["DiaChi"] == System.DBNull.Value) ? null : r["DiaChi"]),
                            SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                        }).ToList();
            }

        }

        public static ChiNhanhCapNuoc GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new ChiNhanhCapNuoc
                    {
                        Id = (int)r["Id"],
                        TenChiNhanh = (string)((r["TenChiNhanh"] == System.DBNull.Value) ? null : r["TenChiNhanh"]),
                        DiaChi = (string)((r["DiaChi"] == System.DBNull.Value) ? null : r["DiaChi"]),
                        SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(ChiNhanhCapNuoc dto)
        {
            dto.CreatedAt = DateTime.Now;

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
            new string[] { "@flag", "@Id", "@TenChiNhanh", "@DiaChi", "@SoDT", "@Status", "@CreatedBy", "@CreatedAt", "@UpdatedBy", "@UpdatedAt" },
            new object[] { "SaveItem", dto.Id, dto.TenChiNhanh, dto.DiaChi, dto.SoDT, dto.Status, dto.CreatedBy, dto.CreatedAt, dto.UpdatedBy, dto.UpdatedAt });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(ChiNhanhCapNuoc dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(ChiNhanhCapNuoc dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_ChiNhanhCapNuoc",
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
