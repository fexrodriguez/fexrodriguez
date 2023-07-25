using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using FactoryPlatform.Areas.ServiceNow.Models.PendingTask.CorrectiveActions;
using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.CorrectiveActions;
using Microsoft.AspNetCore.Http;
using FactoryPlatform.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Syncfusion.EJ2.FileManager.Base;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System;
using static Azure.Core.HttpHeader;
using Syncfusion.EJ2.Diagrams;
using Azure;
using static System.Net.WebRequestMethods;
using Microsoft.CodeAnalysis;
using System.Diagnostics;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Syncfusion.EJ2.Navigations;
using FactoryPlatform.Properties;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Security.Policy;
using System.Xml.Linq;

namespace FactoryPlatform.Areas.ServiceNow.Controllers.TaskMenu
{
    public class TMCorrectiveActionController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public static string validate_name = string.Empty;
        public static string validate_name_delete = string.Empty;
        public static string validate_file = string.Empty;
        public static string validate_action = string.Empty;
        public TMCorrectiveActionController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
        {
            _fpContext = fpContext;
            _SpContext = SpContext;
            _lUsers = new LUsers(appContext);
            _ServiceNow = new LServiceNow(SpContext, fpContext);
            _lPendingTask = new LPendingTask(SpContext);
            _lDocControl = new LDocumentControl(SpContext, fpContext);
        }

        public class ModalInfo
        {
            public TMInfoModalCorrectiveAction InfoBasicaModal { get; set; } = new TMInfoModalCorrectiveAction();
            public List<TMInfoReturnCorrectiveA> InfoRetorno { get; set; } = new List<TMInfoReturnCorrectiveA>();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetInfModalCA(int IdAccionC)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            var jsonDatos = "";
            var model = new ModalInfo();

            var FirstQuary = _SpContext.TMInfoModalCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID",
            new object[]
            {
            new SqlParameter("Operacion", 4),
            new SqlParameter("UsuarioID", UserInf.Id_Usuario),
            new SqlParameter("AcionCorrectivaID", IdAccionC),
            }).AsNoTracking().ToList();

            if (FirstQuary.Any())
            {
                model.InfoBasicaModal = FirstQuary.First();
            }

            var SecondQuery = _SpContext.TMInfoReturnCorrectiveA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID",
            new object[]
            {
            new SqlParameter("Operacion", 5),
            new SqlParameter("UsuarioID", UserInf.Id_Usuario),
            new SqlParameter("AcionCorrectivaID", IdAccionC),
            }).AsNoTracking().ToList();

            if (SecondQuery.Any())
            {
                model.InfoRetorno = SecondQuery;
            }

            jsonDatos = JsonConvert.SerializeObject(model);

            return Ok(jsonDatos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReturnCorrectiveAction(int IdAccionC, int Step, string Comment)
        {
            var UserInf = _lUsers.getIdUser(User).First();

            var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID, @Nivel=@Nivel, @Comentarios=@Comentarios",
            new object[]
            {
            new SqlParameter("Operacion", 6),
            new SqlParameter("UsuarioID", UserInf.Id_Usuario),
            new SqlParameter("AcionCorrectivaID", IdAccionC),
            new SqlParameter("Nivel", Step),
            new SqlParameter("Comentarios", Comment),

            }).AsNoTracking().ToList();

            if (Query.Any())
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
        public IActionResult SaveUpdate(string Key, int IdAccionCorrective, int Step, int IdSources, int IdDepartment, int IdProcess,
        int IdLiderPCA, int IdActivity, int IdActionCategory, string PromiseDate, string Causes, string Actions)
        {
            var UserInf = _lUsers.getIdUser(User).First();

            var query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion = @Operacion, " +
            "@UsuarioID = @UsuarioID, " +
            "@PlantaID = @PlantaID, " +
            "@FuenteID = @FuenteID," +
            "@DepartamentoID = @DepartamentoID," +
            "@ResponsableSeguimientoID = @ResponsableSeguimientoID," +
            "@ResponsableActividadID = @ResponsableActividadID," +
            "@FechaPromesa = @FechaPromesa," +
            "@Causas = @Causas," +
            "@CategoriaAccion = @CategoriaAccion," +
            "@Acciones = @Acciones," +
            "@ProcesoID = @ProcesoID," +
            "@Key = @Key," +
            "@AcionCorrectivaID = @AcionCorrectivaID",
            new object[]
            {
                new SqlParameter("Operacion", 9),
                new SqlParameter("UsuarioID", UserInf.Usuario),
                new SqlParameter("PlantaID", UserInf.PlantaId),
                new SqlParameter("FuenteID", IdSources),
                new SqlParameter("DepartamentoID", IdDepartment),
                new SqlParameter("ProcesoID", IdProcess),
                new SqlParameter("ResponsableSeguimientoID", IdLiderPCA),
                new SqlParameter("ResponsableActividadID", IdActivity),
                new SqlParameter("FechaPromesa",  PromiseDate),
                new SqlParameter("Causas", Causes),
                new SqlParameter("Acciones", Actions),
                new SqlParameter("CategoriaAccion", IdActionCategory),
                new SqlParameter("Key", Key),
                new SqlParameter("@AcionCorrectivaID", IdAccionCorrective)
            }).AsNoTracking().ToList();


            if (query.Any())
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
        public IActionResult DeleteAccionC(int IdAccionC, string Comment)
        {
            var UserInf = _lUsers.getIdUser(User).First();

            var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID, @Comentarios=@Comentarios",
            new object[]
            {
            new SqlParameter("Operacion", 10),
            new SqlParameter("UsuarioID", UserInf.Id_Usuario),
            new SqlParameter("AcionCorrectivaID", IdAccionC),
            new SqlParameter("Comentarios", Comment),

            }).AsNoTracking().ToList();

            if (Query.Any())
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
        public async Task<IActionResult> SavePaso1(IFormFile FileAC, int IdAccionCorrective, int Step, string Comment, int IdSources,
         int IdDepartment, int IdProcess, int IdActivity, int IdAction, string Causes, string Actions, string FamilyRASP, string Failure)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            List<string> files = new List<string>();
            string respuesta = "";
            var user = "";
            var passworda = "";
            var Query = new List<ExecuteStores>();

            var extOriginFile = FileAC != null ? Path.GetExtension(FileAC.FileName) : "-";
            string ext = FileAC != null ? extOriginFile.Split(".")[1] : "-";
            try
            {
                Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                   "@Operacion = @Operacion, " +
                   "@AcionCorrectivaID= @AcionCorrectivaID, " +
                   "@Nivel = @Nivel, " +
                   "@UsuarioID = @UsuarioID, " +
                   "@PlantaID = @PlantaID, " +
                   "@FuenteID = @FuenteID," +
                   "@DepartamentoID = @DepartamentoID," +
                   "@ResponsableActividadID = @ResponsableActividadID," +
                   "@Causas = @Causas," +
                   "@CategoriaAccion = @CategoriaAccion," +
                   "@Acciones = @Acciones," +
                   "@ProcesoID = @ProcesoID," +
                   "@RaspFamily=@RaspFamily, " +
                   "@RASPFailureCode=@RASPFailureCode, " +
                   "@Comentarios=@Comentarios, " +
                   "@ExtFile=@ExtFile",
                   new object[]
                   {
                    new SqlParameter("Operacion", 7),
                    new SqlParameter("AcionCorrectivaID", IdAccionCorrective),
                    new SqlParameter("Nivel", Step),
                    new SqlParameter("UsuarioID", UserInf.Usuario),
                    new SqlParameter("PlantaID", UserInf.PlantaId),
                    new SqlParameter("FuenteID", IdSources),
                    new SqlParameter("DepartamentoID", IdDepartment),
                    new SqlParameter("ResponsableActividadID", IdActivity),
                    new SqlParameter("ProcesoID", IdProcess),
                    new SqlParameter("CategoriaAccion", IdAction),
                    new SqlParameter("Causas", Causes),
                    new SqlParameter("Acciones", Actions),
                    new SqlParameter("RaspFamily", FamilyRASP = FamilyRASP != null ? FamilyRASP : "-"),
                    new SqlParameter("RASPFailureCode", Failure = Failure != null ? Failure : "-" ),
                    new SqlParameter("Comentarios", Comment = Comment != null ? Comment : "-" ),
                    new SqlParameter("ExtFile", ext)
                       }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                var lol = ex.Message;
            }


            if (Query.Any())
            {
                if (FileAC != null)
                {
                    var ftp = _lDocControl.GetFtp(UserInf.Id_Usuario);
                    var ActionId = IdAccionCorrective.ToString();

                    if (ftp.Any())
                    {
                        user = ftp.First().Usuario;
                        passworda = ftp.First().Password;
                    }

                    //// VALIDA SI EXISTE CARPETA
                    string url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if(result == true) { 
                    FtpWebRequest requestDir = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    try
                    {

                        requestDir.Credentials = new NetworkCredential(user, passworda);
                        requestDir.Method = WebRequestMethods.Ftp.ListDirectory;
                        FtpWebResponse response = (FtpWebResponse)requestDir.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);

                        var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                        if (ftpFiles.Count > 0)
                        {
                            files = ftpFiles;

                        }

                        if (ftpFiles.Contains(ActionId))
                        {
                            respuesta = "carpeta";
                        }
                        else
                        {
                            respuesta = "nocarpeta";
                        }

                        response.Close();
                        responseStream.Close();
                        reader.Close();

                    }
                    catch (WebException e)
                    {
                        respuesta = e.Message;
                    }
                    ///
                    }
                    ///Crear Folder
                    if (respuesta == "nocarpeta")
                    {
                        url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}";
                        result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                        if (result == true)
                        {
                            
                            FtpWebRequest requestfolder = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                            try
                            {

                                requestfolder.Credentials = new NetworkCredential(user, passworda);
                                requestfolder.Method = WebRequestMethods.Ftp.MakeDirectory;
                                FtpWebResponse response = (FtpWebResponse)requestfolder.GetResponse();

                                response.Close();
                                respuesta = "correcto";
                            }
                            catch (WebException e)
                            {
                                respuesta = e.Message;

                                if (e.Message.Contains("550"))
                                {
                                    respuesta = "correcto";
                                }

                            }
                        }
                    }
                    ///ENLISTAR ARCHIVOS Y BORRAR ARCHIVO SI EXISTE
                    if (respuesta == "carpeta")
                    {
                        ///ENLISTAR ARCHIVOS
                        url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}";
                        result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                        if (result == true)
                        {
                            FtpWebRequest requestlista = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                            try
                            {

                                requestlista.Credentials = new NetworkCredential(user, passworda);
                                requestlista.Method = WebRequestMethods.Ftp.ListDirectory;
                                FtpWebResponse response = (FtpWebResponse)requestlista.GetResponse();
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
                            catch (WebException e)
                            {
                                respuesta = e.Message;
                            }
                        }

                        ///BORRAR ARCHIVOS

                        var checkFile = files.Where(F => F.Contains($"{ActionId}-analisis")).ToList();

                        if (checkFile.Any())
                        {
                            url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}/{checkFile.First()}";

                            result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                            if (result == true)
                            {
                                FtpWebRequest requestBorrar = (FtpWebRequest)FtpWebRequest.Create(uriResult);

                                try
                                {
                                    requestBorrar.Credentials = new NetworkCredential(user, passworda);
                                    requestBorrar.Method = WebRequestMethods.Ftp.DeleteFile;
                                    FtpWebResponse response = (FtpWebResponse)requestBorrar.GetResponse();

                                    response.Close();

                                }
                                catch (Exception ex)
                                {
                                    respuesta = ex.Message.ToString();
                                }
                            }
                        }
                    }

                    //SUBIR ARCHIVO
                    url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}/{ActionId}-analisis{extOriginFile}";
                    result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        try
                        {
                            request.Credentials = new NetworkCredential(user, passworda);
                            request.Method = WebRequestMethods.Ftp.UploadFile;
                            try
                            {
                                using (Stream stream = request.GetRequestStream())
                                {
                                    FileAC.CopyTo(stream);
                                }
                                respuesta = "success";
                            }
                            catch (Exception e)
                            {
                                ErrorDetails er = new ErrorDetails();
                                respuesta = e.Message.ToString();
                            }


                        }
                        catch (Exception e)
                        {
                            respuesta = e.Message.ToString();

                        }
                    }
                    return Ok(respuesta);


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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SavePaso2(IFormFile FileAC, int IdAccionC, int Step, string Comment)
        {
            var extOriginFile = Path.GetExtension(FileAC.FileName);
            string ext = extOriginFile.Split(".")[1];

            var UserInf = _lUsers.getIdUser(User).First();
            List<string> files = new List<string>();
            string respuesta = "";
            var user = "";
            var passworda = "";


            var query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID, @Nivel=@Nivel, @Comentarios=@Comentarios, @ExtFile=@ExtFile ",
            new object[]
            {
                    new SqlParameter("Operacion", 7),
                    new SqlParameter("Nivel", Step),
                    new SqlParameter("UsuarioID", UserInf.Id_Usuario),
                    new SqlParameter("Comentarios", Comment),
                    new SqlParameter("AcionCorrectivaID", IdAccionC),
                    new SqlParameter("ExtFile", ext),
            }).AsNoTracking().ToList();


            if (query.Any())
            {
                var ftp = _lDocControl.GetFtp(UserInf.Id_Usuario);
                var ActionId = IdAccionC.ToString();

                if (ftp.Any())
                {
                    user = ftp.First().Usuario;
                    passworda = ftp.First().Password;
                }

                //// VALIDA SI EXISTE CARPETA
                string url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/";
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest requestValida = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    try
                    {

                        requestValida.Credentials = new NetworkCredential(user, passworda);
                        requestValida.Method = WebRequestMethods.Ftp.ListDirectory;
                        FtpWebResponse response = (FtpWebResponse)requestValida.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);

                        var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                        if (ftpFiles.Count > 0)
                        {
                            files = ftpFiles;

                        }

                        if (ftpFiles.Contains(ActionId))
                        {
                            respuesta = "carpeta";
                        }
                        else
                        {
                            respuesta = "nocarpeta";
                        }

                        response.Close();
                        responseStream.Close();
                        reader.Close();

                    }
                    catch (WebException e)
                    {
                        respuesta = e.Message;
                    }
                }
                ///

                ///Crear Folder
                if (respuesta == "nocarpeta")
                {
                    url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}";
                    result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest requestCarpeta = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        try
                        {

                            requestCarpeta.Credentials = new NetworkCredential(user, passworda);
                            requestCarpeta.Method = WebRequestMethods.Ftp.MakeDirectory;
                            FtpWebResponse response = (FtpWebResponse)requestCarpeta.GetResponse();

                            response.Close();
                            respuesta = "correcto";
                        }
                        catch (WebException e)
                        {
                            respuesta = e.Message;

                            if (e.Message.Contains("550"))
                            {
                                respuesta = "correcto";
                            }

                        }
                    }
                }
                ///ENLISTAR ARCHIVOS Y BORRAR ARCHIVO SI EXISTE
                if (respuesta == "carpeta")
                {
                    ///ENLISTAR ARCHIVOS
                    url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}";
                    result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest requestFolder = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        try
                        {

                            requestFolder.Credentials = new NetworkCredential(user, passworda);
                            requestFolder.Method = WebRequestMethods.Ftp.ListDirectory;
                            FtpWebResponse response = (FtpWebResponse)requestFolder.GetResponse();
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
                        catch (WebException e)
                        {
                            respuesta = e.Message;
                        }
                    }
                    ///BORRAR ARCHIVOS

                    var checkFile = files.Where(F => F.Contains($"{ActionId}-evidencia")).ToList();

                    if (checkFile.Any())
                    {
                        url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}/{checkFile.First()}";

                        result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                        if (result == true)
                        {
                            FtpWebRequest requestDelete = (FtpWebRequest)FtpWebRequest.Create(uriResult);

                            try
                            {
                                requestDelete.Credentials = new NetworkCredential(user, passworda);
                                requestDelete.Method = WebRequestMethods.Ftp.DeleteFile;
                                FtpWebResponse response = (FtpWebResponse)requestDelete.GetResponse();

                                response.Close();

                            }
                            catch (Exception ex)
                            {
                                respuesta = ex.Message.ToString();
                            }
                        }
                    }
                }

                //SUBIR ARCHIVO
                url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}/{ActionId}-evidencia{extOriginFile}";
                result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                if (result == true)
                {
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    try
                    {
                        request.Credentials = new NetworkCredential(user, passworda);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        try
                        {
                            using (Stream stream = request.GetRequestStream())
                            {
                                FileAC.CopyTo(stream);
                            }
                            respuesta = "success";
                        }
                        catch (Exception e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            respuesta = e.Message.ToString();
                        }


                    }
                    catch (Exception e)
                    {
                        respuesta = e.Message.ToString();

                    }
                }

                return Ok(respuesta);


            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SavePaso3(int IdAccionC, int Step, string CommentStep, string IdDeadLine,
        int IdCloser, int IdSolution, string FamilyRASP, string Failure, int Opcion)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            var Query = new List<ExecuteStores>();

            if (Opcion == 1)
            {
                Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID, @Nivel=@Nivel, " +
               "@Comentarios=@Comentarios",
               new object[]
               {
                new SqlParameter("Operacion", 7),
                new SqlParameter("Opcion", Opcion),
                new SqlParameter("UsuarioID", UserInf.Id_Usuario),
                new SqlParameter("AcionCorrectivaID", IdAccionC),
                new SqlParameter("Nivel", Step),
                new SqlParameter("Comentarios", CommentStep = CommentStep != null ? CommentStep : "-")
               }).AsNoTracking().ToList();
            }
            else
            {
                Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @AcionCorrectivaID=@AcionCorrectivaID, @Nivel=@Nivel, " +
               "@Comentarios=@Comentarios, @FechaCierre=@FechaCierre, @TipoSolucionID=@TipoSolucionID, @RaspFamily=@RaspFamily, " +
               "@RASPFailureCode=@RASPFailureCode, @CerradoPorID=@CerradoPorID",
               new object[]
               {
                new SqlParameter("Operacion", 7),
                new SqlParameter("Opcion", Opcion),
                new SqlParameter("UsuarioID", UserInf.Id_Usuario),
                new SqlParameter("AcionCorrectivaID", IdAccionC),
                new SqlParameter("Nivel", Step),
                new SqlParameter("Comentarios", CommentStep = CommentStep != null ? CommentStep : "-"),
                new SqlParameter("FechaCierre", IdDeadLine),
                new SqlParameter("CerradoPorID", IdCloser),
                new SqlParameter("TipoSolucionID", IdSolution ),
                new SqlParameter("RaspFamily", FamilyRASP = FamilyRASP != null ? FamilyRASP : "-"),
                new SqlParameter("RASPFailureCode", Failure = Failure != null ? Failure : "-" ),
               }).AsNoTracking().ToList();
            }

            if (Query.Any())
            {
                return Ok("success");
            }
            else
            {
                return Ok("Error");
            }

        }


    }
}


