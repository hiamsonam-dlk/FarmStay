using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.DocumentRefers
{
    public class DocumentRefers
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public int CatId { get; set; }
        [Display(Name = "Tên")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Độ dài tiêu đề chuỗi phải lớn hơn {2} Không quá {1} ký tự")]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; }
        public string Alias { get; set; }      
        public string Introtext { get; set; }
        public string Link { get; set; }
        public string Link2 { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedDateShow { get; set; } = DateTime.Now.ToString("dd/MM/yyyyy");
        public string Author { get; set; }

    }

    public class DocumentRefersModel
    {
        public List<DocumentRefers> ListItems { get; set; }
        public List<SelectListItem> ListDocumentsCategories { get; set; }
        public SearchDocumentRefers SearchData { get; set; }

        public DocumentRefers Item { get; set; }
        public PartialPagination Pagination { get; set; }      
        public List<SelectListItem> ListItemsStatus { get; set; }
    }

    public class SearchDocumentRefers
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public string Title { get; set; }
        public int CatId { get; set; }
        public DateTime IssuedDateStart { get; set; }
        public DateTime IssuedDateEnd { get; set; } = DateTime.Now;
       
        public string ShowStartDate { get; set; } = "01/01/1990";
        public string ShowEndDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public int Status { get; set; } = -1;

    }
}
