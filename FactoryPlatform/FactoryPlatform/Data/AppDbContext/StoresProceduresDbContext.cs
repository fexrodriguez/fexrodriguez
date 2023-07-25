using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.CorrectiveActions;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelSequences;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Packaging;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.StopModel;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.UpdModelToSerie;
using FactoryPlatform.Areas.Quality.Models.CorrectiveActions;
using FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelChanges;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureList;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureMatrix;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelsSequencesList;
using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl;
using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.CorrectiveActions;
using FactoryPlatform.Areas.ServiceNow.Models.PendingTask.CorrectiveActions;
using FactoryPlatform.Areas.ServiceNow.Models.ServiceMenu.CorrectiveAction;
using FactoryPlatform.Models;
using FactoryPlatform.Models.StoresGlobal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FactoryPlatform.Data.AppDbContext
{
    public class StoresProceduresDbContext : IdentityDbContext
    {
        static DbContextOptions<StoresProceduresDbContext> _options;
        public StoresProceduresDbContext() : base(_options)
        {

        }
        public StoresProceduresDbContext(DbContextOptions<StoresProceduresDbContext> options)
            : base(options)
        {
            _options = options;
        }
        public DbSet<MainMenuModel> MainMenuModel { get; set; }
        public DbSet<ServicesMenuModel> ServicesMenuModel { get; set; }
        public DbSet<spFPAPP_Sys_menus> spFPAPP_Sys_menus { get; set; }
        public DbSet<spFPAPP_Sys_apps> spFPAPP_Sys_apps { get; set; }
        public DbSet<spFPAPP_Sys_FtpCredencials> spFPAPP_Sys_FtpCredencials { get; set; }
        public DbSet<ExecuteStores> ExecStores { get; set; }
        public DbSet<PaginaInf_Global> PaginaInf_Global { get; set; }


        //-----------------------------------------Documentos---------------------------------------------------------------
        public DbSet<Quality_Docs_DocumentsTypes> Quality_Docs_DocumentsTypes { get; set; }
        public DbSet<spFPAPP_Services_now_DocViewer_DocumentViewerListInfo> spFPAPP_Services_now_DocViewer_DocumentViewerListInfo { get; set; }

        //--DigitalDocs--//
        public DbSet<DigitalDocumentsDesviationModel> DigitalDocuments_Desviations { get; set; }
        public DbSet<DigitalDocumentAMEF_Model> DigitalDocumentAMEF_Model { get; set; }
        public DbSet<DigitalDocumentsOpenIssues> DigitalDocumentsOpenIssuesModel { get; set; }
        public DbSet<DigitalDocumentsOpenIssues_Hallazgo> DigitalDocumentsOpenIssuesModel_Hallazgo { get; set; }
        public DbSet<DigitalDocumentsReleaseQuestions> DigitalDocumentsReleaseQuestions { get; set; }
        public DbSet<DigitalDocumentsReleaseInfoDocument> DigitalDocumentsReleaseInfoDocument { get; set; }
        public DbSet<DigitalDocumentsReleaseAnexB> DigitalDocumentsReleaseAnexB { get; set; }
        public DbSet<DigitalDocumentsFeasibility_Signatures> DigitalDocumentsFeasibility_Signatures { get; set; }
        public DbSet<DigitalDocumentsFeasibility> DigitalDocumentsFeasibility { get; set; }
        public DbSet<DigitalDocumentsToolList> DigitalDocumentsToolList { get; set; }
        public DbSet<DigitalDocumentsToolList_Signatures> DigitalDocumentsToolList_Signatures { get; set; }
        public DbSet<DigitalDocumentsCustomerVoice> DigitalDocumentsCustomerVoice { get; set; }
        public DbSet<DigitalDocumentsCustomerVoice_Signatures> DigitalDocumentsCustomerVoice_Signatures  { get; set; }
        public DbSet<DigitalDocumentsANP> DigitalDocumentsANP { get; set; }
        public DbSet<DigitalDocumentsANP_Signatures> DigitalDocumentsANP_Signatures { get; set; }
        //public DbSet<DigitalDocumentsANP_Desviatios> DigitalDocumentsANP_Desviatios { get; set; }



        //-------------------------------------------------------------------------------------------------------------------

        //-------------------------------------IT Work Orders------------------------------------------------------
        public DbSet<Services_now_WorkOrders_Class> Services_now_WorkOrders_Class { get; set; }
        public DbSet<ITSystems_HardwareReferences> ITSystems_HardwareReferences { get; set; }
        public DbSet<Production_Departments> Production_Departments { get; set; }
        public DbSet<Production_Stations> Production_Stations { get; set; }
        public DbSet<Services_Factories> Services_Factories { get; set; }
        public DbSet<TypeWorkOrder> TypeWorkOrder { get; set; }
        public DbSet<Services_now_WorkOrders> Services_now_WorkOrders { get; set; }
        public DbSet<Maintenance_EquipmentMachinery> Maintenance_EquipmentMachinery { get; set; }

        //-----------------------------------------------------------------------------------------------------------

        public DbSet<DocumentTrainingModel> DocumentTrainingModel { get; set; }
        public DbSet<DocumentTrainingStep1> DocumentTrainingStep1 { get; set; }


        //--------------------------------------------------------------------


        //Quality control

        public DbSet<spFPAPP_Sys_SectionPages> spFPAPP_Sys_SectionPages { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_Assembled> spFPAPP_QualityControl_ModelFeatures_Assembled { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_SaveFeature> spFPAPP_QualityControl_ModelFeatures_SaveFeature { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_ValidationMissingAssamble> spFPAPP_QualityControl_ModelFeatures_ValidationMissingAssamble { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_DesviationTags> spFPAPP_QualityControl_ModelFeatures_DesviationTags { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_ModelStatus> spFPAPP_QualityControl_ModelFeatures_ModelStatus { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_RecoveryComponets> spFPAPP_QualityControl_ModelFeatures_RecoveryComponets { get; set; }
        public DbSet<spFPAPP_QualityControl_ModelFeatures_ValidateModelTags> spFPAPP_QualityControl_ModelFeatures_ValidateModelTags { get; set; }


        //PhotoCenter 
        public DbSet<spFPAPP_PhotoCenter_ValidateStopModel> spFPAPP_PhotoCenter_ValidateStopModel { get; set; }
        public DbSet<spFPAPP_PhotoCenter_Insert_MotorsMultiplant> spFPAPP_PhotoCenter_Insert_MotorsMultiplant { get; set; }

        //DocumentControl
        public DbSet<StoresDocumentList> DocumentList { get; set; }
        public DbSet<DocumentList_Signature> DocumentList_Signature { get; set; }
        public DbSet<DocumentsKeys> DocumentsKeys { get; set; }
        public DbSet<Keys_longitud> Keys_longitud { get; set; }
        public DbSet<CheckQualityDocs> CheckQualityDocs { get; set; }
        public DbSet<UsersReponsables> UsersReponsables { get; set; }
        public DbSet<AffectedDocuments> AffectedDocuments { get; set; }
        public DbSet<spFPAPP_Services_now_DocViewers> spFPAPP_Services_now_DocViewers { get; set; }
        public DbSet<DocList_DocInf> DocList_DocInf { get; set; }
        public DbSet<UpdateKey> UpdateKey { get; set; }


        //DocEdition
        public DbSet<DocsEditStoreModel> DocsEditStoreModel { get; set; }

        //PreApproval 
        public DbSet<PreApprovalModel> PreApprovalModel { get; set; }
        
        //FinalSignature
        public DbSet<FinalSignatureModel> FinalSignatureModel { get; set; }
        
        //DocsStructure
        public DbSet<DocsStructureModel> DocsStructureModel { get; set; }

        //Corrective action
        public DbSet<SelectOptionsCA> SelectOptionsCA { get; set; }
        public DbSet<TMReportCorrectiveAction> TMReportCorrectiveAction { get; set; }
        public DbSet<TMInfoModalCorrectiveAction> TMInfoModalCA{ get; set; }
        public DbSet<TMInfoReturnCorrectiveA> TMInfoReturnCorrectiveA { get; set; }
        public DbSet<CA_List_Combos> CA_List_Combos { get; set; }
        public DbSet<Report_CorrectiveAction_List> Report_CorrectiveAction_List { get; set; }

        public DbSet<CA_Responsible_CP> CA_Responsible_CP { get; set; }
        public DbSet<CA_ResponsiblesManagements_CP> CA_ResponsiblesManagements_CP  { get; set; }
        public DbSet<Quality_Processes_CP> Quality_Processes_CP { get; set; }
        public DbSet<Chart_CA> Chart_CA { get; set; }
        public DbSet<ReportChart_CA> ReportChart_CA { get; set; }

        //Anp Control 
        public DbSet<ReportAnpControl> ReportAnpControl { get; set; }
        public DbSet<AnpListUsers> AnpListUsers { get; set; }
		public DbSet<AnpListReasingUsers> AnpListReasingUsers { get; set; }
		public DbSet<AnpListUnits> AnpListUnits { get; set; }
		public DbSet<ReportAnpControlInformation> ReportAnpControlInformation { get; set; }
        public DbSet<ReportAnpControlInformationTable> ReportAnpControlInformationTable { get; set; }
		public DbSet<ReportAnpStep1Info> ReportAnpStep1Info { get; set; }
		public DbSet<ReportAnpStep1AttrInspection> ReportAnpStep1AttrInspection { get; set; }
        public DbSet<ReportAnpStep1DimensionalInspect> ReportAnpStep1DimensionalInspect { get; set; }
		public DbSet<ReportAnpStep1DimensionalSpecifications> ReportAnpStep1DimensionalSpecifications { get; set; }
        public DbSet<ReportAnpHistoryModal> ReportAnpHistoryModal { get; set; }
		public DbSet<AnpInfoWarranty> AnpInfoWarranty { get; set; }
		


		//========================================== Models =====================================================
		public DbSet<SelectOptionsModels> SelectOptionsModels { get; set; }
        public DbSet<CP_ModelsFamily> CP_ModelsFamily { get; set; }
        public DbSet<CP_ReportModels> CP_ReportModels { get; set; }

        //============================================Model Features
        public DbSet<CP_Q_ModelFeature> CP_Q_ModelFeature { get; set; }
        //============================================Update model to serie
        public DbSet<CP_SerieSearch> CP_SerieSearch { get; set; }
        
        //============================================Stop Models
        public DbSet<CP_Stopeds> CP_Stopeds { get; set; }
        
        //============================================Packaging
        public DbSet<PackagingLists> PackagingLists { get; set; }
        public DbSet<CP_TubBase> CP_TubBase { get; set; }
        //============================================Model Sequences
		public DbSet<CP_MSequencesModel> CP_MSequencesModel { get; set; }
        
        //============================================Report Model Feature List
		public DbSet<R_ModelFeatureList> R_ModelFeatureList { get; set; }

        //============================================Report Model Secuences List
		public DbSet<R_Secuence> R_Secuence { get; set; }
		//============================================Report Model Feature Record
		public DbSet<R_ModelRecordFeatureList> R_ModelRecordFeatureList { get; set; }
		//============================================Report Model Changes
		public DbSet<R_ModelChangesList> R_ModelChangesList { get; set; }
		//============================================Report Model Feature Matrix
		public DbSet<R_ModelFeatureMatrixList> R_ModelFeatureMatrixList { get; set; }



	}
}
