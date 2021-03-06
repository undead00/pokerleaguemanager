using PokerLeagueManager.Common.Events;
// <copyright file="GetPlayerStatisticsHandlerTest.cs">Copyright ©  2012</copyright>

using System;
using System.Linq;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Using;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerLeagueManager.Common.DTO;
using PokerLeagueManager.Common.DTO.DataTransferObjects.Lookups;
using PokerLeagueManager.Common.Tests;
using PokerLeagueManager.Queries.Core.EventHandlers;

namespace PokerLeagueManager.Queries.Core.EventHandlers.Tests
{
    [TestClass]
    [PexClass(typeof(GetPlayerStatisticsHandler))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GetPlayerStatisticsHandlerTest
    {

        [PexMethod(MaxBranches = 200000)]
        [PexUseType(typeof(FakeQueryDataStore))]
        public void Handle([PexAssumeUnderTest] GetPlayerStatisticsHandler target, GameDeletedEvent e,
            LookupGamePlayersDto[] gamePlayersDtos, GetPlayerStatisticsDto[] getPlayerStatisticsDtos)
        {
            PexAssume.IsNotNull(target);
            PexAssume.IsNotNull(target.QueryDataStore);
            PexAssume.IsNotNull(e);

            PexAssume.IsNotNull(gamePlayersDtos);
            PexAssume.IsTrue(gamePlayersDtos.Length == 2);
            PexAssume.IsNotNull(gamePlayersDtos[0]);
            PexAssume.IsNotNull(gamePlayersDtos[1]);
            PexAssume.IsTrue(gamePlayersDtos[1].GameId == e.AggregateId);

            PexAssume.IsNotNull(getPlayerStatisticsDtos);
            PexAssume.IsTrue(getPlayerStatisticsDtos.Length == 1);
            PexAssume.IsNotNull(getPlayerStatisticsDtos[0]);

            PexAssume.IsTrue(gamePlayersDtos[0].PlayerName == getPlayerStatisticsDtos[0].PlayerName);
            PexAssume.IsTrue(gamePlayersDtos[1].PlayerName == getPlayerStatisticsDtos[0].PlayerName);

            foreach (var gamePlayersDto in gamePlayersDtos)
            {
                target.QueryDataStore.Insert(gamePlayersDto);
            }
            target.QueryDataStore.Insert(getPlayerStatisticsDtos[0]);

            target.Handle(e);
            // TODO: add assertions to method GetPlayerStatisticsHandlerTest.Handle(GetPlayerStatisticsHandler, GameDeletedEvent)

            var getPlayerStatisticsDto = target.QueryDataStore.GetData<GetPlayerStatisticsDto>().Single();
            PexObserve.ValueAtEndOfTest("playerStats", getPlayerStatisticsDto);
        }

        [PexMethod(MaxBranches = 200000)]
        [PexUseType(typeof(FakeQueryDataStore))]
        public void Handle([PexAssumeUnderTest]GetPlayerStatisticsHandler target, PlayerAddedToGameEvent e,
            LookupGamePlayersDto[] gamePlayersDtos, GetPlayerStatisticsDto[] getPlayerStatisticsDtos)
        {
            PexAssume.IsNotNull(target);
            PexAssume.IsNotNull(target.QueryDataStore);
            PexAssume.IsNotNull(e);

            PexAssume.IsNotNull(gamePlayersDtos);
            PexAssume.IsTrue(gamePlayersDtos.Length == 2);
            PexAssume.IsNotNull(gamePlayersDtos[0]);
            PexAssume.IsNotNull(gamePlayersDtos[1]);
            PexAssume.IsTrue(gamePlayersDtos[1].GameId == e.AggregateId);

            PexAssume.IsNotNull(getPlayerStatisticsDtos);
            PexAssume.IsTrue(getPlayerStatisticsDtos.Length == 1);
            PexAssume.IsNotNull(getPlayerStatisticsDtos[0]);

            PexAssume.IsTrue(gamePlayersDtos[0].PlayerName == getPlayerStatisticsDtos[0].PlayerName);
            PexAssume.IsTrue(gamePlayersDtos[1].PlayerName == getPlayerStatisticsDtos[0].PlayerName);

            foreach (var gamePlayersDto in gamePlayersDtos)
            {
                target.QueryDataStore.Insert(gamePlayersDto);
            }
            target.QueryDataStore.Insert(getPlayerStatisticsDtos[0]);

            target.Handle(e);
            // TODO: add assertions to method GetPlayerStatisticsHandlerTest.Handle(GetPlayerStatisticsHandler, PlayerAddedToGameEvent)
            var getPlayerStatisticsDto = target.QueryDataStore.GetData<GetPlayerStatisticsDto>().FirstOrDefault();
            PexObserve.ValueAtEndOfTest("playerStats", getPlayerStatisticsDto);
        }
    }
}
