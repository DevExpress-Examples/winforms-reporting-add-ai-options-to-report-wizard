Imports System.ComponentModel.Design
Imports DevExpress.AIIntegration.Reporting
Imports DevExpress.AIIntegration.Reporting.Wizard
Imports DevExpress.AIIntegration.Reporting.Wizard.Presenters
Imports DevExpress.AIIntegration.Reporting.Wizard.Views
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.AIIntegration.WinForms.Reporting
Imports DevExpress.AIIntegration.WinForms.Reporting.Wizard
Imports DevExpress.AIIntegration.WinForms.Reporting.Wizard.Views
Imports DevExpress.Data.Utils
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Wizards

Namespace AIWizardCustomizationExample.Customization

	Friend Class WizardCustomizationService
		Implements IWizardCustomizationService
		Public Sub CustomizeReportWizard(ByVal tool As IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeReportWizard
			tool.StartPage = GetType(ChooseReportCreationModePage(Of XtraReportModel))
			tool.RegisterPage(Of ChooseReportCreationModePage(Of XtraReportModel), ChooseReportCreationModePage(Of XtraReportModel))()
			tool.RegisterPageView(Of IChooseReportCreationModePageView, ChooseReportCreationModePageView)()
			tool.RegisterPage(Of AIChooseDataSourceOptionPage(Of XtraReportModel), AIChooseDataSourceOptionPage(Of XtraReportModel))()
			tool.RegisterPageView(Of IAIChooseDataSourceOptionPageView, AIChooseDataSourceOptionPageView)()
			tool.RegisterPage(Of AINoDataEnterReportPromptPage(Of XtraReportModel), AINoDataEnterReportPromptPage(Of XtraReportModel))()
			tool.RegisterPageView(Of IAINoDataEnterReportPromptPageView, AINoDataEnterReportPromptPageView)()
			tool.RegisterPage(Of AIDataBoundEnterReportPromptPage(Of XtraReportModel), AIDataBoundEnterReportPromptPage(Of XtraReportModel))()
			tool.RegisterPageView(Of IAIDataBoundEnterReportPromptPageView, AIDataBoundEnterReportPromptPageView)()
			tool.Model.SetAIParameters(New AIParameters())
			tool.Model.SetPredefinedAIReportPrompts(AIReportPromptCollection.GetDefaultReportPrompts())
		End Sub

		Public Sub CustomizeDataSourceWizard(ByVal tool As IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeDataSourceWizard
		End Sub

		Public Function TryCreateDataSource(ByVal model As IDataSourceModel, <System.Runtime.InteropServices.Out()> ByRef dataSource As Object, <System.Runtime.InteropServices.Out()> ByRef dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateDataSource
			dataSource = Nothing
			dataMember = Nothing
			Return False
		End Function

		Public Function TryCreateReport(ByVal designerHost As IDesignerHost, ByVal model As XtraReportModel, ByVal dataSource As Object, ByVal dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateReport
			If model.GetIsAIReportType() Then
				DoWithOverlay(designerHost, Sub()
												Dim builder = New AIReportBuilder(designerHost, dataSource, dataMember)
												builder.Build(CType(designerHost.RootComponent, XtraReport), model)
											End Sub)
				Return True
			End If
			Return False
		End Function
		Private Sub DoWithOverlay(ByVal designerHost As IDesignerHost, ByVal action As Action)
			Dim control As System.Windows.Forms.Control = designerHost.GetService(Of ReportTabControlBase)()

			Using waitForm = New AIOverlayForm()
				waitForm.ShowLoading(control)

				Try
					action()
					waitForm.Close()
				Catch ex As Exception
					waitForm.ShowError(control, ex.Message, False)
				End Try
			End Using
		End Sub
	End Class
End Namespace
