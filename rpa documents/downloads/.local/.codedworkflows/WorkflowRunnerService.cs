using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Downloads;

[assembly: WorkflowRunnerServiceAttribute(typeof(Downloads.WorkflowRunnerService))]
namespace Downloads
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the WebExtraction/WebExtraction/Main.xaml
        /// </summary>
        public void WebExtraction_WebExtraction_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WebExtraction\WebExtraction\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the OlympicsManager - start/GetOlympicsInformation.xaml
        /// </summary>
        public (string outOlympicsName, string outNations, string outOpeningDate, string outClosingDate) GetOlympicsInformation(string inOlympicsYear)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"OlympicsManager - start\GetOlympicsInformation.xaml", new Dictionary<string, object>{{"inOlympicsYear", inOlympicsYear}}, default, default, default, GetAssemblyName());
            return ((string)result["outOlympicsName"], (string)result["outNations"], (string)result["outOpeningDate"], (string)result["outClosingDate"]);
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Tests_InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/new.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_new()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\new.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the BitmapExample/BitmapExample/Main.xaml
        /// </summary>
        public void BitmapExample_BitmapExample_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"BitmapExample\BitmapExample\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SuggestMedicine 2/SuggestMedicine/test.xaml
        /// </summary>
        public void test()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SuggestMedicine 2\SuggestMedicine\test.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Tests_WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Tests_InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/Process.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_Process(string in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the ChatBot 2/ChatBot/Main.xaml
        /// </summary>
        public void ChatBot_2_ChatBot_Main(string BreakTriggerScopeInArgument)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ChatBot 2\ChatBot\Main.xaml", new Dictionary<string, object>{{"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WebExtraction 4/WebExtraction/Main.xaml
        /// </summary>
        public void WebExtraction_4_WebExtraction_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WebExtraction 4\WebExtraction\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the OlympicsManager - start/GetMedals.xaml
        /// </summary>
        public System.Data.DataTable GetMedals(string inYear)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"OlympicsManager - start\GetMedals.xaml", new Dictionary<string, object>{{"inYear", inYear}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["outMedalsTable"];
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Tests/ProcessTestCase.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Tests_ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/KillAllProcesses.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/Process.xaml
        /// </summary>
        public void Process(string in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ChatBot 2/ChatBot/CsvToExcel.xaml
        /// </summary>
        public (string Warnings, string Indications, string Contraindications, string Precautions, string AdverseEffects, string Overdose, string Dosage, string HandlingInstructions, string Storage, string Pharmacology, string status, string DrugInteractions) CsvToExcel(string input)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ChatBot 2\ChatBot\CsvToExcel.xaml", new Dictionary<string, object>{{"input", input}}, default, default, default, GetAssemblyName());
            return ((string)result["Warnings"], (string)result["Indications"], (string)result["Contraindications"], (string)result["Precautions"], (string)result["AdverseEffects"], (string)result["Overdose"], (string)result["Dosage"], (string)result["HandlingInstructions"], (string)result["Storage"], (string)result["Pharmacology"], (string)result["status"], (string)result["DrugInteractions"]);
        }

        /// <summary>
        /// Invokes the WebExtraction 4/WebExtraction/demo.xaml
        /// </summary>
        public void demo()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WebExtraction 4\WebExtraction\demo.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the newamazon/newamazon/Main.xaml
        /// </summary>
        public void newamazon_newamazon_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"newamazon\newamazon\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/TakeScreenshot.xaml
        /// </summary>
        public string Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Sequence.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Sequence()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Sequence.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the ChatBot 2/ChatBot/Sequence.xaml
        /// </summary>
        public System.Data.DataTable Sequence()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ChatBot 2\ChatBot\Sequence.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["discontinued"];
        }

        /// <summary>
        /// Invokes the OlympicsManager - start/Main.xaml
        /// </summary>
        public void OlympicsManager___start_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"OlympicsManager - start\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/GetTransactionData.xaml
        /// </summary>
        public (string out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, string io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, string io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((string)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (string)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the ChatBot 2/ChatBot/SimilarString.xaml
        /// </summary>
        public object SimilarString(string input)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ChatBot 2\ChatBot\SimilarString.xaml", new Dictionary<string, object>{{"input", input}}, default, default, default, GetAssemblyName());
            return (object)result["result"];
        }

        /// <summary>
        /// Invokes the OlympicsManager - start/ShowMedals.xaml
        /// </summary>
        public void ShowMedals(System.Data.DataTable inMedalsTable, string inOlympicsName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"OlympicsManager - start\ShowMedals.xaml", new Dictionary<string, object>{{"inMedalsTable", inMedalsTable}, {"inOlympicsName", inOlympicsName}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Tests/MainTestCase.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Tests_MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/CloseAllApplications.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ChatBot 2/ChatBot/scraping.xaml
        /// </summary>
        public void scraping()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ChatBot 2\ChatBot\scraping.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WebExtraction 4/WebExtraction/documentunderstanding.xaml
        /// </summary>
        public void documentunderstanding()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WebExtraction 4\WebExtraction\documentunderstanding.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the newamazon 2/newamazon/Main.xaml
        /// </summary>
        public void newamazon_2_newamazon_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"newamazon 2\newamazon\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Tests_GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/GetTransactionData.xaml
        /// </summary>
        public (string out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, string io_dt_TransactionData) Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, string io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((string)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (string)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Main.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Main.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ChatBot 2/ChatBot/DrugSimilar.xaml
        /// </summary>
        public void DrugSimilar()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ChatBot 2\ChatBot\DrugSimilar.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SuggestMedicine 2/SuggestMedicine/Main.xaml
        /// </summary>
        public (string why, string precaution, string sideEffect, string storageDisposal, string howToUse, string otherUses, string emergency, string dietryInstructions, string otherInfo, string forgotDose, string brandNames, string status) SuggestMedicine_2_SuggestMedicine_Main(string input)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SuggestMedicine 2\SuggestMedicine\Main.xaml", new Dictionary<string, object>{{"input", input}}, default, default, default, GetAssemblyName());
            return ((string)result["why"], (string)result["precaution"], (string)result["sideEffect"], (string)result["storageDisposal"], (string)result["howToUse"], (string)result["otherUses"], (string)result["emergency"], (string)result["dietryInstructions"], (string)result["otherInfo"], (string)result["forgotDose"], (string)result["brandNames"], (string)result["status"]);
        }

        /// <summary>
        /// Invokes the newamazon/newamazon/TestCase.xaml
        /// </summary>
        public void TestCase(string SerialNo, string Employee_Id, string ReportingDay, string ReportingShift, string SiteReference, string Routing_Code, string Operation, string QAD_Good_PartCount)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"newamazon\newamazon\TestCase.xaml", new Dictionary<string, object>{{"SerialNo", SerialNo}, {"Employee_Id", Employee_Id}, {"ReportingDay", ReportingDay}, {"ReportingShift", ReportingShift}, {"SiteReference", SiteReference}, {"Routing_Code", Routing_Code}, {"Operation", Operation}, {"QAD_Good_PartCount", QAD_Good_PartCount}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/process/Get Image Path.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_process_Get_Image_Path()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\process\Get Image Path.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification_BhartiDubey/Face Identification/Framework/InitAllApplications.xaml
        /// </summary>
        public void Face_Identification_Face_Identification_BhartiDubey_Face_Identification_Framework_InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification_BhartiDubey\Face Identification\Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/process/Get Image Path.xaml
        /// </summary>
        public void Get_Image_Path()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\process\Get Image Path.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Face Identification/Face Identification/new.xaml
        /// </summary>
        public void new()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Face Identification\Face Identification\new.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}