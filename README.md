# Leet Speak Translator

#### A program that translate a user-entered phrase into leet speak.

#### By **Tessa Sullivan**

## Description
A user enters: a string and then receives a string with certain letters replaced by numbers or symbols.  Replacements are:
* "e" should be replaced with "3".
* "o" should be replaced with "0".
* Capital (not the lowercase "I" should be replaced with "1".
* "t" should be replaced with "7".
* "s" should be replaced with "z", unless it is the first letter of a word.



### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| e replaced, regardless of case | user enters: e| program outputs: 3|
| e replaced, regardless of case | user enters: E| program outputs: 3|
| o replaced, regardless of case | user enters: o| program outputs: 0|
| o replaced, regardless of case | user enters: O| program outputs: 0|
| t replaced, regardless of case | user enters: t| program outputs: 7|
| t replaced, regardless of case | user enters: T| program outputs: 7|
| I replaced | user enters: I | program outputs: 1|
| i not replaced | user enters: i | program outputs: i|
| s replaced when not at the beginning of the word, regardless of case | user enters: as | program outputs: az|
| s replaced when not at the beginning of the word, regardless of case | user enters: aS | program outputs: az|
| s not replaced when at the beginning of a regular word | User enters: say | program outputs: say|
| s not replaced when at the beginning of a quoted word | User enters: 'say (the word say preceded with a single quote)| program outputs: 'say|
| All rules followed when a longer string is entered | user enters: Don't you love these 'String' exercises? I do!| program outputs: D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!|



## Setup/Installation Requirements

Currently does not include Program.cs so it cannot be run directly from the command line.  Tests can be run by doing the following:
1. Install .Net 2.2 
    * Go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and download the appropriate installer for your OS.
2. cd to repo directory
3. On the command line, run:
    * dotnet test LeetSpeak.Tests

## Known Issues
* No known issues at this time

## Technologies Used

* C#

## Support and contact details

_Contact Tessa Sullivan @ tessa.sullivan@gmail.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_Tessa Sullivan_**