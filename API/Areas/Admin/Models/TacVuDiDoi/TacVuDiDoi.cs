using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace API.Areas.Admin.Models.TacVuDiDoi
{
    public class TacVuDiDoi
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string TenTacVuDiDoi { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class TacVuDiDoiModel
    {
        public List<SelectListItem> ListTacVuDiDoi { get; set; }
        public TacVuDiDoi Item { get; set; }
        public List<TacVuDiDoi> ListItems { get; set; }
        public SearchTacVuDiDoi SearchData { get; set; }
    }

    public class SearchTacVuDiDoi
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int Status { get; set; } = -1;
    }
}
