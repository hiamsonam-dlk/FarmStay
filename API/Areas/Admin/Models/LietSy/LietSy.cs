using API.Areas.Admin.Models.Partial;
using System;
using System.Collections.Generic;

namespace API.Areas.Admin.Models.LietSy
{
    public class LietSy
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public string Name { get; set; }
        public string Ten { get; set; }
        public int Id { get; set; }
        public string NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string Country { get; set; }

        public string NamMat { get; set; }
        public string ChucVu { get; set; }
        public string ChucVu_EN { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int TinhThanh { get; set; }
    }
    public class LietSyModel
    {
        public LietSy Item { get; set; }
        public List<LietSy> ListItems { get; set; }
        public SearchLietSy SearchData { get; set; }
        public PartialPagination Pagination { get; set; }

        public class SearchLietSy
        {
            public int CurrentPage { get; set; }
            public int ItemsPerPage { get; set; }
            public string Keyword { get; set; }
            public int Status { get; set; } = -1;
            public string ShowStartDate { get; set; } = "01/01/1800";
            public string ShowEndDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
