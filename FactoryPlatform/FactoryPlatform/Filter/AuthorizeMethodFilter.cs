using FactoryPlatform.Data;
using FactoryPlatform.Helper;
using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPlatform.Filter
{
    public class AuthorizeMethodFilter : ActionFilterAttribute
    {
        
        private readonly LValidationPages _lValidationPages;

        public AuthorizeMethodFilter(ApplicationDbContext context, LKQMXFPAPPContext fpContext)
        {
            _lValidationPages = new LValidationPages(context, fpContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int IdSeccion = new int();

            if (filterContext.ActionArguments.ContainsKey("IdSeccion"))
            {
                IdSeccion = Convert.ToInt16(filterContext.ActionArguments["IdSeccion"]);
            }
            else if(filterContext.ActionArguments.ContainsKey("SeccionId"))
            {
                IdSeccion = Convert.ToInt16(filterContext.ActionArguments["SeccionId"]);
            }

            var action = (filterContext.HttpContext.Request.RouteValues.Values).ToList();
            var route = "/FactoryPlatform";

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
                var modelValidatePage = _lValidationPages.validatePage(route, filterContext.HttpContext.User, IdSeccion);

                if (modelValidatePage.Respuesta == 0)
                {
                    if (modelValidatePage.Tipo == "Accion")
                    {
                        filterContext.Result = new OkObjectResult("Sorry");
                    }
                    else if(modelValidatePage.Tipo == "NoPage")
                    {
                        filterContext.Result = new OkObjectResult("NoPage");
                    }
                    else
                    {
                        filterContext.Result = new RedirectResult($"/FactoryPlatform/Privacy?message=Sorry, you dont have acces to the next page: {modelValidatePage.Pagina}.");
                    }
                }

                base.OnActionExecuting(filterContext);
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("/FactoryPlatform");
            }
        }

    }
}
