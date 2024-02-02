using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.Phieu_DiDoiNangHa
{
    public class Phieu_DiDoiNangHa
    {
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int Id { get; set; }
        [Display(Name = "Tác vụ")]
        [Required(ErrorMessage = "VUi lòng chọn tác vụ!")]
        public int IdTacVu { get; set; }
        public string TenKH { get; set; }
        //[Display(Name = "Mã khách hàng")]
        //[Required(ErrorMessage = "Mã khách hàng không được để trống!")]
        public string MaKH { get; set; }
        //[Display(Name = "Số điện thoại")]
        //[Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string SoDT { get; set; }
        //[Display(Name = "Nội dung yêu cầu")]
        //[Required(ErrorMessage = "Nội dung yêu cầu không được để trống!")]
        public string NoiDungYeuCau { get; set; }
        //[Display(Name = "Địa chỉ")]
        //[Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string DiaChi { get; set; }
        public bool LoaiHinhTiepNhan { get; set; } = false;
        public int Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string NhanVienKhaoSat { get; set; }
    }

    public class Phieu_DiDoiNangHaModel
    {
        public Phieu_DiDoiNangHa Item { get; set; }
        public List<Phieu_DiDoiNangHa> ListItems { get; set; }
        public SearchPhieu_DiDoiNangHa SearchData { get; set; }
        public List<SelectListItem> ListItemsStatus { get; set; }
        public List<SelectListItem> ListItemsLoaiHinhDangKy { get; set; }
        public List<SelectListItem> ListTacVuDiDoi { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class SearchPhieu_DiDoiNangHa
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
