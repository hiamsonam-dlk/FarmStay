using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Questions;
using Microsoft.AspNetCore.Mvc;
using reCAPTCHA.AspNetCore;

namespace API.Controllers
{

    public class QuestionsController : Controller
    {
        private readonly IRecaptchaService _recaptcha;
        public QuestionsController(IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
        }
             

        public IActionResult List([FromQuery] SearchQuestions dto,int EventId = 0)
        {
            dto.Type = 1;
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            QuestionsModel data = new QuestionsModel() { SearchData = dto };
            data.ListItems = QuestionsService.GetListPaginationFront(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.eID = EventId;

            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            return View(data);
        }

        public IActionResult Index()
        {
            QuestionsModel data = new QuestionsModel() {
                SearchData = new SearchQuestions() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" },
                Item = new Questions()
            };                        
            return View(data);            
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Questions model)
        {
            //string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            var recaptcha = await _recaptcha.Validate(Request);
            
            QuestionsModel data = new QuestionsModel() { Item = model };
            data.Item.Type = 1;
            data.Item.Status = false;
            data.Item.CreatedDate = DateTime.Now;
            if (!recaptcha.success)
            {
                ModelState.AddModelError("Recaptcha", "Mã Captcha không chính xác. Vui lòng thử lại!");
            }
            else
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
                        QuestionsService.SaveItem(model);
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