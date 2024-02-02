using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.USMenu;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.US_USERS_CAT
{
    public class US_USERS_CATService
    {
     
        public static List<int> GetList(int UserId)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_US_USERS_CAT",
                new string[] { "@flag", "@UserId" }, new object[] { "GetList",UserId});
            if (tabl == null)
            {
                return new List<int>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select (int)r["CatId"]).ToList();
            }

        }

       
      
        public static dynamic SaveItem(US_USERS_CATModel dto)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
         
            foreach (var rw in dto.CatId)
            {
                var row = dt.NewRow();
                row["Id"] = rw;
                dt.Rows.Add(row);
            }


            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_US_USERS_CAT",
            new string[] { "@flag", "@UserId", "@CatId"},
            new object[] { "SaveItem", dto.UserId,dt });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
     


    }
}
