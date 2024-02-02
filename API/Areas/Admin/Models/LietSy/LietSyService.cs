using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System;
using static API.Areas.Admin.Models.LietSy.LietSyModel;
using System.Linq;
using EnvDTE;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.VisualStudio.OLE.Interop;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace API.Areas.Admin.Models.LietSy
{
    public class LietSyService
    {
        public static List<LietSy> GetListPagination(SearchLietSy dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LietSy",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@StartDate", "@EndDate", "@Status" },
                new object[] { str_sql, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, StartDate, EndDate, dto.Status });
            if (tabl == null)
            {
                return new List<LietSy>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new LietSy
                        {
                            Id = (int)r["Id"],
                            Name = (string)((r["Name"] == System.DBNull.Value) ? null : r["Name"]),
                            ChucVu = (string)((r["ChucVu"] == System.DBNull.Value) ? null : r["ChucVu"]),
                            NamSinh = (string)((r["NamSinh"] == System.DBNull.Value) ? null : r["NamSinh"]),
                            TinhThanh = (int)((r["TinhThanh"] == System.DBNull.Value) ? null : r["TinhThanh"]),
                            NamMat = (string)((r["NamMat"] == System.DBNull.Value) ? null : r["NamMat"]),
                            QueQuan = (string)((r["QueQuan"] == System.DBNull.Value) ? null : r["QueQuan"]),
                            Status = (bool)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                            TotalRows = (int)r["TotalRows"],

                        }).ToList();
            }
        }

        public static List<LietSy> GetList()
        {
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LietSy",
            new string[] { "@flag"},
            new object[] { "GetList"});
            if (tabl == null)
            {
                return new List<LietSy>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                select new LietSy
                {
                    Id = (int)r["Id"],
                    Name = (string)((r["Name"] == System.DBNull.Value) ? null : r["Name"]),
                            ChucVu = (string)((r["ChucVu"] == System.DBNull.Value) ? null : r["ChucVu"]),
                            NamSinh = (string)((r["NamSinh"] == System.DBNull.Value) ? null : r["NamSinh"]),
                            TinhThanh = (int)((r["TinhThanh"] == System.DBNull.Value) ? null : r["TinhThanh"]),
                            NamMat = (string)((r["NamMat"] == System.DBNull.Value) ? null : r["NamMat"]),
                            QueQuan = (string)((r["QueQuan"] == System.DBNull.Value) ? null : r["QueQuan"]),
                            Status = (bool)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
                            CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                            TotalRows = (int)r["TotalRows"],

                        }).ToList();
            }
        }

        public static LietSy GetItem(decimal Id, string SecretId = null, string LangId = "VI")
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LietSy",
            new string[] { "@flag", "@Id", "@LangId" }, new object[] { "GetItem", Id, LangId });
            LietSy Item = (from r in tabl.AsEnumerable()
                            select new LietSy
                            {
                                Id = (int)r["Id"],
                                Name = (string)((r["Name"] == System.DBNull.Value) ? null : r["Name"]),
                                ChucVu = (string)((r["ChucVu"] == System.DBNull.Value) ? null : r["ChucVu"]),
                                NamSinh = (string)((r["NamSinh"] == System.DBNull.Value) ? null : r["NamSinh"]),
                                NamMat = (string)((r["NamMat"] == System.DBNull.Value) ? null : r["NamMat"]),
                                QueQuan = (string)((r["QueQuan"] == System.DBNull.Value) ? null : r["QueQuan"]),
                                TinhThanh = (int)((r["TinhThanh"] == System.DBNull.Value) ? null : r["TinhThanh"]),
                                Status = (bool)((r["Status"] == System.DBNull.Value) ? 1 : r["Status"]),
                                CreatedBy = (string)((r["CreatedBy"] == System.DBNull.Value) ? null : r["CreatedBy"]),
                                UpdatedBy = (string)((r["UpdatedBy"] == System.DBNull.Value) ? null : r["UpdatedBy"]),
                                CreatedAt = (DateTime)((r["CreatedAt"] == System.DBNull.Value) ? null : r["CreatedAt"]),
                                UpdatedAt = (DateTime?)((r["UpdatedAt"] == System.DBNull.Value) ? null : r["UpdatedAt"]),
                                Deleted = (Boolean)((r["Deleted"] == System.DBNull.Value) ? null : r["Deleted"]),
                                Ids = MyModels.Encode((int)r["Id"], SecretId),
                            }).FirstOrDefault();
            return Item;
        }

        public static dynamic SaveItem(LietSy dto)
        {
            DateTime NgayDang = DateTime.ParseExact(DateTime.Now.ToString("d/M/yyyy HH:mm:ss"), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LietSy",
            new string[] { "@flag", "@Id", "@Name", "@NamSinh", "@ChucVu", "@NamMat", "@QueQuan", "@TinhThanh", "@Status", "@CreatedBy", "@UpdatedBy", "@CreatedAt", "@UpdatedAt", "@Deleted", "@NgayTao" },
            new object[] { "SaveItem", dto.Id, dto.Name, dto.NamSinh, dto.ChucVu, dto.NamMat, dto.QueQuan, dto.TinhThanh, dto.Status, dto.CreatedBy, dto.UpdatedBy, dto.CreatedAt, dto.UpdatedAt, dto.Deleted, NgayDang });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic DeleteItem(LietSy dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LietSy",
            new string[] { "@flag", "@Id", "@UpdatedBy" },
            new object[] { "DeleteItem", dto.Id, dto.UpdatedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(LietSy dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_LietSy",
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
