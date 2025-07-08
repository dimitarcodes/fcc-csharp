
use `$` to initialize string interpolation and `{variable}` to plug vars in strings
```csharp
`string message = $"{greeting} {firstName}!";
```
	* works with all types of variables that implement toString
	* can be combined with the verbatim `@`:
```csharp
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```
results in:
```csharp
C:\Output\First-Project\Data
```
you can mix types and then it will be all string, but put 2 numerical types in brackets and math will execute instead of concatenation:
```csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
```
results in:
```
Bob sold 77 widgets.
Bob sold 14 widgets.
```
`Console.WriteLine` method also supports interpolation through numbered arguments:
```csharp
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
```
results in:
```
World Hello!
Hello Hello Hello!
```

