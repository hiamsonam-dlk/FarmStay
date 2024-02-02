using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using API.Areas.Admin.Models.USUsers;
using Microsoft.AspNetCore.Session;
using API.Areas.Admin.Models.USGroups;
using API.Areas.Admin.Models.USMenu;
using System.Collections.Concurrent;
using Microsoft.Extensions.Caching.Memory;
using API.Areas.Admin.Models.DMCoQuan;

namespace API.MiddleWares
{

    public static class MyAuthenticationMiddleWareExtensions
    {
        public static void UseOnlineUsers(this IApplicationBuilder app, string cookieName = "UserGuid", int lastActivityMinutes = 300)
        {
            app.UseMiddleware<MyAuthenticationMiddleWare>(cookieName, lastActivityMinutes);
        }
    }

    public class MyAuthenticationMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly string _cookieName;
        private readonly int _lastActivityMinutes = 300;
        private static readonly ConcurrentDictionary<string, bool> _allKeys = new ConcurrentDictionary<string, bool>();


        public MyAuthenticationMiddleWare(RequestDelegate next, string cookieName = "UserGuid", int lastActivityMinutes = 300)
        {
            _next = next;
            _cookieName = cookieName;
            _lastActivityMinutes = lastActivityMinutes;
        }

        public async Task InvokeAsync(HttpContext context, IMemoryCache memoryCache)
        {
            Boolean flagDev = false;

            string root = context.Request.Host.Value;
            string link = context.Request.Path.Value;
            List<string> ListLink = link.Split("/").ToList();
            //Đếm số người online

            if (context.Request.Cookies.TryGetValue(_cookieName, out var userGuid) == false)
            {
                userGuid = Guid.NewGuid().ToString();
                context.Response.Cookies.Append(_cookieName, userGuid, new CookieOptions { HttpOnly = true, MaxAge = TimeSpan.FromDays(30) });
            }

            memoryCache.GetOrCreate(userGuid, cacheEntry =>
            {
                if (_allKeys.TryAdd(userGuid, true) == false)
                {
                    //if add key faild, setting expiration to the past cause dose not cache
                    cacheEntry.AbsoluteExpiration = DateTimeOffset.MinValue;
                }
                else
                {
                    cacheEntry.SlidingExpiration = TimeSpan.FromMinutes(_lastActivityMinutes);
                    cacheEntry.RegisterPostEvictionCallback(RemoveKeyWhenExpired);
                }
                return string.Empty;
            });

            //

            //var OnlineUserCounter = context.Session.GetInt32("OnlineUserCounter");
            //if (OnlineUserCounter == null)
            //{
            //    //context.Session.SetString("OnlineUserCounter");
            //    API.Areas.Admin.Models.SiteVisit.SiteVisitService.SaveItem(DateTime.Now.ToString("yyyyMMdd"));
            //    context.Session.SetInt32("OnlineUserCounter", 1);
            //}
            //else {
            //    context.Session.SetInt32("OnlineUserCounter", int.Parse(OnlineUserCounter.ToString()) + 1);
            //}

            if (flagDev)
            {
                UserToken UserToken = new UserToken()
                {
                    Id = 1,
                    IdGroup = 1,
                    IdCoQuan = 1,
                    UserName = "phucbv.dlc",
                    Email = "phucbv.dlc@vnpt.vn"
                };
                context.Request.Headers.Add("Id", UserToken.Id.ToString());
                context.Request.Headers.Add("IdGroup", UserToken.IdGroup.ToString());
                context.Request.Headers.Add("IdCoQuan", UserToken.IdCoQuan.ToString());
                context.Request.Headers.Add("UserName", UserToken.UserName);
                context.Request.Headers.Add("Email", UserToken.Email);
                await _next(context);
            }
            else {
                
                if (ListLink[1].ToString().ToLower() == "admin" || (ListLink[1].ToString().ToLower() == "api" && ListLink[2].ToString().ToLower() == "roxyfileman"))
                {

                    var data = new Models.MsgError() { Success = false, Msg = "Bạn không có quyền truy cập vào Hệ Thống." };
                    try
                    {

                        if (ListLink.Count() > 3 && (ListLink[2].ToString().ToLower() == "account" && ListLink[3].ToString().ToLower() == "login"))
                        {

                            await _next(context);
                        }
                        else
                        {

                            var Login = context.Session.GetString("Login");
                            if (Login != null && Login != "")
                            {

                                USUsers MyInfo = JsonConvert.DeserializeObject<USUsers>(Login);
                                UserToken UserToken = new UserToken()
                                {
                                    Id = MyInfo.Id,
                                    IdGroup = MyInfo.IdGroup,
                                    IdCoQuan = MyInfo.IdCoQuan,
                                    UserName = MyInfo.UserName,
                                    Email = MyInfo.Email
                                };
                                context.Session.SetString("IdCoQuan", MyInfo.IdCoQuan.ToString());
                                context.Session.SetString("TenCoQuan", MyInfo.TenCoQuan);
                                context.Session.SetString("IdUser", MyInfo.Id.ToString());
                                context.Session.SetString("IdGroup", MyInfo.IdGroup.ToString());
                                context.Request.Headers.Add("Id", UserToken.Id.ToString());
                                context.Request.Headers.Add("IdGroup", UserToken.IdGroup.ToString());
                                context.Request.Headers.Add("IdCoQuan", UserToken.IdCoQuan.ToString());
                                context.Request.Headers.Add("UserName", UserToken.UserName);
                                context.Request.Headers.Add("Email", UserToken.Email);
                                context.Session.SetString("LoginError", context.Session.GetString("LoginError") + JsonConvert.SerializeObject(UserToken));
                                //context.Request.Headers.Add("UserToken", JsonConvert.SerializeObject(UserToken));
                                context.Session.SetString("ThongTinCoQuan", JsonConvert.SerializeObject(DMCoQuanService.GetItem(MyInfo.IdCoQuan)));
                                //Check quyền menu
                                var GroupItem = USGroupsService.GetItem(UserToken.IdGroup, API.Models.Settings.SecretId);
                                List<int> ListMenuId = new List<int>();
                                if (!string.IsNullOrEmpty(GroupItem.ListMenuId))
                                {
                                    ListMenuId = GroupItem.ListMenuId.Split(',').Select(int.Parse).ToList();
                                }
                                var ListItems = US_USERS_CATService.GetListPagination(new SearchUSMenu(), API.Models.Settings.SecretId);
                                var ListMenu = (from t in ListItems where ListMenuId.Contains(t.Id) select t.Controller.ToLower()).ToList();
                                if (ListMenu.Contains(ListLink[2].ToString().ToLower())|| ListLink[2].ToString().ToLower()=="account" || (ListLink[1].ToString().ToLower() == "api" && ListLink[2].ToString().ToLower() == "roxyfileman"))
                                    await _next(context);
                                else
                                    context.Response.Redirect("/Admin/Account/Login");
                                
                            }
                            else
                            {

                                context.Response.Redirect("/Admin/Account/Login");
                            }


                        }// if Login Action


                    }
                    catch (Exception e)
                    {
                        data.Data = e.Message;
                        await _next(context);
                        //await context.Response.WriteAsync(JsonConvert.SerializeObject(data));                        
                        //context.Response.Redirect("/Admin/Account/Login");

                    }


                }
                else if (ListLink[1].ToString().ToLower() == "en")
                {                  
                    await _next(context);
                }
                else
                {
                                      
                    //context.Session.SetString("LoginError", context.Session.GetString("LoginError") + "Khong hop Link.");
                    await _next(context);
                }
            }// If Dev
            

        }
        private void RemoveKeyWhenExpired(object key, object value, EvictionReason reason, object state)
        {
            var strKey = (string)key;
            //try to remove key from dictionary
            if (!_allKeys.TryRemove(strKey, out _))
                //if not possible to remove key from dictionary, then try to mark key as not existing in cache
                _allKeys.TryUpdate(strKey, false, true);
        }

        public static int GetOnlineUsersCount()
        {
            return _allKeys.Count(p => p.Value);
        }
    }

    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder UseMyAuthentication(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyAuthenticationMiddleWare>();
        }
    }

}
