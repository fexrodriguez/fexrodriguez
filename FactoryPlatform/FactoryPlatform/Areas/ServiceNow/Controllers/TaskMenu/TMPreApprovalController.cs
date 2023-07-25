using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using FactoryPlatform.Filter;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]

    public class TMPreApprovalController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public TMPreApprovalController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
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
        public IActionResult PreApprovalDocInf(int idDocument, int IdMenuTask)
        {
            var listUser = _lUsers.getIdUser(User).First();
            string Json = "";
            
            var preApprovals = _SpContext.DocumentTrainingStep1.FromSqlRaw("EXEC spFPAPP_Services_now_TrainingDocs @DocumentID = @DocumentID, @UserID = @UserID, @PlantID = @PlantID, " +
           "@Opcion = @Opcion",
            new object[]
           {
            new SqlParameter("Opcion", 2),
            new SqlParameter("UserID", listUser.Id_Usuario),
            new SqlParameter("PlantID", listUser.PlantaId),
            new SqlParameter("DocumentID", idDocument)
           }).AsNoTracking().ToList();


            Json = JsonConvert.SerializeObject(preApprovals);

            return Ok(Json);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveComments(int idDoc, int revision, string comments, int IdMenuTask)
        {
            var listUser = _lUsers.getIdUser(User).First();
            string Json = "";

            var preApprovals = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @DocumentoID = @DocumentoID, " +
           "@UserID = @UserID, @RevisionDoc = @RevisionDoc, @Operacion = @Operacion,  @Opcion = @Opcion, @Comentarios=@Comentarios",
            new object[]
           {
            new SqlParameter("Operacion", 10),
            new SqlParameter("Opcion", 2),
            new SqlParameter("UserID", listUser.Id_Usuario),
            new SqlParameter("RevisionDoc", revision),
            new SqlParameter("DocumentoID", idDoc),
            new SqlParameter("Comentarios", comments),
           }).AsNoTracking().ToList();

            if(preApprovals.Any() )
            {
                return Ok("Success");
            }
            else
            {
                return Ok("Error");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FinishApproval(int IdDocument, int Revision, string Clave,  int IdMenuTask)
        {
            var listUser = _lUsers.getIdUser(User).First();
            string Json = "";

            var preApprovals = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @DocumentoID = @DocumentoID, " +
           "@UserID = @UserID, @RevisionDoc = @RevisionDoc, @Operacion = @Operacion,  @Opcion = @Opcion, @Clave=@Clave",
            new object[]
           {
            new SqlParameter("Operacion", 11),
            new SqlParameter("Opcion", 1),
            new SqlParameter("UserID", listUser.Id_Usuario),
            new SqlParameter("RevisionDoc", Revision),
            new SqlParameter("DocumentoID", IdDocument),
            new SqlParameter("Clave", Clave),
           }).AsNoTracking().ToList();

            if (preApprovals.Any())
            {
                return Ok("Success");
            }
            else
            {
                return Ok("Error");
            }
        }

    }
}
