# _WordCounter_

#### _C# Word Counter_, _Mar. 6, 2020_

#### By _**Zakkrey Short**_

## Description

_This application counts a user inputted word and sentence then states the number of times the word appears in a sentence. By;_
* Taking word and store as string
* Taking sentence and store as string
* Remove punctuation and special characters from sentence string using stringbuilder
* Return the total amount of times the word shows up within the sentence
* Ask if you would like to go again

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| a word is entered into console | RepeatCounter.AcceptWord("Input") | "Input" |
| a sentence is entered | RepeatCounter.AcceptSentence("This is an example sentence") | "This is an example sentence" |
| punctuation of the sentence is removed | RepeatCounter.RemovePunctuation("This! is, an ;example ?sentence") | "This is an example sentence" |
| console checks to see how many instances of word appear in sentence | RepeatCounter.CompareWord("hello", "hello, this is! hello HEllo jello, mello hello") | return 2 instances of "hello" |
| console ignores if word is within word | RepeatCounter.CompareWord("hello", "hello, mahalla mhellos to say hello to yous.") | return 2 instances of hello |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd`` followed by the repository name.

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Zakkrey Short_**