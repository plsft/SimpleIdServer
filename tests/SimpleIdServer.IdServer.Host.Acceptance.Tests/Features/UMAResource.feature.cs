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
    public partial class UMAResourceFeature : object, Xunit.IClassFixture<UMAResourceFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAResource.feature"
#line hidden
        
        public UMAResourceFeature(UMAResourceFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAResource", "\tCheck the endpoint /rreguri\t", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="add UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "add UMA resource")]
        public void AddUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("add UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table518 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table518.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table518.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table518.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table518.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table518, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table519 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table519.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table519.AddRow(new string[] {
                            "subject",
                            "user1"});
                table519.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table519.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table519.AddRow(new string[] {
                            "name#en",
                            "name"});
                table519.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table519.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table519.AddRow(new string[] {
                            "type",
                            "type"});
                table519.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table519, "And ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.And("JSON exists \'_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("JSON exists \'user_access_policy_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="get UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "get UMA resource")]
        public void GetUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table520 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table520.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table520.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table520.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table520.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 34
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table520, "When ");
#line hidden
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table521 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table521.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table521.AddRow(new string[] {
                            "subject",
                            "user1"});
                table521.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table521.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table521.AddRow(new string[] {
                            "name#en",
                            "name"});
                table521.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table521.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table521.AddRow(new string[] {
                            "type",
                            "type"});
                table521.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 44
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table521, "And ");
#line hidden
#line 56
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table522 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table522.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 59
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table522, "And ");
#line hidden
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.And("JSON exists \'resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("JSON \'icon_uri\'=\'icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("JSON \'name#fr\'=\'nom\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("JSON \'name#en\'=\'name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("JSON \'description#fr\'=\'descriptionFR\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("JSON \'description#en\'=\'descriptionEN\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("JSON \'type\'=\'type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="delete UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "delete UMA resource")]
        public void DeleteUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 74
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table523 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table523.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table523.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table523.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table523.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 75
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table523, "When ");
#line hidden
#line 82
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table524 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table524.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table524.AddRow(new string[] {
                            "subject",
                            "user1"});
                table524.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table524.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table524.AddRow(new string[] {
                            "name#en",
                            "name"});
                table524.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table524.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table524.AddRow(new string[] {
                            "type",
                            "type"});
                table524.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 85
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table524, "And ");
#line hidden
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table525 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table525.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 100
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table525, "And ");
#line hidden
#line 104
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="add UMA permissions")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "add UMA permissions")]
        public void AddUMAPermissions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("add UMA permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 106
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table526 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table526.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table526.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table526.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table526.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 107
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table526, "When ");
#line hidden
#line 114
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table527 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table527.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table527.AddRow(new string[] {
                            "subject",
                            "user1"});
                table527.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table527.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table527.AddRow(new string[] {
                            "name#en",
                            "name"});
                table527.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table527.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table527.AddRow(new string[] {
                            "type",
                            "type"});
                table527.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 117
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table527, "And ");
#line hidden
#line 129
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table528 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table528.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table528.AddRow(new string[] {
                            "permissions",
                            "[ { \"claims\": [ { \"name\": \"sub\", \"value\": \"user\" } ], \"scopes\": [ \"scope\" ] } ]"});
#line 132
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/$_id$/permissions\'", ((string)(null)), table528, "And ");
#line hidden
#line 137
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.And("JSON exists \'_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="delete UMA permissions")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "delete UMA permissions")]
        public void DeleteUMAPermissions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete UMA permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 142
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table529 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table529.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table529.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table529.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table529.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 143
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table529, "When ");
#line hidden
#line 150
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table530 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table530.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table530.AddRow(new string[] {
                            "subject",
                            "user1"});
                table530.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table530.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table530.AddRow(new string[] {
                            "name#en",
                            "name"});
                table530.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table530.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table530.AddRow(new string[] {
                            "type",
                            "type"});
                table530.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 153
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table530, "And ");
#line hidden
#line 165
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 166
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table531 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table531.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table531.AddRow(new string[] {
                            "permissions",
                            "[ { \"claims\": [ { \"name\": \"sub\", \"value\": \"user\" } ], \"scopes\": [ \"scope\" ] } ]"});
#line 168
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri/$_id$/permissions\'", ((string)(null)), table531, "And ");
#line hidden
                TechTalk.SpecFlow.Table table532 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table532.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 173
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table532, "And ");
#line hidden
#line 177
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UMAResourceFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAResourceFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
