using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System;
using System.Linq;

namespace API.Areas.Admin.Models.Phieu_DangKySuaChua
{
    public class Phieu_DangKySuaChuaService
    {
        public static List<Phieu_DangKySuaChua> GetListPagination(SearchPhieu_DangKySuaChua dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKySuaChua",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@MucDichSuDung", "@StartDate", "@EndDate", "@Status", "@ChiNhanh" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.MucDichSuDung, StartDate, EndDate, dto.Status, dto.ChiNhanhCapNuoc });
            if (tabl == null)
            {
                return new List<Phieu_DangKySuaChua>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Phieu_DangKySuaChua
                        {
                            Id = (int)r["Id"],
                            TenKH = (string)((r["TenKH"] == System.DBNull.Value) ? null : r["TenKH"]),
                            SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                            Status = (int)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
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

        public static Phieu_DangKySuaChua GetItem(decimal Id, string SecretId = null, string LangId = "VI")
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKySuaChua",
            new string[] { "@flag", "@Id", "@LangId" }, new object[] { "GetItem", Id, LangId });
            Phieu_DangKySuaChua Item = (from r in tabl.AsEnumerable()
                                      select new Phieu_DangKySuaChua
                                      {
                                          Id = (int)r["Id"],
                                          TenKH = (string)((r["TenKH"] == System.DBNull.Value) ? null : r["TenKH"]),
                                          Status = (int)r["Status"],
                                          CreatedBy = (string)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                          UpdatedBy = (string)((r["UpdatedBy"] == System.DBNull.Value) ? null : r["UpdatedBy"]),
                                          CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                                          UpdatedAt = (DateTime?)((r["UpdatedAt"] == System.DBNull.Value) ? null : r["UpdatedAt"]),
                                          NhanVienKhaoSat = (string)((r["NhanVienKhaoSat"] == System.DBNull.Value) ? null : r["NhanVienKhaoSat"]),
                                          SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                                          DiaChi = (string)((r["DiaChi"] == System.DBNull.Value) ? null : r["DiaChi"]),
                                          LoaiHinhTiepNhan = (Boolean)((r["LoaiHinhTiepNhan"] == System.DBNull.Value) ? null : r["LoaiHinhTiepNhan"]),
                                          Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                          NoiDungYeuCau = (string)((r["NoiDungYeuCau"] == System.DBNull.Value) ? null : r["NoiDungYeuCau"]),
                                          Ids = MyModels.Encode((int)r["Id"], SecretId),
                                      }).FirstOrDefault();
            return Item;
        }

        public static dynamic SaveItem(Phieu_DangKySuaChua dto)
        {
            DateTime NgayDang = DateTime.ParseExact(DateTime.Now.ToString("d/M/yyyy HH:mm:ss"), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKySuaChua",
            new string[] { "@flag", "@Id", "@TenKH", "@SoDT", "@DiaChi", "@Status", "@CreatedBy", "@UpdatedBy", "@CreatedAt", "@UpdatedAt", "@LoaiHinhTiepNhan", "@NhanVienKhaoSat", "@Deleted", "@NgayTao", "@NoiDungYeuCau" },
            new object[] { "SaveItem", dto.Id, dto.TenKH, dto.SoDT, dto.DiaChi, dto.Status, dto.CreatedBy, dto.UpdatedBy, dto.CreatedAt, dto.UpdatedAt, dto.LoaiHinhTiepNhan, dto.NhanVienKhaoSat, dto.Deleted, NgayDang, dto.NoiDungYeuCau });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic DeleteItem(Phieu_DangKySuaChua dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKySuaChua",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(Phieu_DangKySuaChua dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKySuaChua",
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
