using KaffeMaskine.CoffeeBeans;
using KaffeMaskine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.Dispencers
{
	interface ILiquidDispencer
	{
		int CurrentLevel { get; set; }
		ILiquid LiquidType { get; set; }
		void FillDispencer();
		void FillBrewer(int amount);
	}
}
