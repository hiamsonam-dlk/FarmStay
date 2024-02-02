using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.MiddleWares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using reCAPTCHA.AspNetCore;
namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static string GoogleReCaptcha { get; private set; }
        public static string ConnectionString { get; private set; }
        public static string OracleConnectionString { get; private set; }
        public static string SqlOldConnection { get; private set; }
        public static string Domain { get; private set; }

        public static string DCDUrl { get; private set; }
        public static string SiteCode { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //services.AddMvc().AddJsonOptions(options =>
            //{
            //    options.SerializerSettings.ContractResolver
            //        = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            //});

            
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(100000);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;

            });
            // --------- Add Capcha google
            services.Configure<RecaptchaSettings>(Configuration.GetSection("RecaptchaSettings"));
            services.AddTransient<IRecaptchaService, RecaptchaService>();
            // --------- End Add Capcha google

            services.AddMemoryCache();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];
                app.UseDeveloperExceptionPage();
            }
            else
            {
                ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            OracleConnectionString = Configuration["ConnectionStrings:OracleConnection"];
            SqlOldConnection = Configuration["ConnectionStrings:SqlOldConnection"];

            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/";
                    await next();
                }
            });


            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCors();
            app.UseRouting();
            app.UseMyAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapAreaControllerRoute(
                    "admin",
                    "admin",
                    "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                "areaRouteEN",
                "EN",
                "EN/{controller=HomeEN}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Album_Detail",
                   pattern: "albums/{alias}-{id}.html",
                   defaults: new { controller = "Albums", action = "Detail" });

                endpoints.MapControllerRoute(
                   name: "ENAlbum_Detail",
                   pattern: "EN/albums/{alias}-{id}.html",
                   defaults: new { area = "EN", controller = "AlbumsEN", action = "Detail" });

                endpoints.MapControllerRoute(
                    name: "DSQuyenGopTaiLieu",
                    pattern: "ds-quyen-gop-tai-lieu.html",
                    defaults: new { controller = "QuyenGopTaiLieu", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "DSQuyenGopTaiLieuEN",
                    pattern: "EN/ds-quyen-gop-tai-lieu.html",
                    defaults: new { area = "EN", controller = "QuyenGopTaiLieuEN", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "QuyenGopTaiLieu",
                    pattern: "quyen-gop-tai-lieu.html",
                    defaults: new { controller = "QuyenGopTaiLieu", action = "SaveItem" });

                endpoints.MapControllerRoute(
                    name: "QuyenGopTaiLieuEN",
                    pattern: "EN/quyen-gop-tai-lieu.html",
                    defaults: new { area = "EN", controller = "QuyenGopTaiLieuEN", action = "SaveItem" });

                endpoints.MapControllerRoute(
                    name: "DiaChiDo",
                    pattern: "dia-chi-do.html",
                    defaults: new { controller = "DiaChiDo", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "DiaChiDoEN",
                    pattern: "EN/dia-chi-do.html.html",
                    defaults: new { area = "EN", controller = "DiaChiDoEN", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "LietSy",
                    pattern: "danh-sach-liet-sy.html",
                    defaults: new { controller = "LietSy", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "EnLietSy",
                    pattern: "EN/danh-sach-liet-sy.html",
                    defaults: new {area ="EN", controller = "LietSyEN", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "CayLuuNiem",
                    pattern: "cay-luu-niem.html",
                    defaults: new { controller = "CayLuuNiem", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "EnCayLuuNiem",
                    pattern: "EN/cay-luu-niem.html",
                    defaults: new { area = "EN", controller = "CayLuuNiemEN", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "SoLuuNiem",
                    pattern: "so-luu-niem.html",
                    defaults: new { controller = "SoLuuNiem", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "EnSoLuuNiem",
                    pattern: "EN/so-luu-niem.html",
                    defaults: new { area= "EN", controller = "SoLuuNiemEN", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "ThemCamNghi",
                    pattern: "them-cam-nghi.html",
                    defaults: new { controller = "SoLuuNiem", action = "SaveItem" });

                endpoints.MapControllerRoute(
                    name: "ENThemCamNghi",
                    pattern: "EN/them-cam-nghi.html",
                    defaults: new { area="EN", controller = "SoLuuNiemEN", action = "SaveItem" });

                endpoints.MapControllerRoute(
                  name: "ArticlesCategoriesEN",
                  pattern: "EN/categories/{alias}-{id}.html",
                  defaults: new { area = "EN", controller = "ArticlesEN", action = "GetByCat" });

                endpoints.MapControllerRoute(
                  name: "areaRoute",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                  name: "TaiLieu",
                  pattern: "tai-lieu.html",
                  defaults: new { controller = "DocumentsLaw", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "ArticlesCategories",
                   pattern: "categories/{alias}-{id}.html",
                   defaults: new { controller = "Articles", action = "GetByCat" });

                endpoints.MapControllerRoute(
                   name: "EnArticlesCategories",
                   pattern: "EN/categories/{alias}-{id}.html",
                   defaults: new { area = "EN", controller = "ArticlesEN", action = "GetByCat" });

                endpoints.MapControllerRoute(
                    name: "TrangChu",
                    pattern: "trang-chu.html",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                 name: "ThuVienAnh",
                 pattern: "thu-vien-anh.html",
                 defaults: new { controller = "Albums", action = "Index" });

                endpoints.MapControllerRoute(
                 name: "ENThuVienAnh",
                 pattern: "EN/thu-vien-anh.html",
                 defaults: new { area="EN", controller = "AlbumsEN", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Videos",
                    pattern: "videos.html",
                    defaults: new { controller = "Videos", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "EnVideos",
                    pattern: "EN/videos.html",
                    defaults: new { area ="EN", controller = "VideosEN", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "SiteMap",
                   pattern: "sitemap.html",
                   defaults: new { controller = "Home", action = "SiteMap" });

                endpoints.MapControllerRoute(
                   name: "Articles_Detail",
                   pattern: "{alias}-{id}.html",
                   defaults: new { controller = "Articles", action = "Detail" });

                endpoints.MapControllerRoute(
                   name: "ENArticles_Detail",
                   pattern: "EN/{alias}-{id}.html",
                   defaults: new { area="EN", controller = "ArticlesEN", action = "Detail" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            GoogleReCaptcha = Configuration["GoogleReCaptcha:key"];
            Domain = Configuration["Site:Domain"];

            DCDUrl = Configuration["Site:DiaChiDo"];
            SiteCode = Configuration["Site:SiteCode"];
        }
    }
}
