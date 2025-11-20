using Scraper.Modules.TradingCardGameCollector.DTOs;

namespace Scraper.Modules.TradingCardGameCollector.Persistence;

public class TradingCardGameCollectorRepostiory
{
    public List<TradingCardGameCollectorPokemonCardDto> GetMyTradingCardGameCollectorCards()
    {
        // Scrape Data from Page https://www.tcgcollector.com
        return new List<TradingCardGameCollectorPokemonCardDto>();
    }
}