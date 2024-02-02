using API.Areas.Admin.Models.MucDichSuDung;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MucDichSuDungController : Controller
    {
        public IActionResult Index([FromQuery] SearchMucDichSuDung dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            MucDichSuDungModel data = new MucDichSuDungModel() { SearchData = dto };
            data.ListItems = MucDichSuDungService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            return View(data);
        }

        public IActionResult SaveItem(string Id = null)
        {
            MucDichSuDungModel data = new MucDichSuDungModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC == 0)
            {
                data.Item = new MucDichSuDung() { };
            }
            else
            {
                data.Item = MucDichSuDungService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }


            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(MucDichSuDung model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            MucDichSuDungModel data = new MucDichSuDungModel() { Item = model };

            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedAt = DateTime.Now;
                    model.UpdatedAt = DateTime.Now;
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    MucDichSuDungService.SaveItem(model);
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
            MucDichSuDung model = new MucDichSuDung() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    MucDichSuDungService.DeleteItem(model);
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
