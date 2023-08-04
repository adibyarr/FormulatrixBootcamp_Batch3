using System;
using System.IO;
using System.Xml.Serialization;

public class Items
{
	public string? Description{get; set;}
	public int Price{get; set;}
	public string? Condition{get;set;}
}

public class Program
{
	static void Main()
	{
		List<Items> items = new List<Items>
		{
			new Items { Description = "Sepeda", Price = 3020000, Condition = "Baik"},
			new Items {Description = "Sepeda", Price = 3020000, Condition = "Baik"}
		};
		
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Items>));
		
		//using(StreamWriter streamWriter = new StreamWriter("items.xml"))
		//{
		//	xmlSerializer.Serialize(streamWriter, items);
		//} 
		using (StreamReader streamReader = new StreamReader("items.xml"))
		{
			List<Items> deserializedItems = (List<Items>)xmlSerializer.Deserialize(streamReader);
			Console.WriteLine(deserializedItems.Count);
			foreach(var items2 in deserializedItems)
			{
				Console.WriteLine($"Deserialize items: {items2.Description}, {items2.Price}, {items2.Condition}");
			}
		}
	}
}