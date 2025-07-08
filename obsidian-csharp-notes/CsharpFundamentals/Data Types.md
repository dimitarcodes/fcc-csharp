Most often used datatypes:

| type      | example   | description                                                   |
| --------- | --------- | ------------------------------------------------------------- |
| `bool`    | `true`    | boolean                                                       |
| `int`     | `42`      | integer                                                       |
| `float`   | `0.25f`   | floating point (6-9 digits precision)                         |
| `double`  | `2.625`   | floating point (15-17 digits precision) - default fp datatype |
| `decimal` | `12.398m` | floating point (28-29 digits precision) - scientific accuracy |
| `char`    | `'b'`     | single character, note the `'` single quote                   |
| `string`  | `"brat"`  | multiple characters, note the `"` double quotes               |

## Variables
* declared with data type, like in java:
```csharp
string firstName;
firstName = "rattingson";
Console.WriteLine(firstName);
```
- can start with:
	- alphabetical letter
	* the underscore character
	* NOT A NUMBER
* can also contain:
	* a number
* can NOT contain:
	* Special characters like the hash symbol `#` or dollar symbol `$`
- are case-sensitive (meaning that `string Value;` and `string value;` are two different variables)
- Variable names must **not** be a C# keyword. For example, you cannot use the following variable declarations: `decimal decimal;` or `string string;`
- check [[NamingConvention]] for more info
## Constants / Literals
- hard coded, don't change
* usually values you use instantly, e.g.
	* in `Console.WriteLine("rat")` the `"rat"` is a `string` literal
	* in `Console.WriteLine('b')` the `'b'` is a `char` literal
	* in  `Console.WriteLine(123);` the `123` is an `int` literal - keep in mind if its sufficiently high it will throw error since integers are limited to 32/64 bits
	* same logic goes for these floating-point literals:
		* float (6-9 digits precision)  `Console.WriteLine(0.25F);`
		* double (15-17 digits precision) `Console.WriteLine(2.625);`
		* decimal (28-29 digits precision) `Console.WriteLine(12.39816m);



## Implicitly typed variables

C# supports implicit typing using the `var` keyword  - that lets the compiler infer the type from the data assigned to it.

```csharp
var message = "Hello World!";
```

will make the compiler infer `string` as the type. subsequent assignments of another type will fail:

```csharp
var message = "Hello World!";
message = 10.703m;
```
will result in:
```csharp
(2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'
```
implicit vars can't be initialized without value:
```csharp
var message;
message = "Hello World!";
```
IS NOT ALLOWED and will throw:
```
(1,5): error CS0818: Implicitly-typed variables must be initialized