using games_catalog.Exceptions;
using games_catalog.Models.InputModel;
using games_catalog.Models.ViewModel;
using games_catalog.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace games_catalog.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GameViewModel>>> GetGameList([FromQuery, Range(1, int.MaxValue)] int page = 1,
                                                                         [FromQuery, Range(1, 50)] int quantity = 5)
        {
            var games = await _gameService.Get(page, quantity);

            if(games.Count() == 0 )
                return NoContent();

            return Ok(games);
        }

        [HttpGet("{idGame:guid}")]
        public async Task<ActionResult<List<GameViewModel>>> GetGame([FromRoute] Guid idGame)
        {
            var game = await _gameService.Get(idGame);

            if (game == null)
                return NoContent();

            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<GameViewModel>> CreateGame([FromBody] GameInputModel gameInputModel){
            try{
                var game = await _gameService.Insert(gameInputModel);

                return Ok(game);
            } catch (GameAlreadyRegisteredExeption) {
                return UnprocessableEntity("Já existe um jogo com este nome para esta produtora");
            }
        }

        [HttpPut("{idGame:guid}")]
        public async Task<ActionResult> UpdateGame([FromRoute] Guid idGame, [FromRoute] GameInputModel gameInputModel){
            try{
                await _gameService.Update(idGame, gameInputModel);

                return Ok();
            } catch (GameNotRegisteredException) {
                return NotFound("Jogo inexistente");
            }
        }

        [HttpPatch("{idGame:guid}/price/{preco:double}")]
        public async Task<ActionResult> UpdateGame([FromRoute] Guid idGame, [FromRoute] double price){
            try{
                await _gameService.Update(idGame, price);

                return Ok();
            } catch (GameNotRegisteredException) {
                return NotFound("Jogo inexistente");
            }
        }

        [HttpDelete("{idGame:guid}")]
        public async Task<ActionResult> DeleteGame([FromRoute] Guid idGame){
            try{
                await _gameService.Delete(idGame);

                return Ok();
            } catch (GameNotRegisteredException) {
                return NotFound("Jogo inexistente");
            }
        }
    }
}