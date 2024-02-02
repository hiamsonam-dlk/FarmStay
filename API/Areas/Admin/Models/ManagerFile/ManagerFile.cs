using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Areas.Admin.Models.ManagerFile
{
    public class ManagerFile
    {
        public class TinymceFolder
        {
            public int Acl { get; set; } = 0;
            public Boolean HasChildren { get; set; } = false;
            public string Name { get; set; }
            public string Url { get; set; }
            public string Path { get; set; }
            public string PathParent { get; set; }
            public string Img { get; set; }
            public List<TinymceFolder> Child { get; set; }
            public Boolean Selected { get; set; } = false;
        }
        
        public class TinymceFile
        {
            public string Name { get; set; }
            public long Size { get; set; }
            public string StrSize { get; set; }
            public string Date { get; set; }
            public string Path { get; set; }
            public string Img { get; set; }
            public string Extension { get; set; }
            public Boolean IsImage { get; set; } = false;
            public string Space { get; set; } = "Byte";
            public Boolean Selected { get; set; } = false;
            public string Msg { get; set; }
            public string PathParent { get; set; }

        }

        public class TinymceGetFiles
        {
            public TinymceFolder CurrentFolder { get; set; }
            public List<TinymceFile> Files { get; set; }
        }


        public class SearchTinymceFolder
        {
            public string Command { get; set; }
            public string Lang { get; set; }
            public string Type { get; set; }
            public string CurrentFolder { get; set; }
            public string Hash { get; set; }
        }

        public class SearchTinymce
        {
            public string Path { get; set; }
            public string Name { get; set; }
            public int flag { get; set; }
            public string Extension { get; set; }
        }

        public class TinymceError
        {
            public Boolean Success { get; set; }
            public string Msg { get; set; }
            public dynamic Data { get; set; }
        }

        public class Breadcrumb { 
            public string Name { get; set; }
            public string Path { get; set; }
            public Boolean IsActive { get; set; }
        }

        public class InfoFile
        {
            public string Name { get; set; }// Tên file
            public string Path { get; set; }// File url gốc 
            public string Folder { get; set; }
            public string FilePath { get; set; } // Link File trên web mới //documents/imgurl.jpg
            public string DirFilePath { get; set; } // Link File gốc
            public int TypeFile { get; set; } = 1;// 1=documents, 2=journal


        }


    }
}
