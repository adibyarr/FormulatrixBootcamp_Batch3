class Program
{
    static void Main(string[] args)
        {
        
        FirstPlayer atbA = new FirstPlayer("James");
        SecondPlayer atbB = new SecondPlayer("Durant");
        ThirdPlayer atbC = new ThirdPlayer("Curry");

    
        Console.WriteLine(atbA.name);
        Console.WriteLine(atbA.Speech());
        atbA.BeGodPlay();
        atbA.Basket();
        
        Console.WriteLine(atbB.name);
        Console.WriteLine(atbB.Speech());
        atbB.BeGodPlay();

        Console.WriteLine(atbC.name);
        atbC.BeGodPlay();
        atbC.Basket();
        }
}

public interface IBasket
{
    void Basket();
}
abstract class Parent   
{
    public string? name;
    abstract public void BeGodPlay();

    public Parent(string name)
    {
        Console.WriteLine("parent constructor called name : " + name);
        this.name = name;
    }
    public virtual string Speech()
    {
        return ("Be a god play");
    }
}

class FirstPlayer : Parent , IBasket
{
    public FirstPlayer(string name) : base(name)
    {
        Console.WriteLine("child constructior callad name : " + name);
    }

    public override void BeGodPlay()
    {
        Console.WriteLine("Train make you perfect");
    }

    //tidak bisa menambahkan fungsi yang tidak ada dalam orang tuanya
    public override string Speech()
    {
        return ("Road to be a king");
    }

    public void Basket()
    {
        Console.WriteLine("Jump High");
    }
}

class SecondPlayer : Parent
{
    public SecondPlayer(string name) : base(name)
    {
        Console.WriteLine("child constructior callad name : " + name);
        this.name = name;
    }

    public override void BeGodPlay()
    {
        Console.WriteLine("DUNKKK");
    }

    public override string Speech()
    {
        return ("Truee kingg");
    }
}

class ThirdPlayer : Parent, IBasket
{
    public ThirdPlayer(string name) : base(name)
    {
        Console.WriteLine("child constructior callad name : " + name);
        this.name = name;
    }
    public override void BeGodPlay()
    {
        Console.WriteLine("GodPlay");
    }

    public void Basket()
    {
        Console.WriteLine("Love Basket");
    }
}