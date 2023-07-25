using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPlatform.Library
{
    public class LHistorySetionsPagesUsers : ListObjects
    {
        public LHistorySetionsPagesUsers(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
        }

        public async Task<SoftwareConfigPagesUserHistory> CheckPagesHistory(int? IdSeccion, int IdUser, int Tipo)
        {
            var model = new SoftwareConfigPagesUserHistory();

            var Delete = _fpContext.SoftwareConfigPagesUserHistory.Where(H => H.UsuarioId == IdUser).ToList();

            if (Delete.Any())
            {
                _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation",
                new object[]
                {
                  new SqlParameter("UserID", IdUser),
                  new SqlParameter("Operation", 4)
                }).ToList();
            }
     
            if(Tipo > 0)
            {
                var savePage = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Tipo=@Tipo, @PageID=@PageID, @Operation=@Operation",
                new object[]
                {
                    new SqlParameter("UserID", IdUser),
                    new SqlParameter("Operation", 5),
                    new SqlParameter("Tipo", Tipo),
                    new SqlParameter("PageID", IdSeccion),
                }).ToList();
            }

            var select = _fpContext.SoftwareConfigPagesUserHistory.Where(H => H.UsuarioId == IdUser).ToList();

            if (select.Any())
            {
                model.PageTitle = select.First().PageTitle;
                model.PageId = Convert.ToInt32(select.First().PageId);
                model.IdSection = select.First().IdSection;
            }

            return (model);
        }


    }
}
