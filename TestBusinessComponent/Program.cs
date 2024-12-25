using BusinessComponent;
using RepositoryComponent;


//var beerManager = new BeerManager(new DefaultRepository());
var beerManager = new BeerManager(new BeerRepository());
beerManager.Add("Delirium Red");
beerManager.Add("London Porter");
Console.WriteLine(beerManager.Get());

// clase provisional
public class DefaultRepository : IRepository
{
    public void Add(string name)
    { }

    public string Get()
        => "algo";
}