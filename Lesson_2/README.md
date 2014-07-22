Lesson 2
================  

##Input and Output
Most programs we work with have some form of input and output for information. We will introduce one of the most simple forms of input and output available to us in C#. 
When we work with basic programs we are often dealing with a text window called the console, this can be command line on Windows, terminal on Mac and many forms 
of Linux, or some other console program altogether. In C# there is a simple way of printing out text to this console and reading in typed input, the syntax for outputting is 
as follows:<br>
```C#
//This outputs Some text to the Console
Console.Write("Some text");

//This Outputs Different text to Console and moves onto a new line
Console.WriteLine("Different text");
``` 
The syntax for input is:<br>
```C# 
String name;
//This reads the users input and stores it in the String name
name = Console.ReadLine();

```