using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPlatform.Library
{
    public class LPendingTask : ListObjects
    {
        public LPendingTask(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        //=================================Docs Edition ===============================================================
        public DocsEditionTaskModel DocsEdition(int userId, int plantId, int idDocument)
        {
            var model = new DocsEditionTaskModel();

            model.DocsEdition = _SpContext.DocsEditStoreModel.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID = @PlantID, " +
           "@Operacion = @Operacion",
           new object[]
           {
            new SqlParameter("Operacion", 6),
            new SqlParameter("UserID", userId),
            new SqlParameter("PlantID", plantId)
           }).AsNoTracking().ToList();

            return model;
        }

        //======================================Pre Approval ===============================================================
        public PreApprovalTaskModel PreApproval(int userId, int plantId)
        {
            var model = new PreApprovalTaskModel();

            model.PreApproval = _SpContext.PreApprovalModel.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID = @PlantID, " +
           "@Operacion = @Operacion",
           new object[]
           {
            new SqlParameter("Operacion", 8),
            new SqlParameter("UserID", userId),
            new SqlParameter("PlantID", plantId)
           }).AsNoTracking().ToList();

            return model;
        }

        //======================================== Final Signature ===============================================================
        public FinalSignatureTaskModel FinalSignature(int userId, int plantId)
        {
            var model = new FinalSignatureTaskModel();

            model.FinalSignature = _SpContext.FinalSignatureModel.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID = @PlantID, " +
           "@Operacion = @Operacion",
           new object[]
           {
            new SqlParameter("Operacion", 9),
            new SqlParameter("UserID", userId),
            new SqlParameter("PlantID", plantId)
           }).AsNoTracking().ToList();

            return model;
        }

        //======================================== Docs Structure ===============================================================
        public DocsStructureTaskModel DocsStructure(int userId, int plantId)
        {
            var model = new DocsStructureTaskModel();

            model.DocsStructure = _SpContext.DocsStructureModel.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID = @PlantID, " +
           "@Operacion = @Operacion",
           new object[]
           {
            new SqlParameter("Operacion", 12),
            new SqlParameter("UserID", userId),
            new SqlParameter("PlantID", plantId)
           }).AsNoTracking().ToList();

            return model;
        }

        //======================================== Corrective Actions ===============================================================
        public TMCorrectiveActionViewModel CorrectiveAction(int userId, int plantId)
        {
            var model = new TMCorrectiveActionViewModel();
            //Report Corrective actions
            model.TMReportCorrectiveAction = _SpContext.TMReportCorrectiveAction.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
           "@UsuarioID = @UsuarioID, @PlantaID= @PlantaID, " +
           "@Operacion = @Operacion",
           new object[]
           {
            new SqlParameter("Operacion", 3),
            new SqlParameter("UsuarioID", userId),
            new SqlParameter("PlantaID", plantId)
           }).AsNoTracking().ToList();

            //Step 1 combos
            var Sources = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 2),
                new SqlParameter("UsuarioID", userId),
                new SqlParameter("PlantaID", plantId)
            }).AsNoTracking().ToList();

            if (Sources.Any())
            {
                Sources.ForEach(item =>
                {
                    model.Quality_CA_Sources.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var Departments = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 3),
                new SqlParameter("UsuarioID", userId),
                new SqlParameter("PlantaID", plantId)   
            }).AsNoTracking().ToList();

            if (Departments.Any())
            {
                Departments.ForEach(item =>
                {
                    model.Production_Departments.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var Quality_Processes = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 7),
                new SqlParameter("UsuarioID", userId),
                new SqlParameter("PlantaID", plantId)
            }).AsNoTracking().ToList();

            if (Quality_Processes.Any())
            {
                Quality_Processes.ForEach(item =>
                {
                    model.Quality_Processes.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }


            var Activity = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 5),
                new SqlParameter("UsuarioID", userId),
                new SqlParameter("PlantaID", plantId)
            }).AsNoTracking().ToList();

            if (Activity.Any())
            {
                Activity.ForEach(item =>
                {
                    model.Quality_CA_Activity.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var CategoryAccion = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 6),
                new SqlParameter("UsuarioID", userId),
                new SqlParameter("PlantaID", plantId)
            }).AsNoTracking().ToList();

            if (CategoryAccion.Any())
            {
                CategoryAccion.ForEach(item =>
                {
                    model.Quality_CA_CategoryAccion.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }


            //Step 3 combos
            var Closer = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
           "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 8),
                new SqlParameter("UsuarioID", userId),
                new SqlParameter("PlantaID", plantId),
           }).AsNoTracking().ToList();

            if (Closer.Any())
            {
                Closer.ForEach(item =>
                {
                    model.ClosersUsers.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var Solution = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
             "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
             new object[]
             {
                    new SqlParameter("Operacion", 1),
                    new SqlParameter("Caso", 9),
                    new SqlParameter("UsuarioID", userId),
                    new SqlParameter("PlantaID", plantId),
             }).AsNoTracking().ToList();

                if (Solution.Any())
                {
                Solution.ForEach(item =>
                    {
                        model.SolutionType.Add(new SelectListItem
                        {
                            Value = item.ID.ToString(),
                            Text = item.Text.ToString()
                        });
                    });
                }

               
            var Responsible = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
               new object[]
               {
                        new SqlParameter("Operacion", 1),
                        new SqlParameter("Caso", 4),
                        new SqlParameter("UsuarioID", userId),
                        new SqlParameter("PlantaID", plantId),
               }).AsNoTracking().ToList();

                if (Responsible.Any())
                {
                    Responsible.ForEach(item =>
                    {
                        model.Quality_CA_Responsible.Add(new SelectListItem
                        {
                            Value = item.ID.ToString(),
                            Text = item.Text.ToString()
                        });
                    });
                }



            return model;
        }


        //=================================Document training ===============================================================
        public DocumentTrainingTaskModel DocumentTrainig(int userId, int plantId, int idDocument)
        {
            var model = new DocumentTrainingTaskModel();
            
            if (idDocument == 0)
            {
                model.DocumentTrainingModel = new List<DocumentTrainingModel>();
                model.DocumentTrainingModel = _SpContext.DocumentTrainingModel.FromSqlRaw("EXEC spFPAPP_Services_now_TrainingDocs @Opcion = @Opcion, @UserID = @UserID, @PlantID = @PlantID",
                    new object[]
                    {
                    new SqlParameter("Opcion", 1),  
                    new SqlParameter("UserID", userId),
                    new SqlParameter("PlantID", plantId),
                    }
                    ).AsNoTracking().ToList();
            }
            else
            {
                model.DocumentTrainingStep1 = new List<DocumentTrainingStep1>();
                model.DocumentTrainingStep1 = _SpContext.DocumentTrainingStep1.FromSqlRaw("EXEC spFPAPP_Services_now_TrainingDocs @Opcion = @Opcion, @UserID = @UserID, @PlantID = @PlantID, @DocumentID=@DocumentID",
                    new object[]
                    {
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UserID", userId),
                    new SqlParameter("PlantID", plantId),
                    new SqlParameter("DocumentID", idDocument),
                    }
                    ).AsNoTracking().ToList();
            }

            return model;
        }

        //======================================== Anp Control ===============================================================
        public TMAnpControlViewModel AnpControl(int userId, int plantId)
        {
            var model = new TMAnpControlViewModel();
            //Report Corrective actions
            model.ReportAnpControl = _SpContext.ReportAnpControl.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
           "@UsuarioID = @UsuarioID, @PlantaID= @PlantaID, " +
		   "@Operacion = @Operacion, @Opcion = @Opcion",
           new object[]
           {
            new SqlParameter("Operacion", 1),
			new SqlParameter("Opcion", 1),
			new SqlParameter("UsuarioID", userId),
            new SqlParameter("PlantaID", plantId)
           }).AsNoTracking().ToList();

            var Users = _SpContext.AnpListUsers.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
             "@UsuarioID = @UsuarioID, @PlantaID= @PlantaID, " +
		   "@Operacion = @Operacion, @Opcion = @Opcion",
             new object[]
             {
                    new SqlParameter("Operacion", 3),
					new SqlParameter("@Opcion", 1),
					new SqlParameter("UsuarioID", userId),
                    new SqlParameter("PlantaID", plantId),
             }).AsNoTracking().ToList();

            if (Users.Any())
            {
                Users.ForEach(item =>
                {
                    model.AnpListUsers.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

			var ReasingUsers = _SpContext.AnpListReasingUsers.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			 "@UsuarioID = @UsuarioID, @PlantaID= @PlantaID, " +
		   "@Operacion = @Operacion, @Opcion = @Opcion",
			 new object[]
			 {
					new SqlParameter("Operacion", 3),
					new SqlParameter("@Opcion", 2),
					new SqlParameter("UsuarioID", userId),
					new SqlParameter("PlantaID", plantId),
			 }).AsNoTracking().ToList();

			if (ReasingUsers.Any())
			{
				ReasingUsers.ForEach(item =>
				{
					model.AnpListReasingUsers.Add(new SelectListItem
					{
						Value = item.ID.ToString(),
						Text = item.Text.ToString()
					});
				});
			}

			var ListUnits = _SpContext.AnpListUnits.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			 "@UsuarioID = @UsuarioID, @PlantaID= @PlantaID, " +
		   "@Operacion = @Operacion, @Opcion = @Opcion",
			 new object[]
			 {
					new SqlParameter("Operacion", 3),
					new SqlParameter("@Opcion", 3),
					new SqlParameter("UsuarioID", userId),
					new SqlParameter("PlantaID", plantId),
			 }).AsNoTracking().ToList();

			if (ListUnits.Any())
			{
				ListUnits.ForEach(item =>
				{
					model.AnpListUnits.Add(new SelectListItem
					{
						Value = item.ID.ToString(),
						Text = item.Text.ToString()
					});
				});
			}

			return model;
        }

    }
}
