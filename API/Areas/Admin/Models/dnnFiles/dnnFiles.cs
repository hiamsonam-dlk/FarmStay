using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
namespace API.Areas.Admin.Models.dnnFiles
{
    public class dnnFiles
    {
		public string Ids { get; set; }
        public int TotalRows { get; set; }
        public int FileId { get; set; }
        public int PortalId { get; set; }
        public string Folder { get; set; }
        public int ArticleId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public double Size { get; set; }
        public string FileTicket { get; set; }
 		
 		
    }
	
	public class dnnFilesModel
    {
        public List<dnnFiles> ListItems { get; set; }       
        public dnnFiles Item { get; set; }
    }

 
}
