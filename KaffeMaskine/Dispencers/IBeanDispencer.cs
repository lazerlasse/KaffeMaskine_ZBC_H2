using KaffeMaskine.CoffeeBeans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.Dispencers
{
	interface IBeanDispencer
	{
		IBean BeanType { get; set; }
		int CurrentLevel { get; set; }
		void FillDispencer();
		void FillBrewer(int amount);
	}
}
