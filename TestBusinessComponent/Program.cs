using BusinessComponent;
using Microsoft.Extensions.DependencyInjection;
using RepositoryComponent;

var container = new ServiceCollection()
    .AddSingleton<IRepository, BeerRepository>() // if need to change or update different repository, here needs to be updated and not all the project
    .AddTransient<BeerManager>()// be using
    .BuildServiceProvider();

//var beerManager = new BeerManager(new DefaultRepository());
//var beerManager = new BeerManager(new BeerRepository());
var beerManager = container.GetService<BeerManager>(); //using dependency injection 
var beerManager2 = container.GetService<BeerManager>(); //using dependency injection 
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