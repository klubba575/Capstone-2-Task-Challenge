using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone_2___Task_Challenge
{
	class Task
	{
		private static List<Task> _tasks = new List<Task>()
		{
			new Task("Bart Simpson", "Skateboards and wreaks havoc!", DateTime.Parse("10/25/2019")),
			new Task("Homer Simpson", "Eats Donuts", DateTime.Parse("10/24/2019")),
			new Task("Marge Simpson", "Keeps Everyone Out of Trouble", DateTime.Parse("10/26/2019")),
			new Task("Lisa Simpson", "Plays a Mean Jazz Saxophone", DateTime.Parse("10/27/2019")),
			new Task("Maggie Simpson", "Chews on the Pacifier", DateTime.Parse("10/28/2019")),
		};
		//fields
		private string _name;
		private string _description;
		private DateTime _dueDate;
		private bool _complete;

		//properties
		#region
		public string Name 
		{
			get { return _name; }
			set { _name = value; }
		}
		public string Description
		{ 
			 get { return _description; }
			set { _description = value; }
		}
		public DateTime DueDate
		{
			get { return _dueDate;}
			set { _dueDate = value; }
		}
		public bool Complete
		{
			get { return _complete; }
			set { _complete = value; }
		}
		#endregion
		//Constructors
		#region
		public Task() { }

		public Task(string name, string description, DateTime dueDate, bool complete = false)
		{
			Name = name;
			Description = description;
			DueDate = dueDate;
			Complete = complete;
		}
		#endregion

		public static void PrintOptions()
		{
			Console.WriteLine("1. List Tasks");
			Console.WriteLine("2. Add Task");
			Console.WriteLine("3. Delete Task");
			Console.WriteLine("4. Mark task complete ");
			Console.WriteLine("5. Quit");
		}
		public static int ParseString(string message)
		{
			
			int userChoice = int.Parse(message);
			return userChoice;
		}
		public static void DisplayTasks()
		{
			for(int i = 0; i < _tasks.Count; i++)
			{
				Console.WriteLine($"\t{i+1}: {_tasks[i].Name}");
				Console.WriteLine($"\tDue Date:{_tasks[i].DueDate.ToShortDateString()}");
				Console.WriteLine($"\tComplete:{_tasks[i].Complete}");
				Console.WriteLine($"\tDescription:{_tasks[i].Description}");
			}
		}
		
		public static void AddTask(Task task)
		{
			_tasks.Add(task);
		}
		public static void DeleteTask(string userInput)
		{
			int newNumber = ParseString(userInput);
			_tasks.RemoveAt(newNumber - 1);

		}
		public static void CompleteTask(string userInput)
		{
			int number = int.Parse(userInput);
			Task foundTask = _tasks[number-1];
			foundTask.Complete = true;
		}
	}
}
