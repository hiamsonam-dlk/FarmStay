using System;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.SiteVisit;
namespace API.Controllers
{
    public class SiteVisitController : Controller
    {
        public IActionResult Index()
        {
            SiteVisitDetail DateWeek = SiteVisitService.GetByDateWeek();
            SiteVisitDetail GetAll = SiteVisitService.GetAll();
            SiteVisitDetail DateNow = SiteVisitService.GetByDate(DateTime.Now);
            SiteVisitDetail LastDate = SiteVisitService.GetByDate(DateTime.Now.AddDays(-1));
            SiteVisitResult data = new SiteVisitResult()
            {
                Total  = GetAll.Amount
            };
            if (DateWeek != null) {
                data.DateOfWeek = DateWeek.Amount;
            }
            if (DateNow != null) {
                data.DateNow = DateNow.Amount;
            }
            if (LastDate != null) {
                data.Yesterday = LastDate.Amount;
            }
            return Json(data);
        }
    }
}