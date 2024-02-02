using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace API.Areas.Admin.Models.QuestionTemplate
{
    public class QuestionTemplate
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public int IdService { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Boolean Deleted { get; set; }
        public Boolean Displayed { get; set; }
    }

    public class QuestionTemplateModel
    {
        public List<SelectListItem> ListService { get; set; }
        public QuestionTemplate Item { get; set; }
        public List<QuestionTemplate> ListItems { get; set; }
        public SearchQuestionTemplate SearchData { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchQuestionTemplate
    {
        public int IdService { get; set; }
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }

}
