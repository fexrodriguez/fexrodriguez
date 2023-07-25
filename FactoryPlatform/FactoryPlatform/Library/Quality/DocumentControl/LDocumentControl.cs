using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPlatform.Library
{
    public class LDocumentControl : ListObjects
    {
        public LDocumentControl(StoresProceduresDbContext spContext, LKQMXFPAPPContext fpContext)
        {
            _SpContext = spContext;
            _fpContext = fpContext;
        }

        //---------------------------------------------------------------------------------------
        //Document List
        //---------------------------------------------------------------------------------------

        public List<spFPAPP_Sys_FtpCredencials> GetFtp(int UserId)
        {
            var model = new List<spFPAPP_Sys_FtpCredencials>();
            model = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
               new object[]
               {
                    new SqlParameter("UserID", UserId)
               }).AsNoTracking().ToList();


            return model;
        }

        public List<StoresDocumentList> DocumentList(int Planta, int Departament, int Stations, int Status, string Key, string Description, int UserId)
        {
            _SpContext.Database.SetCommandTimeout(1500);
            var Model = new List<StoresDocumentList>();

            Model = _SpContext.DocumentList.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                 "@Operacion = @Operacion, " +
                 "@Tipo = @Tipo, " +
                 "@UserID = @UserID, " +
                 "@PlantID = @PlantID, " +
                 "@Clave = @Clave, " +
                 "@Descripcion = @Description, " +
                 "@Estacion = @Estacion, " +
                 "@Departamento = @Departamento, " +
                 "@StatusDoc = @StatusDoc"
             , new object[]
             {
                new SqlParameter("Operacion", 3),
                new SqlParameter("Tipo", 1),
                new SqlParameter("UserID", UserId),
                new SqlParameter("PlantID", Planta),
                new SqlParameter("Clave", Key),
                new SqlParameter("Description", Description),
                new SqlParameter("Estacion", Stations),
                new SqlParameter("Departamento",Departament),
                new SqlParameter("StatusDoc", Status)
             }).AsNoTracking().ToList();

            return Model;
        }

        public List<DocumentList_Signature> DocListSignatures(int UserId, string jsonListaDatos)
        {
            _SpContext.Database.SetCommandTimeout(1500);
            var siglist = new List<DocumentList_Signature>();

            siglist = _SpContext.DocumentList_Signature.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                    "@UserID = @UserID, " +
                    "@Clave = @Clave, @Operacion = @Operacion, @Tipo = @Tipo"
                    , new object[]
                    {
                         new SqlParameter("Operacion", 3),
                            new SqlParameter("Tipo", 2),
                        new SqlParameter("UserID", UserId),
                        new SqlParameter("Clave", jsonListaDatos)
                    }).AsNoTracking().ToList();
            return siglist;
        }

        public DocViewerViewModel ComboData(int UserID, int ComboId, int? PlantaId, int ValueCombo)
        {
            var DocViewModel = new DocViewerViewModel();

            switch (ComboId)
            {
                case 1:
                    DocViewModel.Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID =@PlantID , @Operacion = @Operacion, @Opcion = @Opcion",
                        new object[]
                        {
                            new SqlParameter("Operacion", 2),
                            new SqlParameter("Opcion", 1),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaId)
                        }).AsNoTracking().ToList();
                    break;
                case 2:
                    DocViewModel.ProductionDepartments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @ValueCombo =@ValueCombo , @Operacion=@Operacion, @Tipo = @Tipo",
                     new object[]
                     {
                            new SqlParameter("Operacion", 3),
                            new SqlParameter("Tipo", 3),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("ValueCombo", ValueCombo)
                     }).AsNoTracking().ToList();

                    break;
                case 3:
                    DocViewModel.ProductionStations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID , @ValueCombo =@ValueCombo, @Operacion = @Operacion, @Tipo = @Tipo",
                   new object[]
                   {
                            new SqlParameter("Operacion", 3),
                            new SqlParameter("Tipo", 4),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("ValueCombo", ValueCombo)
                   }).AsNoTracking().ToList();
                    break;
                case 4:

                    DocViewModel.ProductionStations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID =@PlantID , @Operacion = @Operacion, @Opcion = @Opcion",
                     new object[]
                     {
                            new SqlParameter("Operacion", 2),
                            new SqlParameter("Opcion", 3),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaId)
                     }).AsNoTracking().ToList();

                    break;
                case 5:
                    DocViewModel.DocumentsKeys = _SpContext.DocumentsKeys.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID , @PlantID = @PlantID, @Operacion = @Operacion, @Tipo = @Tipo",
                   new object[]
                   {
                            new SqlParameter("Operacion", 3),
                            new SqlParameter("Tipo", 5),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaId)
                   }).AsNoTracking().ToList();
                    break;
                case 6:
                    DocViewModel.Keys_longitud = _SpContext.Keys_longitud.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID , @ValueCombo =@ValueCombo, @Operacion = @Operacion, @Tipo = @Tipo,  @PlantID = @PlantID",
                      new object[]
                      {
                                new SqlParameter("Operacion", 3),
                                new SqlParameter("Tipo", 6),
                                new SqlParameter("UserID", UserID),
                                new SqlParameter("ValueCombo", ValueCombo),
                                 new SqlParameter("PlantID", PlantaId)
                      }).AsNoTracking().ToList();
                    break;

                case 7:
                    var DocsOrigin = _fpContext.QualityDocsOriginChange.Select(O => new
                    {
                        O.Value,
                        O.Titulo
                    }).AsNoTracking().ToList();
                    DocsOrigin.ForEach(item =>
                    {
                        DocViewModel.OriginChange.Add(new SelectListItem
                        {
                            Value = item.Value.ToString(),
                            Text = item.Titulo
                        });
                    });
                    break;
                case 8:
                    DocViewModel.UsersReponsables = _SpContext.UsersReponsables.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID , @PlantID = @PlantID, @Operacion = @Operacion, @Tipo = @Tipo",
                   new object[]
                   {
                            new SqlParameter("Operacion", 3),
                            new SqlParameter("Tipo", 8),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaId)
                   }).AsNoTracking().ToList();
                    break;
            }
            return DocViewModel;
        }

    }
}
