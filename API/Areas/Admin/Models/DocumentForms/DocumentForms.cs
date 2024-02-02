using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.DocumentForms
{
    public class DocumentForms
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Độ dài tiêu đề chuỗi phải lớn hơn {2} Không quá {1} ký tự")]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; }
        public string Alias { get; set; }      
        public string Introtext { get; set; }
        public string EmbedLink { get; set; }
        public string Images { get; set; }
        public int Year { get; set; }
        public string Link { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedDateShow { get; set; } = DateTime.Now.ToString("dd/MM/yyyyy");

    }

    public class DocumentFormsModel
    {
        public List<DocumentForms> ListItems { get; set; }
        public SearchDocumentForms SearchData { get; set; }
        public DocumentForms Item { get; set; }
        public PartialPagination Pagination { get; set; }      
        public List<SelectListItem> ListItemsStatus { get; set; }
        public List<SelectListItem> ListYear { get; set; }
    }

    public class SearchDocumentForms
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }      
        public int Status { get; set; } = -1;

    }
}
