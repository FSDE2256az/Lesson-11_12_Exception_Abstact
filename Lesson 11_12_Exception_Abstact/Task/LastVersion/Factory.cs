namespace Lesson_11_12_Exception_Abstact.Task.LastVersion;


abstract class Sofa { };
abstract class CoffeeTable {  };
abstract class Chair {  };
abstract class Wheel { };

class VictorianWheel : Wheel
{
    public VictorianWheel()
    {
        Console.WriteLine("VictorianWheel");
    }
}


class VictorianSofa : Sofa
{
    public VictorianSofa()
    {
        Console.WriteLine("VictorianSofa");
    }
}

class ModernSofa : Sofa
{
    public ModernSofa()
    {
        Console.WriteLine("ModernSofa");
    }
}

class ArtDecoSofa: Sofa
{
    public ArtDecoSofa()
    {
        Console.WriteLine("ArtDecoSofa");
    }
}


class VictorianCoffeeTable : CoffeeTable
{
    public VictorianCoffeeTable()
    {
        Console.WriteLine("VictorianCoffeeTable");
    }
}

class ModernCoffeeTable : CoffeeTable
{
    public ModernCoffeeTable()
    {
        Console.WriteLine("ModernCoffeeTable");
    }
}

class ArtDecoCoffeeTable : CoffeeTable
{
    public ArtDecoCoffeeTable()
    {
        Console.WriteLine("ArtDecoCoffeeTable");
    }
}


class VictorianChair: Chair
{
    public VictorianChair()
    {
        Console.WriteLine("VictorianChair");
    }
}

class ModernChair : Chair
{
    public ModernChair()
    {
        Console.WriteLine("ModernChair");
    }
}

class ArtDecoChair : Chair
{
    public ArtDecoChair()
    {
        Console.WriteLine("ArtDecoChair");
    }
}


abstract class Factory
{
    public abstract Sofa CreateSofa();
    public abstract Chair CreateChair() ;
    public abstract CoffeeTable CreateCoffeeTable();
    public abstract Wheel CreateWheel();
}


class VictorianFactory : Factory
{
    public override Chair CreateChair() => new VictorianChair();

    public override CoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

    public override Sofa CreateSofa() => new VictorianSofa();

    public override Wheel CreateWheel() => new VictorianWheel();
}


class ArtDecoFactory : Factory
{
    public override Chair CreateChair() => new ArtDecoChair();

    public override CoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

    public override Sofa CreateSofa() => new ArtDecoSofa();
}

class ModernFactory : Factory
{
    public override Chair CreateChair() => new ModernChair();

    public override CoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    public override Sofa CreateSofa() => new ModernSofa();
}