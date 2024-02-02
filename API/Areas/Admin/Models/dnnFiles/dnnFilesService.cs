using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.dnnFiles;
using API.Models;
namespace API.Areas.Admin.Models.dnnFiles
{
    public class dnnFilesService
    {
              
        public static dnnFiles GetItem(string FileTicket = null)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_dnn_Files",
            new string[] { "@flag", "@FileTicket" }, new object[] { "GetItem", FileTicket });
            return (from r in tabl.AsEnumerable()
                    select new dnnFiles
                    {
                        FileId = (int)r["FileId"],
                        PortalId = (int)r["PortalId"],
                        Folder = (string)((r["Folder"] == System.DBNull.Value) ? null : r["Folder"]),
                        FileName = (string)((r["FileName"] == System.DBNull.Value) ? null : r["FileName"]),
                        Extension = (string)((r["Extension"] == System.DBNull.Value) ? null : r["Extension"]),
                        FileTicket = (string)((r["FileTicket"] == System.DBNull.Value) ? null : r["FileTicket"]),
                    }).FirstOrDefault();
        }





        public static dynamic UpdateFileTicket(dnnFiles dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_dnn_Files",
            new string[] { "@flag", "@FileName", "@FileTicket"},
            new object[] { "UpdateFileTicket", dto.FileName,dto.FileTicket});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateCurrentId(int ArticleId)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_dnn_Files",
            new string[] { "@flag", "@ArticleId" },
            new object[] { "UpdateCurrentId",ArticleId });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


        public static List<Articles.Articles> GetListArticle()
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_dnn_Files",
                new string[] { "@flag" }, new object[] { "GetListArticle"});
            if (tabl == null)
            {
                return new List<Articles.Articles>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Articles.Articles
                        {
                            Id = (int)r["Id"],
                            Title = (string)r["Title"],
                            CatId = (int)r["CatId"],                          
                            FullText = (string)((r["FullText"] == System.DBNull.Value) ? null : r["FullText"]),
                            
                        }).ToList();
            }

        }

    }
}
