

using ObjectOrientedProgramming.Business;

Beer erdingBeer = new Beer("Erdinger", 3, -1, 1009);
var coronaBeer = new Beer("Corona", 4, 1, 330);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01), 1000);
Drink drink = new Beer("Erdinger Black", 5, 5, 500);

Console.WriteLine(erdingBeer.GetInfo());
Console.WriteLine(erdingBeer.GetInfo("string"));//overloading
Console.WriteLine(erdingBeer.GetInfo(0));//overloading
Console.WriteLine(erdingBeer.SAlcohol);

Console.WriteLine(coronaBeer.GetInfo());
Console.WriteLine(coronaBeer.SAlcohol);

Console.WriteLine(delirium.GetInfo());//overriding
Console.WriteLine(delirium.GetInfo("string"));//overloading
Console.WriteLine(delirium.GetInfo(0));//overloading
Console.WriteLine(delirium.SAlcohol);

//getting from abtract class
Console.WriteLine(drink.GetQuantity());
Console.WriteLine(delirium.GetQuantity());
Console.WriteLine(drink.GetCategory());
Console.WriteLine(delirium.GetCategory());

