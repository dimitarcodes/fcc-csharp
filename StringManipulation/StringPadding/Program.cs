class StringPadding
{
    public static void Main(string[] args)
    {
        ex2();
    }
    static void ex1()
    {
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));
        Console.WriteLine(input.PadRight(12, 'L'));
    }

    static void ex2()
    {
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName}");
        Console.WriteLine($"As a customer of our {currentProduct}  offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N} sjares at a return of {currentReturn:P}\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage += currentProduct.PadRight(20) + currentReturn.ToString("P").PadRight(10) + currentProfit.ToString("C") + "\n";
        comparisonMessage += newProduct.PadRight(20) + newReturn.ToString("P").PadRight(10) + newProfit.ToString("C") + "\n";

        Console.WriteLine(comparisonMessage);
    }
}