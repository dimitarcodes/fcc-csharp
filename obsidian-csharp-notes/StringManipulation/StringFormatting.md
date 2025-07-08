## General formatting
Done by adding colon and the type - `{variable:N}`
example formatters:
- `:N` for numbers
- `:P` for percentages
- `:C` for currency
## Formatting numbers
done with `:N` 
- 2 digits after decimal by default
```csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
```
results in
```
Measurement: 123,456.79 units
```
* can change by adding nr of digits after the N - e.g. `{someVariable:N4}`
```csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
```
results in
```
Measurement: 123,456.7891 units
```


```csharp
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
```
results in:
```
Price: € 123,45 (Save € 50,00)
```
where the currency sign was inferred from the OS localization

## Formatting Percentages
- `:P`
- takes into account the fact `10% = 0.1m`
- rounds to 2 decimal places
```csharp
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
```
results in
```
Tax rate: 36.79%
```
## Formatting Currencies
* `:C`
* rounds to 2 decimal places and adds currency sign according to OS localization
```
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
```
results in
```
Price: € 123,45 (Save € 50,00)
```
on my PC which is `en-NL` localized