﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class IntrospectFeature : object, Xunit.IClassFixture<IntrospectFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Introspect.feature"
#line hidden
        
        public IntrospectFeature(IntrospectFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Introspect", "\tCheck result returned during the token introspection", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="IsActive is false when the token doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "Introspect")]
        [Xunit.TraitAttribute("Description", "IsActive is false when the token doesn\'t exist")]
        public void IsActiveIsFalseWhenTheTokenDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("IsActive is false when the token doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table295 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table295.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table295.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table295.AddRow(new string[] {
                            "token",
                            "token"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token_info\'", ((string)(null)), table295, "When ");
#line hidden
#line 11
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.And("JSON \'$.active\'=\'false\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="IsActive is false when the token is expired")]
        [Xunit.TraitAttribute("FeatureTitle", "Introspect")]
        [Xunit.TraitAttribute("Description", "IsActive is false when the token is expired")]
        public void IsActiveIsFalseWhenTheTokenIsExpired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("IsActive is false when the token is expired", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table296 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table296.AddRow(new string[] {
                            "client_id",
                            "thirteenClient"});
                table296.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table296.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table296.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 17
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table296, "When ");
#line hidden
#line 24
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("extract parameter \'$.access_token\' from JSON body into \'accessToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table297 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table297.AddRow(new string[] {
                            "client_id",
                            "thirteenClient"});
                table297.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table297.AddRow(new string[] {
                            "token",
                            "$accessToken$"});
#line 27
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token_info\'", ((string)(null)), table297, "And ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("JSON \'$.active\'=\'false\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="IsActive is true when the token is introspected")]
        [Xunit.TraitAttribute("FeatureTitle", "Introspect")]
        [Xunit.TraitAttribute("Description", "IsActive is true when the token is introspected")]
        public void IsActiveIsTrueWhenTheTokenIsIntrospected()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("IsActive is true when the token is introspected", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table298 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table298.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table298.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table298.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table298.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 39
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table298, "When ");
#line hidden
#line 46
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("extract parameter \'$.access_token\' from JSON body into \'accessToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table299 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table299.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table299.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table299.AddRow(new string[] {
                            "token",
                            "$accessToken$"});
#line 49
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token_info\'", ((string)(null)), table299, "And ");
#line hidden
#line 55
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.And("JSON \'$.active\'=\'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("JSON \'$.client_id\'=\'firstClient\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("JSON \'$.scope\'=\'firstScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("JSON \'$.iss\'=\'https://localhost:8080\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                IntrospectFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                IntrospectFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
