using Lesson_11_12_Exception_Abstact.Task.FirstVersion;

namespace Lesson_11_12_Exception_Abstact.Task.SecondVersion;

public class VictorianFactory
{
    public VictorianSofa CreateVictorianSofa() => new VictorianSofa();
    public VictorianChair CreateVictorianChair() => new VictorianChair();
    public VictorianCofeeTable CreateVictorianCofeeTable() => new VictorianCofeeTable();

    public ModernSofa CreateModernSofa() => new ModernSofa();
    public ModernChair CreateModernChair() => new ModernChair();
    public ModernCoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    public ArtDecoSofa CreateArtDecoSofa() => new ArtDecoSofa();
    public ArtDecoChair CreateArtDecoChair() => new ArtDecoChair();
    public ArtDecoCoffeeTable CreateArtDecoCoffeeTable() => new ArtDecoCoffeeTable();


}

public class VictorianSofa { }
public class VictorianChair { }
public class VictorianCoffeeTable { }

public class ModernSofa { }
public class ModernChair { }
public class ModernCoffeeTable { }

public class ArtDecoSofa { }
public class ArtDecoChair { }
public class ArtDecoCoffeeTable { }
