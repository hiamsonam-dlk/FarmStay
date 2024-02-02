using API.Areas.Admin.Models.Articles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ImportService
    {
        public static async Task<List<Articles>> GetListAll()
        {
            List<Articles> ListItems = new List<Articles>();
            var tabl = await TienIchDB.ExecuteDataTableTask(Startup.OracleConnectionString, "WEP_DPI_SELECT_1",
                new string[] { },
                new object[] { });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                ListItems = (from r in tabl.AsEnumerable()
                             select new Articles
                             {
                                 Title = (string)((r["TUA_DE_BAI_VIET"] == System.DBNull.Value) ? "" : r["TUA_DE_BAI_VIET"]),
                                 Category= (string)((r["LOAI_BAI_VIET"] == System.DBNull.Value) ? "" : r["LOAI_BAI_VIET"]),
                                 IntroText= (string)((r["TRICH_LUOC_BAI_VIET"] == System.DBNull.Value) ? "" : r["TRICH_LUOC_BAI_VIET"]),
                                 FullText = (string)((r["BAI_VIET_FULL"] == System.DBNull.Value) ? "" : r["BAI_VIET_FULL"]),
                                 PublishUpShow = (string)((r["NGAY_BAI_VIET"] == System.DBNull.Value) ? "" : r["NGAY_BAI_VIET"]),
                                 Params = (string)((r["ID_BAI_VIET"] == System.DBNull.Value) ? "" : r["ID_BAI_VIET"]).ToString(),
                                 Metadata = (string)((r["URL_WEB_DPI"] == System.DBNull.Value) ? "" : r["URL_WEB_DPI"])
                                 //MOTA = (string)((r["MOTA"] == System.DBNull.Value) ? "" : r["MOTA"]),
                                 //CAPTINH = (string)((r["CAPTINH"] == System.DBNull.Value) ? "" : r["CAPTINH"]),
                                 ////ALIAS = (string)((r["ALIAS"] == System.DBNull.Value) ? "" : r["ALIAS"]),
                                 //HOTEN = (string)((r["HOTEN"] == System.DBNull.Value) ? "" : r["HOTEN"]),
                                 //LUOTXEM = (decimal)((r["LUOTXEM"] == System.DBNull.Value) ? 0 : r["LUOTXEM"]),
                                 //KIEU = (decimal)((r["KIEU"] == System.DBNull.Value) ? 0 : r["KIEU"]),
                                 //ID = (decimal)((r["ID"] == System.DBNull.Value) ? 0 : r["ID"]),
                             }).ToList();

              
                return ListItems;
            }         

        }

        public static async Task<List<Articles>> GetListRelated()
        {
            List<Articles> ListItems = new List<Articles>();
            var tabl = await TienIchDB.ExecuteDataTableTask(Startup.OracleConnectionString, "WEP_DPI_SELECT_2",
                new string[] { },
                new object[] { });
            if (tabl == null)
            {
                return new List<Articles>();
            }
            else
            {
                ListItems = (from r in tabl.AsEnumerable()
                             select new Articles
                             {
                                 Params = (string)((r["ID_BAI_VIET"] == System.DBNull.Value) ? "" : r["ID_BAI_VIET"]).ToString(),
                                 Title = (string)((r["LOAI_RES"] == System.DBNull.Value) ? "" : r["LOAI_RES"]),
                                 Images= (string)((r["FULL_URL"] == System.DBNull.Value) ? "" : r["FULL_URL"])
                                 //MOTA = (string)((r["MOTA"] == System.DBNull.Value) ? "" : r["MOTA"]),
                                 //CAPTINH = (string)((r["CAPTINH"] == System.DBNull.Value) ? "" : r["CAPTINH"]),
                                 ////ALIAS = (string)((r["ALIAS"] == System.DBNull.Value) ? "" : r["ALIAS"]),
                                 //HOTEN = (string)((r["HOTEN"] == System.DBNull.Value) ? "" : r["HOTEN"]),
                                 //LUOTXEM = (decimal)((r["LUOTXEM"] == System.DBNull.Value) ? 0 : r["LUOTXEM"]),
                                 //KIEU = (decimal)((r["KIEU"] == System.DBNull.Value) ? 0 : r["KIEU"]),
                                 //ID = (decimal)((r["ID"] == System.DBNull.Value) ? 0 : r["ID"]),
                             }).ToList();


                return ListItems;
            }

        }
    }
}
