Lesson 3
================  

##Methods
Say you have something that you want to do in lots of different places in your program, getting the square of a number for example.
Methods give you a way of writing that code once instead of every time you want to square something.
```C#
return_type method_name (parameters){
	\\code
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
	//calling the method
	int s = sum(7, 11);
	Console.WriteLine(s);
	//will print 18
}
```

##Control Statements
