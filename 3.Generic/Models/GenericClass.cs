namespace _3.Generic.Models;

public class GenericClass<T>
{
    public T Data { get; set; }
    public string Name { get; set; }




    public T Foo()
    {
        T temp = default!;

        Console.WriteLine(temp);

        return temp;
    }

    public T Foo<Tmethod>()
    {
        T temp = default!;
        Tmethod tempMethod = default!;

        Console.WriteLine(temp);
        Console.WriteLine(tempMethod);

        return temp;
    }


}
