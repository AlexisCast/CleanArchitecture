
var beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");

var reportGeneratorBeer = new ReportGeneratorBeer(beerData);

var report = new Report();

var data = reportGeneratorBeer.Generate();
report.Save(reportGeneratorBeer, "cervezas.txt");

var reportGeneratorBeerHTML = new ReportGeneratorHTMLBeer(beerData);
report.Save(reportGeneratorBeerHTML, "cervezasHTML.html");


public interface IReportGenerator
{
    public string Generate();
}

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

public class ReportGeneratorBeer : IReportGenerator
{
    private BeerData _beerData;
    public ReportGeneratorBeer(BeerData beerData)
    {
        _beerData = beerData;
    }

    public string Generate()
    {
        string data = "";
        foreach (var beer in _beerData.Get())
        {
            data += " Cerveza: " + beer + Environment.NewLine;
        }
        return data;
    }
}

public class ReportGeneratorHTMLBeer : IReportGenerator
{
    private BeerData _beerData;
    public ReportGeneratorHTMLBeer(BeerData beerData)
    {
        _beerData = beerData;
    }
    public string Generate()
    {
        string data = "<div>";
        foreach (var beer in _beerData.Get())
        {
            data += "<b>" + beer + "<b></br>";
        }
        data += "</div>";

        return data;
    }

}

public class Report
{
    public void Save(IReportGenerator reportGenerator, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            string data = reportGenerator.Generate();
            writer.WriteLine(data);
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

