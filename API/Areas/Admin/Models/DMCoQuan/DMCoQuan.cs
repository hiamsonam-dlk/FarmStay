using API.Areas.Admin.Models.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;


namespace API.Areas.Admin.Models.DMCoQuan
{
    public class DMCoQuan
    {
        public int Id { get; set; }

        [Display(Name = "Tên")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Độ dài chuỗi phải lớn hơn {2} Không quá {1} ký tự")]
        [Required(ErrorMessage = "Tên cơ quan không được để trống")]


        public string Title { get; set; }
        public string Title1 { get; set; }
        public string Code { get; set; }
        public object Description { get; set; }        
        public Boolean Status { get; set; }       
        public string Ids { get; set; }
        public int TotalRows { get; set; } = 0;
        public int CreatedBy { get; set; } = 0;
        public int ModifiedBy { get; set; } = 0;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Boolean Deleted { get; set; }
        public int ParentId { get; set; }
        public int CategoryId { get; set; }
        public int Selected { get; set; }
        public string TitleCategory { get; set; }
        public int IdLayout { get; set; } = 0;
        public string Title_1 { get; set; }
        public string Title_2 { get; set; }
        public string Title_3 { get; set; }
        public Metadata MetadataCV { get; set; }
        public string Metadata { get; set; }
    }

    public class Metadata
    {
        //public string UrlImage { get; set; }
        //public string UrlIcon { get; set; }
        //public string MailSettingsEmail { get; set; }
        //public string MailSettingsDisplayName { get; set; }
        //public string MailSettingsPassword { get; set; }
        //public string MailSettingsHost { get; set; }
        //public string MailSettingsPort { get; set; }
        //public string Placename { get; set; }
        //public string Position { get; set; }
        //public string Region { get; set; }
        //public string MST { get; set; }
        //public string ThuTucHanhChinh { get; set; }
        //public string ThuTucHanhChinhXa { get; set; }
        //public string ThuTucHanhChinhHuyen { get; set; }
        //public string Favicon { get; set; }
        //public string DescNewsHot { get; set; }
        //public string DescNewsFeatured { get; set; }
        //public string DescFooter { get; set; }
        //public string DataFooter { get; set; }
        //public string DescImages { get; set; }
        //public int FlagSession { get; set; } = 1;
        //public int FlagComment { get; set; } = 0;
        //public int FlagVideosHome { get; set; } = 0;
        //public int FlagAuthorText { get; set; } = 0;
        //public string FacebookVerification { get; set; }
        //public string ZaloVerification { get; set; }
        //public string FBAppId { get; set; }
        //public string ZaloAppId { get; set; }
        //public string LinkBanDo { get; set; }
        public string SmartVoiceTokenID { get; set; }
        public string SmartVoiceTokenKey { get; set; }
        public string SmartVoiceAccessToken { get; set; }
        public string SmartVoiceRegion { get; set; } = "female_north";
        public int SmartVoiceSpeed { get; set; } = 1;
        //public string FacebookFanpage { get; set; }
        //public string FacebookApp { get; set; }
        //public string LinkIPV6 { get; set; }
        //public int flagDisMarqueeHome { get; set; } = 0;
        //public int MarqueeSpeed { get; set; } = 100;
        //public int MarqueeGap { get; set; } = 100;
        //public string MarqueeDirection { get; set; } = "left";
        //public int flagTaiLieuHop { get; set; } = 0;

    }
    public class DMCoQuanModel
    {
        public List<DMCoQuan> ListItems { get; set; }
        public List<SelectListItem> ListItemsCoQuan { get; set; }
        public List<SelectListItem> ListItemsLoaiCoQuan { get; set; }
        public List<SelectListItem> ListItemsLayout { get; set; }
        public SearchDMCoQuan SearchData { get; set; }
        public DMCoQuan Item { get; set; }
        public PartialPagination Pagination { get; set; }
    }
    public class SearchDMCoQuan
    {
        public int CategoryId { get; set; }
        public int ParentId { get; set; }
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public string Keyword { get; set; }
    }
}
