using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.Heaters
{
	interface IHeater
	{
		void HeatUp();
		void CoolDown();
	}
}
