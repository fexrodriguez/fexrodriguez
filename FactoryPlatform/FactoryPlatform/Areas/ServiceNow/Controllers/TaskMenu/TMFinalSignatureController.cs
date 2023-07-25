using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Filter;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]
    public class TMFinalSignatureController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public TMFinalSignatureController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
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

			if (preApprovals.Any())
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
		public IActionResult FinishApproval(int IdDocument, int Revision, string Clave, int IdMenuTask)
		{
			var listUser = _lUsers.getIdUser(User).First();
			string Json = "";

			var preApprovals = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @DocumentoID = @DocumentoID, " +
		   "@UserID = @UserID, @RevisionDoc = @RevisionDoc, @Operacion = @Operacion,  @Opcion = @Opcion, @Clave=@Clave",
			new object[]
		   {
			new SqlParameter("Operacion", 11),
			new SqlParameter("Opcion", 2),
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
