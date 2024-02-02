using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
/*https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/validation?view=aspnetcore-2.2*/
namespace API.Areas.Admin.Models.SurveyQuestion
{
    public class SurveyQuestion
    {
        public int Id { get; set; }

        [Display(Name = "Tên")]
        [StringLength(1024, MinimumLength = 3, ErrorMessage= "Độ dài chuỗi phải lớn hơn {2} Không quá {1} ký tự")]
        [Required(ErrorMessage = "Nội dung khảo sát không được để trống")]
        public string Title { get; set; }           
        public string TitleSurvey { get; set; }           
        public Boolean Status { get; set; }
        public int IdCoQuan { get; set; }
        public int SurveyId { get; set; }
        public string SurveyIds { get; set; }
        public string Ids { get; set; }
        public string Token { get; set; }
        public int TotalRows { get; set; } = 0;
        public int CreatedBy { get; set; } = 0;
        public int ModifiedBy { get; set; } = 0;
    }

    public class SurveyQuestionModel {
        public List<SurveyQuestion> ListItems { get; set; }       
        public SearchSurveyQuestion SearchData { get; set; }
        public SurveyQuestion Item { get; set; }
        public PartialPagination Pagination { get; set; }
		public List<SelectListItem> ListSurvey { get; set; }
    }
    public class SearchSurveyQuestion {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int SurveyId { get; set; }
        public string Keyword { get; set; }
        public string SurveyIds { get; set; }
    }
}
