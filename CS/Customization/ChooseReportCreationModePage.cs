using DevExpress.AIIntegration.Reporting.Wizard.Presenters;
using DevExpress.Data.WizardFramework;
using DevExpress.XtraReports.Wizards;
using DevExpress.XtraReports.Wizards.Presenters;

namespace AIWizardCustomizationExample.Customization {
    public class ChooseReportCreationModePage<TModel> : WizardPageBase<IChooseReportCreationModePageView, TModel> where TModel: XtraReportModel {
        public ChooseReportCreationModePage(IChooseReportCreationModePageView view) : base(view) { }

        public override bool MoveNextEnabled => true;
        public override bool FinishEnabled => false;

        public override void Begin() {
            View.CreationMode = Model.GetIsAIReportType() ? ReportCreationMode.AI : ReportCreationMode.Standard;
            View.CreationModeChanged += OnCreationModeChanged;
        }

        public override void Commit() {
            View.CreationModeChanged-= OnCreationModeChanged;
            Model.SetIsAIReportType(View.CreationMode == ReportCreationMode.AI);
        }

        public override Type GetNextPageType() {
            return View.CreationMode == ReportCreationMode.Standard
                ? typeof(ChooseReportTypePage<XtraReportModel>)
                : typeof(AIChooseDataSourceOptionPage<XtraReportModel>);
        }

        void OnCreationModeChanged(object? sender, EventArgs e) => RaiseChanged();
    }
}
