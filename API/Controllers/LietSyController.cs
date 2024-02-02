using API.Areas.Admin.Models.DMTinhThanh;
using API.Areas.Admin.Models.LietSy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.OLE.Interop;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    public class LietSyController : Controller
    {
        public IActionResult Index()
        {
            DMTinhThanhModel ltt = new DMTinhThanhModel();
            ltt.ListLietSy = new List<LietSy>();
            ltt.ListItems = new List<DMTinhThanh>
            {
                DMTinhThanhService.GetItem(42),
                DMTinhThanhService.GetItem(43),
                DMTinhThanhService.GetItem(41),
                DMTinhThanhService.GetItem(40),
                DMTinhThanhService.GetItem(44)
            };

            ltt.ListLietSy = LietSyService.GetList();

            for (int i = 0; i < ltt.ListItems.Count(); i++)
            {
                List<LietSy> tmp = new List<LietSy>();
                for (int j = 0; j < ltt.ListLietSy.Count(); j++)
                {
                    if (ltt.ListItems[i].Ma == ltt.ListLietSy[j].TinhThanh.ToString())
                    {
                        tmp.Add(ltt.ListLietSy[j]);
                    }
                }
                ltt.ListItems[i].ListLietSy = tmp;
            }

            //if (ltt.ListItems != null && data.ListItems.Count() > 0)
            //{
            //    TotalItems = data.ListItems[0].TotalRows;
            //}
            //data.Pagination = new Areas.Admin.Models.Partial.PartialPagination() { CurrentPage = data.SearchData.CurrentPage, ItemsPerPage = data.SearchData.ItemsPerPage, TotalItems = TotalItems, QueryString = Request.QueryString.ToString() };

            return View(ltt);
        }
    }
}
