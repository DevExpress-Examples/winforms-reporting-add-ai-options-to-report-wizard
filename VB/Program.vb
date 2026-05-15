Imports System.Windows.Forms
Imports Azure
Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Microsoft.Extensions.AI

Namespace AIWizardCustomizationExample

    Friend Module Program

        Private ReadOnly Property AzureOpenAIEndpoint As String
            Get
                Return "AZURE_OPENAI_ENDPOINT"
            End Get
        End Property

        Private ReadOnly Property AzureOpenAIKey As String
            Get
                Return "AZURE_OPENAI_APIKEY"
            End Get
        End Property

        Private ReadOnly Property DeploymentName As String
            Get
                Return "MODEL_NAME"
            End Get
        End Property

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            WindowsFormsSettings.SetDPIAware()
            WindowsFormsSettings.TrackWindowsAppMode = DevExpress.Utils.DefaultBoolean.[True]
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI)
            Dim client As New AzureOpenAIClient(
            New Uri(AzureOpenAIEndpoint),
            New AzureKeyCredential(AzureOpenAIKey)
            )
            Dim chatClient = client.GetChatClient(DeploymentName).AsIChatClient()

            AIExtensionsContainerDesktop.Default.RegisterChatClient(chatClient)
            Call Application.Run(New CustomXRDesignRibbonForm())
        End Sub
    End Module
End Namespace
