using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    public class ServiceMenuController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public ServiceMenuController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
        {
            _fpContext = fpContext;
            _SpContext = SpContext;
            _lUsers = new LUsers(appContext);
            _ServiceNow = new LServiceNow(SpContext, fpContext);
            _lPendingTask = new LPendingTask(SpContext);
            _lDocControl = new LDocumentControl(SpContext, fpContext);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WorkOrderComboData(int station, int IdMenuService)
        {
            string jsonDatos = "";
            var listUser = _lUsers.getIdUser(User).First();
            var model = new ServiceMenuViewModel();

            switch (IdMenuService)
            {
                case 7:
                    model = _ServiceNow.SecondCombosWorkOrders(station, listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                    jsonDatos = JsonConvert.SerializeObject(model.EngWorkOrdersModel);
                    break;
                case 8:
                    model = _ServiceNow.SecondCombosWorkOrders(station, listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                    jsonDatos = JsonConvert.SerializeObject(model.ItWorkOrdersModel);
                    break;
                case 9:
                    model = _ServiceNow.SecondCombosWorkOrders(station, listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                    jsonDatos = JsonConvert.SerializeObject(model.MTCEWorkOrdersModel);
                    break;
                case 10:
                    model = _ServiceNow.SecondCombosWorkOrders(station, listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                    jsonDatos = JsonConvert.SerializeObject(model.QltyWorkOrdersModel);
                    break;
                case 13:
                    model = _ServiceNow.SecondCombosWorkOrders(station, listUser.Id_Usuario, IdMenuService, listUser.PlantaId);
                    jsonDatos = JsonConvert.SerializeObject(model.HRWorkOrdersModel);
                    break;
            }

            return Ok(jsonDatos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateWorkOrders(int classId, int typeId, int workStationId, int departamentId, int plantId, int hardwareId, string commentStr, int machineId, int IdMenuService)
        {
            var listUser = _lUsers.getIdUser(User).First();

            if (_ServiceNow.InsertWorkOrder(classId, typeId, workStationId, departamentId, plantId, hardwareId, machineId, commentStr, IdMenuService, listUser.Id_Usuario))
            {
                return Ok("correct");
            }

            return Ok("error");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatNewItem(string NICode, string NIDescription, string NIMiddleCode, int PurchaserNI, int IdMenuService)
        {
            var listUser = _lUsers.getIdUser(User).First();

            if (await _ServiceNow.InsertNewItem(NICode, NIDescription, NIMiddleCode, PurchaserNI, listUser.Id_Usuario, listUser.PlantaId))
            {
                return Ok("correct");
            }
            else
            {
                return Ok("error");
            }
        }


    }
}
