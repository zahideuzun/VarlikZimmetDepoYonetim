using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Product
	{
		public int ProductId { get; set; }
		public Guid ProductBarcode { get; set; }
		public ProductGroup ProductGroup { get; set; }
		public double Price { get; set; }
		public ProductType ProductType { get; set; }
		public Brand Brand { get; set; }
		public Model Model { get; set; }
		public bool IsWarrantyValid { get; set; }
		public DateTime EntryDate { get; set; }
		public DateTime RetirementDate { get; set; }
		public double ProductCost { get; set; }
		public string Description { get; set; }
		public string FilePath { get; set; }
		public ProductStatus ProductStatus { get; set; }
		public Currency CostCurrency { get; set; }

	}

}
