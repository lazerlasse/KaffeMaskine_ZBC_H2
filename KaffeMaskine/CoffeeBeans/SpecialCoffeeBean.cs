using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.CoffeeBeans
{
	class SpecialCoffeeBean : IBean
	{
		public string Flavour { get; private set; }
		public string Name { get; set; }

		public SpecialCoffeeBean(string name, string flavour)
		{
			Flavour = flavour;
			Name = name;
		}

		public override string ToString()
		{
			return Name + " " + Flavour;
		}
	}
}
