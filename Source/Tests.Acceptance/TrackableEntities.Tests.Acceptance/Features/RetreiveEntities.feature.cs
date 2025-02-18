﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TrackableEntities.Tests.Acceptance.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RetreiveEntitiesFeature : Xunit.IUseFixture<RetreiveEntitiesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RetreiveEntities.feature"
#line hidden
        
        public RetreiveEntitiesFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Retreive Entities", "In order to retrieve entities\r\nAs a Web API client\r\nI want to retrieve entities f" +
                    "rom the database", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(RetreiveEntitiesFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Retreive Entities")]
        [Xunit.TraitAttribute("Description", "Retreive Customers")]
        public virtual void RetreiveCustomers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retreive Customers", new string[] {
                        "retrieve_entities"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "CustomerId",
                        "CustomerName"});
            table1.AddRow(new string[] {
                        "ABCD",
                        "Test Customer ABCD"});
            table1.AddRow(new string[] {
                        "EFGH",
                        "Test Customer EFGH"});
#line 8
 testRunner.Given("the following customers", ((string)(null)), table1, "Given ");
#line 12
 testRunner.When("I submit a GET request for customers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the request should return the customers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Retreive Entities")]
        [Xunit.TraitAttribute("Description", "Retreive Customer Orders")]
        public virtual void RetreiveCustomerOrders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retreive Customer Orders", new string[] {
                        "retrieve_entities"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "CustomerId",
                        "CustomerName"});
            table2.AddRow(new string[] {
                        "ABCD",
                        "Test Customer ABCD"});
#line 17
 testRunner.Given("the following customers", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "CustomerId"});
            table3.AddRow(new string[] {
                        "ABCD"});
#line 20
 testRunner.And("the following customer orders", ((string)(null)), table3, "And ");
#line 23
 testRunner.When("I submit a GET request for customer orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("the request should return the orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Retreive Entities")]
        [Xunit.TraitAttribute("Description", "Retreive Order")]
        public virtual void RetreiveOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retreive Order", new string[] {
                        "retrieve_entities"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "CustomerId",
                        "CustomerName"});
            table4.AddRow(new string[] {
                        "ABCD",
                        "Test Customer ABCD"});
#line 28
 testRunner.Given("the following customers", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "CustomerId"});
            table5.AddRow(new string[] {
                        "ABCD"});
#line 31
 testRunner.And("the following customer orders", ((string)(null)), table5, "And ");
#line 34
 testRunner.When("I submit a GET request for an order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("the request should return the orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RetreiveEntitiesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RetreiveEntitiesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
