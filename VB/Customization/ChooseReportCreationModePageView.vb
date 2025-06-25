Imports System.ComponentModel
Imports DevExpress.AIIntegration.WinForms.Reporting.Wizard.Images
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraReports.Design

Namespace AIWizardCustomizationExample.Customization

    Public Partial Class ChooseReportCreationModePageView
        Inherits WizardViewBase
        Implements IChooseReportCreationModePageView

        Public Overrides ReadOnly Property HeaderDescription As String
            Get
                Return "Choose Standard or AI-generated report type."
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property CreationMode As ReportCreationMode Implements IChooseReportCreationModePageView.CreationMode
            Get
                Return CType(reportTypeGallery.GetValue(ReportCreationMode.Standard), ReportCreationMode)
            End Get

            Set(ByVal value As ReportCreationMode)
                reportTypeGallery.SetValue(value)
            End Set
        End Property

        Public Event CreationModeChanged As EventHandler Implements IChooseReportCreationModePageView.CreationModeChanged

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            reportTypeGallery.ClearGallery()
            reportTypeGallery.InitializeGallery(Function(list) AddReportItems(list))
            reportTypeGallery.SetSkinStyle(LookAndFeel.ActiveSkinName)
        End Sub

        Protected Sub AddItem(ByVal list As IList(Of GalleryItem), ByVal text As String, ByVal svgImage As SvgImage, ByVal tag As Object)
            list.Add(reportTypeGallery.CreateItem(text, svgImage, tag))
        End Sub

        Protected Overridable Sub AddReportItems(ByVal list As IList(Of GalleryItem))
            AddItem(list, "Standard Report", SvgImageLocator.GetWizardImage("StandardReport"), ReportCreationMode.Standard)
            AddItem(list, "AI-generated Report", AIWizardImages.IconReportAI, ReportCreationMode.AI)
        End Sub

        Private Sub OnItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            If Not e.Item.Checked Then Return
            RaiseEvent CreationModeChangedEvent(Me, EventArgs.Empty)
        End Sub

        Private Sub OnItemDoubleClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            MoveForward()
        End Sub
    End Class
End Namespace
