using System.Collections;

namespace _6._Collection;

// Collection => Melumat toplusu

// 1. Non Generic Collection ( ArrayList, Stack, Queue, HashTable )
// 2. Generic Collection ( List<T>, Stack<T>, Queue<T> )
// 3. Concurent => Thread Safety Collection ( Threadler kecende oyreneceyik )


public class Program
{
    static void Main(string[] args)
    {
        // // Non Generic Collection


        //  ArrayList arrayList = new ArrayList();
        // 
        //  arrayList.Add("Kamran");
        //  arrayList.Add("Xayyam");
        //  arrayList.Add(27);              // Boxing
        //  arrayList.Add(DateTime.Now);    // Boxing
        // 
        //  foreach (var item in arrayList)
        //  {
        //      Console.WriteLine(item);
        //  }
        // 
        //  Stack stack = new Stack();
        // 
        //  stack.Push("Kamran");
        //  stack.Push("Nicat");
        //  stack.Push(19);
        //  stack.Push(DateTime.Now);
        // 
        //  foreach (var item in stack)
        //  {
        //      Console.WriteLine(item);
        //  }
        // 
        // 
        //  Queue queue = new Queue();
        // 
        //  queue.Enqueue("Kamran");
        //  queue.Enqueue("Xayyam");
        //  queue.Enqueue(15);
        //  queue.Enqueue(25);
        // 
        //  foreach (var item in queue)
        //  {
        //      Console.WriteLine(item);
        //  }
        // 
        //  Console.WriteLine("Hello, World!");

        // // Generic Collection

        // List<int> numbers = new List<int>();
        // 
        // numbers.Add(1);
        // numbers.Add(2);
        // numbers.Add(3);
        // numbers.Add(4);
        // numbers.Add(5);
        // 
        // Console.WriteLine(numbers.Capacity);
        // Console.WriteLine(numbers.Count);
        // 
        // Dictionary<int, string> dict = new Dictionary<int, string>();
        // 
        // dict.Add(41, "Lacin");
        // dict.Add(60, "Tovuz");
        // dict.Add(44, "Masalli");
        // dict.Add(42, "Lenkeran");
        // dict.Add(5, "Agstafa");
        // dict.Add(8, "Balaken");
        // dict.Add(18, "Sirvan");
        // dict.Add(15, "Celilabad");
        // dict.Add(35, "Qazax");
        // 
        // 
        // foreach (var item in dict)
        // {
        //     Console.WriteLine(item.Key);
        //     Console.WriteLine(item.Value);
        // }


        List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 5 };

        var data = myList.ToHashSet();

        Console.WriteLine($"Count: {data.Count}");

        List<Person> people = new List<Person>()
        {
            new Person(){ Id  = 1, Name  = "Kamran"}, 
            new Person(){ Id  = 1, Name  = "Kamran"}, 
            new Person(){ Id  = 3, Name  = "Kamran"},
            new Person(){ Id  = 4, Name  = "Kamran"},
        };

        var data2 = people.ToHashSet();
        Console.WriteLine($"Count: {data2.Count}");


        // HashSet<int> hashSet = new HashSet<int>(); // Unique olur
        // 
        // // Datalar HashCode-da saxlanilir
        // 
        // 
        // hashSet.Add(15);
        // hashSet.Add(25);
        // hashSet.Add(35);
        // hashSet.Add(15);
        // 
        // foreach (var item in hashSet)
        // {
        //     Console.WriteLine(item);
        // }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
