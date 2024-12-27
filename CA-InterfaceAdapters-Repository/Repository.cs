using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapter_Data;
using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Repository
{
    public class Repository : IRepository<Beer> // work with entity(Beer) and not model(BeerModel)
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

        public async Task<IEnumerable<Beer>> GetAllAsync()
        {
            return await _dbContext.Beers
                .Select(b => new Beer // transformation
                {
                    Id = b.Id,
                    Name = b.Name,
                    Style = b.Style,
                    Alcohol = b.Alcohol,
                })
                .ToListAsync();
        }

        public async Task<Beer> GetByIdAsync(int id)
        {
            var beerModel = await _dbContext.Beers.FindAsync(id);
            return new Beer // transformation
            {
                Id = beerModel.Id,
                Name = beerModel.Name,
                Style = beerModel.Style,
                Alcohol = beerModel.Alcohol,
            };
        }
    }
}
