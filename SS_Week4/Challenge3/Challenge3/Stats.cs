using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
		internal class Stats
		{
			public Stats(string skillName, double damage, double penetration, double heal, double cost, string description)
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
	}
