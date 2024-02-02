﻿using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using static API.Areas.Admin.Models.LietSy.LietSyModel;
using API.Areas.Admin.Models.LietSy;
using System.Linq;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LietSyController : Controller
    {
        public IActionResult Index([FromQuery] SearchLietSy dto, string btn = "search")
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int TotalItems = 0;
            //if (btn == "excel")
            //{
            //    var ListExcel = LietSyService.GetListExcel(dto, API.Models.Settings.SecretId + ControllerName, LangId, IDUSER);
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

            LietSyModel data = new LietSyModel() { SearchData = dto };
            data.ListItems = LietSyService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
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
            LietSy Item = new LietSy();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            if (IdDC > 0)
            {
                Item = LietSyService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            return Json(Item);
        }

        public IActionResult SaveItem(string Id = null)
        {
            int IDUSER = int.Parse(HttpContext.Request.Headers["Id"]);
            LietSyModel data = new LietSyModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchLietSy() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            LietSy Item = new LietSy() { };
            if (IdDC > 0)
            {
                Item = LietSyService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
            data.Item = Item;
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> SaveItem(LietSy data)
        {
            LietSyModel model = new LietSyModel() { Item = data };
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
                        LietSyService.SaveItem(model.Item);
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
            model.SearchData = new SearchLietSy() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            return View(model);
        }

        public ActionResult UpdateStatus([FromQuery] int Id, bool Status)
        {
            LietSy item = new LietSy();
            try
            {
                if (Id > 0)
                {
                    item.Id = Id;
                    item.Status = Status;
                    dynamic UpdateStatus = LietSyService.UpdateStatus(item);
                    return Json(new MsgSuccess() { Msg = "Cập nhật trạng thái thành công" });
                }
                else
                {
                    return Json(new MsgSuccess() { Msg = "Cập nhật trạng thái Không thành công" });
                }
            }
            catch
            {
                return Json(new MsgSuccess() { Msg = "Cập nhật trạng thái Không thành công" });
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + HttpContext.Request.Headers["UserName"];
            LietSy model = new LietSy() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = "Admin";
                    model.UpdatedBy = "Admin";
                    LietSyService.DeleteItem(model);
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
