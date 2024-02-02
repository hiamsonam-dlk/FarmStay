using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Contacts;
using API.Models.MyHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using reCAPTCHA.AspNetCore;

namespace API.Controllers
{

    public class ContactsController : Controller
    {
        private IConfiguration Configuration;
        public ContactsController(IConfiguration config)
        {
            Configuration = config;
        }


        public IActionResult Index()
        {
            ContactsModel data = new ContactsModel() {
                SearchData = new SearchContacts() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" },
                Item = new Contacts()
            };                        
            return View(data);            
        }

        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contacts model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            Boolean CheckGoogle = Google.CheckGoogle(Configuration["RecaptchaSettings:SecretKey"], model.TokenRecaptcha);


            ContactsModel data = new ContactsModel() { Item = model };
            data.Item.Type = 1;
            data.Item.Status = false;
            data.Item.CreatedDate = DateTime.Now;
            if (CheckGoogle)
            {
                if (ModelState.IsValid)
                {
                    model.Id = 0;
                    model.CreatedBy = 0;
                    model.ModifiedBy = 0;
                    model.Type = 1;
                    model.CreatedBy = 1;
                    try
                    {
                        ContactsService.SaveItem(model);
                        TempData["MessageSuccess"] = "Gửi thông tin thành công. Câu hỏi của bạn sẽ được phản hồi trong thời gian sớm nhất";                       
                    }
                    catch {
                        TempData["MessageError"] = "Gửi thông tin thất bại. Xin vui lòng gửi lại";
                        
                    }
                    return RedirectToAction("Index");

                }
            }

            return View(data);
        }

    }
}