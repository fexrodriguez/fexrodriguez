using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.EJ2.FileManager.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]
    public class HomeController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public HomeController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
        {
            _fpContext = fpContext;
            _SpContext = SpContext;
            _lUsers = new LUsers(appContext);
            _ServiceNow = new LServiceNow(SpContext, fpContext);
            _lPendingTask = new LPendingTask(SpContext);
            _lDocControl = new LDocumentControl(SpContext, fpContext);
        }

        public IActionResult SystemHost()
        {
            var listUser = _lUsers.getIdUser(User);
            var model = new SystemHostViewModel();

            model.MainMenu = _SpContext.MainMenuModel.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_SystemHost @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Operacion=@Operacion"
             , new object[]
            {
                new SqlParameter("UsuarioID", listUser.First().Id_Usuario),
                new SqlParameter("PlantaID", listUser.First().PlantaId),
                new SqlParameter("Operacion", 1),

            }).AsNoTracking().ToList();

            model.ServicesMenu = _SpContext.ServicesMenuModel.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_SystemHost @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Operacion=@Operacion"
             , new object[]
            {
                new SqlParameter("UsuarioID", listUser.First().Id_Usuario),
                new SqlParameter("PlantaID", listUser.First().PlantaId),
                new SqlParameter("Operacion", 2),

            }).AsNoTracking().ToList();



            return View(model);
        }

      
        //--------------------------------------Main Menu-----------------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MainMenuTaksPartial(int IdMenuTask)
        {
            if (User.Identity.IsAuthenticated)
            {
                var listUser = _lUsers.getIdUser(User).First();

                var model = new MainMenuTaskViewModel();

                switch (IdMenuTask)
                {
                    //Docs.Edition
                    case 1:
                        model.DocsEditionTaskModel = _lPendingTask.DocsEdition(listUser.Id_Usuario, listUser.PlantaId, 0);
                        model.DocsEditionTaskModel.UsersPrivileges = _fpContext.QualityDocsUsersPrivileges.Where(Q => Q.PrivilegioId == 4 && Q.UsuarioId == listUser.Id_Usuario).ToList();
                        model.DocsEditionTaskModel.PrivilageNewReview = _fpContext.QualityDocsUsersPrivileges.Where(Q => Q.PrivilegioId == 1 && Q.UsuarioId == listUser.Id_Usuario).ToList();
                        model.DocsEditionTaskModel.OriginChange = _lDocControl.ComboData(listUser.Id_Usuario, 7, listUser.PlantaId, 0).OriginChange;
                        model.DocsEditionTaskModel.UsersReponsables = _lDocControl.ComboData(listUser.Id_Usuario, 8, listUser.PlantaId, 0).UsersReponsables;
                        model.DocsEditionTaskModel.ProductionStations = _lDocControl.ComboData(listUser.Id_Usuario, 4, listUser.PlantaId, 0).ProductionStations;
                        model.DocsEditionTaskModel.Id_Usuario = listUser.Id_Usuario;
                        break;
                    // Pre-Approval 
                    case 2:
                        model.PreApprovalTaskModel = _lPendingTask.PreApproval(listUser.Id_Usuario, listUser.PlantaId);
                        model.PreApprovalTaskModel.Id_Usuario = listUser.Id_Usuario;
                        break;
                    //FinalSignature
                    case 3:
                        model.FinalSignatureTaskModel = _lPendingTask.FinalSignature(listUser.Id_Usuario, listUser.PlantaId);
                        model.FinalSignatureTaskModel.Id_Usuario = listUser.Id_Usuario;
                        break;
                    //Anp Control
                    case 6:
                        model.TMAnpControlViewModel = _lPendingTask.AnpControl(listUser.Id_Usuario, listUser.PlantaId);
                        model.TMAnpControlViewModel.Id_Usuario = listUser.Id_Usuario;
                        break;

                    case 15:
                        model.DocsStructureTaskModel = _lPendingTask.DocsStructure(listUser.Id_Usuario, listUser.PlantaId);
                        model.DocsStructureTaskModel.Id_Usuario = listUser.Id_Usuario;
                        break;

                    //TrainingDocs
                    case 10:
                        model.DocumentTrainingTaskModel = _lPendingTask.DocumentTrainig(listUser.Id_Usuario, listUser.PlantaId, 0);
                        break;
                    case 13:
                        model.TMCorrectiveActionViewModel = _lPendingTask.CorrectiveAction(listUser.Id_Usuario, listUser.PlantaId);
                        model.TMCorrectiveActionViewModel.UserID = listUser.Id_Usuario;
                        break;
                }

                ViewData["TituloMenuTask"] = _fpContext.SoftwareConfigMainMenu.Where(SM => SM.IdMenuSeccion == IdMenuTask).AsNoTracking().ToList().First().MenuSeccion;
                ViewData["MenuTaskId"] = IdMenuTask;

                return PartialView("MainMenuTaskPartial", model);
            }
            else
            {
                return Ok("noSession");
            }
        }

        //----------------------------------Service Menu-----------------------------------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ServiceMenuPartial(int IdMenuService)
        {
            var listUser = _lUsers.getIdUser(User).First();
            var model = new ServiceMenuViewModel();


            switch (IdMenuService)
            {
                case 1:
                    model.DocViewerViewModel = _ServiceNow.FirstCombosDocViewer(listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                break;
                case 7:
                    model.EngWorkOrdersModel = _ServiceNow.FirstCombosWorkOrders(listUser.Id_Usuario, IdMenuService, listUser.PlantaId).EngWorkOrdersModel;
                    break;
                case 8:
                    model.ItWorkOrdersModel = _ServiceNow.FirstCombosWorkOrders(listUser.Id_Usuario, IdMenuService, listUser.PlantaId).ItWorkOrdersModel;
                    break;
                case 9:
                    model.MTCEWorkOrdersModel = _ServiceNow.FirstCombosWorkOrders(listUser.Id_Usuario, IdMenuService, listUser.PlantaId).MTCEWorkOrdersModel;
                    break;
                case 10:
                    model.QltyWorkOrdersModel = _ServiceNow.FirstCombosWorkOrders(listUser.Id_Usuario, IdMenuService, listUser.PlantaId).QltyWorkOrdersModel;
                    break;
                case 13:
                    model.HRWorkOrdersModel = _ServiceNow.FirstCombosWorkOrders(listUser.Id_Usuario, IdMenuService, listUser.PlantaId).HRWorkOrdersModel;
                    break;
                case 25:
                    model.CaptureNewItem = _ServiceNow.NewItemCombos(listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                    break;
                case 28:
                    model.CorrectiveActionViewModel = _ServiceNow.CombosCorrectiveAction(listUser.Id_Usuario, listUser.PlantaId);
                    break;
            }

            ViewData["TituloOrderPartial"] = _fpContext.SoftwareConfigServicesMenu.Where(SM => SM.IdMenuService == IdMenuService).AsNoTracking().ToList().First().MenuSeccion;
            ViewData["MenuId"] = IdMenuService;
            return PartialView("ServiceMenuPartial", model);
        }


    }
}



