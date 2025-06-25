Imports AIWizardCustomizationExample.AIWizardCustomizationExample.Customization
Imports AIWizardCustomizationExample.Customization
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraReports.Wizards

Namespace AIWizardCustomizationExample

    Public Class CustomXRDesignRibbonForm
        Inherits XRDesignRibbonForm

        Public Sub New()
            DesignMdiController.AddService(GetType(DevExpress.XtraReports.Wizards.IWizardCustomizationService), New WizardCustomizationService())
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            DesignMdiController.CreateNewReportWizard()
        End Sub
    End Class
End Namespace
