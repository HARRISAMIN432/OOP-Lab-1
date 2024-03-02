using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.BL
{
	internal class Items
	{
		public string Name;
		public double Price;
		public double DiscountRate;
		public double DiscountPrice;

		public Items(string Name, double Price)
		{
			this.Name = Name;
			this.Price = Price;
			DiscountPrice = Price;
		}

		public void SetDiscountRate(double DiscountRate)
		{
			this.DiscountRate = DiscountRate;
		}

		public void SetDiscountPrice()
		{
			DiscountPrice = Price - DiscountRate / 100 * Price;
		}

		public string GetName()
		{
			return Name;
		}

		public double GetPrice()
		{
			return Price;
		}

		public double GetDiscountRate()
		{
			return DiscountRate;
		}

		public double GetDiscountPrice()
		{
			return DiscountPrice;
		}

		public void SetPrice(double Price)
		{
			this.Price = Price;
		}
	}
}
