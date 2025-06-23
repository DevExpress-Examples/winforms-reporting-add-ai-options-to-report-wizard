namespace AIWizardCustomizationExample.Customization {
    public interface IChooseReportCreationModePageView {
        ReportCreationMode CreationMode { get; set; }
        event EventHandler CreationModeChanged;
    }
}