using FactoryPlatform.Data;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Principal;

namespace FactoryPlatform.Library
{
    public class LValidationPages : ListObjects
    {
        private readonly LUsers _lUser;
        public LValidationPages(ApplicationDbContext appContext, LKQMXFPAPPContext fpContext)
        {
            _appContext = appContext;
            _lUser = new LUsers(appContext);
            _fpContext = fpContext;
        }

        public spFPAPP_Sys_pageValidation validatePage(string ruta, IPrincipal user, int IdSeccion)
        {
            var userId = _lUser.getIdUser(user).ToList().First().Id_Usuario;

            var model = new spFPAPP_Sys_pageValidation();
            
            var Query = _appContext.spFPAPP_Sys_pageValidation.FromSqlRaw("EXEC spFPAPP_Sys_pageValidation @Pagina = @Pagina, @UserID = @UserID, @SeccionID  = @SeccionID",
            new object[]
            {
                new SqlParameter("Pagina", ruta),
                new SqlParameter("UserID", userId),
                new SqlParameter("SeccionID ", IdSeccion)

            }).AsNoTracking().ToList();

            if(Query.Count > 0)
            {
                model = Query.First();
            }
            
            return model;
        }

    }
}
