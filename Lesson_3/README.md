Lesson 3
================  

##Methods
Say you have something that you want to do in lots of different places in your program, getting the square of a number for example.
Methods give you a way of writing that code once instead of every time you want to square something.
```C#
return_type method_name (parameters){
	//code
	return value;
}
```
Now that will probably look confusing if it is your first encounter with them, don't worry if you don't understand. The layout was
shown above to make it easier to explain how methods work. First lets talk about the parameters, parameters are variables that a
function requires when it is called.
```C#
void printNum(int number){
	Console.WriteLine(number);
}

//Main method is where the program always starts
int Main(){
	//calling the method
	printNum(7);
	//Will print 7
}
```
Return type, every function in C# has a return type which the method must give a value for. These values are sent back by the return
statement:
```C#
int sum(int x, int y){
	return x + y;
}

int Main(){
	Console.Write("Please enter a number: ");
	int x = int.Parse(Console.ReadLine());
	Console.Write("Please enter a number: ");
	int y = int.Parse(Console.ReadLine());
	//calling the method
	int s = sum(x, y);
	Console.WriteLine(x " + " + y + " = " + s);
	//will print the sum of the two numbers the user enters
}
```

##Control Statements
All we have done so far is very linear, your code makes no choices and always runs the same set of instructions. When you are programming
you will constantly want the program to do one thing under one condition and another under different conditions. There are three main ways
of doing this in C#.
###if


###else


###switch
