Imports DevExpress.AIIntegration.WinForms.Reporting.Wizard.Views
Imports DevExpress.CodeParser

Namespace AIWizardCustomizationExample.Customization

    Partial Class ChooseReportCreationModePageView

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.AIIntegration.WinForms.Reporting.Wizard.Views.AIChooseReportTypePageView))
            Me.reportTypeGallery = New DevExpress.DataAccess.UI.Native.WizardGallery()
            CType((Me.layoutControlBase), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControlBase.SuspendLayout()
            CType((Me.layoutGroupBase), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutItemFinishButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutItemNextButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutItemHeaderLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutItemSeparatorTop), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutItemPreviousButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelBaseContent), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelBaseContent.SuspendLayout()
            CType((Me.layoutItemBaseContentPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutItemAdditionalButtons), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelAdditionalButtons), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControlBase
            ' 
            Me.layoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(664, 142, 749, 739)
            Me.layoutControlBase.Controls.SetChildIndex(Me.panelAdditionalButtons, 0)
            Me.layoutControlBase.Controls.SetChildIndex(Me.buttonPrevious, 0)
            Me.layoutControlBase.Controls.SetChildIndex(Me.separatorTop, 0)
            Me.layoutControlBase.Controls.SetChildIndex(Me.buttonFinish, 0)
            Me.layoutControlBase.Controls.SetChildIndex(Me.buttonNext, 0)
            Me.layoutControlBase.Controls.SetChildIndex(Me.panelBaseContent, 0)
            Me.layoutControlBase.Controls.SetChildIndex(Me.labelHeader, 0)
            ' 
            ' panelBaseContent
            ' 
            Me.panelBaseContent.Controls.Add(Me.reportTypeGallery)
            ' 
            ' reportTypeGallery
            ' 
            resources.ApplyResources(Me.reportTypeGallery, "reportTypeGallery")
            Me.reportTypeGallery.Name = "reportTypeGallery"
            AddHandler Me.reportTypeGallery.ItemCheckedChanged, New DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(AddressOf Me.OnItemCheckedChanged)
            AddHandler Me.reportTypeGallery.ItemDoubleClick, New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(AddressOf Me.OnItemDoubleClick)
            ' 
            ' AIChooseReportTypePageView
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "S"
            CType((Me.layoutControlBase), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControlBase.ResumeLayout(False)
            CType((Me.layoutGroupBase), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutItemFinishButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutItemNextButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutItemHeaderLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutItemSeparatorTop), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutItemPreviousButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelBaseContent), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelBaseContent.ResumeLayout(False)
            CType((Me.layoutItemBaseContentPanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutItemAdditionalButtons), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelAdditionalButtons), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Protected reportTypeGallery As DevExpress.DataAccess.UI.Native.WizardGallery
    End Class
End Namespace
