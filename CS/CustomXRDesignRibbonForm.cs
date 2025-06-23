using AIWizardCustomizationExample.Customization;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.Wizards;

namespace AIWizardCustomizationExample {
    public class CustomXRDesignRibbonForm : XRDesignRibbonForm {
        public CustomXRDesignRibbonForm() {
            DesignMdiController.AddService(typeof(IWizardCustomizationService), new WizardCustomizationService());
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            DesignMdiController.CreateNewReportWizard();
        }
    }
}
