using System;

namespace Capstone_2___Task_Challenge
{
	class Program
	{
		static bool goAgain = true;
		static void Main(string[] args)
		{  
			while (goAgain)
			{
				PrintOptions();

				string userInput = GetUserInput("Choose one of the 5 options: ");
				
				SelectMenuOption(userInput);
			} 
			Console.WriteLine("Have a great day!");
		}

		public static void SelectMenuOption(string userInput)
		{
			switch (userInput)
			{
				case "1":
				case "list tasks":
					Task.DisplayTasks();
					break;
				case "2":
				case "Add Task":
					CreateTask();
					//Add Task Method
					break;
				case "3":
				case "Delete task":
					RemoveTask();
					//Delete Task Method
					break;
				case "4":
				case "mark task complete":
					WhichTask();
					//Mark Task Complete
					break;
				case "5":
				case "Quit":
					goAgain = false;
					break;
				default:
					SelectMenuOption("That is not an option, please select again.");
					break;
			}
		}
		public static string GetUserInput(string message)
		{
			Console.WriteLine(message);
			return Console.ReadLine();
		}
		public static void PrintOptions()
		{
			Console.WriteLine("1. List Tasks");
			Console.WriteLine("2. Add Task");
			Console.WriteLine("3. Delete Task");
			Console.WriteLine("4. Mark task complete ");
			Console.WriteLine("5. Quit");
		}
		public static void CreateTask()
		{
			Task task = new Task();
			task.Name = GetUserInput("Enter Name: ");
			task.Description = GetUserInput("Enter Description: ");
			task.DueDate = (DateTime.Parse(GetUserInput("Enter a Date: ")));
			task.Complete = false;

			Task.AddTask(task);
		}

		public static DateTime ValiDate(string message)
		{
			try
			{
				return DateTime.Parse(GetUserInput(message));
			}
			catch (FormatException)
			{
				ValiDate("That won't work, we need a valid date!");
			}
			return ValiDate(message);
		}
		private static void RemoveTask()
		{
			Task.DisplayTasks();

			string userInput = GetUserInput("Enter Task Number to Remove");

			Task.DeleteTask(userInput);
		}
		public static void WhichTask()
		{
			Task.DisplayTasks();

			string userInput = GetUserInput("Enter Task Number to Complete");

			Task.CompleteTask(userInput);

		}
	}
}
