using System;
using System.IO;

namespace csSaveEditor
{
	public class Editor
	{
		public void editHP()
		{
			Console.Clear();
			int hp;
			Console.WriteLine("HP Editor");
			Console.WriteLine("---------------------------");
			Console.Write("Enter the desire HP: ");
			hp = Convert.ToInt32(Console.ReadLine());

			using (BinaryWriter bw = new BinaryWriter(new FileStream("Profile.dat", FileMode.Open)))
			{
				bw.BaseStream.Seek(32, SeekOrigin.Begin);
				bw.Write(hp);
				bw.Close();
			}
		}

		public void editMaxHp()
		{
			Console.Clear();
			int maxHp;
			Console.WriteLine("HP Editor");
			Console.WriteLine("---------------------------");
			Console.Write("Enter the desire max HP: ");
			maxHp = Convert.ToInt32(Console.ReadLine());
			using (BinaryWriter bw = new BinaryWriter(new FileStream("Profile.dat", FileMode.Open)))
			{
				bw.BaseStream.Seek(28, SeekOrigin.Begin);
				bw.Write(maxHp);
				bw.Close();
			}
		}

		public void viewData()
		{
			Console.Clear();
			Console.WriteLine("Data");
			Console.WriteLine("---------------------------");
			int currentMap;
			int currentHp;
			int maxHp;
			int facing;
			byte[] values = new byte[21];
			using (BinaryReader br = new BinaryReader(new FileStream("Profile.dat", FileMode.Open)))
			{
				br.BaseStream.Seek(8, SeekOrigin.Begin);
				currentMap = br.ReadByte();

				br.BaseStream.Seek(24, SeekOrigin.Begin);
				facing = br.ReadByte();

				br.BaseStream.Seek(28, SeekOrigin.Begin);
				maxHp = br.ReadByte();

				br.BaseStream.Seek(32, SeekOrigin.Begin);
				currentHp = br.ReadByte();

				Console.WriteLine("Current map: {0}", currentMap);
				Console.WriteLine("Current HP : {0}", currentHp);
				Console.WriteLine("Max HP: {0}", maxHp);
				if (facing == 0)
				{
					Console.WriteLine("Facing: left");
				}
				else if (facing == 2)
				{
					Console.WriteLine("Facing: right");
				}

				Console.WriteLine("<press enter>");
				Console.ReadLine();
				return;
			}

		}

		public void editAmmo()
		{
			int ammo;
			int maxAmmo;
			int currentWeapon;
			Console.Clear();
			Console.WriteLine("Enter desire ammo: ");
			ammo =  Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter desired max ammo: ");
			maxAmmo = Convert.ToInt32(Console.ReadLine());
			using (BinaryReader br = new BinaryReader(new FileStream("Profile.dat", FileMode.Open)))
			{
				br.BaseStream.Seek(36, SeekOrigin.Begin);
				currentWeapon = br.ReadByte();
			}
			using (BinaryWriter bw = new BinaryWriter(new FileStream("Profile.dat", FileMode.Open)))
			{
				bw.BaseStream.Seek(currentWeapon, SeekOrigin.Begin);

			}
		}

		public void changeSong()
		{
			int song;
			Console.Clear();
			Console.WriteLine("Song Editor");
			Console.WriteLine("---------------------------");
			Console.WriteLine("Change current song. Enter the songs value from here: https://www.cavestory.org/guides/profile.txt");
			Console.WriteLine("Change the hexademical value to decimal");

			Console.WriteLine("Enter desired song: ");
			song = Convert.ToInt32(Console.ReadLine());

			using (BinaryWriter bw = new BinaryWriter(new FileStream("Profile.dat", FileMode.Open)))
			{
				bw.BaseStream.Seek(12, SeekOrigin.Begin);
				bw.Write(song);
			}
		}
	}
}