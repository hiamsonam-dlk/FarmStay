using API.Areas.Admin.Models.PAKN;
using API.Areas.Admin.Models.QuestionTemplate;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;

namespace API.Controllers
{
    public class QuestionTemplateController : Controller
    {
        [HttpPost]
        public IActionResult GetListQuestionByService(int MaDV)
        {
            QuestionTemplateModel question = new QuestionTemplateModel();
            question.ListItems = QuestionTemplateService.GetListByService(MaDV);
            return Json(question);
        }

        [HttpPost]
        public IActionResult SendMessage(string HoTen, string SoDT, string CauHoi)
        {
            MsgSuccess res = new MsgSuccess();
            try
            {
                PAKN data = new PAKN();
                data.CreatedBy = 1;
                data.ModifiedBy = 1;
                data.CreatedDate = DateTime.Now;
                data.Fullname = HoTen;
                data.Phone = SoDT;
                data.Title = CauHoi;
                PAKNService.SaveItem(data);
                
                res.Msg = "Gửi câu hỏi thành công.";
            }catch(Exception ex)
            {
                res.Msg = "Gửi câu hỏi thất bại.";
            }
            return Json(res);
        }
    }
}
