using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOpgave
{
    class Products
    {
		private int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		private int supplier;

		public int Supplier
		{
			get { return supplier; }
			set { supplier = value; }
		}



		public Products()
		{
			this.Price = price;
			this.Supplier = supplier;
		}


	}
}
