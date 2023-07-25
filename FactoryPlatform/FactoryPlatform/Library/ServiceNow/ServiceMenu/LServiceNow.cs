using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPlatform.Library
{
    public class LServiceNow : ListObjects
    {

        public LServiceNow(StoresProceduresDbContext spContext, LKQMXFPAPPContext fpContext)
        {
            _SpContext = spContext;
            _fpContext = fpContext;
        }

        //================================================================================================================================================
        //================================ Document Viewer  ==============================================================================================
        //================================================================================================================================================

        public DocViewerViewModel FirstCombosDocViewer(int UserID, int MenuID, int PlantaID)
        {
            var DocViewModel = new DocViewerViewModel();

            DocViewModel.Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, @PlantID =@PlantID , @Operacion = @Operacion, @Opcion = @Opcion",
                        new object[]
                        {
                            new SqlParameter("Operacion", 2),
                            new SqlParameter("Opcion", 1),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaID)
                        }).AsNoTracking().ToList();

            return DocViewModel;
        }

        public DocViewerViewModel SecondCombosDocViewer(int UserID, int PlantaID, int Departamento)
        {
            var DocViewModel = new DocViewerViewModel();

            if(Departamento > 0)
            {
                DocViewModel.ProductionStations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                    "@UserID = @UserID, @PlantID =@PlantID , @Operacion = @Operacion, @Opcion = @Opcion, @Departamento=@Departamento",
                 new object[]
                 {
                                new SqlParameter("Operacion", 2),
                                new SqlParameter("Departamento", Departamento),
                                new SqlParameter("Opcion", 3),
                                new SqlParameter("UserID", UserID),
                                new SqlParameter("PlantID", PlantaID)
                 }).AsNoTracking().ToList();
            }


            DocViewModel.ProductionDepartments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                "@UserID = @UserID, @PlantID =@PlantID , @Operacion=@Operacion, @Opcion = @Opcion",
                new object[]
                {
                            new SqlParameter("Operacion", 2),
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaID)
                }).AsNoTracking().ToList();

            DocViewModel.Quality_Docs_DocumentsTypes = _SpContext.Quality_Docs_DocumentsTypes.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                "@Opcion = @Opcion, @UserID = @UserID, @Operacion=@Operacion,@PlantID = @PlantID",
                new object[]
                {
                            new SqlParameter("Operacion", 2),
                            new SqlParameter("Opcion", 4),
                            new SqlParameter("UserID", UserID),
                            new SqlParameter("PlantID", PlantaID)
                }).AsNoTracking().ToList();

            return DocViewModel;
        }
        //====================================================================================================================================================================



        //================================================================================================================================================
        //==================================== Work Orders  ==============================================================================================
        //================================================================================================================================================
        public ServiceMenuViewModel FirstCombosWorkOrders(int UserID, int MenuID, int PlantaID)
        {
            var Model = new ServiceMenuViewModel();

            switch (MenuID)
            {
                case 7:
                    var EngModel = new EngWorkOrdersModel();

                    EngModel.Services_now_WorkOrders_Class = _SpContext.Services_now_WorkOrders_Class.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 1)
                    }).AsNoTracking().ToList();

                    EngModel.TypeWorkOrder = _SpContext.TypeWorkOrder.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 2)
                    }).AsNoTracking().ToList();

                    EngModel.Production_Stations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 3)
                    }).AsNoTracking().ToList();

                    Model.EngWorkOrdersModel = EngModel;

                    break;

                case 8:

                    var ItModel = new ItWorkOrdersModel();

                    ItModel.Services_now_WorkOrders_Class = _SpContext.Services_now_WorkOrders_Class.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                   new object[]
                   {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 1)
                   }).AsNoTracking().ToList();

                    ItModel.Production_Stations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 2)
                    }).AsNoTracking().ToList();

                    Model.ItWorkOrdersModel = ItModel;

                    break;

                case 9:
                    var MTCEModel = new MTCEWorkOrdersModel();

                    MTCEModel.Services_now_WorkOrders_Class = _SpContext.Services_now_WorkOrders_Class.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                   new object[]
                   {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 1)
                   }).AsNoTracking().ToList();

                    MTCEModel.Production_Stations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 2)
                    }).AsNoTracking().ToList();

                    Model.MTCEWorkOrdersModel = MTCEModel;

                    break;

                case 10:

                    var QltyModel = new QltyWorkOrdersModel();

                    QltyModel.Services_now_WorkOrders_Class = _SpContext.Services_now_WorkOrders_Class.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                   new object[]
                   {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 1)
                   }).AsNoTracking().ToList();

                    QltyModel.Production_Stations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 2)
                    }).AsNoTracking().ToList();

                    Model.QltyWorkOrdersModel = QltyModel;

                    break;

                case 13:

                    var HrModel = new HRWorkOrdersModel();

                    HrModel.Services_now_WorkOrders_Class = _SpContext.Services_now_WorkOrders_Class.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                   new object[]
                   {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 1)
                   }).AsNoTracking().ToList();

                    HrModel.Production_Stations = _SpContext.Production_Stations.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuID),
                     new SqlParameter("PlantaID", PlantaID),
                     new SqlParameter("CaseID", 2)
                    }).AsNoTracking().ToList();

                    Model.HRWorkOrdersModel = HrModel;

                    break;
            }

            return Model;
        }


        public ServiceMenuViewModel SecondCombosWorkOrders(int Station, int UserID, int MenuId, int PlantaId)
        {
            var Model = new ServiceMenuViewModel();

            switch (MenuId)
            {
                case 7:
                    var EngModel = new EngWorkOrdersModel();

                    EngModel.Production_Departments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 4),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    EngModel.Services_Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", EngModel.Production_Departments.First().PlantaID),
                     new SqlParameter("CaseID", 5),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    Model.EngWorkOrdersModel = EngModel;
                    break;

                case 8:
                    var ItModel = new ItWorkOrdersModel();

                    ItModel.Production_Departments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 3),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    ItModel.Services_Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID",   ItModel.Production_Departments.First().PlantaID),
                     new SqlParameter("CaseID", 4),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    ItModel.ITSystems_HardwareReferences = _SpContext.ITSystems_HardwareReferences.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 5),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    Model.ItWorkOrdersModel = ItModel;
                    break;

                case 9:
                    var MTCEModel = new MTCEWorkOrdersModel();

                    MTCEModel.Production_Departments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 3),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    MTCEModel.Services_Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID",  MTCEModel.Production_Departments.First().PlantaID),
                     new SqlParameter("CaseID", 4),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    MTCEModel.Maintenance_EquipmentMachinery = _SpContext.Maintenance_EquipmentMachinery.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 5),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    Model.MTCEWorkOrdersModel = MTCEModel;
                    break;

                case 10:
                    var QltyModel = new QltyWorkOrdersModel();

                    QltyModel.Production_Departments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 3),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    QltyModel.Services_Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID",   QltyModel.Production_Departments.First().PlantaID),
                     new SqlParameter("CaseID", 4),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    Model.QltyWorkOrdersModel = QltyModel;

                    break;

                case 13:
                    var HRModel = new HRWorkOrdersModel();

                    HRModel.Production_Departments = _SpContext.Production_Departments.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID, @EstacionID=@EstacionID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID", PlantaId),
                     new SqlParameter("CaseID", 3),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    HRModel.Services_Factories = _SpContext.Services_Factories.FromSqlRaw("EXEC spFPAPP_SoftwareConfig_WorkOrders @MenuID=@MenuID, @PlantaID=@PlantaID, @CaseID=@CaseID",
                    new object[]
                    {
                     new SqlParameter("MenuID", MenuId),
                     new SqlParameter("PlantaID",   HRModel.Production_Departments.First().PlantaID),
                     new SqlParameter("CaseID", 4),
                     new SqlParameter("EstacionID", Station)
                    }).AsNoTracking().ToList();

                    Model.HRWorkOrdersModel = HRModel;
                    break;
            }

            return Model;
        }

        public bool InsertWorkOrder(int classId, int typeId, int workStationId, int departamentId, int plantId, int hardwareId, int machineId, string commentStr, int menuId, int userId)
        {
            bool result = false;
            var insertCorrect = new List<Services_now_WorkOrders>();
            switch (menuId)
            {
                case 7:
                    insertCorrect = _SpContext.Services_now_WorkOrders.FromSqlRaw("EXEC spFPAPP_Services_now_WorkOrdersEng @Opcion=@Opcion, @Comentarios=@Comentarios, @UserID=@UserID, @ClassID=@ClassID,@WorkStationID=@WorkStationID, @PlantID=@PlantID, @TypeID =@TypeID",
                     new object[]
                     {
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("Comentarios", commentStr),
                            new SqlParameter("UserID", userId),
                            new SqlParameter("ClassID", classId),
                            new SqlParameter("WorkStationID", workStationId),
                            new SqlParameter("PlantID", plantId),
                            new SqlParameter("TypeID", typeId),
                     }).AsNoTracking().ToList();

                    if (insertCorrect.Count > 0)
                    {
                        result = true;
                    }
                    break;
                case 8:
                    insertCorrect = _SpContext.Services_now_WorkOrders.FromSqlRaw("EXEC spFPAPP_Services_now_WorkOrdersIT @Opcion=@Opcion, @Comentarios=@Comentarios, @UserID=@UserID, @ClassID=@ClassID,@WorkStationID=@WorkStationID, @PlantID=@PlantID, @HardwareID=@HardwareID",
                    new object[]
                    {
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("Comentarios", commentStr),
                            new SqlParameter("UserID", userId),
                            new SqlParameter("ClassID", classId),
                            new SqlParameter("WorkStationID", workStationId),
                            new SqlParameter("PlantID", plantId),
                            new SqlParameter("HardwareID", hardwareId),
                    }).AsNoTracking().ToList();

                    if (insertCorrect.Count > 0)
                    {
                        result = true;
                    }
                    break;
                case 9:
                    insertCorrect = _SpContext.Services_now_WorkOrders.FromSqlRaw("EXEC spFPAPP_Services_now_WorkOrdersMTCE @Opcion=@Opcion, @Comentarios=@Comentarios, @UserID=@UserID, @ClassID=@ClassID,@WorkStationID=@WorkStationID, @PlantID=@PlantID, @MachineID=@MachineID",
                    new object[]
                    {
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("Comentarios", commentStr),
                            new SqlParameter("UserID", userId),
                            new SqlParameter("ClassID", classId),
                            new SqlParameter("WorkStationID", workStationId),
                            new SqlParameter("PlantID", plantId),
                            new SqlParameter("MachineID", machineId),
                    }).AsNoTracking().ToList();

                    if (insertCorrect.Count > 0)
                    {
                        result = true;
                    }
                    break;
                case 10:
                    insertCorrect = _SpContext.Services_now_WorkOrders.FromSqlRaw("EXEC spFPAPP_Services_now_WorkOrdersEng @Opcion=@Opcion, @Comentarios=@Comentarios, @UserID=@UserID, @ClassID=@ClassID,@WorkStationID=@WorkStationID, @PlantID=@PlantID",
                     new object[]
                     {
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("Comentarios", commentStr),
                            new SqlParameter("UserID", userId),
                            new SqlParameter("ClassID", classId),
                            new SqlParameter("WorkStationID", workStationId),
                            new SqlParameter("PlantID", plantId),

                     }).AsNoTracking().ToList();

                    if (insertCorrect.Count > 0)
                    {
                        result = true;
                    }
                    break;
                case 13:
                    insertCorrect = _SpContext.Services_now_WorkOrders.FromSqlRaw("EXEC spFPAPP_Services_now_WorkOrdersHR @Opcion=@Opcion, @Comentarios=@Comentarios, @UserID=@UserID, @ClassID=@ClassID,@WorkStationID=@WorkStationID, @PlantID=@PlantID",
                      new object[]
                      {
                            new SqlParameter("Opcion", 2),
                            new SqlParameter("Comentarios", commentStr),
                            new SqlParameter("UserID", userId),
                            new SqlParameter("ClassID", classId),
                            new SqlParameter("WorkStationID", workStationId),
                            new SqlParameter("PlantID", plantId)
                      }).AsNoTracking().ToList();

                    if (insertCorrect.Count > 0)
                    {
                        result = true;
                    }
                    break;
                case 25:
                    break;
            }

            return (result);
        }

        //====================================================================================================================================================================



        //================================================================================================================================================
        //======================================= New Item  ==============================================================================================
        //================================================================================================================================================
        public List<SelectListItem> NewItemCombos(int UserID, int MenuID, int PlantaID)
        {
            List<SelectListItem> Purchaser = new List<SelectListItem>();

            var user = _fpContext.Users.Where(U => U.Status.Equals(true) && U.PlantaId == 1 && (U.PuestoId == 48 || U.PuestoId == 49 || U.PuestoId == 84 || U.PuestoId == 85 || U.PuestoId == 4 || U.PuestoId == 182)).Select(
                        U => new
                        {
                            U.IdUsuario,
                            Comprador = $"{U.NoEmpleado} - {U.Nombres} {U.ApellidoPaterno} {U.ApellidoMaterno}"
                        }
                     ).AsNoTracking().ToList();

            if (user.Count > 0)
            {
                user.ForEach(item =>
                {
                    Purchaser.Add(new SelectListItem
                    {
                        Value = item.IdUsuario.ToString(),
                        Text = item.Comprador.ToString()
                    });
                });
            }
            return Purchaser;
        }

        public async Task<bool> InsertNewItem(string NICode, string NIDescription, string NIMiddleCode, int PurchaserNI, int UserID, int PlantaID)
        {
            bool Result = false;

            var insert = _fpContext.Database.CreateExecutionStrategy();
            await insert.ExecuteAsync(async () =>
            {
                using (var transaction = _fpContext.Database.BeginTransaction())
                {
                    try
                    {
                        var data = new ProductionMissingItemsCodes
                        {
                            Codigo = NICode,
                            Descripcion = NIDescription,
                            CodigoMedio = NIMiddleCode,
                            CompradorId = PurchaserNI,
                            UsuarioRegistroId = UserID,
                            PlantaId = PlantaID,
                        };
                        await _fpContext.AddAsync(data);
                        _fpContext.SaveChanges();

                        Result = true;

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            });
            return Result;
        }
        //======================================================================================================================================================


        //================================================================================================================================================
        //============================================ Corrective action ==========================================================================================
        //================================================================================================================================================

        public CorrectiveActionViewModel CombosCorrectiveAction(int UserID, int PlantaID)
        {
            var model = new CorrectiveActionViewModel();

            var Tools = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 1),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Tools.Any())
            {
                Tools.ForEach(item =>
                {
                    model.Quality_CA_Tools.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var Sources = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 2),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
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
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
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

            var Responsible = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 4),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
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

            var Activity = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 5),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
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
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
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

            var Quality_Processes = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 7),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
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

            return model;
        }
        //======================================================================================================================================================


    }
}
