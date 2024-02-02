using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace API.Areas.Admin.Models.LoaiDichVu
{
    public class LoaiDichVu
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string TenLoaiDichVu { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class LoaiDichVuModel
    {
        public List<LoaiDichVu> ListItems { get; set; }
        public SearchLoaiDichVu SearchData { get; set; }
        public LoaiDichVu Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchLoaiDichVu
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }
}
