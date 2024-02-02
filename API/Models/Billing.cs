using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace API.Models
{
    public class Billing
    {
        public string MaKH { get; set; }
        public string Message { get; set; }
        public string KyHienTaiTuThang { get; set; }
        public string KyHienTaiDenThang { get; set; }
        public string KyHienTaiTuNam { get; set; }
        public string KyHienTaiDenNam { get; set; }
    }
    public class BillingModel
    {
        public Billing Item { get; set; }
        public List<SelectListItem> KyHoaDonTuThangList { get; set; }
        public List<SelectListItem> KyHoaDonTuNamList { get; set; }
        public List<SelectListItem> KyHoaDonDenThangList { get; set; }
        public List<SelectListItem> KyHoaDonDenNamList { get; set; }
        public List<CustomerWebGen> InvoiceList { get; set; }
    }
}
