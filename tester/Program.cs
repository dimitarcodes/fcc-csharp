string rat = "4.123456789";
decimal imp;
bool success = decimal.TryParse(rat, out imp);
Console.WriteLine(imp);