using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{

	internal class Program
	{
		static void Main(string[] args)
		{
			string option;
			List<Player> players = new List<Player>();
			List<Stats> statistics = new List<Stats>();
			while (true)
			{
				Console.Clear();
				menu();
				option = Console.ReadLine();
				if(option == "1")
				{
					Console.Clear();
					inputPlayerInfo(players);
				}
				if(option == "2")
				{
					Console.Clear();
					inputStatisticsInfo(statistics);
				}
				if(option == "3")
				{
					Console.Clear();
					displayPlayer1Info(players);
					displayPlayer2Info(players);
					Console.ReadKey();
				}
				if(option == "4")
				{
					Console.Clear();
					Console.Write("Enter the player name: ");
					string name = Console.ReadLine();
					Console.Write("Enter the name of skill");
					string skillName 
				}
			}
		}

		static void menu()
		{
			Console.WriteLine("1-  Add  Player");
			Console.WriteLine("2-  Add Skill Statistics");
			Console.WriteLine("3-  Display Player Info");
			Console.WriteLine("4-  Learn a skill");
			Console.WriteLine("5-  Attack");
			Console.WriteLine("6-  Exit");
			Console.WriteLine("Select the option...");
		}

		static void inputPlayerInfo(List<Player> players)
		{
			Console.WriteLine("Enter Player name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Enter max health: ");
			double health = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter max energy: ");
			double energy = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter armor effevtiveness: ");
			double armor = double.Parse(Console.ReadLine());
			Player obj = new Player(name, health, energy, armor);
			obj.maxHealth = health;
			obj.maxEnergy = energy;
			players.Add(obj);
		}

		static void inputStatisticsInfo(List<Stats> statistics)
		{
			Console.WriteLine("Enter Skill Name: ");
			string skillName = Console.ReadLine();
			Console.WriteLine("Enter Damage: ");
			double damage = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter penetration: ");
			double penetration = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter penetration: ");
			double heal = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter penetration: ");
			double cost = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter penetration: ");
			string description = Console.ReadLine();
			Stats obj = new Stats(skillName, damage, penetration, heal, cost, description);
			statistics.Add(obj);
		}

		static void displayPlayer1Info(List<Player> players)
		{
			Console.SetCursorPosition(10, 5);
			Console.Write(players[0].name);
			Console.SetCursorPosition(10, 6);
			Console.Write(players[0].maxHealth);
			Console.SetCursorPosition(10, 7);
			Console.Write(players[0].maxEnergy);
			Console.SetCursorPosition(10, 8);
			Console.Write(players[0].armor);
		}

		static void displayPlayer2Info(List<Player> players)
		{
			Console.SetCursorPosition(50, 5);
			Console.Write(players[1].name);
			Console.SetCursorPosition(50, 6);
			Console.Write(players[1].maxHealth);
			Console.SetCursorPosition(50, 7);
			Console.Write(players[1].maxEnergy);
			Console.SetCursorPosition(50, 8);
			Console.Write(players[1].armor);
		}
	}
}
