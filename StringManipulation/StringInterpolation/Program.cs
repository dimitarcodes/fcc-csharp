class StringInterpolation
{
    static void Main(string[] args)
    {
        ex2();
    }

    static void ex1()
    {
        string firstName = "John";
        string lastName = "Doe";
        Console.WriteLine($"My name is {firstName} {lastName}.");
    }

    static void ex2() {
        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
    }

    static void ex3() {
        string first = "Hello";
        string second = "World";
        Console.WriteLine("{1} {0}!", first, second);
        Console.WriteLine("{0} {0} {0}!", first, second);
    }

}
