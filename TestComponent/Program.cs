using BeersRepositoryComponent;
using OperationComponent;

// on Dependancies -> add Project Referances -> OperationComponent
var operations = new Operations();

var result = operations.Mul(2, 3); // ../TestComponent/bin/Debug/net8.0 TestComponent.exe uses OperationComponent.dll
Console.WriteLine(result);
Console.ReadLine();

// on Dependancies -> add Project Referances -> BeerRepositoryComponent
var beer = new Beers();

