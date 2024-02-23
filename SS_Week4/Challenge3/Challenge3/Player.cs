using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
	internal class Player
	{
		public Player(string name, double hp, double energy, double armor)
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
}

