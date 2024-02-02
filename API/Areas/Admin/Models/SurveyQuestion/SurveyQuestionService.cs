using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Areas.Admin.Models.SurveyQuestion;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.SurveyQuestion
{
    public class SurveyQuestionService
    {
        

        public static List<SurveyQuestion> GetListPagination(SearchSurveyQuestion dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword","@SurveyId" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.SurveyId });
            if (tabl == null)
            {
                return new List<SurveyQuestion>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new SurveyQuestion
                        {
                            Id = (int)r["Id"],
                            Title = (string)r["Title"],
                            Status = (bool)r["Status"],
                            TitleSurvey = (string)((r["TitleSurvey"] == System.DBNull.Value) ? "" : r["TitleSurvey"]),
                            SurveyId = (int)((r["SurveyId"] == System.DBNull.Value) ? 0 : r["SurveyId"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }


        }

        public static List<SurveyQuestion> GetList(Boolean Selected = true)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Selected });
            List<SurveyQuestion> ListItems = (from r in tabl.AsEnumerable()
                    select new SurveyQuestion
                    {
                        Id = (int)r["Id"],
                        Title = (string)r["Title"],
                        SurveyId = (int)((r["SurveyId"] == System.DBNull.Value) ? 0 : r["SurveyId"]),
                    }).ToList();
            return ListItems;

        }

        public static List<SelectListItem> GetListSelectItems(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            List<SelectListItem> ListItems = (from r in tabl.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Value = (string)((r["Id"] == System.DBNull.Value) ? null : r["Id"].ToString()),
                                                  Text = (string)((r["Title"] == System.DBNull.Value) ? "" : r["Title"]),
                                              }).ToList();
            ListItems.Insert(0, (new SelectListItem { Text = "--- Chọn Khảo sát---", Value = "0" }));
            return ListItems;

        }

        public static SurveyQuestion GetItem(int Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new SurveyQuestion
                    {
                        Id = (int)r["Id"],
                        Title = (string)r["Title"],
                        Status = (bool)r["Status"],                        
                        SurveyId = (int)((r["SurveyId"] == System.DBNull.Value) ? 0 : r["SurveyId"]),                        
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(SurveyQuestion dto)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
            new string[] { "@flag","@Id", "@Title", "@Status", "@SurveyId", "@CreatedBy", "@ModifiedBy" },
            new object[] { "SaveItem", dto.Id, dto.Title, dto.Status, dto.SurveyId,dto.CreatedBy,dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic UpdateStatus(SurveyQuestion dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
            new string[] { "@flag", "@Id","@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id,dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }

        public static dynamic DeleteItem(SurveyQuestion dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyQuestion",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


    }
}
