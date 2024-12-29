using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_ApplicationLayer.Exceptions;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public class AddBeerUseCase<TDTO>
    {
        private readonly IRepository<Beer> _beerRepository;
        private readonly IMapper<TDTO, Beer> _mapper;
        public AddBeerUseCase(IRepository<Beer> beerRepository,
            IMapper<TDTO, Beer> mapper)
        {
            _beerRepository = beerRepository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(TDTO beerDTO)
        {
            var beer = _mapper.ToEntity(beerDTO);

            if (string.IsNullOrEmpty(beer.Name))
            {
                //throw new Exception("The name of beer is required.");
                throw new ValidationException("The name of beer is required.");
            }

            await _beerRepository.AddAsync(beer);
        }
    }
}
