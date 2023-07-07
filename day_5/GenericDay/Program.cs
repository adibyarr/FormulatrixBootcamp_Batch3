// See https://aka.ms/new-console-template for more information
namespace GenericDay
{
	public class Program
	
	{
		public static void Main()
		{
			KopiEnak<string, int, KopiDescription> kopi1 = new KopiEnak<string, int, KopiDescription>();
			KopiDescription kopi2= kopi1.jenisKopi("Nescafe", 18000);
			Console.WriteLine(kopi2.namaKopi);
			Console.WriteLine(kopi2.hargaKopi);
			
			KopiDescription editKopi1 = new KopiDescription();
			editKopi1.namaKopi = "Gayo";
			editKopi1.hargaKopi = 19000;
			KopiEnak<int, int, KopiDescription> editKopi2 = new KopiEnak<int, int, KopiDescription>();
			KopiDescription editKopi3 = editKopi2.editKopi(editKopi1);
			Console.WriteLine("Nama Kopi diedit: " + editKopi3.namaKopi);
			Console.WriteLine("Harga kopi diedit: "+ editKopi3.hargaKopi);
			
			KopiEnak<string, int, KopiDescription> aksesKopi = new KopiEnak<string, int, KopiDescription>();
			KopiDescription aksesKopi2 = aksesKopi.InputKopiBaru("Temanggung ", 192999);
			Console.WriteLine(aksesKopi2.namaKopi);
			Console.WriteLine(aksesKopi2.hargaKopi);
		}
	}
}