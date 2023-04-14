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
    public partial class RefreshTokenGrantTypeErrorsFeature : object, Xunit.IClassFixture<RefreshTokenGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RefreshTokenGrantTypeErrors.feature"
#line hidden
        
        public RefreshTokenGrantTypeErrorsFeature(RefreshTokenGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "RefreshTokenGrantTypeErrors", "\tCheck errors returned when using \'refresh_token\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token\' with no refresh_token parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token\' with no refresh_token parameter")]
        public void SendGrant_TypeRefresh_TokenWithNoRefresh_TokenParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token\' with no refresh_token parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table241 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table241.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table241, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'missing parameter refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt\' with no client_id")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt\' with no client_id")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtWithNoClient_Id()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt\' with no client_id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table242 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table242.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table242.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
#line 15
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table242, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("JSON \'$.error_description\'=\'missing client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt\' with invalid client_id")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt\' with invalid client_id")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtWithInvalidClient_Id()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt\' with invalid client_id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table243 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table243.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table243.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table243.AddRow(new string[] {
                            "client_id",
                            "c"});
#line 26
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table243, "When ");
#line hidden
#line 32
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("JSON \'$.error_description\'=\'unknown client c\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient\' with no cl" +
            "ient_secret")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient\' with no cl" +
            "ient_secret")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFirstClientWithNoClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient\' with no cl" +
                    "ient_secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table244 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table244.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table244.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table244.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
#line 38
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table244, "When ");
#line hidden
#line 44
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("JSON \'$.error_description\'=\'bad client credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=bad\' with bad client_secret")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=bad\' with bad client_secret")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFirstClientClient_SecretBadWithBadClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
                    "et=bad\' with bad client_secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table245 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table245.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table245.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table245.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table245.AddRow(new string[] {
                            "client_secret",
                            "bad"});
#line 50
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table245, "When ");
#line hidden
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("JSON \'$.error_description\'=\'bad client credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=password\' with unauthorized grant_type")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=password\' with unauthorized grant_type")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFirstClientClient_SecretPasswordWithUnauthorizedGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
                    "et=password\' with unauthorized grant_type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table246 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table246.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table246.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table246.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table246.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 63
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table246, "When ");
#line hidden
#line 70
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("JSON \'$.error_description\'=\'grant type refresh_token is not supported by the clie" +
                        "nt\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=fifthClient,client_secr" +
            "et=password\' with missing refresh_token")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=fifthClient,client_secr" +
            "et=password\' with missing refresh_token")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFifthClientClient_SecretPasswordWithMissingRefresh_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=fifthClient,client_secr" +
                    "et=password\' with missing refresh_token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 75
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
                            "refresh_token"});
                table247.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table247.AddRow(new string[] {
                            "client_id",
                            "fifthClient"});
                table247.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 76
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table247, "When ");
#line hidden
#line 83
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And("JSON \'$.error_description\'=\'bad refresh token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=$refreshtoken$,client_id=fifthClient" +
            ",client_secret=password\' with expired refresh_token")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=$refreshtoken$,client_id=fifthClient" +
            ",client_secret=password\' with expired refresh_token")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRefreshtokenClient_IdFifthClientClient_SecretPasswordWithExpiredRefresh_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=$refreshtoken$,client_id=fifthClient" +
                    ",client_secret=password\' with expired refresh_token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 88
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
                            "client_credentials"});
                table248.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table248.AddRow(new string[] {
                            "client_id",
                            "fifthClient"});
                table248.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 89
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table248, "When ");
#line hidden
#line 96
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("extract parameter \'$.refresh_token\' from JSON body into \'refreshToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table249 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table249.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table249.AddRow(new string[] {
                            "refresh_token",
                            "$refreshToken$"});
                table249.AddRow(new string[] {
                            "client_id",
                            "fifthClient"});
                table249.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 99
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table249, "And ");
#line hidden
#line 106
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And("JSON \'$.error_description\'=\'refresh token is expired\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                RefreshTokenGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RefreshTokenGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
