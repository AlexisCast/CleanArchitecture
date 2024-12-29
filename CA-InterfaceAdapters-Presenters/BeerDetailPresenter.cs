using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_ApplicationLayer;
using CA_EnterpriseLayer;

namespace CA_InterfaceAdapters_Presenters
{
    public class BeerDetailPresenter : IPresenter<Beer, BeerDetailViewModel>
    {
        public IEnumerable<BeerDetailViewModel> Present(IEnumerable<Beer> beers)
        {
            return beers.Select(b => new BeerDetailViewModel //transformation
            {
                Id = b.Id,
                Name = b.Name,
                Alcohol = b.Alcohol + "%",
                Color = b.IsStrongBeer() ? "red" : "green",
                Style = b.Style,
                Message = b.IsStrongBeer() ? "Strong Beer" : "",
            });
        }
    }

}
