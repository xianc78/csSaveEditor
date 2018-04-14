using System;
using System.IO;

namespace csSaveEditor
{
	public class Editor
	{
		public void editHP()
		{
			int hp;
			int maxHp;
			Console.WriteLine("Enter the desire HP: ");
			hp = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the desire max HP: ");
			maxHp = Convert.ToInt32(Console.ReadLine());
			using (BinaryWriter bw = new BinaryWriter(new FileStream("Profile.dat", FileMode.Open)))
			{
				bw.BaseStream.Seek(32, SeekOrigin.Begin);
				bw.Write(hp);
				bw.BaseStream.Seek(28, SeekOrigin.Begin);
				bw.Write(maxHp);
				bw.Close();
			}
		}

		public void viewData()
		{
			Console.Clear();
			int currentMap;
			int currentHp;
			int maxHp;
			byte[] values = new byte[21];
			using (BinaryReader br = new BinaryReader(new FileStream("Profile.dat", FileMode.Open)))
			{
				br.BaseStream.Seek(8, SeekOrigin.Begin);
				currentMap = br.ReadByte();

				br.BaseStream.Seek(28, SeekOrigin.Begin);
				maxHp = br.ReadByte();

				br.BaseStream.Seek(32, SeekOrigin.Begin);
				currentHp = br.ReadByte();

				Console.WriteLine("Current map: {0}", currentMap);
				Console.WriteLine("Current HP : {0}", currentHp);
				Console.WriteLine("Max HP: {0}", maxHp);

				Console.WriteLine("<press enter>");
				Console.ReadLine();
				return;
			}

		}

		public void editAmmo()
		{

		}
	}
}