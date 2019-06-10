using KaffeMaskine.CoffeeBeans;
using KaffeMaskine.Dispencers;
using KaffeMaskine.Liquids;
using KaffeMaskine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.MainParts
{
	public sealed class CoffeeMaker
	{
		public bool IsOn { get; set; }
		private static readonly CoffeeMaker instance = new CoffeeMaker();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static CoffeeMaker()
		{
		}

		private CoffeeMaker()
		{
		}

		public static CoffeeMaker Instance
		{
			get { return instance; }
		}

		public void RunCoffeeMaker()
		{
			// Add liquids to use for brewing...
			ILiquid liquid = new Water();

			// Add beans to use. Each type of beans need is own dispencer...
			IBean bean = new SpecialCoffeeBean("Arabica Special", "Mild rund");

			// Add dispencers to use...
			ILiquidDispencer liquidDispencer = new StandardLiquidDispencer(liquid);     // Use water as liquid..
			IBeanDispencer beanDispencer = new StandardBeanDispencer(bean);             // Add choosen beans to dispencer.

			// Add an brewer or more for multi maker...
			Brewer brewer = new Brewer();

			// Run loop..
			while (IsOn)
			{
				// Clear console and write welcome message and what to make...
				Console.Clear();
				Console.WriteLine("Hej og velkommen i kaffemaskinen.\n\nVælg hvilken drik du ønsker\n\n1. {0}", bean.ToString());

				// Wait for user input..
				string choise = Console.ReadLine();

				// Check and validate input...
				if (choise == "1")
				{
					// Chose strenght for choosen coffee...
					Console.Clear();
					Console.WriteLine("Vælg styrke på din kaffe mellem 1 og 10\n\nVælg: ");
					int.TryParse(Console.ReadLine(), out int strenghtChoise);

					// Brew the choosen drink..
					brewer.StartBrewing(strenghtChoise, 1, liquidDispencer, beanDispencer);
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Hov du fik tastet noget forkert, prøv igen.");
				}
			}
		}

		private void Filldispencers(ILiquidDispencer liquidDispencer, IBeanDispencer beanDispencer)
		{
			liquidDispencer.FillDispencer();
			beanDispencer.FillDispencer();
		}
	}
}