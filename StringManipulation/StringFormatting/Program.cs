class StringFormatting
{
    static void Main(string[] args)
    {
        ex1();
        ex2();
        ex3();
    }

    static void ex1()
    {
        //formatting numbers
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");
        Console.WriteLine($"Measurement: {measurement:N4} units");
    }

    static void ex2() {
        // formatting percentages
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
    }

    static void ex3() {
        //formatting currency
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");
    }

}


