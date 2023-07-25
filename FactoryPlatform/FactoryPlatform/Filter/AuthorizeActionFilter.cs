using FactoryPlatform.Data;
using FactoryPlatform.Helper;
using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPlatform.Filter
{
    public class AuthorizeActionFilter : ActionFilterAttribute
    {
        private readonly LValidationLogin _lValidationLogin;

        public AuthorizeActionFilter(ApplicationDbContext context)
        {
            _lValidationLogin = new LValidationLogin(context);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int IdSeccion = new int();

            if (filterContext.ActionArguments.ContainsKey("IdSeccion"))
            {
                IdSeccion = Convert.ToInt16(filterContext.ActionArguments["IdSeccion"]);
            }

            var user = filterContext.HttpContext.User.Identity.Name;
            var usuario = CookieHelper.GetUsuario(filterContext.HttpContext.User);
            var sessionHash = CookieHelper.GetSessionHash(filterContext.HttpContext.User);
            var existSession = new List<Users_ValidationSession>();

            try
            {
                if (IdSeccion > 0)
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

                base.OnActionExecuting(filterContext);

            }
            catch (Exception)
            {

                if (IdSeccion > 0)
                {
                    filterContext.Result = new RedirectResult("/FactoryPlatform");
                }
                else
                {
                    filterContext.Result = new OkObjectResult("noSession");
                }
            }
        }
    }
}
