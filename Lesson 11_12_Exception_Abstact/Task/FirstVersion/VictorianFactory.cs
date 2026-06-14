namespace Lesson_11_12_Exception_Abstact.Task.FirstVersion;

public class VictorianFactory
{
    public VictorianSofa CreateVictorianSofa() => new VictorianSofa();
    public VictorianChair CreateVictorianChair() => new VictorianChair();
    public VictorianCofeeTable CreateVictorianCofeeTable() => new VictorianCofeeTable();

}


public class VictorianSofa
{
    public int Id { get; set; }
    public int Width { get; set; }
    public int Heigth { get; set; }
    public int Length { get; set; }
    public ConsoleColor Color { get; set; }

    public VictorianSofa()
    {
        Console.WriteLine("Victorian Sofa");
    }
}

public class VictorianChair
{
    public int Id { get; set; }
    public int Width { get; set; }
    public int Heigth { get; set; }
    public int Length { get; set; }
    public ConsoleColor Color { get; set; }

    public VictorianChair()
    {
        Console.WriteLine("Victorian Chair");
    }
}


public class VictorianCofeeTable
{
    public int Id { get; set; }
    public int Width { get; set; }
    public int Heigth { get; set; }
    public int Length { get; set; }
    public ConsoleColor Color { get; set; }

    public VictorianCofeeTable()
    {
        Console.WriteLine("Victorian Cofee Table");
    }
}