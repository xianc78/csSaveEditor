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
			while (true)
			{
				Console.Clear();
				Console.WriteLine("CaveStory Save Editor");
				Console.WriteLine("1) View Data");
				Console.WriteLine("2) Edit HP");
				choice = Console.ReadLine();
				if (choice == "1")
				{
					editor.viewData();
				}
				else if (choice == "2")
				{
					editor.editHP();
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
