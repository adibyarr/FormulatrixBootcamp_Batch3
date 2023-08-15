using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace EFCore;

public class Product
{
	[Key]
	public int ProductId {get; set;}
	[Required]
	[StringLength(40)]
	public string ProductName {get; set;}
	[Column("UnitPrice", TypeName = "money")]
	public decimal? cost{get; set;}
	
	[Column("UnitsInStock")]
	public short? stock{get; set;}
	
	public bool Discontinued{get; set;}
	public int CategoryId{get; set;}
	public virtual Category category{get; set;} = null! ;
}