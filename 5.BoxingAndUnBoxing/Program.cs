using System.Collections;

namespace _5.BoxingAndUnBoxing;


// Performans ve yer baximindan duzgun qaydada deyisenlerimiz saxlamaliyiq

// Value type ==> Stack
// Ref   type ==> Heap

// Biz Heap-de Value type saxlamagimiz duzgun deyil. 

// Heap-e Gabbage Collector nezaret edir, Bizde Value type-i Heapde saxlayanda GC yuklemis oluruq.

// Bu da Boxing and UnBoxing zamani bas verir

// Boxing dediyimiz Value type-in Heap-de saxlanilmasidir
// UnBoxing dediyimiz Reference type ( Heap-den ) value type-in alinmasidir.

// Bizde Boxing and UnBoxing calisdigimiz qeder qacmaliyiq


public class Program
{
    static void Main(string[] args)
    {
        // int number = 42;  // Stack
        // 
        // 
        // // Boxing olur. Heapde men Value type saxlayiram
        // object obj = number; // Heap 
        // 
        // Console.WriteLine(obj);
        // 
        // // UnBoxing 
        // int numberUnBoxing = (int)obj;
        // Console.WriteLine(numberUnBoxing);
        // 
        // 
        // Console.WriteLine($"{number}");             // Boxing
        // Console.WriteLine($"{number.ToString()}");  // Not Boxing
        // Console.WriteLine(number); // Best Practice

        // C 2.0 versiyasina qeder

        ArrayList arrayList = new ArrayList();

        arrayList.Add("Kamran");
        arrayList.Add("Xayyam");
        arrayList.Add(27);              // Boxing
        arrayList.Add(DateTime.Now);    // Boxing

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        Stack stack = new Stack();

        stack.Push("Kamran");
        stack.Push("Nicat");
        stack.Push(19);
        stack.Push(DateTime.Now);

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        //  List<int> numbers = new List<int>(); 
        // 
        //  numbers.Add(15);
        //  numbers.Add(25);
        //  numbers.Add(35);
        //  numbers.Add("Kamran"); // Error



    }
}
