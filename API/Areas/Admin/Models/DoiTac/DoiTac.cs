using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace API.Areas.Admin.Models.DoiTac
{
    public class ThuTuc
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string TenDoiTac { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Link { get; set; }
        public int SortOrder { get; set; }
        public string HinhAnh { get; set; }
    }

    public class DoiTacModel
    {
        public List<ThuTuc> ListItems { get; set; }
        public SearchDoiTac SearchData { get; set; }
        public ThuTuc Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchDoiTac
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }
}
