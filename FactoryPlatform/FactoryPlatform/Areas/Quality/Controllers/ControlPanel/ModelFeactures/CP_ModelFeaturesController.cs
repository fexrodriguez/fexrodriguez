using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using Microsoft.AspNetCore.Http;
using Syncfusion.EJ2.FileManager.Base;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using FactoryPlatform.Models;
using Syncfusion.EJ2.Spreadsheet;
using FactoryPlatform.Areas.Quality.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using Syncfusion.EJ2.Linq;
using Microsoft.Win32;
using System.Security.Policy;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel.ModelFeactures
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class CP_ModelFeaturesController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LModels _lModels;
        public static int valida_planta = 0;
        public static string valida_modelo = string.Empty;
        public static int valida_registro = 0;
        public static string valida_name = string.Empty;
        public static string valida_path = string.Empty;

        public CP_ModelFeaturesController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
            _lUsers = new LUsers(appContext);
            _lModels = new LModels(spContext);
        }

        //==============================================================================
        //Maping the directoryes for pictures 
        public List<string> MapRute(int PlantaId, string Modelo, int IdRegistro)
        {
            var error = "";
            List<string> files = new List<string>();
            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
            var user = "";
            var passworda = "";

            var query = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
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

                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);

                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);

                if (result == true)
                {
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
            else
            {
                return null;
            }
        }

        //======================== Order Features =========================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult FeaturesOrder(string orderData, string orderDataModel, int orderDataStation)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {

                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion= @Opcion, @Caracteristicas=@Caracteristicas ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 5),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Caracteristicas", orderData),
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = JsonConvert.SerializeObject(query);
                }
                else
                {
                    Json = "NoData";
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }

        //========================Save a new Feature =========================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveNewFeature(IFormFile file, string Modelo, int EstacionID,
        string Titulo, string Descripcion, string IdSeccion)
        {
            var query = new List<ExecuteStores>();
            List<string> files = new List<string>();
            var UserInf = _lUsers.getIdUser(User).ToList();
            string error = "";
            var user = "";
            var passworda = "";

            var store = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", UserInf.First().Id_Usuario)
            }).AsNoTracking().ToList();

            if (store.Count > 0)
            {
                var model = store.First();
                user = model.Usuario;
                passworda = model.Password;
            }

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
                "@UsuarioID=@UsuarioID, @PlantaID = @PlantaID, @Operacion = @Operacion, @Opcion=@Opcion, " +
                "@EstacionID=@EstacionID, @Modelo = @Modelo, " +
                "@Titulo=@Titulo, @Descripcion = @Descripcion ",
                new object[]
                {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
                    new SqlParameter("PlantaID", UserInf.First().PlantaId),
                    new SqlParameter("Modelo", Modelo),
                    new SqlParameter("EstacionID", EstacionID),
                    new SqlParameter("Titulo", Titulo),
                    new SqlParameter("Descripcion", Descripcion)
                }).AsNoTracking().ToList();
            }
            catch (Exception Ex)
            {
                error = Ex.Message;
            }

            if (error == "")
            {
                if (query.First().ID > 0)
                {
                    var IdRegistro = query.First().ID;

                    valida_planta = UserInf.First().PlantaId;
                    valida_modelo = Modelo;
                    valida_registro = (int)IdRegistro;

                    valida_path = $"";
                    valida_name = Modelo;
                    await CreateFolder($"", Modelo);
                    Response.Clear();
                    error = null;
                    valida_path = $"/{Modelo}/";
                    valida_name = $"{IdRegistro}";
                    await CreateFolder($"//{Modelo}/", $"{IdRegistro}");
                    Response.Clear();
                    error = null;
                    valida_path = $"/{Modelo}/{IdRegistro}/";
                    valida_name = "large";
                    await CreateFolder($"/{Modelo}/{IdRegistro}/", "large");

                    if (error != "" && error != null)
                    {
                        if (error == "ExistsFolder")
                        {
                            Response.Clear();
                            error = null;
                            await Upload(IdRegistro);

                            if (error != "" && error != null)
                            {
                                error = null;
                                Response.Clear();
                                return Ok("Error");
                            }
                            else
                            {

                                return Ok("success");
                            }
                        }
                        else
                        {
                            return Ok("Error");
                        }
                    }
                    else
                    {
                        await Upload(IdRegistro);
                        if (error != "" && error != null)
                        {
                            error = null;
                            Response.Clear();
                            return Ok("Error");
                        }
                        else
                        {
                            Response.Clear();

                            return Ok("Success");
                        }
                    }
                }
                else
                {
                    return Ok("Exist");
                }
            }
            else
            {
                return Ok("Error");
            }

            async Task CreateFolder(string path, string name)
            {
                string validated_name_host = valida_name;
                string validated_path_host = valida_path;
                if (path.Equals(validated_path_host) && name.Equals(validated_name_host))
                {
                    string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/model-features/{validated_name_host}{validated_name_host}";

                FileManagerResponse createResponse = new FileManagerResponse();
                
                try
                {
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);

                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);

                    if (result == true)
                    {
                        
                        try
                        {
                            request.Credentials = new NetworkCredential(user, passworda);
                            request.Method = WebRequestMethods.Ftp.MakeDirectory;
                            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                            response.Close();
                        }
                        catch (WebException e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            FtpWebResponse response = (FtpWebResponse)e.Response;
                            if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable && response.StatusDescription.Contains("exists"))
                            {

                            }
                            else
                            {
                                er.Code = "417";
                                er.Message = response.StatusDescription;
                            }
                            response.Close();
                            }
                    }
                        
                    
                    FileManagerDirectoryContent createData = new FileManagerDirectoryContent();
                    createData.Name = name;
                    createData.IsFile = false;
                    createData.Size = 0;
                    createData.DateModified = DateTime.Now;
                    createData.DateCreated = createData.DateModified;
                    createData.HasChild = false;
                    createData.Type = "";
                    FileManagerDirectoryContent[] newData = new FileManagerDirectoryContent[] { createData };
                }
                catch (Exception e)
                {
                    error = e.Message.ToString();
                }
                }
            }

            async Task Upload(int? IdRegistro)
            {
                try
                {
                    string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/model-features/{Modelo}/{IdRegistro}/large/";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    
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
                            error = ex.Message.ToString();
                    }
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message.ToString();
                }

                var CountFiles = files.Count + 1;
                string name = $"{Modelo}-{CountFiles}.jpg";

                var OrderFile = new QualityModelFeaturesFilesOrder
                {
                    CaracteristicaId = IdRegistro.Value,
                    NombreArchivo = name,
                    FechaRegistro = DateTime.Now,
                    UsuarioRegistroId = UserInf.First().Id_Usuario,
                    Orden = CountFiles
                };
                await _fpContext.AddAsync(OrderFile);
                _fpContext.SaveChanges();

                try
                {
                    string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/model-features/{Modelo}/{IdRegistro}/large/{name}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        request.Credentials = new NetworkCredential(user, passworda);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        try
                        {
                            using (Stream stream = request.GetRequestStream())
                            {
                                file.CopyTo(stream);
                            }
                        }
                        catch (Exception e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            error = e.Message.ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    error = e.Message.ToString();
                }
            }
        }

        //==========================Order Pictures by Features=====================================

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult FeaturesPictureOrder(int CaracteristicaID, string Pictures)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {

                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion= @Opcion, @CaracteristicaID=@CaracteristicaID, @Pictures=@Pictures ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 6),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("@CaracteristicaID", CaracteristicaID),
                    new SqlParameter("@Pictures", Pictures),

               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = JsonConvert.SerializeObject(query);
                }
                else
                {
                    Json = "NoData";
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


        //========================Information  of the feature to open the modal update=========================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult ShowUpdateFeature(string FeatureID, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<CP_Q_ModelFeature>();

            try
            {

                query = _SpContext.CP_Q_ModelFeature.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion= @Opcion, @FeatureID=@FeatureID ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("FeatureID", FeatureID),
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = JsonConvert.SerializeObject(query);
                }
                else
                {
                    Json = "NoData";
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }

        //========================Update feature Data =========================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult UpdateFeature(string FeatureID, int EstacionID, string Titulo, string Descripcion, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion= @Opcion, @FeatureID=@FeatureID, @EstacionID= @EstacionID, " +
               "@Descripcion=@Descripcion, @Titulo=@Titulo ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 3),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("EstacionID", EstacionID),
                    new SqlParameter("Titulo", Titulo),
                    new SqlParameter("Descripcion", Descripcion),
                    new SqlParameter("FeatureID", FeatureID)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Result = query.First().Resultado;
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);
        }

        //========================Upload pictures =========================================
        public class ReturnUpload //Retornar resultado Json 
        {
            public string FileName { get; set; }
            public int IdRegistro { get; set; }
            public string Modelo { get; set; }
            public int PlantaId { get; set; }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadPictures(IFormFile file, string Modelo, int IdRegistro, string IdSeccion)
        {
            List<string> files = new List<string>();
            var Json = new List<ReturnUpload>();

            var UserInf = _lUsers.getIdUser(User).ToList();
            string error = "";
            string Result = "";
            var user = "";
            var passworda = "";

            var store = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", UserInf.First().Id_Usuario)
            }).AsNoTracking().ToList();

            if (store.Count > 0)
            {
                var model = store.First();
                user = model.Usuario;
                passworda = model.Password;
            }

            //change this  rute in production this only for tests
            await Create($"/photocenter/Planta{UserInf.First().PlantaId}/model-features/", Modelo);
            Response.Clear();
            error = null;
            await Create($"/photocenter/Planta{UserInf.First().PlantaId}/model-features/{Modelo}/", $"{IdRegistro}");
            Response.Clear();
            error = null;
            await Create($"/photocenter/Planta{UserInf.First().PlantaId}/model-features/{Modelo}/{IdRegistro}/", "large");

            if (error != "" && error != null)
            {
                if (error == "ExistsFolder")
                {
                    Response.Clear();
                    error = null;
                    await Upload(IdRegistro);

                    if (error != "" && error != null)
                    {
                        error = null;
                        Response.Clear();
                        return Ok("Error");
                    }
                    else
                    {
                        Response.Clear();
                        files = MapRute(UserInf.First().PlantaId, Modelo, IdRegistro);

                        if (files.Any())
                        {
                            foreach (var name in files)
                            {
                                Json.Add(new ReturnUpload
                                {
                                    FileName = name,
                                    Modelo = Modelo,
                                    IdRegistro = IdRegistro,
                                    PlantaId = UserInf.First().PlantaId
                                });
                            }
                        }

                        Result = JsonConvert.SerializeObject(Json);
                        return Ok(Result);
                    }
                }
                else
                {
                    return Ok("Error");
                }
            }
            else
            {
                await Upload(IdRegistro);
                if (error != "" && error != null)
                {
                    error = null;
                    Response.Clear();
                    return Ok("Error");
                }
                else
                {
                    Response.Clear();
                    files = MapRute(UserInf.First().PlantaId, Modelo, IdRegistro);

                    if (files.Any())
                    {
                        foreach (var name in files)
                        {
                            Json.Add(new ReturnUpload
                            {
                                FileName = name,
                                Modelo = Modelo,
                                IdRegistro = IdRegistro,
                                PlantaId = UserInf.First().PlantaId
                            });
                        }
                    }

                    Result = JsonConvert.SerializeObject(Json);
                    return Ok(Result);
                }
            }

            async Task Create(string path, string name)
            {
                string validate_name_host = valida_name;
                string validate_path_host = valida_path;

                FileManagerResponse createResponse = new FileManagerResponse();
                try
                {
                    if (path.Equals(validate_path_host) && name.Equals(validate_name_host))
                    {
                        string url = $"ftp://10.208.122.234{path}{name}";
                        Uri uriResult;
                        bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                            && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                        if (result == true)
                        {
                            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                            try
                            {
                                request.Credentials = new NetworkCredential(user, passworda);
                                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                            }
                            catch (WebException e)
                            {
                                ErrorDetails er = new ErrorDetails();
                                FtpWebResponse response = (FtpWebResponse)e.Response;
                                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable && response.StatusDescription.Contains("exists"))
                                {

                                }
                                else
                                {
                                    er.Code = "417";
                                    er.Message = response.StatusDescription;
                                }
                                response.Close();
                            }
                        }
                    }
                    FileManagerDirectoryContent createData = new FileManagerDirectoryContent();
                    createData.Name = name;
                    createData.IsFile = false;
                    createData.Size = 0;
                    createData.DateModified = DateTime.Now;
                    createData.DateCreated = createData.DateModified;
                    createData.HasChild = false;
                    createData.Type = "";
                    FileManagerDirectoryContent[] newData = new FileManagerDirectoryContent[] { createData };
                }
                catch (Exception e)
                {
                    error = e.Message.ToString();
                }
            }

            async Task Upload(int? IdRegistro)
            {
                try
                {
                    string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/model-features/{Modelo}/{IdRegistro}/large/";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                       
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
                            error = ex.Message.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message.ToString();
                }

                var CountFiles = files.Count + 1;

                string name = $"{Modelo}-{CountFiles}.jpg";

                var OrderFile = new QualityModelFeaturesFilesOrder
                {
                    CaracteristicaId = IdRegistro.Value,
                    NombreArchivo = name,
                    FechaRegistro = DateTime.Now,
                    UsuarioRegistroId = UserInf.First().Id_Usuario,
                    Orden = CountFiles
                };

                await _fpContext.AddAsync(OrderFile);
                _fpContext.SaveChanges();

                try
                {
                    string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/model-features/{Modelo}/{IdRegistro}/large/{name}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        request.Credentials = new NetworkCredential(user, passworda);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        try
                        {
                            using (Stream stream = request.GetRequestStream())
                            {
                                file.CopyTo(stream);
                            }
                        }
                        catch (Exception e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            error = e.Message.ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    error = e.Message.ToString();
                }
            }
        }

        //========================Delete feature =========================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeleteFeature(int IdRegistro, string Modelo, string IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var MapFiles = new List<string>();

            var error = "";
            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
            var user = "";
            var passworda = "";

            var ftp = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", idUsuario)
            }).AsNoTracking().ToList();

            if (ftp.Count > 0)
            {
                var model = ftp.First();

                user = model.Usuario;
                passworda = model.Password;
            }

            var Json = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion=@Opcion, @FeatureID=@FeatureID ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 4),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("FeatureID", IdRegistro)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    if (await ExistFolder($"", UserInfo.PlantaId, $"{Modelo}"))
                    {
                        if (await ExistFolder($"{Modelo}/", UserInfo.PlantaId, $"{Modelo}"))
                        {
                            if (await ExistFolder($"{Modelo}/large", UserInfo.PlantaId, $"{Modelo}"))
                            {
                                MapFiles = MapRute(UserInfo.PlantaId, Modelo, IdRegistro);

                                foreach (var fileName in MapFiles)
                                {
                                    DeleteEachFiles(UserInfo.PlantaId, IdRegistro, Modelo, fileName);
                                }

                                DeleteFolder(UserInfo.PlantaId, IdRegistro, Modelo, $"{IdRegistro}/large");

                                if (await ExistFolder($"{Modelo}/", UserInfo.PlantaId, $"{IdRegistro}"))
                                {
                                    DeleteFolder(UserInfo.PlantaId, IdRegistro, Modelo, $"{IdRegistro}");
                                }
                            }
                        }
                    }


                    Json = query.First().Resultado;
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);

            async Task<bool> ExistFolder(string Ruta, int PlantaId, string FolderName)
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    bool isExist = false;
                    int index = 0;
                    var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                    var existFolder = ftpFiles.Where(N => N == FolderName || N.Equals(FolderName, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (existFolder.Any())
                    {
                        isExist = true;
                    }

                    reader.Close();
                    return isExist;
                }
                else
                {
                    return false;
                }
            }

            void DeleteEachFiles(int PlantaId, int IdRegistro, string Modelo, string FileName)
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Modelo}/{IdRegistro}/large/{FileName}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                }
            }

            void DeleteFolder(int PlantaId, int IdRegistro, string Modelo, string FolderName)
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Modelo}/{FolderName}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                }

            }

        }

        //========================Delete All Feature =========================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeleteAllFeatures(int EstacionID, string Modelo, string IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var MapFiles = new List<string>();

            var error = "";
            var user = "";
            var passworda = "";

            var ftp = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", UserInfo.Id_Usuario)
            }).AsNoTracking().ToList();

            if (ftp.Count > 0)
            {
                var model = ftp.First();

                user = model.Usuario;
                passworda = model.Password;
            }

            var Registros = _fpContext.QualityModelFeatures.Where(F => F.PlantaId == UserInfo.PlantaId
                              && F.Modelo == Modelo && F.Estacion == EstacionID).AsNoTracking().ToList();

            if (Registros.Any())
            {
                if (await ExistFolder(UserInfo.PlantaId, $"", $"{Modelo}"))
                {
                    foreach (var R in Registros)
                    {
                        if (await ExistFolder(UserInfo.PlantaId, $"{Modelo}", $"{R.IdRegistro}"))
                        {
                            var MapIdRegistroFolder = await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}");

                            if (MapIdRegistroFolder.Any())
                            {
                                foreach (var folders in MapIdRegistroFolder)
                                {
                                    var Files = await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}/{folders}");
                                    if (Files.Any())
                                    {
                                        foreach (var fileName in Files)
                                        {
                                            DeleteEachFiles(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}/{folders}/{fileName}");
                                        }

                                        DeleteFolder(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}/{folders}");

                                        if ((await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}")).Count.Equals(0))
                                        {
                                            DeleteFolder(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}");
                                        }
                                    }
                                    else
                                    {
                                        DeleteFolder(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}/{folders}");

                                        var Direct = await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}");

                                        if ((await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}")).Count.Equals(0))
                                        {
                                            DeleteFolder(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}");
                                        }
                                    }

                                }
                            }
                            else
                            {
                                DeleteFolder(UserInfo.PlantaId, $"{Modelo}/{R.IdRegistro}");
                            }
                        }
                    }
                }
            }


            var Json = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion=@Opcion, @EstacionID=@EstacionID, @Modelo =@Modelo ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 7),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Modelo", Modelo),
                    new SqlParameter("EstacionID", EstacionID)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = query.First().Resultado;
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);

            async Task<bool> ExistFolder(int PlantaId, string Ruta, string FolderName)
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    bool isExist = false;
                    int index = 0;
                    var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                    var existFolder = ftpFiles.Where(N => N == FolderName || N.Equals(FolderName, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (existFolder.Any())
                    {
                        isExist = true;
                    }

                    reader.Close();
                    return isExist;
                }
                else
                {
                    return false;
                }
            }

            async Task<List<string>> MapDirectory(int PlantaId, string Ruta)
            {
                var error = "";
                List<string> files = new List<string>();

                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
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

            void DeleteEachFiles(int PlantaId, string Ruta)
            {
                var error = "";
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                }
            }

            void DeleteFolder(int PlantaId, string Ruta)
            {
                var error = "";
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                }
            }
        }

        //======================== Copy Feature =========================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> CopyFeature(int EstacionID, string Modelo, string NewModelo, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            NewModelo = NewModelo.ToUpper();

            var user = "";
            var passworda = "";

            var ftp = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", UserInfo.Id_Usuario)
            }).AsNoTracking().ToList();

            if (ftp.Count > 0)
            {
                var model = ftp.First();

                user = model.Usuario;
                passworda = model.Password;
            }

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
                "@Modelo=@Modelo, @EstacionID=@EstacionID, " +
                "@NewModelo=@NewModelo ",
                new object[]
                {
                    new SqlParameter("Operacion", 9),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("EstacionID", EstacionID),
                    new SqlParameter("Modelo", Modelo),
                    new SqlParameter("NewModelo", NewModelo)
                }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    if (query.First().Resultado == "NoExistMF")
                    {
                        Result = "NoExistMF";
                    }
                    else if (query.First().Resultado == "NoExistModel")
                    {
                        Result = "NoExistModel";
                    }
                    else
                    {
                        if (await ExistFolder(UserInfo.PlantaId, $"", $"{Modelo}"))
                        {
                            foreach (var R in query)
                            {
                                if (await ExistFolder(UserInfo.PlantaId, $"{Modelo}", $"{R.ID}"))
                                {
                                    var MapIdRegistroFolder = await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.ID}");

                                    if (MapIdRegistroFolder.Where(f => f == "large").ToList().Any())
                                    {
                                        var Images = await MapDirectory(UserInfo.PlantaId, $"{Modelo}/{R.ID}/large");

                                        if (Images.Any())
                                        {
                                            await Create($"/photocenter/Planta{UserInfo.PlantaId}/model-features/", NewModelo);
                                            Response.Clear();
                                            error = null;
                                            await Create($"/photocenter/Planta{UserInfo.PlantaId}/model-features/{NewModelo}/", $"{R.Resultado}");
                                            Response.Clear();
                                            error = null;
                                            await Create($"/photocenter/Planta{UserInfo.PlantaId}/model-features/{NewModelo}/{R.Resultado}/", "large");

                                            var counter = 1;
                                            foreach (var FileName in Images)
                                            {
                                                string NewName = $"{NewModelo}-{counter}.jpg";

                                                var OrderFile = new QualityModelFeaturesFilesOrder
                                                {
                                                    CaracteristicaId = Int32.Parse(R.Resultado),
                                                    NombreArchivo = NewName,
                                                    FechaRegistro = DateTime.Now,
                                                    UsuarioRegistroId = UserInfo.Id_Usuario,
                                                    Orden = counter
                                                };

                                                await _fpContext.AddAsync(OrderFile);
                                                _fpContext.SaveChanges();

                                                CopyFile($"{R.ID}", R.Resultado, FileName, NewName);
                                                counter++;
                                            }

                                        }
                                    }
                                }
                            }

                            Result = "success";
                        }
                    }
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);


            async Task<bool> ExistFolder(int PlantaId, string Ruta, string FolderName)
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    bool isExist = false;
                    int index = 0;
                    var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                    var existFolder = ftpFiles.Where(N => N == FolderName || N.Equals(FolderName, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (existFolder.Any())
                    {
                        isExist = true;
                    }

                    reader.Close();
                    return isExist;
                }
                else
                {
                    return false;
                }
            }

            async Task<List<string>> MapDirectory(int PlantaId, string Ruta)
            {
                var error = "";
                List<string> files = new List<string>();

                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                request.Credentials = new NetworkCredential(user, passworda);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                try
                {
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

            async Task Create(string path, string name)
            {
                FileManagerResponse createResponse = new FileManagerResponse();
                try
                {
                    string url = $"ftp://10.208.122.234{path}{name}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        try
                        {
                            request.Credentials = new NetworkCredential(user, passworda);
                            request.Method = WebRequestMethods.Ftp.MakeDirectory;
                            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        }
                        catch (WebException e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            FtpWebResponse response = (FtpWebResponse)e.Response;
                            if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable && response.StatusDescription.Contains("exists"))
                            {

                            }
                            else
                            {
                                er.Code = "417";
                                er.Message = response.StatusDescription;
                            }
                            response.Close();
                        }
                    }

                    FileManagerDirectoryContent createData = new FileManagerDirectoryContent();
                    createData.Name = name;
                    createData.IsFile = false;
                    createData.Size = 0;
                    createData.DateModified = DateTime.Now;
                    createData.DateCreated = createData.DateModified;
                    createData.HasChild = false;
                    createData.Type = "";
                    FileManagerDirectoryContent[] newData = new FileManagerDirectoryContent[] { createData };
                }
                catch (Exception e)
                {
                    error = e.Message.ToString();
                }
            }

            void CopyFile(string From, string To, string FileName, string NewName)
            {

                string url = $"ftp://10.208.122.234/photocenter/Planta1/model-features/{Modelo}/{From}/large/{FileName}";
                
                Uri uriResult;
              
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeFtp);

                if (result == true )
                {
                    FtpWebRequest requestFrom = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    requestFrom.Credentials = new NetworkCredential(user, passworda);
                    requestFrom.Method = WebRequestMethods.Ftp.DownloadFile;
                    FtpWebResponse response = (FtpWebResponse)requestFrom.GetResponse();

                    byte[] buffer = this.ConvertByte(response.GetResponseStream());

                    string urls = $"ftp://10.208.122.234/photocenter/Planta1/model-features/{NewModelo}/{To}/large/{NewName}";
                    Uri uriResults;
                    bool results = Uri.TryCreate(urls, UriKind.Absolute, out uriResults) && (uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest requestTo = (FtpWebRequest)FtpWebRequest.Create(uriResults);
                    requestTo.Credentials = new NetworkCredential(user, passworda);
                    requestTo.Method = WebRequestMethods.Ftp.UploadFile;
                    
                    using (Stream stream = requestTo.GetRequestStream())
                    {
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    }
                    response.Close();
                }

            }

        }

        private byte[] ConvertByte(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream file = new MemoryStream())
            {
                int count;
                while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    file.Write(buffer, 0, count);
                }
                return file.ToArray();
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeletePicture(int CaracteristicaID, string Modelo, string Picture)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var MapFiles = new List<string>();
            var error = "";
            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
            var user = "";
            var passworda = "";
            var ftp = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", idUsuario)
            }).AsNoTracking().ToList();
            if (ftp.Count > 0)
            {
                var model = ftp.First();
                user = model.Usuario;
                passworda = model.Password;
            }
            var Json = "";
            var query = new List<ExecuteStores>();
            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion=@Opcion, @CaracteristicaID=@CaracteristicaID, @Pictures=@Pictures ",
               new object[]
               {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("Opcion", 8),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("@CaracteristicaID", CaracteristicaID),
                    new SqlParameter("@Pictures", Picture),
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            if (error == "")
            {
                if (query.Any())
                {
                    if (await ExistFolder("", UserInfo.PlantaId, $"{Modelo}"))
                    {
                        if (await ExistFolder($"{Modelo}/", UserInfo.PlantaId, $"{CaracteristicaID}"))
                        {
                            if (await ExistFolder($"{Modelo}/{CaracteristicaID}/", UserInfo.PlantaId, "large"))
                            {
                                DeleteEachFiles(UserInfo.PlantaId, CaracteristicaID, Modelo, Picture);
                            }
                        }
                    }
                    Json = query.First().Resultado;
                }
            }
            else
            {
                Json = "Error";
            }
            return Ok(Json);
            async Task<bool> ExistFolder(string Ruta, int PlantaId, string FolderName)
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Ruta}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);
                    bool isExist = false;
                    int index = 0;
                    var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();
                    var existFolder = ftpFiles.Where(N => N == FolderName || N.Equals(FolderName, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (existFolder.Any())
                    {
                        isExist = true;
                    }
                    reader.Close();
                    return isExist;
                }
                else 
                { 
                    return false; 
                }
            }
            void DeleteEachFiles(int PlantaId, int IdRegistro, string Modelo, string FileName)
            {
                var error = "";
                var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
                var user = "";
                var passworda = "";
                var query = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
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
                string url = $"ftp://10.208.122.234/photocenter/Planta{PlantaId}/model-features/{Modelo}/{IdRegistro}/large/{FileName}";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                }
            }
        }


    }
}
