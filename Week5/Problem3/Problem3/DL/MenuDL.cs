using Problem3.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.DL
{
	internal class MenuDL
	{
		public static List<MenuItemBL> MenuItems = new List<MenuItemBL>();

		public static void ParseData()
		{
			StreamReader file = new StreamReader("D:\\Programming Day\\SS_WEEK5\\Problem3\\Problem3\\Menu.txt");
			string record;
			if (File.Exists("D:\\Programming Day\\SS_WEEK5\\Problem3\\Problem3\\Menu.txt"))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string name = splittedRecord[0];
					string type = splittedRecord[1];
					int price = int.Parse(splittedRecord[2]);
					MenuItemBL obj = new MenuItemBL(name, type, price);
					MenuItems.Add(obj);
				}
			}
			file.Close();
		}
	}
}
