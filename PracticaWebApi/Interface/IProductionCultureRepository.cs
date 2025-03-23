using static PracticaWebApi.Model.ProductionCulturecs;

namespace PracticaWebApi.Interface
{
    public interface IProductionCultureRepository
    {
        Task<IEnumerable<Culture>> GetCultureAsync();
        Task<Culture> GetCultureByIdAsync(string CultureId);
    }
}
