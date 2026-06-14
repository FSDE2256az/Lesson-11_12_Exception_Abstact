using Lesson_11_12_Exception_Abstact.Task.FirstVersion;
using Lesson_11_12_Exception_Abstact.Task.SecondVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_12_Exception_Abstact.Task.ThirdVersion;


public class VictorianFactory
{
    public string ModelName { get; set; }

    public VictorianFactory(string modelName)
    {
        ModelName = modelName;
    }

    public object CreateSofa()
    {
        if (ModelName == "Victorian")
            return new VictorianSofa();

        else if (ModelName == "ArtDeco")
            return new ArtDecoSofa();

        else
            return new ModernSofa();

    }

    public object CreateChair()
    {
        if (ModelName == "Victorian")
            return new VictorianChair();

        else if (ModelName == "ArtDeco")
            return new ArtDecoChair();

        else
            return new ModernChair();
    }

    public object CreateCofeeTable()
    {
        if (ModelName == "Victorian")
            return new VictorianCoffeeTable();

        else if (ModelName == "ArtDeco")
            return new ArtDecoCoffeeTable();

        else
            return new ModernCoffeeTable();
    }

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
