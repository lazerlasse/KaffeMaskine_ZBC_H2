using KaffeMaskine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.Dispencers
{
	class StandardLiquidDispencer : ILiquidDispencer
	{
		public StandardLiquidDispencer(ILiquid liquid)
		{
			DispencerSize = 10;
			LiquidType = liquid;
		}

		public ILiquid LiquidType { get; set; }
		public int DispencerSize { get; private set; }
		public int CurrentLevel { get; set; }

		public void FillBrewer(int amount)
		{
			CurrentLevel = CurrentLevel - amount;
			Console.Clear();
			Console.WriteLine("Brygger har taget {0} kopper {1} ind...", amount, LiquidType);
		}

		public void FillDispencer()
		{
			int amountToFill = DispencerSize - CurrentLevel;
			CurrentLevel = CurrentLevel + amountToFill;
			Console.Clear();
			Console.WriteLine("Der blev fyldt {0} kopper {1} i beholderen...", amountToFill, LiquidType);
		}
	}
}
