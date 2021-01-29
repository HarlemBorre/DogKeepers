using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Utils;
using DogKeepers.Shared.QueryFilters;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface IDogService
    {

        Task<PagedList<Dog>> GetList(DogsQueryFilter model);
    }
}