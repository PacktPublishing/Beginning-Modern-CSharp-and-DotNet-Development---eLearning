using System;
using Person;

namespace Basics 
{ 
	class Program 
	{ 
		static void Main(string[] args) 
		{ 
			//WriteStatement(); 
			SaySomething("Rey");
			Female female = new Female();
			female.Name = "Cindy"; 
			Console.WriteLine($"Her name is {female.Name}");
		} 
		
		// Overloading 
		static void SaySomething() 
		{ 
			Console.WriteLine("I don't even know your name. Don't order me."); 
		} 
		static void SaySomething(string first) 
		{ 
			Console.WriteLine($"Cheers, {first}");
		}
		static void SaySomething(string first, string last) 
		{ 
			Console.WriteLine($"Cheers, {first} {last}"); 
		} 
		/* This method will write a statement * that will impress you. 
		*/ 
		private static void WriteStatement() 
		{ 
			var FirstName = "James"; 
			var LastName = "Bond"; 
			var FullName = FirstName + " " + LastName; 
			Console.WriteLine("My Name is: " + FullName); 
		}
			
	}
}
namespace Person
{
	public class Female
	{
		public string Name { get; set; }
	}
}
