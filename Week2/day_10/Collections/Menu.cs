using System;
using System.Collections.Generic;

namespace Restaurant
{
	public class Menu
	{
		public string RestaurantMenu{get; set;}
		public string MenuTaste {get; set;}
		public int Price { get; set;}
		
		public Menu(string restaurantMenu, string menuTaste, int price)
		{
			RestaurantMenu = restaurantMenu;
			MenuTaste = menuTaste;
			Price = price;
		}
		public override string ToString()
		{
			return $"{RestaurantMenu} with {MenuTaste} ({Price})";
		}
		public override bool Equals(object obj)
        {
            if (obj is Menu otherMenu)
            {
                return RestaurantMenu == otherMenu.RestaurantMenu && MenuTaste == otherMenu.MenuTaste && Price == otherMenu.Price;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (RestaurantMenu, MenuTaste, Price).GetHashCode();
        }
    
	}
}