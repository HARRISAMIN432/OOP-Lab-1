using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Challenge2;

namespace Challenge2
{
	internal class Stats
	{
		public Stats(string skillName ,double damage, double penetration, double heal, double cost, string description)
		{
			this.skillName = skillName;
			this.damage = damage;
			this.description = description;
			this.penetration = penetration;
			this.cost = cost;
			this.heal = heal;
		}

		public string skillName;
		public double damage;
		public string description;
		public double penetration;
		public double cost;
		public double heal;
	}

	internal class Player
	{
		public Player(double hp, double energy, double armor, string name)
		{
			this.hp = hp;
			this.energy = energy;
			this.armor = armor;
			this.name = name;
		}

		public double hp;
		public double maxHealth;
		public double energy;
		public double maxEnergy;
		public double armor;
		public string name;
		public Stats skillStatistics;

		public void updateName()
		{
			name = Console.ReadLine();
		}

		public void learnSkill(Stats skillStatistics)
		{
			this.skillStatistics = skillStatistics;
		}

		public string attack(Player obj)
		{
			if (energy < skillStatistics.cost)
			{
				return name + " attempted to use " + skillStatistics.skillName + "but didn't have enough energy!";
			}
			energy -= skillStatistics.cost;
			double effectiveArmor = obj.armor - skillStatistics.penetration;
			if (effectiveArmor < 0)
				effectiveArmor = 0;
			double damage = skillStatistics.damage * ((100 - effectiveArmor) / 100);
			obj.hp -= damage;
			updateHp(damage);
			string returningString = name + " used " + skillStatistics.skillName + skillStatistics.description + " against " + obj.name + " doing " + damage + " damage!" + "and " + name + " healed for " + skillStatistics.heal + " health!";
			if (obj.hp < 0)
				returningString += "\n" + obj.name + " died!";
			else
			{
				double percent = (obj.hp / obj.maxHealth) * 100;
				returningString += obj.name + " is at " + percent + "% health!";
			}
			return returningString;
		}

		public void updateArmor(double a)
		{
			armor -= a;
		}

		public void updateEnergy(double e)
		{
			energy -= e;
			if (energy > maxEnergy)
				energy = maxEnergy;
		}

		public void updateHp(double damage)
		{
			hp += skillStatistics.heal;
			if (hp > maxHealth)
				hp = maxHealth;
		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			Player alice = new Player(100, 50, 10, "alice");
			Player bob = new Player(100, 60, 20, "bob");
			alice.maxHealth = 100;
			bob.maxHealth = 100;
			alice.maxEnergy = 50;
			bob.maxEnergy = 60;
			Stats fireball = new Stats("fireball", 23, 1.2, 5, 15, "a firey magical attack");
			alice.learnSkill(fireball);
			Console.WriteLine(alice.attack(bob));
			Stats superbeam = new Stats("superbeam", 200, 50, 50, 75, "an overpowered attack, pls nerf");
			bob.learnSkill(superbeam);
			Console.WriteLine(bob.attack(alice));
			Console.ReadKey();
		}
	}
}
