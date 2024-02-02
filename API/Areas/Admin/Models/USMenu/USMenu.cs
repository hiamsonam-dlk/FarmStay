using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.USMenu
{
    public class US_USERS_CAT
    {
		public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
 		public string Title { get; set; }
 		public string TreeMenu { get; set; }
 		public string TreePath { get; set; }
 		public string PathName { get; set; }
        public string Controller { get; set; }
        public int IdParent { get; set; }
 		public string Styles { get; set; }
 		public string Description { get; set; }
 		public int SortOrder { get; set; }
        public Boolean Status { get; set; }
        public Boolean onMenu { get; set; }
         public int? CreatedBy { get; set; }
 		public DateTime? CreatedDate { get; set; }
 		public int? ModifiedBy { get; set; }
 		public DateTime? ModifiedDate { get; set; }
 		public Boolean Deleted { get; set; }
 		
    }
	
	public class USMenuModel {
        public List<US_USERS_CAT> ListItems { get; set; }
        public List<SelectListItem> ListItemsMenus { get; set; }
        public SearchUSMenu SearchData { get; set; }
        public US_USERS_CAT Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchUSMenu {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }
}
