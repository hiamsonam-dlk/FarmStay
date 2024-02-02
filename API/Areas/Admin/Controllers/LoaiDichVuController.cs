using API.Areas.Admin.Models.LoaiDichVu;
using API.Models.Utilities;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiDichVuController : Controller
    {
        public IActionResult Index([FromQuery] SearchLoaiDichVu dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            LoaiDichVuModel data = new LoaiDichVuModel() { SearchData = dto };
            data.ListItems = LoaiDichVuServices.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult SaveItem(string Id = null)
        {
            LoaiDichVuModel data = new LoaiDichVuModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.ListItems = LoaiDichVuServices.GetList();
            data.SearchData = new SearchLoaiDichVu() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            if (IdDC == 0)
            {
                data.Item = new LoaiDichVu() { Status = true };
            }
            else
            {
                data.Item = LoaiDichVuServices.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }


            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveItem(LoaiDichVuModel model)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Item.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            LoaiDichVuModel data = model;
            if (ModelState.IsValid)
            {
                if (model.Item.Id == IdDC)
                {
                    model.Item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.Item.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    var Obj = LoaiDichVuServices.SaveItem(model.Item);
                    if (Obj.N == -2)
                    {
                        TempData["MessageError"] = "Chọn danh mục cha không hợp lệ";
                        data.ListItems = LoaiDichVuServices.GetList();
                        return View(data);
                    }
                    TempData["MessageSuccess"] = "Cập nhật thành công";
                    return RedirectToAction("Index");
                }
            }
            data.ListItems = LoaiDichVuServices.GetList();
            return View(data);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            LoaiDichVu model = new LoaiDichVu() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    LoaiDichVuServices.DeleteItem(model);
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

        [ValidateAntiForgeryToken]
        public ActionResult UpdateStatus([FromQuery] string Ids, Boolean Status)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            LoaiDichVu item = new LoaiDichVu() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = LoaiDichVuServices.UpdateStatus(item);
                    TempData["MessageSuccess"] = "Cập nhật Trạng Thái thành công";
                    return Json(new MsgSuccess());
                }
                else
                {
                    TempData["MessageError"] = "Cập nhật Trạng Thái Không thành công";
                    return Json(new MsgError());
                }
            }
            catch
            {
                TempData["MessageSuccess"] = "Cập nhật Trạng Thái không thành công";
                return Json(new MsgError());
            }
        }
    }
}
