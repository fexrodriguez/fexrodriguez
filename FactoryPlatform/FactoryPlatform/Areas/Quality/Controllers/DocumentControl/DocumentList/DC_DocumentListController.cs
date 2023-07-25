using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Filter;
using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.EJ2.FileManager.Base;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Security.Policy;

namespace FactoryPlatform.Areas.Quality.Controllers.DocumentControl.DocumentList
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class DC_DocumentListController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private LDocumentControl _lDocControl;
        private readonly LUsers _lUsers;
        private readonly LHistorySetionsPagesUsers _lHistoryPages;
        public static DocumentListViewModel _DocumentList = new DocumentListViewModel();

        public static string valida_name = string.Empty;
        public static string valida_path = string.Empty;
        public static int valida_planta = 0;
        public DC_DocumentListController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lDocControl = new LDocumentControl(spContext, fpContext);
            _lUsers = new LUsers(appContext);
            _lHistoryPages = new LHistorySetionsPagesUsers(fpContext, spContext);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DocViewerComboData(int ValueCombo, int comboId)
        {
            string jsonDatos = "";
            var UserInf = _lUsers.getIdUser(User).First();

            var model = new DocViewerViewModel();

            switch (comboId)
            {
                case 2:
                    model.ProductionDepartments = _lDocControl.ComboData(UserInf.Id_Usuario, 2, null, ValueCombo).ProductionDepartments;
                    break;
                case 3:
                    model.ProductionStations = _lDocControl.ComboData(UserInf.Id_Usuario, 3, null, ValueCombo).ProductionStations;
                    break;
                case 6:
                    model.Keys_longitud = _lDocControl.ComboData(UserInf.Id_Usuario, 6, UserInf.PlantaId, ValueCombo).Keys_longitud;
                    break;
            }

            jsonDatos = JsonConvert.SerializeObject(model);
            return Ok(jsonDatos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckRevision(string Clave, int Id, int Revision, int IdSeccion)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            //var model = new List<DocList_DocInf>();

            var jsonDatos = "";
            var error = "";

            var query = new List<DocList_DocInf>();

            try
            {
                query = _spContext.DocList_DocInf.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
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
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }


            if (error == "")
            {
                jsonDatos = JsonConvert.SerializeObject(query);
            }
            else
            {
                jsonDatos = "Error";
            }

            return Ok(jsonDatos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckDocs(string Clave, int IdSeccion)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            string jsonDatos = "";

            var Model = new List<CheckQualityDocs>();

                Model = _spContext.CheckQualityDocs.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                    "@UserID = @UserID, " +
                    "@Clave = @Clave, " +
                    "@Operacion = @Operacion, " +
                    "@Tipo = @Tipo",
                 new object[]
                 {
                            new SqlParameter("Operacion", 3),
                            new SqlParameter("Tipo", 7),
                            new SqlParameter("UserID", UserInf.Id_Usuario),
                            new SqlParameter("Clave", Clave)
                 }).AsNoTracking().ToList();

            return Ok(Model.First().Status);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewDocument(
        int TipoDocumento, int RevisionActual, string Clave, string Title, string Description, string Comentarios, string DateEstimated,
        int ResponChange, int OriginChange, string OriginComment, string DescripChange, string Review, string Validation, string Workstations,
        string Preapproval, string FinalSign, IFormFile Original, IFormFile PDF, int IdSeccion)
        {
            var extOriginFile = Path.GetExtension(Original.FileName);
            string ext = extOriginFile.Split(".")[1];
            //var date = DateEstimated.ToString("M/dd/yyy");

            var UserInf = _lUsers.getIdUser(User).First();
            List<string> files = new List<string>();
            string error = "";
            var user = "";
            var passworda = "";

            var query = _spContext.spFPAPP_Services_now_DocViewers.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                "@Clave=@Clave, @TipoDocumento=@TipoDocumento, @RevisionActual=@RevisionActual, @Titulo=@Titulo, " +
                "@Comentarios=@Comentarios, @FechaFin=@FechaFin, @ResponsableID=@ResponChange ,@Origen=@OriginChange, " +
                "@OrigenComentario=@OriginComment, @Descripcion=@Descripcion,  @DescripcionCambio=@DescripcionCambio, @Revision= @Revision , @Validacion= @Validacion, " +
                "@Estaciones = @Estaciones, @ExtensionFile=@ExtensionFile,  @Vobo = @Vobo, " +
                "@Auth = @Auth, @UserID=@UsuarioID, @PlantID = @PlantaID, @Operacion = @Operacion",
            new object[]
            {
                new SqlParameter("Clave", Clave),
                new SqlParameter("TipoDocumento", TipoDocumento),
                new SqlParameter("ExtensionFile", ext),
                new SqlParameter("RevisionActual", RevisionActual),
                new SqlParameter("Titulo", Title),
                new SqlParameter("Descripcion", Description),
                new SqlParameter("DescripcionCambio  ", DescripChange),
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
                new SqlParameter("Operacion", 4)
            }).AsNoTracking().ToList();

            if (query.Any())
            {
                var ftp = _lDocControl.GetFtp(UserInf.Id_Usuario);

                if (ftp.Any())
                {
                    user = ftp.First().Usuario;
                    passworda = ftp.First().Password;
                }
                string validate_path = "";
                string validate_name = "";

				validate_path = $"/documentcenter/Planta{UserInf.PlantaId}/documents-center/";
				validate_name = Clave;
				await Create($"/documentcenter/Planta{UserInf.PlantaId}/documents-center/", Clave);
                
                Response.Clear();
                error = null;

				validate_path = $"/documentcenter/Planta{UserInf.PlantaId}/documents-center/{Clave}/";
				validate_name = $"{RevisionActual}";

				await Create($"/documentcenter/Planta{UserInf.PlantaId}/documents-center/{Clave}/", $"{RevisionActual}");
                 
                Response.Clear();

                if (error != "" && error != null)
                {
                    if (error == "ExistsFolder")
                    {
                        Response.Clear();
                        error = null;
                        await Upload($"{Clave}{extOriginFile}", Original);
                        valida_name = $"{Clave}{extOriginFile}";
                        await Upload($"{Clave}.PDF", PDF);
                        valida_name = $"{Clave}.PDF";
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
                    await Upload($"{Clave}{extOriginFile}", Original);
                    await Upload($"{Clave}.PDF", PDF);
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

                async Task Create(string path, string name)
                {
                    if (path.Equals(validate_path) && name.Equals(validate_name)) {

                        path = validate_path;
                        name = validate_name;

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
                }

                async Task Upload(string name, IFormFile file)
                {

                    if (name.Equals(valida_name)) {
                        name = valida_name;
                        try
                        {
                            string urls = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{Clave}/{RevisionActual}";
                            Uri uriResults;
                            bool results = Uri.TryCreate(urls, UriKind.Absolute, out uriResults)
                                && (uriResults.Scheme == Uri.UriSchemeFtp || uriResults.Scheme == Uri.UriSchemeFtp);
                            if (results == true)
                            {
                                FtpWebRequest requests = (FtpWebRequest)FtpWebRequest.Create(uriResults);
                            
                                try
                                {
                                    requests.Credentials = new NetworkCredential(user, passworda);
                                    requests.Method = WebRequestMethods.Ftp.ListDirectory;
                                    FtpWebResponse response = (FtpWebResponse)requests.GetResponse();
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

                        string url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{Clave}/{RevisionActual}/{name}";
                        Uri uriResult;
                        bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
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

                }

            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewRevision(
        int RevisionActual, int DocumentoID, string IdObsoleto, string Title, string Description, string Comentarios, string DateEstimated,
        int ResponChange, int OriginChange, string OriginComment, string DescripChange, string Review, string Validation, string Workstations,
        string Preapproval, string FinalSign, IFormFile Original, IFormFile PDF, int IdSeccion)
        {
            var extOriginFile = Path.GetExtension(Original.FileName);
            string ext = extOriginFile.Split(".")[1];
            //var date = DateEstimated.ToString("M/dd/yyy");

            var UserInf = _lUsers.getIdUser(User).First();
            List<string> files = new List<string>();
            string error = "";
            var user = "";
            var passworda = "";

            var Obsoleto = IdObsoleto == "on" ? 1 : 0;

            var query = _spContext.spFPAPP_Services_now_DocViewers.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                "@DocumentoID=@DocumentoID, @RevisionActual=@RevisionActual, @Titulo=@Titulo, " +
                "@Comentarios=@Comentarios, @FechaFin=@FechaFin, @ResponsableID=@ResponChange ,@Origen=@OriginChange, " +
                "@OrigenComentario=@OriginComment, @Descripcion=@Descripcion, @DescripcionCambio=@DescripcionCambio, @Revision= @Revision , @Validacion= @Validacion, " +
                "@Estaciones = @Estaciones, @ExtensionFile=@ExtensionFile, @Vobo = @Vobo, " +
                "@Auth = @Auth, @UserID=@UsuarioID, @PlantID = @PlantaID, @Operacion = @Operacion, @Obsoleto=@Obsoleto",
            new object[]
            {
                new SqlParameter("Operacion", 4),
                new SqlParameter("Obsoleto", Obsoleto),
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
                new SqlParameter("PlantaID", UserInf.PlantaId)
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

				valida_path = $"/documentcenter/Planta{UserInf.PlantaId}/documents-center/";
				valida_name = UpFileData.Clave;

				await Create($"/documentcenter/Planta{UserInf.PlantaId}/documents-center/", UpFileData.Clave);
                
                Response.Clear();
                error = null;
				valida_path = $"/documentcenter/Planta{UserInf.PlantaId}/documents-center/{UpFileData.Clave}/";
				valida_name = $"{RevisionActual}";
				await Create($"/documentcenter/Planta{UserInf.PlantaId}/documents-center/{UpFileData.Clave}/", $"{RevisionActual}");
                
                Response.Clear();

                if (error != "" && error != null)
                {
                    if (error == "ExistsFolder")
                    {
                        Response.Clear();
                        error = null;
                        await Upload($"{UpFileData.Clave}{extOriginFile}", Original);
                        valida_name = $"{UpFileData.Clave}{extOriginFile}";
                        await Upload($"{UpFileData.Clave}.PDF", PDF);
                        valida_name = $"{UpFileData.Clave}.PDF";
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
                    valida_name = $"{UpFileData.Clave}{extOriginFile}";
                    await Upload($"{UpFileData.Clave}.PDF", PDF);
                    valida_name = $"{UpFileData.Clave}.PDF";
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

                async Task Create(string path, string name)
                {
                    if (path.Equals(valida_path) && name.Equals(valida_name))
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
                }

                async Task Upload(string name, IFormFile file)
                {
                    if (name.Equals(valida_name))
                    {
                        string url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{UpFileData.Clave}/{RevisionActual}";
                        Uri uriResult;
                        bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                            && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                        if (result == true)
                        {
                            FtpWebRequest requestUpload = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                            try
                            {

                                requestUpload.Credentials = new NetworkCredential(user, passworda);
                                requestUpload.Method = WebRequestMethods.Ftp.ListDirectory;

                                try
                                {
                                    FtpWebResponse response = (FtpWebResponse)requestUpload.GetResponse();
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
                        }

                        url = $"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/documents-center/{UpFileData.Clave}/{RevisionActual}/{name}";
                        bool results = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                            && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                        if (results == true)
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
                }

            }
            else
            {
                return Ok("Error");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateKey(int id, string NewClave, string reviews, string typeFile, int IdSeccion)
        {
            string error = "";
            var user = "";
            var passworda = "";
            var UserInf = _lUsers.getIdUser(User).First();
            var ftp = _lDocControl.GetFtp(UserInf.Id_Usuario);

            if (ftp.Any())
            {
                user = ftp.First().Usuario;
                passworda = ftp.First().Password;
            }

            var quaryUpdate = _spContext.UpdateKey.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer @UserID = @UserID, " +
            "@Clave=@Clave, @Operacion = @Operacion, @DocumentoID = @DocumentoID",
            new object[]
            {
            new SqlParameter("Operacion", 5),
            new SqlParameter("DocumentoID", id),
            new SqlParameter("UserID", UserInf.Id_Usuario),
            new SqlParameter("Clave", NewClave)
            }).AsNoTracking().ToList();



            if (quaryUpdate.Any())
            {
                valida_planta = quaryUpdate.First().PlantaID;
                if (await ExistFolder(null, quaryUpdate.First().ClaveOriginal, quaryUpdate.First().PlantaID))
                {
                    valida_planta = quaryUpdate.First().PlantaID;
                    await RenameFolder(quaryUpdate.First().ClaveOriginal, NewClave, quaryUpdate.First().PlantaID);

                    foreach (var revision in reviews.Split("*"))
                    {
                        valida_planta = quaryUpdate.First().PlantaID;
                        if (await ExistFolder(NewClave, revision, quaryUpdate.First().PlantaID))
                        {
                            foreach (var ext in typeFile.Split("*"))
                            {
                                valida_planta = quaryUpdate.First().PlantaID;
                                if (await ExistFile($"{NewClave}/{revision}", $"{quaryUpdate.First().ClaveOriginal}.{ext}", quaryUpdate.First().PlantaID))
                                {
                                    valida_planta = quaryUpdate.First().PlantaID;
                                    await RenameFile($"{NewClave}/{revision}/{quaryUpdate.First().ClaveOriginal}.{ext}", $"{NewClave}.{ext}", quaryUpdate.First().PlantaID);
                                }
                                if (await ExistFile($"{NewClave}/{revision}", $"{quaryUpdate.First().ClaveOriginal}.pdf", quaryUpdate.First().PlantaID))
                                {
                                    valida_planta = quaryUpdate.First().PlantaID;
                                    await RenameFile($"{NewClave}/{revision}/{quaryUpdate.First().ClaveOriginal}.pdf", $"{NewClave}.pdf", quaryUpdate.First().PlantaID);
                                }
                            }

                        }
                    }
                }
            }


            if (error == "")
            {
                return Ok("Success");
            }
            else
            {
                return Ok("Error");
            }


            async Task<bool> ExistFolder(string? Rute, string? FolderName, int PlantaID)
            {
                if (PlantaID.Equals(valida_planta))
                {
                    string url = $"ftp://10.208.122.234/documentcenter/Planta{PlantaID}/documents-center/{Rute}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    //FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/DocumentsQA/Planta1/documents-center/{Rute}");
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
                else
                {
                    return false;
                }
            }

            async Task RenameFolder(string? FolderName, string? NewName, int PlantaID)
            {
                if (PlantaID.Equals(valida_planta))
                {
                    FileManagerResponse renameResponse = new FileManagerResponse();
                    string url = $"ftp://10.208.122.234/documentcenter/Planta{PlantaID}/documents-center/{FolderName}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        try
                        {
                            //FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{}/documents-center/{FolderName}");
                            request.Credentials = new NetworkCredential(user, passworda);
                            request.Method = WebRequestMethods.Ftp.Rename;
                            request.RenameTo = NewName;
                            using (var response = (FtpWebResponse)request.GetResponse())
                            {
                                FileManagerDirectoryContent item = new FileManagerDirectoryContent();
                                item.Name = NewName;
                                item.IsFile = false;
                                item.DateModified = DateTime.Now;
                                response.Close();
                            }


                        }
                        catch (WebException e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            FtpWebResponse response = (FtpWebResponse)e.Response;
                            if (response.StatusDescription.Contains("exists"))
                            {
                                er.Code = "400";
                                er.Message = "Cannot rename the key destination already exists.";
                            }
                            else
                            {
                                er.Code = "417";
                                er.Message = response.StatusDescription;
                            }
                            response.Close();
                            renameResponse.Error = er;
                            error = er.Message;
                        }
                    }
                }
            }

            async Task<bool> ExistFile(string? Rute, string? FileName, int PlantaID)
            {
                if (PlantaID.Equals(valida_planta))
                {
                    string url = $"ftp://10.208.122.234/documentcenter/Planta{PlantaID}/documents-center/{Rute}";

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

                        var existFolder = ftpFiles.Where(N => N == FileName || N.Equals(FileName, StringComparison.OrdinalIgnoreCase)).ToList();

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
                else
                {
                    return false;
                }
            }

            async Task RenameFile(string? Rute, string? FileName, int PlantaID)
            {
                if (PlantaID.Equals(valida_planta))
                {
                    FileManagerResponse renameResponse = new FileManagerResponse();
                    string url = $"ftp://10.208.122.234/documentcenter/Planta{PlantaID}/documents-center/{Rute}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                        try
                        {
                            
                            //FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/DocumentsQA/Planta{}/documents-center/{Rute}");
                            request.Credentials = new NetworkCredential(user, passworda);
                            request.Method = WebRequestMethods.Ftp.Rename;
                            request.RenameTo = FileName;
                            using (var response = (FtpWebResponse)request.GetResponse())
                            {
                                FileManagerDirectoryContent item = new FileManagerDirectoryContent();
                                item.Name = FileName;
                                item.IsFile = true;
                                item.DateModified = DateTime.Now;
                                response.Close();
                            }

                        }
                        catch (WebException e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            FtpWebResponse response = (FtpWebResponse)e.Response;
                            if (response.StatusDescription.Contains("exists"))
                            {
                                er.Code = "400";
                                er.Message = "Cannot rename the key destination already exists.";
                            }
                            else
                            {
                                er.Code = "417";
                                er.Message = response.StatusDescription;
                            }
                            response.Close();
                            renameResponse.Error = er;
                            error = er.Message;
                        }
                    }
                }
            }
        }


    }
}
