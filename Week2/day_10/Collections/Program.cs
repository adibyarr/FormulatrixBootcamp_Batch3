using System;
using System.Collections.Generic;
namespace Restaurant
{
	class Program
	{
		static void Main(string[] args)
		{
			Restaurant restaurant = new Restaurant();
			
			restaurant.AddMenu(new Menu("Spaggheti", " Salty ", 20000));
			restaurant.AddMenu(new Menu("Pindang Knalpot ", " Spicy ", 35000));
			restaurant.AddMenu(new Menu("Rica-rica jamur ", " Sweet ", 23000));
			
			restaurant.DisplayMenu();
			
			Menu menuToRemove = new Menu("Pindang Knalpot " ," Spicy", 23000);
			restaurant.RemoveMenu(menuToRemove);
			restaurant.DisplayMenu();
			
			Menu menuToUpdate = new Menu("Spaggheti", " Salty ", 20000);
			restaurant.UpdateMenu(menuToUpdate, "Carbonara ", " oily and garlic ", 40000);
			restaurant.DisplayMenu();
			
		
		}
	}
}
