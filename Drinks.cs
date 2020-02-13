using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOpgave
{
    class Drinks
    {
		private int sodas;

		public int Sodas
		{
			get { return sodas; }
			set { sodas = value; }
		}

		private int water;

		public int Water
		{
			get { return water; }
			set { water = value; }
		}


		private int energyDrinks;

		public int EnergyDrinks
		{
			get { return energyDrinks; }
			set { energyDrinks = value; }
		}


		public Drinks()
		{
			this.Sodas = sodas;
			this.Water = water;
			this.EnergyDrinks = energyDrinks;
		}

	}
}
