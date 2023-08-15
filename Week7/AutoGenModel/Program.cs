using WorkingWithEFCore.AutoGen;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace WorkingWithEFCore;
public class Program
{
	static void Main()
	{
		using(var context = new Northwind())
		{
			var categories = context.Categories.ToList();
			Console.WriteLine("List Categories: ");
			foreach(var category in categories)
			{
				Console.WriteLine($"{category.CategoryId}: {category.CategoryName}");
			}
			var products = context.Products.ToList();
			Console.WriteLine("List Product: ");
			foreach(var product in products)
			{
				Console.WriteLine($"{product.ProductId}: {product.ProductName}, Price: {product.UnitPrice} stok: {product.UnitsInStock}");
			}
			
		}
		
	}
}