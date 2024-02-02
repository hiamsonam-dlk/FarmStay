using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using API.Areas.Admin.Models.Partial;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace API.Areas.Admin.Models.Phieu_DangKyLapMoi
{
    public class Phieu_DangKyLapMoi
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        [Display(Name = "Tên khách hàng")]
        [Required(ErrorMessage = "Tên khách hàng không được để trống!")]
        public string TenKH { get; set; }
        public string NhanVienKhaoSat { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string SoDT { get; set; }
        public List<Image> HinhAnhDinhKem { get; set; }
        [Display(Name = "Địa Chỉ")]
        [Required(ErrorMessage = "Vui lòng chọn địa chỉ!")]
        public string DiaChi { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Vui lòng chọn mục đích sử dụng!")]
        public int MucDichSuDung { get; set; }
        //[Range(1, Int32.MaxValue, ErrorMessage = "Vui lòng chọn chi nhánh!")]
        public int ChiNhanh { get; set; }
        public bool LoaiHinhTiepNhan { get; set; }
        public int Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Str_ListFile { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn hình cho mục CCCD/CMND mặt trước.")]
        [DataType(DataType.Upload)]
        public IFormFile ImageCCCDtr { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn hình cho mục CCCD/CMND mặt sau.")]
        [DataType(DataType.Upload)]
        public IFormFile ImageCCCDsa { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn hình cho mục giấy chứng nhận quyền sử dụng đất.")]
        [DataType(DataType.Upload)]
        public IFormFile ImageQSDDtr { get; set; }
        public IFormFile ImageQSDDsa { get; set; }
        public string HinhAnhCCCDtr { get; set; }
        public string HinhAnhQSDDtr { get; set; }
        public string HinhAnhQSDDsa { get; set; }
        public string HinhAnhCCCDsa { get; set; }
        public int IdQuanHuyen { get; set; }
        public int IdPhuongXa { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class Image
    {
        public string ImagePath { get; set; }
    }

    public class Phieu_DangKyLapMoiModel
    {
        public Phieu_DangKyLapMoi Item { get; set; }
        public List<Phieu_DangKyLapMoi> ListItems { get; set; }
        public SearchPhieu_DangKyLapMoi SearchData { get; set; }
        public List<SelectListItem> ListItemsStatus { get; set; }
        public List<SelectListItem> ListItemsLoaiHinhDangKy { get; set; }
        public List<SelectListItem> ListItemsChiNhanhCapNuoc { get; set; }
        public List<SelectListItem> ListItemsMucDichSuDung { get; set; }
        public List<SelectListItem> ListItemsQuanHuyen { get; set; }
        public List<SelectListItem> ListItemsPhuongXa { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchPhieu_DangKyLapMoi
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
