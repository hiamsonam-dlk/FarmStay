using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Articles;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
/*https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/validation?view=aspnetcore-2.2*/
namespace API.Areas.Admin.Models.DuThaoVanBan
{
    public class DuThaoVanBan
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; }
        public string Introtext { get; set; }        
        public Boolean Status { get; set; }
        public int FieldId { get; set; }
        public string FieldTitle { get; set; }
        public int numGopY { get; set; }
        public string TitleField { get; set; }
        public string Link { get; set; }
        public string Ids { get; set; }
        public int TotalRows { get; set; } = 0;
        public int CreatedBy { get; set; } = 0;
        public int ModifiedBy { get; set; } = 0;
        [Required(ErrorMessage = "Ngày hết hạn không được để trống")]
        public DateTime ExpiresDate { get; set; }
        public string ExpiresDateShow { get; set; } = DateTime.Now.AddMonths(6).ToString("dd/MM/yyyyy");

        public string Str_ListFile { get; set; }
        public List<FileArticle> ListFile { get; set; }
        public List<DuThaoVanBanGopY.DuThaoVanBanGopY> ListGopY { get; set; }
    }

    public class DuThaoVanBanModel {
        public List<DuThaoVanBan> ListItems { get; set; }       
        public SearchDuThaoVanBan SearchData { get; set; }
        public DuThaoVanBan Item { get; set; }
        public PartialPagination Pagination { get; set; }
        public List<SelectListItem> ListDocumentsField { get; set; }
    }
    public class SearchDuThaoVanBan {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int FieldId { get; set; }
    }
}
