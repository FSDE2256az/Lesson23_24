namespace _1.YieldReturn;


// 1 method eyni zamanda coxlu cavab qaytarmak ucun istifade edilir


public class Program
{
    static IEnumerable<int> ExampleYieldReturn()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }


    static IEnumerable<int> GetEvenNumbers(int max)
    {
        for (int i = 1; i < max; i++)
        {
            if (i % 2 == 0)
                yield return i;
        }
    }

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // var data = ExampleYieldReturn();
        // 
        // foreach (var item in data)
        // {
        //     Console.WriteLine(item);
        // }

        var collection = GetEvenNumbers(100);

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

    }
}
