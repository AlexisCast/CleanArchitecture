
var beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");

var reportGeneratorBeer = new ReportGeneratorBeer(beerData);

var report = new Report();

var data = reportGeneratorBeer.Generate();

report.Save(data, "cervezas.txt");

public class BeerData
{
    public List<string> _beers;

    public BeerData()
    {
        _beers = new List<string>();
    }

    public void Add(string beer)
        => _beers.Add(beer);
    public List<string> Get()
        => _beers;
}

public class ReportGeneratorBeer
{
    private BeerData _beerData;
    public ReportGeneratorBeer(BeerData beerData)
    {
        _beerData = beerData;
    }

    public List<string> Generate()
    {
        var data = new List<string>();
        int i = 1;
        foreach (var beer in _beerData.Get())
        {
            data.Add(i + " Cerveza: " + beer);
            i++;
        }
        return data;
    }
}

public class Report
{
    public void Save(List<string> data, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var beer in data)
            {
                writer.WriteLine(beer);
            }
        }
    }
}




// NOT SOLID
//-----------------------------------------------------------
/*var beer = new Beer();
beer.Add("Corona");
beer.Add("Delirium");
beer.SaveReport("cervezas.txt");

public class Beer
{
    public List<string> _beers;

    public Beer()
    {
        _beers = new List<string>();
    }

    public void Add(string beer)
        => _beers.Add(beer);
    public List<string> Get()
        => _beers;
    public List<string> GetReport()
    {
        var data = new List<string>();
        foreach (var beer in _beers)
        {
            data.Add("Cerveza: " + beer);
        }
        return data;
    }
    public void SaveReport(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var beer in GetReport())
            {
                writer.WriteLine(beer);
            }
        }
    }
}*/

