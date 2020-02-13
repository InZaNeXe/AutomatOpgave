using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOpgave
{
    class Snacks
    {
		private int chips;

		public int Chips
		{
			get { return chips; }
			set { chips = value; }
		}


		private int gummies;

		public int Gummies
		{
			get { return gummies; }
			set { gummies = value; }
		}


		private int chocolateBars;

		public int ChocolateBars
		{
			get { return chocolateBars; }
			set { chocolateBars = value; }
		}


		public Snacks()
		{
			this.Chips = chips;
			this.Gummies = gummies;
			this.ChocolateBars = chocolateBars;
		}

	}
}
