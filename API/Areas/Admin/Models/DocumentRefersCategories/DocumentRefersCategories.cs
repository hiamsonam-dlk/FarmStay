using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
namespace API.Areas.Admin.Models.DocumentRefersCategories
{
    public class DocumentRefersCategories
    {
		public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
 		public string Title { get; set; }
 		public string Alias { get; set; }
 		public string Description { get; set; }
 		public Boolean Status { get; set; }
 		public Boolean Deleted { get; set; }
 		public int CreatedBy { get; set; }
 		public DateTime? CreatedDate { get; set; }
 		public int? ModifiedBy { get; set; }
 		public DateTime? ModifiedDate { get; set; }
 		
    }
	
	public class DocumentRefersCategoriesModel {
        public List<DocumentRefersCategories> ListItems { get; set; }       
        public SearchDocumentRefersCategories SearchData { get; set; }
        public DocumentRefersCategories Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchDocumentRefersCategories {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }
}
