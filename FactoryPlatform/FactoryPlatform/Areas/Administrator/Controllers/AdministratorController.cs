using FactoryPlatform.Areas.Administrator.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [ServiceFilter(typeof(AuthorizeActionFilter))]
    public class AdministratorController : Controller
    {
        private readonly LAdministrator _lAdministrator;

        public AdministratorController(LKQMXFPAPPContext fpContext)
        {
            _lAdministrator = new LAdministrator(fpContext);
        }

        [Route("/Administrator/Users")]
        public IActionResult Users()
        {
            var model = new List<UsersModel>();
            ViewData["ProductionDepartList"] = _lAdministrator.GetProductionDepartments();
            ViewData["UserJobsList"] = _lAdministrator.GetUsersJobs();
            ViewData["DepartamentList"] = _lAdministrator.GetDepartments();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Users(int status, int departProductId)
        {
            var model = new List<UsersModel>();

            ViewData["ProductionDepartList"] = _lAdministrator.GetProductionDepartments();
            ViewData["UserJobsList"] = _lAdministrator.GetUsersJobs();
            ViewData["DepartamentList"] = _lAdministrator.GetDepartments();

            model = _lAdministrator.GetUsers(status, departProductId);
            ViewData["alert"] = null;

            return View(model);
        }

    }
}
