using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication28.Models;

namespace WebApplication28.Features.Players.Interfaces
{
    public interface IPlayersService
    {
        Task<IEnumerable<Player>> GetPlayersList();
        Task<Player> GetPlayerById(int id);
        Task<Player> CreatePlayer(Player player);
        Task<int> UpdatePlayer(Player player);
        Task<int> DeletePlayer(Player player);
    }
}
