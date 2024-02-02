using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.ChiNhanhCapNuoc
{
    public class ChiNhanhCapNuoc
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string SoDT { get; set; }
        public string TenChiNhanh { get; set; }
        public string DiaChi { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class ChiNhanhCapNuocModel
    {
        public List<SelectListItem> ListChiNhanhDanhMuc { get; set; }
        public ChiNhanhCapNuoc Item { get; set; }
        public List<ChiNhanhCapNuoc> ListItems { get; set; }
        public SearchChiNhanhCapNuoc SearchData { get; set; }
    }

    public class SearchChiNhanhCapNuoc
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int Status { get; set; } = -1;
    }
}
