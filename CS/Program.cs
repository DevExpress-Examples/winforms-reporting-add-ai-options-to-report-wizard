using System.ClientModel;
using System.ClientModel.Primitives;
using System.Net.Http;
using Azure;
using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.Data.Utils;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Microsoft.Extensions.AI;

namespace AIWizardCustomizationExample {
    internal static class Program {
        static string AzureOpenAIEndpoint { get { return "AZURE_OPENAI_ENDPOINT"; } }
        static string AzureOpenAIKey { get { return "AZURE_OPENAI_APIKEY"; } }
        static string DeploymentName { get { return "gpt-5.2"; } }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.TrackWindowsAppMode = DevExpress.Utils.DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);

            AzureOpenAIClient client = new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint), new AzureKeyCredential(AzureOpenAIKey));
            var chatClient = client.GetChatClient(DeploymentName).AsIChatClient();
            AIExtensionsContainerDesktop.Default.RegisterChatClient(chatClient);

            Application.Run(new CustomXRDesignRibbonForm());
            
        }
    }
}