using BeersRepositoryComponent;
using OperationComponent;

// on Dependancies -> add Project Referances -> OperationComponent
var operations = new Operations();

var result = operations.Mul(2, 3); // ../TestComponent/bin/Debug/net8.0 TestComponent.exe uses OperationComponent.dll
Console.WriteLine(result);
Console.ReadLine();

// on Dependancies -> add Project Referances -> BeerRepositoryComponent
var beer = new Beers();

// CRP talks about not depending on things that will not be used... related to interface segregation principle





// IS in complaince with ADP
public class C
{
    private readonly IA _a;
    public C(IA a)
    {
        _a = a;
    }
}

public interface IA
{
    public void MethodA();
}

public class A : IA
{
    private readonly B _b;
    public A(B b)
    {
        _b = b;
    }
    public void MethodA()
    {


    }
}

public class B
{
    private readonly C _c;
    public B(C c)
    {

        _c = c;
    }
}

// NOT in complaince with ADP
/*public class C
{
    private readonly A _a;
    public C(A a)
    {
        _a = a;
    }
}

public class A
{
    private readonly B _b;
    public A(B b)
    {
        _b = b;
    }
}

public class B
{
    private readonly C _c;
    public B(C c)
    {

        _c = c;
    }
}*/