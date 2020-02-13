using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOpgave
{
    class Input
    {

		private int coinslot;

		public int CoinSlot
		{
			get { return coinslot; }
			set { coinslot = value; }
		}


		private int[] buttons;

		public int[] Buttons
		{
			get { return buttons; }
			set { buttons = value; }
		}


		private string screen;

		public string Screen
		{
			get { return screen; }
			set { screen = value; }
		}


		private string adminlock;

		public string AdminLock
		{
			get { return adminlock; }
			set { adminlock = value; }
		}


		public Input()
		{
			this.CoinSlot = coinslot;
			this.AdminLock = adminlock;
			this.Buttons = buttons;
			this.Screen = screen;
		}


	}
}
