using API.Models;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;

namespace API.Areas.Admin.Models.QuestionTemplate
{
    public class QuestionTemplateService
    {
        public static List<QuestionTemplate> GetListPagination(SearchQuestionTemplate dto, string SecretId)
        {
            string service = "";
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
            if(dto.IdService == 0)
            {
                service = "GetListPagination_sv0";
            }
            if(dto.IdService != 0)
            {
                service = "GetListPagination";
            }
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_QuestionTemplate",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword", "@IdService" },
                new object[] { service, dto.CurrentPage, dto.ItemsPerPage, dto.Keyword, dto.IdService });
            if (tabl == null)
            {
                return new List<QuestionTemplate>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new QuestionTemplate
                        {
                            Id = (int)r["Id"],
                            Question = (string)((r["Question"] == System.DBNull.Value) ? null : r["Question"]),
                            Answer = (string)((r["Answer"] == System.DBNull.Value) ? null : r["Answer"]),
                            Displayed = (bool)((r["Displayed"] == System.DBNull.Value) ? null : r["Displayed"]),
                            Ids = MyModels.Encode((int)r["Id"], SecretId),
                            TotalRows = (int)r["TotalRows"],
                        }).ToList();
            }
        }

        public static List<QuestionTemplate> GetListByService(int IdDv)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_QuestionTemplate",
                new string[] { "@flag", "@IdService" }, new object[] { "GetListByService", IdDv });
            if (tabl == null)
            {
                return new List<QuestionTemplate>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new QuestionTemplate
                        {
                            Id = (int)r["Id"],
                            Question = (string)((r["Question"] == System.DBNull.Value) ? null : r["Question"]),
                            Answer = (string)((r["Answer"] == System.DBNull.Value) ? null : r["Answer"]),
                            Displayed = (bool)((r["Displayed"] == System.DBNull.Value) ? null : r["Displayed"]),
                        }).ToList();
            }

        }

        public static QuestionTemplate GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_QuestionTemplate",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new QuestionTemplate
                    {
                        Id = (int)r["Id"],
                        Question = (string)((r["Question"] == System.DBNull.Value) ? null : r["Question"]),
                        Answer = (string)((r["Answer"] == System.DBNull.Value) ? null : r["Answer"]),
                        Displayed = (bool)((r["Displayed"] == System.DBNull.Value) ? null : r["Displayed"]),
                        Deleted = (Boolean)r["Deleted"],
                        IdService = (int)r["IdService"],
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(QuestionTemplate dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_QuestionTemplate",
            new string[] { "@flag", "@Id", "@IdService", "@Displayed", "@Question", "@Answer"},
            new object[] { "SaveItem", dto.Id, dto.IdService, dto.Displayed, dto.Question, dto.Answer});
            try {
                return (from r in tabl.AsEnumerable()
                        select new
                        {
                            N = (int)(r["N"]),
                        }).FirstOrDefault();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static dynamic DeleteItem(QuestionTemplate dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_QuestionTemplate",
            new string[] { "@flag", "@Id"},
            new object[] { "DeleteItem", dto.Id});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
    }
}
