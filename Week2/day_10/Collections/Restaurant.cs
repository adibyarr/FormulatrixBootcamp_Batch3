using System;
using System.Collections.Generic;

namespace Restaurant
{
	class Restaurant
	{
		private List<Menu> menus;
		public Restaurant()
		{
			menus = new List<Menu>();
		}
		
		public void AddMenu(Menu menu)
		{
			menus.Add(menu);
			Console.WriteLine($"{menu.RestaurantMenu} added to order");
		}
		public void RemoveMenu(Menu menu)
		{
			if (menus.Remove(menu))
			{
				Console.WriteLine($"{menu.RestaurantMenu} remove from the order");
			}
			else 
			{
				Console.WriteLine($"{menu.RestaurantMenu} not foud");
			}
		}
		public void UpdateMenu(Menu existingMenu, string newrestaurantMenu, string newmenuTaste, int newPrice)
		{
			for (int i = 0; i < menus.Count; i++)
            {
                if (menus[i].Equals(existingMenu))
                {
                    menus[i].RestaurantMenu = newrestaurantMenu;
                    menus[i].MenuTaste = newmenuTaste;
                    menus[i].Price = newPrice;
                    Console.WriteLine($"{existingMenu.RestaurantMenu} updated in the menu.");
                    return;
                }
			}
			Console.WriteLine($"{existingMenu.RestaurantMenu} not found in the menu. Update failed");
		}
		public void DisplayMenu()
		{
			Console.WriteLine("Menus in Restaurant Menu");
			foreach(var menu in menus)
			{
				Console.WriteLine(menu);
			}
		}
		
		public Menu[] GetMenus()
		{
			return menus.ToArray();	
		}
	}
}