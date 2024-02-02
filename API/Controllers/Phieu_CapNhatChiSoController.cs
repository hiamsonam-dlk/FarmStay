using API.Areas.Admin.Models.Phieu_CapNhatChiSo;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Hosting;

namespace API.Controllers
{
    public class Phieu_CapNhatChiSoController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        public Phieu_CapNhatChiSoController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

        public IActionResult Index()
        {
            Phieu_CapNhatChiSoModel data = new Phieu_CapNhatChiSoModel();
            data.SearchData = new SearchPhieu_CapNhatChiSo() { CurrentPage = 0, ItemsPerPage = 10, Keyword = "" };
            Phieu_CapNhatChiSo Item = new Phieu_CapNhatChiSo() { };
            data.Item = Item;
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> Index(Phieu_CapNhatChiSo data)
        {
            Phieu_CapNhatChiSoModel model = new Phieu_CapNhatChiSoModel() { Item = data };
            if (ModelState.IsValid)
            {
                model.Item.CreatedBy = data.SoDT;
                model.Item.UpdatedBy = "0";
                model.Item.CreatedAt = DateTime.Now;
                model.Item.UpdatedAt = DateTime.Now;
                model.Item.LoaiHinhTiepNhan = false;
                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "CMS/Content/FromUser/CapNhatChiSo");

                string HinhAnhCCCDFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + API.Models.Utilities.FileHelpers.ChuyenTVKhongDau(model.Item.IHinhAnh.FileName.ToString().Trim());
                var HinhAnhCCCDFilePath = Path.Combine(uploads, HinhAnhCCCDFileName);
                using (var fileStream = new FileStream(HinhAnhCCCDFilePath, FileMode.Create))
                {
                    await model.Item.IHinhAnh.CopyToAsync(fileStream);
                }
                model.Item.HinhAnh = "/CMS/Content/FromUser/CapNhatChiSo/" + HinhAnhCCCDFileName;

                try
                {
                    Phieu_CapNhatChiSoService.SaveItem(model.Item);
                    TempData["MessageSuccess"] = "Tạo thành công!";
                }
                catch { TempData["MessageError"] = "Tạo thất bại!"; }
            }
            return View(model);
        }
    }
}
