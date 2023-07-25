using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Syncfusion.EJ2.Diagrams;
using System.Linq;
using Microsoft.AspNetCore.Http;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Syncfusion.EJ2.FileManager.Base;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;
using System.Diagnostics;
using Azure;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    public class SMCorrectiveActionsController : Controller
    {

        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private readonly LDigitalDocs _lDigitalDocs;
        private LDocumentControl _lDocControl;
        private readonly IHostingEnvironment _hostingEnvironment;
        public static string valida_name = string.Empty;

        public SMCorrectiveActionsController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext, IHostingEnvironment hostingEnvironment)
        {
            _fpContext = fpContext;
            _SpContext = SpContext;
            _lUsers = new LUsers(appContext);
            _ServiceNow = new LServiceNow(SpContext, fpContext);
            _lPendingTask = new LPendingTask(SpContext);
            _lDigitalDocs = new LDigitalDocs(SpContext);
            _lDocControl = new LDocumentControl(SpContext, fpContext);
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> CorrectiveAction(int ToolAC, int SourcesAC, int DepartmentAC, int MonitoringAC, 
        int ActivityAC, string ApertureDate, string PromiseDate, string CausesAC, int ActionCategoryAC, string ActionsAC, int ProcessAC, 
        string Key, IFormFile FileAC, int IdMenuService)
        {
            var extOriginFile = Path.GetExtension(FileAC.FileName);
            string ext = extOriginFile.Split(".")[1];

            var UserInf = _lUsers.getIdUser(User).First();
            List<string> files = new List<string>();
            string error = "";
            var user = "";
            var passworda = "";

                var query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion = @Operacion, " +
                "@UsuarioID = @UsuarioID, " +
                "@PlantaID = @PlantaID, " +
                "@HerramientaID = @HerramientaID, " +
                "@FuenteID = @FuenteID," +
                "@DepartamentoID = @DepartamentoID," +
                "@ResponsableSeguimientoID = @ResponsableSeguimientoID," +
                "@ResponsableActividadID = @ResponsableActividadID," +
                "@FechaApertura = @FechaApertura," +
                "@FechaPromesa = @FechaPromesa," +
                "@Causas = @Causas," +
                "@CategoriaAccion = @CategoriaAccion," +
                "@Acciones = @Acciones," +
                "@ProcesoID = @ProcesoID," +
                "@Key = @Key," +
                "@ExtFile=@ExtFile",
                new object[]
                {
                    new SqlParameter("Operacion", 2),
                    new SqlParameter("UsuarioID", UserInf.Usuario),
                    new SqlParameter("PlantaID", UserInf.PlantaId),
                    new SqlParameter("HerramientaID", ToolAC),
                    new SqlParameter("FuenteID", SourcesAC),
                    new SqlParameter("DepartamentoID", DepartmentAC),
                    new SqlParameter("ResponsableSeguimientoID", MonitoringAC),
                    new SqlParameter("ResponsableActividadID", ActivityAC),
                    new SqlParameter("FechaApertura", ApertureDate),
                    new SqlParameter("FechaPromesa",  PromiseDate),
                    new SqlParameter("Causas", CausesAC),
                    new SqlParameter("CategoriaAccion", ActionCategoryAC),
                    new SqlParameter("Acciones", ActionsAC),
                    new SqlParameter("ProcesoID", ProcessAC),
                    new SqlParameter("Key", Key),
                    new SqlParameter("ExtFile", ext)
                }).AsNoTracking().ToList();



            if (query.Any())
            {
                var ftp = _lDocControl.GetFtp(UserInf.Id_Usuario);
                var ActionId = query.First().ID.ToString();

                if (ftp.Any())
                {
                    user = ftp.First().Usuario;
                    passworda = ftp.First().Password;
                }

                valida_name = ActionId;
                await Create(ActionId);
                Response.Clear();

                if (error != "" && error != null)
                {
                    if (error == "ExistsFolder")
                    {
                        Response.Clear();
                        error = null;
                        await Upload($"{ActionId}-analisis{extOriginFile}", FileAC);
                        if (error != "" && error != null)
                        {
                            error = null;
                            Response.Clear();
                            return BadRequest("Fail to upload the File.");
                        }
                        else
                        {
                            Response.Clear();
                            return Ok("success");
                        }
                    }
                    else
                    {
                        return BadRequest("Fail to upload the File please contac the Admin.");
                    }
                }
                else
                {
                    await Upload($"{ActionId}-analisis{extOriginFile}", FileAC);
                    if (error != "" && error != null)
                    {
                        error = null;
                        Response.Clear();
                        return BadRequest("Fail to upload the File.");
                    }
                    else
                    {
                        Response.Clear();

                        return Ok("success");
                    }
                }

                async Task Create(string? name)
                {

                    string validated_name_host = valida_name;
                    if (name.Equals(validated_name_host))
                    {
                        string url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{validated_name_host}";
                        //return WebRequest.Create(url).GetResponse();

                        
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                        //request.Method = WebRequestMethods.Ftp.DownloadFile;
                        try
                        {
                            request.Credentials = new NetworkCredential(user, passworda);
                            request.Method = WebRequestMethods.Ftp.MakeDirectory;
                            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                            //Stream responseStream = response.GetResponseStream();
                            //StreamReader reader = new StreamReader(responseStream);
                            //reader.ReadToEnd();
                            //reader.Close();
                            response.Close();
                            //responseStream.Close();
                        }
                        catch (Exception ex) // WebException ex
                        {
                            //MessageBox.Show("" + ex.Message); //
                            //ex.Message = response.StatusDescription;
                            error = ex.Message;
                        }
                    }
                    //FileManagerResponse createResponse = new FileManagerResponse();
                    //try
                    //{
                    //    try
                    //    {
                    //        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{name}");
                    //        request.Credentials = new NetworkCredential(user, passworda);
                    //        request.Method = WebRequestMethods.Ftp.MakeDirectory;
                    //        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    //    }
                    //    catch (WebException e)
                    //    {
                    //        ErrorDetails er = new ErrorDetails();
                    //        FtpWebResponse response = (FtpWebResponse)e.Response;
                    //        if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable && response.StatusDescription.Contains("exists"))
                    //        {

                    //        }
                    //        else
                    //        {
                    //            er.Code = "417";
                    //            er.Message = response.StatusDescription;
                    //        }
                    //        response.Close();
                    //    }

                    //    FileManagerDirectoryContent createData = new FileManagerDirectoryContent();
                    //    createData.Name = name;
                    //    createData.IsFile = false;
                    //    createData.Size = 0;
                    //    createData.DateModified = DateTime.Now;
                    //    createData.DateCreated = createData.DateModified;
                    //    createData.HasChild = false;
                    //    createData.Type = "";
                    //    FileManagerDirectoryContent[] newData = new FileManagerDirectoryContent[] { createData };
                    //}
                    //catch (Exception e)
                    //{
                    //    error = e.Message.ToString();
                    //}

                }

                async Task Upload(string name, IFormFile file)
                {
                    try
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}");
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
                            error = ex.Message.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message.ToString();
                    }

                    try
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/corrective-actions-files/{ActionId}/{name}");
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
                    catch (Exception e)
                    {
                        error = e.Message.ToString();
                    }
                }

            }
            else
            {
                return Ok("Error");
            }
        }



    }
}
