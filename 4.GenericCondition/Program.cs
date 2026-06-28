namespace _4.GenericConstraint;

// Constraint => mehdudiyyet vermekdir

// Yeni T-e mueyyen sertler vermekdir

// Human
// Student : Human
// Dog : Animal

// customClass<T> where T: Human

// Constraint

// 1. Struct                => ancaq value type gondere bilersen
// 2. Class                 => ancaq referance type gondere bilersen
// 3. new                   => Objecti yarana bilen bir sey ( abstact, interface, delegate )
// 4. Base class Name       => ancaq base class-dan torenenleri gondere bilerik
// 5. Base interface name   => hemin interface-den implimentation etmisleri gondere bilerik
// 6. T : U                 => T U nun base class-i olmalidr

// Arasdirma kimi

// 7. Unmanaged
// 8. not null
// 9. default


class BaseForValue<T> where T : struct
{
    public void Foo()
    {
        Console.WriteLine("Base Foo function called");
    }
}

class Base<T> where T : class, new()
{
    public void Foo()
    {
        Console.WriteLine("Base Foo function called");
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

interface ISpeak { }
abstract class Human { }

class Person<T> where T : Human, ISpeak, new()
{
    public void Boo()
    {
        Console.WriteLine(" Person Boo function called");
    }
}

class Teacher : Human, ISpeak
{
    public int Id { get; set; }
    public string Name { get; set; }
}





public class Program
{
    static void Main(string[] args)
    {
        var baseclassForValue = new BaseForValue<DateTime>();


        var baseclass = new Base<Student>();


        var person = new Person<Teacher>();


    }
}
