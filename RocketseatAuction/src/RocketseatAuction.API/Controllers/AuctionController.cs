using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionController : RocketseatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetCurrentAuction()
    {
        var UseCase = new GetCurrentAuctionUseCase();
        var result = UseCase.Execute();
        if(result is null)
        {
            return NotFound();
        }
        return Ok(result);
    }
}

