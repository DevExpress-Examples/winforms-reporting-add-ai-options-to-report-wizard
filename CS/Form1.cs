using AIWizardCustomizationExample.Customization;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.Wizards;

namespace AIWizardCustomizationExample {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
            reportDesigner1.AddService<IWizardCustomizationService>(new WizardCustomizationService());
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        private void button1_Click(object sender, EventArgs e) {
            reportDesigner1.CreateNewReportWizard();
        }
    }
}
