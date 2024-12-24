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


// SDP watch udemy video
//var f = new F();
var f = new F2();
var S = new S(f);



// SAP watch udemy video



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











// SDP watch udemy video
// depend on interfaces


public class S
{
    //private readonly F _f;
    private readonly IF _f;
    //public S(F f)
    public S(IF f)
    {
        _f = f;
    }
    public void Do()
    {
        _f.Some();
    }
}
//--------------
public interface IF
{
    public void Some();
}
//--------------
//public class F
public class F : IF
{
    public void Some()
    {
        // code..
    }
}
//--------------
public class F2 : IF
{
    public void Some()
    {
        // other code..
    }
}

