using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Syncfusion.EJ2.FileManager.Base;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FactoryPlatform.Filter;
using Newtonsoft.Json;
using Azure;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]
    public class TMDocsEditionController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private LDocumentControl _lDocControl;

        public static string valida_name = string.Empty;
        public TMDocsEditionController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
        {
            _fpContext = fpContext;
            _SpContext = SpContext;
            _lUsers = new LUsers(appContext);
            _ServiceNow = new LServiceNow(SpContext, fpContext);
            _lPendingTask = new LPendingTask(SpContext);
            _lDocControl = new LDocumentControl(SpContext, fpContext);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckRevision(string Clave, int Id, int Revision, int IdMenuTask)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            //var model = new List<DocList_DocInf>();

            var jsonDatos = "";

            var docInfs = _SpContext.DocList_DocInf.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
             "@Operacion = @Operacion, " +
             "@Tipo = @Tipo, " +
             "@UserID = @UserID, " +
             "@PlantID = @PlantID, " +
             "@DocumentoID= @DocumentoID, " +
             "@RevisionDoc= @RevisionDoc"
         , new object[]
         {
                new SqlParameter("Operacion", 3),
                new SqlParameter("Tipo", 10),
                new SqlParameter("UserID", UserInf.Id_Usuario),
                new SqlParameter("PlantID", UserInf.PlantaId),
                new SqlParameter("DocumentoID", Id),
                new SqlParameter("RevisionDoc", Revision)
         }).AsNoTracking().ToList();

            if (docInfs.Any())
            {
                jsonDatos = JsonConvert.SerializeObject(docInfs);
            }
            else
            {
                jsonDatos = "Error";
            }

            return Ok(jsonDatos);
        }

        private readonly string[] whiteList = { "10.208.122.234" };

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateRevision(
        int RevisionActual, int DocumentoID, string Title, string Description, string Comentarios, string DateEstimated,
        int ResponChange, int OriginChange, string OriginComment, string DescripChange, string Review, string Validation, string Workstations,
        string Preapproval, string FinalSign, IFormFile Original, IFormFile PDF, int IdMenuTask)
        {
            var extOriginFile = Path.GetExtension(Original.FileName);
            string ext = extOriginFile.Split(".")[1];
            //var date = DateEstimated.ToString("MMM/dd/yyy");

            var UserInf = _lUsers.getIdUser(User).First();
            List<string> files = new List<string>();
            string error = "";
            var user = "";
            var passworda = "";

            var query = _SpContext.spFPAPP_Services_now_DocViewers.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                "@DocumentoID=@DocumentoID, @RevisionActual=@RevisionActual, @Titulo=@Titulo, " +
                "@Comentarios=@Comentarios, @FechaFin=@FechaFin, @ResponsableID=@ResponChange ,@Origen=@OriginChange, " +
                "@OrigenComentario=@OriginComment, @Descripcion=@Descripcion, @DescripcionCambio=@DescripcionCambio, @Revision= @Revision , @Validacion= @Validacion, " +
                "@Estaciones = @Estaciones, @ExtensionFile=@ExtensionFile, @Vobo = @Vobo, " +
                "@Auth = @Auth, @UserID=@UsuarioID, @PlantID = @PlantaID, @Operacion = @Operacion",
            new object[]
            {
                new SqlParameter("DocumentoID", DocumentoID),
                new SqlParameter("ExtensionFile", ext),
                new SqlParameter("RevisionActual", RevisionActual),
                new SqlParameter("Titulo", Title),
                new SqlParameter("Descripcion", Description),
                new SqlParameter("DescripcionCambio", DescripChange),
                new SqlParameter("Comentarios", Comentarios),
                new SqlParameter("FechaFin", DateEstimated),
                new SqlParameter("ResponChange", ResponChange),
                new SqlParameter("OriginChange", OriginChange),
                new SqlParameter("OriginComment", OriginComment),
                new SqlParameter("Revision", Review),
                new SqlParameter("Validacion", Validation),
                new SqlParameter("Estaciones", Workstations),
                new SqlParameter("Vobo", Preapproval),
                new SqlParameter("Auth", FinalSign),
                new SqlParameter("UsuarioID", UserInf.Id_Usuario),
                new SqlParameter("PlantaID", UserInf.PlantaId),
                new SqlParameter("Operacion", 7)
            }).AsNoTracking().ToList();

            if (query.Any())
            {
                var UpFileData = query.First();

                var ftp = _lDocControl.GetFtp(UserInf.Id_Usuario);

                if (ftp.Any())
                {
                    user = ftp.First().Usuario;
                    passworda = ftp.First().Password;
                }

				valida_name = UpFileData.Clave;
				await Create(UpFileData.Clave);
                
                Response.Clear();
                error = null;

				valida_name = $"/{RevisionActual}";
				await Create($"/{RevisionActual}");
                
                Response.Clear();

                if (error != "" && error != null)
                {
                    if (error == "ExistsFolder")
                    {
                        Response.Clear();
                        error = null;
                        await Upload($"{UpFileData.Clave}{extOriginFile}", Original);
                        await Upload($"{UpFileData.Clave}.PDF", PDF);
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
                    await Upload($"{UpFileData.Clave}{extOriginFile}", Original);
                    await Upload($"{UpFileData.Clave}.PDF", PDF);
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

                async Task Create(string name)
                {
                    string validated_name_host = valida_name;
                    if (name.Equals(validated_name_host))
                    {
                        string url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{validated_name_host}";

                        FileManagerResponse createResponse = new FileManagerResponse();

                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(url);
                        try
                        {
                            try
                            {
                                request.Credentials = new NetworkCredential(user, passworda);
                                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                                Stream dataStream = response.GetResponseStream();
                                
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

                async Task Upload(string name, IFormFile file)
                {
                    try
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{UpFileData.Clave}/{RevisionActual}");
                        

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
                            files = null;
                            files.Clear();
                            ftpFiles = null;
                            ftpFiles.Clear();
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
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{UpFileData.Clave}/{RevisionActual}/{name}");
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
