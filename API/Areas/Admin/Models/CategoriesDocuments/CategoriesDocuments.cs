using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.CategoriesDocuments
{
    public class CategoriesDocuments
    {
		public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Độ dài chuỗi phải lớn hơn {2} Không quá {1} ký tự")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Title { get; set; }
 		public string Alias { get; set; }
 		public string Description { get; set; }
 		public int? ParentId { get; set; }
 		public Boolean Status { get; set; }
 		public Boolean Deleted { get; set; }
 		public Boolean FeaturedHome { get; set; }
 		public int CreatedBy { get; set; }
 		public DateTime? CreatedDate { get; set; }
 		public int? ModifiedBy { get; set; }
 		public DateTime? ModifiedDate { get; set; }
 		public string Metadesc { get; set; }
 		public string Metakey { get; set; }
 		public string Metadata { get; set; }
        public IFormFile Icon { get; set; }
        public string Images { get; set; }
        public string Params { get; set; }
        public int? Ordering { get; set; }
        public int? Hits { get; set; }
        public Boolean NoDelete { get; set; }
        public int? Level { get; set; }
        public int Type { get; set; }
        public string LangId { get; set; }
 		
    }
	
	public class CategoriesDocumentsModel {
        public List<CategoriesDocuments> ListItems { get; set; }
        public List<SelectListItem> ListItemsDanhMuc { get; set; }
        public List<SelectListItem> ListItemType { get; set; }
        public List<SelectListItem> ListItemLevel { get; set; }
        public SearchCategoriesDocuments SearchData { get; set; }
        public CategoriesDocuments Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchCategoriesDocuments {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int Level { get; set; } = -1;
    }



    public class CategoriesDocumentsDropDown
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CountChild { get; set; }

    }
}
