using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.Liquids
{
	class Water : ILiquid
	{
		public string Name { get; set; }

		public Water()
		{
			Name = "Vand";
		}
	}
}
