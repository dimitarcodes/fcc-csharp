## Variables
Variable names should:
* use **camel case** e.g `string thisIsCamelCase;`
- begin with an alphabetical letter or underscore
	- underscore for private vars probably
- be one or more entire words appended together. Don't use contractions or abbreviations because the name of the variable (and therefore, its purpose) may be unclear to others who are reading your code.
- **NOT** include the data type of the variable. You might see some advice to use a style like `string strValue;`. That advice is no longer current.
- be descriptive and meaningful in your app. Choose a name for your variable that represents the kind of data it will hold.
### examples
```csharp
char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;
```
## Constants
Constant names should:
- be all caps ? - I'm guessing