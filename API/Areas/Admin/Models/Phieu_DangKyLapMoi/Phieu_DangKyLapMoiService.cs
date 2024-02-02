using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System;
using System.Linq;

namespace API.Areas.Admin.Models.Phieu_DangKyLapMoi
{
    public class Phieu_DangKyLapMoiService
    {
        public static List<Phieu_DangKyLapMoi> GetListPagination(SearchPhieu_DangKyLapMoi dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKyLapMoi",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@MucDichSuDung", "@StartDate", "@EndDate", "@Status", "@ChiNhanh"},
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.MucDichSuDung, StartDate, EndDate, dto.Status, dto.ChiNhanhCapNuoc});
            if (tabl == null)
            {
                return new List<Phieu_DangKyLapMoi>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Phieu_DangKyLapMoi
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

        public static Phieu_DangKyLapMoi GetItem(decimal Id, string SecretId = null, string LangId = "VI")
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKyLapMoi",
            new string[] { "@flag", "@Id", "@LangId" }, new object[] { "GetItem", Id, LangId });
            Phieu_DangKyLapMoi Item = (from r in tabl.AsEnumerable()
                             select new Phieu_DangKyLapMoi
                             {
                                 Id = (int)r["Id"],
                                 IdPhuongXa = (int)r["IdXaPhuong"],
                                 IdQuanHuyen = (int)r["IdQuanHuyen"],
                                 TenKH = (string)((r["TenKH"] == System.DBNull.Value) ? null : r["TenKH"]),
                                 Status = (int)r["Status"],
                                 CreatedBy = (string)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                 UpdatedBy = (string)((r["UpdatedBy"] == System.DBNull.Value) ? null : r["UpdatedBy"]),
                                 CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                                 UpdatedAt = (DateTime?)((r["UpdatedAt"] == System.DBNull.Value) ? null : r["UpdatedAt"]),
                                 NhanVienKhaoSat = (string)((r["NhanVienKhaoSat"] == System.DBNull.Value) ? null : r["NhanVienKhaoSat"]),
                                 SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                                 //Str_ListFile = (string)((r["HinhAnhDinhKem"] == System.DBNull.Value) ? null : r["HinhAnhDinhKem"]),
                                 HinhAnhCCCDtr = (string)((r["HinhAnhCCCDtr"] == System.DBNull.Value) ? null : r["HinhAnhCCCDtr"]),
                                 HinhAnhCCCDsa = (string)((r["HinhAnhCCCDsa"] == System.DBNull.Value) ? null : r["HinhAnhCCCDsa"]),
                                 HinhAnhQSDDtr = (string)((r["HinhAnhQSDDtr"] == System.DBNull.Value) ? null : r["HinhAnhQSDDtr"]),
                                 HinhAnhQSDDsa = (string)((r["HinhAnhQSDDsa"] == System.DBNull.Value) ? null : r["HinhAnhQSDDsa"]),
                                 DiaChi = (string)((r["DiaChi"] == System.DBNull.Value) ? null : r["DiaChi"]),
                                 MucDichSuDung = (int)((r["MucDichSuDung"] == System.DBNull.Value) ? null : r["MucDichSuDung"]),
                                 ChiNhanh = (int)((r["ChiNhanh"] == System.DBNull.Value) ? null : r["ChiNhanh"]),
                                 LoaiHinhTiepNhan = (Boolean)((r["LoaiHinhTiepNhan"] == System.DBNull.Value) ? null : r["LoaiHinhTiepNhan"]),
                                 Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                 Ids = MyModels.Encode((int)r["Id"], SecretId),
                             }).FirstOrDefault();
            //if (Item.Str_ListFile != null && Item.Str_ListFile != "")
            //{
            //    Item.HinhAnhDinhKem = JsonConvert.DeserializeObject<List<Image>>(Item.Str_ListFile);
            //}
            return Item;
        }

        public static dynamic SaveItem(Phieu_DangKyLapMoi dto)
        {
            //string Str_ListFile = null;
            //List<Image> ListFileArticle = new List<Image>();

            //if (dto.HinhAnhDinhKem != null && dto.HinhAnhDinhKem.Count() > 0)
            //{
            //    for (int i = 0; i < dto.HinhAnhDinhKem.Count(); i++)
            //    {
            //        if (dto.HinhAnhDinhKem[i].ImagePath != null && dto.HinhAnhDinhKem[i].ImagePath.Trim() != "")
            //        {
            //            ListFileArticle.Add(dto.HinhAnhDinhKem[i]);
            //        }
            //    }
            //    if (ListFileArticle != null && ListFileArticle.Count() > 0)
            //    {
            //        Str_ListFile = JsonConvert.SerializeObject(ListFileArticle);
            //    }

            //}
            DateTime NgayDang = DateTime.ParseExact(DateTime.Now.ToString("d/M/yyyy HH:mm:ss"), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKyLapMoi",
            new string[] { "@flag", "@Id", "@TenKH", "@SoDT", "@DiaChi", "@MucDichSuDung", "@ChiNhanh", "@Status", "@CreatedBy", "@UpdatedBy", "@CreatedAt", "@UpdatedAt", "@LoaiHinhTiepNhan", "@NhanVienKhaoSat","@Deleted", "@NgayTao", "@HinhAnhCCCDtr", "@HinhAnhCCCDsa", "@HinhAnhQSDDtr", "@HinhAnhQSDDsa", "@IdQuanHuyen", "@IdXaPhuong" },
            new object[] { "SaveItem", dto.Id, dto.TenKH, dto.SoDT, dto.DiaChi, dto.MucDichSuDung, dto.ChiNhanh, dto.Status, dto.CreatedBy, dto.UpdatedBy, dto.CreatedAt, dto.UpdatedAt, dto.LoaiHinhTiepNhan, dto.NhanVienKhaoSat, dto.Deleted, NgayDang ,dto.HinhAnhCCCDtr, dto.HinhAnhCCCDsa, dto.HinhAnhQSDDtr, dto.HinhAnhQSDDsa, dto.IdQuanHuyen, dto.IdPhuongXa});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic DeleteItem(Phieu_DangKyLapMoi dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKyLapMoi",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(Phieu_DangKyLapMoi dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKyLapMoi",
            new string[] { "@flag", "@Id", "@Status", "@UpdatedBy" },
            new object[] { "UpdateStatus", dto.Id, dto.Status, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateNVKhaoSat(Phieu_DangKyLapMoi dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Phieu_DangKyLapMoi",
            new string[] { "@flag", "@Id", "@Status", "@UpdatedBy", "@NhanVienKhaoSat" },
            new object[] { "UpdateNVKhaoSat", dto.Id, dto.Status, dto.UpdatedBy, dto.NhanVienKhaoSat });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

    }
}
