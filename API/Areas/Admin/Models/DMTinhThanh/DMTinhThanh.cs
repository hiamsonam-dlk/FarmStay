﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Areas.Admin.Models.DMTinhThanh
{
    public class DMTinhThanh
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int? Id { get; set; }
        public string Ten { get; set; }
        public string TenEN { get; set; }
        public string Ma { get; set; }
        public string MoTa { get; set; }
        public Boolean? TrangThai { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Boolean? Deleted { get; set; }
        public List<LietSy.LietSy> ListLietSy { get; set; }

    }
    public class DMTinhThanhModel
    {
        public List<DMTinhThanh> ListItems { get; set; }
        public List<LietSy.LietSy> ListLietSy { get; set; }
        public SearchDMTinhThanh SearchData { get; set; }
        public DMTinhThanh Item { get; set; }
    }
    public class SearchDMTinhThanh
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }
}
