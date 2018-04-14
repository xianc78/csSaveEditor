using System;
using System.IO;

namespace csSaveEditor
{

	enum modes { menu, inventory, hp, ammo }


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
				else
				{
					Console.WriteLine("Invalid choice");
					Console.ReadLine();
				}
			}
			
		}

	}
}
