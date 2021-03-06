using PokerLeagueManager.UI.Wpf.ViewModels;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2012</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Using;
using Microsoft.Pex.Framework.Validation;
using PokerLeagueManager.Common.Tests;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("PokerLeagueManager.UI.Wpf")]
[assembly: PexInstrumentAssembly("System.ServiceModel")]
[assembly: PexInstrumentAssembly("PokerLeagueManager.Common.DTO")]
[assembly: PexInstrumentAssembly("PokerLeagueManager.Common.Utilities")]
[assembly: PexInstrumentAssembly("PresentationCore")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("PokerLeagueManager.Common.Commands")]
[assembly: PexInstrumentAssembly("PresentationFramework")]
[assembly: PexInstrumentAssembly("log4net")]
[assembly: PexInstrumentAssembly("Microsoft.Practices.Unity")]
[assembly: PexInstrumentAssembly("WindowsBase")]
[assembly: PexInstrumentAssembly("System.Xaml")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.ServiceModel")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PokerLeagueManager.Common.DTO")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PokerLeagueManager.Common.Utilities")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PresentationCore")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PokerLeagueManager.Common.Commands")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PresentationFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "log4net")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Practices.Unity")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "WindowsBase")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Xaml")]
[assembly: PexSuppressExplorableEvent(typeof(EnterGameResultsViewModel))]
[assembly: PexSuppressStaticFieldStore("PokerLeagueManager.UI.Wpf.ViewModels.EnterGameResultsViewModel+<>c", "<>9__23_0")]
[assembly: PexSuppressStaticFieldStore("PokerLeagueManager.UI.Wpf.ViewModels.EnterGameResultsViewModel+<>c", "<>9__23_1")]
[assembly: PexUseType(typeof(FakeQueryDataStore))]
