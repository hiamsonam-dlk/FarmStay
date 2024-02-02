using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;

namespace API.Areas.Admin.Models.MucDichSuDung
{
    public class MucDichSuDungService
    {
        public static List<MucDichSuDung> GetListPagination(SearchMucDichSuDung dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword });
            if (tabl == null)
            {
                return new List<MucDichSuDung>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new MucDichSuDung
                        {
                            Id = (int)r["Id"],
                            TenMucDich = (string)r["TenMucDich"],
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }
        }

        public static List<SelectListItem> GetListMucDichSuDungDanhMuc(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["TenMucDich"] == System.DBNull.Value) ? null : r["TenMucDich"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "--- Chọn mục đích sử dụng ---", Value = "0" }));
            return ListItems;

        }

        public static List<MucDichSuDung> GetList(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            if (tabl == null)
            {
                return new List<MucDichSuDung>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new MucDichSuDung
                        {
                            Id = (int)r["Id"],
                            TenMucDich = (string)r["TenMucDich"],
                            Status = (Boolean)r["Status"]
                        }).ToList();
            }

        }

        public static MucDichSuDung GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new MucDichSuDung
                    {
                        Id = (int)r["Id"],
                        TenMucDich = (string)r["TenMucDich"],
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(MucDichSuDung dto)
        {
            if (dto.CreatedAt == null)
            {
                dto.CreatedAt = DateTime.Now;
            }

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
            new string[] { "@flag", "@Id", "@TenMucDich", "@Status", "@CreatedBy", "@CreatedAt", "@UpdatedBy", "@UpdatedAt" },
            new object[] { "SaveItem", dto.Id, dto.TenMucDich, dto.Status, dto.CreatedBy, dto.CreatedAt, dto.UpdatedBy, dto.UpdatedAt });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(MucDichSuDung dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(MucDichSuDung dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_MucDichSuDung",
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
