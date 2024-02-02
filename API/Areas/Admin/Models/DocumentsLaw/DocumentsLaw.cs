using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Articles;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.DocumentsLaw
{
    public class DocumentsLaw
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Độ dài tiêu đề chuỗi phải lớn hơn {2} Không quá {1} ký tự")]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; }
        public string Alias { get; set; }
        [Display(Name = "Số ký hiệu")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Độ dài Số ký hiệu phải lớn hơn {2} Không quá {1} ký tự")]
    
        public string Code { get; set; }
        public string Introtext { get; set; }
        public string FullText { get; set; }
        public string Link { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedDateShow { get; set; } = DateTime.Now.ToString("dd/MM/yyyyy");
        public int TypeId { get; set; }
        public string FieldName { get; set; }

        [Required(ErrorMessage = "Năm không được để trống")]
        public int Year { get; set; }
        public string TypeTitle { get; set; }

        public string Str_ListFile { get; set; }
        public List<FileArticle> ListFile { get; set; }

    }

    public class DocumentsLawModel
    {
        public List<DocumentsLaw> ListItems { get; set; }
        public SearchDocumentsLaw SearchData { get; set; }
        public DocumentsLaw Item { get; set; }
        public PartialPagination Pagination { get; set; }
        public List<SelectListItem> ListDocumentsType { get; set; }
        public List<SelectListItem> ListItemsStatus { get; set; }
    }

    public class SearchDocumentsLaw
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
        public int Year { get; set; }
        public DateTime IssuedDateStart { get; set; }
        public DateTime IssuedDateEnd { get; set; } = DateTime.Now;
        public string ShowStartDate { get; set; }
        public string ShowEndDate { get; set; } 
        public int Status { get; set; } = -1;

    }
}
