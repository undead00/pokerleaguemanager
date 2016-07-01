using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using PokerLeagueManager.UI.Wpf.Infrastructure;
using PokerLeagueManager.Common.DTO;
using PokerLeagueManager.Common.Commands.Infrastructure;
using System.Collections.Generic;
using PokerLeagueManager.UI.Wpf.ViewModels;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PokerLeagueManager.UI.Wpf.ViewModels.Tests
{
    public partial class EnterGameResultsViewModelTest
    {

[TestMethod]
[PexGeneratedBy(typeof(EnterGameResultsViewModelTest))]
public void PlayersGetTest878()
{
    EnterGameResultsViewModel enterGameResultsViewModel;
    IEnumerable<string> iEnumerable;
    enterGameResultsViewModel = new EnterGameResultsViewModel
                                    ((ICommandService)null, (IQueryService)null, (IMainWindow)null, (ILog)null);
    enterGameResultsViewModel.GameDate = default(DateTime?);
    enterGameResultsViewModel.SelectedPlayerIndex = 0;
    ((BaseViewModel)enterGameResultsViewModel).Width = 0;
    iEnumerable = this.PlayersGetTest(enterGameResultsViewModel);
    Assert.IsNotNull((object)iEnumerable);
    Assert.IsNotNull((object)enterGameResultsViewModel);
    Assert.IsNull((object)(enterGameResultsViewModel.GameDate));
    Assert.AreEqual<string>("", enterGameResultsViewModel.NewPlayerName);
    Assert.AreEqual<string>("", enterGameResultsViewModel.NewPlacing);
    Assert.AreEqual<string>("0", enterGameResultsViewModel.NewWinnings);
    Assert.AreEqual<string>("0", enterGameResultsViewModel.NewPayIn);
    Assert.IsNotNull(enterGameResultsViewModel.AddPlayerCommand);
    Assert.IsNotNull(enterGameResultsViewModel.DeletePlayerCommand);
    Assert.IsNotNull(enterGameResultsViewModel.SaveGameCommand);
    Assert.IsNotNull(enterGameResultsViewModel.CancelCommand);
    Assert.AreEqual<int>(0, enterGameResultsViewModel.SelectedPlayerIndex);
    Assert.AreEqual<int>(0, ((BaseViewModel)enterGameResultsViewModel).Width);
    Assert.AreEqual<int>(400, ((BaseViewModel)enterGameResultsViewModel).Height);
    Assert.AreEqual<string>("Enter Game Results", 
                            ((BaseViewModel)enterGameResultsViewModel).WindowTitle);
}
    }
}
