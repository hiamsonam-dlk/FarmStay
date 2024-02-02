using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace API.Areas.Admin.Models.Phieu_CapNhatChiSo
{
    public class Phieu_CapNhatChiSo
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        [Display(Name = "Hình ảnh minh chứng")]
        [Required(ErrorMessage = "Hình ảnh minh chứng không được để trống!")]
        public IFormFile IHinhAnh { get; set; }
        public int ChiSoCu { get; set; }
        [Range(0, 10000000000000000000, ErrorMessage = "Chỉ số mới phải lớn hơn 0.")]
        public int ChiSoMoi { get; set; }
        public bool LoaiHinhTiepNhan { get; set; } = false;
        public int Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class Phieu_CapNhatChiSoModel
    {
        public Phieu_CapNhatChiSo Item { get; set; }
        public List<Phieu_CapNhatChiSo> ListItems { get; set; }
        public SearchPhieu_CapNhatChiSo SearchData { get; set; }
        public List<SelectListItem> ListItemsStatus { get; set; }
        public List<SelectListItem> ListItemsLoaiHinhDangKy { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchPhieu_CapNhatChiSo
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int Status { get; set; } = 0;
        public int ChiNhanhCapNuoc { get; set; }
        public int MucDichSuDung { get; set; }
        public string ShowStartDate { get; set; } = "01/01/2010";
        public string ShowEndDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
