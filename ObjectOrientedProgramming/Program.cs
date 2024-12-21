

using ObjectOrientedProgramming.Business;

Beer erdingBeer = new Beer("Erdinger", 3, -1);
var coronaBeer = new Beer("Corona", 4, 1);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01));

Console.WriteLine(erdingBeer.GetInfo());
Console.WriteLine(erdingBeer.SAlcohol);
Console.WriteLine(coronaBeer.GetInfo());
Console.WriteLine(coronaBeer.SAlcohol);
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.SAlcohol);

