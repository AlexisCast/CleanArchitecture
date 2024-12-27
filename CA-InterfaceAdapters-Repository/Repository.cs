using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapter_Data;
using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Repository
{
    public class Repository : IRepository<BeerModel>
    {
        private readonly AppDbContext _dbContext;
        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Beer beer)
        {
            var beerModel = new BeerModel() // transformation
            {
                Name = beer.Name,
                Style = beer.Style,
                Alcohol = beer.Alcohol,

            };
            await _dbContext.Beers.AddAsync(beerModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BeerModel>> GetAllAsync()
        {
            return await _dbContext.Beers.ToListAsync();
        }

        public async Task<BeerModel> GetByIdAsync(int id)
        {
            return await _dbContext.Beers.FindAsync(id);
        }
    }
}
