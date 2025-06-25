Imports DevExpress.AIIntegration.Reporting.Wizard.Presenters
Imports DevExpress.Data.WizardFramework
Imports DevExpress.XtraReports.Wizards
Imports DevExpress.XtraReports.Wizards.Presenters

Namespace AIWizardCustomizationExample.Customization

    Public Class ChooseReportCreationModePage(Of TModel As XtraReportModel)
        Inherits WizardPageBase(Of IChooseReportCreationModePageView, TModel)

        Public Sub New(ByVal view As IChooseReportCreationModePageView)
            MyBase.New(view)
        End Sub

        Public Overrides ReadOnly Property MoveNextEnabled As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property FinishEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides Sub Begin()
            View.CreationMode = If(Model.GetIsAIReportType(), ReportCreationMode.AI, ReportCreationMode.Standard)
            Me.View.CreationModeChanged += AddressOf OnCreationModeChanged
        End Sub

        Public Overrides Sub Commit()
            Me.View.CreationModeChanged -= AddressOf OnCreationModeChanged
            Model.SetIsAIReportType(View.CreationMode = ReportCreationMode.AI)
        End Sub

        Public Overrides Function GetNextPageType() As Type
            Return If(View.CreationMode = ReportCreationMode.Standard, GetType(ChooseReportTypePage(Of XtraReportModel)), GetType(AIChooseDataSourceOptionPage(Of XtraReportModel)))
        End Function

        Private Sub OnCreationModeChanged(ByVal sender As Object?, ByVal e As EventArgs)
            RaiseChanged()
        End Sub
    End Class
End Namespace
