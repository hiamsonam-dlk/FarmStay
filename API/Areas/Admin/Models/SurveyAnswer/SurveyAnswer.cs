using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
namespace API.Areas.Admin.Models.SurveyAnswer
{
    public class SurveyAnswer
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string QuestionTitle { get; set; }
        public string SurveyTitle { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn 1 phương án")]
        [Range(1, Double.MaxValue, ErrorMessage = "Vui lòng chọn 1 phương án.")]
        public int QuestionId { get; set; }
      
        public int SurveyId { get; set; }        
        public string Ids { get; set; }
        public int TotalRows { get; set; } = 0;
        public int CreatedBy { get; set; } = 0;
        public int ModifiedBy { get; set; } = 0;
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }

    public class SurveyAnswerModel {
        public List<SurveyAnswer> ListItems { get; set; }       
        public SearchSurveyAnswer SearchData { get; set; }
        public SurveyAnswer Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }
    public class SearchSurveyAnswer {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
		public int QuestionId { get; set; }        
        public int SurveyId { get; set; }
    }
}
