namespace GenericDay
{
	public class KopiEnak<TKey1, TKey2, TKey3>
	{
			public KopiEnak()
			{
				Console.WriteLine("Kopienak Constructor");
			 
			}
			public KopiDescription InputKopiBaru(TKey1 nama, TKey2 harga)
			{
				KopiDescription inputKopi = new KopiDescription();
				inputKopi.namaKopi = nama.ToString();
				inputKopi.hargaKopi = Convert.ToInt32(harga);
				return inputKopi;
			}
			public KopiDescription jenisKopi(TKey1 nama, TKey2 harga)
			{
				KopiDescription jenisKopi = new KopiDescription();
				jenisKopi.namaKopi= "sidikalang";
				jenisKopi.hargaKopi= 300000;
				return jenisKopi;
			}
			public KopiDescription editKopi(TKey3 edit)
			{
				KopiDescription editKopi = new KopiDescription();
				editKopi.namaKopi = "Flores";
				editKopi.hargaKopi = 40000;
				return editKopi;
			}
		
	}
}