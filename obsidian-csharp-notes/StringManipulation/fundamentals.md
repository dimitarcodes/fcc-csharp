
## Literals
* `\n` for newline
* `\t` for tab
* `\` for escaping a character like `"`
	* `Console.WriteLine("Hello \"World\"!");`
	* `Console.WriteLine("c:\\source\\repos");`
* `@` for verbatim string literal
```csharp
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
```
results in:
```
c:\source\repos    
        (this is where your code goes)
```
## Variables
* concatenate with `+`
	* `string message = "Hello " + firstName;
	* `string message = greeting + " " + firstName + "!";`

