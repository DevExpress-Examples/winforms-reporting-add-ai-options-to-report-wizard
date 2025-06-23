using System.ComponentModel.Design;
using DevExpress.AIIntegration.Reporting;
using DevExpress.AIIntegration.Reporting.Wizard;
using DevExpress.AIIntegration.Reporting.Wizard.Presenters;
using DevExpress.AIIntegration.Reporting.Wizard.Views;
using DevExpress.AIIntegration.WinForms;
using DevExpress.AIIntegration.WinForms.Reporting;
using DevExpress.AIIntegration.WinForms.Reporting.Wizard;
using DevExpress.AIIntegration.WinForms.Reporting.Wizard.Views;
using DevExpress.Data.Utils;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;

namespace AIWizardCustomizationExample.Customization {
    internal class WizardCustomizationService : IWizardCustomizationService {
        public void CustomizeReportWizard(IWizardCustomization<XtraReportModel> tool) {
            tool.StartPage = typeof(ChooseReportCreationModePage<XtraReportModel>);
            tool.RegisterPage<ChooseReportCreationModePage<XtraReportModel>, ChooseReportCreationModePage<XtraReportModel>>();
            tool.RegisterPageView<IChooseReportCreationModePageView, ChooseReportCreationModePageView>();
            tool.RegisterPage<AIChooseDataSourceOptionPage<XtraReportModel>, AIChooseDataSourceOptionPage<XtraReportModel>>();
            tool.RegisterPageView<IAIChooseDataSourceOptionPageView, AIChooseDataSourceOptionPageView>();
            tool.RegisterPage<AINoDataEnterReportPromptPage<XtraReportModel>, AINoDataEnterReportPromptPage<XtraReportModel>>();
            tool.RegisterPageView<IAINoDataEnterReportPromptPageView, AINoDataEnterReportPromptPageView>();
            tool.RegisterPage<AIDataBoundEnterReportPromptPage<XtraReportModel>, AIDataBoundEnterReportPromptPage<XtraReportModel>>();
            tool.RegisterPageView<IAIDataBoundEnterReportPromptPageView, AIDataBoundEnterReportPromptPageView>();
            tool.Model.SetAIParameters(new AIParameters());
            tool.Model.SetPredefinedAIReportPrompts(AIReportPromptCollection.GetDefaultReportPrompts());
        }

        public void CustomizeDataSourceWizard(IWizardCustomization<XtraReportModel> tool) { }

        public bool TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }

        public bool TryCreateReport(IDesignerHost designerHost, XtraReportModel model, object dataSource, string dataMember) {
            if(model.GetIsAIReportType()) {
                DoWithOverlay(designerHost, () => {
                    var builder = new AIReportBuilder(designerHost, dataSource, dataMember);
                    builder.Build((XtraReport)designerHost.RootComponent, model);
                });
                return true;
            }
            return false;
        }

        void DoWithOverlay(IDesignerHost designerHost, Action action) {
            Control control = designerHost.GetService<ReportTabControlBase>();
            using(var waitForm = new AIOverlayForm()) {
                waitForm.ShowLoading(control);
                try {
                    action();
                    waitForm.Close();
                } catch(Exception ex) {
                    waitForm.ShowError(control, ex.Message, false);
                }
            }
        }
    }
}
