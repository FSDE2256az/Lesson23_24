namespace _2.MyIterator;

public class Program
{
    static void Main(string[] args)
    {
        //IEnumerator

        List<int> numbers = Enumerable.Range(5, 10).ToList();

        // foreach (var item in numbers)
        // {
        //     Console.WriteLine(item);
        // }

        // IEnumerator<int> iterator = numbers.GetEnumerator();
        // 
        // while (iterator.MoveNext())
        // {
        //     Console.WriteLine(iterator.Current);
        // }
        // 
        // Console.WriteLine("Yeniden");
        // 
        // iterator.Reset();
        // 
        // while (iterator.MoveNext())
        // {
        //     Console.WriteLine(iterator.Current);
        // }


        IEnumerable<int> collection = Enumerable.Range(5, 10).ToList();

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }


        // Console.WriteLine("Hello, World!");
    }
}
