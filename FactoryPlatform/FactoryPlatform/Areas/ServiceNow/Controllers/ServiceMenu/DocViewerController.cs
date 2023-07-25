using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Areas.ServiceNow.Pages.Account;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlatform.Areas.ServiceNow.Controllers
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]
    public class DocViewerController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LPendingTask _lPendingTask;
        private readonly LServiceNow _ServiceNow;
        private readonly LDigitalDocs _lDigitalDocs;
        private LDocumentControl _lDocControl;
        private readonly IHostingEnvironment _hostingEnvironment;

        public static int valida_planta = 0;
        public static int valida_documentoid = 0;
        public DocViewerController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext, IHostingEnvironment hostingEnvironment)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DocViewerComboData(int plant, int IdMenuService ,int Departamento)
        {
            string jsonDatos = "";
            var listUser = _lUsers.getIdUser(User).First();

            var model = new ServiceMenuViewModel();

            model.DocViewerViewModel = _ServiceNow.SecondCombosDocViewer(listUser.Id_Usuario, plant, Departamento);
            jsonDatos = JsonConvert.SerializeObject(model.DocViewerViewModel);

            return Ok(jsonDatos);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetDocumentList(int Planta, int Departamento, int Estacion, int TipoDocumento, string Clave, string Titulo, string Descripcion, string IdMenuService)
        {
            var UserInf = _lUsers.getIdUser(User).First();

            string JsonResult = "";

            var listDocs = _SpContext.spFPAPP_Services_now_DocViewer_DocumentViewerListInfo.FromSqlRaw("EXEC spFPAPP_Services_now_DocViewer " +
                "@Operacion = @Operacion, " +
                "@UserID = @UserID, " +
                "@PlantID = @PlantID, " +
                "@Clave = @Clave, " +
                "@Titulo = @Titulo, " +
                "@Descripcion = @Descripcion, " +
                "@Estacion = @Estacion, " +
                "@Departamento = @Departamento, " +
                "@TipoDocumento = @TipoDocumento"
            , new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("UserID", UserInf.Id_Usuario),
                new SqlParameter("PlantID", Planta == 0 ? UserInf.PlantaId : Planta),
                new SqlParameter("Clave", Clave ),
                new SqlParameter("Titulo", Titulo ),
                new SqlParameter("Descripcion", Descripcion),
                new SqlParameter("Estacion", Estacion ),
                new SqlParameter("TipoDocumento", TipoDocumento),
                new SqlParameter("Departamento", Departamento)
        }).AsNoTracking().ToList();

            if (listDocs.Count > 0)
            {
                JsonResult = JsonConvert.SerializeObject(listDocs);
                return Ok(JsonResult);
            }
            else
            {
                return Ok("NoData");
            }
        }

        //Maping Rute 
        public List<string> MapRute(int? PlantaId, int DocID, int opcion, string? CodigoMedio)
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


            FtpWebRequest request = null;

            switch (opcion)
            {
                case 1:
                    request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/photocenter/Planta{PlantaId}/customerVoice/{DocID}/large");
                    break;
                case 2:
                    request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/photocenter/Planta{PlantaId}/fanp/{CodigoMedio}/{DocID}/Step1");
                    break;
                case 3:
                    request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/photocenter/Planta{PlantaId}/fanp/{CodigoMedio}/{DocID}/Step3");
                    break;
                case 4:
                    request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/photocenter/Planta{PlantaId}/fanp/{CodigoMedio}/{DocID}/Step4");
                    break;
            }

            request.Credentials = new NetworkCredential(user, passworda);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            if (PlantaId.Equals(valida_planta) && DocID.Equals(valida_documentoid))
            {
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
                    reader = null;
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


        [HttpGet]
        public IActionResult ExportToPDF()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExportToPDF(int DigitalID, int TipoDigital, string Ruta, int PlantaID, int NewWind, int Print)
        {
            var model = new DigitalDocumentsModel();

            String JsonData = "";
            var UserInf = _lUsers.getIdUser(User).First();
            switch (TipoDigital)
            {
                case 1:
                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsFeasibilityModel.DigitalDocumentsFeasibility.Count > 0)
                    {
                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsFeasibilityModel);
                    }
                    break;
                case 2:
                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsCustomerVoiceModel.CustomerVoice.Count > 0)
                    {

                        if (model.DigitalDocumentsCustomerVoiceModel.CustomerVoice_Signatures.First().TipoDoc == 3)
                        {
                            valida_planta = (int)model.DigitalDocumentsCustomerVoiceModel.CustomerVoice_Signatures.First().PlantaID;
                            valida_documentoid = DigitalID;
                            model.DigitalDocumentsCustomerVoiceModel.ftpFiles = MapRute(model.DigitalDocumentsCustomerVoiceModel.CustomerVoice_Signatures.First().PlantaID, DigitalID, 1, null);

                        }

                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsCustomerVoiceModel);
                    }

                    break;
                case 3:
                    break;
                case 4:
                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsDesviationModel.Count > 0)
                    {
                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsDesviationModel.First());
                    }
                    break;
                case 5:
                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentAMEF_Model.Count > 0)
                    {
                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentAMEF_Model.First());
                    }
                    break;
                case 6:
                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsReleaseModel.ReleaseInfoDocument.Count > 0)
                    {
                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsReleaseModel);
                    }

                    break;
                case 7:
                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsToolListModel.ToolListModel.Count > 0)
                    {
                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsToolListModel);
                    }

                    break;
                case 8:

                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsOpenIssuesModel.DigitalDocumentsOpenIssues.Count > 0)
                    {
                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsOpenIssuesModel);
                    }

                    break;

                case 9:

                    model = _lDigitalDocs.GetDigitalDocuments(TipoDigital, DigitalID, UserInf.Id_Usuario);

                    if (model.DigitalDocumentsANPModel.ANP_Signatures.Count > 0)
                    {
                        valida_planta = (int)model.DigitalDocumentsANPModel.ANP_Signatures.First().PlantaID;
                        valida_documentoid = DigitalID;
                        model.DigitalDocumentsANPModel.DatosEntrada = MapRute(model.DigitalDocumentsANPModel.ANP_Signatures.First().PlantaID, DigitalID, 2, model.DigitalDocumentsANPModel.ANP_Signatures.First().CodigoMedioR).ToList();
                        model.DigitalDocumentsANPModel.Mediciones = MapRute(model.DigitalDocumentsANPModel.ANP_Signatures.First().PlantaID, DigitalID, 3, model.DigitalDocumentsANPModel.ANP_Signatures.First().CodigoMedioR).ToList();
                        model.DigitalDocumentsANPModel.Conclusiones = MapRute(model.DigitalDocumentsANPModel.ANP_Signatures.First().PlantaID, DigitalID, 4, model.DigitalDocumentsANPModel.ANP_Signatures.First().CodigoMedioR).ToList();


                        JsonData = JsonConvert.SerializeObject(model.DigitalDocumentsANPModel);
                    }

                    break;
            }

            //Initialize HTML to PDF converter with Blink rendering engine 
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);
            BlinkConverterSettings settings = new BlinkConverterSettings();

            //Set the BlinkBinaries folder path 
            settings.BlinkPath = Path.Combine(_hostingEnvironment.ContentRootPath, "BlinkBinariesWindows");

            //Assign Blink settings to HTML converter
            htmlConverter.ConverterSettings = settings;


            //Convert URL to PDF
            switch (TipoDigital)
            {
                case 1:
                    feasibilityPDFModel._dataFeasibility = JsonData;
                    break;
                case 2:
                    customerVoice_PDFModel._dataCustomerVoice = JsonData;
                    break;
                case 4:
                    deviationPDFModel._dataDesviation = JsonData;
                    break;
                case 5:
                    amef_PDFModel._dataAMEF = JsonData;
                    break;
                case 6:
                    release_PDFModel._dataRelease = JsonData;
                    break;
                case 7:
                    toolListPDFModel._dataToolList = JsonData;
                    break;
                case 8:
                    openIssues_PDFModel._dataOpenIssues = JsonData;
                    break;
                case 9:
                    anpPDFModel._dataANP = JsonData;
                    break;
            }

            //PdfDocument document = htmlConverter.Convert($"https://localhost:44378/factoryplatform/servicenow/{Ruta}");
            PdfDocument document = htmlConverter.Convert($"https://mxesc1vapp001/FactoryPlatform/ServiceNow/{Ruta}");

            if (Print == 0)
            {
                document.Security.OwnerPassword = "Syncfusion";
                document.Security.Permissions = PdfPermissionsFlags.Default;
                document.Security.Permissions = PdfPermissionsFlags.EditAnnotations;
                document.Security.Permissions = PdfPermissionsFlags.FillFields;
                document.Security.Permissions = PdfPermissionsFlags.AssembleDocument;
            }
            

            MemoryStream stream = new MemoryStream();
                document.Save(stream);

                var filePdf = stream.ToArray();

                document.Close();
                //string base64String = Convert.ToBase64String(filePdf);
                string base64String = Convert.ToBase64String(filePdf, 0, filePdf.Length, 0);

                if (TipoDigital == 9)
                {
                    if (NewWind == 1)
                    {
                        return File(stream.ToArray(), MediaTypeNames.Application.Pdf);
                    }
                    else
                    {
                        return File(stream.ToArray(), System.Net.Mime.MediaTypeNames.Application.Pdf, $"{model.DigitalDocumentsANPModel.ANP_Signatures.First().Codigo}.pdf");
                    }
                }
                else
                {
                    return Ok(base64String);
                }
        }


    }
}
