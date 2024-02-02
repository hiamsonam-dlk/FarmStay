using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace API.Areas.Admin.Models.Phieu_CapNhatThongTin
{
    public class Phieu_CapNhatThongTin
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        public string MaKH { get; set; }
        public string TenKHCu { get; set; }
        public string SoDTCu { get; set; }
        public string DiaChiCu { get; set; }
        public int MucDichSuDungCu { get; set; }
        [Display(Name = "Tên khách hàng")]
        [Required(ErrorMessage = "Tên khách hàng không được để trống!")]
        public string TenKHMoi { get; set; }
        public string SoDTMoi { get; set; }
        [Display(Name = "Địa chỉ khách hàng")]
        [Required(ErrorMessage = "Địa chỉ khách hàng không được để trống!")]
        public string DiaChiMoi { get; set; }
        [Display(Name = "Mục đích sử dụng")]
        [Required(ErrorMessage = "Vui lòng chọn mục đích sử dụng!")]
        public int MucDichSuDungMoi { get; set; }

        public bool LoaiHinhTiepNhan { get; set; } = false;
        public int Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class Phieu_CapNhatThongTinModel
    {
        public Phieu_CapNhatThongTin Item { get; set; }
        public List<Phieu_CapNhatThongTin> ListItems { get; set; }
        public SearchPhieu_CapNhatThongTin SearchData { get; set; }
        public List<SelectListItem> ListItemsStatus { get; set; }
        public List<SelectListItem> ListItemsLoaiHinhDangKy { get; set; }
        public List<SelectListItem> ListItemsMucDichSuDung { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchPhieu_CapNhatThongTin
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
