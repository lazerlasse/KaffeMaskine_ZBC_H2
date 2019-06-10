using KaffeMaskine;
using KaffeMaskine.CoffeeBeans;
using KaffeMaskine.Dispencers;
using KaffeMaskine.Heaters;
using KaffeMaskine.Liquids;
using KaffeMaskine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KaffeMaskine.MainParts
{
	class Brewer
	{
		private IHeater Heater { get; set; }

		public Brewer()
		{
			// Add heater to use for warm drink...
			Heater = new StandardHeater();
		}

		public void StartBrewing(int strength, int amountToBrew, ILiquidDispencer liquidDispencer, IBeanDispencer beanDispencer)
		{
			// Heat up...
			Heater.HeatUp();

			// Calculate amount of beans to use...
			int beansToUse = Calculator.CalculateSpoonsOfBeansToUse(strength);

			// Get the liquid from dispencer...
			liquidDispencer.FillBrewer(amountToBrew);

			// Get beans from dispencer...
			beanDispencer.FillBrewer(beansToUse);

			// Brew the choosen type...
			Brew(amountToBrew, beanDispencer);

			// Cool down the heater again...
			Heater.CoolDown();
		}

		private void Brew(int amount, IBeanDispencer beanDispencer)
		{
			// Simulate that the brewer is brewing...
			for (int i = 0; i < 101; i++)
			{
				Console.Clear();
				Console.WriteLine("Brygger nu {0} kop {1} vent venligst...\n{2} %", amount, beanDispencer.BeanType.Name, i);
				Thread.Sleep(100);
			}

			// Print finish message to user...
			Console.Clear();
			Console.WriteLine("Færdig. Du kan tage din kop nu.");
			Thread.Sleep(3000);
		}
	}
}
