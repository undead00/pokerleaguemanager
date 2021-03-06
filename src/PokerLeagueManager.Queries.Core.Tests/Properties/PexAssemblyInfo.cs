using System;
using System.Runtime.InteropServices;
using PokerLeagueManager.Queries.Core.Infrastructure;
using Microsoft.Pex.Framework.Using;
using PokerLeagueManager.Common.Events;
using PokerLeagueManager.Common.DTO;
using PokerLeagueManager.Common.DTO.DataTransferObjects.Lookups;
using PokerLeagueManager.Common.Tests;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2012</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("PokerLeagueManager.Queries.Core")]
[assembly: PexInstrumentAssembly("EntityFramework")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("Microsoft.Practices.Unity")]
[assembly: PexInstrumentAssembly("PokerLeagueManager.Common.DTO")]
[assembly: PexInstrumentAssembly("PokerLeagueManager.Common.Utilities")]
[assembly: PexInstrumentAssembly("PokerLeagueManager.Common.Events")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "EntityFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Practices.Unity")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PokerLeagueManager.Common.DTO")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PokerLeagueManager.Common.Utilities")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PokerLeagueManager.Common.Events")]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(FakeQueryDataStore))]
[assembly: PexSuppressExplorableEvent(typeof(FakeQueryDataStore))]
[assembly: PexSuppressExplorableEvent(typeof(LookupGamePlayersDto))]
[assembly: PexSuppressExplorableEvent(typeof(GetPlayerStatisticsDto))]
[assembly: PexSuppressExplorableEvent(typeof(GameDeletedEvent))]
[assembly: PexUseType(typeof(FakeQueryDataStore))]
[assembly: PexSuppressStaticFieldStore("System.Linq.SR", "loader")]
[assembly: PexSuppressUninstrumentedMethodFromType("Microsoft.Win32.Win32Native")]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(Marshal))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(TimeZoneInfo))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(Environment))]

