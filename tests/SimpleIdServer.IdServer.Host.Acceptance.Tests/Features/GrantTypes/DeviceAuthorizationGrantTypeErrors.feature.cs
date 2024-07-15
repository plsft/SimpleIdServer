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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DeviceAuthorizationGrantTypeErrorsFeature : object, Xunit.IClassFixture<DeviceAuthorizationGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DeviceAuthorizationGrantTypeErrors.feature"
#line hidden
        
        public DeviceAuthorizationGrantTypeErrorsFeature(DeviceAuthorizationGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "DeviceAuthorizationGrantTypeErrors", "\tCheck all the errors from urn:ietf:params:oauth:grant-type:device_code", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="client_id is required")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "client_id is required")]
        public void Client_IdIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client_id is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table247 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table247.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table247, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("JSON \'$.error_description\'=\'missing client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="device_code is required")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "device_code is required")]
        public void Device_CodeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("device_code is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table248 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table248.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
                table248.AddRow(new string[] {
                            "client_id",
                            "sixtyOneClient"});
                table248.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 16
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table248, "When ");
#line hidden
#line 22
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("JSON \'$.error_description\'=\'missing parameter device_code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="device_code must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "device_code must exists")]
        public void Device_CodeMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("device_code must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table249 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table249.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
                table249.AddRow(new string[] {
                            "client_id",
                            "sixtyOneClient"});
                table249.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table249.AddRow(new string[] {
                            "device_code",
                            "unknown"});
#line 29
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table249, "When ");
#line hidden
#line 36
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("JSON \'$.error_description\'=\'the device_code doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="device_code must not be issued")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "device_code must not be issued")]
        public void Device_CodeMustNotBeIssued()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("device_code must not be issued", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table250 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table250.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
                table250.AddRow(new string[] {
                            "client_id",
                            "sixtyOneClient"});
                table250.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table250.AddRow(new string[] {
                            "device_code",
                            "issuedDeviceCode"});
#line 43
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table250, "When ");
#line hidden
#line 50
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("JSON \'$.error_description\'=\'the device code has already been used to get a token\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="device_code must not be expired")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "device_code must not be expired")]
        public void Device_CodeMustNotBeExpired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("device_code must not be expired", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 56
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table251 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table251.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
                table251.AddRow(new string[] {
                            "client_id",
                            "sixtyOneClient"});
                table251.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table251.AddRow(new string[] {
                            "device_code",
                            "expiredDeviceCode"});
#line 57
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table251, "When ");
#line hidden
#line 64
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.And("JSON \'$.error\'=\'expired_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("JSON \'$.error_description\'=\'the device code is expired\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="cannot get the device_code too many times")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "cannot get the device_code too many times")]
        public void CannotGetTheDevice_CodeTooManyTimes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cannot get the device_code too many times", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 70
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table252 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table252.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
                table252.AddRow(new string[] {
                            "client_id",
                            "sixtyOneClient"});
                table252.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table252.AddRow(new string[] {
                            "device_code",
                            "tooManyDeviceCode"});
#line 71
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table252, "When ");
#line hidden
#line 78
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.And("JSON \'$.error\'=\'slow_down\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And("JSON \'$.error_description\'=\'you tried too many times to get a token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="cannot get an access token if the authorization device code has a PENDING state")]
        [Xunit.TraitAttribute("FeatureTitle", "DeviceAuthorizationGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "cannot get an access token if the authorization device code has a PENDING state")]
        public void CannotGetAnAccessTokenIfTheAuthorizationDeviceCodeHasAPENDINGState()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cannot get an access token if the authorization device code has a PENDING state", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 84
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table253 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table253.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:device_code"});
                table253.AddRow(new string[] {
                            "client_id",
                            "sixtyOneClient"});
                table253.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table253.AddRow(new string[] {
                            "device_code",
                            "pendingDeviceCode"});
#line 85
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table253, "When ");
#line hidden
#line 92
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.And("JSON \'$.error\'=\'authorization_pending\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And("JSON \'$.error_description\'=\'authorization request is still pending as the end use" +
                        "r hasn\'t yet completed the user-interation steps\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                DeviceAuthorizationGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DeviceAuthorizationGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
