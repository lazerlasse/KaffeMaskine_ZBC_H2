using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaffeMaskine.CoffeeBeans;

namespace KaffeMaskine.Dispencers
{
	class StandardBeanDispencer : IBeanDispencer
	{
		public StandardBeanDispencer(IBean bean)
		{
			BeanType = bean;
			DispencerSize = 20;
		}

		public IBean BeanType { get; set; }
		public int DispencerSize { get; private set; }
		public int CurrentLevel { get; set; }

		public void FillBrewer(int amount)
		{
			CurrentLevel = CurrentLevel - amount;
			Console.Clear();
			Console.WriteLine("Brygger har taget {0} skefulde {1} ind...", amount, BeanType);
		}

		public void FillDispencer()
		{
			int amountToFill = DispencerSize - CurrentLevel;
			CurrentLevel = CurrentLevel + amountToFill;
			Console.Clear();
			Console.WriteLine("Der blev fyldt {0} skefulde {1} i beholderen...", amountToFill, BeanType);
		}
	}
}
