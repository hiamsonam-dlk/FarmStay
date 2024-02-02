using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.DocumentsLevel;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.DocumentsLevel
{
    public class DocumentsLevelService
    {
        public static List<SelectListItem> GetListSelectItems()
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLevel",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", true });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                                              }).ToList();

            ListItems.Insert(0, (new SelectListItem { Text = "--- Cơ quan ban Hành ---", Value = "0" }));
            return ListItems;

        }

        public static DocumentsLevel GetItemByTitle(string Title)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLevel",
            new string[] { "@flag", "@Title" }, new object[] { "GetItem", Title });
            return (from r in tabl.AsEnumerable()
                    select new DocumentsLevel
                    {
                        Id = (int)r["Id"],
                        Alias = (string)((r["Alias"] == System.DBNull.Value) ? null : r["Alias"]),
                        Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"])                      
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(DocumentsLevel dto)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_DocumentsLevel",
            new string[] { "@flag", "@Id", "@Alias", "@Title" },
            new object[] { "SaveItem", dto.Id, dto.Alias, dto.Title });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

    }
}
