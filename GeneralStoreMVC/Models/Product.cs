using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreMVC.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		[Required]
		[DisplayName("Product Name")]
		public string Name { get; set; }
		[Required]
		[DisplayName("# in Stock")]
		public int InventoryCount { get; set; }
		[Required]
		public decimal Price { get; set; }
		[Required]
		[DisplayName("It is a food")]
		public bool IsFood { get; set; }
	}
}