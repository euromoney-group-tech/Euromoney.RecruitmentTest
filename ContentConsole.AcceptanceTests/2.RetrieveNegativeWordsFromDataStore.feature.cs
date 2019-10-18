// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ContentConsole.AcceptanceTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Retrieve negative words from data store")]
    public partial class RetrieveNegativeWordsFromDataStoreFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "2.RetrieveNegativeWordsFromDataStore.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Retrieve negative words from data store", "\tAs an administrator\r\n\tI want to be able to change the set of negative words coun" +
                    "ted\r\n\tSo that I don\'t need to change the code when we select new negative words " +
                    "or phrases", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Detect negative words")]
        [NUnit.Framework.TestCaseAttribute("The weather in Manchester in winter is bad. It must be horrible for people visiti" +
            "ng.", "bad,horrible,swine", "2", null)]
        [NUnit.Framework.TestCaseAttribute("The weather in Manchester in winter is bad. It must be horrible for people visiti" +
            "ng.", "annoying,swine", "0", null)]
        public virtual void DetectNegativeWords(string content, string bannedWords, string expectedNumber, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Detect negative words", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("{0} is supplied", content), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("a set of predefined negative words that include \'{0}\'", bannedWords), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("the content is analysed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("the number of negative words should be {0}", expectedNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("provide the analysed phrase as its output", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
