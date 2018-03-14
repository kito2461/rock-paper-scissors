/*
 * Created by SharpDevelop.
 * User: 0256080
 * Date: 3/14/2018
 * Time: 10:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Rock__Paper__Scissors
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Rock, Paper, Scissors");
			Console.ReadLine();
			Console.WriteLine("Make your choice:");
			gameFunc();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void gameFunc()
			{
			Random rand = new Random();
			
			string rock = "ROCK";
			string paper = "PAPER";
			string scissors = "SCISSORS";
			string choice = Console.ReadLine();
			
			int random = rand.Next(1, 4);
			choice = choice.ToUpper();
			
			switch (random) 
				{
				case 1:
					if (choice == rock)
					{
						Console.WriteLine(choice +  " <- you vs. us -> " + rock + ".");
						Console.WriteLine("It's a tie.");
					}
					else if(choice == paper)
					{
					Console.WriteLine(choice +  " <- you vs. us -> " + rock + ".");
						Console.WriteLine("You win!");
					}
					else if(choice == scissors)
					{
					Console.WriteLine(choice +  " <- you vs. us -> " + rock + ".");
						Console.WriteLine("You lose...");
					}
					else
					{
						Console.WriteLine(choice + " is not a choice.");
					}
					break;
					
					
				case 2:
					if (choice == rock)
					{
						Console.WriteLine(choice +  " <- you vs. us -> " + paper + ".");
						Console.WriteLine("You lose...");
					}
					else if(choice == paper)
					{
					Console.WriteLine(choice +  " <- you vs. us -> " + paper + ".");
						Console.WriteLine("It's a tie.");
					}
					else if(choice == scissors)
					{
					Console.WriteLine(choice +  " <- you vs. us -> " + paper + ".");
						Console.WriteLine("You win!");
					}
					else
					{
						Console.WriteLine(choice + " is not a choice.");
					}
					break;
					
				default:
					if (choice == rock)
					{
						Console.WriteLine(choice +  " <- you vs. us -> " + scissors + ".");
						Console.WriteLine("You win!");
					}
					else if(choice == paper)
					{
					Console.WriteLine(choice +  " <- you vs. us -> " + scissors + ".");
						Console.WriteLine("You lose...");
					}
					else if(choice == scissors)
					{
					Console.WriteLine(choice +  " <- you vs. us -> " + scissors + ".");
						Console.WriteLine("It's a tie.");
					}
					else
					{
						Console.WriteLine(choice + " is not a choice.");
					}
					break;
				}
			
			Console.ReadLine();
			}
	}
}