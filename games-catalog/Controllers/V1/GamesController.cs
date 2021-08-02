using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace games_catalog.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<object>>> GetGameList()
        {
            return Ok();
        }

        [HttpGet("{idGame:guid}")]
        public async Task<ActionResult<List<object>>> GetGame(Guid idGame)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<object>> CreateGame( object game){
            return Ok();
        }

        [HttpPut("{idGame:guid}")]
        public async Task<ActionResult> UpdateGame(Guid idGame, object game){
            return Ok();
        }

        [HttpPatch("{idGame:guid}/price/{preco:double}")]
        public async Task<ActionResult> UpdateGame(Guid idGame, double price){
            return Ok();
        }

        [HttpDelete("{idGame:guid}")]
        public async Task<ActionResult> DeleteGame(Guid idGame){
            return Ok();
        }
    }
}