using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
using API.Areas.Admin.Models.DMCoQuan;
namespace API.Areas.Admin.Models.Menus
{
    public class Menus
    {
		public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public int IdCoQuan { get; set; }
 		public string TenCoQuan { get; set; }
 		public string Title { get; set; }
 		public string Ten { get; set; }
 		public string Alias { get; set; }
 		public int CatId { get; set; }
 		public int StaticId { get; set; }
 		public string Link { get; set; }
 		public string LinkEN { get; set; }
 		public int ParentId { get; set; }
 		public int? ModifiedBy { get; set; }
 		public Boolean? Status { get; set; }
 		public Boolean? Deleted { get; set; }
 		public DateTime? ModifiedDate { get; set; }
 		public int? ArticleId { get; set; }
 		public int? Ordering { get; set; } 		
        public int ChildCount { get; set; }
        public int Type { get; set; }
        public string Icon { get; set; }
        public List<Menus> ListMenus { get; set; }
        public int Position { get; set; }
        public string LangId { get; set; }
        public string Target { get; set; }
        public int Level { get; set; }
    }
	
	public class MenusModel {
        public List<Menus> ListItems { get; set; }       
        public SearchMenus SearchData { get; set; }
        public List<SelectListItem> ListType { get; set; }
        public List<SelectListItem> ListItemsMenus { get; set; }
        public List<SelectListItem> ListItemsArticle { get; set; }
        public List<CategoriesArticles.CategoriesArticles> ListCategoriesArticles { get; set; }
        public List<CategoriesDocuments.CategoriesDocuments> ListCategoriesProducts { get; set; }
        public Menus Item { get; set; }
        public PartialPagination Pagination { get; set; }
        public List<SelectListItem> ListDMCoQuan { get; set; }
        public List<SelectListItem> ListPosition { get; set; }

    }

    public class SearchMenus {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int CatId { get; set; }
        public string Keyword { get; set; }
        public int IdCoQuan { get; set; } = 1;
        public string LangId { get; set; }="VI";
        public int Position { get; set; } = 1;

    }
}
