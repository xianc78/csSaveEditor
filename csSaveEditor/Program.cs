using System;
using System.IO;

namespace csSaveEditor
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			Editor editor = new Editor();
			string choice;
			Console.BackgroundColor = ConsoleColor.Blue;
			while (true)
			{
				Console.Clear();
				Console.WriteLine("CaveStory Save Editor");
				Console.WriteLine("---------------------------");
				Console.WriteLine("1) View Data");
				Console.WriteLine("2) Edit HP");
				Console.WriteLine("3) Edit Max HP");
				Console.WriteLine("4) Edit Current Song");
				choice = Console.ReadLine();
				if (choice == "1")
				{
					editor.viewData();
				}
				else if (choice == "2")
				{
					editor.editHP();
				}
				else if (choice == "3")
				{
					editor.editMaxHp();
				}
				else if (choice == "4")
				{
					editor.changeSong();
				}
				else
				{
					Console.WriteLine("Invalid choice");
					Console.ReadLine();
				}
			}
			
		}

	}
}
