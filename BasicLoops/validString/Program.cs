string? userInput;
bool validInput = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput = Console.ReadLine();
    string cleanedInput = userInput.Trim().ToLower();
    if (cleanedInput == "administrator" || cleanedInput == "manager" || cleanedInput == "user") validInput = true;
    else Console.WriteLine($"The role that you entered \"{userInput}\" is not valid. Enter your role name (Administrator, Manager or User)");
} while (!validInput);

Console.WriteLine($"Your input value ({userInput}) has been accepted.");