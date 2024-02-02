using API.Areas.Admin.Models.Phieu_DangKyLapMoi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.IO;
using System;
using API.Models.Utilities;
using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using API.Areas.Admin.Models.Phieu_CapNhatChiSo;
using API.Areas.Admin.Models.DMPhuongXa;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Phieu_DangKyLapMoiController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public Phieu_DangKyLapMoiController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

        public IActionResult Index([FromQuery] SearchPhieu_DangKyLapMoi dto, string btn = "search")
        {
            int IDUSER = int.Parse(HttpContext.Request.Headers["Id"]);
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int TotalItems = 0;
            //if (btn == "excel")
            //{
            //    var ListExcel = Phieu_DangKyLapMoiService.GetListExcel(dto, API.Models.Settings.SecretId + ControllerName, LangId, IDUSER);
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

            Phieu_DangKyLapMoiModel data = new Phieu_DangKyLapMoiModel() { SearchData = dto };
            data.ListItems = Phieu_DangKyLapMoiService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            data.ListItemsStatus = Phieu_DangKyLapMoiService.GetListItemsStatus();
            data.ListItemsLoaiHinhDangKy = Phieu_DangKyLapMoiService.GetListItemsLoaiHinhDangKy();
            data.ListItemsChiNhanhCapNuoc = API.Areas.Admin.Models.ChiNhanhCapNuoc.ChiNhanhCapNuocService.GetListChiNhanhDanhMuc();
            data.ListItemsMucDichSuDung = API.Areas.Admin.Models.MucDichSuDung.MucDichSuDungService.GetListMucDichSuDungDanhMuc();
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
            Phieu_DangKyLapMoi Item = new Phieu_DangKyLapMoi();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC > 0)
            {
                Item = Phieu_DangKyLapMoiService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return Json(Item);
        }

        public IActionResult SaveItem(string Id = null)
        {
            Phieu_DangKyLapMoiModel data = new Phieu_DangKyLapMoiModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            Phieu_DangKyLapMoi Item = new Phieu_DangKyLapMoi() { };
            if (IdDC > 0)
            {
                Item = Phieu_DangKyLapMoiService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            
            data.SearchData = new SearchPhieu_DangKyLapMoi() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            data.ListItemsStatus = Phieu_DangKyLapMoiService.GetListItemsStatus();
            data.ListItemsLoaiHinhDangKy = Phieu_DangKyLapMoiService.GetListItemsLoaiHinhDangKy();
            data.ListItemsMucDichSuDung = API.Areas.Admin.Models.MucDichSuDung.MucDichSuDungService.GetListMucDichSuDungDanhMuc();
            data.ListItemsQuanHuyen = API.Areas.Admin.Models.DMQuanHuyen.DMQuanHuyenService.GetListSelectItems(42, Item.IdQuanHuyen);
            data.ListItemsPhuongXa = API.Areas.Admin.Models.DMPhuongXa.DMPhuongXaService.GetListSelectItems(Item.IdQuanHuyen, Item.IdPhuongXa);

            data.Item = Item;
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> SaveItem(Phieu_DangKyLapMoi data)
        {
            Phieu_DangKyLapMoiModel model = new Phieu_DangKyLapMoiModel() { Item = data };
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(model.Item.Ids, API.Models.Settings.SecretId + ControllerName).ToString());

            //if (ModelState.IsValid)
            //{
                if (model.Item.Id == IdDC)
                {
                    model.Item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    model.Item.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    model.Item.CreatedAt = DateTime.Now;
                    model.Item.UpdatedAt = DateTime.Now;
                    try
                    {
                        // Them file
                        //var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "CMS/Content/FromUser/LapMoi");

                        //string HinhAnhCCCDFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(model.Item.ImageCCCDtr.FileName.ToString().Trim());
                        //var HinhAnhCCCDFilePath = Path.Combine(uploads, HinhAnhCCCDFileName);
                        //using (var fileStream = new FileStream(HinhAnhCCCDFilePath, FileMode.Create))
                        //{
                        //    await model.Item.ImageCCCDtr.CopyToAsync(fileStream);
                        //}
                        //model.Item.HinhAnhCCCDtr = "/CMS/Content/FromUser/LapMoi/" + HinhAnhCCCDFileName;

                        //string HinhAnhQSDDFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(model.Item.ImageQSDD.FileName.ToString().Trim());
                        //var HinhAnhQSDDFilePath = Path.Combine(uploads, HinhAnhQSDDFileName);
                        //using (var fileStream = new FileStream(HinhAnhQSDDFilePath, FileMode.Create))
                        //{
                        //    await model.Item.ImageQSDD.CopyToAsync(fileStream);
                        //}
                        //model.Item.HinhAnhQSDD = "/CMS/Content/FromUser/LapMoi/" + HinhAnhQSDDFileName;

                        Phieu_DangKyLapMoiService.UpdateNVKhaoSat(model.Item);
                        TempData["MessageSuccess"] = "Cập nhật thành công";
                        //string Str_Url = HttpContext.Session.GetString("STR_Action_Link_" + ControllerName);
                        //if (Str_Url != null && Str_Url != "")
                        //{
                        //    return Redirect("/Admin/" + this.ControllerContext.RouteData.Values["controller"].ToString() + "/Index" + Str_Url);
                        //}
                        //else
                        //{
                        //    return RedirectToAction("Index");
                        //}
                    }
                    catch{throw;}
                }
            //}
            model.SearchData = new SearchPhieu_DangKyLapMoi() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            return RedirectToAction("Index");
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            Phieu_DangKyLapMoi model = new Phieu_DangKyLapMoi() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    model.UpdatedBy = int.Parse(HttpContext.Request.Headers["Id"]).ToString();
                    Phieu_DangKyLapMoiService.DeleteItem(model);
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

        public ActionResult UpdateStatus([FromQuery] int Id, int Status)
        {
            Phieu_DangKyLapMoi item = new Phieu_DangKyLapMoi();
            try
            {
                if (Id > 0)
                {
                    item.Id = Id;
                    item.Status = Status;
                    dynamic UpdateStatus = Phieu_DangKyLapMoiService.UpdateStatus(item);
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
    }
}
