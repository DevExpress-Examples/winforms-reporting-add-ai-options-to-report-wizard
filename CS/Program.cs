using System.ClientModel;
using System.ClientModel.Primitives;
using System.Net.Http;
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
        static string DeploymentName { get { return "gpt-4o-mini"; } }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            //IChatClient client = new AzureOpenAIClient(
            //new Uri(AzureOpenAIEndpoint),
            //new ApiKeyCredential(AzureOpenAIKey))
            //    .GetChatClient(DeploymentName).AsIChatClient();
            //AIExtensionsContainerDesktop.Default.RegisterChatClient(client);

            //AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(AzureOpenAIEndpointUri, AzureOpenAIKeyCredentials, new AzureOpenAIClientOptions() {
            //    Transport = new PromoteHttpStatusErrorsPipelineTransport()
            //});
            //IChatClient chatClient = azureOpenAIClient.GetChatClient("GPT4o").AsIChatClient();
            ////
            //var container = AIExtensionsContainerDesktop.Default;
            //container.RegisterChatClient(chatClient);

            //container.RegisterAIExceptionHandler(new AIExceptionHandler());


            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.TrackWindowsAppMode = DevExpress.Utils.DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            Application.Run(new CustomXRDesignRibbonForm());
        }

        //static string AzureOpenAIEndpoint {
        //    get {
        //        string azureOpenAIEndpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode);
        //        if(string.IsNullOrEmpty(azureOpenAIEndpoint))
        //            azureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai";//DevExpress proxy-server
        //        return azureOpenAIEndpoint;
        //    }
        //}
        //static Uri AzureOpenAIEndpointUri {
        //    get {

        //        return new Uri(AzureOpenAIEndpoint);
        //    }
        //}
        //static string AzureOpenAIKey {
        //    get {
        //        string azureOpenAIKey = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode);
        //        if(string.IsNullOrEmpty(azureOpenAIKey))
        //            azureOpenAIKey = "DEMO";//Demo key
        //        return azureOpenAIKey;
        //    }
        //}
        //static System.ClientModel.ApiKeyCredential AzureOpenAIKeyCredentials {
        //    get {
        //        return new System.ClientModel.ApiKeyCredential(AzureOpenAIKey);
        //    }
        //}
        //static bool IsDeveloperMode {
        //    get {
        //        return string.Equals(AssemblyInfo.Version, $"{AssemblyInfo.VersionShort}.0.0", StringComparison.InvariantCultureIgnoreCase);
        //    }
        //}
        //static string GetEnvironmentVariable(string variableName, bool allowSetNewEnvironmentVariable = false) {
        //    string environmentVariable = SafeEnvironment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User);
        //    if(string.IsNullOrEmpty(environmentVariable) && allowSetNewEnvironmentVariable) {
        //        environmentVariable = XtraInputBox.Show($"Please enter {variableName} variable.", variableName, string.Empty);
        //        if(string.IsNullOrEmpty(environmentVariable))
        //            Application.Exit();
        //        SafeEnvironment.SetEnvironmentVariable(variableName, environmentVariable, EnvironmentVariableTarget.User);
        //    }
        //    return environmentVariable;
        //}

        //#region inner classes
        //class PromoteHttpStatusErrorsPipelineTransport : HttpClientPipelineTransport {
        //    protected override void OnReceivedResponse(PipelineMessage message, HttpResponseMessage httpResponse) {
        //        if(!httpResponse.IsSuccessStatusCode) {
        //            if((int)httpResponse.StatusCode == 429)
        //                throw new AIDemoException("You have reached demo request limit. Further requests are temporarily suspended. Please try again in a few minutes. Thank you for your patience and understanding.");
        //            throw new HttpRequestException("HTTP request failed with status code: " + httpResponse.StatusCode);
        //        }
        //        base.OnReceivedResponse(message, httpResponse);
        //    }
        //}
        //public class AIExceptionHandler : IAIExceptionHandler {
        //    public void ProcessException(AIExceptionArgs args) {
        //        if(!(args.Exception is AIDemoException))
        //            args.Exception = new Exception("Something went wrong.", args.Exception);
        //    }
        //}
        ////
        //public class AIDemoException : Exception {
        //    public AIDemoException(string message) : base(message) {
        //    }
        //}
        //#endregion
    }
}