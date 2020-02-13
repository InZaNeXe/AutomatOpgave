using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOpgave
{
    class Vending_Machine
    {

		private int[] rowsnColumns;

		public int[] RowsnColumns
		{
			get { return rowsnColumns; }
			set { rowsnColumns = value; }
		}

		private string output;

		public string Output
		{
			get { return output; }
			set { output = value; }
		}

		private int cashbox;

		public int CashBox
		{
			get { return cashbox; }
			set { cashbox = value; }
		}


		public Vending_Machine()
		{
			this.RowsnColumns = rowsnColumns;
			this.Output = output;
			this.CashBox = cashbox;
		}


	}
}
