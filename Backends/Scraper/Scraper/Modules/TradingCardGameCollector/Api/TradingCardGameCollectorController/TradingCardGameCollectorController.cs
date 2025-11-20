using Microsoft.AspNetCore.Mvc;
using Scraper.Modules.TradingCardGameCollector.DTOs;
using Scraper.Modules.TradingCardGameCollector.Logic;

namespace Scraper.Modules.TradingCardGameCollector.Api.TradingCardGameCollectorController;

[ApiController]
[Route("tradingCardGameCollector")]
public class TradingCardGameCollectorController(TradingCardGameCollectorLogic tradingCardGameCollectorLogic) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<TradingCardGameCollectorPokemonCardDto>> GetMyTradingCardGameCollectorCards()
    {
        return tradingCardGameCollectorLogic.GetMyTradingCardGameCollectorCards();
    }
}