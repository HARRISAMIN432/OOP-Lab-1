using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAppWeek3.BL;

namespace BusinessAppWeek3.DL
{
	internal class ItemsDL
	{
		public static List<Items> MedicinesList = new List<Items>();
		public static List<Items> SkinCareList = new List<Items>();
		public static List<Items> EyeCareList = new List<Items>();
		public static List<Items> MedicalDevicesList = new List<Items>();

		public static void AddToMedicinesList(Items obj)
		{
			MedicinesList.Add(obj);
		}

		public static void AddToSkinCareProductsList(Items obj)
		{
			SkinCareList.Add(obj);
		}

		public static void AddToEyeCareProductsList(Items obj)
		{
			EyeCareList.Add(obj);
		}
		
		public static void AddToMedicalDevicesList(Items obj)
		{
			MedicinesList.Add(obj);
		}

		public static void RemoveMedicineFromList(string Medicine)
		{
			int Counter = 0;
			foreach (var i in MedicinesList)
				if (Medicine == i.Name)
				{ 
					MedicinesList.RemoveAt(Counter);
					Counter++;
				}
		}

		public static void RemoveSkinCareProductFromList(string SkinCare)
		{
			int Counter = 0;
			foreach (var i in SkinCareList)
				if (SkinCare == i.Name)
				{
					SkinCareList.RemoveAt(Counter);
					Counter++;
				}
		}

		public static void RemoveEyeCareProductFromList(string EyeCare)
		{
			int Counter = 0;
			foreach (var i in EyeCareList)
				if (EyeCare == i.Name)
				{
					EyeCareList.RemoveAt(Counter);
					Counter++;
				}
		}

		public static void RemoveMedicalDeviceFromList(string MedicalDevice)
		{
			int Counter = 0;
			foreach (var i in MedicalDevicesList)
				if (MedicalDevice == i.Name)
				{
					MedicalDevicesList.RemoveAt(Counter);
					Counter++;
				}
		}

		public static Items ReturnMedicine(string Name)
		{
			foreach (var i in MedicinesList)
				if (i.Name == Name)
					return i;
			return null;
		}

		public static Items ReturnSkinCare(string Name)
		{
			foreach (var i in SkinCareList)
				if (i.Name == Name)
					return i;
			return null;
		}

		public static Items ReturnEyeCare(string Name)
		{
			foreach (var i in EyeCareList)
				if (i.Name == Name)
					return i;
			return null;
		}

		public static Items ReturnDevices(string Name)
		{
			foreach (var i in MedicalDevicesList)
				if (i.Name == Name)
					return i;
			return null;
		}
	}
}
