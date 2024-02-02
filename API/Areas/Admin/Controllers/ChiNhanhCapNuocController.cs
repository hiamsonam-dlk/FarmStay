using API.Areas.Admin.Models.ChiNhanhCapNuoc;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChiNhanhCapNuocController : Controller
    {
        public IActionResult Index([FromQuery] SearchChiNhanhCapNuoc dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ChiNhanhCapNuocModel data = new ChiNhanhCapNuocModel() { SearchData = dto };
            data.ListItems = ChiNhanhCapNuocService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            return View(data);
        }

        public IActionResult SaveItem(string Id = null)
        {
            ChiNhanhCapNuocModel data = new ChiNhanhCapNuocModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC == 0)
            {
                data.Item = new ChiNhanhCapNuoc() { };
            }
            else
            {
                data.Item = ChiNhanhCapNuocService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }


            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(ChiNhanhCapNuoc model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            ChiNhanhCapNuocModel data = new ChiNhanhCapNuocModel() { Item = model };

            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedAt = DateTime.Now;
                    model.UpdatedAt = DateTime.Now;
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    ChiNhanhCapNuocService.SaveItem(model);
                    if (model.Id > 0)
                    {
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                    }
                    else
                    {
                        TempData["MessageSuccess"] = "Thêm mới thành công";
                    }
                    return RedirectToAction("Index");
                }
            }
            return View(data);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ChiNhanhCapNuoc model = new ChiNhanhCapNuoc() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    ChiNhanhCapNuocService.DeleteItem(model);
                    TempData["MessageSuccess"] = "Xóa thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Xóa Không thành công";
                    return Json(new MsgError());
                }

            }
            catch
            {
                TempData["MessageSuccess"] = "Xóa không thành công";
                return Json(new MsgError());
            }


        }
    }
}
