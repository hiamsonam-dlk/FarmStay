using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Areas.Admin.Models.Booking
{
    public class Booking
    {
        public int Id { get; set; }
        [Display(Name = "Cảm nghĩ")]
        [Required(ErrorMessage = "Cảm nghĩ không được để trống / Please fill your thought!")]
        public string CamNghi { get; set; }
        [Display(Name = "Tên khách hàng")]
        [Required(ErrorMessage = "Họ và tên không được để trống / Please fill your name!")]
        public string TenKhachHang { get; set; }
        public string DonViCongTac { get; set; }
        public string Ids { get; set; }
        public int TotalRows { get; set; }
        public string SoDT { get; set; }
        public int Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string TokenRecaptcha { get; set; }
        public string StrListHinhAnh { get; set; }
        public List<HinhAnh> ListHinhAnh { get; set; }
        public List<IFormFile> IListImage { get; set; }
    }

    public class BookingModel
    {
        public List<SelectListItem> ListItemsStatus { get; set; }
        public Booking Item { get; set; }
        public List<Booking> ListItems { get; set; }
        public SearchBooking SearchData { get; set; }
        public PartialPagination Pagination { get; set; }
    }

    public class HinhAnh
    {
        public string URL { get; set; }
    }

    public class SearchBooking
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
        public int Status { get; set; } = -1;
        public string ShowStartDate { get; set; } = "01/01/2023";
        public string ShowEndDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
