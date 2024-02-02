using API.Areas.Admin.Models.Phieu_DangKySuaChua;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using API.Areas.Admin.Models.Phieu_CapNhatChiSo;
using API.Areas.Admin.Models.Phieu_DangKySuaChua;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Phieu_DangKySuaChuaController : Controller
    {
        public IActionResult Index([FromQuery] SearchPhieu_DangKySuaChua dto, string btn = "search")
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int TotalItems = 0;
            //if (btn == "excel")
            //{
            //    var ListExcel = Phieu_DangKySuaChuaService.GetListExcel(dto, API.Models.Settings.SecretId + ControllerName, LangId, IDUSER);
            //    var stream = new MemoryStream();
            //    using (var package = new ExcelPackage(stream))
            //    {
            //        var workSheet = package.Workbook.Worksheets.Add("List");
            //        workSheet.Cells.LoadFromCollection(ListExcel, true);
            //        package.Save();
            //    }
            //    stream.Position = 0;
            //    string excelName = $"DanhSachBaiViet-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            //    return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
            //}

            Phieu_DangKySuaChuaModel data = new Phieu_DangKySuaChuaModel() { SearchData = dto };
            data.ListItems = Phieu_DangKySuaChuaService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.ListItemsStatus = Phieu_DangKySuaChuaService.GetListItemsStatus();
            data.ListItemsLoaiHinhDangKy = Phieu_DangKySuaChuaService.GetListItemsLoaiHinhDangKy();
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            HttpContext.Session.SetString("STR_Action_Link_" + ControllerName, Request.QueryString.ToString());
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(data);
        }

        public IActionResult GetItem(string Id = null)
        {
            Phieu_DangKySuaChua Item = new Phieu_DangKySuaChua();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC > 0)
            {
                Item = Phieu_DangKySuaChuaService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return Json(Item);
        }

        public IActionResult SaveItem(string Id = null)
        {
            int IDUSER = int.Parse(HttpContext.Request.Headers["Id"]);
            Phieu_DangKySuaChuaModel data = new Phieu_DangKySuaChuaModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchPhieu_DangKySuaChua() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            data.ListItemsStatus = Phieu_DangKySuaChuaService.GetListItemsStatus();
            data.ListItemsLoaiHinhDangKy = Phieu_DangKySuaChuaService.GetListItemsLoaiHinhDangKy();
            Phieu_DangKySuaChua Item = new Phieu_DangKySuaChua() { };
            if (IdDC > 0)
            {
                Item = Phieu_DangKySuaChuaService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            data.Item = Item;
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> SaveItem(Phieu_DangKySuaChua data)
        {
            Phieu_DangKySuaChuaModel model = new Phieu_DangKySuaChuaModel() { Item = data };
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(model.Item.Ids, API.Models.Settings.SecretId + ControllerName).ToString());

            if (ModelState.IsValid)
            {
                if (model.Item.Id == IdDC)
                {
                    model.Item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    model.Item.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    model.Item.CreatedAt = DateTime.Now;
                    model.Item.UpdatedAt = DateTime.Now;
                    try
                    {
                        Phieu_DangKySuaChuaService.SaveItem(model.Item);
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                        string Str_Url = HttpContext.Session.GetString("STR_Action_Link_" + ControllerName);
                        if (Str_Url != null && Str_Url != "")
                        {
                            return Redirect("/Admin/" + this.ControllerContext.RouteData.Values["controller"].ToString() + "/Index" + Str_Url);
                        }
                        else
                        {
                            return RedirectToAction("Index");
                        }
                    }
                    catch { throw; }
                }
            }
            model.SearchData = new SearchPhieu_DangKySuaChua() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            return View(model);
        }

        public ActionResult UpdateStatus([FromQuery] int Id, int Status)
        {
            Phieu_DangKySuaChua item = new Phieu_DangKySuaChua();
            try
            {
                if (Id > 0)
                {
                    item.Id = Id;
                    item.Status = Status;
                    dynamic UpdateStatus = Phieu_DangKySuaChuaService.UpdateStatus(item);
                    return Json(new MsgSuccess() { Msg = "Cập nhật Trạng Thái yêu cầu thành công" });
                }
                else
                {
                    return Json(new MsgSuccess() { Msg = "Cập nhật Trạng Thái yêu cầu Không thành công" });
                }
            }
            catch
            {
                return Json(new MsgSuccess() { Msg = "Cập nhật Trạng Thái yêu cầu Không thành công" });
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Phieu_DangKySuaChua model = new Phieu_DangKySuaChua() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    Phieu_DangKySuaChuaService.DeleteItem(model);
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
