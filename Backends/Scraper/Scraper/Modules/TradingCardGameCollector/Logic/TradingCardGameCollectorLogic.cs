using Microsoft.AspNetCore.Mvc;
using Scraper.Modules.TradingCardGameCollector.DTOs;
using Scraper.Modules.TradingCardGameCollector.Persistence;

namespace Scraper.Modules.TradingCardGameCollector.Logic;

public class TradingCardGameCollectorLogic(TradingCardGameCollectorRepostiory tradingCardGameCollectorRepostiory)
    : ControllerBase
{
    public List<TradingCardGameCollectorPokemonCardDto> GetMyTradingCardGameCollectorCards()
    {
        return tradingCardGameCollectorRepostiory.GetMyTradingCardGameCollectorCards();
    }
}