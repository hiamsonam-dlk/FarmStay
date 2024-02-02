using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Areas.Admin.Models.DocumentForms;
using API.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;

namespace API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DocumentFormsController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;


        public DocumentFormsController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

        public IActionResult Index([FromQuery] SearchDocumentForms dto)
        {
            int TotalItems = 0;
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentFormsModel data = new DocumentFormsModel() { SearchData = dto };
            data.ListItems = DocumentFormsService.GetListPagination(data.SearchData, API.Models.Settings.SecretId + ControllerName);
            if (data.ListItems != null && data.ListItems.Count() > 0)
            {
                TotalItems = data.ListItems[0].TotalRows;
            }
            data.Pagination = new Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };
            data.ListItemsStatus = DocumentFormsService.GetListItemsStatus();
            data.ListYear= DocumentFormsService.GetListItemsYear();
            return View(data);
        }

        public IActionResult SaveItem(string Id = null)
        {
            DocumentFormsModel data = new DocumentFormsModel();
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString());
            data.SearchData = new SearchDocumentForms() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
          
            DocumentForms Item = new DocumentForms() {
                IssuedDateShow = DateTime.Now.ToString("dd/MM/yyyy"),
                Status=true
            };
            if (IdDC > 0)
            {
                Item = DocumentFormsService.GetItem(IdDC, API.Models.Settings.SecretId + ControllerName);
            }
          
            data.Item = Item;

            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveItem(DocumentForms model, IEnumerable<IFormFile> FilePDF)
        {
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "TapChi");
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            int IdDC = Int32.Parse(MyModels.Decode(model.Ids, API.Models.Settings.SecretId + ControllerName).ToString());
            DocumentFormsModel data = new DocumentFormsModel() { Item = model };          
            if (ModelState.IsValid)
            {
                if (model.Id == IdDC)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);

                    //File 
                    foreach (var file in FilePDF)
                    {
                        if (file != null && file.Length > 0)
                        {
                            if (API.Models.Utilities.FileHelpers.CheckFileTypePDF(file.FileName))
                            {
                                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(file.FileName.TrimEnd());
                                var filePath = Path.Combine(uploads, filename);
                                using (var fileStream = new FileStream(filePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                }
                                model.Link = filename;
                            }
                            else
                            {
                                TempData["MessageError"] = "Chỉ chấp nhận file PDF";
                                return View(data);
                            }
                        }

                    }
                    // End them file    

                    try
                    {
                        DocumentFormsService.SaveItem(model);
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
                    catch
                    {
                        throw;
                        TempData["MessageError"] = "Lỗi khi lưu dữ liệu";
                    }

                }
            }
            return View(data);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(string Id)
        {
            string ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            DocumentForms model = new DocumentForms() { Id = Int32.Parse(MyModels.Decode(Id, API.Models.Settings.SecretId + ControllerName).ToString()) };
            try
            {
                if (model.Id > 0)
                {
                    model.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    model.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    DocumentFormsService.DeleteItem(model);
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
            DocumentForms item = new DocumentForms() { Id = Int32.Parse(MyModels.Decode(Ids, API.Models.Settings.SecretId + ControllerName).ToString()), Status = Status };
            try
            {
                if (item.Id > 0)
                {
                    item.CreatedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    item.ModifiedBy = int.Parse(HttpContext.Request.Headers["Id"]);
                    dynamic UpdateStatus = DocumentFormsService.UpdateStatus(item);
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
