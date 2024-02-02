using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.Ablums;
using API.Models;
namespace API.Areas.Admin.Models.Ablums
{
    public class AblumsService
    {
        public static List<Ablums> GetListPagination(SearchAblums dto, string SecretId)
        {
			if (dto.CurrentPage <= 0)
            {
                dto.CurrentPage = 1;
            }
            if (dto.ItemsPerPage <= 0)
            {
                dto.ItemsPerPage = 10;
            }
            if (dto.Keyword == null)
            {
                dto.Keyword = "";
            }
            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage", "@Keyword" },
                new object[] { "GetListPagination", dto.CurrentPage, dto.ItemsPerPage, dto.Keyword });
            if (tabl == null)
            {
                return new List<Ablums>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new Ablums
					{
						Id = (int)r["Id"],
 						CatId = (int)r["CatId"],
 						Title = (string)r["Title"],
 						Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						Images = (string)r["Images"],
 						Status = (Boolean)r["Status"],
 						
						Ids = MyModels.Encode((int)r["Id"], SecretId),
						TotalRows = (int)r["TotalRows"],
					}).ToList();
            }


        }
        public static List<Ablums> GetListPagination(SearchAblums dto,bool FE=false)
        {
            if (dto.CurrentPage <= 0)
            {
                dto.CurrentPage = 1;
            }
            if (dto.ItemsPerPage <= 0)
            {
                dto.ItemsPerPage = 10;
            }

            string flag = "GetListAlbumsPagination";
            if(FE)
                flag = "GetListAlbumsPaginationFont";

            var tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag", "@CurrentPage", "@ItemsPerPage" },
                new object[] { flag, dto.CurrentPage, dto.ItemsPerPage});
            if (tabl == null)
            {
                return new List<Ablums>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Ablums
                        {
                            Id = (int)r["Id"],
                            CatId = (int)r["CatId"],
                            Title = (string)((r["Title"] == System.DBNull.Value) ? null : r["Title"]),
                            Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                            Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                            Status = (Boolean)r["Status"],                                                     
                        }).ToList();
            }
        }
        public static List<Ablums> GetList(Boolean Selected = true)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag", "@Selected" }, new object[] { "GetList", Convert.ToDecimal(Selected) });
            if (tabl == null)
            {
                return new List<Ablums>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
					select new Ablums
					{
						Id = (int)r["Id"],
 						CatId = (int)r["CatId"],
 						Title = (string)r["Title"],
 						Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						Images = (string)r["Images"],
 						Status = (Boolean)r["Status"],                        
                    }).ToList();
            }

        }

        public static List<Ablums> GetListNew(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag" }, new object[] { "GetListNew" });
            if (tabl == null)
            {
                return new List<Ablums>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Ablums
                        {
                            Id = (int)r["Id"],
                            CatId = (int)r["CatId"],
                            Title = (string)r["Title"],
                            Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                            Images = (string)r["Images"],
                            Status = (Boolean)r["Status"],
                        }).ToList();
            }

        }

        public static List<Ablums> GetListFeatured(Boolean Selected = true)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag" }, new object[] { "GetListFeatured" });
            if (tabl == null)
            {
                return new List<Ablums>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Ablums
                        {
                            Id = (int)r["Id"],
                            CatId = (int)r["CatId"],
                            Title = (string)r["Title"],
                            Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                            Images = (string)r["Images"],                            
                        }).ToList();
            }

        }

        public static List<Ablums> GetListByParrent(int ParentId = 0)
        {
            List<Ablums> Ablums = new List<Ablums>();

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag", "@ParentId" }, new object[] { "GetListByParrent", ParentId });
            if (tabl == null)
            {
                Ablums = new List<Ablums>();
            }
            else
            {
                Ablums = (from r in tabl.AsEnumerable()
                                    select new Ablums
                                    {
                                        Id = (int)r["Id"],
                                        Title = (string)r["Title"],
                                        Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                                        Ten = (string)((r["Ten"] == System.DBNull.Value) ? null : r["Ten"]),
                                        MoTa = (string)((r["MoTa"] == System.DBNull.Value) ? null : r["MoTa"]),
                                        Images = (string)((r["Images"] == System.DBNull.Value) ? null : r["Images"]),
                                        Status = (Boolean)r["Status"],
                                    }).ToList();
            }
            return Ablums;
        }


        public static List<Ablums> GetList(int Id = 0, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
                new string[] { "@flag", "@Id" }, new object[] { "GetListAlbums", Id });
            if (tabl == null)
            {
                return new List<Ablums>();
            }
            else
            {
                return (from r in tabl.AsEnumerable()
                        select new Ablums
                        {
                            Id = (int)r["Id"],
                            CatId = (int)r["CatId"],
                            Ordering = (int)r["Ordering"],
                            Title = (string)r["Title"],
                            Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
                            Images = (string)r["Images"],
                            Status = (Boolean)r["Status"],                            
                            Deleted = false,
                            Ids = MyModels.Encode((int)r["Id"], SecretId)
                        }).ToList();
            }
        }
        public static Ablums GetItem(decimal Id, string SecretId = null)
        {

            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
            new string[] { "@flag", "@Id" }, new object[] { "GetItem", Id });
            return (from r in tabl.AsEnumerable()
                    select new Ablums
                    {
                        Id = (int)r["Id"],
 						CatId = (int)r["CatId"],
 						Title = (string)r["Title"],
 						Description = (string)((r["Description"] == System.DBNull.Value) ? null : r["Description"]),
 						Images = (string)r["Images"],
 						Status = (Boolean)r["Status"],
 						Deleted = false,
                        Ids = MyModels.Encode((int)r["Id"], SecretId),
                    }).FirstOrDefault();
        }

        public static dynamic SaveItem(Ablums dto)
        {
            
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
            new string[] { "@flag","@Id","@CatId","@Title","@Description","@Images","@Status","@CreatedBy","@ModifiedBy", "@Ordering", "@Deleted" ,"@Ten", "@MoTa"},
            new object[] { "SaveItem",dto.Id,dto.CatId,dto.Title,dto.Description,dto.Images,dto.Status,dto.CreatedBy,dto.ModifiedBy,dto.Ordering,dto.Deleted, dto.Ten, dto.MoTa });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        
        public static dynamic DeleteItem(Ablums dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
            new string[] { "@flag", "@Id", "@ModifiedBy" },
            new object[] { "DeleteItem", dto.Id, dto.ModifiedBy});
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


		
		public static dynamic UpdateStatus(Ablums dto)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
            new string[] { "@flag", "@Id","@Status", "@ModifiedBy" },
            new object[] { "UpdateStatus", dto.Id,dto.Status, dto.ModifiedBy });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }
        public static dynamic UpdateStatusCat(int CatId)
        {
            DataTable tabl = ConnectDb.ExecuteDataTableTask(Startup.ConnectionString, "SP_Ablums",
            new string[] { "@flag", "@CatId" },
            new object[] { "UpdateStatusCat", CatId });
            return (from r in tabl.AsEnumerable()
                    select new
                    {
                        N = (int)(r["N"]),
                    }).FirstOrDefault();

        }


    }
}
