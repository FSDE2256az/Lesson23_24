namespace _2.MyIterator;

public class Program
{
    static void Main(string[] args)
    {
        //IEnumerator

        List<int> numbers = Enumerable.Range(5, 20).ToList();

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("Hello, World!");
    }
}
