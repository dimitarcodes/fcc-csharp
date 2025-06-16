string? readInput;
int inputInteger;
bool validInput = false; 

Console.WriteLine("Please enter an integer between 5 and 10");
do
{
    readInput = Console.ReadLine();

    validInput = int.TryParse(readInput, out inputInteger);

    if (validInput)
    {
        if (inputInteger < 5 || inputInteger > 10)
        {
            Console.WriteLine($"You entered {inputInteger}. Please enter a number between 5 and 10.");
            validInput = false;
        }
    } else {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (!validInput);

Console.WriteLine($"Your input value ({inputInteger}) has been accepted.");

for (int i = 0; i < inputInteger; i++)
{
    int blankspace = inputInteger - 1 - i;
    for (int blanki = 0; blanki < blankspace; blanki++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    for (int stari = 0; stari < i * 2; stari++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}