namespace Lesson_11_12_Exception_Abstact.Task.LastVersion;


abstract class Sofa { };
abstract class CoffeeTable {  };
abstract class Chair {  };


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






public class Factory
{
    public Sofa CreateSofa();
    public Chair CreateChair() ;
    public abstract CoffeeTable CreateCoffeeTable();


}
