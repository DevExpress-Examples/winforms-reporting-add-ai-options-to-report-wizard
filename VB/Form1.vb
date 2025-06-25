Imports AIWizardCustomizationExample.Customization
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.Wizards

Namespace AIWizardCustomizationExample

    Public Partial Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            reportDesigner1.AddService(Of IWizardCustomizationService)(New WizardCustomizationService())
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            reportDesigner1.CreateNewReportWizard()
        End Sub
    End Class
End Namespace
