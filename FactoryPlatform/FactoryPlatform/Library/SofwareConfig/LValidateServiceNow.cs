using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Principal;

namespace FactoryPlatform.Library
{
    public class LValidateServiceNow : ListObjects
    {
        private readonly LUsers _lUser;

        public LValidateServiceNow(ApplicationDbContext appContext)
        {
            _appContext = appContext;
            _lUser = new LUsers(appContext);
        }

        public spFPAPP_Sys_serviceNowValidation validateTaskMenu(string ruta, IPrincipal user, int taskMenuId)
        {
            var userId = _lUser.getIdUser(user).ToList().First().Id_Usuario;

            var Result = new spFPAPP_Sys_serviceNowValidation();

            var Query = _appContext.spFPAPP_Sys_serviceNowValidation.FromSqlRaw("EXEC spFPAPP_Sys_serviceNowValidation @Pagina = @Pagina, @UserID = @UserID, @MenuServiceID= @MenuServiceID, @TipoID=@TipoID",
             new object[]
             {
                new SqlParameter("Pagina", ruta),
                new SqlParameter("UserID", userId),
                new SqlParameter("MenuServiceID ", taskMenuId),
                new SqlParameter("TipoID", 1)
             }).AsNoTracking().ToList();

            if (Query.Count > 0)
            {
                Result = Query.First();
            }

            return Result;
        }

        public spFPAPP_Sys_serviceNowValidation validateServiceMenu(string ruta, IPrincipal user, int serviceMenuId)
        {
            var userId = _lUser.getIdUser(user).ToList().First().Id_Usuario;

            var Result = new spFPAPP_Sys_serviceNowValidation();

            var Query = _appContext.spFPAPP_Sys_serviceNowValidation.FromSqlRaw("EXEC spFPAPP_Sys_serviceNowValidation @Pagina = @Pagina, @UserID = @UserID, @MenuServiceID= @MenuServiceID, @TipoID=@TipoID",
             new object[]
             {
                new SqlParameter("Pagina", ruta),
                new SqlParameter("UserID", userId),
                new SqlParameter("MenuServiceID ", serviceMenuId),
                new SqlParameter("TipoID", 2)
             }).AsNoTracking().ToList();


            if (Query.Count > 0) 
            {
                Result = Query.First();
            }

            return Result;
        }

     


    }
}
