DemoFunc.PrintHelloWorld();
// TestFloatPoint();
// ControlFlowIf();
// ControlFlowLoop();
// ThereIsAList();
// ChineseStrSort();
// LinqTest();
// TestOop();

class DemoFunc
{
    public static void PrintHelloWorld()
    {
        var hello = "   Hello, World.";
        hello = hello.Trim();
        Console.WriteLine(hello);

        Console.Write("What's your name: ");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}.");

        Console.WriteLine($"string replace test: {hello.Replace("llo", "[wow]")}");

        Console.WriteLine(Environment.NewLine + "Press any key to exit...");
        Console.ReadKey(true);
    }

    public static void TestFloatPoint()
    {
        // double or float(suffix F) will be inaccurate
        decimal a = 3.1M;
        decimal b = 3.2M;
        decimal sum = checked(a + b);
        Console.WriteLine($"sum: {sum}, max of decimal is: {decimal.MaxValue}");
        Console.WriteLine($"max of double is {double.MaxValue}");
    }

    public static void ControlFlowIf()
    {
        // |(Logical OR operator) will execute the second operand, even the first operand is false.
        // but ||(Conditional logical OR operator) will stop at the false one.
        if (true || true)
        {
            Console.WriteLine("the if block is True");
        }
    }

    public static void ControlFlowLoop()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"for loop, idx: {i}");
        }
    }

    public static void ThereIsAList()
    {
        var li = new List<int> { 1, 2, 4, 8 };
        li.Add(16);
        li.Add(0);

        li.Sort();
        Console.WriteLine($"the index of 0: {li.IndexOf(0)}");
        foreach (var i in li)
        {
            Console.Write($"{i} ");
        }
        Console.Write(Environment.NewLine);
    }

    public static void ChineseStrSort()
    {
        var li = new List<string> { "奶茶", "蜘蛛", "可怕的蜘蛛奶茶 (O.O;)!" };
        li.Sort();
        foreach (var i in li)
        {
            Console.Write($"{i}， ");
        }
        Console.Write(Environment.NewLine);
    }

    public static void LinqTest()
    {
        List<int> a = [1, 2, 4, 8];
        // ???????? LINQ
        // Microsoft magic!!?
        // https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/
        IEnumerable<int> query =
            from aTmp in a
            where aTmp > 2
            orderby aTmp descending
            select aTmp;

        foreach (int i in query)
            Console.Write($"{i} ");
        Console.Write(Environment.NewLine);
    }

    public static void TestOop()
    {
        var peo = new People("Lemon", 1000);
        peo.IdNum = 0;
        Console.WriteLine($"people id is: {peo.IdNum}");
    }
}

class People(string name, int id)
{
    public string Name { get; set; } = name;
    public int IdNum { get; set; } = id;
}
