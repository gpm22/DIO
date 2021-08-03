using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using games_catalog.Models.InputModel;
using games_catalog.Models.ViewModel;

namespace games_catalog.Services
{
    public interface IGameService
    {
        Task<List<GameViewModel>> Get(int page, int quantity);

        Task<GameViewModel> Get(Guid id);

        Task<GameViewModel> Insert(GameInputModel game);

        Task Update(Guid id, GameInputModel game);

        Task Update(Guid id, double price);

        Task Delete(Guid id);
    }
}