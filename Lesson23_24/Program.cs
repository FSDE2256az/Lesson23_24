namespace Lesson23_24;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int number = 5;

        var student = new Student();

        student.Foo(42);

    }
}




class Student
{
    // Heap
    public int Id { get; set; }
    public string Name { get; set; }


    public int Foo(int number)
    {
        // Stack
        int number2 = number + 15;

        return number2;
    }

}



