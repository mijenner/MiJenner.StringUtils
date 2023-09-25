# MiJennerStringUtils
StringUtils is a cross-platform C# .NET class library for modifying strings. 

* ```CountWords(string input)``` Counts words in a string. 
* ```ReplaceSpecialCharactersWithNothing(string input)``` Removes special characters from string. 
* ```ReplaceSpecialCharactersWithSpace(string input)```Replaces special characters with space. 
* ```IsBinaryString(string input)``` Check if string contains only 0's and 1's (characters). 
* ```IsNumeric(string input)``` Check if string contains numerics only. 
* ```RemoveWhitespace(string input)``` Removes whitespaces, i.e. space, tabs, newlines, carriage returns. 

# Method signatures 
```public static int CountWords(string input)```
```public static string ReplaceSpecialCharactersWithNothing(string input)```
```public static string ReplaceSpecialCharactersWithSpace(string input)```
```public static bool IsBinaryString(string input)```
```public static bool IsNumeric(string input)```
```public static string RemoveWhitespace(string input)```

# Examples 

Remember to add using: 
```using MiJenner; ```

Examples: 

```cs
string str = @"""Rockets are cool. There’s no getting around that."" – Elon Musk";
Console.WriteLine(str);
Console.WriteLine("Words in above: " + StringUtils.CountWords(str));
```
