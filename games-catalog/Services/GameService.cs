using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_catalog.Entities;
using games_catalog.Exceptions;
using games_catalog.Models.InputModel;
using games_catalog.Models.ViewModel;
using games_catalog.Repositories;

namespace games_catalog.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task Delete(Guid id)
        {
            var game = _gameRepository.Get(id);
            
            if (game == null)
                throw new GameNotRegisteredException();

            await _gameRepository.Delete(id);
        }

        public async Task<List<GameViewModel>> Get(int page, int quantity)
        {
            var games = await _gameRepository.Get(page, quantity);

            return games.Select(game => new GameViewModel 
            { 
                Id = game.Id,
                Name = game.Name,
                Producer = game.Producer,
                Price = game.Price
            }).ToList();
        }

        public async Task<GameViewModel> Get(Guid id)
        {
            var game = await _gameRepository.Get(id);

            if (game == null)
                return null;

            return new GameViewModel 
            { 
                Id = game.Id,
                Name = game.Name,
                Producer = game.Producer,
                Price = game.Price
            };
        }

        public async Task<GameViewModel> Insert(GameInputModel game)
        {
            var gameEntity = await _gameRepository.Get(game.Name, game.Producer);

            if (gameEntity.Count > 0)
                throw new GameAlreadyRegisteredExeption();

            var gameInsert = new Game
            {
                Id = Guid.NewGuid(),
                Name = game.Name,
                Producer = game.Producer,
                Price = game.Price
            };

            await _gameRepository.Insert(gameInsert);

            return new GameViewModel{
                Id = gameInsert.Id,
                Name = game.Name,
                Producer = game.Producer,
                Price = game.Price
            }
        }

        public async Task Update(Guid id, GameInputModel game)
        {
            var gameEntity = await _gameRepository.Get(id);

            if (gameEntity == null)
                throw new GameNotRegisteredException();

            gameEntity.Name = game.Name;
            gameEntity.Producer = game.Producer;
            gameEntity.Price = game.Price;

            await _gameRepository.Update(gameEntity);
        }

        public async Task Update(Guid id, double price)
        {
            var gameEntity = await _gameRepository.Get(id);

            if (gameEntity == null)
                throw new GameNotRegisteredException();

            gameEntity.Price = price;

            await _gameRepository.Update(gameEntity);
        }

        public void Dispose(){
            _gameRepository?.Dispose();
        }
    }
}