namespace Kasur
{
	public class TypeKasur
	{
		public TypeKasur typeKasur{get; set;}
		public string Description{get; set;}
		public TypeKasur(TypeKasur typeKasur, string Description)
		{
			Kasur = typeKasur;
			Description = description;
		}
		public static TypeKasur GetKasur(TypeKasur typeKasur)
		
		{
			switch(typeKasur)
			{
				case TypeKasur.KasurAngin:
				case TypeKasur.KasurLipat:
				return new TypeKasur(typeKasur, " jelek ");
				case TypeKasur.KasurBusa:
				return new TypeKasur(typeKasur, " edan");
				case TypeKasur.KasurPalembang:
				return new TypeKasur(typeKasur, "auah");
				default:
					return null;
			}
		}
	}
}