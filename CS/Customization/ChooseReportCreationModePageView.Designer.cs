using DevExpress.AIIntegration.WinForms.Reporting.Wizard.Views;

namespace AIWizardCustomizationExample.Customization {
    partial class ChooseReportCreationModePageView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIChooseReportTypePageView));
            this.reportTypeGallery = new DevExpress.DataAccess.UI.Native.WizardGallery();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).BeginInit();
            this.layoutControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemFinishButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSeparatorTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemPreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseContent)).BeginInit();
            this.panelBaseContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBaseContentPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemAdditionalButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditionalButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlBase
            // 
            this.layoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(664, 142, 749, 739);
            this.layoutControlBase.Controls.SetChildIndex(this.panelAdditionalButtons, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.buttonPrevious, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.separatorTop, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.buttonFinish, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.buttonNext, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.panelBaseContent, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.labelHeader, 0);
            // 
            // panelBaseContent
            // 
            this.panelBaseContent.Controls.Add(this.reportTypeGallery);
            // 
            // reportTypeGallery
            // 
            resources.ApplyResources(this.reportTypeGallery, "reportTypeGallery");
            this.reportTypeGallery.Name = "reportTypeGallery";
            this.reportTypeGallery.ItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnItemCheckedChanged);
            this.reportTypeGallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.OnItemDoubleClick);
            // 
            // AIChooseReportTypePageView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "S";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).EndInit();
            this.layoutControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemFinishButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSeparatorTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemPreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseContent)).EndInit();
            this.panelBaseContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBaseContentPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemAdditionalButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditionalButtons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected DevExpress.DataAccess.UI.Native.WizardGallery reportTypeGallery;
    }
}
