// ------------------------------------------------------------------------------
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
namespace Behavioral.Automation.Scenarios
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Primer_Blast_test")]
    public partial class Primer_Blast_TestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Primer-Blast-test.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Primer_Blast_test", @"	NIH: https://www.genome.gov/genetics-glossary/Polymerase-Chain-Reaction
	Polymerase chain reaction (abbreviated PCR) is a laboratory technique for rapidly producing (amplifying) millions to billions of copies of a specific segment of DNA.
	PCR involves using short synthetic DNA fragments called primers to select a segment of the genome to be amplified.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can provide PCR template\\User can start Primers design")]
        [NUnit.Framework.CategoryAttribute("PrimerDesign1")]
        public void UserCanProvidePCRTemplateUserCanStartPrimersDesign()
        {
            string[] tagsOfScenario = new string[] {
                    "PrimerDesign1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can provide PCR template\\User can start Primers design", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("application URL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And(@"user entered ""GGCTTCGGCGGTAAGGTATCACTCAAGAAGCAGACACAGTAAGACACGGTCTAGCTGACTGTCTATCGGCTAGGTCAAATAGAGAGCTTTGATATCTGCATGTCTAGCTTTAGAATTCAGTTTAGCGCGCTGATCTGAGTCGAGATAAAATCACCAGTACCCAAGACCAGGGGGGCTCGCCACGTTGGCTAATCCTGGTACATCTTGTAATCAATATTCAGTAGAAAATTTGTGTTAGAAGGACGAGTCACCATGTACCAATAGCGATAACGATCGGTCGGACTATTCATTGTGGTGATGACGCTGGGTTTACGTGGGAAAGGTGCTTGTGTCCCGACAGGCTAGGATATAATGCTGAGGCCCTTCCCCAAGCGTTCAGCGTGGGATTTGCTACAACTTCCGAGTCCTACATGTGCGTGTTCATGTTATGTATGCACAAGGCCGAGAATAGGACGTAGCCTTCGAGTTAGTACGTAGCGTGGTCGCACAAGCACAGTAGATCCTCCCCGCGCATCCTATTTATTAAGTTAATTCTAAAGCAATACGATCACATGTGGATGGGCAGTGGCCGGTTGTTACACGCCTACCGCGGTGCTGAATGACCGGGACTAAAGAGGCGAAGATTATGGCGTGTGACCCGTTATGCTCGAGTTCGGTCAGTGCGTCATTGCAAGTAGTCGATTGCTTTCTCAATCTCCGAGCGATTTAGCGTGACAGCCCCAGGGAACCCATAAAATGTGATCGCAGTCCATCCGATCGTACATAGAAAGGAAGGTCCCCATACGCCCACGCACCTGTTTACTCGTCGTATGCATAAAAGAGCCGCACGAACCACAGAGCATAAAGAGGACCTCTAGTTCCTTTACAAAGTACAGGTTCGCTTTTCGGCGAGATGCCTTACCTAGATGCAATGACGGACGTATTCCTCTGGCCACATCGGTTCCTGCTTTCGCTGGGATCCAAGATTGGCAGCTGAAGCCGCCTTTCCATAGTGAGTCCT"" into ""Template"" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("\"Perform specificity check\" checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.When("user clicks on \"Get Primers\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\"Primers design\" table should become visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can specify design parameter")]
        [NUnit.Framework.CategoryAttribute("PrimerDesign2")]
        public void UserCanSpecifyDesignParameter()
        {
            string[] tagsOfScenario = new string[] {
                    "PrimerDesign2"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can specify design parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 15
 testRunner.Given("application URL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
 testRunner.And(@"user entered ""GGCTTCGGCGGTAAGGTATCACTCAAGAAGCAGACACAGTAAGACACGGTCTAGCTGACTGTCTATCGGCTAGGTCAAATAGAGAGCTTTGATATCTGCATGTCTAGCTTTAGAATTCAGTTTAGCGCGCTGATCTGAGTCGAGATAAAATCACCAGTACCCAAGACCAGGGGGGCTCGCCACGTTGGCTAATCCTGGTACATCTTGTAATCAATATTCAGTAGAAAATTTGTGTTAGAAGGACGAGTCACCATGTACCAATAGCGATAACGATCGGTCGGACTATTCATTGTGGTGATGACGCTGGGTTTACGTGGGAAAGGTGCTTGTGTCCCGACAGGCTAGGATATAATGCTGAGGCCCTTCCCCAAGCGTTCAGCGTGGGATTTGCTACAACTTCCGAGTCCTACATGTGCGTGTTCATGTTATGTATGCACAAGGCCGAGAATAGGACGTAGCCTTCGAGTTAGTACGTAGCGTGGTCGCACAAGCACAGTAGATCCTCCCCGCGCATCCTATTTATTAAGTTAATTCTAAAGCAATACGATCACATGTGGATGGGCAGTGGCCGGTTGTTACACGCCTACCGCGGTGCTGAATGACCGGGACTAAAGAGGCGAAGATTATGGCGTGTGACCCGTTATGCTCGAGTTCGGTCAGTGCGTCATTGCAAGTAGTCGATTGCTTTCTCAATCTCCGAGCGATTTAGCGTGACAGCCCCAGGGAACCCATAAAATGTGATCGCAGTCCATCCGATCGTACATAGAAAGGAAGGTCCCCATACGCCCACGCACCTGTTTACTCGTCGTATGCATAAAAGAGCCGCACGAACCACAGAGCATAAAGAGGACCTCTAGTTCCTTTACAAAGTACAGGTTCGCTTTTCGGCGAGATGCCTTACCTAGATGCAATGACGGACGTATTCCTCTGGCCACATCGGTTCCTGCTTTCGCTGGGATCCAAGATTGGCAGCTGAAGCCGCCTTTCCATAGTGAGTCCT"" into ""Template"" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("user entered \"4\" into \"Number of primers to return\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("\"Perform specificity check\" checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("user opened \"Database\" dropdown and selected \"Refseq representative genomes\" in d" +
                        "ropdown menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When("user clicks on \"Get primers\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("\"Primers design\" table should become visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can see primers pairs")]
        [NUnit.Framework.CategoryAttribute("PrimerDesign3")]
        public void UserCanSeePrimersPairs()
        {
            string[] tagsOfScenario = new string[] {
                    "PrimerDesign3"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can see primers pairs", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.Given("application URL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.And(@"user entered ""GGCTTCGGCGGTAAGGTATCACTCAAGAAGCAGACACAGTAAGACACGGTCTAGCTGACTGTCTATCGGCTAGGTCAAATAGAGAGCTTTGATATCTGCATGTCTAGCTTTAGAATTCAGTTTAGCGCGCTGATCTGAGTCGAGATAAAATCACCAGTACCCAAGACCAGGGGGGCTCGCCACGTTGGCTAATCCTGGTACATCTTGTAATCAATATTCAGTAGAAAATTTGTGTTAGAAGGACGAGTCACCATGTACCAATAGCGATAACGATCGGTCGGACTATTCATTGTGGTGATGACGCTGGGTTTACGTGGGAAAGGTGCTTGTGTCCCGACAGGCTAGGATATAATGCTGAGGCCCTTCCCCAAGCGTTCAGCGTGGGATTTGCTACAACTTCCGAGTCCTACATGTGCGTGTTCATGTTATGTATGCACAAGGCCGAGAATAGGACGTAGCCTTCGAGTTAGTACGTAGCGTGGTCGCACAAGCACAGTAGATCCTCCCCGCGCATCCTATTTATTAAGTTAATTCTAAAGCAATACGATCACATGTGGATGGGCAGTGGCCGGTTGTTACACGCCTACCGCGGTGCTGAATGACCGGGACTAAAGAGGCGAAGATTATGGCGTGTGACCCGTTATGCTCGAGTTCGGTCAGTGCGTCATTGCAAGTAGTCGATTGCTTTCTCAATCTCCGAGCGATTTAGCGTGACAGCCCCAGGGAACCCATAAAATGTGATCGCAGTCCATCCGATCGTACATAGAAAGGAAGGTCCCCATACGCCCACGCACCTGTTTACTCGTCGTATGCATAAAAGAGCCGCACGAACCACAGAGCATAAAGAGGACCTCTAGTTCCTTTACAAAGTACAGGTTCGCTTTTCGGCGAGATGCCTTACCTAGATGCAATGACGGACGTATTCCTCTGGCCACATCGGTTCCTGCTTTCGCTGGGATCCAAGATTGGCAGCTGAAGCCGCCTTTCCATAGTGAGTCCT"" into ""Template"" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("user entered \"8\" into \"Number of primers to return\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("user entered \"59\" into \"Minimal melting temperature of primers\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("user entered \"62\" into \"Optimal melting temperature of primers\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("user entered \"65\" into \"Maximal melting temperature of primers\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("\"Perform specificity check\" checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.When("user clicks on \"Get primers\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("\"Primers design\" table should become visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User provided invalid input (sequence or settings)")]
        [NUnit.Framework.CategoryAttribute("PrimerDesign4")]
        public void UserProvidedInvalidInputSequenceOrSettings()
        {
            string[] tagsOfScenario = new string[] {
                    "PrimerDesign4"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User provided invalid input (sequence or settings)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 37
 testRunner.Given("application URL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
 testRunner.And("user entered \"GGCTTCGGCGGTAAGGTATCACTCAAGAAGCAGACACAGTAAGACACGGTCTAGCTGACTGTCTATC" +
                        "GGCTAGGTCAAATAGAGAGCTTTGATATCTGCATGTCTAGCTTTAGAATTCAGTTTAGCGCGCTGATCTGAGTCGAG\" i" +
                        "nto \"Template\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("user entered \"GCTTCG\" into \"Forward primer from\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("user entered \"GACTGTCT\" into \"Forward primer to\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("user entered \"CAAATAG\" into \"Reverse primer from\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("user entered \"GTCGAG\" into \"Reverse primer to\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When("user clicks on \"Get primers\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("label \"Error\" should become visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User provides primers")]
        [NUnit.Framework.CategoryAttribute("PrimerDesign5")]
        public void UserProvidesPrimers()
        {
            string[] tagsOfScenario = new string[] {
                    "PrimerDesign5"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User provides primers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 48
 testRunner.Given("application URL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 49
 testRunner.And(@"user entered ""GGCTTCGGCGGTAAGGTATCACTCAAGAAGCAGACACAGTAAGACACGGTCTAGCTGACTGTCTATCGGCTAGGTCAAATAGAGAGCTTTGATATCTGCATGTCTAGCTTTAGAATTCAGTTTAGCGCGCTGATCTGAGTCGAGATAAAATCACCAGTACCCAAGACCAGGGGGGCTCGCCACGTTGGCTAATCCTGGTACATCTTGTAATCAATATTCAGTAGAAAATTTGTGTTAGAAGGACGAGTCACCATGTACCAATAGCGATAACGATCGGTCGGACTATTCATTGTGGTGATGACGCTGGGTTTACGTGGGAAAGGTGCTTGTGTCCCGACAGGCTAGGATATAATGCTGAGGCCCTTCCCCAAGCGTTCAGCGTGGGATTTGCTACAACTTCCGAGTCCTACATGTGCGTGTTCATGTTATGTATGCACAAGGCCGAGAATAGGACGTAGCCTTCGAGTTAGTACGTAGCGTGGTCGCACAAGCACAGTAGATCCTCCCCGCGCATCCTATTTATTAAGTTAATTCTAAAGCAATACGATCACATGTGGATGGGCAGTGGCCGGTTGTTACACGCCTACCGCGGTGCTGAATGACCGGGACTAAAGAGGCGAAGATTATGGCGTGTGACCCGTTATGCTCGAGTTCGGTCAGTGCGTCATTGCAAGTAGTCGATTGCTTTCTCAATCTCCGAGCGATTTAGCGTGACAGCCCCAGGGAACCCATAAAATGTGATCGCAGTCCATCCGATCGTACATAGAAAGGAAGGTCCCCATACGCCCACGCACCTGTTTACTCGTCGTATGCATAAAAGAGCCGCACGAACCACAGAGCATAAAGAGGACCTCTAGTTCCTTTACAAAGTACAGGTTCGCTTTTCGGCGAGATGCCTTACCTAGATGCAATGACGGACGTATTCCTCTGGCCACATCGGTTCCTGCTTTCGCTGGGATCCAAGATTGGCAGCTGAAGCCGCCTTTCCATAGTGAGTCCT"" into ""Template"" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("user entered \"CGGCGGTAAGGTATCACTCA\" into \"Forward primer\" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("\"Perform specificity check\" checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.When("user clicks on \"Get primers\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("\"Primers design\" table should become visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User specify exon-exon junction attribute")]
        [NUnit.Framework.CategoryAttribute("PrimerDesign6")]
        public void UserSpecifyExon_ExonJunctionAttribute()
        {
            string[] tagsOfScenario = new string[] {
                    "PrimerDesign6"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User specify exon-exon junction attribute", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 57
 testRunner.Given("application URL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
 testRunner.And(@"user entered ""CGCGAUCCGUUAGGGUCGAAAUGUAGCGGUAGUGUACACCGCACUCUAGUAAUAGAAUCCCCACCAUAGAUAGAUUCCUCCCACCAAUUGAAUAUGUACGUAUCCAUCUCGGCGUUGCGCGCUCCUUAUCGGCAAAGCGCUUUAGCAGAGGUACCCGGAGGACCUAUGGUUUAGAUUUUAGUGGUAUCCACGCGAGAUGUUCGGUAUUGUCAUGGUGGUUAUGCCCUUGGAAUCAUCCCAUGGCGCAAUGGGCCUUCCACACAUUACAUCAGUUAACGAUGCAUGAAGAAUUACUGCUCGAUACAAUUCCCAAGGCAACUGUCCUAAUUGACAACGGAAGUGAUUAAAAAGUAACACUUUGCUUCCUAGGGCUUCUGUCUUCGGCGCAUAGCAACCAGUCAAGUGUCAAUUCAAUAUUCGAGCUGGUAUCUUGCCAAAGACAACUUCCCCCACCACGUAGGCCCCUCUAUUUACGUCGAAGCACUAAGCCGUUAGCAGGAAUUUAGUAAGACAGGAUUCUGGCACAAUCGGCGCUUAGAACGAUUGGAUUUUUAGAGAUGUUAUAUUUGUCUGCGGCCUCAAGCGAUGACGUUAGAGUUAGCAGCACUCGAAACCCUGAGGGAUGAGCAAAUCUAAUGACAUGCGUGAUCGAAGUUGUCUUGGGGGAAGCAACGAUGCUCAUCCAUUUAUAGCUUUGCCCAGAAUAGCCCUUCUCAUUGUUAUCAAUCUUGCGAGGAUACCCCGGAAUGUUAACUACCCCGAGGCUUAUAACCUAAGGCUCAAAAUUGUAGAACUCAAUCUUACAGCAGCCGCGACUUCUAUGGCAUUCAGCCUGCAGGGUUCGAAAAGCGUUCUCAUCGCGUUAUAGAUCAACUAGUAGCGUGGCAUCUAUGCGACCUGGCAGUUCAAUAGUCCUCAACGAUUACCGCAAUGUGGGCCAACCUACGGUUAUACGGGAGGCGCCGCACGCGGCACUGAACUGCGGAGGAAGUGGGCCUAC"" into ""Template"" input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("user opened \"Exon Junction span\" dropdown and selected \"No preference\" in dropdow" +
                        "n menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("\"Perform specificity check\" checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.When("user clicks on \"Get primers\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("\"Primers design\" table should become visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
