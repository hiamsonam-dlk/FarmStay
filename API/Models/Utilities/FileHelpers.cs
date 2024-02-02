﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace API.Models.Utilities
{
    public class FileHelpers
    {

        public static bool CheckFileTypeAudio(string FileName)
        {
            string ext = System.IO.Path.GetExtension(FileName);
            if (ext.ToUpper().Equals(".MP3") || ext.ToUpper().Equals(".WAV"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckFileAttach(string FileName)
        {
            string ext = System.IO.Path.GetExtension(FileName);
            if (ext.ToUpper().Equals(".PDF")|| ext.ToUpper().Equals(".DOC")|| ext.ToUpper().Equals(".DOCX") || ext.ToUpper().Equals(".XLS") || ext.ToUpper().Equals(".XLSX") || ext.ToUpper().Equals(".RAR") 
                || ext.ToUpper().Equals(".ZIP") || ext.ToUpper().Equals(".JPG") || ext.ToUpper().Equals(".PNG") || ext.ToUpper().Equals(".GIP"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool CheckFileTypePDF(string FileName)
        {
            string ext = System.IO.Path.GetExtension(FileName);
            if (ext.ToUpper().Equals(".PDF"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ChuyenTVKhongDau(string strVietNamese)
        {
            strVietNamese = strVietNamese.Trim();
            string strVietNameselower = strVietNamese.ToLower();
            string FindText = "ÀàảẢãáÁạẠăằẳẵắặâÂầẩẫấẤậđĐèẻẽéẹêÊềểễếệìỉĩíịòỏõóọôÔồổỗốộơờởỡớợùủũúụưƯừửữứựỳỷỹýỵ";
            string ReplText = "AaaAaaAaAaaaaaaaAaaaaAadDeeeeeeEeeeeeiiiiiooooooOooooooooooouuuuuuUuuuuuyyyyy";
            int index = -1, index2;
            while ((index = strVietNameselower.IndexOfAny(FindText.ToCharArray())) != -1)
            {
                index2 = FindText.IndexOf(strVietNameselower[index]);
                strVietNameselower = strVietNameselower.Replace(strVietNameselower[index], ReplText[index2]);
            }
            strVietNameselower = strVietNameselower.Replace("&", "").Replace("+", "").Replace(";", "").Replace(",", "");

            return strVietNameselower;
        }

        public static async Task<string> ProcessFormFile(IFormFile formFile,
            ModelStateDictionary modelState)
        {            
            string filePath = Path.Combine("wwwroot", "FileUpload");
            var fieldDisplayName = string.Empty;
          
            var fileName = WebUtility.HtmlEncode(
                Path.GetFileName(formFile.FileName));

            if (!formFile.ContentType.ToLower().Contains("image"))
            {
                modelState.AddModelError(formFile.Name,
                    $"The {fieldDisplayName}file ({fileName}) must be a text file.");
            }

            // Check the file length and don't bother attempting to
            // read it if the file contains no content. This check
            // doesn't catch files that only have a BOM as their
            // content, so a content length check is made later after 
            // reading the file's content to catch a file that only
            // contains a BOM.
            if (formFile.Length == 0)
            {
                modelState.AddModelError(formFile.Name,
                    $"The {fieldDisplayName}file ({fileName}) is empty.");
            }
            else if (formFile.Length > 1048576)
            {
                modelState.AddModelError(formFile.Name,
                    $"The {fieldDisplayName}file ({fileName}) exceeds 1 MB.");
            }
            else
            {
                try
                {
                    
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }
                    if (formFile.Length > 0)
                    {
                        using (var fileStream = new FileStream(Path.Combine(filePath, formFile.FileName), FileMode.Create))
                        {
                            await formFile.CopyToAsync(fileStream);

                        }
                    }
                }
                catch (Exception ex)
                {
                    modelState.AddModelError(formFile.Name,
                        $"The {fieldDisplayName}file ({fileName}) upload failed. " +
                        $"Please contact the Help Desk for support. Error: {ex.Message}");
                    // Log the exception
                }
            }

            return "/FileUpload/" + fileName;
        }
    }
}
