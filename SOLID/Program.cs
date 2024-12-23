
//BeerData beerData = new LimitedBeerData(2); Do not use/not relation in between
//LimitedBeerData beerData = new LimitedBeerData(2); // yes in complaince with LISKOV
//var beerData = new LimitedBeerData(2); // yes in complaince with LISKOV
var beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");
beerData.Add("Erdinger");

var reportGeneratorBeer = new ReportGeneratorBeer(beerData);

var report = new Report();

var data = reportGeneratorBeer.Generate();
report.Save(reportGeneratorBeer, "cervezas.txt");

var reportGeneratorBeerHTML = new ReportGeneratorHTMLBeer(beerData);
report.Save(reportGeneratorBeerHTML, "cervezasHTML.html");


Show(reportGeneratorBeer);

Rectangle rectangle = new Square();
rectangle.setWidth(10);
rectangle.setHeight(20); // not in complaince with Liskov
Console.WriteLine(rectangle.getArea());

void Show(IReportShow report)
{
    report.Show();
}

public interface IReportGenerator
{
    public string Generate();
}

public interface IReportShow
{
    public void Show();
}

public class BeerData
{
    protected List<string> _beers;

    public BeerData()
    {
        _beers = new List<string>();
    }

    public virtual void Add(string beer)
        => _beers.Add(beer);
    public List<string> Get()
        => _beers;
}

// BREAKING LISKOV
/*public class LimitedBeerData : BeerData
{
    private int _limit;
    public LimitedBeerData(int limit)
    {
        _limit = limit;
    }
    public override void Add(string beer) // parent should change to virtual
    {
        if (_beers.Count >= _limit)
        {
            throw new InvalidOperationException("Límite de cervezas alcanzado");
        }
        base.Add(beer);
    }
}*/

// IN COMPLAINCE WITH LISKOV not effective parent behavior
public class LimitedBeerData : BeerData
{
    private BeerData _beerData = new BeerData();
    private int _limit;
    private int _count = 0;

    public LimitedBeerData(int limit)
    {
        _limit = limit;
    }
    public override void Add(string beer) // parent should change to virtual
    {
        if (_beers.Count >= _limit)
        {
            throw new InvalidOperationException("Límite de cervezas alcanzado");
        }
        _beerData.Add(beer);
        _count++;
    }
    public List<string> Get()
    {
        return _beerData.Get();
    }
}

public class ReportGeneratorBeer : IReportGenerator, IReportShow
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
    public void Show()
    {
        foreach (var beer in _beerData.Get())
        {
            Console.WriteLine("Cerveza: " + beer);
        }
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


public class Rectangle
{
    private int _width;
    private int _height;

    public virtual void setWidth(int width)
    {
        _width = width;
    }

    public virtual void setHeight(int height)
    {
        _height = height;
    }

    public int getArea()
    {
        return _width * _height;
    }
}

public class Square : Rectangle
{
    public override void setWidth(int width)
    {
        base.setWidth(width);
        base.setHeight(width);
    }

    public override void setHeight(int height)
    {
        base.setWidth(height);
        base.setHeight(height);
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

