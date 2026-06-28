using _3.Generic.Models;

namespace _3.Generic;

interface IRequest { }
interface IRequest<T> { }

interface IRequest<T, TResult> { }


class Base { }
class Base<T> { }
class Base<T1, T2> { }

struct Point { }
struct Point<T> { }

delegate void SomeDelegate<T>();

record MyRecord<T> { }


public class Program
{
    static void Main(string[] args)
    {
        var genericClass = new GenericClass<int>();

        genericClass.Data = 42;

        Console.WriteLine(genericClass.Data);

        genericClass.Foo();

        genericClass.Foo<string>();
    }
}
