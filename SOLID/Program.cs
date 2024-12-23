




// NOT SOLID
//-----------------------------------------------------------
var beer = new Beer();
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
}

