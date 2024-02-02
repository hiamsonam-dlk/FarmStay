using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System;
using System.Linq;

namespace API.Areas.Admin.Models.Phieu_CapNhatChiSo
{
    public class Phieu_CapNhatChiSoService
    {
        public static List<Phieu_CapNhatChiSo> GetListPagination(SearchPhieu_CapNhatChiSo dto, string SecretId)
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
            string EndDate = DateTime.ParseExact(dto.ShowEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(1).ToString("yyyyMMdd");
            string str_sql = "GetListPagination";
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_CapNhatChiSo",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@StartDate", "@EndDate", "@Status" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, StartDate, EndDate, dto.Status });
            if (tabl == null)
            {
                return new List<Phieu_CapNhatChiSo>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Phieu_CapNhatChiSo
                        {
                            Id = (int)r["Id"],
                            TenKH = (string)((r["TenKH"] == System.DBNull.Value) ? null : r["TenKH"]),
                            SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                            DiaChi = (string)((r["DiaChi"] == System.DBNull.Value) ? null : r["DiaChi"]),
                            Status = (int)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
                            ChiSoCu = (int)((r["ChiSoCu"] == System.DBNull.Value) ? 1 : r["ChiSoCu"]),
                            ChiSoMoi = (int)((r["ChiSoMoi"] == System.DBNull.Value) ? 1 : r["ChiSoMoi"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                            TotalRows = (int)r["TotalRows"],

                        }).ToList();
            }
        }

        public static List<SelectListItem> GetListItemsLoaiHinhDangKy()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "--- Hình thức đăng ký ---", Value = "-1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Trực tuyến", Value = "0" }));
            ListItems.Insert(2, (new SelectListItem { Text = "Trực tiếp", Value = "1" }));
            return ListItems;
        }

        public static List<SelectListItem> GetListItemsStatus()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "--- Trạng Thái ---", Value = "-1" }));
            ListItems.Insert(1, (new SelectListItem { Text = "Tiếp nhận", Value = "0" }));
            ListItems.Insert(2, (new SelectListItem { Text = "Đang xử lý", Value = "1" }));
            ListItems.Insert(3, (new SelectListItem { Text = "Hoàn tất", Value = "2" }));
            return ListItems;
        }

        public static Phieu_CapNhatChiSo GetItem(decimal Id, string SecretId = null, string LangId = "VI")
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_CapNhatChiSo",
            new string[] { "@flag", "@Id", "@LangId" }, new object[] { "GetItem", Id, LangId });
            Phieu_CapNhatChiSo Item = (from r in tabl.AsEnumerable()
                                          select new Phieu_CapNhatChiSo
                                          {
                                              Id = (int)r["Id"],
                                              TenKH = (string)((r["TenKH"] == System.DBNull.Value) ? null : r["TenKH"]),
                                              SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                                              DiaChi = (string)((r["DiaChi"] == System.DBNull.Value) ? null : r["DiaChi"]),
                                              ChiSoCu = (int)((r["ChiSoCu"] == System.DBNull.Value) ? null : r["ChiSoCu"]),
                                              ChiSoMoi = (int)((r["ChiSoMoi"] == System.DBNull.Value) ? null : r["ChiSoMoi"]),
                                              Status = (int)r["Status"],
                                              HinhAnh = (string)((r["HinhAnh"] == System.DBNull.Value) ? null : r["HinhAnh"]),
                                              CreatedBy = (string)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                              UpdatedBy = (string)((r["UpdatedBy"] == System.DBNull.Value) ? null : r["UpdatedBy"]),
                                              CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                                              UpdatedAt = (DateTime?)((r["UpdatedAt"] == System.DBNull.Value) ? null : r["UpdatedAt"]),
                                              LoaiHinhTiepNhan = (Boolean)((r["LoaiHinhTiepNhan"] == System.DBNull.Value) ? null : r["LoaiHinhTiepNhan"]),
                                              Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                              Ids = MyModels.Encode((int)r["Id"], SecretId),
                                          }).FirstOrDefault();
            return Item;
        }

        public static dynamic SaveItem(Phieu_CapNhatChiSo dto)
        {
            DateTime NgayDang = DateTime.ParseExact(DateTime.Now.ToString("d/M/yyyy HH:mm:ss"), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_CapNhatChiSo",
            new string[] { "@flag", "@Id", "@MaKH", "@TenKH", "@SoDT", "@DiaChi", "@ChiSoCu", "@ChiSoMoi", "@Status", "@CreatedBy", "@UpdatedBy", "@CreatedAt", "@UpdatedAt", "@LoaiHinhTiepNhan", "@Deleted", "@NgayTao" , "@HinhAnh"},
            new object[] { "SaveItem", dto.Id, dto.MaKH, dto.TenKH, dto.SoDT, dto.DiaChi, dto.ChiSoCu, dto.ChiSoMoi, dto.Status, dto.CreatedBy, dto.UpdatedBy, dto.CreatedAt, dto.UpdatedAt, dto.LoaiHinhTiepNhan, dto.Deleted, NgayDang ,dto.HinhAnh });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic DeleteItem(Phieu_CapNhatChiSo dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_CapNhatChiSo",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(Phieu_CapNhatChiSo dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_CapNhatChiSo",
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
