using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppClass
{
	internal class medicineClass
	{
		public medicineClass(string name, int price)
		{
			medicines = name;
			medicineprice = price;
		}
		public string medicines;
		public int medicineprice;
	}

	internal class skinCareClass
	{
		public skinCareClass(string name, int price)
		{
			skinCare = name;
			skinCarePrice = price;
		}
		public string skinCare;
		public int skinCarePrice;
	}

	internal class eyeCareClass
	{
		public eyeCareClass(string name, int price)
		{
			eyeCare = name;
			eyeCarePrice = price;
		}
		public string eyeCare;
		public int eyeCarePrice;
	}

	internal class devicesClass
	{
		public devicesClass(string name, int price)
		{
			medicalDevices = name;
			medicalDevicesPrice = price;
		}
		public string medicalDevices;
		public int medicalDevicesPrice;
	}

	internal class discountMedicineClass
	{
		public discountMedicineClass(string name, int rate)
		{
			discountMedicines = name;
			discountRate = rate;
		}
		public string discountMedicines;
		public int discountRate;
	}

	internal class discountSkinCareClass
	{
		public discountSkinCareClass(string name, int rate)
		{
			discountSkinCare = name;
			discountRate = rate;
		}
		public string discountSkinCare;
		public int discountRate;
	}

	internal class discountEyeCareClass
	{
		public discountEyeCareClass(string name, int rate)
		{
			discountEyeCare = name;
			discountRate = rate;
		}
		public string discountEyeCare;
		public int discountRate;
	}

	internal class discountDevicesClass
	{
		public discountDevicesClass(string name, int rate)
		{
			discountDevices = name;
			discountRate = rate;
		}
		public string discountDevices;
		public int discountRate;
	}


}
