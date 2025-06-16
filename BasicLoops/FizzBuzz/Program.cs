for (int i = 1; i < 100; i++)
{
    string printFizzBuzz = "";
    if (i % 3 == 0)
    {
        printFizzBuzz += "Fizz";
    }
    if (i % 5 == 0)
    {
        printFizzBuzz += "Buzz";
    }
    if (i % 3 != 0 && i % 5 != 0)
    {
        printFizzBuzz += i;
    }
    Console.WriteLine(printFizzBuzz);
    
}