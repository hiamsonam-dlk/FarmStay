using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;

namespace API.Areas.Admin.Models.MucDichSuDung
{
    public class MucDichSuDung
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string TenMucDich { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class MucDichSuDungModel
    {
        public List<SelectListItem> ListMucDichSuDungDanhMuc { get; set; }
        public MucDichSuDung Item { get; set; }
        public List<MucDichSuDung> ListItems { get; set; }
        public SearchMucDichSuDung SearchData { get; set; }
    }

    public class SearchMucDichSuDung
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int Status { get; set; } = -1;
    }
}
