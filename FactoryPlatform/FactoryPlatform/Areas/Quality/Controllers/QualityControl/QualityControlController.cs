using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Http.Features;
using FactoryPlatform.Models;

namespace FactoryPlatform.Areas.Quality.Controllers
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    [ServiceFilter(typeof(AuthorizeMethodFilter), Order = 2)]
    public class QualityControlController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private readonly LUsers _lUsers;
        private readonly LHistorySetionsPagesUsers _lHistoryPages;

        public static int valida_planta = 0;
        public static string valida_modelo = string.Empty;
        public static int valida_registro = 0;

        public static ModelFeaturesViewModel _ModelFeacture = new ModelFeaturesViewModel() { 
            QualityModelFeatures = new List<QualityModelFeatures>() 
        };
        
        public static BeforeProofViewModel _BeforeProof = new BeforeProofViewModel(){ 
            QualityModelFeatures = new List<QualityModelFeatures>(), 
            DesviationTags = new List<spFPAPP_QualityControl_ModelFeatures_DesviationTags>()
        };

        public QualityControlController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lUsers = new LUsers(appContext);
            _lHistoryPages = new LHistorySetionsPagesUsers(fpContext, spContext);

        }

        //Maping Rute 
        public List<string> MapRute(int PlantaId, string Modelo, int IdRegistro)
        {
            var error = "";
            List<string> files = new List<string>();
            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
            var user = "";
            var passworda = "";

            var query = _spContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
               new object[]
               {
                    new SqlParameter("UserID", idUsuario)
               }).AsNoTracking().ToList();

            if (query.Count > 0)
            {
                var model = query.First();

                user = model.Usuario;
                passworda = model.Password;
            }

            int validated_planta_host = valida_planta;
            string validated_modelo_host = valida_modelo;
            int validated_registro_host = valida_registro;


            if (PlantaId.Equals(validated_planta_host) && Modelo.Equals(validated_modelo_host) && IdRegistro.Equals(validated_registro_host))
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{validated_planta_host}/model-features/{validated_modelo_host}/{validated_registro_host}/large";

                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                

                    try
                    {
                        request.Credentials = new NetworkCredential(user, passworda);
                        request.Method = WebRequestMethods.Ftp.ListDirectory;
                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);

                        var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                        if (ftpFiles.Count > 0)
                        {
                            files = ftpFiles;
                        }

                        response.Close();
                        responseStream.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                    }

                return files;
            }
            else
            {
                return null;
            }
        }


        //==========================Model Factures=================================================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModelFeatures(int SeccionId, string Station, string Modelo, string Serie, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var model = new ModelFeaturesViewModel();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new ModelFeaturesViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            if (Modelo != null && Serie != null)
            {
                model.Modelo = Modelo;
                model.Serie = Serie;
            }

            _ModelFeacture = model;

            return Redirect("/FactoryPlatform/QualityControl/ModelFeatures");
        }

        public IActionResult ModelFeatures()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new ModelFeaturesViewModel();
            model = _ModelFeacture;
            _ModelFeacture = new ModelFeaturesViewModel();
            model.QualityModelFeatures = new List<QualityModelFeatures>();

            var UserId = _lUsers.getIdUser(User).First().Id_Usuario;

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                if (model.Modelo != null && model.Serie != null)
                {
                    var features = _fpContext.QualityModelFeatures.Where(MF => MF.Modelo == model.Modelo && MF.Estacion == model.Station).Select(MF => new QualityModelFeatures
                    {
                        IdRegistro = MF.IdRegistro,
                        Modelo = MF.Modelo,
                        Titulo = MF.Titulo,
                        PlantaId = MF.PlantaId,
                        Descripcion = MF.Descripcion
                    }).AsNoTracking().ToList();

                    if (features.Count > 0)
                    {
                        model.QualityModelFeatures = features;

                        var filesInf = new List<FilesModelFeactures>();
                        foreach (var item in features)
                        {
                            valida_planta = item.PlantaId;
                            valida_modelo = item.Modelo;
                            valida_registro = item.IdRegistro;

                            var files = MapRute(item.PlantaId, item.Modelo, item.IdRegistro);
                            foreach (var name in files)
                            {
                                filesInf.Add(new FilesModelFeactures
                                {
                                    RegistroId = item.IdRegistro,
                                    FileName = name
                                });
                            }
                        }

                        model.FilesModelFeactures = filesInf;
                    }

                    model.Serie = model.Serie;
                    model.Modelo = model.Modelo;
                }

                return View(model);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation",
                new object[]
                {
                    new SqlParameter("UserID", UserId),
                    new SqlParameter("Operation", 6)
                }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        ViewData["Titulo"] = select.First().PageTitle;
                        model.Station = select.First().PageID;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

                        return View(model);
                    }
                    else
                    {
                        return Redirect("/FactoryPlatform");
                    }
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }

        //===========================================================================================================================================


        //=============================Antes de prueba ==============================================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BeforeProof(int SeccionId, string Modelo, string Serie, string Station, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var model = new BeforeProofViewModel();
            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new BeforeProofViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            if (Modelo != null && Serie != null)
            {
                model.Modelo = Modelo;
                model.Serie = Serie;
            }

            _BeforeProof = model;

            return Redirect("/FactoryPlatform/QualityControl/BeforeProof");
        }

        public IActionResult BeforeProof()
        {
            var UserID = _lUsers.getIdUser(User).First().Id_Usuario;
            var action = (HttpContext.Request.RouteValues.Values).Last();
            var model = new BeforeProofViewModel();
            model = _BeforeProof;
            _BeforeProof = new BeforeProofViewModel();
            model.QualityModelFeatures = new List<QualityModelFeatures>();
            model.DesviationTags = new List<spFPAPP_QualityControl_ModelFeatures_DesviationTags>();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;
                model.Station = model.Station;

                if (model.Modelo != null && model.Serie != null)
                {
                    var features = _fpContext.QualityModelFeatures.Where(MF => MF.Modelo == model.Modelo && MF.Estacion == model.Station).Select(MF => new QualityModelFeatures
                    {
                        IdRegistro = MF.IdRegistro,
                        Modelo = MF.Modelo,
                        Titulo = MF.Titulo,
                        PlantaId = MF.PlantaId,
                        Descripcion = MF.Descripcion
                    }).AsNoTracking().ToList();

                    if (features.Count > 0)
                    {
                        model.QualityModelFeatures = features;

                        var filesInf = new List<FilesModelFeactures>();
                        foreach (var item in features)
                        {
                            valida_planta = item.PlantaId;
                            valida_modelo = item.Modelo;
                            valida_registro = item.IdRegistro;

                            var files = MapRute(item.PlantaId, item.Modelo, item.IdRegistro);
                            foreach (var name in files)
                            {
                                filesInf.Add(new FilesModelFeactures
                                {
                                    RegistroId = item.IdRegistro,
                                    FileName = name
                                });
                            }
                        }

                        model.FilesModelFeactures = filesInf;
                    }

                    var query = _spContext.spFPAPP_QualityControl_ModelFeatures_DesviationTags.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID",
                    new object[]
                    {
                    new SqlParameter("Serie", model.Serie),
                    new SqlParameter("Modelo", model.Modelo),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("ProcesoID", 6)
                    }).AsNoTracking().ToList();

                    if (query.Count > 0)
                    {
                        model.DesviationTags = query;
                    }
                    model.Serie = model.Serie;
                    model.Modelo = model.Modelo;
                }

                return View(model);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
              "@UserID=@UserID, @Operation=@Operation",
              new object[]
              {
                    new SqlParameter("UserID", UserID),
                    new SqlParameter("Operation", 6)
              }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        ViewData["Titulo"] = select.First().PageTitle;
                        model.Station = select.First().PageID;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

                        return View(model);
                    }
                    else
                    {
                        return Redirect("/FactoryPlatform");
                    }
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }

        //===========================================================================================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidateModelTags(int desviacionID, string serie, string modelo, int opcion, string IdSeccion)
        {
            var UsuarioID = _lUsers.getIdUser(User).ToList().First().Id_Usuario;

            var query = _spContext.spFPAPP_QualityControl_ModelFeatures_ValidateModelTags.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @UsuarioID=@UsuarioID, @DesviationID = @DesviationID, @OpcionID =@OpcionID, @ProcesoID=@ProcesoID",
               new object[]
               {
                    new SqlParameter("Serie", serie),
                    new SqlParameter("Modelo", modelo),
                    new SqlParameter("UsuarioID", UsuarioID),
                    new SqlParameter("DesviationID", desviacionID),
                    new SqlParameter("OpcionID", opcion),
                    new SqlParameter("ProcesoID", 7),
               }).AsNoTracking().ToList();

            if (query.Count > 0)
            {
                return Ok(query.First().Result);
            }
            else
            {
                return Ok("Error");
            }
        }

        //===========================================================================================================================================        


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetModeloInf(string serie, string modelo, string IdSeccion)
        {
            string jsonListaDatos = "";
            var UserID = _lUsers.getIdUser(User).First().Id_Usuario;
            var query = _spContext.spFPAPP_QualityControl_ModelFeatures_ModelStatus.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures " +
                "@Serie=@Serie, @Modelo=@Modelo, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID",
                new object[]
                {
                    new SqlParameter("Serie", serie),
                    new SqlParameter("Modelo", modelo),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("ProcesoID", 4)
                }).AsNoTracking().ToList();

            if (query.Count > 0)
            {
                jsonListaDatos = JsonConvert.SerializeObject(query.First());
                return Ok(jsonListaDatos);
            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ComponentsRecovery(string serie, string modelo, string IdSeccion)
        {
            string jsonListaDatos = "";
            var UserID = _lUsers.getIdUser(User).First().Id_Usuario;
            var query = _spContext.spFPAPP_QualityControl_ModelFeatures_RecoveryComponets.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID",
                new object[]
                {
                    new SqlParameter("Serie", serie),
                    new SqlParameter("Modelo", modelo),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("ProcesoID", 5)
                }).AsNoTracking().ToList();

            //return Ok(query);

            if (query.Count > 0)
            {
                jsonListaDatos = JsonConvert.SerializeObject(query);
                return Ok(jsonListaDatos);
            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ComponentModelsInsert(string serie, int registro, string IdSeccion)
        {
            if (serie != null && registro > 0)
            {
                var UserID = _lUsers.getIdUser(User).First().Id_Usuario;

                var error = "";
                var strategy = _fpContext.Database.CreateExecutionStrategy();
                await strategy.ExecuteAsync(async () =>
                {
                    using (var transaction = _fpContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var model = new QualityComponentsRecoveryByProduct()
                            {
                                Serie = serie,
                                RegistroComponenteId = registro,
                                UsuarioRegistroId = UserID,
                            };
                            await _fpContext.AddAsync(model);
                            _fpContext.SaveChanges();

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            error = "Error";
                            transaction.Rollback();
                        }
                    }
                });

                if (error != "")
                {
                    return Ok("Error");
                }
                else
                {
                    return Ok("Correcto");
                }

            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveInputEspecial(string Modelo, string Serie, int NumeroPrueba, string IdSeccion)
        {
            var UserID = _lUsers.getIdUser(User).First().Id_Usuario;
            string error = null;

            if (NumeroPrueba > 0) //Int alway be 0 if u send a value more length that the Quantity specific ist's save in the variable NumeroPrueba
            {
                var valida = _fpContext.QualityEspecialTest.Where(U => U.IdRegistro == NumeroPrueba).ToList();

                if (valida.Count > 0)
                {
                    var strategy = _fpContext.Database.CreateExecutionStrategy();
                    await strategy.ExecuteAsync(async () =>
                    {
                        using (var transaction = _fpContext.Database.BeginTransaction())
                        {
                            try
                            {
                                var model = new QualityEspecialTestSeries()
                                {
                                    Modelo = Modelo,
                                    Serie = Serie,
                                    UsuarioRegistroId = UserID,
                                    PruebaId = NumeroPrueba
                                };
                                await _fpContext.AddAsync(model);
                                _fpContext.SaveChanges();

                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                error = "Error";
                                transaction.Rollback();
                            }
                        }
                    });
                }
                else
                {
                    if (NumeroPrueba <= 10256)
                    {
                        var strategy = _fpContext.Database.CreateExecutionStrategy();
                        await strategy.ExecuteAsync(async () =>
                        {
                            using (var transaction = _fpContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    var model = new QualityEspecialTestSeries()
                                    {
                                        Modelo = Modelo,
                                        Serie = Serie,
                                        UsuarioRegistroId = UserID,
                                        PruebaId = NumeroPrueba
                                    };
                                    await _fpContext.AddAsync(model);
                                    _fpContext.SaveChanges();

                                    transaction.Commit();
                                }
                                catch (Exception ex)
                                {
                                    error = "Error";
                                    transaction.Rollback();
                                }
                            }
                        });
                    }
                    else
                    {
                        return Ok("Novalida");
                    }
                }
                if (error != null)
                {
                    return Ok("Error");
                }
                else
                {
                    return Ok("Correcto");
                }

            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Assembled(int Opcion, string Serie, string Modelo, int Station, int Registro, string IdSeccion)
        {
            var UserID = _lUsers.getIdUser(User).First().Id_Usuario;

            if (Opcion == 1)
            {
                var query = _spContext.spFPAPP_QualityControl_ModelFeatures_Assembled.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @EstacionID=@EstacionID, @OpcionID=@OpcionID, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID",
                    new object[]
                    {
                        new SqlParameter("Serie", Serie),
                        new SqlParameter("Modelo", Modelo),
                        new SqlParameter("EstacionID", Station),
                        new SqlParameter("OpcionID", Opcion),
                        new SqlParameter("UsuarioID", UserID),
                        new SqlParameter("ProcesoID", 1)
                    }).AsNoTracking().ToList();

                if (query.Count > 0)
                {
                    if (query.First().Respuesta != null)
                    {
                        return Ok(query.First().Respuesta);
                    }
                    else
                    {
                        var datosModelEnsam = new spFPAPP_QualityControl_ModelFeatures_Assembled()
                        {
                            ID_Registro = query.First().ID_Registro,
                            ID_Request = query.First().ID_Request,
                            Codigo = query.First().Codigo,
                            DCodigo = query.First().DCodigo
                        };
                        var jsonDatosModelEnsam = JsonConvert.SerializeObject(datosModelEnsam);
                        return Ok(jsonDatosModelEnsam);
                    }
                }
            }
            else if (Opcion == 3)
            {
                var query = _spContext.spFPAPP_QualityControl_ModelFeatures_Assembled.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @EstacionID=@EstacionID, @RegistroID = @RegistroID, @OpcionID=@OpcionID, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID",
                   new object[]
                   {
                    new SqlParameter("Serie", Serie),
                    new SqlParameter("Modelo", Modelo),
                    new SqlParameter("EstacionID", Station),
                    new SqlParameter("RegistroID", Registro),
                    new SqlParameter("OpcionID", Opcion),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("ProcesoID", 1)
                   }).AsNoTracking().ToList();
                if (query.Count > 0)
                {
                    if (query.First().Respuesta != null)
                    {
                        return Ok(query.First().Respuesta);
                    }
                }
            }

            return Ok("Error");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveFeature(int opcion, int featureId, string serie, string modelo, int estacion, string IdSeccion)
        {
            var UserList = _lUsers.getIdUser(User).ToList();
            int Err = 0;

            var query = _spContext.spFPAPP_QualityControl_ModelFeatures_SaveFeature.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @FeatureID=@FeatureID, @EstacionID=@EstacionID, @Resultado=@Resultado, @UsuarioID=@UsuarioID, @PlantaID =@PlantaID, @ProcesoID=@ProcesoID",
               new object[]
               {
                    new SqlParameter("Serie", serie),
                    new SqlParameter("Modelo", modelo),
                    new SqlParameter("FeatureID", featureId),
                    new SqlParameter("EstacionID", estacion),
                    new SqlParameter("Resultado", opcion),
                    new SqlParameter("UsuarioID", UserList.First().Id_Usuario),
                    new SqlParameter("PlantaID ", UserList.First().PlantaId),
                    new SqlParameter("ProcesoID", 2),
               }).AsNoTracking().ToList();

            if (query.Count > 0)
            {
                return Ok("correcto");
            }

            return Ok("");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidateMissingAssamble(string serie, string modelo, int estacion, string IdSeccion)
        {
            var UsuarioID = _lUsers.getIdUser(User).ToList().First().Id_Usuario;
            string jsonDatos = "";
            int Err = 0;

            var query = _spContext.spFPAPP_QualityControl_ModelFeatures_ValidationMissingAssamble.FromSqlRaw("EXEC spFPAPP_QualityControl_ModelFeatures @Serie=@Serie, @Modelo=@Modelo, @EstacionID=@EstacionID, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID",
               new object[]
               {
                    new SqlParameter("Serie", serie),
                    new SqlParameter("Modelo", modelo),
                    new SqlParameter("EstacionID", estacion),
                    new SqlParameter("UsuarioID", UsuarioID),
                    new SqlParameter("ProcesoID", 3),
               }).AsNoTracking().ToList();

            if (query.Count > 0)
            {
                var jsonQuary = new spFPAPP_QualityControl_ModelFeatures_ValidationMissingAssamble();
                jsonQuary = query.First();

                jsonDatos = JsonConvert.SerializeObject(jsonQuary);
                return Ok(jsonDatos);
            }
            return Ok("");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveComment(string modelo, string motor, string comentario, byte Station, string IdSeccion)
        {
            var UserID = _lUsers.getIdUser(User).First().Id_Usuario;
            int Err = 0;

            if (modelo != null && Station > 0 && motor != null && comentario != null)
            {
                var strategy = _fpContext.Database.CreateExecutionStrategy();
                await strategy.ExecuteAsync(async () =>
                {
                    using (var transaction = _fpContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var model = new QualityModelFeaturesComments()
                            {
                                Modelo = modelo,
                                Serie = motor,
                                Estacion = Station,
                                Comentario = comentario,
                                FechaRegistro = DateTime.Now,
                                UsuarioId = UserID,
                                PlantaId = 1
                            };
                            await _fpContext.AddAsync(model);
                            _fpContext.SaveChanges();

                            transaction.Commit();
                            Err = 1;

                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }
                });

                if (Err == 1)
                {
                    return Ok("correcto");
                }
            }
            return Ok("");
        }


    }
}
