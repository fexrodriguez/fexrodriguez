using FactoryPlatform.Data;
using FactoryPlatform.Helper;
using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPlatform.Filter
{
    public class ActionMethodServiceNowFilter : ActionFilterAttribute
    {
        private readonly LValidationLogin _lValidationLogin;
        private readonly LValidationPages _lValidationPages;
        private readonly LValidateServiceNow _lValidateServiceNow;
        private LKQMXFPAPPContext _fpContext;
        public ActionMethodServiceNowFilter(ApplicationDbContext context, LKQMXFPAPPContext fpContext)
        {
            _lValidateServiceNow = new LValidateServiceNow(context);
            _lValidationLogin = new LValidationLogin(context);
            _fpContext = fpContext;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int serviceMenuId = new int();
            int taskMenuId = new int();

            if (filterContext.ActionArguments.ContainsKey("IdMenuService"))
            {
                serviceMenuId = Convert.ToInt16(filterContext.ActionArguments["IdMenuService"]);
            }
            if (filterContext.ActionArguments.ContainsKey("IdMenuTask"))
            {
                taskMenuId = Convert.ToInt16(filterContext.ActionArguments["IdMenuTask"]);
            }

            var action = (filterContext.HttpContext.Request.RouteValues.Values).ToList();
            var route = "/FactoryPlatform";

            var user = filterContext.HttpContext.User.Identity.Name;
            var usuario = CookieHelper.GetUsuario(filterContext.HttpContext.User);
            var sessionHash = CookieHelper.GetSessionHash(filterContext.HttpContext.User);
            var existSession = new List<Users_ValidationSession>();

            int contador = 0;
            if (action.Count == 3)
            {
                foreach (var item in action)
                {
                    if (contador > 0)
                    {
                        route = $"{route}/{item}";
                    }
                    contador++;
                }
            }
            else
            {
                foreach (var item in action)
                {
                    route = $"{route}/{item}";
                }
            }

            try
            {
                if(serviceMenuId > 0 || taskMenuId > 0)
                {
                    if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                    {
                        var dataUser1 = _lValidationLogin.infoUserByCorreo(user);
                        var dataUser2 = _lValidationLogin.infoUserIdentify(usuario);

                        if (user.Contains("@") && dataUser1.Count == 0)
                        {
                            filterContext.Result = new OkObjectResult("noSession");
                        }
                        else if (dataUser2.Count == 0 && dataUser1.Count == 0)
                        {
                            filterContext.Result = new OkObjectResult("noSession");
                        }
                        else
                        {
                            existSession = user.Contains("@") ? _lValidationLogin.checkSession(dataUser1.First().Usuario)
                            : _lValidationLogin.checkSession(dataUser2.First().Usuario);

                            if (existSession.Count > 0)
                            {
                                if (sessionHash != existSession.First().IDSesion)
                                {
                                    filterContext.Result = new OkObjectResult("noSession");
                                }
                            }
                            else
                            {
                                filterContext.Result = new OkObjectResult("noSession");
                            }
                        }
                    }
                    else
                    {
                        filterContext.Result = new OkObjectResult("noSession");
                    }
                }
                else
                {
                    if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                    {
                        var dataUser1 = _lValidationLogin.infoUserByCorreo(user);
                        var dataUser2 = _lValidationLogin.infoUserIdentify(usuario);

                        if (user.Contains("@") && dataUser1.Count == 0)
                        {
                            filterContext.Result = new RedirectResult("/FactoryPlatform");
                        }
                        else if (dataUser2.Count == 0 && dataUser1.Count == 0)
                        {
                            filterContext.Result = new RedirectResult("/FactoryPlatform");
                        }
                        else
                        {
                            existSession = user.Contains("@") ? _lValidationLogin.checkSession(dataUser1.First().Usuario)
                            : _lValidationLogin.checkSession(dataUser2.First().Usuario);

                            if (existSession.Count > 0)
                            {
                                if (sessionHash != existSession.First().IDSesion)
                                {
                                    filterContext.Result = new RedirectResult("/FactoryPlatform");
                                }
                            }
                            else
                            {
                                filterContext.Result = new RedirectResult("/FactoryPlatform");
                            }
                        }
                    }
                    else
                    {
                        filterContext.Result = new RedirectResult("/FactoryPlatform");
                    }
                }
                
                //MainMenu Validation
                if (taskMenuId > 0)
                {
                    var Query = _lValidateServiceNow.validateTaskMenu(route, filterContext.HttpContext.User, taskMenuId);
                    if (Query.Respuesta == 0)
                    {
                        if (Query.Tipo == "Metodo" || Query.Tipo == null)
                        {
                            filterContext.Result = new OkObjectResult("Sorry");
                        }
                        else
                        {
                            var select = _fpContext.SoftwareConfigMainMenu.Where(SM => SM.IdMenuSeccion == taskMenuId).ToList();
                            if (select.Count > 0)
                            {
                                filterContext.Result = new RedirectResult($"/FactoryPlatform/Privacy?message=Sorry, you dont have acces to the next page: {select.First().MenuSeccion}.");
                            }
                        }
                    }
                }
                //ServiceMenu Validation
                if (serviceMenuId > 0)
                {
                    var Query = _lValidateServiceNow.validateServiceMenu(route, filterContext.HttpContext.User, serviceMenuId);
                    if (Query.Respuesta == 0)
                    {
                        if (Query.Tipo == "Metodo" || Query.Tipo == null)
                        {
                            filterContext.Result = new OkObjectResult("Sorry");
                        }
                        else
                        {
                            var select = _fpContext.SoftwareConfigServicesMenu.Where(SM => SM.IdMenuService == serviceMenuId).ToList();
                            if (select.Count > 0)
                            {
                                filterContext.Result = new RedirectResult($"/FactoryPlatform/Privacy?message=Sorry, you dont have acces to the next page: {select.First().MenuSeccion}.");
                            }
                        }
                    }
                }

                base.OnActionExecuting(filterContext);
            }
            catch (Exception)
            {
                filterContext.Result = new OkObjectResult("noSession");
            }
        }



    }
}
