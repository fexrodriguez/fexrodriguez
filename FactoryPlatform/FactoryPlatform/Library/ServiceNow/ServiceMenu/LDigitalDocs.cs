using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPlatform.Library
{
    public class LDigitalDocs : ListObjects
    {
        public LDigitalDocs(StoresProceduresDbContext spspContext)
        {
            _SpContext = spspContext;
        }

        public DigitalDocumentsModel GetDigitalDocuments(int TipoDigital, int DigitalID, int UserID)
        {
            var model = new DigitalDocumentsModel();

            switch (TipoDigital)
            {
                case 1:
                    model.DigitalDocumentsFeasibilityModel.DigitalDocumentsFeasibility = _SpContext.DigitalDocumentsFeasibility.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                    , new object[]
                    {
                            new SqlParameter("TipoDigital", TipoDigital),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("Opcion", 1),
                            new SqlParameter("ID", DigitalID)
                    }).ToList();

                    model.DigitalDocumentsFeasibilityModel.DigitalDocumentsFeasibility_Signatures = _SpContext.DigitalDocumentsFeasibility_Signatures.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                    , new object[]
                    {
                            new SqlParameter("TipoDigital", TipoDigital),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("ID", DigitalID)
                    }).ToList();

                    break;
                case 2:

                    model.DigitalDocumentsCustomerVoiceModel.CustomerVoice_Signatures = _SpContext.DigitalDocumentsCustomerVoice_Signatures.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                     , new object[]
                     {
                                    new SqlParameter("TipoDigital", TipoDigital),
                                    new SqlParameter("UserID", UserID),
                                    new SqlParameter("Opcion", 1),
                                    new SqlParameter("ID", DigitalID)
                     }).ToList();

                    model.DigitalDocumentsCustomerVoiceModel.CustomerVoice = _SpContext.DigitalDocumentsCustomerVoice.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                    , new object[]
                    {
                            new SqlParameter("TipoDigital", TipoDigital),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("ID", DigitalID)
                    }).ToList();

                    break;
                case 3:
                    break;

                case 4:

                    model.DigitalDocumentsDesviationModel = _SpContext.DigitalDocuments_Desviations.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @ID=@ID"
                   , new object[]
                   {
                        new SqlParameter("TipoDigital", TipoDigital),
                        new SqlParameter("UserID", UserID),
                        new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();

                    //---------------------------------------------

                    break;
                case 5:

                    model.DigitalDocumentAMEF_Model = _SpContext.DigitalDocumentAMEF_Model.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @ID=@ID"
                    , new object[]
                    {
                        new SqlParameter("TipoDigital", TipoDigital),
                        new SqlParameter("UserID", UserID),
                        new SqlParameter("ID", DigitalID)
                    }).AsNoTracking().ToList();

                    break;
                case 6:

                    model.DigitalDocumentsReleaseModel.ReleaseInfoDocument = _SpContext.DigitalDocumentsReleaseInfoDocument.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                    , new object[]
                    {
                        new SqlParameter("TipoDigital", TipoDigital),
                        new SqlParameter("UserID", UserID),
                        new SqlParameter("Opcion", 1),
                        new SqlParameter("ID", DigitalID)
                    }).AsNoTracking().ToList();

                    model.DigitalDocumentsReleaseModel.ReleaseQuestions = _SpContext.DigitalDocumentsReleaseQuestions.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                    , new object[]
                    {
                        new SqlParameter("TipoDigital", TipoDigital),
                        new SqlParameter("UserID", UserID),
                        new SqlParameter("Opcion", 2),
                        new SqlParameter("ID", DigitalID)
                    }).AsNoTracking().ToList();


                    model.DigitalDocumentsReleaseModel.ReleaseQAnexoB = _SpContext.DigitalDocumentsReleaseAnexB.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                   , new object[]
                   {
                        new SqlParameter("TipoDigital", TipoDigital),
                        new SqlParameter("UserID", UserID),
                        new SqlParameter("Opcion", 3),
                        new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();

                    break;
                case 7:

                    model.DigitalDocumentsToolListModel.ToolList_Signatures = _SpContext.DigitalDocumentsToolList_Signatures.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                     , new object[]
                     {
                            new SqlParameter("TipoDigital", TipoDigital),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("Opcion", 1),
                            new SqlParameter("ID", DigitalID)
                     }).ToList();

                    model.DigitalDocumentsToolListModel.ToolListModel = _SpContext.DigitalDocumentsToolList.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID"
                   , new object[]
                   {
                            new SqlParameter("TipoDigital", TipoDigital),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();

                    break;
                case 8:

                    model.DigitalDocumentsOpenIssuesModel.DigitalDocumentsOpenIssues = _SpContext.DigitalDocumentsOpenIssuesModel.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                   , new object[]
                   {
                    new SqlParameter("TipoDigital", TipoDigital),
                    new SqlParameter("UserID", UserID),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();

                    model.DigitalDocumentsOpenIssuesModel.DigitalDocumentsOpenIssues_Hallazgo = _SpContext.DigitalDocumentsOpenIssuesModel_Hallazgo.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                   , new object[]
                   {
                    new SqlParameter("TipoDigital", TipoDigital),
                    new SqlParameter("UserID", UserID),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();
                    break;


                case 9:

                    model.DigitalDocumentsANPModel.ANP_Signatures = _SpContext.DigitalDocumentsANP_Signatures.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                   , new object[]
                   {
                    new SqlParameter("TipoDigital", TipoDigital),
                    new SqlParameter("UserID", UserID),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();

                    model.DigitalDocumentsANPModel.DigitalDocumentsANP = _SpContext.DigitalDocumentsANP.FromSqlRaw("EXEC spFPAPP_Sys_DigitalDocuments @UserID=@UserID, @TipoDigital=@TipoDigital, @Opcion= @Opcion, @ID=@ID "
                   , new object[]
                   {
                    new SqlParameter("TipoDigital", TipoDigital),
                    new SqlParameter("UserID", UserID),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("ID", DigitalID)
                   }).AsNoTracking().ToList();
                    break;
            }
            return model;
        }

    }
}
