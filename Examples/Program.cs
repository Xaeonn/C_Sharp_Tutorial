using System;
using System.Collections.Generic;

//namespace allows you to group things accros several files
namespace Examples
{
	class MainClass
	{
		//Main is the method (function) that is run when the program starts in any C# program
		public static void Main ()
		{
			//basic variable types
			//integer (whole number)
			int numberA = 5;
			//floating point number (decimal)
			float numberB = 4.2f;
			//single character eg. a letter or !,@,£ etc
			char letter = 'a';
			//a series of characters
			string word = "Hello";
			//a true or false 
			bool exists = false;

			//print something to Console
			Console.WriteLine ("Examples");
			//print a variable and some text to the console
			Console.WriteLine ("numberA = " + numberA);


			//conditions
			//if something is true do something
			if (numberB == 4.2f) {
				Console.WriteLine ("True");
			} 
			//otherwise do something else
			else {
				Console.WriteLine ("False");
			}

			//loops
			//while something is true keep doing something
			while (numberA < 10) {
				Console.WriteLine ("numberA is " + numberA);
				//increment numberA by one
				numberA++;
			}

			//set a starting variable, keep doing it while it meets a condition, change the variable in some way every time it loops
			for (int i = 0; i < 10; i++) {
				Console.WriteLine ("i = " + i);
			}

			//call the sum method with 4 and 5 and print the result
			Console.WriteLine ("5 + 4 = " + sum (5, 4));


			//Create instance of Person object (class) called S and initializes it to have the name Sam Boles and age 21
			//Look at Person.cs file then come back here
			Person S = new Person ("Sam", "Boles", 21);

			//Prints the ToString from Person
			Console.WriteLine (S);

			//Prints age of S
			Console.WriteLine (S + " is " + S.Age + " years old");

			//calls method hasBirthday on Person S
			S.hasBirthday ();

			//prints age again
			Console.WriteLine (S + " is " + S.Age + " years old");

			//creates Person B and makes them equal to S
			Person B = S;

			//prints out B
			Console.WriteLine (B);

			//changes name in B
			B.Name = "Bee";

			//Print B again
			Console.WriteLine (B);

			//Prints S
			//Look at the output then read comment below
			Console.WriteLine (S);
			//The result is Bee Boles instead of Sam Boles despite only changing this in B and not in S
			//the reason for this is because objects are a thing called reference types
			//reference types copy a reference (kind of like a website address) to the object when one object is put = another
			//this means that when you change the value in one it changes in any copies of it because they are all the same 
			//actual object (Say a website has multiple addresses and you change the content all the addresses now point to 
			//the new content)

			//creates ComplexNumber x and initializes it with a real value of 4.2 and an imaginary value of 3
			ComplexNumber x = new ComplexNumber (4.2f, 3f);

			//Prints out x
			Console.WriteLine ("x = " + x);

			//Creates second complexNumber y
			ComplexNumber y = new ComplexNumber (3.3f, 5f);

			//prints out y
			Console.WriteLine ("y = " + y);

			//makes y equal to y + x
			y = y + x;

			//prints out new value of y
			Console.WriteLine ("x + y = " + y);

			//creates new complexNumber z and makes it equal to y
			ComplexNumber z = y;

			//prints z
			Console.WriteLine ("z = " + z);

			//sets the real part of z to 1
			z.Real = 1f;

			//prints out new z
			Console.WriteLine ("z = " + z);
			//prints out y
			Console.WriteLine ("y = " + y);
			//notice y hasn't changed even though we changed z after making it a copy of y
			//this is because structs are what we call data types
			//data types copy the values instead of the location of the values
			//this is very useful in mathematical programs and games



		}

		//a method to add two integers together
		//static means that the method can be called without needing an instance of the object to use
		static int sum(int a, int b)
		{
			//return sends back a value to the place it was called
			return a + b;
		}
	}
}
