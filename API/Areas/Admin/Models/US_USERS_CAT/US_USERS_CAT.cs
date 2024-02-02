using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Partial;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API.Areas.Admin.Models.US_USERS_CAT
{
    public class US_USERS_CAT
    {
        public int UserId { get; set; }
        public int CatId { get; set; }

    }

    public class US_USERS_CATModel
    {
        public int UserId { get; set; }
        public List<int> CatId { get; set; }


    }


}
