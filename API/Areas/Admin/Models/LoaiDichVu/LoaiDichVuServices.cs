using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;

namespace API.Areas.Admin.Models.LoaiDichVu
{
    public class LoaiDichVuServices
    {
        public static List<LoaiDichVu> GetListPagination(SearchLoaiDichVu dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword });
            if (tabl == null)
            {
                return new List<LoaiDichVu>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new LoaiDichVu
                        {
                            Id = (int)r["Id"],
                            TenLoaiDichVu = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
                            Status = (Boolean)r["Status"],
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                        }).ToList();
            }


        }

        public static List<LoaiDichVu> GetList(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            if (tabl == null)
            {
                return new List<LoaiDichVu>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new LoaiDichVu
                        {
                            Id = (int)r["Id"],
                            TenLoaiDichVu = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
                        }).ToList();
            }

        }

        //public static List<LoaiDichVu> GetListFeaturedHome()
        //{

        //    DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
        //        new string[] { "@flag" }, new object[] { "GetListFeaturedHome" });
        //    if (tabl == null)
        //    {
        //        return new List<LoaiDichVu>();
        //    }
        //    else
        //    {
        //        return (from r in tabl.AsEnumerable()
        //                select new LoaiDichVu
        //                {
        //                    Id = (int)r["Id"],
        //                    TenLoaiDichVu = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
        //                }).ToList();
        //    }

        //}
        public static List<SelectListItem> GetListItems(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "Chọn Danh mục", Value = "0" }));
            return ListItems;

        }



        public static LoaiDichVu GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new LoaiDichVu
                    {
                        Id = (int)r["Id"],
                        TenLoaiDichVu = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }
        //public static LoaiDichVu GetItemByAlias(string Alias, string SecretId = null)
        //{

        //    DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
        //    new string[] { "@flag", "@Alias" }, new object[] { "GetItemByAlias", Alias });
        //    return (from r in tabl.AsEnumerable()
        //            select new LoaiDichVu
        //            {
        //                Id = (int)r["Id"],
        //                TenLoaiDichVu = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
        //                Ids = MyModels.Encode((int)r["Id"], SecretId),
        //            }).FirstOrDefault();
        //}

        //public static List<LoaiDichVu> GetListChild(int Id, int limit = 100)
        //{

        //    DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
        //    new string[] { "@flag", "@Id", "@Limit" }, new object[] { "GetListChild", Id, limit });
        //    return (from r in tabl.AsEnumerable()
        //            select new LoaiDichVu
        //            {
        //                Id = (int)r["Id"],
        //                TenLoaiDichVu = (string)((r["TenLoaiDichVu"] == System.DBNull.Value) ? null : r["TenLoaiDichVu"]),
        //            }).ToList();
        //}

        public static dynamic SaveItem(LoaiDichVu dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
            new string[] { "@flag", "@Id", "@TenLoaiDichVu", "@Status", "@Deleted", "@CreatedBy", "@UpdatedBy"},
            new object[] { "SaveItem", dto.Id, dto.TenLoaiDichVu,dto.Status, dto.Deleted, dto.CreatedBy, dto.UpdatedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(LoaiDichVu dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(LoaiDichVu dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
            new string[] { "@flag", "@Id", "@Status", "@UpdatedBy" },
            new object[] { "UpdateStatus", dto.Id, dto.Status, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        //public static dynamic UpdateAlias(int Id, string Alias)
        //{
        //    DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Request",
        //    new string[] { "@flag", "@Id", "@Alias" },
        //    new object[] { "UpdateAlias", Id, Alias });
        //    return (from r in tabl.AsEnumerable()
        //            select new
        //            {
        //                N = (int)(r["N"]),
        //            }).FirstOrDefault();

        //}
    }
}
