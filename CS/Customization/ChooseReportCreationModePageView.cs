using System.ComponentModel;
using DevExpress.AIIntegration.Reporting.Wizard;
using DevExpress.AIIntegration.WinForms.Reporting.Wizard.Images;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.Design;

namespace AIWizardCustomizationExample.Customization {
    public partial class ChooseReportCreationModePageView : WizardViewBase, IChooseReportCreationModePageView {
        public override string HeaderDescription => "Choose Standard or AI-generated report type.";
        
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ReportCreationMode CreationMode {
            get { return (ReportCreationMode)reportTypeGallery.GetValue(ReportCreationMode.Standard); }
            set { reportTypeGallery.SetValue(value); }
        }

        public event EventHandler CreationModeChanged;

        public ChooseReportCreationModePageView() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            reportTypeGallery.ClearGallery();
            reportTypeGallery.InitializeGallery(list => AddReportItems(list));
            reportTypeGallery.SetSkinStyle(LookAndFeel.ActiveSkinName);
        }

        protected void AddItem(IList<GalleryItem> list, string text, SvgImage svgImage, object tag) {
            list.Add(reportTypeGallery.CreateItem(text, svgImage, tag));
        }

        protected virtual void AddReportItems(IList<GalleryItem> list) {
            AddItem(list, "Standard Report", SvgImageLocator.GetWizardImage("StandardReport"), ReportCreationMode.Standard);
            AddItem(list, "AI-generated Report", AIWizardImages.IconReportAI, ReportCreationMode.AI);
        }

        void OnItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            if(!e.Item.Checked)
                return;
            CreationModeChanged?.Invoke(this, EventArgs.Empty);
        }

        void OnItemDoubleClick(object sender, GalleryItemClickEventArgs e) {
            MoveForward();
        }
    }
}
