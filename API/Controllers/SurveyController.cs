using API.Areas.Admin.Models.Survey;
using API.Areas.Admin.Models.SurveyAnswer;
using API.Areas.Admin.Models.SurveyQuestion;
using Microsoft.AspNetCore.Mvc;
using reCAPTCHA.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class SurveyController : Controller
    {
        private readonly IRecaptchaService _recaptcha;
        public SurveyController(IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
        }

        public IActionResult Index([FromQuery] SearchSurvey dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            SurveyModel data = new SurveyModel() { SearchData = dto };

            data.ListItems = SurveyService.GetListPagination(data.SearchData, ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            
            return View(data);
        }

        public IActionResult Detail(int id)
        {

            SurveyModel data = new SurveyModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            data.Item = SurveyService.GetItem(id);
            var dto = new SearchSurveyQuestion() { CurrentPage = 1, ItemsPerPage = 100, SurveyId = id };
            data.ListSurveyQuestion = SurveyQuestionService.GetListPagination(dto,"");
  

            if (data.Item == null)
                return RedirectToAction("Index", "Home");

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(SurveyAnswer model)
        {
            var recaptcha = await _recaptcha.Validate(Request);
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            SurveyModel data = new SurveyModel();
            data.Answer = model;
            data.Item = SurveyService.GetItem(model.SurveyId);
            var dto = new SearchSurveyQuestion() { CurrentPage = 1, ItemsPerPage = 100, SurveyId = model.SurveyId };
            data.ListSurveyQuestion = SurveyQuestionService.GetListPagination(dto, "");
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
                   
                        try
                        {
                            SurveyAnswerService.SaveItem(model);
                            TempData["MessageSuccess"] = "Cảm ơn bạn đã tham gia khảo sát.";
                        }
                        catch
                        {
                            TempData["MessageError"] = "Gửi thông tin thất bại. Xin vui lòng gửi lại";
                        }

                    data.Answer = new SurveyAnswer();
                    return RedirectToAction("Detail",new { Id = model.SurveyId });

                }

            }


            return View(data);
        }




    }
}
