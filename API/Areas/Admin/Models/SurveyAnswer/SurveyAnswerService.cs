using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Areas.Admin.Models.SurveyAnswer;
using API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.SurveyAnswer
{
    public class SurveyAnswerService
    {
        

        public static List<SurveyAnswer> GetListPagination(SearchSurveyAnswer dto, string SecretId)
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
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyAnswer",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword });
            if (tabl == null)
            {
                return new List<SurveyAnswer>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new SurveyAnswer
                        {
                            Id = (int)r["Id"],
                            CustomerId = (string)((r["CustomerId"] == System.DBNull.Value) ? "" : r["CustomerId"]),
                            SurveyId = (int)r["SurveyId"],
                            QuestionId = (int)((r["SurveyQuestionId"] == System.DBNull.Value) ? 0 : r["SurveyQuestionId"]),
                            QuestionTitle = (string)((r["SurveyQuestionTitle"] == System.DBNull.Value) ? "" : r["SurveyQuestionTitle"]),
                            SurveyTitle = (string)((r["SurveyTitle"] == System.DBNull.Value) ? "" : r["SurveyTitle"]),
                            FullName = (string)((r["FullName"] == System.DBNull.Value) ? "" : r["FullName"]),
                            Address = (string)((r["Address"] == System.DBNull.Value) ? "" : r["Address"]),
                            Phone = (string)((r["Phone"] == System.DBNull.Value) ? "" : r["Phone"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }


        }


        public static dynamic SaveItem(SurveyAnswer dto)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyAnswer",
            new string[] { "@flag","@Id", "@CustomerId", "@SurveyId", "@SurveyQuestionId", "@CreatedBy", "@ModifiedBy", "@FullName", "@Address", "@Phone" },
            new object[] { "SaveItem", dto.Id, dto.CustomerId, dto.SurveyId, dto.QuestionId, dto.CreatedBy,dto.ModifiedBy,dto.FullName,dto.Address,dto.Phone });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


        public static dynamic DeleteItem(SurveyAnswer dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_SurveyAnswer",
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
