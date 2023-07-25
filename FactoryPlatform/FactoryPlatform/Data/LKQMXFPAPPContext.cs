using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LKQMXFPAPPContext : DbContext
    {
        public LKQMXFPAPPContext()
        {
        }

        public LKQMXFPAPPContext(DbContextOptions<LKQMXFPAPPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdministrationProviders> AdministrationProviders { get; set; }
        public virtual DbSet<Administrators> Administrators { get; set; }
        public virtual DbSet<AdministratorsValidationSession> AdministratorsValidationSession { get; set; }
        public virtual DbSet<CatPicEntry> CatPicEntry { get; set; }
        public virtual DbSet<CatPicLine> CatPicLine { get; set; }
        public virtual DbSet<CatPicLocation> CatPicLocation { get; set; }
        public virtual DbSet<CatPicProduct> CatPicProduct { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<EngineeringApqpProjects> EngineeringApqpProjects { get; set; }
        public virtual DbSet<EngineeringApqpProjectsBackup> EngineeringApqpProjectsBackup { get; set; }
        public virtual DbSet<EngineeringApqpProjectsPoints> EngineeringApqpProjectsPoints { get; set; }
        public virtual DbSet<EngineeringApqpProjectsSelectedPoints> EngineeringApqpProjectsSelectedPoints { get; set; }
        public virtual DbSet<EngineeringApqpProjectsSelectedPointsBackup> EngineeringApqpProjectsSelectedPointsBackup { get; set; }
        public virtual DbSet<EngineeringApqpResponsibles> EngineeringApqpResponsibles { get; set; }
        public virtual DbSet<EngineeringComponents> EngineeringComponents { get; set; }
        public virtual DbSet<EngineeringComponentsBom> EngineeringComponentsBom { get; set; }
        public virtual DbSet<EngineeringComponentsFeatureTypes> EngineeringComponentsFeatureTypes { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesAttributes> EngineeringComponentsFeaturesAttributes { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesBom> EngineeringComponentsFeaturesBom { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesDimensional> EngineeringComponentsFeaturesDimensional { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesSpecifications> EngineeringComponentsFeaturesSpecifications { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesSpecificationsDetails> EngineeringComponentsFeaturesSpecificationsDetails { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesSpecificationsRejects> EngineeringComponentsFeaturesSpecificationsRejects { get; set; }
        public virtual DbSet<EngineeringComponentsFeaturesWorkStations> EngineeringComponentsFeaturesWorkStations { get; set; }
        public virtual DbSet<EngineeringComponentsProduct> EngineeringComponentsProduct { get; set; }
        public virtual DbSet<EngineeringComponentsProductSpecifications> EngineeringComponentsProductSpecifications { get; set; }
        public virtual DbSet<EngineeringCustomerVoice> EngineeringCustomerVoice { get; set; }
        public virtual DbSet<EngineeringCustomerVoiceQuestions> EngineeringCustomerVoiceQuestions { get; set; }
        public virtual DbSet<EngineeringCustomerVoiceQuestionsLog> EngineeringCustomerVoiceQuestionsLog { get; set; }
        public virtual DbSet<EngineeringCustomerVoiceResults> EngineeringCustomerVoiceResults { get; set; }
        public virtual DbSet<EngineeringFanp> EngineeringFanp { get; set; }
        public virtual DbSet<EngineeringFanpCharacteristics> EngineeringFanpCharacteristics { get; set; }
        public virtual DbSet<EngineeringFanpInputData> EngineeringFanpInputData { get; set; }
        public virtual DbSet<EngineeringFanpInputDataLevel1> EngineeringFanpInputDataLevel1 { get; set; }
        public virtual DbSet<EngineeringFanpInputDataLevel1Add> EngineeringFanpInputDataLevel1Add { get; set; }
        public virtual DbSet<EngineeringFanpInputDataLevel2> EngineeringFanpInputDataLevel2 { get; set; }
        public virtual DbSet<EngineeringFanpInputDataLevel2Add> EngineeringFanpInputDataLevel2Add { get; set; }
        public virtual DbSet<EngineeringFanpInputDataLevel3> EngineeringFanpInputDataLevel3 { get; set; }
        public virtual DbSet<EngineeringFanpInputDataLevel3Add> EngineeringFanpInputDataLevel3Add { get; set; }
        public virtual DbSet<EngineeringFanpMedicionTestData1> EngineeringFanpMedicionTestData1 { get; set; }
        public virtual DbSet<EngineeringFanpMedicionTestData1Add> EngineeringFanpMedicionTestData1Add { get; set; }
        public virtual DbSet<EngineeringFanpMedicionTestData2> EngineeringFanpMedicionTestData2 { get; set; }
        public virtual DbSet<EngineeringFanpMedicionTestData2Add> EngineeringFanpMedicionTestData2Add { get; set; }
        public virtual DbSet<EngineeringFanpTests> EngineeringFanpTests { get; set; }
        public virtual DbSet<EngineeringFanpWarrantyFeaturesStep1> EngineeringFanpWarrantyFeaturesStep1 { get; set; }
        public virtual DbSet<EngineeringFanpWarrantyFeaturesStep2> EngineeringFanpWarrantyFeaturesStep2 { get; set; }
        public virtual DbSet<EngineeringFanpWarrantyFeaturesStep3> EngineeringFanpWarrantyFeaturesStep3 { get; set; }
        public virtual DbSet<EngineeringFanpWarrantyFeaturesStep4> EngineeringFanpWarrantyFeaturesStep4 { get; set; }
        public virtual DbSet<EngineeringFeasibilitySheet> EngineeringFeasibilitySheet { get; set; }
        public virtual DbSet<EngineeringFeasibilitySheetQuestions> EngineeringFeasibilitySheetQuestions { get; set; }
        public virtual DbSet<EngineeringFeasibilitySheetQuestionsLog> EngineeringFeasibilitySheetQuestionsLog { get; set; }
        public virtual DbSet<EngineeringFeasibilitySheetResults> EngineeringFeasibilitySheetResults { get; set; }
        public virtual DbSet<EngineeringMeasurementUnits> EngineeringMeasurementUnits { get; set; }
        public virtual DbSet<EngineeringOpenIssues> EngineeringOpenIssues { get; set; }
        public virtual DbSet<EngineeringOpenIssuesList> EngineeringOpenIssuesList { get; set; }
        public virtual DbSet<EngineeringOpenIssuesRejects> EngineeringOpenIssuesRejects { get; set; }
        public virtual DbSet<EngineeringOpenIssuesReviews> EngineeringOpenIssuesReviews { get; set; }
        public virtual DbSet<EngineeringProjects> EngineeringProjects { get; set; }
        public virtual DbSet<EngineeringProjectsDocuments> EngineeringProjectsDocuments { get; set; }
        public virtual DbSet<EngineeringProjectsDocumentsReviews> EngineeringProjectsDocumentsReviews { get; set; }
        public virtual DbSet<EngineeringProjectsPhases> EngineeringProjectsPhases { get; set; }
        public virtual DbSet<EngineeringProjectsPhasesPoints> EngineeringProjectsPhasesPoints { get; set; }
        public virtual DbSet<EngineeringProjectsReviews> EngineeringProjectsReviews { get; set; }
        public virtual DbSet<EngineeringToolChecklist> EngineeringToolChecklist { get; set; }
        public virtual DbSet<EngineeringToolChecklistResults> EngineeringToolChecklistResults { get; set; }
        public virtual DbSet<EngineeringToolChecklistReviews> EngineeringToolChecklistReviews { get; set; }
        public virtual DbSet<EngineeringToolingActivities> EngineeringToolingActivities { get; set; }
        public virtual DbSet<EngineeringToolingDepartament> EngineeringToolingDepartament { get; set; }
        public virtual DbSet<EngineeringToolingStations> EngineeringToolingStations { get; set; }
        public virtual DbSet<EngineeringToolingTemplate> EngineeringToolingTemplate { get; set; }
        public virtual DbSet<EngineeringToolingTemplateDetails> EngineeringToolingTemplateDetails { get; set; }
        public virtual DbSet<EngineeringToolingTemplateDetailsExtra> EngineeringToolingTemplateDetailsExtra { get; set; }
        public virtual DbSet<EstacionesEmp> EstacionesEmp { get; set; }
        public virtual DbSet<Factories> Factories { get; set; }
        public virtual DbSet<FactoriesManufacturing> FactoriesManufacturing { get; set; }
        public virtual DbSet<FinancesAccounts> FinancesAccounts { get; set; }
        public virtual DbSet<FinancesAccountsApprovers> FinancesAccountsApprovers { get; set; }
        public virtual DbSet<FinancesAccountsApproversBudget> FinancesAccountsApproversBudget { get; set; }
        public virtual DbSet<FinancesAccountsApproversPrivileges> FinancesAccountsApproversPrivileges { get; set; }
        public virtual DbSet<FinancesAccountsApproversTemp> FinancesAccountsApproversTemp { get; set; }
        public virtual DbSet<FinancesAccountsApproversTempByAccount> FinancesAccountsApproversTempByAccount { get; set; }
        public virtual DbSet<FinancesAccountsSubAccounts> FinancesAccountsSubAccounts { get; set; }
        public virtual DbSet<FinancesRequisitions> FinancesRequisitions { get; set; }
        public virtual DbSet<FinancesRequisitionsArticles> FinancesRequisitionsArticles { get; set; }
        public virtual DbSet<FinancesRequisitionsAuth> FinancesRequisitionsAuth { get; set; }
        public virtual DbSet<FinancesRequisitionsComments> FinancesRequisitionsComments { get; set; }
        public virtual DbSet<FinancesRequisitionsPurchaseOptions> FinancesRequisitionsPurchaseOptions { get; set; }
        public virtual DbSet<FinancesRequisitionsQuotes> FinancesRequisitionsQuotes { get; set; }
        public virtual DbSet<FinancesRequisitionsReviews> FinancesRequisitionsReviews { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluation> HumanResourcesAdministrativeEvaluation { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationActivities> HumanResourcesAdministrativeEvaluationActivities { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationActivitiesCopy> HumanResourcesAdministrativeEvaluationActivitiesCopy { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationCompetencies> HumanResourcesAdministrativeEvaluationCompetencies { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationCorrectiveActions> HumanResourcesAdministrativeEvaluationCorrectiveActions { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationFactors> HumanResourcesAdministrativeEvaluationFactors { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationFactorsResults> HumanResourcesAdministrativeEvaluationFactorsResults { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationRegister> HumanResourcesAdministrativeEvaluationRegister { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationReview> HumanResourcesAdministrativeEvaluationReview { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationStrategicPlanning> HumanResourcesAdministrativeEvaluationStrategicPlanning { get; set; }
        public virtual DbSet<HumanResourcesAdministrativeEvaluationStrategicPlanningResults> HumanResourcesAdministrativeEvaluationStrategicPlanningResults { get; set; }
        public virtual DbSet<HumanResourcesCompetitionFactors> HumanResourcesCompetitionFactors { get; set; }
        public virtual DbSet<HumanResourcesCompetitionFactorsChangeLevels> HumanResourcesCompetitionFactorsChangeLevels { get; set; }
        public virtual DbSet<HumanResourcesCompetitionFactorsTests> HumanResourcesCompetitionFactorsTests { get; set; }
        public virtual DbSet<HumanResourcesCompetitionFactorsTestsQuestions> HumanResourcesCompetitionFactorsTestsQuestions { get; set; }
        public virtual DbSet<HumanResourcesCompetitionFactorsTestsQuestionsAnswers> HumanResourcesCompetitionFactorsTestsQuestionsAnswers { get; set; }
        public virtual DbSet<HumanResourcesCourses> HumanResourcesCourses { get; set; }
        public virtual DbSet<HumanResourcesDepartments> HumanResourcesDepartments { get; set; }
        public virtual DbSet<HumanResourcesEmployeesMedical> HumanResourcesEmployeesMedical { get; set; }
        public virtual DbSet<HumanResourcesEmployeesMedicalExams> HumanResourcesEmployeesMedicalExams { get; set; }
        public virtual DbSet<HumanResourcesJobDescription> HumanResourcesJobDescription { get; set; }
        public virtual DbSet<HumanResourcesJobDescriptionConcepts> HumanResourcesJobDescriptionConcepts { get; set; }
        public virtual DbSet<HumanResourcesJobDescriptionProfile> HumanResourcesJobDescriptionProfile { get; set; }
        public virtual DbSet<HumanResourcesJobDescriptionResponsibility> HumanResourcesJobDescriptionResponsibility { get; set; }
        public virtual DbSet<HumanResourcesMatrixSkills> HumanResourcesMatrixSkills { get; set; }
        public virtual DbSet<HumanResourcesMedicalExams> HumanResourcesMedicalExams { get; set; }
        public virtual DbSet<HumanResourcesRequisicionPersonal> HumanResourcesRequisicionPersonal { get; set; }
        public virtual DbSet<HumanResourcesRequisicionPersonalCompetencies> HumanResourcesRequisicionPersonalCompetencies { get; set; }
        public virtual DbSet<HumanResourcesRequisicionPersonalReturn> HumanResourcesRequisicionPersonalReturn { get; set; }
        public virtual DbSet<HumanResourcesRequisicionPersonalReview> HumanResourcesRequisicionPersonalReview { get; set; }
        public virtual DbSet<HumanResourcesRequisicionPersonalsRejects> HumanResourcesRequisicionPersonalsRejects { get; set; }
        public virtual DbSet<HumanResourcesSurveys> HumanResourcesSurveys { get; set; }
        public virtual DbSet<HumanResourcesSurveysCategories> HumanResourcesSurveysCategories { get; set; }
        public virtual DbSet<HumanResourcesSurveysCuestions> HumanResourcesSurveysCuestions { get; set; }
        public virtual DbSet<HumanResourcesSurveysCuestionsOrden> HumanResourcesSurveysCuestionsOrden { get; set; }
        public virtual DbSet<HumanResourcesSurveysCuestionsResp10012020> HumanResourcesSurveysCuestionsResp10012020 { get; set; }
        public virtual DbSet<HumanResourcesSurveysDimensions> HumanResourcesSurveysDimensions { get; set; }
        public virtual DbSet<HumanResourcesSurveysDimensionsResp10012020> HumanResourcesSurveysDimensionsResp10012020 { get; set; }
        public virtual DbSet<HumanResourcesSurveysDomains> HumanResourcesSurveysDomains { get; set; }
        public virtual DbSet<HumanResourcesSurveysResults> HumanResourcesSurveysResults { get; set; }
        public virtual DbSet<HumanResourcesSurveysResults2019> HumanResourcesSurveysResults2019 { get; set; }
        public virtual DbSet<HumanResourcesSurveysResults2020> HumanResourcesSurveysResults2020 { get; set; }
        public virtual DbSet<HumanResourcesSurveysResultsCategories> HumanResourcesSurveysResultsCategories { get; set; }
        public virtual DbSet<HumanResourcesSurveysResultsDimension> HumanResourcesSurveysResultsDimension { get; set; }
        public virtual DbSet<HumanResourcesSurveysResultsDomains> HumanResourcesSurveysResultsDomains { get; set; }
        public virtual DbSet<HumanResourcesSurveysResultsPreview> HumanResourcesSurveysResultsPreview { get; set; }
        public virtual DbSet<HumanResourcesSurveysResultsResp16102020> HumanResourcesSurveysResultsResp16102020 { get; set; }
        public virtual DbSet<HumanResourcesTrainingBusinessUnit> HumanResourcesTrainingBusinessUnit { get; set; }
        public virtual DbSet<HumanResourcesTrainingEmployeesTests> HumanResourcesTrainingEmployeesTests { get; set; }
        public virtual DbSet<HumanResourcesTrainingEmployeesTestsResults> HumanResourcesTrainingEmployeesTestsResults { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperations> HumanResourcesTrainingRequestOperations { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsAuditIpp> HumanResourcesTrainingRequestOperationsAuditIpp { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsAuditPreControl> HumanResourcesTrainingRequestOperationsAuditPreControl { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsAuditWarranties> HumanResourcesTrainingRequestOperationsAuditWarranties { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsCancel> HumanResourcesTrainingRequestOperationsCancel { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsDocs> HumanResourcesTrainingRequestOperationsDocs { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsFails> HumanResourcesTrainingRequestOperationsFails { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsGages> HumanResourcesTrainingRequestOperationsGages { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsMachineReviews> HumanResourcesTrainingRequestOperationsMachineReviews { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsReviews> HumanResourcesTrainingRequestOperationsReviews { get; set; }
        public virtual DbSet<HumanResourcesTrainingRequestOperationsSecurityEquipment> HumanResourcesTrainingRequestOperationsSecurityEquipment { get; set; }
        public virtual DbSet<ImportUsers> ImportUsers { get; set; }
        public virtual DbSet<ItsystemsAdministrators> ItsystemsAdministrators { get; set; }
        public virtual DbSet<ItsystemsHardwareReferences> ItsystemsHardwareReferences { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesFiles> ItsystemsHardwareReferencesFiles { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesHistoryStatus> ItsystemsHardwareReferencesHistoryStatus { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesHistoryUpdate> ItsystemsHardwareReferencesHistoryUpdate { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesHistoryWorkStations> ItsystemsHardwareReferencesHistoryWorkStations { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesManufacturer> ItsystemsHardwareReferencesManufacturer { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesModels> ItsystemsHardwareReferencesModels { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesStatus> ItsystemsHardwareReferencesStatus { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesTabSections> ItsystemsHardwareReferencesTabSections { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesTabSectionsLinkedUsers> ItsystemsHardwareReferencesTabSectionsLinkedUsers { get; set; }
        public virtual DbSet<ItsystemsHardwareReferencesTypes> ItsystemsHardwareReferencesTypes { get; set; }
        public virtual DbSet<ItsystemsServices> ItsystemsServices { get; set; }
        public virtual DbSet<ItsystemsServicesTypes> ItsystemsServicesTypes { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<LogisiticsFanpWarranty> LogisiticsFanpWarranty { get; set; }
        public virtual DbSet<LogisiticsFanpWarrantyFeatures> LogisiticsFanpWarrantyFeatures { get; set; }
        public virtual DbSet<LogisiticsItemsCriticalParts> LogisiticsItemsCriticalParts { get; set; }
        public virtual DbSet<LogisiticsItemsMiddleCode> LogisiticsItemsMiddleCode { get; set; }
        public virtual DbSet<LogisiticsProviders> LogisiticsProviders { get; set; }
        public virtual DbSet<LogisiticsProvidersItems> LogisiticsProvidersItems { get; set; }
        public virtual DbSet<LogisiticsProvidersItemsResp031121> LogisiticsProvidersItemsResp031121 { get; set; }
        public virtual DbSet<LogisiticsProvidersItemsResp041121> LogisiticsProvidersItemsResp041121 { get; set; }
        public virtual DbSet<LogisiticsProvidersResp041121> LogisiticsProvidersResp041121 { get; set; }
        public virtual DbSet<LogisiticsProvidersUpd> LogisiticsProvidersUpd { get; set; }
        public virtual DbSet<LogisiticsPurchasesCtrlPanelTabs> LogisiticsPurchasesCtrlPanelTabs { get; set; }
        public virtual DbSet<LogisiticsPurchasesCtrlPanelTabsUsers> LogisiticsPurchasesCtrlPanelTabsUsers { get; set; }
        public virtual DbSet<LogisiticsRequestNewProduct> LogisiticsRequestNewProduct { get; set; }
        public virtual DbSet<LogisiticsRequestNewProductAssembled> LogisiticsRequestNewProductAssembled { get; set; }
        public virtual DbSet<LogisiticsRequestNewProductAssembledModels> LogisiticsRequestNewProductAssembledModels { get; set; }
        public virtual DbSet<LogisiticsRequestNewProductPrioritys> LogisiticsRequestNewProductPrioritys { get; set; }
        public virtual DbSet<LogisiticsRequestNewProductPrioritysQy> LogisiticsRequestNewProductPrioritysQy { get; set; }
        public virtual DbSet<LogisiticsRequestNewProductReviews> LogisiticsRequestNewProductReviews { get; set; }
        public virtual DbSet<LogisiticsRequestNewProductStepsResponsible> LogisiticsRequestNewProductStepsResponsible { get; set; }
        public virtual DbSet<LogisticsMarchingReport> LogisticsMarchingReport { get; set; }
        public virtual DbSet<LogisticsMarchingReport11082021> LogisticsMarchingReport11082021 { get; set; }
        public virtual DbSet<LogisticsMarchingReportBestcore> LogisticsMarchingReportBestcore { get; set; }
        public virtual DbSet<LogisticsMarchingReportCc> LogisticsMarchingReportCc { get; set; }
        public virtual DbSet<LogisticsMarchingReportCcintransit> LogisticsMarchingReportCcintransit { get; set; }
        public virtual DbSet<LogisticsMarchingReportCoreConversion> LogisticsMarchingReportCoreConversion { get; set; }
        public virtual DbSet<LogisticsMarchingReportCores> LogisticsMarchingReportCores { get; set; }
        public virtual DbSet<LogisticsMarchingReportDelete> LogisticsMarchingReportDelete { get; set; }
        public virtual DbSet<LogisticsMarchingReportInfo> LogisticsMarchingReportInfo { get; set; }
        public virtual DbSet<LogisticsMarchingReportJobsFirm> LogisticsMarchingReportJobsFirm { get; set; }
        public virtual DbSet<LogisticsMarchingReportJobsRelease> LogisticsMarchingReportJobsRelease { get; set; }
        public virtual DbSet<LogisticsMarchingReportProductionReview> LogisticsMarchingReportProductionReview { get; set; }
        public virtual DbSet<LogisticsMarchingReportPt> LogisticsMarchingReportPt { get; set; }
        public virtual DbSet<LogisticsMarchingReportResume> LogisticsMarchingReportResume { get; set; }
        public virtual DbSet<LogisticsMarchingReportStockTarget> LogisticsMarchingReportStockTarget { get; set; }
        public virtual DbSet<LogisticsMarchingReportStockorder> LogisticsMarchingReportStockorder { get; set; }
        public virtual DbSet<LogisticsMarchingReportTransactions> LogisticsMarchingReportTransactions { get; set; }
        public virtual DbSet<LogisticsMarchingReportTransit> LogisticsMarchingReportTransit { get; set; }
        public virtual DbSet<LogisticsMarchingReportTruckAtk> LogisticsMarchingReportTruckAtk { get; set; }
        public virtual DbSet<MaintenanceAdministrators> MaintenanceAdministrators { get; set; }
        public virtual DbSet<MaintenanceEnvironmentalChecklistEquipamentRelease> MaintenanceEnvironmentalChecklistEquipamentRelease { get; set; }
        public virtual DbSet<MaintenanceEnvironmentalChecklistEquipamentReleaseCorrectiveAction> MaintenanceEnvironmentalChecklistEquipamentReleaseCorrectiveAction { get; set; }
        public virtual DbSet<MaintenanceEnvironmentalChecklistEquipamentReleaseQuestions> MaintenanceEnvironmentalChecklistEquipamentReleaseQuestions { get; set; }
        public virtual DbSet<MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResults> MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResults { get; set; }
        public virtual DbSet<MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResultsAnexoB> MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResultsAnexoB { get; set; }
        public virtual DbSet<MaintenanceEnvironmentalChecklistEquipamentReleaseReview> MaintenanceEnvironmentalChecklistEquipamentReleaseReview { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachinery> MaintenanceEquipmentMachinery { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryEvidenceReplace> MaintenanceEquipmentMachineryEvidenceReplace { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryFiles> MaintenanceEquipmentMachineryFiles { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryGroups> MaintenanceEquipmentMachineryGroups { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryHistoryStatus> MaintenanceEquipmentMachineryHistoryStatus { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryHistoryUpdate> MaintenanceEquipmentMachineryHistoryUpdate { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryHistoryWorkStations> MaintenanceEquipmentMachineryHistoryWorkStations { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryManufacturer> MaintenanceEquipmentMachineryManufacturer { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryMultiplant> MaintenanceEquipmentMachineryMultiplant { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryStatus> MaintenanceEquipmentMachineryStatus { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryTabSections> MaintenanceEquipmentMachineryTabSections { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryTabSectionsLinkedUsers> MaintenanceEquipmentMachineryTabSectionsLinkedUsers { get; set; }
        public virtual DbSet<MaintenanceEquipmentMachineryUp> MaintenanceEquipmentMachineryUp { get; set; }
        public virtual DbSet<MaintenanceProcess> MaintenanceProcess { get; set; }
        public virtual DbSet<MaintenanceProcessFiles> MaintenanceProcessFiles { get; set; }
        public virtual DbSet<MaintenanceProcessHistoryNextService> MaintenanceProcessHistoryNextService { get; set; }
        public virtual DbSet<MaintenanceProcessHistoryStatus> MaintenanceProcessHistoryStatus { get; set; }
        public virtual DbSet<MaintenanceProcessHistoryUpdate> MaintenanceProcessHistoryUpdate { get; set; }
        public virtual DbSet<MaintenanceProcessPlanner> MaintenanceProcessPlanner { get; set; }
        public virtual DbSet<MaintenanceProcessPlannerFilesDelete> MaintenanceProcessPlannerFilesDelete { get; set; }
        public virtual DbSet<MaintenanceProcessStatus> MaintenanceProcessStatus { get; set; }
        public virtual DbSet<MaintenanceProcessTabSections> MaintenanceProcessTabSections { get; set; }
        public virtual DbSet<MaintenanceProcessTabSectionsLinkedUsers> MaintenanceProcessTabSectionsLinkedUsers { get; set; }
        public virtual DbSet<MaintenanceProcessTypes> MaintenanceProcessTypes { get; set; }
        public virtual DbSet<MaintenanceServices> MaintenanceServices { get; set; }
        public virtual DbSet<Managements> Managements { get; set; }
        public virtual DbSet<ProductionBomItems> ProductionBomItems { get; set; }
        public virtual DbSet<ProductionBomItemsProviders> ProductionBomItemsProviders { get; set; }
        public virtual DbSet<ProductionBomJobs> ProductionBomJobs { get; set; }
        public virtual DbSet<ProductionBomJobsItems> ProductionBomJobsItems { get; set; }
        public virtual DbSet<ProductionBomJobsModels> ProductionBomJobsModels { get; set; }
        public virtual DbSet<ProductionCells> ProductionCells { get; set; }
        public virtual DbSet<ProductionCoresColumnsDocuments> ProductionCoresColumnsDocuments { get; set; }
        public virtual DbSet<ProductionCoresConfigurations> ProductionCoresConfigurations { get; set; }
        public virtual DbSet<ProductionCoresLog> ProductionCoresLog { get; set; }
        public virtual DbSet<ProductionCoresOptions> ProductionCoresOptions { get; set; }
        public virtual DbSet<ProductionDepartments> ProductionDepartments { get; set; }
        public virtual DbSet<ProductionMaterialSequences> ProductionMaterialSequences { get; set; }
        public virtual DbSet<ProductionMissingItems> ProductionMissingItems { get; set; }
        public virtual DbSet<ProductionMissingItemsCauses> ProductionMissingItemsCauses { get; set; }
        public virtual DbSet<ProductionMissingItemsCodes> ProductionMissingItemsCodes { get; set; }
        public virtual DbSet<ProductionMissingItemsCodesCodes> ProductionMissingItemsCodesCodes { get; set; }
        public virtual DbSet<ProductionMissingItemsCoordinators> ProductionMissingItemsCoordinators { get; set; }
        public virtual DbSet<ProductionMissingItemsCriticalParts> ProductionMissingItemsCriticalParts { get; set; }
        public virtual DbSet<ProductionMissingItemsInv> ProductionMissingItemsInv { get; set; }
        public virtual DbSet<ProductionMissingItemsReviews> ProductionMissingItemsReviews { get; set; }
        public virtual DbSet<ProductionModels> ProductionModels { get; set; }
        public virtual DbSet<ProductionModelsFamilies> ProductionModelsFamilies { get; set; }
        public virtual DbSet<ProductionModelsUpdateModels> ProductionModelsUpdateModels { get; set; }
        public virtual DbSet<ProductionMotors> ProductionMotors { get; set; }
        public virtual DbSet<ProductionMotorsDown> ProductionMotorsDown { get; set; }
        public virtual DbSet<ProductionMotorsHistory> ProductionMotorsHistory { get; set; }
        public virtual DbSet<ProductionMotorsMultiplant> ProductionMotorsMultiplant { get; set; }
        public virtual DbSet<ProductionMotorsMultiplantHistory> ProductionMotorsMultiplantHistory { get; set; }
        public virtual DbSet<ProductionMotorsRecordsLack> ProductionMotorsRecordsLack { get; set; }
        public virtual DbSet<ProductionMotorsSequences> ProductionMotorsSequences { get; set; }
        public virtual DbSet<ProductionQcMotorsSequences> ProductionQcMotorsSequences { get; set; }
        public virtual DbSet<ProductionStations> ProductionStations { get; set; }
        public virtual DbSet<ProductionStationsDocs> ProductionStationsDocs { get; set; }
        public virtual DbSet<ProductionStationsDocsUpdate> ProductionStationsDocsUpdate { get; set; }
        public virtual DbSet<ProductionStationsMachinery> ProductionStationsMachinery { get; set; }
        public virtual DbSet<ProductionStopModels> ProductionStopModels { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<QualityAuditsAuditConcentration> QualityAuditsAuditConcentration { get; set; }
        public virtual DbSet<QualityAuditsAuditDocuments> QualityAuditsAuditDocuments { get; set; }
        public virtual DbSet<QualityAuditsAuditEnvironmentalCulture> QualityAuditsAuditEnvironmentalCulture { get; set; }
        public virtual DbSet<QualityAuditsAuditIlumination> QualityAuditsAuditIlumination { get; set; }
        public virtual DbSet<QualityAuditsAuditIpp> QualityAuditsAuditIpp { get; set; }
        public virtual DbSet<QualityAuditsAuditMatrixAbilities> QualityAuditsAuditMatrixAbilities { get; set; }
        public virtual DbSet<QualityAuditsAuditMeasurementEquipment> QualityAuditsAuditMeasurementEquipment { get; set; }
        public virtual DbSet<QualityAuditsAuditPreControl> QualityAuditsAuditPreControl { get; set; }
        public virtual DbSet<QualityAuditsAuditTeamLeader> QualityAuditsAuditTeamLeader { get; set; }
        public virtual DbSet<QualityAuditsAuditTorques> QualityAuditsAuditTorques { get; set; }
        public virtual DbSet<QualityAuditsAuditWarrantyActions> QualityAuditsAuditWarrantyActions { get; set; }
        public virtual DbSet<QualityAuditsAuditsOpen> QualityAuditsAuditsOpen { get; set; }
        public virtual DbSet<QualityAuditsCharacteristics> QualityAuditsCharacteristics { get; set; }
        public virtual DbSet<QualityAuditsDateRange> QualityAuditsDateRange { get; set; }
        public virtual DbSet<QualityAuditsDepartments> QualityAuditsDepartments { get; set; }
        public virtual DbSet<QualityAuditsInput> QualityAuditsInput { get; set; }
        public virtual DbSet<QualityAuditsInspectors> QualityAuditsInspectors { get; set; }
        public virtual DbSet<QualityAuditsLines> QualityAuditsLines { get; set; }
        public virtual DbSet<QualityAuditsPlanners> QualityAuditsPlanners { get; set; }
        public virtual DbSet<QualityAuditsPlannersCycles> QualityAuditsPlannersCycles { get; set; }
        public virtual DbSet<QualityAuditsPlannersWorkStations> QualityAuditsPlannersWorkStations { get; set; }
        public virtual DbSet<QualityAuditsTemplates> QualityAuditsTemplates { get; set; }
        public virtual DbSet<QualityAuditsTypes> QualityAuditsTypes { get; set; }
        public virtual DbSet<QualityAuditsWarrantyActions> QualityAuditsWarrantyActions { get; set; }
        public virtual DbSet<QualityAuditsWarrantyFamily> QualityAuditsWarrantyFamily { get; set; }
        public virtual DbSet<QualityAuditsWorkStationsByLines> QualityAuditsWorkStationsByLines { get; set; }
        public virtual DbSet<QualityCaClosers> QualityCaClosers { get; set; }
        public virtual DbSet<QualityCaResponsible> QualityCaResponsible { get; set; }
        public virtual DbSet<QualityCaSolutionsTypes> QualityCaSolutionsTypes { get; set; }
        public virtual DbSet<QualityCaSources> QualityCaSources { get; set; }
        public virtual DbSet<QualityCaTools> QualityCaTools { get; set; }
        public virtual DbSet<QualityCauses> QualityCauses { get; set; }
        public virtual DbSet<QualityCheckListAmef> QualityCheckListAmef { get; set; }
        public virtual DbSet<QualityCheckListAmefQuestions> QualityCheckListAmefQuestions { get; set; }
        public virtual DbSet<QualityCheckListAmefQuestionsResults> QualityCheckListAmefQuestionsResults { get; set; }
        public virtual DbSet<QualityCheckListAmefRejects> QualityCheckListAmefRejects { get; set; }
        public virtual DbSet<QualityCheckListAmefReviews> QualityCheckListAmefReviews { get; set; }
        public virtual DbSet<QualityComponents> QualityComponents { get; set; }
        public virtual DbSet<QualityComponentsRecovery> QualityComponentsRecovery { get; set; }
        public virtual DbSet<QualityComponentsRecoveryByModel> QualityComponentsRecoveryByModel { get; set; }
        public virtual DbSet<QualityComponentsRecoveryByProduct> QualityComponentsRecoveryByProduct { get; set; }
        public virtual DbSet<QualityCorrectiveActions> QualityCorrectiveActions { get; set; }
        public virtual DbSet<QualityCorrectiveActionsDelete> QualityCorrectiveActionsDelete { get; set; }
        public virtual DbSet<QualityCorrectiveActionsRejects> QualityCorrectiveActionsRejects { get; set; }
        public virtual DbSet<QualityCorrectiveActionsReviews> QualityCorrectiveActionsReviews { get; set; }
        public virtual DbSet<QualityCorrectiveActionsUpdate> QualityCorrectiveActionsUpdate { get; set; }
        public virtual DbSet<QualityDeviations> QualityDeviations { get; set; }
        public virtual DbSet<QualityDeviationsCapture> QualityDeviationsCapture { get; set; }
        public virtual DbSet<QualityDeviationsEngineering> QualityDeviationsEngineering { get; set; }
        public virtual DbSet<QualityDeviationsModels> QualityDeviationsModels { get; set; }
        public virtual DbSet<QualityDeviationsRejects> QualityDeviationsRejects { get; set; }
        public virtual DbSet<QualityDeviationsReturn> QualityDeviationsReturn { get; set; }
        public virtual DbSet<QualityDeviationsReviews> QualityDeviationsReviews { get; set; }
        public virtual DbSet<QualityDeviationsReviewsAuth> QualityDeviationsReviewsAuth { get; set; }
        public virtual DbSet<QualityDeviationsTagsLog> QualityDeviationsTagsLog { get; set; }
        public virtual DbSet<QualityDeviationsTagsModel> QualityDeviationsTagsModel { get; set; }
        public virtual DbSet<QualityDeviationsTagsModelLog> QualityDeviationsTagsModelLog { get; set; }
        public virtual DbSet<QualityDeviationsWarranty> QualityDeviationsWarranty { get; set; }
        public virtual DbSet<QualityDocsAffectedDocuments> QualityDocsAffectedDocuments { get; set; }
        public virtual DbSet<QualityDocsConfidentialDocsGroups> QualityDocsConfidentialDocsGroups { get; set; }
        public virtual DbSet<QualityDocsConfidentialDocsGroupsDocs> QualityDocsConfidentialDocsGroupsDocs { get; set; }
        public virtual DbSet<QualityDocsConfidentialDocsGroupsUsers> QualityDocsConfidentialDocsGroupsUsers { get; set; }
        public virtual DbSet<QualityDocsDocumentsDigital> QualityDocsDocumentsDigital { get; set; }
        public virtual DbSet<QualityDocsDocumentsKeys> QualityDocsDocumentsKeys { get; set; }
        public virtual DbSet<QualityDocsDocumentsKeysFields> QualityDocsDocumentsKeysFields { get; set; }
        public virtual DbSet<QualityDocsDocumentsTypes> QualityDocsDocumentsTypes { get; set; }
        public virtual DbSet<QualityDocsEmployeesTrainingUpdatedDocs> QualityDocsEmployeesTrainingUpdatedDocs { get; set; }
        public virtual DbSet<QualityDocsFormatsQuantityViewed> QualityDocsFormatsQuantityViewed { get; set; }
        public virtual DbSet<QualityDocsJobsDocs> QualityDocsJobsDocs { get; set; }
        public virtual DbSet<QualityDocsOriginChange> QualityDocsOriginChange { get; set; }
        public virtual DbSet<QualityDocsQuantityViewed> QualityDocsQuantityViewed { get; set; }
        public virtual DbSet<QualityDocsReport> QualityDocsReport { get; set; }
        public virtual DbSet<QualityDocsReviews> QualityDocsReviews { get; set; }
        public virtual DbSet<QualityDocsReviewsActions> QualityDocsReviewsActions { get; set; }
        public virtual DbSet<QualityDocsReviewsAffectedDocs> QualityDocsReviewsAffectedDocs { get; set; }
        public virtual DbSet<QualityDocsReviewsAuth> QualityDocsReviewsAuth { get; set; }
        public virtual DbSet<QualityDocsReviewsCheck> QualityDocsReviewsCheck { get; set; }
        public virtual DbSet<QualityDocsReviewsReleases> QualityDocsReviewsReleases { get; set; }
        public virtual DbSet<QualityDocsReviewsUpdates> QualityDocsReviewsUpdates { get; set; }
        public virtual DbSet<QualityDocsReviewsVoBo> QualityDocsReviewsVoBo { get; set; }
        public virtual DbSet<QualityDocsReviewsVoBosEmailsSent> QualityDocsReviewsVoBosEmailsSent { get; set; }
        public virtual DbSet<QualityDocsUsersAffectedDocs> QualityDocsUsersAffectedDocs { get; set; }
        public virtual DbSet<QualityDocsUsersDocsTypes> QualityDocsUsersDocsTypes { get; set; }
        public virtual DbSet<QualityDocsUsersPrivileges> QualityDocsUsersPrivileges { get; set; }
        public virtual DbSet<QualityDocuments> QualityDocuments { get; set; }
        public virtual DbSet<QualityDocumentsDelete> QualityDocumentsDelete { get; set; }
        public virtual DbSet<QualityEffects> QualityEffects { get; set; }
        public virtual DbSet<QualityEspecialTest> QualityEspecialTest { get; set; }
        public virtual DbSet<QualityEspecialTestRejects> QualityEspecialTestRejects { get; set; }
        public virtual DbSet<QualityEspecialTestReviews> QualityEspecialTestReviews { get; set; }
        public virtual DbSet<QualityEspecialTestSeries> QualityEspecialTestSeries { get; set; }
        public virtual DbSet<QualityEvaluationRisks> QualityEvaluationRisks { get; set; }
        public virtual DbSet<QualityFails> QualityFails { get; set; }
        public virtual DbSet<QualityFailsInProcess> QualityFailsInProcess { get; set; }
        public virtual DbSet<QualityFailsMotoParts> QualityFailsMotoParts { get; set; }
        public virtual DbSet<QualityMetrolGages> QualityMetrolGages { get; set; }
        public virtual DbSet<QualityMetrolGagesCalibration> QualityMetrolGagesCalibration { get; set; }
        public virtual DbSet<QualityMetrolGagesGroups> QualityMetrolGagesGroups { get; set; }
        public virtual DbSet<QualityMetrolGagesStations> QualityMetrolGagesStations { get; set; }
        public virtual DbSet<QualityMetrolGagesStatus> QualityMetrolGagesStatus { get; set; }
        public virtual DbSet<QualityMetrolGagesStatusChanged> QualityMetrolGagesStatusChanged { get; set; }
        public virtual DbSet<QualityModelFeatures> QualityModelFeatures { get; set; }
        public virtual DbSet<QualityModelFeaturesComments> QualityModelFeaturesComments { get; set; }
        public virtual DbSet<QualityModelFeaturesFilesOrder> QualityModelFeaturesFilesOrder { get; set; }
        public virtual DbSet<QualityModelFeaturesLastMultipleUpload> QualityModelFeaturesLastMultipleUpload { get; set; }
        public virtual DbSet<QualityModelFeaturesMissingAssamble> QualityModelFeaturesMissingAssamble { get; set; }
        public virtual DbSet<QualityModelFeaturesMissingAssambleLog> QualityModelFeaturesMissingAssambleLog { get; set; }
        public virtual DbSet<QualityModelFeaturesResults> QualityModelFeaturesResults { get; set; }
        public virtual DbSet<QualityModelFeaturesResultsHistory> QualityModelFeaturesResultsHistory { get; set; }
        public virtual DbSet<QualityModelFeaturesResultsPackaging> QualityModelFeaturesResultsPackaging { get; set; }
        public virtual DbSet<QualityModelFeaturesResultsResp20012022> QualityModelFeaturesResultsResp20012022 { get; set; }
        public virtual DbSet<QualityModelFeaturesResultsResp23012022> QualityModelFeaturesResultsResp23012022 { get; set; }
        public virtual DbSet<QualityModelFeaturesResultsResp25012022> QualityModelFeaturesResultsResp25012022 { get; set; }
        public virtual DbSet<QualityModelFeaturesSinFoto> QualityModelFeaturesSinFoto { get; set; }
        public virtual DbSet<QualityModelFeaturesSubComponents> QualityModelFeaturesSubComponents { get; set; }
        public virtual DbSet<QualityModelFeaturesToUpdate> QualityModelFeaturesToUpdate { get; set; }
        public virtual DbSet<QualityModelStatus> QualityModelStatus { get; set; }
        public virtual DbSet<QualityModelsModelsChanges> QualityModelsModelsChanges { get; set; }
        public virtual DbSet<QualityModelsPackagingHuacales> QualityModelsPackagingHuacales { get; set; }
        public virtual DbSet<QualityModelsPackagingProblems> QualityModelsPackagingProblems { get; set; }
        public virtual DbSet<QualityModelsPackagingTubsBases> QualityModelsPackagingTubsBases { get; set; }
        public virtual DbSet<QualityModelsPackagingTubsInserts> QualityModelsPackagingTubsInserts { get; set; }
        public virtual DbSet<QualityModelsPackagingTubsInsertsWood> QualityModelsPackagingTubsInsertsWood { get; set; }
        public virtual DbSet<QualityModelsPackagingTubsTapas> QualityModelsPackagingTubsTapas { get; set; }
        public virtual DbSet<QualityMonitorRisks> QualityMonitorRisks { get; set; }
        public virtual DbSet<QualityMonitorRisksEvaluation> QualityMonitorRisksEvaluation { get; set; }
        public virtual DbSet<QualityMonitorRisksHistory> QualityMonitorRisksHistory { get; set; }
        public virtual DbSet<QualityMonitorRisksPestel> QualityMonitorRisksPestel { get; set; }
        public virtual DbSet<QualityPerformanceIndicators> QualityPerformanceIndicators { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsAccumulated> QualityPerformanceIndicatorsAccumulated { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsChangescomments> QualityPerformanceIndicatorsChangescomments { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsConcepts> QualityPerformanceIndicatorsConcepts { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsConclusion> QualityPerformanceIndicatorsConclusion { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsDepartaments> QualityPerformanceIndicatorsDepartaments { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsGoals> QualityPerformanceIndicatorsGoals { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsIndicador> QualityPerformanceIndicatorsIndicador { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsNo> QualityPerformanceIndicatorsNo { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsPrivileges> QualityPerformanceIndicatorsPrivileges { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsProcess> QualityPerformanceIndicatorsProcess { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsReal> QualityPerformanceIndicatorsReal { get; set; }
        public virtual DbSet<QualityPerformanceIndicatorsUpdMetric> QualityPerformanceIndicatorsUpdMetric { get; set; }
        public virtual DbSet<QualityPerformanceReportsManufacturing02> QualityPerformanceReportsManufacturing02 { get; set; }
        public virtual DbSet<QualityPerformanceReportsManufacturing02Details> QualityPerformanceReportsManufacturing02Details { get; set; }
        public virtual DbSet<QualityPerformanceReportsManufacturingMaster> QualityPerformanceReportsManufacturingMaster { get; set; }
        public virtual DbSet<QualityPerformanceReportsRma> QualityPerformanceReportsRma { get; set; }
        public virtual DbSet<QualityPerformanceReportsSales> QualityPerformanceReportsSales { get; set; }
        public virtual DbSet<QualityPerformanceReportsWarranty> QualityPerformanceReportsWarranty { get; set; }
        public virtual DbSet<QualityPhotoCenterUpdBackupFolderRecords> QualityPhotoCenterUpdBackupFolderRecords { get; set; }
        public virtual DbSet<QualityProcesses> QualityProcesses { get; set; }
        public virtual DbSet<QualityRmc> QualityRmc { get; set; }
        public virtual DbSet<QualityRmcModels> QualityRmcModels { get; set; }
        public virtual DbSet<QualityRmcPruebas> QualityRmcPruebas { get; set; }
        public virtual DbSet<QualitySuppliersStockAnp> QualitySuppliersStockAnp { get; set; }
        public virtual DbSet<QualitySuppliersStockAnpBias> QualitySuppliersStockAnpBias { get; set; }
        public virtual DbSet<QualitySuppliersStockAnpPartialDelivery> QualitySuppliersStockAnpPartialDelivery { get; set; }
        public virtual DbSet<QualitySuppliersStockAnpReviews> QualitySuppliersStockAnpReviews { get; set; }
        public virtual DbSet<QualitySuppliersStockAnpSytlineExists> QualitySuppliersStockAnpSytlineExists { get; set; }
        public virtual DbSet<QualityUpdateInformation> QualityUpdateInformation { get; set; }
        public virtual DbSet<QualityWarrantiesByMonth> QualityWarrantiesByMonth { get; set; }
        public virtual DbSet<QualityWarrantiesClaims> QualityWarrantiesClaims { get; set; }
        public virtual DbSet<QualityWarrantiesDailyInspection> QualityWarrantiesDailyInspection { get; set; }
        public virtual DbSet<QualityWarrantiesUploadLog> QualityWarrantiesUploadLog { get; set; }
        public virtual DbSet<QualityWorkstations> QualityWorkstations { get; set; }
        public virtual DbSet<QualityWorkstationsLinkToCodesStations> QualityWorkstationsLinkToCodesStations { get; set; }
        public virtual DbSet<ServicesNowPlanners> ServicesNowPlanners { get; set; }
        public virtual DbSet<ServicesNowProjects> ServicesNowProjects { get; set; }
        public virtual DbSet<ServicesNowWorkOrders> ServicesNowWorkOrders { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersClass> ServicesNowWorkOrdersClass { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersClassHistory> ServicesNowWorkOrdersClassHistory { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersComments> ServicesNowWorkOrdersComments { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersCtrlTabSections> ServicesNowWorkOrdersCtrlTabSections { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersCtrlTabSectionsLinkedUsers> ServicesNowWorkOrdersCtrlTabSectionsLinkedUsers { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersJobTime> ServicesNowWorkOrdersJobTime { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersPrivileges> ServicesNowWorkOrdersPrivileges { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersRejects> ServicesNowWorkOrdersRejects { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersReviews> ServicesNowWorkOrdersReviews { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersServiceRatingResults> ServicesNowWorkOrdersServiceRatingResults { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersServiceRatingTypes> ServicesNowWorkOrdersServiceRatingTypes { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersTabSections> ServicesNowWorkOrdersTabSections { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersTabSectionsLinkedUsers> ServicesNowWorkOrdersTabSectionsLinkedUsers { get; set; }
        public virtual DbSet<ServicesNowWorkOrdersTypes> ServicesNowWorkOrdersTypes { get; set; }
        public virtual DbSet<SoftwareConfigAdministrators> SoftwareConfigAdministrators { get; set; }
        public virtual DbSet<SoftwareConfigApps> SoftwareConfigApps { get; set; }
        public virtual DbSet<SoftwareConfigAppsV2> SoftwareConfigAppsV2 { get; set; }
        public virtual DbSet<SoftwareConfigControllersActionMethods> SoftwareConfigControllersActionMethods { get; set; }
        public virtual DbSet<SoftwareConfigDocsMultiplantLinkedUsers> SoftwareConfigDocsMultiplantLinkedUsers { get; set; }
        public virtual DbSet<SoftwareConfigFtpCredencials> SoftwareConfigFtpCredencials { get; set; }
        public virtual DbSet<SoftwareConfigMainMenu> SoftwareConfigMainMenu { get; set; }
        public virtual DbSet<SoftwareConfigMainMenuLinkedUsers> SoftwareConfigMainMenuLinkedUsers { get; set; }
        public virtual DbSet<SoftwareConfigMainMenuTemporaryApprover> SoftwareConfigMainMenuTemporaryApprover { get; set; }
        public virtual DbSet<SoftwareConfigMainMenuTemporaryLog> SoftwareConfigMainMenuTemporaryLog { get; set; }
        public virtual DbSet<SoftwareConfigMainMenuUserPrivileges> SoftwareConfigMainMenuUserPrivileges { get; set; }
        public virtual DbSet<SoftwareConfigPages> SoftwareConfigPages { get; set; }
        public virtual DbSet<SoftwareConfigPagesDetails> SoftwareConfigPagesDetails { get; set; }
        public virtual DbSet<SoftwareConfigPagesUserHistory> SoftwareConfigPagesUserHistory { get; set; }
        public virtual DbSet<SoftwareConfigPagesV2> SoftwareConfigPagesV2 { get; set; }
        public virtual DbSet<SoftwareConfigSections> SoftwareConfigSections { get; set; }
        public virtual DbSet<SoftwareConfigSectionsLinkedUsers> SoftwareConfigSectionsLinkedUsers { get; set; }
        public virtual DbSet<SoftwareConfigSectionsLinkedUsersV2> SoftwareConfigSectionsLinkedUsersV2 { get; set; }
        public virtual DbSet<SoftwareConfigSectionsLinkedUsersV2History> SoftwareConfigSectionsLinkedUsersV2History { get; set; }
        public virtual DbSet<SoftwareConfigSectionsLinkedUsersV2Resp25052022> SoftwareConfigSectionsLinkedUsersV2Resp25052022 { get; set; }
        public virtual DbSet<SoftwareConfigSectionsUserHistory> SoftwareConfigSectionsUserHistory { get; set; }
        public virtual DbSet<SoftwareConfigSectionsV2> SoftwareConfigSectionsV2 { get; set; }
        public virtual DbSet<SoftwareConfigServiceNowActionMethods> SoftwareConfigServiceNowActionMethods { get; set; }
        public virtual DbSet<SoftwareConfigServicesMenu> SoftwareConfigServicesMenu { get; set; }
        public virtual DbSet<SoftwareConfigServicesMenuLinkedUsers> SoftwareConfigServicesMenuLinkedUsers { get; set; }
        public virtual DbSet<SoftwareConfigServicesMenuUserPrivileges> SoftwareConfigServicesMenuUserPrivileges { get; set; }
        public virtual DbSet<SoftwareConfigSubSectionsLinkedUsersV2> SoftwareConfigSubSectionsLinkedUsersV2 { get; set; }
        public virtual DbSet<SoftwareConfigSubSectionsLinkedUsersV2History> SoftwareConfigSubSectionsLinkedUsersV2History { get; set; }
        public virtual DbSet<SoftwareConfigSubSectionsLinkedUsersV2Resp25052022> SoftwareConfigSubSectionsLinkedUsersV2Resp25052022 { get; set; }
        public virtual DbSet<SoftwareConfigSubSectionsV2> SoftwareConfigSubSectionsV2 { get; set; }
        public virtual DbSet<SoftwareConfigUsersSharedTasks> SoftwareConfigUsersSharedTasks { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersImport> UsersImport { get; set; }
        public virtual DbSet<UsersJobs> UsersJobs { get; set; }
        public virtual DbSet<UsersValidationSession> UsersValidationSession { get; set; }
        public virtual DbSet<UsersValidationSessionOut> UsersValidationSessionOut { get; set; }
        public virtual DbSet<VwMenus> VwMenus { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdministrationProviders>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK_HumanResources_Providers");

                entity.ToTable("Administration_Providers");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_Proveedor");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiroProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoEntrega)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoEntrega)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<Administrators>(entity =>
            {
                entity.HasKey(e => e.IdAdministrador);

                entity.Property(e => e.IdAdministrador).HasColumnName("ID_Administrador");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('normal')");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaSecreta)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.RespuestaSecreta)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Administrators)
                    .HasForeignKey(d => d.DepartamentoId)
                    .HasConstraintName("FK_Administrators__Departments");
            });

            modelBuilder.Entity<AdministratorsValidationSession>(entity =>
            {
                entity.HasKey(e => e.ValIdValidacion);

                entity.ToTable("Administrators_ValidationSession");

                entity.Property(e => e.ValIdValidacion).HasColumnName("Val_Id_Validacion");

                entity.Property(e => e.AdministradorId).HasColumnName("AdministradorID");

                entity.Property(e => e.FechaReg)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatPicEntry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BomId).HasColumnName("bom_id");

                entity.Property(e => e.CatPicLineId).HasColumnName("cat_pic_line_id");

                entity.Property(e => e.CatPicLocationId).HasColumnName("cat_pic_location_id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsFixedLength();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameOverride)
                    .HasColumnName("name_override")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CatPicLine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CatPicGroupId).HasColumnName("cat_pic_group_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.PrimaryNumber).HasColumnName("primary_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CatPicLocation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(4000);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CatPicProduct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.IdPais).HasColumnName("ID_Pais");

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.CarpetaSite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IconClass)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IconoMenu)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Iconos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaginaPrincipal)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringApqpProjects>(entity =>
            {
                entity.HasKey(e => e.IdProyecto);

                entity.ToTable("Engineering_APQP_Projects");

                entity.Property(e => e.IdProyecto).HasColumnName("ID_Proyecto");

                entity.Property(e => e.FechaProyecto).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Motor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProyecto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Cancelado; 1 = Activo; 2 =  Retrasado; 3 = Terminado ");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringApqpProjectsBackup>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_APQP_Projects_Backup");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaProyecto).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdProyecto).HasColumnName("ID_Proyecto");

                entity.Property(e => e.Motor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringApqpProjectsPoints>(entity =>
            {
                entity.HasKey(e => e.IdPunto)
                    .HasName("PK_Engineering_APQP_Projects_Phases");

                entity.ToTable("Engineering_APQP_Projects_Points");

                entity.Property(e => e.IdPunto).HasColumnName("ID_Punto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FaseId)
                    .HasColumnName("FaseID")
                    .HasComment("1 = Planeación del desarrollo; 2 = Desarrollo del producto; 3 = Desarrollo del proceso; 4 = Validación del producto y proceso");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Punto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringApqpProjectsSelectedPoints>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_APQP_Projects_SelectedPoints");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComentariosNoSelected)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPuntoPlan).HasColumnType("date");

                entity.Property(e => e.FechaPuntoReal).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRevisionPlan).HasColumnType("date");

                entity.Property(e => e.FechaRevisionReal).HasColumnType("date");

                entity.Property(e => e.FechaTerminado).HasColumnType("datetime");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.PuntoId).HasColumnName("PuntoID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = Abierto; 2 = Retrasado; 3 = Terminado");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioTerminadoId).HasColumnName("UsuarioTerminadoID");
            });

            modelBuilder.Entity<EngineeringApqpProjectsSelectedPointsBackup>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_APQP_Projects_SelectedPoints_Backup");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComentariosNoSelected)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPunto).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaRevision).HasColumnType("date");

                entity.Property(e => e.FechaTerminado).HasColumnType("datetime");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.PuntoId).HasColumnName("PuntoID");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioTerminadoId).HasColumnName("UsuarioTerminadoID");
            });

            modelBuilder.Entity<EngineeringApqpResponsibles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Engineering_APQP_Responsibles");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponents>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Components");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Componente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsBom>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Engineering_Components_FeaturesSpecifications_Models");

                entity.ToTable("Engineering_Components_BOM");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.CodigoModeloId).HasColumnName("CodigoModeloID");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.EspecificacionId).HasColumnName("EspecificacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotorModeloId).HasColumnName("MotorModeloID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsFeatureTypes>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("Engineering_Components_FeatureTypes");

                entity.Property(e => e.IdTipo).HasColumnName("ID_Tipo");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesAttributes>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica);

                entity.ToTable("Engineering_Components_FeaturesAttributes");

                entity.Property(e => e.IdCaracteristica).HasColumnName("ID_Caracteristica");

                entity.Property(e => e.Caracteristica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesBom>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica);

                entity.ToTable("Engineering_Components_FeaturesBOM");

                entity.Property(e => e.IdCaracteristica).HasColumnName("ID_Caracteristica");

                entity.Property(e => e.CaracteristicaComponenteId).HasColumnName("CaracteristicaComponenteID");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesDimensional>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica)
                    .HasName("PK_Engineering_Components_Features");

                entity.ToTable("Engineering_Components_FeaturesDimensional");

                entity.Property(e => e.IdCaracteristica).HasColumnName("ID_Caracteristica");

                entity.Property(e => e.Caracteristica)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesSpecifications>(entity =>
            {
                entity.HasKey(e => e.IdEspecificacion);

                entity.ToTable("Engineering_Components_FeaturesSpecifications");

                entity.Property(e => e.IdEspecificacion).HasColumnName("ID_Especificacion");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");

                entity.Property(e => e.FechaLibero).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroBaja).HasColumnType("datetime");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAprobacionId).HasColumnName("UsuarioAprobacionID");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioLiberoId).HasColumnName("UsuarioLiberoID");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesSpecificationsDetails>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Engineering_Specifications");

                entity.ToTable("Engineering_Components_FeaturesSpecificationsDetails");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.CodigoModeloId).HasColumnName("CodigoModeloID");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.EspecificacionId).HasColumnName("EspecificacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Maximo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UnidadMedidaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesSpecificationsRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Components_FeaturesSpecificationsRejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EspecificacionId).HasColumnName("EspecificacionID");

                entity.Property(e => e.FechaRechazo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotivoRechazo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");
            });

            modelBuilder.Entity<EngineeringComponentsFeaturesWorkStations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Components_FeaturesWorkStations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");
            });

            modelBuilder.Entity<EngineeringComponentsProduct>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Engineering_Components_Product");

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");

                entity.Property(e => e.FechaLibero).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAprobacionId).HasColumnName("UsuarioAprobacionID");

                entity.Property(e => e.UsuarioLiberoId).HasColumnName("UsuarioLiberoID");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringComponentsProductSpecifications>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Components_ProductSpecifications");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EspecificacionId).HasColumnName("EspecificacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringCustomerVoice>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Customer_Voice");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrg)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumeroParte)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringCustomerVoiceQuestions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Customer_Voice_Questions");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringCustomerVoiceQuestionsLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Customer_Voice_Questions_log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Disabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionNew)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionPrevious)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringCustomerVoiceResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Customer_Voice_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(850)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringFanp>(entity =>
            {
                entity.HasKey(e => e.IdFanp);

                entity.ToTable("Engineering_FANP");

                entity.Property(e => e.IdFanp).HasColumnName("ID_FANP");

                entity.Property(e => e.CodigoMedio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMedioId).HasColumnName("CodigoMedioID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringFanpCharacteristics>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica)
                    .HasName("PK_Engineering_FANP_DimensionalInspection");

                entity.ToTable("Engineering_FANP_Characteristics");

                entity.Property(e => e.IdCaracteristica).HasColumnName("ID_Caracteristica");

                entity.Property(e => e.DescripcionCaracteristica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FanpId).HasColumnName("FANP_ID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpInputData>(entity =>
            {
                entity.HasKey(e => e.IdRegistroEntrada);

                entity.ToTable("Engineering_FANP_InputData");

                entity.Property(e => e.IdRegistroEntrada).HasColumnName("ID_RegistroEntrada");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosMedicion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusiones)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ConclusionesDesviacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAplicacion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FanpId).HasColumnName("FanpID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringFanpInputDataLevel1>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_InputDataLevel_1");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Medicion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFanpInputDataLevel1Add>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_InputDataLevel_1_ADD");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Caracteristica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFanpInputDataLevel2>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_InputDataLevel_2");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Resultado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpInputDataLevel2Add>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_InputDataLevel_2_ADD");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Caracteristica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpInputDataLevel3>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_InputDataLevel_3");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Medicion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFanpInputDataLevel3Add>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_InputDataLevel_3_ADD");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Caracteristica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFanpMedicionTestData1>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Engineering_FANP_InputDataLevel_4");

                entity.ToTable("Engineering_FANP_MedicionTestData_1");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modificado).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpMedicionTestData1Add>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_MedicionTestData_1_ADD");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Caracteristica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FanpId).HasColumnName("FanpID");

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpMedicionTestData2>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_MedicionTestData_2");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modificado).HasDefaultValueSql("((0))");

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpMedicionTestData2Add>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_MedicionTestData_2_ADD");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FanpId).HasColumnName("FanpID");

                entity.Property(e => e.Prueba)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpTests>(entity =>
            {
                entity.HasKey(e => e.IdPrueba);

                entity.ToTable("Engineering_FANP_Tests");

                entity.Property(e => e.IdPrueba).HasColumnName("ID_Prueba");

                entity.Property(e => e.DescripcionPrueba)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FanpId).HasColumnName("FANP_ID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpWarrantyFeaturesStep1>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_WarrantyFeatures_Step1");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Medicion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFanpWarrantyFeaturesStep2>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_WarrantyFeatures_Step2");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Resultado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFanpWarrantyFeaturesStep3>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_WarrantyFeatures_Step3");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Medicion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFanpWarrantyFeaturesStep4>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_FANP_WarrantyFeatures_Step4");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.Conclusion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroEntradaId).HasColumnName("RegistroEntradaID");

                entity.Property(e => e.Resultado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringFeasibilitySheet>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Feasibility_Sheet");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringFeasibilitySheetQuestions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Feasibility_Sheet_Questions");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringFeasibilitySheetQuestionsLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Feasibility_Sheet_Questions_log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionNew)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionPrevious)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineeringFeasibilitySheetResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Feasibility_Sheet_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FeasibilityId).HasColumnName("FeasibilityID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringMeasurementUnits>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.ToTable("Engineering_Measurement_Units");

                entity.Property(e => e.IdUnidad).HasColumnName("ID_Unidad");

                entity.Property(e => e.DescripcionUnidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Medida)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EngineeringOpenIssues>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Open_Issues");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AplicaId).HasColumnName("AplicaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobOrder)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroParte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringOpenIssuesList>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Open_Issues_List");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AccionCorrectiva)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AdpDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdpId).HasColumnName("AdpID");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierre).HasColumnType("date");

                entity.Property(e => e.FechaDeteccion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hallazgo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.SeveridadId).HasColumnName("SeveridadID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringOpenIssuesRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Open_Issues_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");
            });

            modelBuilder.Entity<EngineeringOpenIssuesReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Open_Issues_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringProjects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Projects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComentarioCierre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IngenieroAsignadoId).HasColumnName("IngenieroAsignadoID");

                entity.Property(e => e.Projecto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.UsuarioCierreId).HasColumnName("UsuarioCierreID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringProjectsDocuments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Projects_Documents");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoDigitalId).HasColumnName("DocumentoDigitalID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PantallaId).HasColumnName("PantallaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringProjectsDocumentsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Projects_Documents_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringProjectsPhases>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Projects_Phases");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringProjectsPhasesPoints>(entity =>
            {
                entity.HasKey(e => e.IdPunto);

                entity.ToTable("Engineering_Projects_Phases_Points");

                entity.Property(e => e.IdPunto).HasColumnName("ID_Punto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FaseId).HasColumnName("FaseID");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nivel).HasDefaultValueSql("((1))");

                entity.Property(e => e.Punto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringProjectsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Projects_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolChecklist>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Tool_Checklist");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolChecklistResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Engineering_Tool_Checklist_Results");

                entity.Property(e => e.ActividadId).HasColumnName("ActividadID");

                entity.Property(e => e.ChecklistId).HasColumnName("ChecklistID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusOperacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolChecklistReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Tool_Checklist_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ChecklistId).HasColumnName("ChecklistID");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolingActivities>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Tooling_Activities");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantillaId).HasColumnName("PlantillaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolingDepartament>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Tooling_Departament");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantillaId).HasColumnName("PlantillaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolingStations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Engineering_Tooling_Stations\\");

                entity.ToTable("Engineering_Tooling_Stations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantillaId).HasColumnName("PlantillaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolingTemplate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Tooling_Template");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolingTemplateDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Engineering_Tooling_Template_Details");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OperacionId).HasColumnName("OperacionID");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EngineeringToolingTemplateDetailsExtra>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Engineering_Tooling_Template_Details_Extra");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListId).HasColumnName("CheckListID");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OperacionId).HasColumnName("OperacionID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<EstacionesEmp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoEmpleado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factories>(entity =>
            {
                entity.HasKey(e => e.IdPlanta);

                entity.Property(e => e.IdPlanta).HasColumnName("ID_Planta");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoContacto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Locacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FactoriesManufacturing>(entity =>
            {
                entity.HasKey(e => e.IdFabricante);

                entity.ToTable("Factories_Manufacturing");

                entity.Property(e => e.IdFabricante).HasColumnName("ID_Fabricante");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('color')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fabricante)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoFabricante).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FinancesAccounts>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.ToTable("Finances_Accounts");

                entity.Property(e => e.IdCuenta).HasColumnName("ID_Cuenta");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroBaja).HasColumnType("datetime");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroBajaId).HasColumnName("UsuarioRegistroBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<FinancesAccountsApprovers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Finances_AccountsManagers");

                entity.ToTable("Finances_AccountsApprovers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CuentaId).HasColumnName("CuentaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioResponsableId).HasColumnName("UsuarioResponsableID");
            });

            modelBuilder.Entity<FinancesAccountsApproversBudget>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Finances_AccountsManagers_Budget");

                entity.ToTable("Finances_AccountsApprovers_Budget");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CuentaResponsableId).HasColumnName("CuentaResponsableID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Month)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthId)
                    .HasColumnName("MonthID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.YearId)
                    .IsRequired()
                    .HasColumnName("YearID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancesAccountsApproversPrivileges>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_AccountsApprovers_Privileges");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Contenido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTab)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroId)
                    .HasColumnName("FechaRegistroID")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PrivilegioId).HasColumnName("PrivilegioID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<FinancesAccountsApproversTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Finances_AccountsApprovers_Temp");

                entity.Property(e => e.AprobadorTemporalId).HasColumnName("AprobadorTemporalID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAprobadorId).HasColumnName("UsuarioAprobadorID");
            });

            modelBuilder.Entity<FinancesAccountsApproversTempByAccount>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_AccountsApprovers_TempByAccount");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AprobadorTemporalId).HasColumnName("AprobadorTemporalID");

                entity.Property(e => e.CuentaResponsableId).HasColumnName("CuentaResponsableID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<FinancesAccountsSubAccounts>(entity =>
            {
                entity.HasKey(e => e.IdSubCuenta)
                    .HasName("PK_Finances_Accounts_SubAccounts");

                entity.ToTable("Finances_AccountsSubAccounts");

                entity.Property(e => e.IdSubCuenta).HasColumnName("ID_SubCuenta");

                entity.Property(e => e.CuentaId).HasColumnName("CuentaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Presupuesto).HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubCuenta)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<FinancesRequisitions>(entity =>
            {
                entity.HasKey(e => e.IdRequisicion);

                entity.ToTable("Finances_Requisitions");

                entity.Property(e => e.IdRequisicion).HasColumnName("ID_Requisicion");

                entity.Property(e => e.ComentarioRetorno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.CuentaId).HasColumnName("CuentaID");

                entity.Property(e => e.FechaAutorizacionDireccion).HasColumnType("datetime");

                entity.Property(e => e.FechaAutorizacionGerencia).HasColumnType("datetime");

                entity.Property(e => e.FechaCompletada).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroCancelacion).HasColumnType("datetime");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoCompra)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRequisicion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpcionCompraId).HasColumnName("OpcionCompraID");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Retornado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubCuentaId).HasColumnName("SubCuentaID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<FinancesRequisitionsArticles>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_Requisitions_Articles");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FinancesRequisitionsAuth>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_Requisitions_Auth");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Orden).HasDefaultValueSql("((1))");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAutorizacionId).HasColumnName("UsuarioAutorizacionID");
            });

            modelBuilder.Entity<FinancesRequisitionsComments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_Requisitions_Comments");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<FinancesRequisitionsPurchaseOptions>(entity =>
            {
                entity.HasKey(e => e.IdOpcionCompra);

                entity.ToTable("Finances_Requisitions_PurchaseOptions");

                entity.Property(e => e.IdOpcionCompra).HasColumnName("ID_OpcionCompra");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FinancesRequisitionsQuotes>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_Requisitions_Quotes");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<FinancesRequisitionsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Finances_Requisitions_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioAsignoId).HasColumnName("UsuarioAsignoID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluation>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsEvaluated)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsEvaluator)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DateEthics).HasColumnType("datetime");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.EvaluacionId).HasColumnName("EvaluacionID");

                entity.Property(e => e.FechaEvaluacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.StrategicPlanning)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvaluacionId).HasColumnName("TipoEvaluacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationActivities>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Activities");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Meta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Razones)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoEvaluacionId).HasColumnName("TipoEvaluacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationActivitiesCopy>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_ActivitiesCopy");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Meta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Razones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoEvaluacionId).HasColumnName("TipoEvaluacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationCompetencies>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Competencies");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formacion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Razon)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationCorrectiveActions>(entity =>
            {
                entity.HasKey(e => e.IdRegisto);

                entity.ToTable("HumanResources_Administrative_Evaluation_CorrectiveActions");

                entity.Property(e => e.IdRegisto).HasColumnName("ID_Registo");

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaRegistroId)
                    .HasColumnName("FechaRegistroID")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationFactors>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Factors");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Factor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationFactorsResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Factors_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FactorId).HasColumnName("FactorID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationRegister>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Register");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationReview>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Review");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationStrategicPlanning>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Strategic_Planning");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Planeacion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesAdministrativeEvaluationStrategicPlanningResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Administrative_Evaluation_Strategic_Planning_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EstrategiaId).HasColumnName("EstrategiaID");

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticipacionId).HasColumnName("ParticipacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesCompetitionFactors>(entity =>
            {
                entity.HasKey(e => e.IdFactorCompetencia);

                entity.ToTable("HumanResources_CompetitionFactors");

                entity.Property(e => e.IdFactorCompetencia).HasColumnName("ID_FactorCompetencia");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesCompetitionFactorsChangeLevels>(entity =>
            {
                entity.HasKey(e => e.IdCambioNivel);

                entity.ToTable("HumanResources_CompetitionFactors_ChangeLevels");

                entity.Property(e => e.IdCambioNivel).HasColumnName("ID_CambioNivel");

                entity.Property(e => e.CambioNivelCompetencia).HasComment("1 = 1 a 2; 2 = 2 a 3; 3 = 3 a 4");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FactorCompetenciaId).HasColumnName("FactorCompetenciaID");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesCompetitionFactorsTests>(entity =>
            {
                entity.HasKey(e => e.IdExamen)
                    .HasName("PK_HumanResources_CompetitionsFactors_Tests");

                entity.ToTable("HumanResources_CompetitionFactors_Tests");

                entity.Property(e => e.IdExamen).HasColumnName("ID_Examen");

                entity.Property(e => e.CambioNivelId).HasColumnName("CambioNivelID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FactorCompetenciaId).HasColumnName("FactorCompetenciaID");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PorcentajeAprobacion)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesCompetitionFactorsTestsQuestions>(entity =>
            {
                entity.HasKey(e => e.IdPregunta);

                entity.ToTable("HumanResources_CompetitionFactors_Tests_Questions");

                entity.Property(e => e.IdPregunta).HasColumnName("ID_Pregunta");

                entity.Property(e => e.ExamenId).HasColumnName("ExamenID");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoPregunta)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = Opcion multiplie; 2 = Falso y verdadero");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesCompetitionFactorsTestsQuestionsAnswers>(entity =>
            {
                entity.HasKey(e => e.IdRespuesta);

                entity.ToTable("HumanResources_CompetitionFactors_Tests_Questions_Answers");

                entity.Property(e => e.IdRespuesta).HasColumnName("ID_Respuesta");

                entity.Property(e => e.Correcta)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesCourses>(entity =>
            {
                entity.HasKey(e => e.IdCurso);

                entity.ToTable("HumanResources_Courses");

                entity.Property(e => e.IdCurso).HasColumnName("ID_Curso");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreCurso)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoCurso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesDepartments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_Departments");

                entity.Property(e => e.CarpetaSite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IconClass)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IconoMenu)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento)
                    .HasColumnName("ID_Departamento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PaginaPrincipal)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourcesEmployeesMedical>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_Employees_Medical");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.ExamenId).HasColumnName("ExamenID");

                entity.Property(e => e.FechaExamen).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesEmployeesMedicalExams>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Employees_MedicalExams");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.EsApto).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExamenId).HasColumnName("ExamenID");

                entity.Property(e => e.FechaExamen).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesJobDescription>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_JobDescription");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesJobDescriptionConcepts>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_JobDescription_Concepts");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesJobDescriptionProfile>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_JobDescription_Profile");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Evidence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TopicsDesirable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TopicsEssential)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesJobDescriptionResponsibility>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_JobDescription_Responsibility");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Criterion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Responsibility)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesMatrixSkills>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_MatrixSkills");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaCursoInstructorInterno).HasColumnType("datetime");

                entity.Property(e => e.FechaLilberacionFaseHabilidad).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HumanResourcesMedicalExams>(entity =>
            {
                entity.HasKey(e => e.IdExamen);

                entity.ToTable("HumanResources_MedicalExams");

                entity.Property(e => e.IdExamen).HasColumnName("ID_Examen");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesRequisicionPersonal>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Requisicion_Personal");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Contratacion).HasColumnType("date");

                entity.Property(e => e.ContratacionId).HasColumnName("ContratacionID");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Especificar)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Expide)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HorarioId).HasColumnName("HorarioID");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PuestoId).HasColumnName("PuestoID");

                entity.Property(e => e.QtyPersonas).HasDefaultValueSql("((1))");

                entity.Property(e => e.Recepcion).HasColumnType("datetime");

                entity.Property(e => e.ReemplazoId).HasColumnName("ReemplazoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UltimoNivel)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkstationId).HasColumnName("WorkstationID");
            });

            modelBuilder.Entity<HumanResourcesRequisicionPersonalCompetencies>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Requisicion_Personal_Competencies");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesRequisicionPersonalReturn>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Requisicion_Personal_Return");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComentarioReturn)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioReturnId).HasColumnName("UsuarioReturnID");
            });

            modelBuilder.Entity<HumanResourcesRequisicionPersonalReview>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Requisicion_Personal_Review");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");
            });

            modelBuilder.Entity<HumanResourcesRequisicionPersonalsRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Requisicion_Personals_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRechazo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequisicionId).HasColumnName("RequisicionID");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");
            });

            modelBuilder.Entity<HumanResourcesSurveys>(entity =>
            {
                entity.HasKey(e => e.IdEncuesta);

                entity.ToTable("HumanResources_Surveys");

                entity.Property(e => e.IdEncuesta).HasColumnName("ID_Encuesta");

                entity.Property(e => e.DescripcionEncuesta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<HumanResourcesSurveysCategories>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("HumanResources_SurveysCategories");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EncuestaId).HasColumnName("EncuestaID");

                entity.Property(e => e.FechaModificacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IconMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioModificaId).HasColumnName("UsuarioModificaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesSurveysCuestions>(entity =>
            {
                entity.HasKey(e => e.IdPregunta);

                entity.ToTable("HumanResources_SurveysCuestions");

                entity.Property(e => e.IdPregunta).HasColumnName("ID_Pregunta");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.DescripcionPregunta)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionId).HasColumnName("DimensionID");

                entity.Property(e => e.DominioId).HasColumnName("DominioID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrdenId)
                    .HasColumnName("OrdenID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesSurveysCuestionsOrden>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.ToTable("HumanResources_SurveysCuestions_Orden");

                entity.Property(e => e.IdOrden).HasColumnName("ID_Orden");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IconMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesSurveysCuestionsResp10012020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysCuestions_Resp10012020");

                entity.Property(e => e.DescripcionPregunta)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionId).HasColumnName("DimensionID");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdPregunta)
                    .HasColumnName("ID_Pregunta")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesSurveysDimensions>(entity =>
            {
                entity.HasKey(e => e.IdDimension);

                entity.ToTable("HumanResources_SurveysDimensions");

                entity.Property(e => e.IdDimension).HasColumnName("ID_Dimension");

                entity.Property(e => e.DescripcionDimension)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleDimension)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EncuestaId).HasColumnName("EncuestaID");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IconMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioModificaId).HasColumnName("UsuarioModificaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesSurveysDimensionsResp10012020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysDimensions_Resp10012020");

                entity.Property(e => e.DescripcionDimension)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleDimension)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EncuestaId).HasColumnName("EncuestaID");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IconMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDimension)
                    .HasColumnName("ID_Dimension")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioModificaId).HasColumnName("UsuarioModificaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesSurveysDomains>(entity =>
            {
                entity.HasKey(e => e.IdDominio);

                entity.ToTable("HumanResources_SurveysDomains");

                entity.Property(e => e.IdDominio).HasColumnName("ID_Dominio");

                entity.Property(e => e.Dominio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesSurveysResults>(entity =>
            {
                entity.HasKey(e => e.RegistroId);

                entity.ToTable("HumanResources_SurveysResults");

                entity.HasIndex(e => new { e.NumEmp, e.FechaRegistro })
                    .HasName("IX_HumanResources_SurveysResults");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");

                entity.Property(e => e.Calificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EncuestaId).HasColumnName("EncuestaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumEmp)
                    .IsRequired()
                    .HasColumnName("Num_emp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesSurveysResults2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysResults_2019");

                entity.Property(e => e.Calificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NumEmp)
                    .HasColumnName("Num_emp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.RegistroId)
                    .HasColumnName("RegistroID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HumanResourcesSurveysResults2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysResults_2020");

                entity.Property(e => e.Calificacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NumEmp)
                    .IsRequired()
                    .HasColumnName("Num_emp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.RegistroId)
                    .HasColumnName("RegistroID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HumanResourcesSurveysResultsCategories>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysResults_Categories");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Valor)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourcesSurveysResultsDimension>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysResults_Dimension");

                entity.Property(e => e.DimensionId).HasColumnName("DimensionID");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Valor)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourcesSurveysResultsDomains>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysResults_Domains");

                entity.Property(e => e.DominioId).HasColumnName("DominioID");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Valor)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourcesSurveysResultsPreview>(entity =>
            {
                entity.HasKey(e => e.RegistroId);

                entity.ToTable("HumanResources_SurveysResultsPreview");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");

                entity.Property(e => e.EncuestaId).HasColumnName("EncuestaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumEmp).HasColumnName("Num_emp");

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");
            });

            modelBuilder.Entity<HumanResourcesSurveysResultsResp16102020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResources_SurveysResults_Resp16102020");

                entity.Property(e => e.Calificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NumEmp)
                    .HasColumnName("Num_emp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.RegistroId)
                    .HasColumnName("RegistroID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HumanResourcesTrainingBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.IdUnidadNegocio);

                entity.ToTable("HumanResources_Training_BusinessUnit");

                entity.Property(e => e.IdUnidadNegocio).HasColumnName("ID_UnidadNegocio");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoordinadorIngenieriaId).HasColumnName("CoordinadorIngenieriaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ResponsableId)
                    .HasColumnName("ResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesTrainingEmployeesTests>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_EmployeesTests");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ExamenId).HasColumnName("ExamenID");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaPresentacion).HasColumnType("datetime");

                entity.Property(e => e.ResultadoFinal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesTrainingEmployeesTestsResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_EmployeesTests_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ExamenEmpleadoId).HasColumnName("ExamenEmpleadoID");

                entity.Property(e => e.ExamenId).HasColumnName("ExamenID");

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.RespuestaId).HasColumnName("RespuestaID");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperations>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("HumanResources_Training_RequestOperations");

                entity.Property(e => e.IdSolicitud).HasColumnName("ID_Solicitud");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosRechazoInspector)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusiones)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.EntrenamientoStep)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.EvaluacionEntrenamiento)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoEntrenamiento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadNegocioId).HasColumnName("UnidadNegocioID");

                entity.Property(e => e.UsuarioEmpleadoId).HasColumnName("UsuarioEmpleadoID");

                entity.Property(e => e.UsuarioEntrenoId).HasColumnName("UsuarioEntrenoID");

                entity.Property(e => e.UsuarioInspectorId)
                    .HasColumnName("UsuarioInspectorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsAuditIpp>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_AuditIPP");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actualizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroContestado).HasColumnType("datetime");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TempleateId).HasColumnName("TempleateID");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsAuditPreControl>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_AuditPreControl");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actualizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroContestado).HasColumnType("datetime");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsAuditWarranties>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_AuditWarranties");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AccionGarantiaId).HasColumnName("AccionGarantiaID");

                entity.Property(e => e.Alerta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroContestado).HasColumnType("datetime");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsCancel>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_Cancel");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsDocs>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_Docs");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaAprobado).HasColumnType("datetime");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsFails>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_Fails");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Falla)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsGages>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_Gages");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actualizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GageId).HasColumnName("GageID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsMachineReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_MachineReviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Maquina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Revision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TiempoRespuesta).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioAsignoId).HasColumnName("UsuarioAsignoID");
            });

            modelBuilder.Entity<HumanResourcesTrainingRequestOperationsSecurityEquipment>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("HumanResources_Training_RequestOperations_SecurityEquipment");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Equipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ImportUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApellidoMaterno).HasMaxLength(255);

                entity.Property(e => e.ApellidoPaterno).HasMaxLength(255);

                entity.Property(e => e.Categoria).HasMaxLength(255);

                entity.Property(e => e.Correo).HasMaxLength(255);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(255);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.DepartamentoProduccionId)
                    .HasColumnName("DepartamentoProduccionID")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaBaja).HasMaxLength(255);

                entity.Property(e => e.FechaIngreso).HasMaxLength(255);

                entity.Property(e => e.FechaLiberacionEntrenamiento).HasMaxLength(255);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GerenciaId)
                    .HasColumnName("GerenciaID")
                    .HasMaxLength(255);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Idioma).HasMaxLength(255);

                entity.Property(e => e.Imss)
                    .HasColumnName("IMSS")
                    .HasMaxLength(255);

                entity.Property(e => e.NoEmpleado).HasMaxLength(255);

                entity.Property(e => e.Nombres).HasMaxLength(255);

                entity.Property(e => e.PaginaInicio).HasMaxLength(255);

                entity.Property(e => e.Pass).HasMaxLength(255);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PreguntaSecreta).HasMaxLength(255);

                entity.Property(e => e.Puesto).HasMaxLength(255);

                entity.Property(e => e.PuestoId)
                    .HasColumnName("PuestoID")
                    .HasMaxLength(255);

                entity.Property(e => e.RespuestaSecreta).HasMaxLength(255);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(255);

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SupervisorID")
                    .HasMaxLength(255);

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.Property(e => e.UsuarioBajaId)
                    .HasColumnName("UsuarioBajaID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ItsystemsAdministrators>(entity =>
            {
                entity.HasKey(e => e.IdAdministradorIt)
                    .HasName("PK_ITServices_Administrators");

                entity.ToTable("ITSystems_Administrators");

                entity.Property(e => e.IdAdministradorIt).HasColumnName("ID_AdministradorIT");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferences>(entity =>
            {
                entity.HasKey(e => e.IdReferencia)
                    .HasName("PK_Services_now_ITcontrol");

                entity.ToTable("ITSystems_HardwareReferences");

                entity.Property(e => e.IdReferencia).HasColumnName("ID_Referencia");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionReferencia)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DominioLkq)
                    .HasColumnName("DominioLKQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FabricanteId).HasColumnName("FabricanteID");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NegocioCritico)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.RevisionAnterior)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionSiguiente).HasColumnType("date");

                entity.Property(e => e.So)
                    .HasColumnName("SO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoReferenciaId).HasColumnName("TipoReferenciaID");

                entity.Property(e => e.UsuarioActualizacionId).HasColumnName("UsuarioActualizacionID");

                entity.Property(e => e.UsuarioAd).HasColumnName("UsuarioAD");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesFiles>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_ITServices_HardwareReferences_Files");

                entity.ToTable("ITSystems_HardwareReferences_Files");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenciaId).HasColumnName("ReferenciaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesHistoryStatus>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_ITServices_HardwareReferences_HistoryStatus");

                entity.ToTable("ITSystems_HardwareReferences_HistoryStatus");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenciaId).HasColumnName("ReferenciaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesHistoryUpdate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_ITServices_HardwareReferences_HistoryUpdate");

                entity.ToTable("ITSystems_HardwareReferences_HistoryUpdate");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenciaId).HasColumnName("ReferenciaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesHistoryWorkStations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_ITServices_HardwareReferences_HistoryWorkStations");

                entity.ToTable("ITSystems_HardwareReferences_HistoryWorkStations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionAnteriorId).HasColumnName("EstacionAnteriorID");

                entity.Property(e => e.EstacionNuevaId).HasColumnName("EstacionNuevaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenciaId).HasColumnName("ReferenciaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesManufacturer>(entity =>
            {
                entity.HasKey(e => e.IdFabricante)
                    .HasName("PK_ITServices_HardwareReferences_Manufacturer");

                entity.ToTable("ITSystems_HardwareReferences_Manufacturer");

                entity.Property(e => e.IdFabricante).HasColumnName("ID_Fabricante");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesModels>(entity =>
            {
                entity.HasKey(e => e.IdModelo)
                    .HasName("PK_ITServices_HardwareReferences_Models");

                entity.ToTable("ITSystems_HardwareReferences_Models");

                entity.Property(e => e.IdModelo).HasColumnName("ID_Modelo");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("ITSystems_HardwareReferences_Status");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesTabSections>(entity =>
            {
                entity.HasKey(e => e.IdSeccion)
                    .HasName("PK_ITServices_HardwareReferences_Sections");

                entity.ToTable("ITSystems_HardwareReferences_TabSections");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Onclick)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tab)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesTabSectionsLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_ITServices_HardwareReferences_SectionsLinkedUsers");

                entity.ToTable("ITSystems_HardwareReferences_TabSectionsLinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<ItsystemsHardwareReferencesTypes>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK_ITServices_References_Types");

                entity.ToTable("ITSystems_HardwareReferences_Types");

                entity.Property(e => e.IdTipo).HasColumnName("ID_Tipo");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsServices>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK_ITServices_Services");

                entity.ToTable("ITSystems_Services");

                entity.Property(e => e.IdServicio).HasColumnName("ID_Servicio");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenciaId).HasColumnName("ReferenciaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoServicioId).HasColumnName("TipoServicioID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ItsystemsServicesTypes>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio)
                    .HasName("PK_ITServices_Types");

                entity.ToTable("ITSystems_ServicesTypes");

                entity.Property(e => e.IdTipoServicio).HasColumnName("ID_TipoServicio");

                entity.Property(e => e.DescripcionServicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.Property(e => e.IdUbicacion).HasColumnName("ID_Ubicacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dirección)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.MunicipioId).HasColumnName("MunicipioID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("1 = propia, 2 = rentado, 3 = prestado");
            });

            modelBuilder.Entity<LogisiticsFanpWarranty>(entity =>
            {
                entity.HasKey(e => e.IdFanp)
                    .HasName("PK_Quality_FANP_Warranty");

                entity.ToTable("Logisitics_FANP_Warranty");

                entity.Property(e => e.IdFanp).HasColumnName("ID_FANP");

                entity.Property(e => e.CodigoId).HasColumnName("CodigoID");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsFanpWarrantyFeatures>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica);

                entity.ToTable("Logisitics_FANP_WarrantyFeatures");

                entity.Property(e => e.IdCaracteristica).HasColumnName("ID_Caracteristica");

                entity.Property(e => e.DescripcionCaracteristica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FanpId).HasColumnName("FANP_ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LogisiticsItemsCriticalParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logisitics_Items_CriticalParts");

                entity.Property(e => e.CodigoParte)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionParte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdParteCritica)
                    .HasColumnName("ID_ParteCritica")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioModificoId)
                    .HasColumnName("UsuarioModificoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroParteId).HasColumnName("UsuarioRegistroParteID");
            });

            modelBuilder.Entity<LogisiticsItemsMiddleCode>(entity =>
            {
                entity.HasKey(e => e.IdCodigoMedio);

                entity.ToTable("Logisitics_Items_MiddleCode");

                entity.Property(e => e.IdCodigoMedio).HasColumnName("ID_CodigoMedio");

                entity.Property(e => e.CodigoMedio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioModificoId)
                    .HasColumnName("UsuarioModificoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LogisiticsProviders>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("Logisitics_Providers");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_Proveedor");

                entity.Property(e => e.AutoTicket)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadContactoProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBancario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoImportacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalVendedor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioBaja)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.ContactoPrimario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoProveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCompras)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataOem)
                    .HasColumnName("DataOEM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripcionCuentaCompras)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Determinacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionProveedor2)
                    .HasColumnName("DireccionProveedor_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionVendedor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionVendedor2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContactoProveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailExterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailInterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnvioDirecto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacturaDirecta).HasDefaultValueSql("((1))");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaFirma).HasColumnType("date");

                entity.Property(e => e.FechaRechazo).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimaCompra).HasColumnType("date");

                entity.Property(e => e.GrupoContacto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idioma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IncludeTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.InicialEstadoProveedor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtroContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisVendedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ticket).HasDefaultValueSql("((0))");

                entity.Property(e => e.TiempoEntrega)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Urlinternet)
                    .HasColumnName("URLInternet")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdbaja).HasColumnName("UsuarioIDBaja");

                entity.Property(e => e.UsuarioIdfirma).HasColumnName("UsuarioIDFirma");

                entity.Property(e => e.UsuarioIdrechazo).HasColumnName("UsuarioIDRechazo");

                entity.Property(e => e.UsuarioIdregistro).HasColumnName("UsuarioIDRegistro");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WareHouse)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisiticsProvidersItems>(entity =>
            {
                entity.HasKey(e => e.IdregistroProvider)
                    .HasName("PK_Logisitics_ProvidersItems_Resp041121");

                entity.ToTable("Logisitics_ProvidersItems");

                entity.Property(e => e.IdregistroProvider).HasColumnName("IDRegistroProvider");

                entity.Property(e => e.AcuerdoCompromiso)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.Clasificacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostoPromedio).HasColumnType("money");

                entity.Property(e => e.DescripcionMoneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCotizacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimaOrden).HasColumnType("date");

                entity.Property(e => e.ItemVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TiempoEntrega).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UltimoCosto).HasColumnType("money");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsProvidersItemsResp031121>(entity =>
            {
                entity.HasKey(e => e.IdregistroProvider)
                    .HasName("PK_Logisitics_ProvidersItems");

                entity.ToTable("Logisitics_ProvidersItems_Resp031121");

                entity.Property(e => e.IdregistroProvider).HasColumnName("IDRegistroProvider");

                entity.Property(e => e.AcuerdoCompromiso)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.Clasificacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostoPromedio).HasColumnType("money");

                entity.Property(e => e.DescripcionMoneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCotizacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimaOrden).HasColumnType("date");

                entity.Property(e => e.ItemVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TiempoEntrega).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UltimoCosto).HasColumnType("money");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsProvidersItemsResp041121>(entity =>
            {
                entity.HasKey(e => e.IdregistroProvider)
                    .HasName("PK_Logisitics_ProvidersItems_Resp03112021");

                entity.ToTable("Logisitics_ProvidersItems_Resp041121");

                entity.Property(e => e.IdregistroProvider).HasColumnName("IDRegistroProvider");

                entity.Property(e => e.AcuerdoCompromiso)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.Clasificacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostoPromedio).HasColumnType("money");

                entity.Property(e => e.DescripcionMoneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCotizacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimaOrden).HasColumnType("date");

                entity.Property(e => e.ItemVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.TiempoEntrega).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UltimoCosto).HasColumnType("money");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsProvidersResp041121>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logisitics_Providers_Resp041121");

                entity.Property(e => e.AutoTicket)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadContactoProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBancario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoImportacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalVendedor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioBaja)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.ContactoPrimario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoProveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCompras)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataOem).HasColumnName("DataOEM");

                entity.Property(e => e.DescripcionCuentaCompras)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Determinacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionProveedor2)
                    .HasColumnName("DireccionProveedor_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionVendedor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionVendedor2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContactoProveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailExterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailInterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnvioDirecto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaFirma).HasColumnType("date");

                entity.Property(e => e.FechaRechazo).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaCompra).HasColumnType("date");

                entity.Property(e => e.GrupoContacto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("ID_Proveedor")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idioma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InicialEstadoProveedor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtroContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisVendedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoEntrega)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Urlinternet)
                    .HasColumnName("URLInternet")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdbaja).HasColumnName("UsuarioIDBaja");

                entity.Property(e => e.UsuarioIdfirma).HasColumnName("UsuarioIDFirma");

                entity.Property(e => e.UsuarioIdrechazo).HasColumnName("UsuarioIDRechazo");

                entity.Property(e => e.UsuarioIdregistro).HasColumnName("UsuarioIDRegistro");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WareHouse)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisiticsProvidersUpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logisitics_ProvidersUPD");

                entity.Property(e => e.ClaveUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisiticsPurchasesCtrlPanelTabs>(entity =>
            {
                entity.HasKey(e => e.IdTabPanel)
                    .HasName("PK_Logisitics_PurchasesCtrlPanelTabs");

                entity.ToTable("Logisitics_PurchasesCtrlPanel_Tabs");

                entity.Property(e => e.IdTabPanel).HasColumnName("ID_TabPanel");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.DescripcionPanel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LogisiticsPurchasesCtrlPanelTabsUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logisitics_PurchasesCtrlPanel_TabsUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistroId)
                    .HasColumnName("FechaRegistroID")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PanelId).HasColumnName("PanelID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<LogisiticsRequestNewProduct>(entity =>
            {
                entity.HasKey(e => e.IdRequest);

                entity.ToTable("Logisitics_Request_NewProduct");

                entity.Property(e => e.IdRequest).HasColumnName("ID_Request");

                entity.Property(e => e.ActivaPrioridad).HasDefaultValueSql("((0))");

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.AsignacionIngeniero).HasDefaultValueSql("((0))");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoMedio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CostoStandar)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaCompletada).HasColumnType("datetime");

                entity.Property(e => e.FechaModificaPrioridad).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroAprobacion1).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroAprobacion2).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroAprobacion3).HasColumnType("datetime");

                entity.Property(e => e.FechaRevisionDibujo).HasColumnType("datetime");

                entity.Property(e => e.FolioSyt)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NuevoPrecio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroJob)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroParte)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Oem).HasColumnName("OEM");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Razon)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.UsuarioCalidadId)
                    .HasColumnName("UsuarioCalidadID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioCompletoId).HasColumnName("UsuarioCompletoID");

                entity.Property(e => e.UsuarioDocumentosId).HasColumnName("UsuarioDocumentosID");

                entity.Property(e => e.UsuarioIngenieroId)
                    .HasColumnName("UsuarioIngenieroID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioPartesCriticasId)
                    .HasColumnName("UsuarioPartesCriticasID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroBajaId).HasColumnName("UsuarioRegistroBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioRegistroIdaprobacion1).HasColumnName("UsuarioRegistroIDAprobacion1");

                entity.Property(e => e.UsuarioRegistroIdaprobacion2).HasColumnName("UsuarioRegistroIDAprobacion2");

                entity.Property(e => e.UsuarioRegistroIdaprobacion3).HasColumnName("UsuarioRegistroIDAprobacion3");

                entity.Property(e => e.UsuarioRevisionDibujoId)
                    .HasColumnName("UsuarioRevisionDibujoID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LogisiticsRequestNewProductAssembled>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logisitics_Request_NewProduct_Assembled");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroEnsambleId).HasColumnName("RegistroEnsambleID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsRequestNewProductAssembledModels>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logisitics_Request_NewProduct_AssembledModels");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsRequestNewProductPrioritys>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logisitics_Request_NewProduct_Prioritys");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisiticsRequestNewProductPrioritysQy>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logisitics_Request_NewProduct_PrioritysQY");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LogisiticsRequestNewProductReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Logisitics_Request_NewProduct_Review");

                entity.ToTable("Logisitics_Request_NewProduct_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComentarioLiberado)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioRevision)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRevision)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarea)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoRespuesta).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRevisionId).HasColumnName("UsuarioRevisionID");
            });

            modelBuilder.Entity<LogisiticsRequestNewProductStepsResponsible>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logisitics_Request_NewProduct_Steps_Responsible");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisticsMarchingReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report");

                entity.Property(e => e.Atk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Core)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Line)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineData)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineMarching)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Part)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.Vege)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsMarchingReport11082021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_11082021");

                entity.Property(e => e.Atk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Core)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Line)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineData)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Part)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.Vege)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsMarchingReportBestcore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Bestcore");

                entity.Property(e => e.AbcCode)
                    .HasColumnName("ABC_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AcceptRequirements).HasColumnName("Accept_Requirements");

                entity.Property(e => e.ActiveForCustomerPortal).HasColumnName("Active_For_Customer_Portal");

                entity.Property(e => e.ActiveForDataIntegration).HasColumnName("Active_for_Data_Integration");

                entity.Property(e => e.AffiliateSales)
                    .HasColumnName("Affiliate_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AflExchSales)
                    .HasColumnName("AFL_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AllocatedToCustomerOrders).HasColumnName("Allocated_To_Customer_Orders");

                entity.Property(e => e.AllocatedToProd).HasColumnName("Allocated_To_Prod");

                entity.Property(e => e.AlternateItem)
                    .HasColumnName("Alternate_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.AprJobSales)
                    .HasColumnName("Apr_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AprSales)
                    .HasColumnName("Apr_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AprWarrantySales)
                    .HasColumnName("Apr_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AtkItem)
                    .HasColumnName("ATK_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.AtkSalesTarget)
                    .HasColumnName("ATK_Sales_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.AugJobSales)
                    .HasColumnName("Aug_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AugSales)
                    .HasColumnName("Aug_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AugWarrantySales)
                    .HasColumnName("Aug_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AutoJobGeneration)
                    .HasColumnName("Auto_Job_Generation")
                    .HasMaxLength(255);

                entity.Property(e => e.AutoReleaseWhenFirmed)
                    .HasColumnName("Auto_Release_When_Firmed")
                    .HasMaxLength(255);

                entity.Property(e => e.BackOrderQty)
                    .HasColumnName("Back_Order_Qty")
                    .HasMaxLength(255);

                entity.Property(e => e.BackflushLocation)
                    .HasColumnName("Backflush_Location")
                    .HasMaxLength(255);

                entity.Property(e => e.BeginningInventory)
                    .HasColumnName("Beginning_Inventory")
                    .HasMaxLength(255);

                entity.Property(e => e.BodyStyle)
                    .HasColumnName("Body_Style")
                    .HasMaxLength(255);

                entity.Property(e => e.Buyer).HasMaxLength(255);

                entity.Property(e => e.CalExchSales)
                    .HasColumnName("CAL_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.CalJobMonthlySales)
                    .HasColumnName("CAL_Job_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Cat).HasMaxLength(255);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(255);

                entity.Property(e => e.Cell).HasMaxLength(255);

                entity.Property(e => e.CellPcsPerHour)
                    .HasColumnName("Cell_Pcs_Per_Hour")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("Change_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangeDate2)
                    .HasColumnName("Change_Date_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Charfld1).HasMaxLength(255);

                entity.Property(e => e.Charfld11).HasMaxLength(255);

                entity.Property(e => e.Charfld2).HasMaxLength(255);

                entity.Property(e => e.Charfld3).HasMaxLength(255);

                entity.Property(e => e.Charfld4).HasMaxLength(255);

                entity.Property(e => e.Code45)
                    .HasColumnName("Code_45")
                    .HasMaxLength(255);

                entity.Property(e => e.Code46)
                    .HasColumnName("Code_46")
                    .HasMaxLength(255);

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.CommodityDescription)
                    .HasColumnName("Commodity_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.ComputedSalesTarget)
                    .HasColumnName("Computed_Sales_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.ConfigurationFlag).HasColumnName("Configuration_Flag");

                entity.Property(e => e.CostMethod)
                    .HasColumnName("Cost_Method")
                    .HasMaxLength(255);

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CountryOfOrigin)
                    .HasColumnName("Country_Of_Origin")
                    .HasMaxLength(255);

                entity.Property(e => e.CrankMatch)
                    .HasColumnName("Crank_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrentUnitCost).HasColumnName("Current_Unit_Cost");

                entity.Property(e => e.Cylinders).HasMaxLength(255);

                entity.Property(e => e.DateFirstStocked)
                    .HasColumnName("Date_First_Stocked")
                    .HasMaxLength(255);

                entity.Property(e => e.DaysSupply).HasColumnName("Days_Supply");

                entity.Property(e => e.DecJobSales)
                    .HasColumnName("Dec_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.DecSales)
                    .HasColumnName("Dec_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.DecWarrantySales)
                    .HasColumnName("Dec_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Decifld1).HasMaxLength(255);

                entity.Property(e => e.Decifld2).HasMaxLength(255);

                entity.Property(e => e.Decifld3).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Diesel).HasMaxLength(255);

                entity.Property(e => e.Displacement).HasMaxLength(255);

                entity.Property(e => e.DockToStock).HasColumnName("Dock-to-Stock");

                entity.Property(e => e.DrawingNumber)
                    .HasColumnName("Drawing_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.EarliestPlannedPurchaseReceipt)
                    .HasColumnName("Earliest_Planned_Purchase_Receipt")
                    .HasMaxLength(255);

                entity.Property(e => e.Ecn).HasColumnName("ECN");

                entity.Property(e => e.EnablePiecesInventory).HasColumnName("Enable_Pieces_Inventory");

                entity.Property(e => e.ExpeditedFixed).HasColumnName("Expedited_Fixed");

                entity.Property(e => e.ExpeditedVariable).HasColumnName("Expedited_Variable");

                entity.Property(e => e.Family).HasMaxLength(255);

                entity.Property(e => e.FamilyCode)
                    .HasColumnName("Family_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureString)
                    .HasColumnName("Feature_String")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureTemplate)
                    .HasColumnName("Feature_Template")
                    .HasMaxLength(255);

                entity.Property(e => e.FeaturedItem).HasColumnName("Featured_Item");

                entity.Property(e => e.FebJobSales)
                    .HasColumnName("Feb_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FebSales)
                    .HasColumnName("Feb_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FebWarrantySales)
                    .HasColumnName("Feb_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedLeadTime).HasColumnName("Fixed_Lead_Time");

                entity.Property(e => e.FixedOrderQty).HasColumnName("Fixed_Order_Qty");

                entity.Property(e => e.ForShortPrc)
                    .HasColumnName("For_Short_Prc")
                    .HasMaxLength(255);

                entity.Property(e => e.FullUpc)
                    .HasColumnName("Full_UPC")
                    .HasMaxLength(255);

                entity.Property(e => e.Gl)
                    .HasColumnName("GL")
                    .HasMaxLength(255);

                entity.Property(e => e.HeadMatch)
                    .HasColumnName("Head_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.HollanderReady)
                    .HasColumnName("Hollander_Ready")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallerNoteLine1)
                    .HasColumnName("Installer_Note_Line_1")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallerNoteLine2)
                    .HasColumnName("Installer_Note_Line_2")
                    .HasMaxLength(255);

                entity.Property(e => e.InvChangeName)
                    .HasColumnName("Inv_Change_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryLcl)
                    .HasColumnName("Inventory_LCL_%")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryType)
                    .HasColumnName("Inventory_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryUcl)
                    .HasColumnName("Inventory_UCL_%")
                    .HasMaxLength(255);

                entity.Property(e => e.IssueBy)
                    .HasColumnName("Issue_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemAttributeGroup)
                    .HasColumnName("Item_Attribute_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemAttributeGroupDescription)
                    .HasColumnName("Item_Attribute_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.JanJobSales)
                    .HasColumnName("Jan_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JanSales)
                    .HasColumnName("Jan_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JanWarrantySales)
                    .HasColumnName("Jan_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JobConfigurable).HasColumnName("Job_Configurable");

                entity.Property(e => e.JulJobSales)
                    .HasColumnName("Jul_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JulSales)
                    .HasColumnName("Jul_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JulWarrantySales)
                    .HasColumnName("Jul_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunJobSales)
                    .HasColumnName("Jun_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunSales)
                    .HasColumnName("Jun_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunWarrantySales)
                    .HasColumnName("Jun_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.LastChange)
                    .HasColumnName("Last_Change")
                    .HasMaxLength(255);

                entity.Property(e => e.LastImportDate)
                    .HasColumnName("Last_Import_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Li)
                    .HasColumnName("LI")
                    .HasMaxLength(255);

                entity.Property(e => e.LotAttributeGroup)
                    .HasColumnName("Lot_Attribute_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.LotAttributeGroupDescription)
                    .HasColumnName("Lot_Attribute_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LotPrefix)
                    .HasColumnName("Lot_Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.LotSize).HasColumnName("Lot_Size");

                entity.Property(e => e.LotTrack).HasColumnName("Lot_Track");

                entity.Property(e => e.LowLevel).HasColumnName("Low_Level");

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.ManufacturedYtd).HasColumnName("Manufactured_YTD");

                entity.Property(e => e.MarJobSales)
                    .HasColumnName("Mar_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MarSales)
                    .HasColumnName("Mar_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MarWarrantySales)
                    .HasColumnName("Mar_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialStatus)
                    .HasColumnName("Material_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.MayJobSales)
                    .HasColumnName("May_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MayLSSalesOkStk)
                    .HasColumnName("May_L_S_Sales_OK_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.MaySales)
                    .HasColumnName("May_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MayWarrantySales)
                    .HasColumnName("May_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MnoMtdLS)
                    .HasColumnName("MNO_MTD_L_S_")
                    .HasMaxLength(255);

                entity.Property(e => e.Mofr).HasMaxLength(255);

                entity.Property(e => e.Moto)
                    .HasColumnName("MOTO")
                    .HasMaxLength(255);

                entity.Property(e => e.MpsFlag).HasColumnName("MPS_Flag");

                entity.Property(e => e.MpsPlanFence)
                    .HasColumnName("MPS_Plan_Fence")
                    .HasMaxLength(255);

                entity.Property(e => e.MrpItem).HasColumnName("MRP_Item");

                entity.Property(e => e.MustUseFuturePosBeforeCreatingPlns)
                    .HasColumnName("Must_use_future_POs_before_creating_PLNs")
                    .HasMaxLength(255);

                entity.Property(e => e.NameSpace)
                    .HasColumnName("Name_Space")
                    .HasMaxLength(255);

                entity.Property(e => e.NatExchSales)
                    .HasColumnName("NAT_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NatJobMonthlySales)
                    .HasColumnName("Nat_Job_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NetChange).HasColumnName("Net_Change");

                entity.Property(e => e.NewBu)
                    .HasColumnName("New_BU")
                    .HasMaxLength(255);

                entity.Property(e => e.NewGlCode)
                    .HasColumnName("New_GL_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.NonNettableStock).HasColumnName("Non-Nettable_Stock");

                entity.Property(e => e.NovJobSales)
                    .HasColumnName("Nov_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NovSales)
                    .HasColumnName("Nov_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NovWarrantySales)
                    .HasColumnName("Nov_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctJobSales)
                    .HasColumnName("Oct_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctSales)
                    .HasColumnName("Oct_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctWarrantySales)
                    .HasColumnName("Oct_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OldFamilyCode)
                    .HasColumnName("Old_Family_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.OldProductCode)
                    .HasColumnName("Old_Product_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderConfigurable).HasColumnName("Order_Configurable");

                entity.Property(e => e.OrderMaximum).HasColumnName("Order_Maximum");

                entity.Property(e => e.OrderMinimum).HasColumnName("Order_Minimum");

                entity.Property(e => e.OrderMultiple).HasColumnName("Order_Multiple");

                entity.Property(e => e.Origin).HasMaxLength(255);

                entity.Property(e => e.Overview).HasMaxLength(255);

                entity.Property(e => e.PaperWork).HasColumnName("Paper_Work");

                entity.Property(e => e.PartNumber)
                    .HasColumnName("Part_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PassRequirements).HasColumnName("Pass_Requirements");

                entity.Property(e => e.PhantomFlag).HasColumnName("Phantom_Flag");

                entity.Property(e => e.PieceDimensionGroup)
                    .HasColumnName("Piece_Dimension_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.PieceDimensionGroupDescription)
                    .HasColumnName("Piece_Dimension_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.PlannedMfgSupplySwitching).HasColumnName("Planned_Mfg_Supply_Switching");

                entity.Property(e => e.PlannerCode)
                    .HasColumnName("Planner_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PoToleranceOver)
                    .HasColumnName("PO_Tolerance_Over")
                    .HasMaxLength(255);

                entity.Property(e => e.PoToleranceUnder)
                    .HasColumnName("PO_Tolerance_Under")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignLots).HasColumnName("Preassign_Lots");

                entity.Property(e => e.PreassignSerials).HasColumnName("Preassign_Serials");

                entity.Property(e => e.PreferenceCriterion)
                    .HasColumnName("Preference_Criterion")
                    .HasMaxLength(255);

                entity.Property(e => e.PreferredCoProductMix)
                    .HasColumnName("Preferred_Co-product_Mix")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintKitComponentsOnCustomerPaperwork).HasColumnName("Print_Kit_Components_on_Customer_Paperwork");

                entity.Property(e => e.ProductCode).HasColumnName("Product_Code");

                entity.Property(e => e.ProductionType)
                    .HasColumnName("Production_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchasedYtd).HasColumnName("Purchased_YTD");

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnName("Quantity_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityOrdered).HasColumnName("Quantity_Ordered");

                entity.Property(e => e.QuantityWip).HasColumnName("Quantity_WIP");

                entity.Property(e => e.RateDay).HasColumnName("Rate/Day");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("Reason_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.RecievedThisMonth)
                    .HasColumnName("Recieved_This_Month")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMtd)
                    .HasColumnName("Recoup_MTD")
                    .HasMaxLength(255);

                entity.Property(e => e.Release1)
                    .HasColumnName("Release_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Release2)
                    .HasColumnName("Release_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Release3)
                    .HasColumnName("Release_3")
                    .HasMaxLength(255);

                entity.Property(e => e.ReorderPoint).HasColumnName("Reorder_Point");

                entity.Property(e => e.ReservedForCustomerOrders).HasColumnName("Reserved_For_Customer_Orders");

                entity.Property(e => e.Revision).HasMaxLength(255);

                entity.Property(e => e.RevisionTrack).HasColumnName("Revision_Track");

                entity.Property(e => e.RevivaOnHand)
                    .HasColumnName("Reviva_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.SNPrefix)
                    .HasColumnName("S/N_Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.SNTrack).HasColumnName("S/N_Track");

                entity.Property(e => e.SafetyStock).HasColumnName("Safety_Stock");

                entity.Property(e => e.SafetyStockPercent).HasColumnName("Safety_Stock_Percent");

                entity.Property(e => e.SalesPace)
                    .HasColumnName("Sales_Pace")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesTotals)
                    .HasColumnName("Sales_Totals")
                    .HasMaxLength(255);

                entity.Property(e => e.SaveCurrentRevisionUponImport).HasColumnName("Save_Current_Revision_Upon_Import");

                entity.Property(e => e.ScreenTwoThirdsUpdated)
                    .HasColumnName("Screen_Two-Thirds_Updated")
                    .HasMaxLength(255);

                entity.Property(e => e.SepJobSales)
                    .HasColumnName("Sep_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.SepSales)
                    .HasColumnName("Sep_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.SepWarrantySales)
                    .HasColumnName("Sep_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Separation).HasMaxLength(255);

                entity.Property(e => e.SetupGroup)
                    .HasColumnName("Setup_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.ShelfLife)
                    .HasColumnName("Shelf_Life")
                    .HasMaxLength(255);

                entity.Property(e => e.ShowInDropDownLists).HasColumnName("Show_In_Drop-Down_Lists");

                entity.Property(e => e.ShrinkFactor).HasColumnName("Shrink_Factor");

                entity.Property(e => e.SoldYtd).HasColumnName("Sold_YTD");

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.StandardUnitCost).HasColumnName("Standard_Unit_Cost");

                entity.Property(e => e.StatusChangeUserCode)
                    .HasColumnName("Status_Change_User_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.StdDuePeriod)
                    .HasColumnName("Std_Due_Period")
                    .HasMaxLength(255);

                entity.Property(e => e.StockInSna)
                    .HasColumnName("Stock_in_SNA")
                    .HasMaxLength(255);

                entity.Property(e => e.SubjectToRvcRequirements).HasColumnName("Subject_To_RVC_Requirements");

                entity.Property(e => e.SupplySite)
                    .HasColumnName("Supply_Site")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyUsageTolerance).HasColumnName("Supply_Usage_Tolerance");

                entity.Property(e => e.SupplyWhse)
                    .HasColumnName("Supply_Whse")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetInvMax)
                    .HasColumnName("Target_Inv_Max")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetInvMin)
                    .HasColumnName("Target_Inv_Min")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetedSafetyStockReplenishment)
                    .HasColumnName("Targeted_Safety_Stock_Replenishment")
                    .HasMaxLength(255);

                entity.Property(e => e.TariffClassification)
                    .HasColumnName("Tariff_Classification")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCode1Uet)
                    .HasColumnName("Tax_Code_1_UET")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCodeDescription)
                    .HasColumnName("Tax_Code_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxFreeDays).HasColumnName("Tax_Free_Days");

                entity.Property(e => e.TaxFreeImportedMaterial).HasColumnName("Tax-Free_Imported_Material");

                entity.Property(e => e.TimeFenceRule)
                    .HasColumnName("Time_Fence_Rule")
                    .HasMaxLength(255);

                entity.Property(e => e.TimeFenceValue).HasColumnName("Time_Fence_Value");

                entity.Property(e => e.TopSeller).HasColumnName("Top_Seller");

                entity.Property(e => e.TotalTarget)
                    .HasColumnName("Total_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.TypeDefinition)
                    .HasColumnName("Type_Definition")
                    .HasMaxLength(255);

                entity.Property(e => e.UM)
                    .HasColumnName("U/M")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitWeight).HasColumnName("Unit_Weight");

                entity.Property(e => e.UpcCode)
                    .HasColumnName("UPC_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.UseReorderPoint).HasColumnName("Use_Reorder_Point");

                entity.Property(e => e.UsedEngineMatch)
                    .HasColumnName("Used_Engine_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.UsedYtd).HasColumnName("Used_YTD");

                entity.Property(e => e.User).HasMaxLength(255);

                entity.Property(e => e.VegeCode)
                    .HasColumnName("Vege_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.VinNumber)
                    .HasColumnName("Vin_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.VipAddOn)
                    .HasColumnName("VIP_Add_On")
                    .HasMaxLength(255);

                entity.Property(e => e.VirSales)
                    .HasColumnName("Vir_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WarBO)
                    .HasColumnName("War_B_O")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyReserve)
                    .HasColumnName("Warranty_Reserve")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantySales)
                    .HasColumnName("Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WdExchSales)
                    .HasColumnName("WD_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WdMonthlySales)
                    .HasColumnName("WD_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WeightUnits)
                    .HasColumnName("Weight_Units")
                    .HasMaxLength(255);

                entity.Property(e => e.WholesalePrice).HasColumnName("Wholesale_Price");

                entity.Property(e => e.XInterchange)
                    .HasColumnName("X_Interchange_#")
                    .HasMaxLength(255);

                entity.Property(e => e.Years).HasMaxLength(255);

                entity.Property(e => e.YrFr)
                    .HasColumnName("Yr_Fr")
                    .HasMaxLength(255);

                entity.Property(e => e.YrTo)
                    .HasColumnName("Yr_To")
                    .HasMaxLength(255);

                entity.Property(e => e._46TypeCode)
                    .HasColumnName("46_Type_Code")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportCc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_CC");

                entity.Property(e => e.CWhsNameStatic)
                    .HasColumnName("C(WhsNameStatic)")
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeCodePartNumber)
                    .HasColumnName("Charge_Code_Part_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.CostMethod)
                    .HasColumnName("Cost_Method")
                    .HasMaxLength(255);

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Description1).HasMaxLength(255);

                entity.Property(e => e.Dlsstk)
                    .HasColumnName("DLSStk")
                    .HasMaxLength(255);

                entity.Property(e => e.Dlstst)
                    .HasColumnName("DLStst")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstYears)
                    .HasColumnName("First_Years")
                    .HasMaxLength(255);

                entity.Property(e => e.FixOvhdCost).HasColumnName("Fix_Ovhd_Cost");

                entity.Property(e => e.FixedOvhdAcct).HasColumnName("Fixed_Ovhd_Acct");

                entity.Property(e => e.FixedOvhdAcctDescription)
                    .HasColumnName("Fixed_Ovhd_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedOvhdUnitCode1)
                    .HasColumnName("Fixed_Ovhd_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedOvhdUnitCode2).HasColumnName("Fixed_Ovhd_Unit_Code2");

                entity.Property(e => e.FixedOvhdUnitCode3)
                    .HasColumnName("Fixed_Ovhd_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedOvhdUnitCode4)
                    .HasColumnName("Fixed_Ovhd_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.HoldCode)
                    .HasColumnName("Hold_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.IssueBy)
                    .HasColumnName("Issue_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemOnHand)
                    .HasColumnName("Item_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemUM)
                    .HasColumnName("Item_U/_M")
                    .HasMaxLength(255);

                entity.Property(e => e.JaxStk)
                    .HasColumnName("JAX_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.Jaxtst)
                    .HasColumnName("JAXtst")
                    .HasMaxLength(255);

                entity.Property(e => e.KtyStock)
                    .HasColumnName("KTY_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.KtyTransit)
                    .HasColumnName("KTY_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborAcct).HasColumnName("Labor_Acct");

                entity.Property(e => e.LaborAcctDescription)
                    .HasColumnName("Labor_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborCost).HasColumnName("Labor_Cost");

                entity.Property(e => e.LaborUnitCode1)
                    .HasColumnName("Labor_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborUnitCode2).HasColumnName("Labor_Unit_Code2");

                entity.Property(e => e.LaborUnitCode3)
                    .HasColumnName("Labor_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborUnitCode4)
                    .HasColumnName("Labor_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.LastYears)
                    .HasColumnName("Last_Years")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.LocationDescription)
                    .HasColumnName("Location_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationOnHand)
                    .HasColumnName("Location_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationReserved).HasColumnName("Location_Reserved");

                entity.Property(e => e.LocationType)
                    .HasColumnName("Location_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.LotTrack).HasColumnName("Lot_Track");

                entity.Property(e => e.MaterialAcct).HasColumnName("Material_Acct");

                entity.Property(e => e.MaterialAcctDescription)
                    .HasColumnName("Material_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialCost).HasColumnName("Material_Cost");

                entity.Property(e => e.MaterialUnitCode1)
                    .HasColumnName("Material_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialUnitCode2).HasColumnName("Material_Unit_Code2");

                entity.Property(e => e.MaterialUnitCode3)
                    .HasColumnName("Material_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialUnitCode4)
                    .HasColumnName("Material_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.MaySnoStk)
                    .HasColumnName("May_SNO_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.NewPurBu)
                    .HasColumnName("New_Pur_BU")
                    .HasMaxLength(255);

                entity.Property(e => e.NewPurCostCenter)
                    .HasColumnName("New_Pur_Cost_Center_")
                    .HasMaxLength(255);

                entity.Property(e => e.NewPurGlCode)
                    .HasColumnName("New_Pur_GL_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.NonNettable).HasColumnName("Non-Nettable");

                entity.Property(e => e.OrlyStock)
                    .HasColumnName("Orly_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.OrlyTransit)
                    .HasColumnName("Orly_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideAcct).HasColumnName("Outside_Acct");

                entity.Property(e => e.OutsideAcctDescription)
                    .HasColumnName("Outside_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideCost).HasColumnName("Outside_Cost");

                entity.Property(e => e.OutsideUnitCode1)
                    .HasColumnName("Outside_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideUnitCode2).HasColumnName("Outside_Unit_Code2");

                entity.Property(e => e.OutsideUnitCode3)
                    .HasColumnName("Outside_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideUnitCode4)
                    .HasColumnName("Outside_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.PenTst)
                    .HasColumnName("PEN_Tst")
                    .HasMaxLength(255);

                entity.Property(e => e.PptDesc)
                    .HasColumnName("PPT_Desc")
                    .HasMaxLength(255);

                entity.Property(e => e.PptPartNo)
                    .HasColumnName("PPT_Part_No")
                    .HasMaxLength(255);

                entity.Property(e => e.ProStk)
                    .HasColumnName("PRO_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.RecoupMonth1)
                    .HasColumnName("Recoup_Month_1_")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth10)
                    .HasColumnName("Recoup_Month_10")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth11)
                    .HasColumnName("Recoup_Month_11")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth12)
                    .HasColumnName("Recoup_Month_12")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth2)
                    .HasColumnName("Recoup_Month_2")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth3)
                    .HasColumnName("Recoup_Month_3")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth4)
                    .HasColumnName("Recoup_Month_4")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth5)
                    .HasColumnName("Recoup_Month_5")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth6)
                    .HasColumnName("Recoup_Month_6_")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth7)
                    .HasColumnName("Recoup_Month_7")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth8)
                    .HasColumnName("Recoup_Month_8")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth9)
                    .HasColumnName("Recoup_Month_9")
                    .HasMaxLength(255);

                entity.Property(e => e.Rod2)
                    .HasColumnName("Rod_2_")
                    .HasMaxLength(255);

                entity.Property(e => e.SNTrack).HasColumnName("S/N_Track");

                entity.Property(e => e.SendToLkq)
                    .HasColumnName("Send_to_LKQ")
                    .HasMaxLength(255);

                entity.Property(e => e.SnaStk)
                    .HasColumnName("SNA_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.SnaTst)
                    .HasColumnName("SNA_Tst")
                    .HasMaxLength(255);

                entity.Property(e => e.SocalStock)
                    .HasColumnName("Socal_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.SocalTransit)
                    .HasColumnName("Socal_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalAvailableInventory)
                    .HasColumnName("Total_Available_Inventory")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalCost).HasColumnName("Total_Cost");

                entity.Property(e => e.TotalNonNettableStock)
                    .HasColumnName("Total_Non-Nettable_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalReservedCo).HasColumnName("Total_Reserved_CO");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UM)
                    .HasColumnName("U/M")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitCost).HasColumnName("Unit_Cost");

                entity.Property(e => e.VarOvhdCost).HasColumnName("Var_Ovhd_Cost");

                entity.Property(e => e.VarOvhdUnitCode1)
                    .HasColumnName("Var_Ovhd_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.VarOvhdUnitCode2).HasColumnName("Var_Ovhd_Unit_Code2");

                entity.Property(e => e.VarOvhdUnitCode3)
                    .HasColumnName("Var_Ovhd_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.VarOvhdUnitCode4)
                    .HasColumnName("Var_Ovhd_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.VariableOvhdAcct).HasColumnName("Variable_Ovhd_Acct");

                entity.Property(e => e.VariableOvhdAcctDescription)
                    .HasColumnName("Variable_Ovhd_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.Warehouse).HasMaxLength(255);

                entity.Property(e => e.WarehouseOnHand)
                    .HasColumnName("Warehouse_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10Avail)
                    .HasColumnName("Whse_10_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10Comm)
                    .HasColumnName("Whse_10_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10Mos1LS)
                    .HasColumnName("Whse_10_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10OnOrder)
                    .HasColumnName("Whse_10_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse11Avail)
                    .HasColumnName("Whse_11_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse11Comm)
                    .HasColumnName("Whse_11_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse11OnOrder)
                    .HasColumnName("Whse_11_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse12Avail).HasMaxLength(255);

                entity.Property(e => e.Whse12Comm)
                    .HasColumnName("Whse_12_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse12OnOrder)
                    .HasColumnName("Whse_12_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse13Avail)
                    .HasColumnName("Whse_13_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse13Comm)
                    .HasColumnName("Whse_13_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse13OnOrder)
                    .HasColumnName("Whse_13_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse14Avail)
                    .HasColumnName("Whse_14_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse14Comm)
                    .HasColumnName("Whse_14_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse14OnOrder)
                    .HasColumnName("Whse_14_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse15Avail)
                    .HasColumnName("Whse_15_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse15Comm)
                    .HasColumnName("Whse_15_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse15OnOrder)
                    .HasColumnName("Whse_15_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse16Avail)
                    .HasColumnName("Whse_16_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse16Comm)
                    .HasColumnName("Whse_16_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse16OnOrder)
                    .HasColumnName("Whse_16_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Allocated)
                    .HasColumnName("Whse_17_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos1LS)
                    .HasColumnName("Whse_17_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos2LS)
                    .HasColumnName("Whse_17_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos3LS)
                    .HasColumnName("Whse_17_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos4LS)
                    .HasColumnName("Whse_17_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos5LS)
                    .HasColumnName("Whse_17_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos6LS)
                    .HasColumnName("Whse_17_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Stock)
                    .HasColumnName("Whse_17_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Transit)
                    .HasColumnName("Whse_17_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Allocated)
                    .HasColumnName("Whse_18_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos1LS)
                    .HasColumnName("Whse_18_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos2LS)
                    .HasColumnName("Whse_18_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos3LS)
                    .HasColumnName("Whse_18_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos4LS)
                    .HasColumnName("Whse_18_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos5LS)
                    .HasColumnName("Whse_18_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos6LS)
                    .HasColumnName("Whse_18_mos_6_L_S_")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Stock)
                    .HasColumnName("Whse_18_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Transit)
                    .HasColumnName("Whse_18_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Allocated)
                    .HasColumnName("Whse_19_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos1LS)
                    .HasColumnName("Whse_19_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos2LS)
                    .HasColumnName("Whse_19_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos3LS)
                    .HasColumnName("Whse_19_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos4LS)
                    .HasColumnName("Whse_19_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos5LS)
                    .HasColumnName("Whse_19_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos6LS)
                    .HasColumnName("Whse_19_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Stock)
                    .HasColumnName("Whse_19_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Transit)
                    .HasColumnName("Whse_19_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1Avail)
                    .HasColumnName("Whse_1_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1Comm)
                    .HasColumnName("Whse_1_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1MtdLs)
                    .HasColumnName("Whse_1_MTD_LS_")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1OnOrder)
                    .HasColumnName("Whse_1_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1StkSeeNote1InNotes)
                    .HasColumnName("Whse_1_Stk_see_note_1_in_Notes")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1Tst)
                    .HasColumnName("Whse_1_Tst")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Allocated)
                    .HasColumnName("Whse_20_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos2LS)
                    .HasColumnName("Whse_20_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos3LS)
                    .HasColumnName("Whse_20_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos4LS)
                    .HasColumnName("Whse_20_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos5LS)
                    .HasColumnName("Whse_20_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos6LS)
                    .HasColumnName("Whse_20_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Stock)
                    .HasColumnName("Whse_20_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Transit)
                    .HasColumnName("Whse_20_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Allocated)
                    .HasColumnName("Whse_21_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos1LS)
                    .HasColumnName("Whse_21_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos2LS)
                    .HasColumnName("Whse_21_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos3LS)
                    .HasColumnName("Whse_21_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos4LS)
                    .HasColumnName("Whse_21_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos5LS)
                    .HasColumnName("Whse_21_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos6LS)
                    .HasColumnName("Whse_21_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos6LS1)
                    .HasColumnName("Whse_21_mos_6_L_S1")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Stock)
                    .HasColumnName("Whse_21_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Transit)
                    .HasColumnName("Whse_21_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Allocated)
                    .HasColumnName("Whse_22_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos1LS)
                    .HasColumnName("Whse_22_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos2LS)
                    .HasColumnName("Whse_22_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos3LS)
                    .HasColumnName("Whse_22_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos4LS)
                    .HasColumnName("Whse_22_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos5LS)
                    .HasColumnName("Whse_22_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos6LS)
                    .HasColumnName("Whse_22_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Stock)
                    .HasColumnName("Whse_22_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Transit)
                    .HasColumnName("Whse_22_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Allocated)
                    .HasColumnName("Whse_23_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos1LS)
                    .HasColumnName("Whse_23_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos2LS)
                    .HasColumnName("Whse_23_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos3LS)
                    .HasColumnName("Whse_23_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos4LS)
                    .HasColumnName("Whse_23_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos5LS)
                    .HasColumnName("Whse_23_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Stock)
                    .HasColumnName("Whse_23_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Transit)
                    .HasColumnName("Whse_23_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Allocated)
                    .HasColumnName("Whse_24_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos1LS)
                    .HasColumnName("Whse_24_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos2LS)
                    .HasColumnName("Whse_24_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos3LS)
                    .HasColumnName("Whse_24_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos4LS)
                    .HasColumnName("Whse_24_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos5LS)
                    .HasColumnName("Whse_24_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos6LS)
                    .HasColumnName("Whse_24_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Stock)
                    .HasColumnName("Whse_24_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Transit)
                    .HasColumnName("Whse_24_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Allocated)
                    .HasColumnName("Whse_25_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos1LS)
                    .HasColumnName("Whse_25_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos2LS)
                    .HasColumnName("Whse_25_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos3LS)
                    .HasColumnName("Whse_25_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos4LS)
                    .HasColumnName("Whse_25_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos5LS)
                    .HasColumnName("Whse_25_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos6LS)
                    .HasColumnName("Whse_25_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Stock)
                    .HasColumnName("Whse_25_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Transit)
                    .HasColumnName("Whse_25_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Allocated)
                    .HasColumnName("Whse_26_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos1LS)
                    .HasColumnName("Whse_26_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos2LS)
                    .HasColumnName("Whse_26_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos3LS)
                    .HasColumnName("Whse_26_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos4LS)
                    .HasColumnName("Whse_26_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos5LS)
                    .HasColumnName("Whse_26_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos6LS)
                    .HasColumnName("Whse_26_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Stock)
                    .HasColumnName("Whse_26_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Transit)
                    .HasColumnName("Whse_26_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Allocated)
                    .HasColumnName("Whse_27_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos1LS)
                    .HasColumnName("Whse_27_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos2LS)
                    .HasColumnName("Whse_27_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos3LS)
                    .HasColumnName("Whse_27_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos4LS)
                    .HasColumnName("Whse_27_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos5LS)
                    .HasColumnName("Whse_27_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos6LS)
                    .HasColumnName("Whse_27_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Stock)
                    .HasColumnName("Whse_27_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Transit)
                    .HasColumnName("Whse_27_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Allocated)
                    .HasColumnName("Whse_28_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Allocated1)
                    .HasColumnName("Whse_28_Allocated1")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos1LS)
                    .HasColumnName("Whse_28_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos2LS)
                    .HasColumnName("Whse_28_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos3LS)
                    .HasColumnName("Whse_28_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos4LS)
                    .HasColumnName("Whse_28_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos5LS)
                    .HasColumnName("Whse_28_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos6LS)
                    .HasColumnName("Whse_28_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Stock)
                    .HasColumnName("Whse_28_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Transit)
                    .HasColumnName("Whse_28_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos1LS)
                    .HasColumnName("Whse_29_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos2LS)
                    .HasColumnName("Whse_29_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos3LS)
                    .HasColumnName("Whse_29_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos4LS)
                    .HasColumnName("Whse_29_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos5LS)
                    .HasColumnName("Whse_29_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos6LS)
                    .HasColumnName("Whse_29_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Stock)
                    .HasColumnName("Whse_29_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Transit)
                    .HasColumnName("Whse_29_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Avail)
                    .HasColumnName("Whse_2_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Comm)
                    .HasColumnName("Whse_2_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2MtdLS)
                    .HasColumnName("Whse_2_MTD_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2OnOrder)
                    .HasColumnName("Whse_2_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Stock)
                    .HasColumnName("Whse_2_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Transit)
                    .HasColumnName("Whse_2_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse30Allocated)
                    .HasColumnName("Whse_30_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse30Mos1LS)
                    .HasColumnName("Whse_30_mos_1_L_S")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportCcintransit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_CCintransit");

                entity.Property(e => e.AbcCode)
                    .HasColumnName("ABC_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AcceptRequirements).HasColumnName("Accept_Requirements");

                entity.Property(e => e.ActiveForCustomerPortal).HasColumnName("Active_For_Customer_Portal");

                entity.Property(e => e.ActiveForDataIntegration).HasColumnName("Active_for_Data_Integration");

                entity.Property(e => e.AffiliateSales)
                    .HasColumnName("Affiliate_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AflExchSales)
                    .HasColumnName("AFL_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AllocatedToCustomerOrders).HasColumnName("Allocated_To_Customer_Orders");

                entity.Property(e => e.AllocatedToProd).HasColumnName("Allocated_To_Prod");

                entity.Property(e => e.AlternateItem)
                    .HasColumnName("Alternate_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.AprJobSales)
                    .HasColumnName("Apr_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AprSales)
                    .HasColumnName("Apr_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AprWarrantySales)
                    .HasColumnName("Apr_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AtkItem)
                    .HasColumnName("ATK_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.AtkSalesTarget)
                    .HasColumnName("ATK_Sales_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.AugJobSales)
                    .HasColumnName("Aug_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AugSales)
                    .HasColumnName("Aug_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AugWarrantySales)
                    .HasColumnName("Aug_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AutoJobGeneration)
                    .HasColumnName("Auto_Job_Generation")
                    .HasMaxLength(255);

                entity.Property(e => e.AutoReleaseWhenFirmed)
                    .HasColumnName("Auto_Release_When_Firmed")
                    .HasMaxLength(255);

                entity.Property(e => e.BackOrderQty)
                    .HasColumnName("Back_Order_Qty")
                    .HasMaxLength(255);

                entity.Property(e => e.BackflushLocation)
                    .HasColumnName("Backflush_Location")
                    .HasMaxLength(255);

                entity.Property(e => e.BeginningInventory)
                    .HasColumnName("Beginning_Inventory")
                    .HasMaxLength(255);

                entity.Property(e => e.BodyStyle)
                    .HasColumnName("Body_Style")
                    .HasMaxLength(255);

                entity.Property(e => e.Buyer).HasMaxLength(255);

                entity.Property(e => e.CalExchSales)
                    .HasColumnName("CAL_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.CalJobMonthlySales)
                    .HasColumnName("CAL_Job_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Cat).HasMaxLength(255);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(255);

                entity.Property(e => e.Cell).HasMaxLength(255);

                entity.Property(e => e.CellPcsPerHour)
                    .HasColumnName("Cell_Pcs_Per_Hour")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("Change_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangeDate2)
                    .HasColumnName("Change_Date_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Charfld1).HasMaxLength(255);

                entity.Property(e => e.Charfld11).HasMaxLength(255);

                entity.Property(e => e.Charfld2).HasMaxLength(255);

                entity.Property(e => e.Charfld3).HasMaxLength(255);

                entity.Property(e => e.Charfld4).HasMaxLength(255);

                entity.Property(e => e.Code45)
                    .HasColumnName("Code_45")
                    .HasMaxLength(255);

                entity.Property(e => e.Code46)
                    .HasColumnName("Code_46")
                    .HasMaxLength(255);

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.CommodityDescription)
                    .HasColumnName("Commodity_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.ComputedSalesTarget)
                    .HasColumnName("Computed_Sales_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.ConfigurationFlag).HasColumnName("Configuration_Flag");

                entity.Property(e => e.CostMethod)
                    .HasColumnName("Cost_Method")
                    .HasMaxLength(255);

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CountryOfOrigin)
                    .HasColumnName("Country_Of_Origin")
                    .HasMaxLength(255);

                entity.Property(e => e.CrankMatch)
                    .HasColumnName("Crank_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrentUnitCost)
                    .HasColumnName("Current_Unit_Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.Cylinders).HasMaxLength(255);

                entity.Property(e => e.DateFirstStocked)
                    .HasColumnName("Date_First_Stocked")
                    .HasMaxLength(255);

                entity.Property(e => e.DaysSupply).HasColumnName("Days_Supply");

                entity.Property(e => e.DecJobSales)
                    .HasColumnName("Dec_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.DecSales)
                    .HasColumnName("Dec_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.DecWarrantySales)
                    .HasColumnName("Dec_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Decifld1).HasMaxLength(255);

                entity.Property(e => e.Decifld2).HasMaxLength(255);

                entity.Property(e => e.Decifld3).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Diesel).HasMaxLength(255);

                entity.Property(e => e.Displacement).HasMaxLength(255);

                entity.Property(e => e.DockToStock).HasColumnName("Dock-to-Stock");

                entity.Property(e => e.DrawingNumber)
                    .HasColumnName("Drawing_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.EarliestPlannedPurchaseReceipt)
                    .HasColumnName("Earliest_Planned_Purchase_Receipt")
                    .HasMaxLength(255);

                entity.Property(e => e.Ecn).HasColumnName("ECN");

                entity.Property(e => e.EnablePiecesInventory).HasColumnName("Enable_Pieces_Inventory");

                entity.Property(e => e.ExpeditedFixed).HasColumnName("Expedited_Fixed");

                entity.Property(e => e.ExpeditedVariable).HasColumnName("Expedited_Variable");

                entity.Property(e => e.Family).HasMaxLength(255);

                entity.Property(e => e.FamilyCode)
                    .HasColumnName("Family_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureString)
                    .HasColumnName("Feature_String")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureTemplate)
                    .HasColumnName("Feature_Template")
                    .HasMaxLength(255);

                entity.Property(e => e.FeaturedItem).HasColumnName("Featured_Item");

                entity.Property(e => e.FebJobSales)
                    .HasColumnName("Feb_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FebSales)
                    .HasColumnName("Feb_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FebWarrantySales)
                    .HasColumnName("Feb_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedLeadTime).HasColumnName("Fixed_Lead_Time");

                entity.Property(e => e.FixedOrderQty).HasColumnName("Fixed_Order_Qty");

                entity.Property(e => e.ForShortPrc)
                    .HasColumnName("For_Short_Prc")
                    .HasMaxLength(255);

                entity.Property(e => e.FullUpc)
                    .HasColumnName("Full_UPC")
                    .HasMaxLength(255);

                entity.Property(e => e.Gl)
                    .HasColumnName("GL")
                    .HasMaxLength(255);

                entity.Property(e => e.HeadMatch)
                    .HasColumnName("Head_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.HollanderReady)
                    .HasColumnName("Hollander_Ready")
                    .HasMaxLength(255);

                entity.Property(e => e.ImpArt)
                    .HasColumnName("Imp#_Art#")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallerNoteLine1)
                    .HasColumnName("Installer_Note_Line_1")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallerNoteLine2)
                    .HasColumnName("Installer_Note_Line_2")
                    .HasMaxLength(255);

                entity.Property(e => e.InvChangeName)
                    .HasColumnName("Inv_Change_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryLcl)
                    .HasColumnName("Inventory_LCL_%")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryType)
                    .HasColumnName("Inventory_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryUcl)
                    .HasColumnName("Inventory_UCL_%")
                    .HasMaxLength(255);

                entity.Property(e => e.IssueBy)
                    .HasColumnName("Issue_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemAttributeGroup)
                    .HasColumnName("Item_Attribute_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemAttributeGroupDescription)
                    .HasColumnName("Item_Attribute_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.JanJobSales)
                    .HasColumnName("Jan_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JanSales)
                    .HasColumnName("Jan_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JanWarrantySales)
                    .HasColumnName("Jan_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JobConfigurable).HasColumnName("Job_Configurable");

                entity.Property(e => e.JulJobSales)
                    .HasColumnName("Jul_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JulSales)
                    .HasColumnName("Jul_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JulWarrantySales)
                    .HasColumnName("Jul_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunJobSales)
                    .HasColumnName("Jun_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunSales)
                    .HasColumnName("Jun_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunWarrantySales)
                    .HasColumnName("Jun_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.LastChange)
                    .HasColumnName("Last_Change")
                    .HasMaxLength(255);

                entity.Property(e => e.LastImportDate)
                    .HasColumnName("Last_Import_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Li)
                    .HasColumnName("LI")
                    .HasMaxLength(255);

                entity.Property(e => e.LotAttributeGroup)
                    .HasColumnName("Lot_Attribute_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.LotAttributeGroupDescription)
                    .HasColumnName("Lot_Attribute_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LotPrefix)
                    .HasColumnName("Lot_Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.LotSize).HasColumnName("Lot_Size");

                entity.Property(e => e.LotTrack).HasColumnName("Lot_Track");

                entity.Property(e => e.LowLevel).HasColumnName("Low_Level");

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.ManufacturedYtd).HasColumnName("Manufactured_YTD");

                entity.Property(e => e.MarJobSales)
                    .HasColumnName("Mar_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MarSales)
                    .HasColumnName("Mar_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MarWarrantySales)
                    .HasColumnName("Mar_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialStatus)
                    .HasColumnName("Material_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.MayJobSales)
                    .HasColumnName("May_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MayLSSalesOkStk)
                    .HasColumnName("May_L_S_Sales_OK_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.MaySales)
                    .HasColumnName("May_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MayWarrantySales)
                    .HasColumnName("May_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MnoMtdLS)
                    .HasColumnName("MNO_MTD_L_S_")
                    .HasMaxLength(255);

                entity.Property(e => e.Mofr).HasMaxLength(255);

                entity.Property(e => e.Moto)
                    .HasColumnName("MOTO")
                    .HasMaxLength(255);

                entity.Property(e => e.MpsFlag).HasColumnName("MPS_Flag");

                entity.Property(e => e.MpsPlanFence)
                    .HasColumnName("MPS_Plan_Fence")
                    .HasMaxLength(255);

                entity.Property(e => e.MrpItem).HasColumnName("MRP_Item");

                entity.Property(e => e.MustUseFuturePosBeforeCreatingPlns).HasColumnName("Must_use_future_POs_before_creating_PLNs");

                entity.Property(e => e.Name).HasColumnName("#NAME?");

                entity.Property(e => e.NameSpace)
                    .HasColumnName("Name_Space")
                    .HasMaxLength(255);

                entity.Property(e => e.NatExchSales)
                    .HasColumnName("NAT_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NatJobMonthlySales)
                    .HasColumnName("Nat_Job_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NetChange).HasColumnName("Net_Change");

                entity.Property(e => e.NewBu)
                    .HasColumnName("New_BU")
                    .HasMaxLength(255);

                entity.Property(e => e.NewGlCode)
                    .HasColumnName("New_GL_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.NonNettableStock).HasColumnName("Non-Nettable_Stock");

                entity.Property(e => e.NovJobSales)
                    .HasColumnName("Nov_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NovSales)
                    .HasColumnName("Nov_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NovWarrantySales)
                    .HasColumnName("Nov_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctJobSales)
                    .HasColumnName("Oct_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctSales)
                    .HasColumnName("Oct_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctWarrantySales)
                    .HasColumnName("Oct_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OldFamilyCode)
                    .HasColumnName("Old_Family_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.OldProductCode)
                    .HasColumnName("Old_Product_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderConfigurable).HasColumnName("Order_Configurable");

                entity.Property(e => e.OrderMaximum).HasColumnName("Order_Maximum");

                entity.Property(e => e.OrderMinimum).HasColumnName("Order_Minimum");

                entity.Property(e => e.OrderMultiple).HasColumnName("Order_Multiple");

                entity.Property(e => e.Origin).HasMaxLength(255);

                entity.Property(e => e.Overview).HasMaxLength(255);

                entity.Property(e => e.PaperWork).HasColumnName("Paper_Work");

                entity.Property(e => e.PartNumber)
                    .HasColumnName("Part_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PassRequirements).HasColumnName("Pass_Requirements");

                entity.Property(e => e.PhantomFlag).HasColumnName("Phantom_Flag");

                entity.Property(e => e.PieceDimensionGroup)
                    .HasColumnName("Piece_Dimension_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.PieceDimensionGroupDescription)
                    .HasColumnName("Piece_Dimension_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.PlannedMfgSupplySwitching).HasColumnName("Planned_Mfg_Supply_Switching");

                entity.Property(e => e.PlannerCode)
                    .HasColumnName("Planner_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PoToleranceOver)
                    .HasColumnName("PO_Tolerance_Over")
                    .HasMaxLength(255);

                entity.Property(e => e.PoToleranceUnder)
                    .HasColumnName("PO_Tolerance_Under")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignLots).HasColumnName("Preassign_Lots");

                entity.Property(e => e.PreassignSerials).HasColumnName("Preassign_Serials");

                entity.Property(e => e.PreferenceCriterion)
                    .HasColumnName("Preference_Criterion")
                    .HasMaxLength(255);

                entity.Property(e => e.PreferredCoProductMix)
                    .HasColumnName("Preferred_Co-product_Mix")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintKitComponentsOnCustomerPaperwork).HasColumnName("Print_Kit_Components_on_Customer_Paperwork");

                entity.Property(e => e.ProductCode).HasColumnName("Product_Code");

                entity.Property(e => e.ProductionType)
                    .HasColumnName("Production_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchasedYtd)
                    .HasColumnName("Purchased_YTD")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnName("Quantity_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityOrdered)
                    .HasColumnName("Quantity_Ordered")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityWip).HasColumnName("Quantity_WIP");

                entity.Property(e => e.RateDay).HasColumnName("Rate/Day");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("Reason_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.RecievedThisMonth)
                    .HasColumnName("Recieved_This_Month")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMtd)
                    .HasColumnName("Recoup_MTD")
                    .HasMaxLength(255);

                entity.Property(e => e.Release1)
                    .HasColumnName("Release_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Release2)
                    .HasColumnName("Release_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Release3)
                    .HasColumnName("Release_3")
                    .HasMaxLength(255);

                entity.Property(e => e.ReorderPoint)
                    .HasColumnName("Reorder_Point")
                    .HasMaxLength(50);

                entity.Property(e => e.ReservedForCustomerOrders).HasColumnName("Reserved_For_Customer_Orders");

                entity.Property(e => e.Revision).HasMaxLength(255);

                entity.Property(e => e.RevisionTrack).HasColumnName("Revision_Track");

                entity.Property(e => e.SNPrefix)
                    .HasColumnName("S/N_Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.SNTrack).HasColumnName("S/N_Track");

                entity.Property(e => e.SafetyStock)
                    .HasColumnName("Safety_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.SafetyStockPercent).HasColumnName("Safety_Stock_Percent");

                entity.Property(e => e.SalesPace)
                    .HasColumnName("Sales_Pace")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesTotals)
                    .HasColumnName("Sales_Totals")
                    .HasMaxLength(255);

                entity.Property(e => e.SaveCurrentRevisionUponImport).HasColumnName("Save_Current_Revision_Upon_Import");

                entity.Property(e => e.ScreenTwoThirdsUpdated)
                    .HasColumnName("Screen_Two-Thirds_Updated")
                    .HasMaxLength(255);

                entity.Property(e => e.SepJobSales)
                    .HasColumnName("Sep_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.SepSales)
                    .HasColumnName("Sep_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.SepWarrantySales)
                    .HasColumnName("Sep_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Separation).HasMaxLength(255);

                entity.Property(e => e.SetupGroup)
                    .HasColumnName("Setup_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.ShelfLife)
                    .HasColumnName("Shelf_Life")
                    .HasMaxLength(255);

                entity.Property(e => e.ShowInDropDownLists).HasColumnName("Show_In_Drop-Down_Lists");

                entity.Property(e => e.ShrinkFactor).HasColumnName("Shrink_Factor");

                entity.Property(e => e.SoldYtd).HasColumnName("Sold_YTD");

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.StandardUnitCost)
                    .HasColumnName("Standard_Unit_Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusChangeUserCode)
                    .HasColumnName("Status_Change_User_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.StdDuePeriod)
                    .HasColumnName("Std_Due_Period")
                    .HasMaxLength(255);

                entity.Property(e => e.StockInSna)
                    .HasColumnName("Stock_in_SNA")
                    .HasMaxLength(255);

                entity.Property(e => e.SubjectToRvcRequirements).HasColumnName("Subject_To_RVC_Requirements");

                entity.Property(e => e.SupplySite)
                    .HasColumnName("Supply_Site")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyUsageTolerance).HasColumnName("Supply_Usage_Tolerance");

                entity.Property(e => e.SupplyWhse)
                    .HasColumnName("Supply_Whse")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetInvMax)
                    .HasColumnName("Target_Inv_Max")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetInvMin)
                    .HasColumnName("Target_Inv_Min")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetedSafetyStockReplenishment)
                    .HasColumnName("Targeted_Safety_Stock_Replenishment")
                    .HasMaxLength(255);

                entity.Property(e => e.TariffClassification)
                    .HasColumnName("Tariff_Classification")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCode1Uet)
                    .HasColumnName("Tax_Code_1_UET")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCodeDescription)
                    .HasColumnName("Tax_Code_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxFreeDays).HasColumnName("Tax_Free_Days");

                entity.Property(e => e.TaxFreeImportedMaterial).HasColumnName("Tax-Free_Imported_Material");

                entity.Property(e => e.TimeFenceRule)
                    .HasColumnName("Time_Fence_Rule")
                    .HasMaxLength(255);

                entity.Property(e => e.TimeFenceValue).HasColumnName("Time_Fence_Value");

                entity.Property(e => e.TopSeller).HasColumnName("Top_Seller");

                entity.Property(e => e.TotalTarget)
                    .HasColumnName("Total_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.TypeDefinition)
                    .HasColumnName("Type_Definition")
                    .HasMaxLength(255);

                entity.Property(e => e.UM)
                    .HasColumnName("U/M")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitWeight).HasColumnName("Unit_Weight");

                entity.Property(e => e.UpcCode)
                    .HasColumnName("UPC_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.UseReorderPoint).HasColumnName("Use_Reorder_Point");

                entity.Property(e => e.UsedEngineMatch)
                    .HasColumnName("Used_Engine_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.UsedYtd)
                    .HasColumnName("Used_YTD")
                    .HasMaxLength(255);

                entity.Property(e => e.User).HasMaxLength(255);

                entity.Property(e => e.VegeCode)
                    .HasColumnName("Vege_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.VinNumber)
                    .HasColumnName("Vin_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.VipAddOn)
                    .HasColumnName("VIP_Add_On")
                    .HasMaxLength(255);

                entity.Property(e => e.VirSales)
                    .HasColumnName("Vir_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WarBO)
                    .HasColumnName("War_B_O")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyReserve)
                    .HasColumnName("Warranty_Reserve")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantySales)
                    .HasColumnName("Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WdExchSales)
                    .HasColumnName("WD_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WdMonthlySales)
                    .HasColumnName("WD_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WeightUnits)
                    .HasColumnName("Weight_Units")
                    .HasMaxLength(255);

                entity.Property(e => e.WholesalePrice).HasColumnName("Wholesale_Price");

                entity.Property(e => e.XInterchange)
                    .HasColumnName("X_Interchange_#")
                    .HasMaxLength(255);

                entity.Property(e => e.Years).HasMaxLength(255);

                entity.Property(e => e.YrFr)
                    .HasColumnName("Yr_Fr")
                    .HasMaxLength(255);

                entity.Property(e => e.YrTo)
                    .HasColumnName("Yr_To")
                    .HasMaxLength(255);

                entity.Property(e => e._46TypeCode)
                    .HasColumnName("46_Type_Code")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportCoreConversion>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logistics_Marching_Report_CoreConversion");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Componente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoreDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRelacion).HasColumnName("ID_Relacion");

                entity.Property(e => e.MotorId).HasColumnName("MotorID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisticsMarchingReportCores>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Logistics_Marching_Report_Cores");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Core)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisticsMarchingReportDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Delete");

                entity.Property(e => e.Atk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Core)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroDelete)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Line)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineData)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineMarching)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Part)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroDeleteId).HasColumnName("UsuarioRegistroDeleteID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.Vege)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsMarchingReportInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Info");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<LogisticsMarchingReportJobsFirm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_JobsFirm");

                entity.Property(e => e.ActualPistonSize)
                    .HasColumnName("Actual_Piston_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.Breed).HasMaxLength(255);

                entity.Property(e => e.CamLineBoreSize)
                    .HasColumnName("Cam_Line_Bore_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.CamMainJournalSize)
                    .HasColumnName("Cam_Main_Journal_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.Cart).HasMaxLength(255);

                entity.Property(e => e.Cart1).HasMaxLength(255);

                entity.Property(e => e.CoProductMix)
                    .HasColumnName("Co-product_Mix")
                    .HasMaxLength(255);

                entity.Property(e => e.ComponentTagNumber)
                    .HasColumnName("Component_Tag_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Compression).HasMaxLength(255);

                entity.Property(e => e.CoreSN)
                    .HasColumnName("Core_S/N")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudget)
                    .HasColumnName("Cost_Budget")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit1)
                    .HasColumnName("Cost_Budget_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit2)
                    .HasColumnName("Cost_Budget_Acct_Unit2")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit3)
                    .HasColumnName("Cost_Budget_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit4)
                    .HasColumnName("Cost_Budget_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Description1).HasMaxLength(255);

                entity.Property(e => e.Destination).HasMaxLength(255);

                entity.Property(e => e.DestinationLineSuffix).HasColumnName("Destination_Line-Suffix");

                entity.Property(e => e.DestinationRelease).HasColumnName("Destination_Release");

                entity.Property(e => e.DestinationType)
                    .HasColumnName("Destination_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Ecn)
                    .HasColumnName("ECN")
                    .HasMaxLength(255);

                entity.Property(e => e.End).HasMaxLength(255);

                entity.Property(e => e.EstJob)
                    .HasColumnName("Est_Job")
                    .HasMaxLength(255);

                entity.Property(e => e.EstJobSuffix).HasColumnName("Est_Job_Suffix");

                entity.Property(e => e.ExternalOrder)
                    .HasColumnName("External_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.FinishJob)
                    .HasColumnName("Finish_Job")
                    .HasMaxLength(255);

                entity.Property(e => e.FinishJobSuffix).HasColumnName("Finish_Job_Suffix");

                entity.Property(e => e.ForWhse)
                    .HasColumnName("For_Whse")
                    .HasMaxLength(255);

                entity.Property(e => e.FrontSleeve)
                    .HasColumnName("Front_Sleeve")
                    .HasMaxLength(255);

                entity.Property(e => e.Inspector).HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.Job).HasMaxLength(255);

                entity.Property(e => e.JobDate)
                    .HasColumnName("Job_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.JobPicked)
                    .HasColumnName("Job_Picked")
                    .HasMaxLength(255);

                entity.Property(e => e.JobSuffix).HasColumnName("Job_Suffix");

                entity.Property(e => e.Junked).HasMaxLength(255);

                entity.Property(e => e.LastOperationCompleted)
                    .HasColumnName("Last_Operation_Completed")
                    .HasMaxLength(255);

                entity.Property(e => e.LastTransactionDate)
                    .HasColumnName("Last_Transaction_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.LkqbwaSerialNumber)
                    .HasColumnName("LKQBWA_Serial_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.LowLevel).HasColumnName("Low_Level");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OilFlow)
                    .HasColumnName("Oil_Flow")
                    .HasMaxLength(255);

                entity.Property(e => e.OilPressureEnd)
                    .HasColumnName("Oil_Pressure_End")
                    .HasMaxLength(255);

                entity.Property(e => e.OilPressureStart)
                    .HasColumnName("Oil_Pressure_Start")
                    .HasMaxLength(255);

                entity.Property(e => e.OpCold)
                    .HasColumnName("OP_Cold")
                    .HasMaxLength(255);

                entity.Property(e => e.OpHot)
                    .HasColumnName("OP_Hot_")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.OutputType)
                    .HasColumnName("Output_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentJob)
                    .HasColumnName("Parent_Job")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentJobSuffix).HasColumnName("Parent_Job_Suffix");

                entity.Property(e => e.ParkingSpot)
                    .HasColumnName("Parking_Spot")
                    .HasMaxLength(255);

                entity.Property(e => e.PistonProtrusion)
                    .HasColumnName("Piston_Protrusion")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanOnSave)
                    .HasColumnName("Plan_On_Save")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignLots)
                    .HasColumnName("Preassign_Lots")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignSerials)
                    .HasColumnName("Preassign_Serials")
                    .HasMaxLength(255);

                entity.Property(e => e.PriorityFreeze)
                    .HasColumnName("Priority_Freeze")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionDate)
                    .HasColumnName("Production_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionNumber)
                    .HasColumnName("Production_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionPosition)
                    .HasColumnName("Production_Position")
                    .HasMaxLength(255);

                entity.Property(e => e.Projected).HasMaxLength(255);

                entity.Property(e => e.QtyOrdered).HasColumnName("Qty_Ordered");

                entity.Property(e => e.Ready).HasMaxLength(255);

                entity.Property(e => e.RearSleeve)
                    .HasColumnName("Rear_Sleeve")
                    .HasMaxLength(255);

                entity.Property(e => e.Revision).HasMaxLength(255);

                entity.Property(e => e.Rework).HasMaxLength(255);

                entity.Property(e => e.RodBigEndSize)
                    .HasColumnName("Rod_Big_End_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.SBinLocation)
                    .HasColumnName("sBinLocation")
                    .HasMaxLength(255);

                entity.Property(e => e.SCrankThrust)
                    .HasColumnName("sCrankThrust")
                    .HasMaxLength(255);

                entity.Property(e => e.SN)
                    .HasColumnName("S/N")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheduled).HasMaxLength(255);

                entity.Property(e => e.Start).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.Status1).HasMaxLength(255);

                entity.Property(e => e.TestDate)
                    .HasColumnName("Test_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Tester).HasMaxLength(255);

                entity.Property(e => e.Tester1).HasMaxLength(255);

                entity.Property(e => e.TotalWip).HasColumnName("Total_WIP");

                entity.Property(e => e.UnlinkedReference).HasColumnName("Unlinked_Reference");

                entity.Property(e => e.Vacuum).HasMaxLength(255);

                entity.Property(e => e.ValveGuideSize)
                    .HasColumnName("Valve_Guide_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.WaterTemp)
                    .HasColumnName("Water_Temp")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcct).HasColumnName("WIP_Fovhd_Acct");

                entity.Property(e => e.WipFovhdAcctUnit1)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcctUnit2).HasColumnName("WIP_Fovhd_Acct_Unit_2");

                entity.Property(e => e.WipFovhdAcctUnit3)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcctUnit4)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdTotal).HasColumnName("WIP_Fovhd_Total");

                entity.Property(e => e.WipLaborAcct).HasColumnName("WIP_Labor_Acct");

                entity.Property(e => e.WipLaborAcctUnit1)
                    .HasColumnName("WIP_Labor_Acct_Unit1")
                    .HasColumnType("datetime");

                entity.Property(e => e.WipLaborAcctUnit2).HasColumnName("WIP_Labor_Acct_Unit2");

                entity.Property(e => e.WipLaborAcctUnit3)
                    .HasColumnName("WIP_Labor_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborAcctUnit4)
                    .HasColumnName("WIP_Labor_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborTotal).HasColumnName("WIP_Labor_Total");

                entity.Property(e => e.WipMatlAcct).HasColumnName("WIP_Matl_Acct");

                entity.Property(e => e.WipMatlAcctUnit1)
                    .HasColumnName("WIP_Matl_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcctUnit2).HasColumnName("WIP_Matl_Acct_Unit2");

                entity.Property(e => e.WipMatlAcctUnit3)
                    .HasColumnName("WIP_Matl_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcctUnit4)
                    .HasColumnName("WIP_Matl_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlTotal).HasColumnName("WIP_Matl_Total");

                entity.Property(e => e.WipOutsideAcct).HasColumnName("WIP_Outside_Acct");

                entity.Property(e => e.WipOutsideAcctUnit1)
                    .HasColumnName("WIP_Outside_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcctUnit2).HasColumnName("WIP_Outside_Acct_Unit2");

                entity.Property(e => e.WipOutsideAcctUnit3)
                    .HasColumnName("WIP_Outside_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcctUnit4)
                    .HasColumnName("WIP_Outside_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideTotal).HasColumnName("WIP_Outside_Total");

                entity.Property(e => e.WipVovhdAcct).HasColumnName("WIP_Vovhd_Acct");

                entity.Property(e => e.WipVovhdAcctUnit1)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcctUnit2).HasColumnName("WIP_Vovhd_Acct_Unit_2");

                entity.Property(e => e.WipVovhdAcctUnit3)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcctUnit4)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdTotal).HasColumnName("WIP_Vovhd_Total");
            });

            modelBuilder.Entity<LogisticsMarchingReportJobsRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_JobsRelease");

                entity.Property(e => e.ActualPistonSize)
                    .HasColumnName("Actual_Piston_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.Breed).HasMaxLength(255);

                entity.Property(e => e.CamLineBoreSize)
                    .HasColumnName("Cam_Line_Bore_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.CamMainJournalSize)
                    .HasColumnName("Cam_Main_Journal_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.Cart).HasMaxLength(255);

                entity.Property(e => e.Cart1).HasMaxLength(255);

                entity.Property(e => e.CoProductMix)
                    .HasColumnName("Co-product_Mix")
                    .HasMaxLength(255);

                entity.Property(e => e.ComponentTagNumber)
                    .HasColumnName("Component_Tag_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Compression).HasMaxLength(255);

                entity.Property(e => e.CoreSN)
                    .HasColumnName("Core_S/N")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudget)
                    .HasColumnName("Cost_Budget")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit1)
                    .HasColumnName("Cost_Budget_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit2)
                    .HasColumnName("Cost_Budget_Acct_Unit2")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit3)
                    .HasColumnName("Cost_Budget_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudgetAcctUnit4)
                    .HasColumnName("Cost_Budget_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Description1).HasMaxLength(255);

                entity.Property(e => e.Destination).HasMaxLength(255);

                entity.Property(e => e.DestinationLineSuffix).HasColumnName("Destination_Line-Suffix");

                entity.Property(e => e.DestinationRelease).HasColumnName("Destination_Release");

                entity.Property(e => e.DestinationType)
                    .HasColumnName("Destination_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Ecn)
                    .HasColumnName("ECN")
                    .HasMaxLength(255);

                entity.Property(e => e.End).HasMaxLength(255);

                entity.Property(e => e.EstJob)
                    .HasColumnName("Est_Job")
                    .HasMaxLength(255);

                entity.Property(e => e.EstJobSuffix).HasColumnName("Est_Job_Suffix");

                entity.Property(e => e.ExternalOrder)
                    .HasColumnName("External_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.FinishJob)
                    .HasColumnName("Finish_Job")
                    .HasMaxLength(255);

                entity.Property(e => e.FinishJobSuffix).HasColumnName("Finish_Job_Suffix");

                entity.Property(e => e.ForWhse)
                    .HasColumnName("For_Whse")
                    .HasMaxLength(255);

                entity.Property(e => e.FrontSleeve)
                    .HasColumnName("Front_Sleeve")
                    .HasMaxLength(255);

                entity.Property(e => e.Inspector).HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.Job).HasMaxLength(255);

                entity.Property(e => e.JobDate)
                    .HasColumnName("Job_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.JobPicked)
                    .HasColumnName("Job_Picked")
                    .HasMaxLength(255);

                entity.Property(e => e.JobSuffix).HasColumnName("Job_Suffix");

                entity.Property(e => e.Junked).HasMaxLength(255);

                entity.Property(e => e.LastOperationCompleted).HasColumnName("Last_Operation_Completed");

                entity.Property(e => e.LastTransactionDate)
                    .HasColumnName("Last_Transaction_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.LkqbwaSerialNumber)
                    .HasColumnName("LKQBWA_Serial_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.LowLevel).HasColumnName("Low_Level");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OilFlow)
                    .HasColumnName("Oil_Flow")
                    .HasMaxLength(255);

                entity.Property(e => e.OilPressureEnd)
                    .HasColumnName("Oil_Pressure_End")
                    .HasMaxLength(255);

                entity.Property(e => e.OilPressureStart)
                    .HasColumnName("Oil_Pressure_Start")
                    .HasMaxLength(255);

                entity.Property(e => e.OpCold)
                    .HasColumnName("OP_Cold")
                    .HasMaxLength(255);

                entity.Property(e => e.OpHot)
                    .HasColumnName("OP_Hot_")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.OutputType)
                    .HasColumnName("Output_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentJob)
                    .HasColumnName("Parent_Job")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentJobSuffix).HasColumnName("Parent_Job_Suffix");

                entity.Property(e => e.ParkingSpot)
                    .HasColumnName("Parking_Spot")
                    .HasMaxLength(255);

                entity.Property(e => e.PistonProtrusion)
                    .HasColumnName("Piston_Protrusion")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanOnSave)
                    .HasColumnName("Plan_On_Save")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignLots)
                    .HasColumnName("Preassign_Lots")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignSerials)
                    .HasColumnName("Preassign_Serials")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority).HasMaxLength(255);

                entity.Property(e => e.PriorityFreeze)
                    .HasColumnName("Priority_Freeze")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionDate)
                    .HasColumnName("Production_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionNumber)
                    .HasColumnName("Production_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionPosition)
                    .HasColumnName("Production_Position")
                    .HasMaxLength(255);

                entity.Property(e => e.Projected).HasMaxLength(255);

                entity.Property(e => e.QtyOrdered).HasColumnName("Qty_Ordered");

                entity.Property(e => e.Ready).HasMaxLength(255);

                entity.Property(e => e.RearSleeve)
                    .HasColumnName("Rear_Sleeve")
                    .HasMaxLength(255);

                entity.Property(e => e.Revision).HasMaxLength(255);

                entity.Property(e => e.Rework).HasMaxLength(255);

                entity.Property(e => e.RodBigEndSize)
                    .HasColumnName("Rod_Big_End_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.SBinLocation)
                    .HasColumnName("sBinLocation")
                    .HasMaxLength(255);

                entity.Property(e => e.SCrankThrust)
                    .HasColumnName("sCrankThrust")
                    .HasMaxLength(255);

                entity.Property(e => e.SN)
                    .HasColumnName("S/N")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheduled).HasMaxLength(255);

                entity.Property(e => e.Start).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.Status1).HasMaxLength(255);

                entity.Property(e => e.TestDate)
                    .HasColumnName("Test_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Tester).HasMaxLength(255);

                entity.Property(e => e.Tester1).HasMaxLength(255);

                entity.Property(e => e.TotalWip)
                    .HasColumnName("Total_WIP")
                    .HasMaxLength(255);

                entity.Property(e => e.UnlinkedReference).HasColumnName("Unlinked_Reference");

                entity.Property(e => e.Vacuum).HasMaxLength(255);

                entity.Property(e => e.ValveGuideSize)
                    .HasColumnName("Valve_Guide_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.WaterTemp)
                    .HasColumnName("Water_Temp")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcct)
                    .HasColumnName("WIP_Fovhd_Acct")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcctUnit1)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcctUnit2)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_2")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcctUnit3)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdAcctUnit4)
                    .HasColumnName("WIP_Fovhd_Acct_Unit_4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipFovhdTotal)
                    .HasColumnName("WIP_Fovhd_Total")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborAcct)
                    .HasColumnName("WIP_Labor_Acct")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborAcctUnit1)
                    .HasColumnName("WIP_Labor_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborAcctUnit2)
                    .HasColumnName("WIP_Labor_Acct_Unit2")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborAcctUnit3)
                    .HasColumnName("WIP_Labor_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborAcctUnit4)
                    .HasColumnName("WIP_Labor_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipLaborTotal)
                    .HasColumnName("WIP_Labor_Total")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcct)
                    .HasColumnName("WIP_Matl_Acct")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcctUnit1)
                    .HasColumnName("WIP_Matl_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcctUnit2)
                    .HasColumnName("WIP_Matl_Acct_Unit2")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcctUnit3)
                    .HasColumnName("WIP_Matl_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlAcctUnit4)
                    .HasColumnName("WIP_Matl_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipMatlTotal)
                    .HasColumnName("WIP_Matl_Total")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcct)
                    .HasColumnName("WIP_Outside_Acct")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcctUnit1)
                    .HasColumnName("WIP_Outside_Acct_Unit1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcctUnit2)
                    .HasColumnName("WIP_Outside_Acct_Unit2")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcctUnit3)
                    .HasColumnName("WIP_Outside_Acct_Unit3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideAcctUnit4)
                    .HasColumnName("WIP_Outside_Acct_Unit4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipOutsideTotal)
                    .HasColumnName("WIP_Outside_Total")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcct)
                    .HasColumnName("WIP_Vovhd_Acct")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcctUnit1)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_1")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcctUnit2)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_2")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcctUnit3)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_3")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdAcctUnit4)
                    .HasColumnName("WIP_Vovhd_Acct_Unit_4")
                    .HasMaxLength(255);

                entity.Property(e => e.WipVovhdTotal)
                    .HasColumnName("WIP_Vovhd_Total")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportProductionReview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_ProductionReview");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.CItem)
                    .HasColumnName("C_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.CK7Core)
                    .HasColumnName("C_K7_Core")
                    .HasMaxLength(255);

                entity.Property(e => e.CNonNettable)
                    .HasColumnName("C_Non_Nettable")
                    .HasMaxLength(255);

                entity.Property(e => e.COnOrder)
                    .HasColumnName("C_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.CStock)
                    .HasColumnName("C_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.D70).HasMaxLength(255);

                entity.Property(e => e.K10Core)
                    .HasColumnName("K10_Core")
                    .HasMaxLength(255);

                entity.Property(e => e.K70).HasMaxLength(255);

                entity.Property(e => e.PDescription)
                    .HasColumnName("P_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.PItem1)
                    .HasColumnName("P_item1")
                    .HasMaxLength(255);

                entity.Property(e => e.PK7Core)
                    .HasColumnName("P_K7_Core")
                    .HasMaxLength(255);

                entity.Property(e => e.PQtyNonNettable)
                    .HasColumnName("P_Qty_Non_Nettable")
                    .HasMaxLength(255);

                entity.Property(e => e.PQtyOnOrder)
                    .HasColumnName("P_qty_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.PQtyOpen)
                    .HasColumnName("P_Qty_Open")
                    .HasMaxLength(255);

                entity.Property(e => e.PQtyRel1)
                    .HasColumnName("P_Qty_Rel1")
                    .HasMaxLength(255);

                entity.Property(e => e.PQtyStock)
                    .HasColumnName("P_qty_stock")
                    .HasMaxLength(255);

                entity.Property(e => e.ProdCode1).HasMaxLength(255);

                entity.Property(e => e.Rank).HasMaxLength(255);

                entity.Property(e => e.Required).HasMaxLength(255);

                entity.Property(e => e.VItem)
                    .HasColumnName("V_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.Wip)
                    .HasColumnName("WIP")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportPt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_PT");

                entity.Property(e => e.CWhsNameStatic)
                    .HasColumnName("C(WhsNameStatic)")
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeCodePartNumber)
                    .HasColumnName("Charge_Code_Part_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.CostMethod)
                    .HasColumnName("Cost_Method")
                    .HasMaxLength(255);

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Description1).HasMaxLength(255);

                entity.Property(e => e.Dlsstk)
                    .HasColumnName("DLSStk")
                    .HasMaxLength(255);

                entity.Property(e => e.Dlstst)
                    .HasColumnName("DLStst")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstYears)
                    .HasColumnName("First_Years")
                    .HasMaxLength(255);

                entity.Property(e => e.FixOvhdCost).HasColumnName("Fix_Ovhd_Cost");

                entity.Property(e => e.FixedOvhdAcct).HasColumnName("Fixed_Ovhd_Acct");

                entity.Property(e => e.FixedOvhdAcctDescription)
                    .HasColumnName("Fixed_Ovhd_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedOvhdUnitCode1)
                    .HasColumnName("Fixed_Ovhd_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedOvhdUnitCode2).HasColumnName("Fixed_Ovhd_Unit_Code2");

                entity.Property(e => e.FixedOvhdUnitCode3)
                    .HasColumnName("Fixed_Ovhd_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedOvhdUnitCode4)
                    .HasColumnName("Fixed_Ovhd_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.HoldCode)
                    .HasColumnName("Hold_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.IssueBy)
                    .HasColumnName("Issue_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemOnHand)
                    .HasColumnName("Item_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemUM)
                    .HasColumnName("Item_U/_M")
                    .HasMaxLength(255);

                entity.Property(e => e.JaxStk)
                    .HasColumnName("JAX_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.Jaxtst)
                    .HasColumnName("JAXtst")
                    .HasMaxLength(255);

                entity.Property(e => e.KtyStock)
                    .HasColumnName("KTY_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.KtyTransit)
                    .HasColumnName("KTY_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborAcct).HasColumnName("Labor_Acct");

                entity.Property(e => e.LaborAcctDescription)
                    .HasColumnName("Labor_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborCost).HasColumnName("Labor_Cost");

                entity.Property(e => e.LaborUnitCode1)
                    .HasColumnName("Labor_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborUnitCode2).HasColumnName("Labor_Unit_Code2");

                entity.Property(e => e.LaborUnitCode3)
                    .HasColumnName("Labor_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborUnitCode4)
                    .HasColumnName("Labor_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.LastYears)
                    .HasColumnName("Last_Years")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.LocationDescription)
                    .HasColumnName("Location_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationOnHand)
                    .HasColumnName("Location_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationReserved).HasColumnName("Location_Reserved");

                entity.Property(e => e.LocationType)
                    .HasColumnName("Location_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.LotTrack).HasColumnName("Lot_Track");

                entity.Property(e => e.MaterialAcct).HasColumnName("Material_Acct");

                entity.Property(e => e.MaterialAcctDescription)
                    .HasColumnName("Material_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialCost).HasColumnName("Material_Cost");

                entity.Property(e => e.MaterialUnitCode1)
                    .HasColumnName("Material_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialUnitCode2).HasColumnName("Material_Unit_Code2");

                entity.Property(e => e.MaterialUnitCode3)
                    .HasColumnName("Material_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialUnitCode4)
                    .HasColumnName("Material_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.MaySnoStk)
                    .HasColumnName("May_SNO_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.NewPurBu)
                    .HasColumnName("New_Pur_BU")
                    .HasMaxLength(255);

                entity.Property(e => e.NewPurCostCenter)
                    .HasColumnName("New_Pur_Cost_Center_")
                    .HasMaxLength(255);

                entity.Property(e => e.NewPurGlCode)
                    .HasColumnName("New_Pur_GL_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.NonNettable).HasColumnName("Non-Nettable");

                entity.Property(e => e.OrlyStock)
                    .HasColumnName("Orly_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.OrlyTransit)
                    .HasColumnName("Orly_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideAcct).HasColumnName("Outside_Acct");

                entity.Property(e => e.OutsideAcctDescription)
                    .HasColumnName("Outside_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideCost).HasColumnName("Outside_Cost");

                entity.Property(e => e.OutsideUnitCode1)
                    .HasColumnName("Outside_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideUnitCode2).HasColumnName("Outside_Unit_Code2");

                entity.Property(e => e.OutsideUnitCode3)
                    .HasColumnName("Outside_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideUnitCode4)
                    .HasColumnName("Outside_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.PenTst)
                    .HasColumnName("PEN_Tst")
                    .HasMaxLength(255);

                entity.Property(e => e.PptDesc)
                    .HasColumnName("PPT_Desc")
                    .HasMaxLength(255);

                entity.Property(e => e.PptPartNo)
                    .HasColumnName("PPT_Part_No")
                    .HasMaxLength(255);

                entity.Property(e => e.ProStk)
                    .HasColumnName("PRO_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.RecoupMonth1)
                    .HasColumnName("Recoup_Month_1_")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth10)
                    .HasColumnName("Recoup_Month_10")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth11)
                    .HasColumnName("Recoup_Month_11")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth12)
                    .HasColumnName("Recoup_Month_12")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth2)
                    .HasColumnName("Recoup_Month_2")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth3)
                    .HasColumnName("Recoup_Month_3")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth4)
                    .HasColumnName("Recoup_Month_4")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth5)
                    .HasColumnName("Recoup_Month_5")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth6)
                    .HasColumnName("Recoup_Month_6_")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth7)
                    .HasColumnName("Recoup_Month_7")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth8)
                    .HasColumnName("Recoup_Month_8")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMonth9)
                    .HasColumnName("Recoup_Month_9")
                    .HasMaxLength(255);

                entity.Property(e => e.Rod2)
                    .HasColumnName("Rod_2_")
                    .HasMaxLength(255);

                entity.Property(e => e.SNTrack).HasColumnName("S/N_Track");

                entity.Property(e => e.SendToLkq)
                    .HasColumnName("Send_to_LKQ")
                    .HasMaxLength(255);

                entity.Property(e => e.SnaStk)
                    .HasColumnName("SNA_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.SnaTst)
                    .HasColumnName("SNA_Tst")
                    .HasMaxLength(255);

                entity.Property(e => e.SocalStock)
                    .HasColumnName("Socal_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.SocalTransit)
                    .HasColumnName("Socal_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalAvailableInventory)
                    .HasColumnName("Total_Available_Inventory")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalCost).HasColumnName("Total_Cost");

                entity.Property(e => e.TotalNonNettableStock)
                    .HasColumnName("Total_Non-Nettable_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalReservedCo).HasColumnName("Total_Reserved_CO");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UM)
                    .HasColumnName("U/M")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitCost).HasColumnName("Unit_Cost");

                entity.Property(e => e.VarOvhdCost).HasColumnName("Var_Ovhd_Cost");

                entity.Property(e => e.VarOvhdUnitCode1)
                    .HasColumnName("Var_Ovhd_Unit_Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.VarOvhdUnitCode2).HasColumnName("Var_Ovhd_Unit_Code2");

                entity.Property(e => e.VarOvhdUnitCode3)
                    .HasColumnName("Var_Ovhd_Unit_Code3")
                    .HasMaxLength(255);

                entity.Property(e => e.VarOvhdUnitCode4)
                    .HasColumnName("Var_Ovhd_Unit_Code4")
                    .HasMaxLength(255);

                entity.Property(e => e.VariableOvhdAcct).HasColumnName("Variable_Ovhd_Acct");

                entity.Property(e => e.VariableOvhdAcctDescription)
                    .HasColumnName("Variable_Ovhd_Acct_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.Warehouse).HasMaxLength(255);

                entity.Property(e => e.WarehouseOnHand)
                    .HasColumnName("Warehouse_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10Avail)
                    .HasColumnName("Whse_10_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10Comm)
                    .HasColumnName("Whse_10_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10Mos1LS)
                    .HasColumnName("Whse_10_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse10OnOrder)
                    .HasColumnName("Whse_10_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse11Avail)
                    .HasColumnName("Whse_11_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse11Comm)
                    .HasColumnName("Whse_11_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse11OnOrder)
                    .HasColumnName("Whse_11_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse12Avail).HasMaxLength(255);

                entity.Property(e => e.Whse12Comm)
                    .HasColumnName("Whse_12_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse12OnOrder)
                    .HasColumnName("Whse_12_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse13Avail)
                    .HasColumnName("Whse_13_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse13Comm)
                    .HasColumnName("Whse_13_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse13OnOrder)
                    .HasColumnName("Whse_13_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse14Avail)
                    .HasColumnName("Whse_14_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse14Comm)
                    .HasColumnName("Whse_14_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse14OnOrder)
                    .HasColumnName("Whse_14_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse15Avail)
                    .HasColumnName("Whse_15_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse15Comm)
                    .HasColumnName("Whse_15_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse15OnOrder)
                    .HasColumnName("Whse_15_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse16Avail)
                    .HasColumnName("Whse_16_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse16Comm)
                    .HasColumnName("Whse_16_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse16OnOrder)
                    .HasColumnName("Whse_16_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Allocated)
                    .HasColumnName("Whse_17_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos1LS)
                    .HasColumnName("Whse_17_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos2LS)
                    .HasColumnName("Whse_17_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos3LS)
                    .HasColumnName("Whse_17_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos4LS)
                    .HasColumnName("Whse_17_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos5LS)
                    .HasColumnName("Whse_17_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Mos6LS)
                    .HasColumnName("Whse_17_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Stock)
                    .HasColumnName("Whse_17_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse17Transit)
                    .HasColumnName("Whse_17_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Allocated)
                    .HasColumnName("Whse_18_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos1LS)
                    .HasColumnName("Whse_18_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos2LS)
                    .HasColumnName("Whse_18_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos3LS)
                    .HasColumnName("Whse_18_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos4LS)
                    .HasColumnName("Whse_18_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos5LS)
                    .HasColumnName("Whse_18_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Mos6LS)
                    .HasColumnName("Whse_18_mos_6_L_S_")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Stock)
                    .HasColumnName("Whse_18_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse18Transit)
                    .HasColumnName("Whse_18_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Allocated)
                    .HasColumnName("Whse_19_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos1LS)
                    .HasColumnName("Whse_19_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos2LS)
                    .HasColumnName("Whse_19_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos3LS)
                    .HasColumnName("Whse_19_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos4LS)
                    .HasColumnName("Whse_19_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos5LS)
                    .HasColumnName("Whse_19_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Mos6LS)
                    .HasColumnName("Whse_19_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Stock)
                    .HasColumnName("Whse_19_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse19Transit)
                    .HasColumnName("Whse_19_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1Avail)
                    .HasColumnName("Whse_1_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1Comm)
                    .HasColumnName("Whse_1_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1MtdLs)
                    .HasColumnName("Whse_1_MTD_LS_")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1OnOrder)
                    .HasColumnName("Whse_1_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1StkSeeNote1InNotes)
                    .HasColumnName("Whse_1_Stk_see_note_1_in_Notes")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse1Tst)
                    .HasColumnName("Whse_1_Tst")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Allocated)
                    .HasColumnName("Whse_20_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos2LS)
                    .HasColumnName("Whse_20_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos3LS)
                    .HasColumnName("Whse_20_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos4LS)
                    .HasColumnName("Whse_20_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos5LS)
                    .HasColumnName("Whse_20_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Mos6LS)
                    .HasColumnName("Whse_20_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Stock)
                    .HasColumnName("Whse_20_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse20Transit)
                    .HasColumnName("Whse_20_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Allocated)
                    .HasColumnName("Whse_21_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos1LS)
                    .HasColumnName("Whse_21_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos2LS)
                    .HasColumnName("Whse_21_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos3LS)
                    .HasColumnName("Whse_21_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos4LS)
                    .HasColumnName("Whse_21_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos5LS)
                    .HasColumnName("Whse_21_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos6LS)
                    .HasColumnName("Whse_21_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Mos6LS1)
                    .HasColumnName("Whse_21_mos_6_L_S1")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Stock)
                    .HasColumnName("Whse_21_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse21Transit)
                    .HasColumnName("Whse_21_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Allocated)
                    .HasColumnName("Whse_22_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos1LS)
                    .HasColumnName("Whse_22_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos2LS)
                    .HasColumnName("Whse_22_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos3LS)
                    .HasColumnName("Whse_22_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos4LS)
                    .HasColumnName("Whse_22_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos5LS)
                    .HasColumnName("Whse_22_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Mos6LS)
                    .HasColumnName("Whse_22_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Stock)
                    .HasColumnName("Whse_22_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse22Transit)
                    .HasColumnName("Whse_22_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Allocated)
                    .HasColumnName("Whse_23_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos1LS)
                    .HasColumnName("Whse_23_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos2LS)
                    .HasColumnName("Whse_23_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos3LS)
                    .HasColumnName("Whse_23_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos4LS)
                    .HasColumnName("Whse_23_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Mos5LS)
                    .HasColumnName("Whse_23_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Stock)
                    .HasColumnName("Whse_23_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse23Transit)
                    .HasColumnName("Whse_23_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Allocated)
                    .HasColumnName("Whse_24_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos1LS)
                    .HasColumnName("Whse_24_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos2LS)
                    .HasColumnName("Whse_24_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos3LS)
                    .HasColumnName("Whse_24_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos4LS)
                    .HasColumnName("Whse_24_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos5LS)
                    .HasColumnName("Whse_24_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Mos6LS)
                    .HasColumnName("Whse_24_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Stock)
                    .HasColumnName("Whse_24_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse24Transit)
                    .HasColumnName("Whse_24_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Allocated)
                    .HasColumnName("Whse_25_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos1LS)
                    .HasColumnName("Whse_25_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos2LS)
                    .HasColumnName("Whse_25_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos3LS)
                    .HasColumnName("Whse_25_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos4LS)
                    .HasColumnName("Whse_25_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos5LS)
                    .HasColumnName("Whse_25_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Mos6LS)
                    .HasColumnName("Whse_25_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Stock)
                    .HasColumnName("Whse_25_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse25Transit)
                    .HasColumnName("Whse_25_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Allocated)
                    .HasColumnName("Whse_26_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos1LS)
                    .HasColumnName("Whse_26_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos2LS)
                    .HasColumnName("Whse_26_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos3LS)
                    .HasColumnName("Whse_26_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos4LS)
                    .HasColumnName("Whse_26_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos5LS)
                    .HasColumnName("Whse_26_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Mos6LS)
                    .HasColumnName("Whse_26_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Stock)
                    .HasColumnName("Whse_26_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse26Transit)
                    .HasColumnName("Whse_26_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Allocated)
                    .HasColumnName("Whse_27_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos1LS)
                    .HasColumnName("Whse_27_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos2LS)
                    .HasColumnName("Whse_27_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos3LS)
                    .HasColumnName("Whse_27_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos4LS)
                    .HasColumnName("Whse_27_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos5LS)
                    .HasColumnName("Whse_27_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Mos6LS)
                    .HasColumnName("Whse_27_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Stock)
                    .HasColumnName("Whse_27_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse27Transit)
                    .HasColumnName("Whse_27_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Allocated)
                    .HasColumnName("Whse_28_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Allocated1)
                    .HasColumnName("Whse_28_Allocated1")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos1LS)
                    .HasColumnName("Whse_28_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos2LS)
                    .HasColumnName("Whse_28_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos3LS)
                    .HasColumnName("Whse_28_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos4LS)
                    .HasColumnName("Whse_28_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos5LS)
                    .HasColumnName("Whse_28_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Mos6LS)
                    .HasColumnName("Whse_28_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Stock)
                    .HasColumnName("Whse_28_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse28Transit)
                    .HasColumnName("Whse_28_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos1LS)
                    .HasColumnName("Whse_29_mos_1_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos2LS)
                    .HasColumnName("Whse_29_mos_2_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos3LS)
                    .HasColumnName("Whse_29_mos_3_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos4LS)
                    .HasColumnName("Whse_29_mos_4_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos5LS)
                    .HasColumnName("Whse_29_mos_5_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Mos6LS)
                    .HasColumnName("Whse_29_mos_6_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Stock)
                    .HasColumnName("Whse_29_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse29Transit)
                    .HasColumnName("Whse_29_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Avail)
                    .HasColumnName("Whse_2_Avail")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Comm)
                    .HasColumnName("Whse_2_Comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2MtdLS)
                    .HasColumnName("Whse_2_MTD_L_S")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2OnOrder)
                    .HasColumnName("Whse_2_On_Order")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Stock)
                    .HasColumnName("Whse_2_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse2Transit)
                    .HasColumnName("Whse_2_Transit")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse30Allocated)
                    .HasColumnName("Whse_30_Allocated")
                    .HasMaxLength(255);

                entity.Property(e => e.Whse30Mos1LS)
                    .HasColumnName("Whse_30_mos_1_L_S")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportResume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Resume");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Best)
                    .HasColumnName("BEST")
                    .HasMaxLength(50);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoAtk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F27).HasMaxLength(50);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Int1)
                    .HasColumnName("INT1")
                    .HasMaxLength(50);

                entity.Property(e => e.JobsFirm).HasColumnName("Jobs_Firm");

                entity.Property(e => e.JobsTarget).HasColumnName("Jobs_target");

                entity.Property(e => e.K10).HasMaxLength(50);

                entity.Property(e => e.K7).HasMaxLength(50);

                entity.Property(e => e.K70).HasMaxLength(50);

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnOrder).HasColumnName("On_order");

                entity.Property(e => e.ProdPace).HasColumnName("Prod_pace");

                entity.Property(e => e.ReporteId).HasColumnName("ReporteID");

                entity.Property(e => e.Vdm).HasColumnName("VDM");

                entity.Property(e => e.Wip)
                    .HasColumnName("WIP")
                    .HasMaxLength(50);

                entity.Property(e => e.WipJobs).HasColumnName("Wip_jobs");
            });

            modelBuilder.Entity<LogisticsMarchingReportStockTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Stock_Target");

                entity.Property(e => e.AbcCode)
                    .HasColumnName("ABC_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AcceptRequirements).HasColumnName("Accept_Requirements");

                entity.Property(e => e.ActiveForCustomerPortal).HasColumnName("Active_For_Customer_Portal");

                entity.Property(e => e.ActiveForDataIntegration).HasColumnName("Active_for_Data_Integration");

                entity.Property(e => e.AffiliateSales)
                    .HasColumnName("Affiliate_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AflExchSales)
                    .HasColumnName("AFL_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AllocatedToCustomerOrders)
                    .HasColumnName("Allocated_To_Customer_Orders")
                    .HasMaxLength(255);

                entity.Property(e => e.AllocatedToProd).HasColumnName("Allocated_To_Prod");

                entity.Property(e => e.AlternateItem)
                    .HasColumnName("Alternate_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.AprJobSales)
                    .HasColumnName("Apr_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AprSales)
                    .HasColumnName("Apr_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AprWarrantySales)
                    .HasColumnName("Apr_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AtkItem)
                    .HasColumnName("ATK_Item")
                    .HasMaxLength(255);

                entity.Property(e => e.AtkSalesTarget)
                    .HasColumnName("ATK_Sales_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.AugJobSales)
                    .HasColumnName("Aug_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AugSales)
                    .HasColumnName("Aug_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AugWarrantySales)
                    .HasColumnName("Aug_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.AutoJobGeneration)
                    .HasColumnName("Auto_Job_Generation")
                    .HasMaxLength(255);

                entity.Property(e => e.AutoReleaseWhenFirmed)
                    .HasColumnName("Auto_Release_When_Firmed")
                    .HasMaxLength(255);

                entity.Property(e => e.BackOrderQty).HasColumnName("Back_Order_Qty");

                entity.Property(e => e.BackflushLocation)
                    .HasColumnName("Backflush_Location")
                    .HasMaxLength(255);

                entity.Property(e => e.BeginningInventory)
                    .HasColumnName("Beginning_Inventory")
                    .HasMaxLength(255);

                entity.Property(e => e.BodyStyle)
                    .HasColumnName("Body_Style")
                    .HasMaxLength(255);

                entity.Property(e => e.Buyer).HasMaxLength(255);

                entity.Property(e => e.CalExchSales)
                    .HasColumnName("CAL_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.CalJobMonthlySales)
                    .HasColumnName("CAL_Job_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Cat).HasMaxLength(255);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(255);

                entity.Property(e => e.Cell).HasMaxLength(255);

                entity.Property(e => e.CellPcsPerHour)
                    .HasColumnName("Cell_Pcs_Per_Hour")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("Change_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangeDate2)
                    .HasColumnName("Change_Date_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Charfld1).HasMaxLength(255);

                entity.Property(e => e.Charfld11).HasMaxLength(255);

                entity.Property(e => e.Charfld2).HasMaxLength(255);

                entity.Property(e => e.Charfld3).HasMaxLength(255);

                entity.Property(e => e.Charfld4).HasMaxLength(255);

                entity.Property(e => e.Code45)
                    .HasColumnName("Code_45")
                    .HasMaxLength(255);

                entity.Property(e => e.Code46)
                    .HasColumnName("Code_46")
                    .HasMaxLength(255);

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.CommodityDescription)
                    .HasColumnName("Commodity_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.ComputedSalesTarget)
                    .HasColumnName("Computed_Sales_Target")
                    .HasMaxLength(255);

                entity.Property(e => e.ConfigurationFlag).HasColumnName("Configuration_Flag");

                entity.Property(e => e.CostMethod)
                    .HasColumnName("Cost_Method")
                    .HasMaxLength(255);

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CountryOfOrigin)
                    .HasColumnName("Country_Of_Origin")
                    .HasMaxLength(255);

                entity.Property(e => e.CrankMatch)
                    .HasColumnName("Crank_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrentUnitCost)
                    .HasColumnName("Current_Unit_Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.Cylinders).HasMaxLength(255);

                entity.Property(e => e.DateFirstStocked)
                    .HasColumnName("Date_First_Stocked")
                    .HasMaxLength(255);

                entity.Property(e => e.DaysSupply).HasColumnName("Days_Supply");

                entity.Property(e => e.DecJobSales)
                    .HasColumnName("Dec_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.DecSales)
                    .HasColumnName("Dec_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.DecWarrantySales)
                    .HasColumnName("Dec_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Decifld1).HasMaxLength(255);

                entity.Property(e => e.Decifld2).HasMaxLength(255);

                entity.Property(e => e.Decifld3).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Diesel).HasMaxLength(255);

                entity.Property(e => e.Displacement).HasMaxLength(255);

                entity.Property(e => e.DockToStock).HasColumnName("Dock-to-Stock");

                entity.Property(e => e.DrawingNumber)
                    .HasColumnName("Drawing_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.EarliestPlannedPurchaseReceipt)
                    .HasColumnName("Earliest_Planned_Purchase_Receipt")
                    .HasMaxLength(255);

                entity.Property(e => e.Ecn).HasColumnName("ECN");

                entity.Property(e => e.EnablePiecesInventory).HasColumnName("Enable_Pieces_Inventory");

                entity.Property(e => e.ExpeditedFixed).HasColumnName("Expedited_Fixed");

                entity.Property(e => e.ExpeditedVariable).HasColumnName("Expedited_Variable");

                entity.Property(e => e.Family).HasMaxLength(255);

                entity.Property(e => e.FamilyCode)
                    .HasColumnName("Family_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureString)
                    .HasColumnName("Feature_String")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureTemplate)
                    .HasColumnName("Feature_Template")
                    .HasMaxLength(255);

                entity.Property(e => e.FeaturedItem).HasColumnName("Featured_Item");

                entity.Property(e => e.FebJobSales)
                    .HasColumnName("Feb_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FebSales)
                    .HasColumnName("Feb_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FebWarrantySales)
                    .HasColumnName("Feb_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.FixedLeadTime).HasColumnName("Fixed_Lead_Time");

                entity.Property(e => e.FixedOrderQty).HasColumnName("Fixed_Order_Qty");

                entity.Property(e => e.ForShortPrc).HasColumnName("For_Short_Prc");

                entity.Property(e => e.FullUpc)
                    .HasColumnName("Full_UPC")
                    .HasMaxLength(255);

                entity.Property(e => e.Gl)
                    .HasColumnName("GL")
                    .HasMaxLength(255);

                entity.Property(e => e.HeadMatch)
                    .HasColumnName("Head_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.HollanderReady)
                    .HasColumnName("Hollander_Ready")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallerNoteLine1)
                    .HasColumnName("Installer_Note_Line_1")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallerNoteLine2)
                    .HasColumnName("Installer_Note_Line_2")
                    .HasMaxLength(255);

                entity.Property(e => e.InvChangeName)
                    .HasColumnName("Inv_Change_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryLcl)
                    .HasColumnName("Inventory_LCL_%")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryType)
                    .HasColumnName("Inventory_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryUcl)
                    .HasColumnName("Inventory_UCL_%")
                    .HasMaxLength(255);

                entity.Property(e => e.IssueBy)
                    .HasColumnName("Issue_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemAttributeGroup)
                    .HasColumnName("Item_Attribute_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemAttributeGroupDescription)
                    .HasColumnName("Item_Attribute_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.JanJobSales)
                    .HasColumnName("Jan_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JanSales)
                    .HasColumnName("Jan_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JanWarrantySales)
                    .HasColumnName("Jan_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JobConfigurable).HasColumnName("Job_Configurable");

                entity.Property(e => e.JulJobSales)
                    .HasColumnName("Jul_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JulSales)
                    .HasColumnName("Jul_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JulWarrantySales)
                    .HasColumnName("Jul_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunJobSales)
                    .HasColumnName("Jun_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunSales)
                    .HasColumnName("Jun_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.JunWarrantySales)
                    .HasColumnName("Jun_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.LastChange)
                    .HasColumnName("Last_Change")
                    .HasMaxLength(255);

                entity.Property(e => e.LastImportDate)
                    .HasColumnName("Last_Import_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Li).HasColumnName("LI");

                entity.Property(e => e.LotAttributeGroup)
                    .HasColumnName("Lot_Attribute_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.LotAttributeGroupDescription)
                    .HasColumnName("Lot_Attribute_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.LotPrefix)
                    .HasColumnName("Lot_Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.LotSize).HasColumnName("Lot_Size");

                entity.Property(e => e.LotTrack).HasColumnName("Lot_Track");

                entity.Property(e => e.LowLevel).HasColumnName("Low_Level");

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.ManufacturedYtd).HasColumnName("Manufactured_YTD");

                entity.Property(e => e.MarJobSales)
                    .HasColumnName("Mar_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MarSales)
                    .HasColumnName("Mar_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MarWarrantySales)
                    .HasColumnName("Mar_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialStatus)
                    .HasColumnName("Material_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.MayJobSales)
                    .HasColumnName("May_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MayLSSalesOkStk)
                    .HasColumnName("May_L_S_Sales_OK_Stk")
                    .HasMaxLength(255);

                entity.Property(e => e.MaySales)
                    .HasColumnName("May_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MayWarrantySales)
                    .HasColumnName("May_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.MnoMtdLS)
                    .HasColumnName("MNO_MTD_L_S_")
                    .HasMaxLength(255);

                entity.Property(e => e.Mofr).HasMaxLength(255);

                entity.Property(e => e.Moto)
                    .HasColumnName("MOTO")
                    .HasMaxLength(255);

                entity.Property(e => e.MpsFlag).HasColumnName("MPS_Flag");

                entity.Property(e => e.MpsPlanFence)
                    .HasColumnName("MPS_Plan_Fence")
                    .HasMaxLength(255);

                entity.Property(e => e.MrpItem).HasColumnName("MRP_Item");

                entity.Property(e => e.MustUseFuturePosBeforeCreatingPlns).HasColumnName("Must_use_future_POs_before_creating_PLNs");

                entity.Property(e => e.Name)
                    .HasColumnName("#NAME?")
                    .HasMaxLength(255);

                entity.Property(e => e.NameSpace)
                    .HasColumnName("Name_Space")
                    .HasMaxLength(255);

                entity.Property(e => e.NatExchSales)
                    .HasColumnName("NAT_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NatJobMonthlySales)
                    .HasColumnName("Nat_Job_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NetChange).HasColumnName("Net_Change");

                entity.Property(e => e.NewBu)
                    .HasColumnName("New_BU")
                    .HasMaxLength(255);

                entity.Property(e => e.NewGlCode).HasColumnName("New_GL_Code");

                entity.Property(e => e.NonNettableStock).HasColumnName("Non-Nettable_Stock");

                entity.Property(e => e.NovJobSales)
                    .HasColumnName("Nov_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NovSales)
                    .HasColumnName("Nov_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.NovWarrantySales)
                    .HasColumnName("Nov_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctJobSales)
                    .HasColumnName("Oct_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctSales)
                    .HasColumnName("Oct_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OctWarrantySales)
                    .HasColumnName("Oct_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.OldFamilyCode)
                    .HasColumnName("Old_Family_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.OldProductCode)
                    .HasColumnName("Old_Product_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderConfigurable).HasColumnName("Order_Configurable");

                entity.Property(e => e.OrderMaximum).HasColumnName("Order_Maximum");

                entity.Property(e => e.OrderMinimum).HasColumnName("Order_Minimum");

                entity.Property(e => e.OrderMultiple).HasColumnName("Order_Multiple");

                entity.Property(e => e.Origin).HasMaxLength(255);

                entity.Property(e => e.Overview).HasMaxLength(255);

                entity.Property(e => e.PaperWork).HasColumnName("Paper_Work");

                entity.Property(e => e.PartNumber)
                    .HasColumnName("Part_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PassRequirements).HasColumnName("Pass_Requirements");

                entity.Property(e => e.PhantomFlag).HasColumnName("Phantom_Flag");

                entity.Property(e => e.PieceDimensionGroup)
                    .HasColumnName("Piece_Dimension_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.PieceDimensionGroupDescription)
                    .HasColumnName("Piece_Dimension_Group_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.PlannedMfgSupplySwitching).HasColumnName("Planned_Mfg_Supply_Switching");

                entity.Property(e => e.PlannerCode)
                    .HasColumnName("Planner_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PoToleranceOver)
                    .HasColumnName("PO_Tolerance_Over")
                    .HasMaxLength(255);

                entity.Property(e => e.PoToleranceUnder)
                    .HasColumnName("PO_Tolerance_Under")
                    .HasMaxLength(255);

                entity.Property(e => e.PreassignLots).HasColumnName("Preassign_Lots");

                entity.Property(e => e.PreassignSerials).HasColumnName("Preassign_Serials");

                entity.Property(e => e.PreferenceCriterion)
                    .HasColumnName("Preference_Criterion")
                    .HasMaxLength(255);

                entity.Property(e => e.PreferredCoProductMix)
                    .HasColumnName("Preferred_Co-product_Mix")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintKitComponentsOnCustomerPaperwork).HasColumnName("Print_Kit_Components_on_Customer_Paperwork");

                entity.Property(e => e.ProductCode).HasColumnName("Product_Code");

                entity.Property(e => e.ProductionType)
                    .HasColumnName("Production_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchasedYtd)
                    .HasColumnName("Purchased_YTD")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnName("Quantity_On_Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityOrdered)
                    .HasColumnName("Quantity_Ordered")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityWip).HasColumnName("Quantity_WIP");

                entity.Property(e => e.RateDay).HasColumnName("Rate/Day");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("Reason_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.RecievedThisMonth)
                    .HasColumnName("Recieved_This_Month")
                    .HasMaxLength(255);

                entity.Property(e => e.RecoupMtd)
                    .HasColumnName("Recoup_MTD")
                    .HasMaxLength(255);

                entity.Property(e => e.Release1)
                    .HasColumnName("Release_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Release2)
                    .HasColumnName("Release_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Release3)
                    .HasColumnName("Release_3")
                    .HasMaxLength(255);

                entity.Property(e => e.ReorderPoint).HasColumnName("Reorder_Point");

                entity.Property(e => e.ReservedForCustomerOrders).HasColumnName("Reserved_For_Customer_Orders");

                entity.Property(e => e.Revision).HasMaxLength(255);

                entity.Property(e => e.RevisionTrack).HasColumnName("Revision_Track");

                entity.Property(e => e.SNPrefix)
                    .HasColumnName("S/N_Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.SNTrack).HasColumnName("S/N_Track");

                entity.Property(e => e.SafetyStock)
                    .HasColumnName("Safety_Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.SafetyStockPercent)
                    .HasColumnName("Safety_Stock_Percent")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesPace)
                    .HasColumnName("Sales_Pace")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesTotals)
                    .HasColumnName("Sales_Totals")
                    .HasMaxLength(255);

                entity.Property(e => e.SaveCurrentRevisionUponImport).HasColumnName("Save_Current_Revision_Upon_Import");

                entity.Property(e => e.ScreenTwoThirdsUpdated)
                    .HasColumnName("Screen_Two-Thirds_Updated")
                    .HasMaxLength(255);

                entity.Property(e => e.SepJobSales)
                    .HasColumnName("Sep_Job_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.SepSales)
                    .HasColumnName("Sep_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.SepWarrantySales)
                    .HasColumnName("Sep_Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.Separation).HasMaxLength(255);

                entity.Property(e => e.SetupGroup)
                    .HasColumnName("Setup_Group")
                    .HasMaxLength(255);

                entity.Property(e => e.ShelfLife)
                    .HasColumnName("Shelf_Life")
                    .HasMaxLength(255);

                entity.Property(e => e.ShowInDropDownLists).HasColumnName("Show_In_Drop-Down_Lists");

                entity.Property(e => e.ShrinkFactor).HasColumnName("Shrink_Factor");

                entity.Property(e => e.SoldYtd)
                    .HasColumnName("Sold_YTD")
                    .HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.StandardUnitCost)
                    .HasColumnName("Standard_Unit_Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusChangeUserCode)
                    .HasColumnName("Status_Change_User_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.StdDuePeriod)
                    .HasColumnName("Std_Due_Period")
                    .HasMaxLength(255);

                entity.Property(e => e.StockInSna)
                    .HasColumnName("Stock_in_SNA")
                    .HasMaxLength(255);

                entity.Property(e => e.SubjectToRvcRequirements).HasColumnName("Subject_To_RVC_Requirements");

                entity.Property(e => e.SupplySite)
                    .HasColumnName("Supply_Site")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyUsageTolerance).HasColumnName("Supply_Usage_Tolerance");

                entity.Property(e => e.SupplyWhse)
                    .HasColumnName("Supply_Whse")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetInvMax)
                    .HasColumnName("Target_Inv_Max")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetInvMin).HasColumnName("Target_Inv_Min");

                entity.Property(e => e.TargetedSafetyStockReplenishment)
                    .HasColumnName("Targeted_Safety_Stock_Replenishment")
                    .HasMaxLength(255);

                entity.Property(e => e.TariffClassification)
                    .HasColumnName("Tariff_Classification")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCode1Uet)
                    .HasColumnName("Tax_Code_1_UET")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCodeDescription)
                    .HasColumnName("Tax_Code_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxFreeDays).HasColumnName("Tax_Free_Days");

                entity.Property(e => e.TaxFreeImportedMaterial).HasColumnName("Tax-Free_Imported_Material");

                entity.Property(e => e.Taxable).HasMaxLength(255);

                entity.Property(e => e.TimeFenceRule)
                    .HasColumnName("Time_Fence_Rule")
                    .HasMaxLength(255);

                entity.Property(e => e.TimeFenceValue).HasColumnName("Time_Fence_Value");

                entity.Property(e => e.TopSeller).HasColumnName("Top_Seller");

                entity.Property(e => e.TotalTarget).HasColumnName("Total_Target");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.TypeDefinition)
                    .HasColumnName("Type_Definition")
                    .HasMaxLength(255);

                entity.Property(e => e.UM)
                    .HasColumnName("U/M")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitWeight)
                    .HasColumnName("Unit_Weight")
                    .HasMaxLength(255);

                entity.Property(e => e.UpcCode).HasColumnName("UPC_Code");

                entity.Property(e => e.UseReorderPoint).HasColumnName("Use_Reorder_Point");

                entity.Property(e => e.UsedEngineMatch)
                    .HasColumnName("Used_Engine_Match")
                    .HasMaxLength(255);

                entity.Property(e => e.UsedYtd).HasColumnName("Used_YTD");

                entity.Property(e => e.User).HasMaxLength(255);

                entity.Property(e => e.VegeCode)
                    .HasColumnName("Vege_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.VinNumber)
                    .HasColumnName("Vin_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.VipAddOn)
                    .HasColumnName("VIP_Add_On")
                    .HasMaxLength(255);

                entity.Property(e => e.VirSales)
                    .HasColumnName("Vir_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WarBO)
                    .HasColumnName("War_B_O")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyReserve)
                    .HasColumnName("Warranty_Reserve")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantySales)
                    .HasColumnName("Warranty_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WdExchSales)
                    .HasColumnName("WD_Exch_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WdMonthlySales)
                    .HasColumnName("WD_Monthly_Sales")
                    .HasMaxLength(255);

                entity.Property(e => e.WeightUnits)
                    .HasColumnName("Weight_Units")
                    .HasMaxLength(255);

                entity.Property(e => e.WholesalePrice).HasColumnName("Wholesale_Price");

                entity.Property(e => e.XInterchange)
                    .HasColumnName("X_Interchange_#")
                    .HasMaxLength(255);

                entity.Property(e => e.Years).HasMaxLength(255);

                entity.Property(e => e.YrFr).HasColumnName("Yr_Fr");

                entity.Property(e => e.YrTo).HasColumnName("Yr_To");

                entity.Property(e => e._46TypeCode)
                    .HasColumnName("46_Type_Code")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportStockorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Stockorder");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CustNum)
                    .HasColumnName("Cust_Num")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Part).HasMaxLength(255);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("PO_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvSt)
                    .HasColumnName("Prov_St")
                    .HasMaxLength(255);

                entity.Property(e => e.QtyNeeded).HasColumnName("Qty_Needed");

                entity.Property(e => e.QtyOrderedTotal).HasColumnName("Qty_Ordered_Total");

                entity.Property(e => e.QtyToOrder).HasColumnName("Qty_To_Order");

                entity.Property(e => e.StockMessage)
                    .HasColumnName("Stock_Message")
                    .HasMaxLength(255);

                entity.Property(e => e.StockOrder)
                    .HasColumnName("Stock_Order#")
                    .HasMaxLength(255);

                entity.Property(e => e.StockQtyAvailable)
                    .HasColumnName("Stock_Qty_Available")
                    .HasMaxLength(255);

                entity.Property(e => e.StockStatus)
                    .HasColumnName("Stock_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.Warehouse).HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportTransactions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Transactions");

                entity.Property(e => e.BrokerAdjustment)
                    .HasColumnName("Broker_Adjustment")
                    .HasMaxLength(255);

                entity.Property(e => e.CostCode)
                    .HasColumnName("Cost_Code")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateAndTimeOfTrans)
                    .HasColumnName("Date_and_Time_of_Trans")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("Document_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.FovhdCost).HasColumnName("Fovhd_Cost");

                entity.Property(e => e.FromSite)
                    .HasColumnName("From_Site")
                    .HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemDescription)
                    .HasColumnName("Item_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemUM)
                    .HasColumnName("Item_U/_M")
                    .HasMaxLength(255);

                entity.Property(e => e.LaborCost).HasColumnName("Labor_Cost");

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Lot).HasMaxLength(255);

                entity.Property(e => e.MaterialCost)
                    .HasColumnName("Material_Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.OutsideCost).HasColumnName("Outside_Cost");

                entity.Property(e => e.ProductCode).HasMaxLength(255);

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("Reason_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.ReasonDescription)
                    .HasColumnName("Reason_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.RefLine).HasColumnName("Ref_Line");

                entity.Property(e => e.RefNumber)
                    .HasColumnName("Ref_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefRelease).HasColumnName("Ref_Release");

                entity.Property(e => e.ReferenceType)
                    .HasColumnName("Reference_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalPosted)
                    .HasColumnName("Total_Posted")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDescription)
                    .HasColumnName("Transaction_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionNumber).HasColumnName("Transaction_Number");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit_Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.User).HasMaxLength(255);

                entity.Property(e => e.VovhdCost).HasColumnName("Vovhd_Cost");

                entity.Property(e => e.Warehouse).HasMaxLength(255);

                entity.Property(e => e.WorkCenter)
                    .HasColumnName("Work_Center")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportTransit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_Transit");

                entity.Property(e => e.CoNum)
                    .HasColumnName("CO_Num")
                    .HasMaxLength(255);

                entity.Property(e => e.Coline).HasColumnName("COLine");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.Price).HasMaxLength(255);

                entity.Property(e => e.SCoRelease).HasColumnName("sCoRelease");

                entity.Property(e => e.Serial).HasMaxLength(255);

                entity.Property(e => e.Shipped).HasMaxLength(255);

                entity.Property(e => e.TruckDate)
                    .HasColumnName("Truck_Date")
                    .HasMaxLength(255);

                entity.Property(e => e.TruckNum)
                    .HasColumnName("Truck_Num")
                    .HasMaxLength(255);

                entity.Property(e => e.Tub).HasMaxLength(255);

                entity.Property(e => e.VegePartNumber)
                    .HasColumnName("VEGE_Part_Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight).HasMaxLength(255);
            });

            modelBuilder.Entity<LogisticsMarchingReportTruckAtk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Marching_Report_TruckAtk");

                entity.Property(e => e.ArrivedToAsk)
                    .HasColumnName("Arrived_To_Ask")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryFromVmc)
                    .HasColumnName("Delivery_From_VMC")
                    .HasMaxLength(255);

                entity.Property(e => e.TransitTime).HasColumnName("transit_time");

                entity.Property(e => e.Transito).HasColumnName("TRANSITO");

                entity.Property(e => e.Trlr)
                    .HasColumnName("TRLR")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MaintenanceAdministrators>(entity =>
            {
                entity.HasKey(e => e.IdAdministradorIt);

                entity.ToTable("Maintenance_Administrators");

                entity.Property(e => e.IdAdministradorIt).HasColumnName("ID_AdministradorIT");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<MaintenanceEnvironmentalChecklistEquipamentRelease>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Environmental_Checklist_EquipamentRelease");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationId).HasColumnName("EvaluationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idmejora)
                    .IsRequired()
                    .HasColumnName("IDMejora")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeEngId).HasColumnName("TypeEngID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEnvironmentalChecklistEquipamentReleaseCorrectiveAction>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Environmental_Checklist_EquipamentRelease_CorrectiveAction");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompromiso).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReleaseId).HasColumnName("ReleaseID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEnvironmentalChecklistEquipamentReleaseQuestions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Environmental_Checklist_EquipamentRelease_Questions");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Preguntas)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Environmental_Checklist_EquipamentRelease_Questions_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.ReleaseId).HasColumnName("ReleaseID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResultsAnexoB>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Environmental_Checklist_EquipamentRelease_Questions_Results_AnexoB");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Autorizaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Planes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.Regulaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseId).HasColumnName("ReleaseID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEnvironmentalChecklistEquipamentReleaseReview>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Environmental_Checklist_EquipamentRelease_Review");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReleaseId).HasColumnName("ReleaseID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachinery>(entity =>
            {
                entity.HasKey(e => e.IdMaquina);

                entity.ToTable("Maintenance_EquipmentMachinery");

                entity.Property(e => e.IdMaquina).HasColumnName("ID_Maquina");

                entity.Property(e => e.Critico).HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripcionMaquina)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FabricanteId).HasColumnName("FabricanteID");

                entity.Property(e => e.FechaInstalacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimoServicio).HasColumnType("date");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PlantaUbicacionId).HasColumnName("PlantaUbicacionID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryEvidenceReplace>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_EquipmentMachinery_Evidence_Replace");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Maquina)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryFiles>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_EquipmentMachinery_Files");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryGroups>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("Maintenance_EquipmentMachinery_Groups");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_Grupo");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryHistoryStatus>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_EquipmentMachinery_HistoryStatus");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryHistoryUpdate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_EquipmentMachinery_HistoryUpdate");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryHistoryWorkStations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_EquipmentMachinery_HistoryWorkStations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionAnteriorId).HasColumnName("EstacionAnteriorID");

                entity.Property(e => e.EstacionNuevaId).HasColumnName("EstacionNuevaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");

                entity.Property(e => e.PlantaAnteriorId).HasColumnName("PlantaAnteriorID");

                entity.Property(e => e.PlantaNuevaId).HasColumnName("PlantaNuevaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryManufacturer>(entity =>
            {
                entity.HasKey(e => e.IdFabricante);

                entity.ToTable("Maintenance_EquipmentMachinery_Manufacturer");

                entity.Property(e => e.IdFabricante).HasColumnName("ID_Fabricante");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fabricante)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryMultiplant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Maintenance_EquipmentMachinery_Multiplant");

                entity.Property(e => e.DescripcionMaquina)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FabricanteId).HasColumnName("FabricanteID");

                entity.Property(e => e.FechaInstalacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoServicio).HasColumnType("date");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.IdMaquina)
                    .HasColumnName("ID_Maquina")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PlantaUbicacionId).HasColumnName("PlantaUbicacionID");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("Maintenance_EquipmentMachinery_Status");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryTabSections>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("Maintenance_EquipmentMachinery_TabSections");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Onclick)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tab)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryTabSectionsLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_EquipmentMachinery_TabSectionsLinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<MaintenanceEquipmentMachineryUp>(entity =>
            {
                entity.HasKey(e => e.Registro);

                entity.ToTable("Maintenance_EquipmentMachinery_Up");

                entity.Property(e => e.NumeroMaquina)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMaquinaId)
                    .IsRequired()
                    .HasColumnName("NumeroMaquinaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceProcess>(entity =>
            {
                entity.HasKey(e => e.IdProceso);

                entity.ToTable("Maintenance_Process");

                entity.Property(e => e.IdProceso).HasColumnName("ID_Proceso");

                entity.Property(e => e.DescripcionProceso)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaMantenimientoAnterior).HasColumnType("date");

                entity.Property(e => e.FechaMantenimientoSiguiente).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId)
                    .HasColumnName("MaquinaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroProceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoMantenimientoId).HasColumnName("TipoMantenimientoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceProcessFiles>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Maintenance_ProcessFiles");

                entity.ToTable("Maintenance_Process_Files");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceProcessHistoryNextService>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Process_HistoryNextService");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProximoMantenimientoAnterior).HasColumnType("date");

                entity.Property(e => e.FechaProximoMantenimientoNueva).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceProcessHistoryStatus>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Process_HistoryStatus");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceProcessHistoryUpdate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Process_HistoryUpdate");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceProcessPlanner>(entity =>
            {
                entity.HasKey(e => e.IdPlaneacion);

                entity.ToTable("Maintenance_Process_Planner");

                entity.Property(e => e.IdPlaneacion).HasColumnName("ID_Planeacion");

                entity.Property(e => e.FechaMantenimiento)
                    .HasColumnType("date")
                    .HasComment("FechaMantenimientoSiguiente, campo para almacenar la Fecha correspondiente al proximo mantenimiento");

                entity.Property(e => e.FechaPlaneado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroServicio).HasColumnType("datetime");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioPlaneoId).HasColumnName("UsuarioPlaneoID");

                entity.Property(e => e.UsuarioRegistroServicioId).HasColumnName("UsuarioRegistroServicioID");
            });

            modelBuilder.Entity<MaintenanceProcessPlannerFilesDelete>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Process_PlannerFilesDelete");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlaneacionId).HasColumnName("PlaneacionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceProcessStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatusProceso)
                    .HasName("PK_Maintenance_ProcessStatus");

                entity.ToTable("Maintenance_Process_Status");

                entity.Property(e => e.IdStatusProceso).HasColumnName("ID_StatusProceso");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MaintenanceProcessTabSections>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("Maintenance_Process_TabSections");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Onclick)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tab)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceProcessTabSectionsLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Maintenance_Process_TabSectionsLinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<MaintenanceProcessTypes>(entity =>
            {
                entity.HasKey(e => e.IdTipoMantenimiento)
                    .HasName("PK_Maintenance_ProcessTypes");

                entity.ToTable("Maintenance_Process_Types");

                entity.Property(e => e.IdTipoMantenimiento).HasColumnName("ID_TipoMantenimiento");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoMantenimiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<MaintenanceServices>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK_Maintenance_Process_Services");

                entity.ToTable("Maintenance_Services");

                entity.Property(e => e.IdServicio).HasColumnName("ID_Servicio");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Critico).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<Managements>(entity =>
            {
                entity.HasKey(e => e.IdGerencia);

                entity.Property(e => e.IdGerencia).HasColumnName("ID_Gerencia");

                entity.Property(e => e.Gerencia)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");
            });

            modelBuilder.Entity<ProductionBomItems>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("Production_BOM_Items");

                entity.Property(e => e.IdItem).HasColumnName("ID_Item");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionBomItemsProviders>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_BOM_ItemsProviders");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroParte)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Principal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionBomJobs>(entity =>
            {
                entity.HasKey(e => e.IdJob);

                entity.ToTable("Production_BOM_Jobs");

                entity.Property(e => e.IdJob).HasColumnName("ID_Job");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionBomJobsItems>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_BOM_JobsItems");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorSeleccionadoId).HasColumnName("ProveedorSeleccionadoID");
            });

            modelBuilder.Entity<ProductionBomJobsModels>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_BOM_JobsModels");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionCells>(entity =>
            {
                entity.HasKey(e => e.IdCelda);

                entity.ToTable("Production_Cells");

                entity.Property(e => e.IdCelda).HasColumnName("ID_Celda");

                entity.Property(e => e.Celda)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProductionCoresColumnsDocuments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Cores_ColumnsDocuments");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Columna)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreOpcionId).HasColumnName("CoreOpcionID");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionCoresConfigurations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Cores_Configurations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.MotivosBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.VegeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionCoresLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Cores_Log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Columna)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionCoresOptions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Cores_Options");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoreId).HasColumnName("CoreID");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotivosBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionDepartments>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Production_Departments");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProductionMaterialSequences>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_MaterialSequences");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Arbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArbolCheck)
                    .HasColumnName("Arbol_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.ArbolHoraCompromiso)
                    .HasColumnName("Arbol_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ArbolStatus)
                    .HasColumnName("Arbol_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Biela)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BielaCheck)
                    .HasColumnName("Biela_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.BielaHoraCompromiso)
                    .HasColumnName("Biela_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BielaStatus)
                    .HasColumnName("Biela_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Block)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BlockCheck)
                    .HasColumnName("Block_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.BlockHoraCompromiso)
                    .HasColumnName("Block_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BlockStatus)
                    .HasColumnName("Block_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Cab1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cab1Check)
                    .HasColumnName("Cab1_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.Cab1HoraCompromiso)
                    .HasColumnName("Cab1_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cab1Status)
                    .HasColumnName("Cab1_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Cig)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CigCheck)
                    .HasColumnName("Cig_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.CigHoraCompromiso)
                    .HasColumnName("Cig_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CigStatus)
                    .HasColumnName("Cig_status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Family)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCheck)
                    .HasColumnName("Item_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.ItemHoraCompromiso)
                    .HasColumnName("Item_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemStatus)
                    .HasColumnName("Item_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Job)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManoDeObra)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManoDeObraStatus)
                    .HasColumnName("ManoDeObra_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Maquina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaquinaStatus)
                    .HasColumnName("Maquina_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.MaterialSequencesStatus)
                    .HasColumnName("MaterialSequences_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Materiales)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialesStatus)
                    .HasColumnName("Materiales_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Metodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoStatus)
                    .HasColumnName("Metodo_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.Motor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotorCheck)
                    .HasColumnName("Motor_Check")
                    .HasComment("0 = Vacio; 1 = check; 2 = cruz;");

                entity.Property(e => e.MotorHoraCompromiso)
                    .HasColumnName("Motor_HoraCompromiso")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MotorStatus)
                    .HasColumnName("Motor_Status")
                    .HasComment("0 = Blanco; 1 = Amarillo; 2 = Naranja; 3 = Verde; 4 = Rojo;");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionMissingItems>(entity =>
            {
                entity.HasKey(e => e.IdFaltante);

                entity.ToTable("Production_MissingItems");

                entity.Property(e => e.IdFaltante).HasColumnName("ID_Faltante");

                entity.Property(e => e.CausaId).HasColumnName("CausaID");

                entity.Property(e => e.CodigoFaltanteId).HasColumnName("CodigoFaltanteID");

                entity.Property(e => e.ComentarioCausa)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.CoordinadorAsignadoId)
                    .HasColumnName("CoordinadorAsignadoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.DetalleCausaId).HasColumnName("DetalleCausaID");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaFaltante).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel).HasDefaultValueSql("((1))");

                entity.Property(e => e.PlantaFaltanteId).HasColumnName("PlantaFaltanteID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProblemaFaltante)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.ReportadoPorId).HasColumnName("ReportadoPorID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioCierreId).HasColumnName("UsuarioCierreID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionMissingItemsCauses>(entity =>
            {
                entity.HasKey(e => e.IdCausa);

                entity.ToTable("Production_MissingItems_Causes");

                entity.Property(e => e.IdCausa).HasColumnName("ID_Causa");

                entity.Property(e => e.Causa)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionMissingItemsCodes>(entity =>
            {
                entity.HasKey(e => e.IdCodigo);

                entity.ToTable("Production_MissingItems_Codes");

                entity.Property(e => e.IdCodigo).HasColumnName("ID_Codigo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAbc)
                    .HasColumnName("CodigoABC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodigoAlterno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAtk)
                    .HasColumnName("CodigoATK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMedio)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoVege)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.CostoStd)
                    .HasColumnName("CostoSTD")
                    .HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizado).HasColumnType("date");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertSyt).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVin)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoArticulo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioActualizoId).HasColumnName("UsuarioActualizoID");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionMissingItemsCodesCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Production_MissingItems_CodesCodes");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCodigo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionMissingItemsCoordinators>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Production_MissingItems_Coordinators");

                entity.Property(e => e.CoodinadorId).HasColumnName("CoodinadorID");

                entity.Property(e => e.FaltanteId).HasColumnName("FaltanteID");
            });

            modelBuilder.Entity<ProductionMissingItemsCriticalParts>(entity =>
            {
                entity.HasKey(e => e.IdParteCritica);

                entity.ToTable("Production_MissingItems_CriticalParts");

                entity.Property(e => e.IdParteCritica).HasColumnName("ID_ParteCritica");

                entity.Property(e => e.DescripcionParte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroParteId).HasColumnName("UsuarioRegistroParteID");
            });

            modelBuilder.Entity<ProductionMissingItemsInv>(entity =>
            {
                entity.HasKey(e => e.IdArticulo);

                entity.ToTable("Production_MissingItems_Inv");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_Articulo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAbc)
                    .HasColumnName("CodigoABC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodigoArticuloAlterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAtk)
                    .HasColumnName("CodigoATK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoVege)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.CostoStd)
                    .HasColumnName("CostoSTD")
                    .HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizado).HasColumnType("date");

                entity.Property(e => e.NumeroVin)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArticulo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductionMissingItemsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_MissingItems_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FaltanteId).HasColumnName("FaltanteID");

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TiempoRespuesta).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRevisionId).HasColumnName("UsuarioRevisionID");
            });

            modelBuilder.Entity<ProductionModels>(entity =>
            {
                entity.HasKey(e => e.IdModelo)
                    .HasName("PK_Production_Models_1");

                entity.ToTable("Production_Models");

                entity.Property(e => e.IdModelo).HasColumnName("ID_Modelo");

                entity.Property(e => e.CargaSyteLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmbalajeId).HasColumnName("EmbalajeID");

                entity.Property(e => e.FamiliaId).HasColumnName("FamiliaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.HuacalId).HasColumnName("HuacalID");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TubbaseId).HasColumnName("TUBBaseID");

                entity.Property(e => e.TubinsertoId).HasColumnName("TUBInsertoID");

                entity.Property(e => e.TubinsertoMaderaId).HasColumnName("TUBInsertoMaderaID");

                entity.Property(e => e.TubtapaId).HasColumnName("TUBTapaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioUltimaActualizacionId).HasColumnName("UsuarioUltimaActualizacionID");

                entity.Property(e => e.VegeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionModelsFamilies>(entity =>
            {
                entity.HasKey(e => e.IdFamilia);

                entity.ToTable("Production_Models_Families");

                entity.Property(e => e.IdFamilia).HasColumnName("ID_Familia");

                entity.Property(e => e.CeldaId).HasColumnName("CeldaID");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProductionModelsUpdateModels>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Production_Models_UpdateModels");

                entity.Property(e => e.Base)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Huacal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertoMadera)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertoPlastico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroBase)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHuacal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroInsertoMadera)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroInsertoPlastico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTapa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tapa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionMotors>(entity =>
            {
                entity.HasKey(e => e.Serie);

                entity.ToTable("Production_Motors");

                entity.HasIndex(e => new { e.UsuarioPhotoCenterProof17Id, e.FechaPhotoCenterProof18, e.FechaPhotoCenterProof19, e.FechaPhotoCenterProof20, e.FechaPhotoCenterProof21 })
                    .HasName("IX_Production_Motors2");

                entity.HasIndex(e => new { e.FechaPhotoCenterProof1, e.FechaPhotoCenterProof2, e.FechaPhotoCenterProof3, e.FechaPhotoCenterProof4, e.FechaPhotoCenterProof5, e.FechaPhotoCenterProof6, e.FechaPhotoCenterProof7, e.FechaPhotoCenterProof8, e.FechaPhotoCenterProof9, e.FechaPhotoCenterProof10, e.FechaPhotoCenterProof11, e.FechaPhotoCenterProof12, e.FechaPhotoCenterProof13, e.FechaPhotoCenterProof14, e.FechaPhotoCenterProof15, e.FechaPhotoCenterProof16 })
                    .HasName("IX_Production_Motors");

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPhotoCenterProof1).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof10).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof11).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof12).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof13).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof14).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof15).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof16).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof17).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof18).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof19).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof2).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof20).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof21).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof22).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof23).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof3).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof4).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof5).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof6).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof7).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof8).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof9).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioPhotoCenterProof10Id).HasColumnName("UsuarioPhotoCenterProof10ID");

                entity.Property(e => e.UsuarioPhotoCenterProof11Id).HasColumnName("UsuarioPhotoCenterProof11ID");

                entity.Property(e => e.UsuarioPhotoCenterProof12Id).HasColumnName("UsuarioPhotoCenterProof12ID");

                entity.Property(e => e.UsuarioPhotoCenterProof13Id).HasColumnName("UsuarioPhotoCenterProof13ID");

                entity.Property(e => e.UsuarioPhotoCenterProof14Id).HasColumnName("UsuarioPhotoCenterProof14ID");

                entity.Property(e => e.UsuarioPhotoCenterProof15Id).HasColumnName("UsuarioPhotoCenterProof15ID");

                entity.Property(e => e.UsuarioPhotoCenterProof16Id).HasColumnName("UsuarioPhotoCenterProof16ID");

                entity.Property(e => e.UsuarioPhotoCenterProof17Id).HasColumnName("UsuarioPhotoCenterProof17ID");

                entity.Property(e => e.UsuarioPhotoCenterProof18Id).HasColumnName("UsuarioPhotoCenterProof18ID");

                entity.Property(e => e.UsuarioPhotoCenterProof19Id).HasColumnName("UsuarioPhotoCenterProof19ID");

                entity.Property(e => e.UsuarioPhotoCenterProof1Id).HasColumnName("UsuarioPhotoCenterProof1ID");

                entity.Property(e => e.UsuarioPhotoCenterProof20Id).HasColumnName("UsuarioPhotoCenterProof20ID");

                entity.Property(e => e.UsuarioPhotoCenterProof21Id).HasColumnName("UsuarioPhotoCenterProof21ID");

                entity.Property(e => e.UsuarioPhotoCenterProof22Id).HasColumnName("UsuarioPhotoCenterProof22ID");

                entity.Property(e => e.UsuarioPhotoCenterProof23Id).HasColumnName("UsuarioPhotoCenterProof23ID");

                entity.Property(e => e.UsuarioPhotoCenterProof2Id).HasColumnName("UsuarioPhotoCenterProof2ID");

                entity.Property(e => e.UsuarioPhotoCenterProof3Id).HasColumnName("UsuarioPhotoCenterProof3ID");

                entity.Property(e => e.UsuarioPhotoCenterProof4Id).HasColumnName("UsuarioPhotoCenterProof4ID");

                entity.Property(e => e.UsuarioPhotoCenterProof5Id).HasColumnName("UsuarioPhotoCenterProof5ID");

                entity.Property(e => e.UsuarioPhotoCenterProof6Id).HasColumnName("UsuarioPhotoCenterProof6ID");

                entity.Property(e => e.UsuarioPhotoCenterProof7Id).HasColumnName("UsuarioPhotoCenterProof7ID");

                entity.Property(e => e.UsuarioPhotoCenterProof8Id).HasColumnName("UsuarioPhotoCenterProof8ID");

                entity.Property(e => e.UsuarioPhotoCenterProof9Id).HasColumnName("UsuarioPhotoCenterProof9ID");
            });

            modelBuilder.Entity<ProductionMotorsDown>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Motors_Down");

                entity.HasIndex(e => e.Serie);

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo).HasComment("1 = Capturado mal AP; 2 = Enviado a PT; 3 = Cambio de tipo; 4 = Otros");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionMotorsHistory>(entity =>
            {
                entity.HasKey(e => e.Serie);

                entity.ToTable("Production_Motors_History");

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPhotoCenterProof1).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof10).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof11).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof12).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof13).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof14).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof15).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof16).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof17).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof18).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof19).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof2).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof20).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof21).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof22).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof23).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof3).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof4).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof5).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof6).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof7).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof8).HasColumnType("datetime");

                entity.Property(e => e.FechaPhotoCenterProof9).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioPhotoCenterProof10Id).HasColumnName("UsuarioPhotoCenterProof10ID");

                entity.Property(e => e.UsuarioPhotoCenterProof11Id).HasColumnName("UsuarioPhotoCenterProof11ID");

                entity.Property(e => e.UsuarioPhotoCenterProof12Id).HasColumnName("UsuarioPhotoCenterProof12ID");

                entity.Property(e => e.UsuarioPhotoCenterProof13Id).HasColumnName("UsuarioPhotoCenterProof13ID");

                entity.Property(e => e.UsuarioPhotoCenterProof14Id).HasColumnName("UsuarioPhotoCenterProof14ID");

                entity.Property(e => e.UsuarioPhotoCenterProof15Id).HasColumnName("UsuarioPhotoCenterProof15ID");

                entity.Property(e => e.UsuarioPhotoCenterProof16Id).HasColumnName("UsuarioPhotoCenterProof16ID");

                entity.Property(e => e.UsuarioPhotoCenterProof17Id).HasColumnName("UsuarioPhotoCenterProof17ID");

                entity.Property(e => e.UsuarioPhotoCenterProof18Id).HasColumnName("UsuarioPhotoCenterProof18ID");

                entity.Property(e => e.UsuarioPhotoCenterProof19Id).HasColumnName("UsuarioPhotoCenterProof19ID");

                entity.Property(e => e.UsuarioPhotoCenterProof1Id).HasColumnName("UsuarioPhotoCenterProof1ID");

                entity.Property(e => e.UsuarioPhotoCenterProof20Id).HasColumnName("UsuarioPhotoCenterProof20ID");

                entity.Property(e => e.UsuarioPhotoCenterProof21Id).HasColumnName("UsuarioPhotoCenterProof21ID");

                entity.Property(e => e.UsuarioPhotoCenterProof22Id).HasColumnName("UsuarioPhotoCenterProof22ID");

                entity.Property(e => e.UsuarioPhotoCenterProof23Id).HasColumnName("UsuarioPhotoCenterProof23ID");

                entity.Property(e => e.UsuarioPhotoCenterProof2Id).HasColumnName("UsuarioPhotoCenterProof2ID");

                entity.Property(e => e.UsuarioPhotoCenterProof3Id).HasColumnName("UsuarioPhotoCenterProof3ID");

                entity.Property(e => e.UsuarioPhotoCenterProof4Id).HasColumnName("UsuarioPhotoCenterProof4ID");

                entity.Property(e => e.UsuarioPhotoCenterProof5Id).HasColumnName("UsuarioPhotoCenterProof5ID");

                entity.Property(e => e.UsuarioPhotoCenterProof6Id).HasColumnName("UsuarioPhotoCenterProof6ID");

                entity.Property(e => e.UsuarioPhotoCenterProof7Id).HasColumnName("UsuarioPhotoCenterProof7ID");

                entity.Property(e => e.UsuarioPhotoCenterProof8Id).HasColumnName("UsuarioPhotoCenterProof8ID");

                entity.Property(e => e.UsuarioPhotoCenterProof9Id).HasColumnName("UsuarioPhotoCenterProof9ID");
            });

            modelBuilder.Entity<ProductionMotorsMultiplant>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Production_Motors_Multiplant_1");

                entity.ToTable("Production_Motors_Multiplant");

                entity.HasIndex(e => new { e.FechaRegistro, e.Serie, e.Modelo })
                    .HasName("IX_Production_Motors_Multiplant");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId)
                    .HasColumnName("PlantaID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkstationId).HasColumnName("WorkstationID");
            });

            modelBuilder.Entity<ProductionMotorsMultiplantHistory>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Motors_Multiplant_History");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId)
                    .HasColumnName("PlantaID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkstationId).HasColumnName("WorkstationID");
            });

            modelBuilder.Entity<ProductionMotorsRecordsLack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Production_Motors_RecordsLack");

                entity.Property(e => e.FechaModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionMotorsSequences>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Motors_Sequences");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");
            });

            modelBuilder.Entity<ProductionQcMotorsSequences>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_QC_Motors_Sequences");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");
            });

            modelBuilder.Entity<ProductionStations>(entity =>
            {
                entity.HasKey(e => e.IdEstacion)
                    .HasName("PK_Quality_Docs_JobsStations");

                entity.ToTable("Production_Stations");

                entity.HasIndex(e => e.Numero)
                    .HasName("IX_Quality_Docs_JobsStations_Numero");

                entity.Property(e => e.IdEstacion).HasColumnName("ID_Estacion");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExamenAuditivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroUnidadNegocio).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalRequerido).HasDefaultValueSql("((4))");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PlantaTiempoLaboradoId).HasColumnName("PlantaTiempoLaboradoID");

                entity.Property(e => e.RevisionDocCarpeta).HasDefaultValueSql("((0))");

                entity.Property(e => e.RevisionDocPantalla).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnidadNegocioId)
                    .HasColumnName("UnidadNegocioID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroUnidadNegocioId)
                    .HasColumnName("UsuarioRegistroUnidadNegocioID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductionStationsDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Production_Stations_Docs");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");
            });

            modelBuilder.Entity<ProductionStationsDocsUpdate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_Stations_DocsUpdate");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ProductionStationsMachinery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Production_Stations_Machinery");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");
            });

            modelBuilder.Entity<ProductionStopModels>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Production_StopModels");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MensajeAlerta)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioLiberacionId).HasColumnName("UsuarioLiberacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.Property(e => e.IdProveedor).HasColumnName("ID_Proveedor");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityAuditsAuditConcentration>(entity =>
            {
                entity.HasKey(e => e.IdRegistroConcentracion);

                entity.ToTable("Quality_Audits_AuditConcentration");

                entity.Property(e => e.IdRegistroConcentracion).HasColumnName("ID_RegistroConcentracion");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioaRegistroId)
                    .HasColumnName("UsuarioaRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditDocuments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Audits_AuditDocuments");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.PlannerId).HasColumnName("PlannerID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditEnvironmentalCulture>(entity =>
            {
                entity.HasKey(e => e.IdRegistroCultura);

                entity.ToTable("Quality_Audits_AuditEnvironmentalCulture");

                entity.Property(e => e.IdRegistroCultura).HasColumnName("ID_RegistroCultura");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioaRegistroId)
                    .HasColumnName("UsuarioaRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditIlumination>(entity =>
            {
                entity.HasKey(e => e.IdRegistroIlumination);

                entity.ToTable("Quality_Audits_AuditIlumination");

                entity.Property(e => e.IdRegistroIlumination).HasColumnName("ID_RegistroIlumination");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioaRegistroId)
                    .HasColumnName("UsuarioaRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditIpp>(entity =>
            {
                entity.HasKey(e => e.IdRegistroIpp);

                entity.ToTable("Quality_Audits_AuditIPP");

                entity.Property(e => e.IdRegistroIpp).HasColumnName("ID_RegistroIPP");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioaRegistroId)
                    .HasColumnName("UsuarioaRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditMatrixAbilities>(entity =>
            {
                entity.HasKey(e => e.IdRegistroHabilidades)
                    .HasName("PK_Quality_Audits_AuditAbilities");

                entity.ToTable("Quality_Audits_AuditMatrixAbilities");

                entity.Property(e => e.IdRegistroHabilidades).HasColumnName("ID_RegistroHabilidades");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SupervisorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsusarioRegistroId).HasColumnName("UsusarioRegistroID");
            });

            modelBuilder.Entity<QualityAuditsAuditMeasurementEquipment>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Audits_AuditMeasurementEquipment");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Alerta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GageId).HasColumnName("GageID");

                entity.Property(e => e.PlannerId).HasColumnName("PlannerID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioResponsableId).HasColumnName("UsuarioResponsableID");
            });

            modelBuilder.Entity<QualityAuditsAuditPreControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Audits_AuditPreControl");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistroControl)
                    .HasColumnName("ID_RegistroControl")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioaRegistroId)
                    .HasColumnName("UsuarioaRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditTeamLeader>(entity =>
            {
                entity.HasKey(e => e.IdRegistroIlumination);

                entity.ToTable("Quality_Audits_AuditTeamLeader");

                entity.Property(e => e.IdRegistroIlumination).HasColumnName("ID_RegistroIlumination");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.Medicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioaRegistroId)
                    .HasColumnName("UsuarioaRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditTorques>(entity =>
            {
                entity.HasKey(e => e.IdRegistroTorques);

                entity.ToTable("Quality_Audits_AuditTorques");

                entity.Property(e => e.IdRegistroTorques).HasColumnName("ID_RegistroTorques");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Calibracion).HasColumnType("date");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GageId).HasColumnName("GageID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditWarrantyActions>(entity =>
            {
                entity.HasKey(e => e.IdRegistroAccion);

                entity.ToTable("Quality_Audits_AuditWarrantyActions");

                entity.Property(e => e.IdRegistroAccion).HasColumnName("ID_RegistroAccion");

                entity.Property(e => e.AccionId).HasColumnName("AccionID");

                entity.Property(e => e.Alerta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditPlannerId).HasColumnName("AuditPlannerID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaArranque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioResponsableId)
                    .HasColumnName("UsuarioResponsableID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsAuditsOpen>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Audits_AuditsOpen");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AuditoriaId).HasColumnName("AuditoriaID");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.LineaId).HasColumnName("LineaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusTemplate).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoAuditoriaId).HasColumnName("TipoAuditoriaID");
            });

            modelBuilder.Entity<QualityAuditsCharacteristics>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica)
                    .HasName("PK_Quality_Audits_Characteristic");

                entity.ToTable("Quality_Audits_Characteristics");

                entity.Property(e => e.IdCaracteristica).HasColumnName("ID_Caracteristica");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsDateRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Audits_DateRange");

                entity.Property(e => e.DateFormatOption).HasColumnName("dateFormatOption");

                entity.Property(e => e.DateOutput)
                    .HasColumnName("dateOutput")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<QualityAuditsDepartments>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Quality_Audits_Departments");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.Audit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");
            });

            modelBuilder.Entity<QualityAuditsInput>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria)
                    .HasName("PK_Quality_Audits_Audits");

                entity.ToTable("Quality_Audits_Input");

                entity.Property(e => e.IdAuditoria).HasColumnName("ID_Auditoria");

                entity.Property(e => e.EstacionId)
                    .HasColumnName("EstacionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineaId)
                    .HasColumnName("LineaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoAuditoriaId)
                    .HasColumnName("TipoAuditoriaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioBajaId)
                    .HasColumnName("UsuarioBajaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsInspectors>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Audits_Inspectors");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InspectorId).HasColumnName("InspectorID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityAuditsLines>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Audits_Lines");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Linea)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId)
                    .HasColumnName("UsuarioBajaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsPlanners>(entity =>
            {
                entity.HasKey(e => e.IdAuditPlanner);

                entity.ToTable("Quality_Audits_Planners");

                entity.Property(e => e.IdAuditPlanner).HasColumnName("ID_AuditPlanner");

                entity.Property(e => e.FechaAsignado).HasColumnType("date");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistrado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaTerminacion).HasColumnType("datetime");

                entity.Property(e => e.IncompletaId)
                    .HasColumnName("IncompletaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InspectorAsignadoId)
                    .HasColumnName("InspectorAsignadoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineaId).HasColumnName("LineaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioActualizacionId).HasColumnName("UsuarioActualizacionID");

                entity.Property(e => e.UsuarioAsignadoId)
                    .HasColumnName("UsuarioAsignadoID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsPlannersCycles>(entity =>
            {
                entity.HasKey(e => e.IdCicloAuditoria)
                    .HasName("PK_Quality_Audits_PlannerCycles");

                entity.ToTable("Quality_Audits_PlannersCycles");

                entity.Property(e => e.IdCicloAuditoria).HasColumnName("ID_CicloAuditoria");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioCierreId).HasColumnName("UsuarioCierreID");
            });

            modelBuilder.Entity<QualityAuditsPlannersWorkStations>(entity =>
            {
                entity.HasKey(e => e.IdPlanner);

                entity.ToTable("Quality_Audits_PlannersWorkStations");

                entity.Property(e => e.IdPlanner).HasColumnName("ID_Planner");

                entity.Property(e => e.CicloAuditoriaId).HasColumnName("CicloAuditoriaID");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaAsignado).HasColumnType("datetime");

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineaId).HasColumnName("LineaID");

                entity.Property(e => e.Modifica).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignoId)
                    .HasColumnName("UsuarioAsignoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioInspectorId).HasColumnName("UsuarioInspectorID");
            });

            modelBuilder.Entity<QualityAuditsTemplates>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Audits");

                entity.ToTable("Quality_Audits_Templates");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AuditoriaId).HasColumnName("AuditoriaID");

                entity.Property(e => e.Caracteristica)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.InputId).HasColumnName("InputID");

                entity.Property(e => e.LineaId).HasColumnName("LineaID");

                entity.Property(e => e.Maquina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maximo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Minimo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityAuditsTypes>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria);

                entity.ToTable("Quality_Audits_Types");

                entity.Property(e => e.IdAuditoria).HasColumnName("ID_Auditoria");

                entity.Property(e => e.Auditoria)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsWarrantyActions>(entity =>
            {
                entity.HasKey(e => e.IdAccion);

                entity.ToTable("Quality_Audits_WarrantyActions");

                entity.Property(e => e.IdAccion).HasColumnName("ID_Accion");

                entity.Property(e => e.Accion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FamiliaId).HasColumnName("FamiliaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityAuditsWarrantyFamily>(entity =>
            {
                entity.HasKey(e => e.IdFamilia);

                entity.ToTable("Quality_Audits_WarrantyFamily");

                entity.Property(e => e.IdFamilia).HasColumnName("ID_Familia");

                entity.Property(e => e.Familia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityAuditsWorkStationsByLines>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Audits_LinesByWorkStations");

                entity.ToTable("Quality_Audits_WorkStationsByLines");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineaId).HasColumnName("LineaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityCaClosers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_CA_Closers");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityCaResponsible>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_CA_Responsible");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityCaSolutionsTypes>(entity =>
            {
                entity.HasKey(e => e.IdSolucion);

                entity.ToTable("Quality_CA_SolutionsTypes");

                entity.Property(e => e.IdSolucion).HasColumnName("ID_Solucion");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Solucion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityCaSources>(entity =>
            {
                entity.HasKey(e => e.IdFuente);

                entity.ToTable("Quality_CA_Sources");

                entity.Property(e => e.IdFuente).HasColumnName("ID_Fuente");

                entity.Property(e => e.Fuente)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityCaTools>(entity =>
            {
                entity.HasKey(e => e.IdHerramienta);

                entity.ToTable("Quality_CA_Tools");

                entity.Property(e => e.IdHerramienta).HasColumnName("ID_Herramienta");

                entity.Property(e => e.Herramienta)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");
            });

            modelBuilder.Entity<QualityCauses>(entity =>
            {
                entity.HasKey(e => e.IdCausa);

                entity.ToTable("Quality_Causes");

                entity.Property(e => e.IdCausa).HasColumnName("ID_Causa");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityCheckListAmef>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CheckList_AMEF");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Desarrollo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityCheckListAmefQuestions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CheckList_AMEF_Questions");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Preguntas)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityCheckListAmefQuestionsResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CheckList_AMEF_Questions_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AmefId).HasColumnName("AmefID");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PreguntaId).HasColumnName("PreguntaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityCheckListAmefRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CheckList_AMEF_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AmefId).HasColumnName("AmefID");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRechazo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");
            });

            modelBuilder.Entity<QualityCheckListAmefReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CheckList_AMEF_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AmefId).HasColumnName("AmefID");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityComponents>(entity =>
            {
                entity.HasKey(e => e.IdComponente);

                entity.ToTable("Quality_Components");

                entity.Property(e => e.IdComponente).HasColumnName("ID_Componente");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityComponentsRecovery>(entity =>
            {
                entity.HasKey(e => e.IdComponente)
                    .HasName("PK_Quality_ComponentsRecovery");

                entity.ToTable("Quality_Components_Recovery");

                entity.Property(e => e.IdComponente).HasColumnName("ID_Componente");

                entity.Property(e => e.Componente)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityComponentsRecoveryByModel>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_ComponentsRecoveryByModel");

                entity.ToTable("Quality_Components_RecoveryByModel");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityComponentsRecoveryByProduct>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Components_RecoveryByProduct");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroComponenteId).HasColumnName("RegistroComponenteID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityCorrectiveActions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CorrectiveActions");

                entity.HasIndex(e => e.FechaApertura)
                    .HasName("IX_Quality_CorrectiveActions");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Acciones)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaAccion).HasComment("1 = Correctiva; 2 = Preventiva; 3 = De Riesgo");

                entity.Property(e => e.Causas)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CerradoPorId).HasColumnName("CerradoPorID");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveAutomatica).HasDefaultValueSql("((1))");

                entity.Property(e => e.ComentariosVerificacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaApertura).HasColumnType("date");

                entity.Property(e => e.FechaCierre).HasColumnType("date");

                entity.Property(e => e.FechaPromesa).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");

                entity.Property(e => e.FuenteId).HasColumnName("FuenteID");

                entity.Property(e => e.HerramientaId).HasColumnName("HerramientaID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.RaspfailureCode)
                    .HasColumnName("RASPFailureCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Raspfamilia)
                    .HasColumnName("RASPFamilia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableActividadId).HasColumnName("ResponsableActividadID");

                entity.Property(e => e.ResponsableSeguimientoId).HasColumnName("ResponsableSeguimientoID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoArchivoAnalisisProblema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArchivoEvidencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSolucionId).HasColumnName("TipoSolucionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.VerificadorId).HasColumnName("VerificadorID");
            });

            modelBuilder.Entity<QualityCorrectiveActionsDelete>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CorrectiveActions_Delete");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Acciones)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Causas)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CerradoPorId).HasColumnName("CerradoPorID");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioDelete)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosVerificacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaApertura).HasColumnType("date");

                entity.Property(e => e.FechaCierre).HasColumnType("date");

                entity.Property(e => e.FechaPromesa).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroDelete)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");

                entity.Property(e => e.FuenteId).HasColumnName("FuenteID");

                entity.Property(e => e.HerramientaId).HasColumnName("HerramientaID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.RaspfailureCode)
                    .HasColumnName("RASPFailureCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Raspfamilia)
                    .HasColumnName("RASPFamilia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableActividadId).HasColumnName("ResponsableActividadID");

                entity.Property(e => e.ResponsableSeguimientoId).HasColumnName("ResponsableSeguimientoID");

                entity.Property(e => e.TipoArchivoAnalisisProblema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArchivoEvidencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSolucionId).HasColumnName("TipoSolucionID");

                entity.Property(e => e.UsuarioDeleteId).HasColumnName("UsuarioDeleteID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.VerificadorId).HasColumnName("VerificadorID");
            });

            modelBuilder.Entity<QualityCorrectiveActionsRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CorrectiveActions_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioCargadoId).HasColumnName("UsuarioCargadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityCorrectiveActionsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CorrectiveActions_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityCorrectiveActionsUpdate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_CorrectiveActions_Update");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Acciones)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Causas)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.IdFuente).HasColumnName("ID_Fuente");

                entity.Property(e => e.IdProceso).HasColumnName("ID_Proceso");

                entity.Property(e => e.ResponsableActividadId).HasColumnName("ResponsableActividadID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDeviations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CantidadAnterior).HasDefaultValueSql("((1))");

                entity.Property(e => e.CodigoGarantia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Desviacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDeviationsCapture>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Capture");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AccionCorrectiva)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionProccess)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EngineerId).HasColumnName("EngineerID");

                entity.Property(e => e.FechaAccion).HasColumnType("date");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LimitDate).HasColumnType("date");

                entity.Property(e => e.OriginChange)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioCierreId).HasColumnName("UsuarioCierreID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkStationId)
                    .HasColumnName("WorkStationID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityDeviationsEngineering>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Engineering");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Determination)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.DeviationId).HasColumnName("DeviationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobsId)
                    .IsRequired()
                    .HasColumnName("JobsID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDeviationsModels>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_DeviationsModels");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroDesviacionId).HasColumnName("RegistroDesviacionID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityDeviationsRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DesviationId).HasColumnName("DesviationID");

                entity.Property(e => e.FechaRechazo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");
            });

            modelBuilder.Entity<QualityDeviationsReturn>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Return");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ComentarioReturn)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DesviationId).HasColumnName("DesviationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioReturnId).HasColumnName("UsuarioReturnID");
            });

            modelBuilder.Entity<QualityDeviationsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.DesviationId).HasColumnName("DesviationID");

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDeviationsReviewsAuth>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Reviews_Auth");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDeviationsTagsLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_DeviationsTags_Log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DesviacionId).HasColumnName("DesviacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDeviationsTagsModel>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_DeviationsTags_Model");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DesviacionId).HasColumnName("DesviacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityDeviationsTagsModelLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_DeviationsTags_Model_Log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DesviacionId).HasColumnName("DesviacionID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityDeviationsWarranty>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Deviations_Warranty");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DesviationId).HasColumnName("DesviationID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MetodoTrazabilidad)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableTrazabilidadId).HasColumnName("ResponsableTrazabilidadID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDocsAffectedDocuments>(entity =>
            {
                entity.HasKey(e => e.IdDocumento);

                entity.ToTable("Quality_Docs_AffectedDocuments");

                entity.Property(e => e.IdDocumento).HasColumnName("ID_Documento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsConfidentialDocsGroups>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("Quality_Docs_ConfidentialDocs_Groups");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_Grupo");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityDocsConfidentialDocsGroupsDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_ConfidentialDocs_GroupsDocs");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityDocsConfidentialDocsGroupsUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_ConfidentialDocs_GroupsUsers");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsDocumentsDigital>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_DocumentsDigital");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDocsDocumentsKeys>(entity =>
            {
                entity.HasKey(e => e.IdClaveDocumento);

                entity.ToTable("Quality_Docs_DocumentsKeys");

                entity.Property(e => e.IdClaveDocumento).HasColumnName("ID_ClaveDocumento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ejemplo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsDocumentsKeysFields>(entity =>
            {
                entity.HasKey(e => e.IdCampo);

                entity.ToTable("Quality_Docs_DocumentsKeys_Fields");

                entity.Property(e => e.IdCampo).HasColumnName("ID_Campo");

                entity.Property(e => e.ClaveDocumentoId).HasColumnName("ClaveDocumentoID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.ValorDefault)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityDocsDocumentsTypes>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("Quality_Docs_DocumentsTypes");

                entity.Property(e => e.IdTipo).HasColumnName("ID_Tipo");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsEmployeesTrainingUpdatedDocs>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Docs_EmployeesTraining");

                entity.ToTable("Quality_Docs_EmployeesTraining_UpdatedDocs");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaCapacitacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = Pendiente; 2 = Actualizado; 3 = Incompleto.");

                entity.Property(e => e.StatusEmpleado).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsFormatsQuantityViewed>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_FormatsQuantityViewed");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<QualityDocsJobsDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_JobsDocs");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.PuestoId).HasColumnName("PuestoID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityDocsOriginChange>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK__Quality___3E5D8D4ECF384BDB");

                entity.ToTable("Quality_Docs_OriginChange");

                entity.Property(e => e.IdRegistro).HasColumnName("Id_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Titulo).HasMaxLength(250);
            });

            modelBuilder.Entity<QualityDocsQuantityViewed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_QuantityViewed");

                entity.HasIndex(e => e.DocumentoId)
                    .IsUnique();

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");
            });

            modelBuilder.Entity<QualityDocsReport>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Report");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ChangeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveDt)
                    .HasColumnName("ClaveDT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateRevision)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescDoc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescDoc2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescDt)
                    .HasColumnName("DescDT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroDoc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumento).HasColumnName("ID_Documento");

                entity.Property(e => e.ResponsableChange)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.Solicitante)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDocTxt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityDocsReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews");

                entity.HasIndex(e => e.FechaRegistro)
                    .HasName("IX_Quality_Docs_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DigitalId).HasColumnName("DigitalID");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaTerminacion).HasColumnType("datetime");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenComentario)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Revision)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.SolicitanteId).HasColumnName("SolicitanteID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDigital).HasComment("1.-Hoja Factibilidad,2.-Voz del Cliente,3.-Descripcion de Puesto,4.-Desviaciones");

                entity.Property(e => e.Validacion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityDocsReviewsActions>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews_Actions");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Operacion).HasComment("1 = Aprobacion; 2 = Rechazo");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsReviewsAffectedDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_Reviews_AffectedDocs");

                entity.Property(e => e.DocAfectadoId).HasColumnName("DocAfectadoID");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");
            });

            modelBuilder.Entity<QualityDocsReviewsAuth>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews_Auth");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = Abierto; 2 = Aprobado; 3 = Rechazado");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsReviewsCheck>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews_Check");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsReviewsReleases>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews_Releases");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsReviewsUpdates>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews_Updates");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaUpdate).HasColumnType("datetime");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsReviewsVoBo>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Docs_Reviews_VoBo");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = Abierto; 2 = Aprobado; 3 = Rechazado");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsReviewsVoBosEmailsSent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_Reviews_VoBosEmailsSent");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.RevisionId).HasColumnName("RevisionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsUsersAffectedDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_UsersAffectedDocs");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsUsersDocsTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_UsersDocsTypes");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocsUsersPrivileges>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Docs_UsersPrivileges");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PrivilegioId)
                    .HasColumnName("PrivilegioID")
                    .HasComment("1 = Edición; 2 = VoBo; 3 = Autorización; 4 = Nuevo documento");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityDocuments>(entity =>
            {
                entity.HasKey(e => e.IdDocumento);

                entity.ToTable("Quality_Documents");

                entity.HasIndex(e => e.Clave);

                entity.Property(e => e.IdDocumento).HasColumnName("ID_Documento");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosBaja)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formato).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.SolicitudAnp).HasColumnName("SolicitudANP");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = Activo; 2 = En firmas; 3 = Rechazado; 4 = Borrado; 5.-Revision");

                entity.Property(e => e.TipoDocumentoId)
                    .HasColumnName("TipoDocumentoID")
                    .HasComment("1 = Activo; 2 = En firmas; 3 = Rechazado; 4 = Borrado");

                entity.Property(e => e.UsuarioRegistroBajaId).HasColumnName("UsuarioRegistroBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioSaveId).HasColumnName("UsuarioSaveID");
            });

            modelBuilder.Entity<QualityDocumentsDelete>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Documents_Delete");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityEffects>(entity =>
            {
                entity.HasKey(e => e.IdEfecto)
                    .HasName("PK_Quality_Fails");

                entity.ToTable("Quality_Effects");

                entity.Property(e => e.IdEfecto).HasColumnName("ID_Efecto");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityEspecialTest>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Especial_Test");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Causa)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoId).HasColumnName("CodigoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolioAnp).HasColumnName("FolioANP");

                entity.Property(e => e.Objetivo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableImpresionId)
                    .HasColumnName("ResponsableImpresionID")
                    .HasDefaultValueSql("((970))");

                entity.Property(e => e.ResponsableProduccionId).HasColumnName("ResponsableProduccionID");

                entity.Property(e => e.ResponsablePruebaId).HasColumnName("ResponsablePruebaID");

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnidadNegocioId).HasColumnName("UnidadNegocioID");

                entity.Property(e => e.UnidadNegocioSecondId).HasColumnName("UnidadNegocioSecondID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityEspecialTestRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Especial_Test_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRechazo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.UsuarioRechazoId).HasColumnName("UsuarioRechazoID");
            });

            modelBuilder.Entity<QualityEspecialTestReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Especial_Test_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityEspecialTestSeries>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Especial_Test_Series");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityEvaluationRisks>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Evaluation_Risks");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Actual)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Efectos)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityFails>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Fails_1");

                entity.ToTable("Quality_Fails");

                entity.HasIndex(e => e.Serie)
                    .HasName("IX_Quality_Fails");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CausaId).HasColumnName("CausaID");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.ConclusionId)
                    .HasColumnName("ConclusionID")
                    .HasComment("1 = Reparado; 2 = Desensamblado; 3 = No Fail");

                entity.Property(e => e.DepartamentoCausaId).HasColumnName("DepartamentoCausaID");

                entity.Property(e => e.DescripcionCausa)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionConclusion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionEfecto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EfectoId).HasColumnName("EfectoID");

                entity.Property(e => e.FechaRegistroCausa).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroConclusion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroEfecto).HasColumnType("datetime");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerieComponente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoReparacion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroCausaId).HasColumnName("UsuarioRegistroCausaID");

                entity.Property(e => e.UsuarioRegistroConclusionId).HasColumnName("UsuarioRegistroConclusionID");

                entity.Property(e => e.UsuarioRegistroEfectoId).HasColumnName("UsuarioRegistroEfectoID");
            });

            modelBuilder.Entity<QualityFailsInProcess>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_FailsInProcess_1");

                entity.ToTable("Quality_FailsInProcess");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CausaId).HasColumnName("CausaID");

                entity.Property(e => e.ComponenteId).HasColumnName("ComponenteID");

                entity.Property(e => e.DepartamentoCausaId).HasColumnName("DepartamentoCausaID");

                entity.Property(e => e.DescripcionCausa)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FamiliaId).HasColumnName("FamiliaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroCausa).HasColumnType("datetime");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PruebaId).HasColumnName("PruebaID");

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroCausaId).HasColumnName("UsuarioRegistroCausaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityFailsMotoParts>(entity =>
            {
                entity.HasKey(e => e.RegistroId);

                entity.ToTable("Quality_FailsMotoParts");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");

                entity.Property(e => e.CodigoParteId).HasColumnName("CodigoParteID");

                entity.Property(e => e.FallaId).HasColumnName("FallaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityMetrolGages>(entity =>
            {
                entity.HasKey(e => e.IdGage)
                    .HasName("PK_Quality_Metrology_Gages");

                entity.ToTable("Quality_Metrol_Gages");

                entity.Property(e => e.IdGage).HasColumnName("ID_Gage");

                entity.Property(e => e.Activo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calibracion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalibracionExterna)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCalibracionAnterior).HasColumnType("date");

                entity.Property(e => e.FechaCalibracionSiguiente).HasColumnType("date");

                entity.Property(e => e.FechaCompra).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrupoId)
                    .HasColumnName("GrupoID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LlamadaAnterior)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Locacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MedidaRango)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroGage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Rango)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioOwnerId).HasColumnName("UsuarioOwnerID");

                entity.Property(e => e.UsuarioOwnerStr)
                    .HasColumnName("UsuarioOwnerSTR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityMetrolGagesCalibration>(entity =>
            {
                entity.HasKey(e => e.IdCalibracion);

                entity.ToTable("Quality_Metrol_Gages_Calibration");

                entity.Property(e => e.IdCalibracion).HasColumnName("ID_Calibracion");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCalibracion).HasColumnType("date");

                entity.Property(e => e.FechaCalibracionAnterior).HasColumnType("date");

                entity.Property(e => e.FechaCalibracionSiguiente).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GageId).HasColumnName("GageID");

                entity.Property(e => e.ProveedorCalibradoId).HasColumnName("ProveedorCalibradoID");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioCalibradoId).HasColumnName("UsuarioCalibradoID");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityMetrolGagesGroups>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PK_Quality_Metrology_GagesGroups");

                entity.ToTable("Quality_Metrol_Gages_Groups");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_Grupo");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityMetrolGagesStations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Metrol_Gages_Stations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.EstacionNuevaId).HasColumnName("EstacionNuevaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GageId).HasColumnName("GageID");

                entity.Property(e => e.LocacionId)
                    .HasColumnName("LocacionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocacionNuevaId)
                    .HasColumnName("LocacionNuevaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Razon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityMetrolGagesStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK_Quality_Metrology_GagesStatus");

                entity.ToTable("Quality_Metrol_Gages_Status");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.DescripcionStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityMetrolGagesStatusChanged>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Metrol_Gages_StatusChanged");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("getdate()");

                entity.Property(e => e.GageId).HasColumnName("GageID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusAnteriorId).HasColumnName("StatusAnteriorID");

                entity.Property(e => e.StatusNuevoId).HasColumnName("StatusNuevoID");

                entity.Property(e => e.UsuarioRegistroId)
                    .HasColumnName("UsuarioRegistroID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QualityModelFeatures>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_ModelFeatures_Resp27032020");

                entity.ToTable("Quality_ModelFeatures");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizadoOrden).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FotoCatPicId).HasColumnName("FotoCatPicID");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesComments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_ModelFeatures_Comments");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesFilesOrder>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_ModelFeatures_FilesOrder");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelFeaturesLastMultipleUpload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_LastMultipleUpload");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");
            });

            modelBuilder.Entity<QualityModelFeaturesMissingAssamble>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_ModelFeatures_MissingAssamble");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityModelFeaturesMissingAssambleLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_ModelFeatures_MissingAssamble_log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_ModelFeatures_Results");

                entity.HasIndex(e => new { e.FechaRegistro, e.Serie, e.Modelo, e.PlantaId })
                    .HasName("IX_Quality_ModelFeatures_Results");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.EstacionBack).HasColumnName("Estacion_Back");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModelStatus).HasComment("1.-Aprobado,2.-Desaprobado,3.-Temporal");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesResultsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_Results_History");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesResultsPackaging>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_ModelFeatures_Results_Packaging");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmbalajeId).HasColumnName("EmbalajeID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HuacalId).HasColumnName("HuacalID");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TubbaseId).HasColumnName("TUBBaseID");

                entity.Property(e => e.TubinsertoId).HasColumnName("TUBInsertoID");

                entity.Property(e => e.TubinsertoMaderaId).HasColumnName("TUBInsertoMaderaID");

                entity.Property(e => e.TubproblemaId).HasColumnName("TUBProblemaID");

                entity.Property(e => e.TubtapaId).HasColumnName("TUBTapaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelFeaturesResultsResp20012022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_Results_resp20012022");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesResultsResp23012022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_Results_resp23012022");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesResultsResp25012022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_Results_resp25012022");

                entity.Property(e => e.CaracteristicaId).HasColumnName("CaracteristicaID");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelFeaturesSinFoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_SinFoto");

                entity.Property(e => e.FotoCatPicId)
                    .IsRequired()
                    .HasColumnName("FotoCatPicID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityModelFeaturesSubComponents>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_ModelFeatures_SubComponents");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo).HasMaxLength(255);

                entity.Property(e => e.Operacion).HasMaxLength(255);

                entity.Property(e => e.SubModelo).HasMaxLength(255);
            });

            modelBuilder.Entity<QualityModelFeaturesToUpdate>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_MotorFeatures_ToUpdate");

                entity.ToTable("Quality_ModelFeatures_ToUpdate");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FotoCatPicId).HasColumnName("FotoCatPicID");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelStatus>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Model_Status");

                entity.HasIndex(e => e.IdRegistro)
                    .HasName("IX_Quality_Model_Status");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ComentarioCambioStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioDesaprobado)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioTemporal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloId).HasColumnName("ModeloID");

                entity.Property(e => e.StatusModel).HasComment("1.-Aprobado,2.-Desaprobado,3.-Temporal");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelsModelsChanges>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Models_ModelsChanges");

                entity.Property(e => e.IdRegistro).HasColumnName("Id_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModeloAnterior)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloNuevo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityModelsPackagingHuacales>(entity =>
            {
                entity.HasKey(e => e.IdHuacal);

                entity.ToTable("Quality_Models_Packaging_Huacales");

                entity.Property(e => e.IdHuacal).HasColumnName("ID_Huacal");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelsPackagingProblems>(entity =>
            {
                entity.HasKey(e => e.IdProblema);

                entity.ToTable("Quality_Models_Packaging_Problems");

                entity.Property(e => e.IdProblema).HasColumnName("ID_Problema");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelsPackagingTubsBases>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Models_Packaging_Tubs_Bases");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTubsBases)
                    .HasColumnName("ID_Tubs_Bases")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelsPackagingTubsInserts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Models_Packaging_Tubs_Inserts");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTubsInserts)
                    .HasColumnName("ID_Tubs_Inserts")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelsPackagingTubsInsertsWood>(entity =>
            {
                entity.HasKey(e => e.IdTubsInsertsWood);

                entity.ToTable("Quality_Models_Packaging_Tubs_Inserts_Wood");

                entity.Property(e => e.IdTubsInsertsWood).HasColumnName("ID_Tubs_Inserts_Wood");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityModelsPackagingTubsTapas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Models_Packaging_Tubs_Tapas");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTubsTapas)
                    .HasColumnName("ID_Tubs_Tapas")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityMonitorRisks>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Monitor_Risks");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Factor)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PestelId).HasColumnName("PestelID");

                entity.Property(e => e.Proceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityMonitorRisksEvaluation>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Monitor_Risks_Evaluation");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FactorId).HasColumnName("FactorID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<QualityMonitorRisksHistory>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Monitor_Risks_History");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FactorId).HasColumnName("FactorID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityMonitorRisksPestel>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Monitor_Risks_Pestel");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Factor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicators>(entity =>
            {
                entity.HasKey(e => e.IdIndicador);

                entity.ToTable("Quality_Performance_Indicators");

                entity.Property(e => e.IdIndicador).HasColumnName("ID_Indicador");

                entity.Property(e => e.Conclusiones)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento).HasComment(@"1.-Calidad,
2.-Finanzas,
3.-Ingenieria,
4.-Logistica,
5.-Mantenimiento,
6.-Planta 3,
7.-Planta 4,
8.-Produccion,
9.-Produccion P2,
10.- RH
");

                entity.Property(e => e.Encendido).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.Incumplimiento)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorDesempeno)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MesIndicador)
                    .HasColumnType("datetime")
                    .HasComment("");

                entity.Property(e => e.NumeroIndicador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjetivoIndicador).HasComment("1.-No,2.-Partially, 3.-Mostly,4.-Yes,5.-New PI");

                entity.Property(e => e.ObjetivoYtd).HasColumnName("ObjetivoYTD");

                entity.Property(e => e.Pca)
                    .HasColumnName("PCA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TendenciaIndicador).HasComment(@"1.-Negative,
2.-Positive,
3.-Stable
");

                entity.Property(e => e.UsuarioCierreId).HasColumnName("UsuarioCierreID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsAccumulated>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Accumulated");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsChangescomments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Changescomments");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ConclusionesAnteriores)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConclusionesNuevo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroId)
                    .HasColumnName("FechaRegistroID")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IncumplimientoAnterior)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IncumplimientoNuevo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsConcepts>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Concepts");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");

                entity.Property(e => e.Metric).HasComment("0.-nada,1.-Porcentaje,2.-Amount");

                entity.Property(e => e.MetricRule).HasComment(@"0.-menos es mejor ,
1.-mas es mejor");

                entity.Property(e => e.NumeroId).HasColumnName("NumeroID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProcesoId).HasColumnName("ProcesoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsConclusion>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Conclusion");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Conlusion)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoRegistro).HasComment("0.Guardar , 1.-Desaprobada");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsDepartaments>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Quality_Performance_Indicators_Departaments");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsGoals>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Goals");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsIndicador>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Performance_Indicators_Indicador");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdIndicador)
                    .HasColumnName("ID_Indicador")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Indicador)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsNo>(entity =>
            {
                entity.HasKey(e => e.IdNumero);

                entity.ToTable("Quality_Performance_Indicators_No");

                entity.Property(e => e.IdNumero).HasColumnName("ID_Numero");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Proceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsPrivileges>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Privileges");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Contenido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTab)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroId)
                    .HasColumnName("FechaRegistroID")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PrivilegioId).HasColumnName("PrivilegioID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsProcess>(entity =>
            {
                entity.HasKey(e => e.IdProceso);

                entity.ToTable("Quality_Performance_Indicators_Process");

                entity.Property(e => e.IdProceso).HasColumnName("ID_Proceso");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsReal>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_Real");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceIndicatorsUpdMetric>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Indicators_updMetric");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Metric).HasComment("0.-Menos es mejor , 1.-Mas es mejor");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityPerformanceReportsManufacturing02>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Performance_ReportsManufacturing_02");

                entity.ToTable("Quality_Performance_Reports_Manufacturing_02");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaFabricanteId).HasColumnName("PlantaFabricanteID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityPerformanceReportsManufacturing02Details>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Performance_Reports_Manufacturing_02_Details");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FabricanteId).HasColumnName("FabricanteID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<QualityPerformanceReportsManufacturingMaster>(entity =>
            {
                entity.HasKey(e => e.Registro);

                entity.ToTable("Quality_Performance_Reports_ManufacturingMaster");

                entity.Property(e => e.CantidadRma)
                    .HasColumnName("CantidadRMA")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CloseDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCompleto)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoFalla)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRma)
                    .HasColumnName("CodigoRMA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Familia)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInspeccion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaProduccion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaReclamo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRma)
                    .HasColumnName("FechaRMA")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaVenta)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FieldRepair)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FieldRepairable)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nfwgyn)
                    .HasColumnName("NFWGYN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nfwp)
                    .HasColumnName("NFWP")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nfwpamt).HasColumnName("NFWPAmt");

                entity.Property(e => e.NombreCargo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroParte)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRam)
                    .HasColumnName("NumeroRAM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroReclamo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PtsRcvd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reg20)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Size)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Vinreclamo)
                    .HasColumnName("VINReclamo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Vinventa)
                    .HasColumnName("VINVenta")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityPerformanceReportsRma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Performance_Reports_RMA");

                entity.HasIndex(e => e.IdRegistro)
                    .HasName("IX_Quality_Performance_Reports_RMA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRecibiso).HasColumnType("date");

                entity.Property(e => e.FechaRma)
                    .HasColumnName("FechaRMA")
                    .HasColumnType("date");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NumeroRma)
                    .HasColumnName("NumeroRMA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRma)
                    .HasColumnName("TipoRMA")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityPerformanceReportsSales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Performance_Reports_Sales");

                entity.HasIndex(e => e.IdRegistro)
                    .HasName("IX_Quality_Performance_ReportsSales");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVenta).HasColumnType("date");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nfw)
                    .IsRequired()
                    .HasColumnName("NFW")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCliente)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVin)
                    .IsRequired()
                    .HasColumnName("NumeroVIN")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityPerformanceReportsWarranty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_Performance_Reports_Warranty");

                entity.HasIndex(e => e.IdRegistro)
                    .HasName("IX_Quality_Performance_Reports_Warranty");

                entity.Property(e => e.CargaFabrica)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoFalla)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoReclamo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierreReclamo).HasColumnType("date");

                entity.Property(e => e.FechaFalla).HasColumnType("date");

                entity.Property(e => e.FechaInspeccion).HasColumnType("date");

                entity.Property(e => e.FechaInstalacion).HasColumnType("date");

                entity.Property(e => e.FechaRecepcion).HasColumnType("date");

                entity.Property(e => e.FechaReclamo).HasColumnType("date");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MillasFalla)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MillasInstalacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreInspector)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroReclamo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReclamoVin)
                    .IsRequired()
                    .HasColumnName("ReclamoVIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QualityPhotoCenterUpdBackupFolderRecords>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_PhotoCenter_UpdBackupFolder_Records");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<QualityProcesses>(entity =>
            {
                entity.HasKey(e => e.IdProceso)
                    .HasName("PK_Quality_Docs_Processes");

                entity.ToTable("Quality_Processes");

                entity.Property(e => e.IdProceso).HasColumnName("ID_Proceso");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityRmc>(entity =>
            {
                entity.HasKey(e => e.RegistroId);

                entity.ToTable("Quality_RMC");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");

                entity.Property(e => e.Avgoilflow).HasColumnName("AVGOILFLOW");

                entity.Property(e => e.Avgoiltemp).HasColumnName("AVGOILTEMP");

                entity.Property(e => e.CompTestRpm)
                    .HasColumnName("Comp_Test_RPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Compmaxpsi).HasColumnName("COMPMAXPSI");

                entity.Property(e => e.Compminpsi).HasColumnName("COMPMINPSI");

                entity.Property(e => e.Compresults)
                    .HasColumnName("COMPRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl10comp).HasColumnName("CYL10COMP");

                entity.Property(e => e.Cyl10results)
                    .HasColumnName("CYL10RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl1comp).HasColumnName("CYL1COMP");

                entity.Property(e => e.Cyl1deact)
                    .HasColumnName("CYL1DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl1results)
                    .HasColumnName("CYL1RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl2comp).HasColumnName("CYL2COMP");

                entity.Property(e => e.Cyl2results)
                    .HasColumnName("CYL2RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl3comp).HasColumnName("CYL3COMP");

                entity.Property(e => e.Cyl3results)
                    .HasColumnName("CYL3RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl4comp).HasColumnName("CYL4COMP");

                entity.Property(e => e.Cyl4deact)
                    .HasColumnName("CYL4DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl4results)
                    .HasColumnName("CYL4RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl5comp).HasColumnName("CYL5COMP");

                entity.Property(e => e.Cyl5results)
                    .HasColumnName("CYL5RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl6comp).HasColumnName("CYL6COMP");

                entity.Property(e => e.Cyl6deact)
                    .HasColumnName("CYL6DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl6results)
                    .HasColumnName("CYL6RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl7comp).HasColumnName("CYL7COMP");

                entity.Property(e => e.Cyl7deact)
                    .HasColumnName("CYL7DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl7results)
                    .HasColumnName("CYL7RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl8comp).HasColumnName("CYL8COMP");

                entity.Property(e => e.Cyl8results)
                    .HasColumnName("CYL8RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl9comp).HasColumnName("CYL9COMP");

                entity.Property(e => e.Cyl9results)
                    .HasColumnName("CYL9RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyldeactresults)
                    .HasColumnName("CYLDEACTRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leak1)
                    .HasColumnName("LEAK1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leak2)
                    .HasColumnName("LEAK2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leakmin).HasColumnName("LEAKMIN");

                entity.Property(e => e.Leakresults)
                    .HasColumnName("LEAKRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leaktime).HasColumnName("LEAKTIME");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxTestedPsi).HasColumnName("MaxTestedPSI");

                entity.Property(e => e.Maxoilpsi).HasColumnName("MAXOILPSI");

                entity.Property(e => e.Maxtorque).HasColumnName("MAXTORQUE");

                entity.Property(e => e.Maxtrqdeg).HasColumnName("MAXTRQDEG");

                entity.Property(e => e.Maxtrqmeas).HasColumnName("MAXTRQMEAS");

                entity.Property(e => e.Minoilpsi).HasColumnName("MINOILPSI");

                entity.Property(e => e.MintestedPsi).HasColumnName("MINTestedPSI");

                entity.Property(e => e.NoSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Runinoilpsi).HasColumnName("RUNINOILPSI");

                entity.Property(e => e.Runinresults)
                    .HasColumnName("RUNINRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Runinrpm).HasColumnName("RUNINRPM");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Torqueresults)
                    .HasColumnName("TORQUERESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VariancePsi).HasColumnName("VariancePSI");

                entity.Property(e => e.Vvtcyl1)
                    .HasColumnName("VVTCYL1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtcyl2)
                    .HasColumnName("VVTCYL2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtcyl5)
                    .HasColumnName("VVTCYL5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtcyl6)
                    .HasColumnName("VVTCYL6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtresults)
                    .HasColumnName("VVTRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityRmcModels>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_RMC_Models");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityRmcPruebas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quality_RMC_Pruebas");

                entity.Property(e => e.Avgoilflow).HasColumnName("AVGOILFLOW");

                entity.Property(e => e.Avgoiltemp).HasColumnName("AVGOILTEMP");

                entity.Property(e => e.CompTestRpm)
                    .HasColumnName("Comp_Test_RPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Compmaxpsi).HasColumnName("COMPMAXPSI");

                entity.Property(e => e.Compminpsi).HasColumnName("COMPMINPSI");

                entity.Property(e => e.Compresults)
                    .HasColumnName("COMPRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl10comp).HasColumnName("CYL10COMP");

                entity.Property(e => e.Cyl10results)
                    .HasColumnName("CYL10RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl1comp).HasColumnName("CYL1COMP");

                entity.Property(e => e.Cyl1deact)
                    .HasColumnName("CYL1DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl1results)
                    .HasColumnName("CYL1RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl2comp).HasColumnName("CYL2COMP");

                entity.Property(e => e.Cyl2results)
                    .HasColumnName("CYL2RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl3comp).HasColumnName("CYL3COMP");

                entity.Property(e => e.Cyl3results)
                    .HasColumnName("CYL3RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl4comp).HasColumnName("CYL4COMP");

                entity.Property(e => e.Cyl4deact)
                    .HasColumnName("CYL4DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl4results)
                    .HasColumnName("CYL4RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl5comp).HasColumnName("CYL5COMP");

                entity.Property(e => e.Cyl5results)
                    .HasColumnName("CYL5RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl6comp).HasColumnName("CYL6COMP");

                entity.Property(e => e.Cyl6deact)
                    .HasColumnName("CYL6DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl6results)
                    .HasColumnName("CYL6RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl7comp).HasColumnName("CYL7COMP");

                entity.Property(e => e.Cyl7deact)
                    .HasColumnName("CYL7DEACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl7results)
                    .HasColumnName("CYL7RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl8comp).HasColumnName("CYL8COMP");

                entity.Property(e => e.Cyl8results)
                    .HasColumnName("CYL8RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyl9comp).HasColumnName("CYL9COMP");

                entity.Property(e => e.Cyl9results)
                    .HasColumnName("CYL9RESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cyldeactresults)
                    .HasColumnName("CYLDEACTRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leak1)
                    .HasColumnName("LEAK1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leak2)
                    .HasColumnName("LEAK2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leakmin).HasColumnName("LEAKMIN");

                entity.Property(e => e.Leakresults)
                    .HasColumnName("LEAKRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Leaktime).HasColumnName("LEAKTIME");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxTestedPsi).HasColumnName("MaxTestedPSI");

                entity.Property(e => e.Maxoilpsi).HasColumnName("MAXOILPSI");

                entity.Property(e => e.Maxtorque).HasColumnName("MAXTORQUE");

                entity.Property(e => e.Maxtrqdeg).HasColumnName("MAXTRQDEG");

                entity.Property(e => e.Maxtrqmeas).HasColumnName("MAXTRQMEAS");

                entity.Property(e => e.Minoilpsi).HasColumnName("MINOILPSI");

                entity.Property(e => e.MintestedPsi).HasColumnName("MINTestedPSI");

                entity.Property(e => e.NoSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroId)
                    .HasColumnName("RegistroID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Runinoilpsi).HasColumnName("RUNINOILPSI");

                entity.Property(e => e.Runinresults)
                    .HasColumnName("RUNINRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Runinrpm).HasColumnName("RUNINRPM");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Torqueresults)
                    .HasColumnName("TORQUERESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VariancePsi).HasColumnName("VariancePSI");

                entity.Property(e => e.Vvtcyl1)
                    .HasColumnName("VVTCYL1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtcyl2)
                    .HasColumnName("VVTCYL2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtcyl5)
                    .HasColumnName("VVTCYL5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtcyl6)
                    .HasColumnName("VVTCYL6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vvtresults)
                    .HasColumnName("VVTRESULTS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualitySuppliersStockAnp>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Suppliers_stockANP");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Po)
                    .IsRequired()
                    .HasColumnName("PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioEntregaId).HasColumnName("UsuarioEntregaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualitySuppliersStockAnpBias>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Suppliers_stockANP_Bias");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompradorId).HasColumnName("CompradorID");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Po)
                    .IsRequired()
                    .HasColumnName("PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioEntregaId).HasColumnName("UsuarioEntregaID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualitySuppliersStockAnpPartialDelivery>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Suppliers_stockANP_PartialDelivery");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EngineerId).HasColumnName("EngineerID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.Voucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualitySuppliersStockAnpReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Suppliers_stockANP_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualitySuppliersStockAnpSytlineExists>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Suppliers_stockANP_SytlineExists");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");
            });

            modelBuilder.Entity<QualityUpdateInformation>(entity =>
            {
                entity.HasKey(e => e.Registro)
                    .HasName("PK_quality_metrol");

                entity.ToTable("Quality_UpdateInformation");

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityWarrantiesByMonth>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Guarantees_ByMonth");

                entity.ToTable("Quality_Warranties_ByMonth");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDate).HasColumnType("date");

                entity.Property(e => e.CloseDate).HasColumnType("date");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dato13yr)
                    .HasColumnName("Dato_13YR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FailureCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistroUp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.MileageAtFailure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfClose)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroClaim)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroEngineSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMfgPart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroParte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSro)
                    .HasColumnName("NumeroSRO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartRcv)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionDate).HasColumnType("date");

                entity.Property(e => e.WhoCourtesyInsp)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityWarrantiesClaims>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Guarantees_Claims$");

                entity.ToTable("Quality_Warranties_Claims");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Administrator).HasMaxLength(255);

                entity.Property(e => e.ApprovalStatus).HasMaxLength(255);

                entity.Property(e => e.ApprovalStatus1)
                    .HasColumnName("ApprovalStatus_1")
                    .HasMaxLength(255);

                entity.Property(e => e.CDerBillAddressStatic)
                    .HasColumnName("C_DerBillAddressStatic")
                    .HasMaxLength(255);

                entity.Property(e => e.CDerShipAddressStatic)
                    .HasColumnName("C_DerShipAddressStatic")
                    .HasMaxLength(255);

                entity.Property(e => e.CallerAddress).HasMaxLength(255);

                entity.Property(e => e.CallerCity).HasMaxLength(255);

                entity.Property(e => e.CallerMailingAddress).HasMaxLength(255);

                entity.Property(e => e.CallerName).HasMaxLength(255);

                entity.Property(e => e.CallerState).HasMaxLength(255);

                entity.Property(e => e.CallerZipCode).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.Claim).HasMaxLength(255);

                entity.Property(e => e.ClaimDate).HasColumnType("date");

                entity.Property(e => e.CloseDate).HasColumnType("date");

                entity.Property(e => e.ComplaintCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionReported).HasMaxLength(2000);

                entity.Property(e => e.ConditionReported1).HasMaxLength(2000);

                entity.Property(e => e.ConditionReported2).HasMaxLength(255);

                entity.Property(e => e.Contact).HasMaxLength(255);

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.CustomerItem).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DaysInService)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeniedCallDate).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Description1).HasMaxLength(1000);

                entity.Property(e => e.DestinationSite).HasMaxLength(255);

                entity.Property(e => e.Dtccode)
                    .HasColumnName("DTCCode")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FactoryCode).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FechaRegistroUp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FollowupDate).HasColumnType("date");

                entity.Property(e => e.InspectionManagerUser).HasMaxLength(255);

                entity.Property(e => e.InspectionReleaseDate).HasMaxLength(255);

                entity.Property(e => e.InspectionSite).HasMaxLength(255);

                entity.Property(e => e.InspectionStatus).HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemDescription).HasMaxLength(255);

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.MeterAmt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeterDate).HasColumnType("date");

                entity.Property(e => e.MilesInService)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Nfwtype)
                    .HasColumnName("NFWType")
                    .HasMaxLength(255);

                entity.Property(e => e.OpenCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName).HasMaxLength(255);

                entity.Property(e => e.OwnerSite).HasMaxLength(255);

                entity.Property(e => e.PData)
                    .HasColumnName("P_Data")
                    .HasMaxLength(255);

                entity.Property(e => e.PartReceivedDescription).HasMaxLength(1000);

                entity.Property(e => e.PartReplaced).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PriorIncident).HasMaxLength(255);

                entity.Property(e => e.PriorityCode).HasMaxLength(255);

                entity.Property(e => e.PriorityCodeDescription).HasMaxLength(255);

                entity.Property(e => e.Qty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SetStore)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo).HasMaxLength(50);

                entity.Property(e => e.Ssr)
                    .HasColumnName("SSR")
                    .HasMaxLength(255);

                entity.Property(e => e.Ssrname)
                    .HasColumnName("SSRName")
                    .HasMaxLength(255);

                entity.Property(e => e.Ssrsite)
                    .HasColumnName("SSRSite")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusCode).HasMaxLength(255);

                entity.Property(e => e.StatusCodeDescription).HasMaxLength(255);

                entity.Property(e => e.StreetAddress).HasMaxLength(255);

                entity.Property(e => e.TrackIt)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.TypePuchase).HasMaxLength(255);

                entity.Property(e => e.Um)
                    .HasColumnName("UM")
                    .HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);

                entity.Property(e => e.UnitDescription).HasMaxLength(255);

                entity.Property(e => e.VendorNotes).HasMaxLength(2000);

                entity.Property(e => e.WAtkcore)
                    .HasColumnName("wATKcore")
                    .HasMaxLength(255);

                entity.Property(e => e.WAtkno)
                    .HasColumnName("wATKno")
                    .HasMaxLength(255);

                entity.Property(e => e.WAuthorizedPartsRepaced)
                    .HasColumnName("wAuthorizedPartsRepaced")
                    .HasMaxLength(255);

                entity.Property(e => e.WBillNo)
                    .HasColumnName("wBillNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WBy)
                    .HasColumnName("wBy")
                    .HasMaxLength(255);

                entity.Property(e => e.WCarrier)
                    .HasColumnName("wCarrier")
                    .HasMaxLength(255);

                entity.Property(e => e.WCheckNo)
                    .HasColumnName("wCheckNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WChgTo)
                    .HasColumnName("wChgTo")
                    .HasMaxLength(255);

                entity.Property(e => e.WClaimDate)
                    .HasColumnName("wClaimDate")
                    .HasMaxLength(255);

                entity.Property(e => e.WClaimEstablishedBy)
                    .HasColumnName("wClaimEstablishedBy")
                    .HasMaxLength(255);

                entity.Property(e => e.WClientsClaimNo)
                    .HasColumnName("wClientsClaimNo")
                    .HasMaxLength(355);

                entity.Property(e => e.WCnct)
                    .HasColumnName("wCnct")
                    .HasMaxLength(255);

                entity.Property(e => e.WCondition)
                    .HasColumnName("wCondition")
                    .HasMaxLength(255);

                entity.Property(e => e.WCreatedBy)
                    .HasColumnName("wCreatedBy")
                    .HasMaxLength(255);

                entity.Property(e => e.WCustPd)
                    .HasColumnName("wCustPD")
                    .HasMaxLength(255);

                entity.Property(e => e.WCustomer)
                    .HasColumnName("wCustomer")
                    .HasMaxLength(255);

                entity.Property(e => e.WCustomerNo)
                    .HasColumnName("wCustomerNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateFail)
                    .HasColumnName("wDateFail")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateInst)
                    .HasColumnName("wDateInst")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateProc)
                    .HasColumnName("wDateProc")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateRecd)
                    .HasColumnName("wDateRecd")
                    .HasColumnType("date");

                entity.Property(e => e.WDays)
                    .HasColumnName("wDays")
                    .HasMaxLength(255);

                entity.Property(e => e.WDuplicateClaim)
                    .HasColumnName("wDuplicateClaim")
                    .HasMaxLength(255);

                entity.Property(e => e.WEngineNo)
                    .HasColumnName("wEngineNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WFailureCode)
                    .HasColumnName("wFailureCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WFax)
                    .HasColumnName("wFax")
                    .HasMaxLength(255);

                entity.Property(e => e.WFreightIn)
                    .HasColumnName("wFreightIn")
                    .HasMaxLength(255);

                entity.Property(e => e.WFrtin)
                    .HasColumnName("wFRTin")
                    .HasMaxLength(255);

                entity.Property(e => e.WFrtout)
                    .HasColumnName("wFRTout")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageAddress)
                    .HasColumnName("wGarageAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageCity)
                    .HasColumnName("wGarageCity")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageContactFirst)
                    .HasColumnName("wGarageContactFirst")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageFaxNo)
                    .HasColumnName("wGarageFaxNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageName)
                    .HasColumnName("wGarageName")
                    .HasMaxLength(255);

                entity.Property(e => e.WGaragePhone)
                    .HasColumnName("wGaragePhone")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageSt)
                    .HasColumnName("wGarageST")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageZip)
                    .HasColumnName("wGarageZip")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WGoodwillAmount)
                    .HasColumnName("wGoodwillAmount")
                    .HasMaxLength(255);

                entity.Property(e => e.WInspectionClaimNo)
                    .HasColumnName("wInspectionClaimNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WInspectionDate)
                    .HasColumnName("wInspectionDate")
                    .HasMaxLength(255);

                entity.Property(e => e.WInspector)
                    .HasColumnName("wInspector")
                    .HasMaxLength(255);

                entity.Property(e => e.WLab)
                    .HasColumnName("wLAB")
                    .HasMaxLength(255);

                entity.Property(e => e.WLabor)
                    .HasColumnName("wLabor")
                    .HasMaxLength(255);

                entity.Property(e => e.WLaborRate)
                    .HasColumnName("wLaborRate")
                    .HasMaxLength(255);

                entity.Property(e => e.WLaborTime)
                    .HasColumnName("wLaborTime")
                    .HasMaxLength(255);

                entity.Property(e => e.WLaimno)
                    .HasColumnName("wLAIMno")
                    .HasMaxLength(255);

                entity.Property(e => e.WMileFail)
                    .HasColumnName("wMileFail")
                    .HasMaxLength(255);

                entity.Property(e => e.WMileInst)
                    .HasColumnName("wMileInst")
                    .HasMaxLength(255);

                entity.Property(e => e.WModel)
                    .HasColumnName("wModel")
                    .HasMaxLength(255);

                entity.Property(e => e.WNetworkIsActive)
                    .HasColumnName("wNetworkIsActive")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WPaymentGoesTo)
                    .HasColumnName("wPaymentGoesTo")
                    .HasMaxLength(255);

                entity.Property(e => e.WReccomendEngine)
                    .HasColumnName("wReccomendEngine")
                    .HasMaxLength(255);

                entity.Property(e => e.WReplacementSent)
                    .HasColumnName("wReplacementSent")
                    .HasMaxLength(255);

                entity.Property(e => e.WReportedFailure)
                    .HasColumnName("wReportedFailure")
                    .HasMaxLength(2000);

                entity.Property(e => e.WSalesIsActive)
                    .HasColumnName("wSalesIsActive")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WSerialNo)
                    .HasColumnName("wSerialNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WShipInfoIsActive)
                    .HasColumnName("wShipInfoIsActive")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WShopLaborRate)
                    .HasColumnName("wShopLaborRate")
                    .HasMaxLength(255);

                entity.Property(e => e.WStarlightNo)
                    .HasColumnName("wStarlightNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreAddress)
                    .HasColumnName("wStoreAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreCity)
                    .HasColumnName("wStoreCity")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreName)
                    .HasColumnName("wStoreName")
                    .HasMaxLength(255);

                entity.Property(e => e.WStorePhone)
                    .HasColumnName("wStorePhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WStoreSt)
                    .HasColumnName("wStoreST")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreZip)
                    .HasColumnName("wStoreZip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WTime1)
                    .HasColumnName("wTime1")
                    .HasMaxLength(255);

                entity.Property(e => e.WTime2)
                    .HasColumnName("wTime2")
                    .HasMaxLength(255);

                entity.Property(e => e.WTotalPaid)
                    .HasColumnName("wTotalPaid")
                    .HasMaxLength(255);

                entity.Property(e => e.WTotalWGsa)
                    .HasColumnName("wTotalW_GSA")
                    .HasMaxLength(255);

                entity.Property(e => e.WTypeOfGoodwill)
                    .HasColumnName("wTypeOfGoodwill")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerAddress)
                    .HasColumnName("wVehicleOwnerAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerCellNo)
                    .HasColumnName("wVehicleOwnerCellNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerName)
                    .HasColumnName("wVehicleOwnerName")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerPhone)
                    .HasColumnName("wVehicleOwnerPhone")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerSt)
                    .HasColumnName("wVehicleOwnerST")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerZip)
                    .HasColumnName("wVehicleOwnerZip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WVenChg)
                    .HasColumnName("wVenChg")
                    .HasMaxLength(255);

                entity.Property(e => e.WVinNo)
                    .HasColumnName("wVinNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WWarrantyDays)
                    .HasColumnName("wWarrantyDays")
                    .HasMaxLength(255);

                entity.Property(e => e.WWarrantyMiles)
                    .HasColumnName("wWarrantyMiles")
                    .HasMaxLength(255);

                entity.Property(e => e.WarningDate).HasColumnType("date");

                entity.Property(e => e.WarrantyAdministratorApprovalStatus).HasMaxLength(255);

                entity.Property(e => e.WarrantyInspectionApprovalDate).HasColumnType("date");

                entity.Property(e => e.Wdcode)
                    .HasColumnName("WDCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityWarrantiesDailyInspection>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Quality_Guarantees_DailyInspection_resp");

                entity.ToTable("Quality_Warranties_DailyInspection");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Administrator).HasMaxLength(255);

                entity.Property(e => e.ApprovalStatus).HasMaxLength(255);

                entity.Property(e => e.ApprovalStatus1)
                    .HasColumnName("ApprovalStatus_1")
                    .HasMaxLength(255);

                entity.Property(e => e.CallerAddress).HasMaxLength(255);

                entity.Property(e => e.CallerCity).HasMaxLength(255);

                entity.Property(e => e.CallerMailingAddress).HasMaxLength(255);

                entity.Property(e => e.CallerName).HasMaxLength(255);

                entity.Property(e => e.CallerState).HasMaxLength(255);

                entity.Property(e => e.CallerZipCode).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.Claim).HasMaxLength(255);

                entity.Property(e => e.ClaimDate).HasColumnType("date");

                entity.Property(e => e.CloseDate).HasColumnType("date");

                entity.Property(e => e.Contact).HasMaxLength(255);

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.CustomerItem).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DestinationSite).HasMaxLength(255);

                entity.Property(e => e.Dtccode)
                    .HasColumnName("DTCCode")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FactoryCode).HasMaxLength(255);

                entity.Property(e => e.FamilyCode).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FechaRegistroLoad)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FollowupDate).HasColumnType("date");

                entity.Property(e => e.InspectionManagerUser).HasMaxLength(255);

                entity.Property(e => e.InspectionReleaseDate).HasColumnType("date");

                entity.Property(e => e.InspectionSite).HasMaxLength(255);

                entity.Property(e => e.InspectionStatus).HasMaxLength(255);

                entity.Property(e => e.Item).HasMaxLength(255);

                entity.Property(e => e.ItemDescription).HasMaxLength(255);

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.MeterDate).HasColumnType("date");

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.NoSerial).HasMaxLength(255);

                entity.Property(e => e.NonSlserial)
                    .HasColumnName("NonSLSerial#")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroReplacementSerial).HasMaxLength(255);

                entity.Property(e => e.NumeroTrackIt)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroWinvoice).HasColumnName("NumeroWInvoice");

                entity.Property(e => e.OwnerName)
                    .HasColumnName("Owner_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.OwnerSite).HasMaxLength(255);

                entity.Property(e => e.PartReceivedDescription).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PriorIncident).HasMaxLength(255);

                entity.Property(e => e.PriorityCode).HasMaxLength(255);

                entity.Property(e => e.PriorityCodeDescription).HasMaxLength(255);

                entity.Property(e => e.ProductionDate).HasColumnType("date");

                entity.Property(e => e.Serial).HasMaxLength(255);

                entity.Property(e => e.SerialNumberReceived).HasMaxLength(255);

                entity.Property(e => e.ShipTo).HasMaxLength(50);

                entity.Property(e => e.Ssr)
                    .HasColumnName("SSR")
                    .HasMaxLength(255);

                entity.Property(e => e.SsrSite)
                    .HasColumnName("SSR_Site")
                    .HasMaxLength(255);

                entity.Property(e => e.Ssrname)
                    .HasColumnName("SSRName")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusCode).HasMaxLength(255);

                entity.Property(e => e.StatusCodeDescription).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.Um)
                    .HasColumnName("UM")
                    .HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);

                entity.Property(e => e.UnitDescription).HasMaxLength(255);

                entity.Property(e => e.WAtkno)
                    .HasColumnName("wATKno")
                    .HasMaxLength(255);

                entity.Property(e => e.WAuthorizedPartsRepaced)
                    .HasColumnName("wAuthorizedPartsRepaced")
                    .HasMaxLength(255);

                entity.Property(e => e.WBillNo)
                    .HasColumnName("wBillNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WBy)
                    .HasColumnName("wBy")
                    .HasMaxLength(255);

                entity.Property(e => e.WCarrier)
                    .HasColumnName("wCarrier")
                    .HasMaxLength(255);

                entity.Property(e => e.WCheckNo)
                    .HasColumnName("wCheckNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WChgTo)
                    .HasColumnName("wChgTo")
                    .HasMaxLength(255);

                entity.Property(e => e.WClaimDate)
                    .HasColumnName("wClaimDate")
                    .HasMaxLength(255);

                entity.Property(e => e.WClaimEstablishedBy)
                    .HasColumnName("wClaimEstablishedBy")
                    .HasMaxLength(255);

                entity.Property(e => e.WClientsClaimNo)
                    .HasColumnName("wClientsClaimNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WCnct)
                    .HasColumnName("wCnct")
                    .HasMaxLength(255);

                entity.Property(e => e.WCondition)
                    .HasColumnName("wCondition")
                    .HasMaxLength(255);

                entity.Property(e => e.WConditionReported)
                    .HasColumnName("wConditionReported")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.WCreatedBy)
                    .HasColumnName("wCreatedBy")
                    .HasMaxLength(255);

                entity.Property(e => e.WCustPd)
                    .HasColumnName("wCustPD")
                    .HasMaxLength(255);

                entity.Property(e => e.WCustomer)
                    .HasColumnName("wCustomer")
                    .HasMaxLength(255);

                entity.Property(e => e.WCustomerNo)
                    .HasColumnName("wCustomerNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateFail)
                    .HasColumnName("wDateFail")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateInst)
                    .HasColumnName("wDateInst")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateProc)
                    .HasColumnName("wDateProc")
                    .HasMaxLength(255);

                entity.Property(e => e.WDateRecd)
                    .HasColumnName("wDateRecd")
                    .HasColumnType("date");

                entity.Property(e => e.WDays)
                    .HasColumnName("wDays")
                    .HasMaxLength(255);

                entity.Property(e => e.WEngineNo)
                    .HasColumnName("wEngineNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WFailureCode)
                    .HasColumnName("wFailureCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WFax)
                    .HasColumnName("wFax")
                    .HasMaxLength(255);

                entity.Property(e => e.WFreightIn)
                    .HasColumnName("wFreightIn")
                    .HasMaxLength(255);

                entity.Property(e => e.WFrtin)
                    .HasColumnName("wFRTin")
                    .HasMaxLength(255);

                entity.Property(e => e.WFrtout)
                    .HasColumnName("wFRTout")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageAddress)
                    .HasColumnName("wGarageAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageCity)
                    .HasColumnName("wGarageCity")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageContactFirst)
                    .HasColumnName("wGarageContactFirst")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageFaxNo)
                    .HasColumnName("wGarageFaxNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageName)
                    .HasColumnName("wGarageName")
                    .HasMaxLength(255);

                entity.Property(e => e.WGaragePhone)
                    .HasColumnName("wGaragePhone")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageSt)
                    .HasColumnName("wGarageST")
                    .HasMaxLength(255);

                entity.Property(e => e.WGarageZip)
                    .HasColumnName("wGarageZip")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WGoodwillAmount)
                    .HasColumnName("wGoodwillAmount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WInspectionClaimNo)
                    .HasColumnName("wInspectionClaimNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WInspectionDate)
                    .HasColumnName("wInspectionDate")
                    .HasMaxLength(255);

                entity.Property(e => e.WInspector)
                    .HasColumnName("wInspector")
                    .HasMaxLength(255);

                entity.Property(e => e.WLab)
                    .HasColumnName("wLAB")
                    .HasMaxLength(255);

                entity.Property(e => e.WLabor)
                    .HasColumnName("wLabor")
                    .HasMaxLength(255);

                entity.Property(e => e.WLaborRate)
                    .HasColumnName("wLaborRate")
                    .HasMaxLength(255);

                entity.Property(e => e.WLaborTime)
                    .HasColumnName("wLaborTime")
                    .HasMaxLength(255);

                entity.Property(e => e.WLaimno)
                    .HasColumnName("wLAIMno")
                    .HasMaxLength(255);

                entity.Property(e => e.WManual)
                    .HasColumnName("wManual")
                    .HasMaxLength(255);

                entity.Property(e => e.WMileFail)
                    .HasColumnName("wMileFail")
                    .HasMaxLength(255);

                entity.Property(e => e.WMileInst)
                    .HasColumnName("wMileInst")
                    .HasMaxLength(255);

                entity.Property(e => e.WModel)
                    .HasColumnName("wModel")
                    .HasMaxLength(255);

                entity.Property(e => e.WNetworkIsActive).HasColumnName("wNetworkIsActive");

                entity.Property(e => e.WPartNo)
                    .HasColumnName("wPartNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WPaymentGoesTo)
                    .HasColumnName("wPaymentGoesTo")
                    .HasMaxLength(255);

                entity.Property(e => e.WReccomendEngine)
                    .HasColumnName("wReccomendEngine")
                    .HasMaxLength(255);

                entity.Property(e => e.WReportedFailure)
                    .HasColumnName("wReportedFailure")
                    .HasMaxLength(255);

                entity.Property(e => e.WSalesIsActive).HasColumnName("wSalesIsActive");

                entity.Property(e => e.WSerialNo).HasColumnName("wSerialNo");

                entity.Property(e => e.WShipInfoIsActive).HasColumnName("wShipInfoIsActive");

                entity.Property(e => e.WShopLaborRate)
                    .HasColumnName("wShopLaborRate")
                    .HasMaxLength(255);

                entity.Property(e => e.WStarlightNo)
                    .HasColumnName("wStarlightNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreAddress)
                    .HasColumnName("wStoreAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreCity)
                    .HasColumnName("wStoreCity")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreName)
                    .HasColumnName("wStoreName")
                    .HasMaxLength(255);

                entity.Property(e => e.WStorePhone)
                    .HasColumnName("wStorePhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WStoreSt)
                    .HasColumnName("wStoreST")
                    .HasMaxLength(255);

                entity.Property(e => e.WStoreZip)
                    .HasColumnName("wStoreZip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WSuggestedRepair)
                    .HasColumnName("wSuggestedRepair")
                    .HasMaxLength(2000)
                    .IsFixedLength();

                entity.Property(e => e.WTime1)
                    .HasColumnName("wTime1")
                    .HasMaxLength(255);

                entity.Property(e => e.WTime2)
                    .HasColumnName("wTime2")
                    .HasMaxLength(255);

                entity.Property(e => e.WTotalPaid)
                    .HasColumnName("wTotalPaid")
                    .HasMaxLength(255);

                entity.Property(e => e.WTotalWgsa)
                    .HasColumnName("wTotalWGSA")
                    .HasMaxLength(255);

                entity.Property(e => e.WTypeOfGoodwill)
                    .HasColumnName("wTypeOfGoodwill")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerAddress)
                    .HasColumnName("wVehicleOwnerAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerCellNo)
                    .HasColumnName("wVehicleOwnerCellNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerName)
                    .HasColumnName("wVehicleOwnerName")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerPhone)
                    .HasColumnName("wVehicleOwnerPhone")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerSt)
                    .HasColumnName("wVehicleOwnerST")
                    .HasMaxLength(255);

                entity.Property(e => e.WVehicleOwnerZip)
                    .HasColumnName("wVehicleOwnerZip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WVenChg)
                    .HasColumnName("wVenChg")
                    .HasMaxLength(255);

                entity.Property(e => e.WVinNo)
                    .HasColumnName("wVinNo")
                    .HasMaxLength(255);

                entity.Property(e => e.WVipamount)
                    .HasColumnName("wVIPamount")
                    .HasMaxLength(255);

                entity.Property(e => e.WWarrantyDays)
                    .HasColumnName("wWarrantyDays")
                    .HasMaxLength(255);

                entity.Property(e => e.WWarrantyMiles)
                    .HasColumnName("wWarrantyMiles")
                    .HasMaxLength(255);

                entity.Property(e => e.WarningDate).HasColumnType("date");

                entity.Property(e => e.WarrantyAdministratorApprovalStatus).HasMaxLength(255);

                entity.Property(e => e.WarrantyInspectionApprovalDate).HasColumnType("date");

                entity.Property(e => e.Wdcode).HasColumnName("WDCode");
            });

            modelBuilder.Entity<QualityWarrantiesUploadLog>(entity =>
            {
                entity.HasKey(e => e.RegistroId)
                    .HasName("PK_Quality_Guarantees_UploadLog");

                entity.ToTable("Quality_Warranties_UploadLog");

                entity.Property(e => e.RegistroId).HasColumnName("RegistroID");

                entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UltimoDato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<QualityWorkstations>(entity =>
            {
                entity.HasKey(e => e.IdWorkstation);

                entity.ToTable("Quality_Workstations");

                entity.Property(e => e.IdWorkstation).HasColumnName("ID_Workstation");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PrimaryMax).HasColumnName("Primary_max");

                entity.Property(e => e.PrimaryMin).HasColumnName("Primary_min");

                entity.Property(e => e.Workstation)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QualityWorkstationsLinkToCodesStations>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Quality_Workstations_LinkToCodesStations");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("WorkstationID");
            });

            modelBuilder.Entity<ServicesNowPlanners>(entity =>
            {
                entity.HasKey(e => e.IdPlanner);

                entity.ToTable("Services_now_Planners");

                entity.Property(e => e.IdPlanner).HasColumnName("ID_Planner");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPlanner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowProjects>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK_Services_ProjectMagnament");

                entity.ToTable("Services_now_Projects");

                entity.Property(e => e.IdProyecto).HasColumnName("ID_Proyecto");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.DescripcionProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel).HasDefaultValueSql("((1))");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.PlannerId).HasColumnName("PlannerID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowWorkOrders>(entity =>
            {
                entity.HasKey(e => e.IdWorkOrder)
                    .HasName("PK_Maintenance_WorkOrders");

                entity.ToTable("Services_now_WorkOrders");

                entity.Property(e => e.IdWorkOrder).HasColumnName("ID_WorkOrder");

                entity.Property(e => e.ClaseId).HasColumnName("ClaseID");

                entity.Property(e => e.ComentarioApertura)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioAsignacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioServicio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosCancelacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosCierre)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId).HasColumnName("EstacionID");

                entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDownTime).HasColumnType("datetime");

                entity.Property(e => e.FechaEstimadaServicio).HasColumnType("datetime");

                entity.Property(e => e.FechaProgramada).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistroCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroServicio).HasColumnType("datetime");

                entity.Property(e => e.HoraEstimadaServicio)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaquinaId).HasColumnName("MaquinaID");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoSeccionId).HasColumnName("TipoSeccionID");

                entity.Property(e => e.TipoTrabajoId).HasColumnName("TipoTrabajoID");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioCancelacionId).HasColumnName("UsuarioCancelacionID");

                entity.Property(e => e.UsuarioRegistroCierreId).HasColumnName("UsuarioRegistroCierreID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioRegistroServicioId).HasColumnName("UsuarioRegistroServicioID");

                entity.Property(e => e.UsuarioSupervisorId).HasColumnName("UsuarioSupervisorID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersClass>(entity =>
            {
                entity.HasKey(e => e.IdClase)
                    .HasName("PK_Maintenance_WorkOrders_Class");

                entity.ToTable("Services_now_WorkOrders_Class");

                entity.Property(e => e.IdClase).HasColumnName("ID_Clase");

                entity.Property(e => e.Clase)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TabSectionId).HasColumnName("TabSectionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersClassHistory>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Services_now_WorkOrders_ClassHistory");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.ClaseAnteriorId).HasColumnName("ClaseAnteriorID");

                entity.Property(e => e.ClaseNuevaId).HasColumnName("ClaseNuevaID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersComments>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Services_now_WorkOrders_Comments");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tipo).HasComment("1.-Tecnico,2.-Usuario,3.-Supervisor");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkorderId).HasColumnName("WorkorderID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersCtrlTabSections>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("Services_now_WorkOrders_CtrlTabSections");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Onclick)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tab)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersCtrlTabSectionsLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Services_now_WorkOrders_CtrlTabSectionsLinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersJobTime>(entity =>
            {
                entity.HasKey(e => e.IdTurnoProduccion);

                entity.ToTable("Services_now_WorkOrders_JobTime");

                entity.Property(e => e.IdTurnoProduccion).HasColumnName("ID_TurnoProduccion");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Trabaja).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersPrivileges>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Maintenance_WorkOrders_Privileges");

                entity.ToTable("Services_now_WorkOrders_Privileges");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TabSeccionId).HasColumnName("TabSeccionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersRejects>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Maintenance_WorkOrders_Rejects");

                entity.ToTable("Services_now_WorkOrders_Rejects");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioCargadoId).HasColumnName("UsuarioCargadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersReviews>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_Maintenance_WorkOrders_Reviews");

                entity.ToTable("Services_now_WorkOrders_Reviews");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiberado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Opcion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersServiceRatingResults>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Services_now_WorkOrders_ServiceRatingResults");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoEvaluacionId).HasColumnName("TipoEvaluacionID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersServiceRatingTypes>(entity =>
            {
                entity.HasKey(e => e.IdEvaluacion)
                    .HasName("PK_Maintenance_WorkOrders_ServiceRating");

                entity.ToTable("Services_now_WorkOrders_ServiceRatingTypes");

                entity.Property(e => e.IdEvaluacion).HasColumnName("ID_Evaluacion");

                entity.Property(e => e.DescripcionEvaluacion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersTabSections>(entity =>
            {
                entity.HasKey(e => e.IdSeccion)
                    .HasName("PK_Services_now_WorkOrdersTypes");

                entity.ToTable("Services_now_WorkOrders_TabSections");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Onclick)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tab)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersTabSectionsLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Services_now_WorkOrders_TabSectionsLinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<ServicesNowWorkOrdersTypes>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK_Maintenance_WorkOrders_Types");

                entity.ToTable("Services_now_WorkOrders_Types");

                entity.Property(e => e.IdTipo).HasColumnName("ID_Tipo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoOrdenTrabajo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<SoftwareConfigAdministrators>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_Administrators");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nivel).HasDefaultValueSql("((1))");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigApps>(entity =>
            {
                entity.HasKey(e => e.IdAplicacion);

                entity.ToTable("SoftwareConfig_Apps");

                entity.Property(e => e.IdAplicacion).HasColumnName("ID_Aplicacion");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SoftwareConfigAppsV2>(entity =>
            {
                entity.HasKey(e => e.IdAplicacion);

                entity.ToTable("SoftwareConfig_Apps_v2");

                entity.Property(e => e.IdAplicacion).HasColumnName("ID_Aplicacion");

                entity.Property(e => e.Actualizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CarpetaSite)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionUrl)
                    .HasColumnName("DireccionURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.SoftwareConfigAppsV2)
                    .HasForeignKey(d => d.DepartamentoId)
                    .HasConstraintName("FK_SoftwareConfig_Apps_v2__Departments");
            });

            modelBuilder.Entity<SoftwareConfigControllersActionMethods>(entity =>
            {
                entity.HasKey(e => e.IdPagina);

                entity.ToTable("SoftwareConfig_Controllers_ActionMethods");

                entity.Property(e => e.IdPagina).HasColumnName("ID_Pagina");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareConfigDocsMultiplantLinkedUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SoftwareConfig_DocsMultiplant_LinkedUsers");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigFtpCredencials>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK__Software__8EC639F2A14D56F1");

                entity.ToTable("SoftwareConfig_FtpCredencials");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FtpDireccion).HasMaxLength(250);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Usuario).HasMaxLength(250);
            });

            modelBuilder.Entity<SoftwareConfigMainMenu>(entity =>
            {
                entity.HasKey(e => e.IdMenuSeccion)
                    .HasName("PK_SoftwareConfig_Tasks");

                entity.ToTable("SoftwareConfig_MainMenu");

                entity.Property(e => e.IdMenuSeccion).HasColumnName("ID_MenuSeccion");

                entity.Property(e => e.ActionMethod).HasMaxLength(250);

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("(N'ff4c4c')");

                entity.Property(e => e.ColorActivo)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("(N'ff4c4c')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileSystem)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InMenu).HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuIconos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuSeccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel).HasDefaultValueSql("((1))");

                entity.Property(e => e.QueryTabla)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TemporalId)
                    .HasColumnName("TemporalID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<SoftwareConfigMainMenuLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK_SoftwareConfig_MainMenu_LinkUsers");

                entity.ToTable("SoftwareConfig_MainMenu_LinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.MenuSeccionId).HasColumnName("MenuSeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigMainMenuTemporaryApprover>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_MainMenu_Temporary_Approver");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuSeccionId).HasColumnName("MenuSeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");

                entity.Property(e => e.UsuarioTemporalId).HasColumnName("UsuarioTemporalID");
            });

            modelBuilder.Entity<SoftwareConfigMainMenuTemporaryLog>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_MainMenu_Temporary_Log");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaCambio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

                entity.Property(e => e.MenuSeccionId).HasColumnName("MenuSeccionID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioOrigenId).HasColumnName("UsuarioOrigenID");

                entity.Property(e => e.UsuiarioTemporalId).HasColumnName("UsuiarioTemporalID");
            });

            modelBuilder.Entity<SoftwareConfigMainMenuUserPrivileges>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_MainMenu_UserPrivileges");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuSeccionId).HasColumnName("MenuSeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<SoftwareConfigPages>(entity =>
            {
                entity.HasKey(e => e.IdPagina);

                entity.ToTable("SoftwareConfig_Pages");

                entity.Property(e => e.IdPagina).HasColumnName("ID_Pagina");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pagina')");

                entity.Property(e => e.TituloPagina)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Seccion)
                    .WithMany(p => p.SoftwareConfigPages)
                    .HasForeignKey(d => d.SeccionId)
                    .HasConstraintName("FK_SoftwareConfig_Pages__SoftwareConfig_Sections");
            });

            modelBuilder.Entity<SoftwareConfigPagesDetails>(entity =>
            {
                entity.HasKey(e => e.IdPagina);

                entity.ToTable("SoftwareConfig_Pages_Details");

                entity.Property(e => e.IdPagina).HasColumnName("ID_Pagina");

                entity.Property(e => e.AplicacionId).HasColumnName("AplicacionID");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InMenu).HasDefaultValueSql("((1))");

                entity.Property(e => e.PadreId).HasColumnName("PadreID");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.SubSeccionId).HasColumnName("SubSeccionID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareConfigPagesUserHistory>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK__Software__8EC639F20A770A70");

                entity.ToTable("SoftwareConfig_Pages_User_History");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PageAction).HasMaxLength(100);

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigPagesV2>(entity =>
            {
                entity.HasKey(e => e.IdPagina);

                entity.ToTable("SoftwareConfig_Pages_v2");

                entity.Property(e => e.IdPagina).HasColumnName("ID_Pagina");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionUrl)
                    .HasColumnName("DireccionURL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubSeccionId).HasColumnName("SubSeccionID");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPagina)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareConfigSections>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("SoftwareConfig_Sections");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.AplicacionId).HasColumnName("AplicacionID");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Original)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Aplicacion)
                    .WithMany(p => p.SoftwareConfigSections)
                    .HasForeignKey(d => d.AplicacionId)
                    .HasConstraintName("FK_SoftwareConfig_Sections__SoftwareConfig_Apps");
            });

            modelBuilder.Entity<SoftwareConfigSectionsLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_Sections_LinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Seccion)
                    .WithMany(p => p.SoftwareConfigSectionsLinkedUsers)
                    .HasForeignKey(d => d.SeccionId)
                    .HasConstraintName("FK_SoftwareConfig_Sections_LinkedUsers__SoftwareConfig_Sections");
            });

            modelBuilder.Entity<SoftwareConfigSectionsLinkedUsersV2>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_Sections_LinkedUsers_v2");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSectionsLinkedUsersV2History>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_Sections_LinkedUsers_v2_History");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSectionsLinkedUsersV2Resp25052022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SoftwareConfig_Sections_LinkedUsers_v2_resp25052022");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSectionsUserHistory>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_Sections_User_History");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSectionsV2>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("SoftwareConfig_Sections_v2");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.AplicacionId).HasColumnName("AplicacionID");

                entity.Property(e => e.CarpetaSite)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NewDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.QualityWorkStationId).HasColumnName("QualityWorkStationID");

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareConfigServiceNowActionMethods>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK__Software__8EC639F2F0D6FEA2");

                entity.ToTable("SoftwareConfig_ServiceNow_ActionMethods");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuServiceId).HasColumnName("MenuServiceID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareConfigServicesMenu>(entity =>
            {
                entity.HasKey(e => e.IdMenuService);

                entity.ToTable("SoftwareConfig_ServicesMenu");

                entity.Property(e => e.IdMenuService).HasColumnName("ID_MenuService");

                entity.Property(e => e.ActionMethod).HasMaxLength(100);

                entity.Property(e => e.Colors)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileSystem)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FontColor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Icono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InMenu)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuIconos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MenuSeccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QueryTabla)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<SoftwareConfigServicesMenuLinkedUsers>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_ServicesMenu_LinkedUsers");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.MenuServiceId).HasColumnName("MenuServiceID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigServicesMenuUserPrivileges>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_ServicesMenu_UserPrivileges");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuSeccionId).HasColumnName("MenuSeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<SoftwareConfigSubSectionsLinkedUsersV2>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_SubSections_LinkedUsers_v2");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubSeccionId).HasColumnName("SubSeccionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSubSectionsLinkedUsersV2History>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_SubSections_LinkedUsers_v2_History");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.SubSeccionId).HasColumnName("SubSeccionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSubSectionsLinkedUsersV2Resp25052022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SoftwareConfig_SubSections_LinkedUsers_v2_resp25052022");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("ID_Registro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubSeccionId).HasColumnName("SubSeccionID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<SoftwareConfigSubSectionsV2>(entity =>
            {
                entity.HasKey(e => e.IdSubSeccion);

                entity.ToTable("SoftwareConfig_SubSections_v2");

                entity.Property(e => e.IdSubSeccion).HasColumnName("ID_SubSeccion");

                entity.Property(e => e.CarpetaSite)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NewDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubSeccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareConfigUsersSharedTasks>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("SoftwareConfig_Users_Shared_Tasks");

                entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuSeccionId).HasColumnName("MenuSeccionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioAsignadoId).HasColumnName("UsuarioAsignadoID");

                entity.Property(e => e.UsuarioRegistroId).HasColumnName("UsuarioRegistroID");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado).HasColumnName("ID_Estado");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId).HasColumnName("PaisID");
            });

            modelBuilder.Entity<Towns>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio);

                entity.Property(e => e.IdMunicipio).HasColumnName("ID_Municipio");

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Auditivo).HasColumnType("date");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('restringido')");

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.DepartamentoProduccionId).HasColumnName("DepartamentoProduccionID");

                entity.Property(e => e.Empleado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Evaluacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaLiberacionEntrenamiento).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GerenciaId).HasColumnName("GerenciaID");

                entity.Property(e => e.Idioma)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('spanish')");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('blank.png')");

                entity.Property(e => e.Imss)
                    .HasColumnName("IMSS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KronosId)
                    .HasColumnName("KronosID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.PaginaInicio)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaginaInicioDepartamento)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-------')");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Apmqj8LK3w/oFGPjslWzm9oeXa4i7Igju8eZnKqWdiY=')");

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.PreguntaSecreta)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----')");

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.PuestoId)
                    .HasColumnName("PuestoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RespuestaSecreta)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----')");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('wFN/dzSy/PVHk0Vo1SzwcQ==')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.TipoEvaluacionId).HasColumnName("TipoEvaluacionID");

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.UnidadNegocioId)
                    .HasColumnName("UnidadNegocioID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioBajaId).HasColumnName("UsuarioBajaID");

                entity.Property(e => e.Visual).HasColumnType("date");
            });

            modelBuilder.Entity<UsersImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Users_Import");

                entity.Property(e => e.FechaLiberacionEntrenamiento).HasColumnType("date");

                entity.Property(e => e.NoEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersJobs>(entity =>
            {
                entity.HasKey(e => e.IdPuestoTrabajo);

                entity.ToTable("Users_Jobs");

                entity.Property(e => e.IdPuestoTrabajo).HasColumnName("ID_PuestoTrabajo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("PlantaID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UsersValidationSession>(entity =>
            {
                entity.HasKey(e => e.ValIdValidacion);

                entity.ToTable("Users_ValidationSession");

                entity.Property(e => e.ValIdValidacion).HasColumnName("Val_Id_Validacion");

                entity.Property(e => e.FechaCierreSesion).HasColumnType("datetime");

                entity.Property(e => e.FechaReg)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idsesion)
                    .IsRequired()
                    .HasColumnName("IDSesion")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SessionTipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<UsersValidationSessionOut>(entity =>
            {
                entity.HasKey(e => e.RegistroValidationId);

                entity.ToTable("Users_ValidationSession_Out");

                entity.Property(e => e.RegistroValidationId).HasColumnName("RegistroValidationID");

                entity.Property(e => e.FechaReg)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionTipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<VwMenus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMenus");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.IconoMenu)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.PaginaPrincipal)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
