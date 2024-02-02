using API.Areas.Admin.Models.Booking;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System;
using System.Linq;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Newtonsoft.Json;

namespace API.Areas.Admin.Models.Booking
{
    public class BookingService
    {
        public static List<Booking> GetListPagination(SearchBooking dto, string SecretId)
        {
            string str_sql = "GetListPagination";
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
            if(dto.Status != -1)
            {
                str_sql = "GetListPagination_Status";
            }
            string StartDate = DateTime.ParseExact(dto.ShowStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string EndDate = DateTime.ParseExact(dto.ShowEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(1).ToString("yyyyMMdd");
            
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Booking",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@StartDate", "@EndDate", "@Status" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, StartDate, EndDate, dto.Status });
            if (tabl == null)
            {
                return new List<Booking>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Booking
                        {
                            Id = (int)r["Id"],
                            CamNghi = (string)((r["CamNghi"] == System.DBNull.Value) ? null : r["CamNghi"]),
                            TenKhachHang = (string)((r["TenKhachHang"] == System.DBNull.Value) ? null : r["TenKhachHang"]),
                            SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                            DonViCongTac = (string)((r["DonViCongTac"] == System.DBNull.Value) ? null : r["DonViCongTac"]),
                            Status = (int)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                            TotalRows = (int)r["TotalRows"],

                        }).ToList();
            }
        }


        public static List<Booking> GetListPaginationClient(SearchBooking dto, string SecretId)
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
            string StartDate = DateTime.ParseExact(dto.ShowStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string EndDate = DateTime.ParseExact(dto.ShowEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(1).ToString("yyyyMMdd");
            string str_sql = "GetListPaginationClient";
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Booking",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@StartDate", "@EndDate" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, StartDate, EndDate });
            if (tabl == null)
            {
                return new List<Booking>();
            }
            else
            {
                var list = (from r in tabl.AsEnumerable()
                        select new Booking
                        {
                            Id = (int)r["Id"],
                            CamNghi = (string)((r["CamNghi"] == System.DBNull.Value) ? null : r["CamNghi"]),
                            TenKhachHang = (string)((r["TenKhachHang"] == System.DBNull.Value) ? null : r["TenKhachHang"]),
                            SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                            DonViCongTac = (string)((r["DonViCongTac"] == System.DBNull.Value) ? null : r["DonViCongTac"]),
                            Status = (int)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                            TotalRows = (int)r["TotalRows"],
                            StrListHinhAnh = (string)((r["StrListHinhAnh"] == System.DBNull.Value) ? null : r["StrListHinhAnh"]),

                        }).ToList();
                foreach (var Item in list)
                {
                    if (Item.StrListHinhAnh != null && Item.StrListHinhAnh != "")
                    {
                        Item.ListHinhAnh = JsonConvert.DeserializeObject<List<HinhAnh>>(Item.StrListHinhAnh);
                    }
                }

                return list; 
            }
        }

        public static List<SelectListItem> GetListItemsStatus()
        {
            List<SelectListItem> ListItems = new List<SelectListItem>();
            ListItems.Insert(0, (new SelectListItem { Text = "--- Trạng Thái ---", Value = "-1"}));
            ListItems.Insert(1, (new SelectListItem { Text = "Tiếp nhận", Value = "0" }));
            ListItems.Insert(2, (new SelectListItem { Text = "Duyệt", Value = "1" }));
            return ListItems;
        }

        public static Booking GetItem(decimal Id, string SecretId = null, string LangId = "VI")
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Booking",
            new string[] { "@flag", "@Id", "@LangId" }, new object[] { "GetItem", Id, LangId });
            Booking Item = (from r in tabl.AsEnumerable()
                                       select new Booking
                                       {
                                           Id = (int)r["Id"],
                                           CamNghi = (string)((r["CamNghi"] == System.DBNull.Value) ? null : r["CamNghi"]),
                                           SoDT = (string)((r["SoDT"] == System.DBNull.Value) ? null : r["SoDT"]),
                                           DonViCongTac = (string)((r["DonViCongTac"] == System.DBNull.Value) ? null : r["DonViCongTac"]),
                                           Status = (int)r["Status"],
                                           TenKhachHang = (string)((r["TenKhachHang"] == System.DBNull.Value) ? null : r["TenKhachHang"]),
                                           CreatedBy = (string)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                           UpdatedBy = (string)((r["UpdatedBy"] == System.DBNull.Value) ? null : r["UpdatedBy"]),
                                           StrListHinhAnh = (string)((r["StrListHinhAnh"] == System.DBNull.Value) ? null : r["StrListHinhAnh"]),
                                           CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                                           UpdatedAt = (DateTime?)((r["UpdatedAt"] == System.DBNull.Value) ? null : r["UpdatedAt"]),
                                           Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                           Ids = MyModels.Encode((int)r["Id"], SecretId),
                                       }).FirstOrDefault();

            if (Item.StrListHinhAnh != null && Item.StrListHinhAnh != "")
            {
                Item.ListHinhAnh = JsonConvert.DeserializeObject<List<HinhAnh>>(Item.StrListHinhAnh);
            }
            return Item;
        }

        public static dynamic SaveItem(Booking dto)
        {
            DateTime NgayDang = DateTime.ParseExact(DateTime.Now.ToString("d/M/yyyy HH:mm:ss"), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Booking",
            new string[] { "@flag", "@Id", "@TenKhachHang", "@CamNghi", "@DonViCongTac", "@SoDT", "@Status", "@CreatedBy", "@UpdatedBy", "@CreatedAt", "@UpdatedAt", "@Deleted", "@NgayTao", "@StrListHinhAnh" },
            new object[] { "SaveItem", dto.Id, dto.TenKhachHang, dto.CamNghi, dto.DonViCongTac, dto.SoDT, dto.Status, dto.CreatedBy, dto.UpdatedBy, dto.CreatedAt, dto.UpdatedAt, dto.Deleted, NgayDang, dto.StrListHinhAnh});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic DeleteItem(Booking dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Booking",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(Booking dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Booking",
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
