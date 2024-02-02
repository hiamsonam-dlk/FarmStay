using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using API.Areas.Admin.Models.dnnFiles;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace API.Controllers
{
    public class GetFileController : Controller
    {

        public IActionResult Index(string fileticket = "",string tabid = "")
        {
            var file = dnnFilesService.GetItem(fileticket);
            if(file!=null)
            {
                var url = "/Portals/" + file.PortalId.ToString() + "/" + file.Folder + file.FileName;

                return Redirect(url);

            }
            else
            {
                ViewData["Ticket"] = "File không tồn tại trên hệ thống !";
                return View();
            }
           
        }

        public IActionResult BackUp()
        {
         
                var ListArticle = dnnFilesService.GetListArticle();
                foreach (var item in ListArticle)
                {
                    try
                    {
                        var htmlDoc = new HtmlDocument();
                        htmlDoc.LoadHtml(item.FullText);

                        var cateNodes = htmlDoc.DocumentNode.SelectNodes("//a");


                        foreach (HtmlNode node in cateNodes)
                        {
                            var URL = node.GetAttributeValue("href", "");
                            URL = "http://sotuphap.daklak.gov.vn" + URL;
                            URL = HttpUtility.HtmlDecode(URL);
                            if (URL.Contains("/LinkClick.aspx"))
                            {
                                Uri myUri = new Uri(URL);
                                string fileticket = "";
                                string tabid = "";

                                fileticket = HttpUtility.ParseQueryString(myUri.Query).Get("fileticket");
                                tabid = HttpUtility.ParseQueryString(myUri.Query).Get("tabid");

                                //GetFile(fileticket, tabid);
                            }
                            //SITE URL
                        }

                        dnnFilesService.UpdateCurrentId(item.Id);
                    }

                    catch
                    { }

                }
            
      
           


            return View();
        }


        //public JsonResult GetFile(string fileticket="", string tabid = "")
        //{
        //    try
        //    {
        //        var client = new RestClient("http://sotuphap.daklak.gov.vn/LinkClick.aspx?fileticket=" + fileticket + "&tabid="+tabid);
        //        client.Timeout = -1;
        //        var request = new RestRequest(Method.GET);
        //        IRestResponse response = client.Execute(request);
        //        var filename = "";
        //        foreach (var h in response.Headers)
        //        {


        //            if (h.ToString().Contains("filename"))
        //            {
        //                var reg = new Regex("\".*?\"");
        //                var matches = reg.Matches(h.ToString());
        //                foreach (var item in matches)
        //                {
        //                    filename = item.ToString();
        //                }
        //            }

        //        }
        //        filename = filename.Replace("\"", "");

        //        dnnFiles myfile = new dnnFiles() { FileName = filename, FileTicket = fileticket };
        //        dnnFilesService.UpdateFileTicket(myfile);
        //        return Json(1);
        //    }
        //    catch
        //    {
        //        return Json(0);
        //    }
            

            
        //}

    }
}