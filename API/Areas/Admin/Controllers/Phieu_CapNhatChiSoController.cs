using API.Areas.Admin.Models.Phieu_CapNhatChiSo;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using API.Areas.Admin.Models.Articles;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Phieu_CapNhatChiSoController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        public Phieu_CapNhatChiSoController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }
        public IActionResult Index([FromQuery] SearchPhieu_CapNhatChiSo dto, string btn = "search")
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int TotalItems = 0;
            //if (btn == "excel")
            //{
            //    var ListExcel = Phieu_CapNhatChiSoService.GetListExcel(dto, API.Models.Settings.SecretId + ControllerName, LangId, IDUSER);
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

            Phieu_CapNhatChiSoModel data = new Phieu_CapNhatChiSoModel() { SearchData = dto };
            data.ListItems = Phieu_CapNhatChiSoService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.ListItemsStatus = Phieu_CapNhatChiSoService.GetListItemsStatus();
            data.ListItemsLoaiHinhDangKy = Phieu_CapNhatChiSoService.GetListItemsLoaiHinhDangKy();
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
            Phieu_CapNhatChiSo Item = new Phieu_CapNhatChiSo();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC > 0)
            {
                Item = Phieu_CapNhatChiSoService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return Json(Item);
        }

        public IActionResult SaveItem(string Id = null)
        {
            int IDUSER = int.Parse(HttpContext.Request.Headers["Id"]);
            Phieu_CapNhatChiSoModel data = new Phieu_CapNhatChiSoModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchPhieu_CapNhatChiSo() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            data.ListItemsStatus = Phieu_CapNhatChiSoService.GetListItemsStatus();
            data.ListItemsLoaiHinhDangKy = Phieu_CapNhatChiSoService.GetListItemsLoaiHinhDangKy();
            Phieu_CapNhatChiSo Item = new Phieu_CapNhatChiSo() { };
            if (IdDC > 0)
            {
                Item = Phieu_CapNhatChiSoService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            data.Item = Item;
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> SaveItem(Phieu_CapNhatChiSo data)
        {
            Phieu_CapNhatChiSoModel model = new Phieu_CapNhatChiSoModel() { Item = data };
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
                        var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "CMS/Content/FromUser/CapNhatChiSo");

                        string HinhAnhCCCDFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(model.Item.IHinhAnh.FileName.ToString().Trim());
                        var HinhAnhCCCDFilePath = Path.Combine(uploads, HinhAnhCCCDFileName);
                        using (var fileStream = new FileStream(HinhAnhCCCDFilePath, FileMode.Create))
                        {
                            await model.Item.IHinhAnh.CopyToAsync(fileStream);
                        }
                        model.Item.HinhAnh = "/CMS/Content/FromUser/CapNhatChiSo/" + HinhAnhCCCDFileName;
                        Phieu_CapNhatChiSoService.SaveItem(model.Item);
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
            model.SearchData = new SearchPhieu_CapNhatChiSo() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            return View(model);
        }

        public ActionResult UpdateStatus([FromQuery] int Id, int Status)
        {
            Phieu_CapNhatChiSo item = new Phieu_CapNhatChiSo();
            try
            {
                if (Id > 0)
                {
                    item.Id = Id;
                    item.Status = Status;
                    dynamic UpdateStatus = Phieu_CapNhatChiSoService.UpdateStatus(item);
                    return Json(new MsgSuccess() { Msg= "Cập nhật Trạng Thái yêu cầu thành công" });
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
            Phieu_CapNhatChiSo model = new Phieu_CapNhatChiSo() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = "Admin";
                    model.UpdatedBy = "Admin";
                    Phieu_CapNhatChiSoService.DeleteItem(model);
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
