// <copyright file="EnterGameResultsViewModelTest.cs">Copyright ©  2012</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerLeagueManager.Common.Commands.Infrastructure;
using PokerLeagueManager.Common.DTO;
using PokerLeagueManager.UI.Wpf.Infrastructure;
using PokerLeagueManager.UI.Wpf.ViewModels;
using log4net;

namespace PokerLeagueManager.UI.Wpf.ViewModels.Tests
{
    /// <summary>This class contains parameterized unit tests for EnterGameResultsViewModel</summary>
    [PexClass(typeof(EnterGameResultsViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class EnterGameResultsViewModelTest
    {
        /// <summary>Test stub for .ctor(ICommandService, IQueryService, IMainWindow, ILog)</summary>
        [PexMethod]
        public EnterGameResultsViewModel ConstructorTest(
            ICommandService commandService,
            IQueryService queryService,
            IMainWindow mainWindow,
            ILog logger
        )
        {
            EnterGameResultsViewModel target = new EnterGameResultsViewModel
                                                   (commandService, queryService, mainWindow, logger);
            return target;
            // TODO: add assertions to method EnterGameResultsViewModelTest.ConstructorTest(ICommandService, IQueryService, IMainWindow, ILog)
        }

        /// <summary>Test stub for get_Players()</summary>
        [PexMethod]
        public IEnumerable<string> PlayersGetTest([PexAssumeUnderTest]EnterGameResultsViewModel target)
        {
            IEnumerable<string> result = target.Players;
            return result;
            // TODO: add assertions to method EnterGameResultsViewModelTest.PlayersGetTest(EnterGameResultsViewModel)
        }
    }
}
