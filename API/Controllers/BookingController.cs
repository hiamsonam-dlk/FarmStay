using API.Areas.Admin.Models.Booking;
using API.Models.MyHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace API.Controllers
{
    public class BookingController : Controller
    {
        private IConfiguration Configuration;
        public BookingController(IConfiguration config)
        {
            Configuration = config;
        }

        [HttpPost]
        public async Task<ActionResult> SaveItem(Booking data)
        {
            BookingModel model = new BookingModel() { Item = data };
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            API.Models.MyHelper.Google Google = new API.Models.MyHelper.Google();
            Boolean CheckGoogle = Google.CheckGoogle(Configuration["RecaptchaSettings:SecretKey"], data.TokenRecaptcha);
            //Boolean CheckGoogle = true;
            if (CheckGoogle)
            {
                if (ModelState.IsValid)
                {
                    model.Item.CreatedBy = data.SoDT;
                    model.Item.CreatedAt = DateTime.Now;
                    try
                    {
                        BookingService.SaveItem(model.Item);
                        TempData["MessageSuccess"] = "Đã gửi yêu cầu đặt xe thành công, xin vui lòng đợi tài xế ít phút!";
                        return View("~/Views/Home/Index.cshtml");
                    }
                    catch { throw; }
                }
            }
            else
            {
                TempData["MessageSuccess"] = "Có lỗi khi xác minh, vui lòng thử lại!";
            }
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
