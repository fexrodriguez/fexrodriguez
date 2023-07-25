using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using FactoryPlatform.Filter;

namespace FactoryPlatform.Areas.ServiceNow.Controllers.TaskMenu
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]
    public class TrainingDocsController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public TrainingDocsController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
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
        public IActionResult GetDocumentInf(int idDocument, int IdMenuTask)
        {
            string jsonDatos = "";
            var listUser = _lUsers.getIdUser(User).First();
            var model = new MainMenuTaskViewModel();

            model.DocumentTrainingTaskModel = _lPendingTask.DocumentTrainig(listUser.Id_Usuario, listUser.PlantaId, idDocument);

            jsonDatos = JsonConvert.SerializeObject(model.DocumentTrainingTaskModel.DocumentTrainingStep1);
            return Ok(jsonDatos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDocsEmployeesTraining(int idDoc, int IdMenuTask)
        {
            var listUser = _lUsers.getIdUser(User).First();
            var update = _fpContext.QualityDocsEmployeesTrainingUpdatedDocs.Where(QDET => QDET.DocumentoId == idDoc && QDET.UsuarioId == listUser.Id_Usuario && QDET.Status == 1).OrderByDescending(QDET => QDET.IdRegistro).ToList();

            if (update.Count > 0)
            {
                var QualityDocsEmployeesTrainingUpdatedDocs = update.First();

                QualityDocsEmployeesTrainingUpdatedDocs.Status = 2;
                QualityDocsEmployeesTrainingUpdatedDocs.FechaCapacitacion = DateTime.Now;
                _fpContext.Update(QualityDocsEmployeesTrainingUpdatedDocs);
                _fpContext.SaveChanges();

                return Ok("Correct");
            }
            else
            {
                return Ok("Error");
            }
        }


    }
}
