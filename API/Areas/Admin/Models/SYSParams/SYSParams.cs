using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Areas.Admin.Models.SYSParams
{
    public class SYSParams
    {
        public string IdType { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Introtext { get; set; }
        public string Icon { get; set; }
        public string Alias { get; set; }
        public string EN { get; set; }
        public int Ordering { get; set; }
        public int CountItem { get; set; }
        public Boolean Selected;
    }
    public class SearchSYSParams {
        public Boolean Selected { get; set; }
        public string IdType { get; set; }
        public string Alias { get; set; }
    }

    public class SYSConfigModel
    {
        public SYSConfig Item { get; set; }
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

    public class SYSConfig
    {
        public string WebsiteName { get; set; }
        public string WebsiteNameEN { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameEN { get; set; }
        public string Slogan { get; set; }
        public string SloganEN { get; set; }
        public string Address { get; set; }        
        public string AddressEN { get; set; }        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Footer { get; set; }
        public string FooterEN { get; set; }
        public string SEODescription { get; set; }
        public string SEOKeyword { get; set; }
        public string Contact { get; set; }
        public string Map { get; set; }
        public string Youtube { get; set; }       
        public string CountYTST { get; set; }       
        public string Hotline { get; set; }
        public string GoogleAnalytics { get; set; }
        public string MessengerPlugin { get; set; }
        public string BoCongThuong { get; set; }
        public string ToSuaChua { get; set; }
        public Metadata MetadataCV { get; set; }
        public string Metadata { get; set; }
    }
}