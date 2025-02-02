﻿

using ObjectOrientedProgramming.Business;

Beer erdingBeer = new Beer("Erdinger", 3, -1, 1009);
var coronaBeer = new Beer("Corona", 4, 1, 330);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01), 1000);
Drink drink = new Beer("Erdinger Black", 5, 5, 500);

//Console.WriteLine(erdingBeer.GetInfo());
//Console.WriteLine(erdingBeer.GetInfo("string"));//overloading
//Console.WriteLine(erdingBeer.GetInfo(0));//overloading
//Console.WriteLine(erdingBeer.SAlcohol);

//Console.WriteLine(coronaBeer.GetInfo());
//Console.WriteLine(coronaBeer.SAlcohol);

//Console.WriteLine(delirium.GetInfo());//overriding
//Console.WriteLine(delirium.GetInfo("string"));//overloading
//Console.WriteLine(delirium.GetInfo(0));//overloading
//Console.WriteLine(delirium.SAlcohol);

////getting from abtract class
//Console.WriteLine(drink.GetQuantity());
//Console.WriteLine(delirium.GetQuantity());
//Console.WriteLine(drink.GetCategory());
//Console.WriteLine(delirium.GetCategory());


//abstract class
Drink drinkWine = new Wine(525);
Show(drinkWine);
drinkWine = new Beer("Corona", 3, 4, 330);
Show(drinkWine);
Show(erdingBeer);


SendSome(erdingBeer);


var service = new Service(100, 10);

ISalable[] concepts = [
    erdingBeer,
    delirium,
    coronaBeer,
    service,
];

Console.WriteLine(GetTotal(concepts));



void Show(Drink drink)
    => Console.WriteLine(drink.GetCategory());

void SendSome(ISend some)
{
    some.Send();
}

decimal GetTotal(ISalable[] concepts)
{
    decimal total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
        Console.WriteLine(concept.GetPrice());
    }
    return total;
}

Console.WriteLine("-------");

// generics
var elements = new Collection<int>(3);
elements.Add(100);
elements.Add(150);
elements.Add(200);
elements.Add(500);
foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}
Console.WriteLine("-------");


var names = new Collection<string>(2);
names.Add("Héctor");
names.Add("Ana");
names.Add("Juan");
foreach (var element in names.Get())
{
    Console.WriteLine(element);
}
Console.WriteLine("-------");


var beers = new Collection<Beer>(2);
beers.Add(erdingBeer);
beers.Add(delirium);
foreach (var element in beers.Get())
{
    Console.WriteLine(element.GetInfo());
}




//static
Console.WriteLine($"Objetos creados {Beer.QuantityObjects}");
Console.WriteLine(Operations.Add(1, 3));
Console.WriteLine(Operations.Mul(10, 20));
