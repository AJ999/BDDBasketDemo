﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDBasketDemo
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Shopping Basket")]
    public partial class ShoppingBasketFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ShoppingBasket.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Shopping Basket", "A simple shopping basket that we can add and remove items from", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A new basket no contents")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ANewBasketNoContents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new basket no contents", new string[] {
                        "mytag"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.When("I create a new basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("The basket has no contents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding an item to the basket")]
        public virtual void AddingAnItemToTheBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding an item to the basket", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
testRunner.Given("I create a new basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
testRunner.When("I add an item to the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
testRunner.Then("the basket contains the added item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Removing a item from the basket")]
        public virtual void RemovingAItemFromTheBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Removing a item from the basket", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
testRunner.Given("I create a new basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
testRunner.And("I add an item to the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.When("I remove an item from the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
testRunner.Then("the basket does not contain the item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
