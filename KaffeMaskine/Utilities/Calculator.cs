using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine.Utilities
{
	public static class Calculator
	{
		public static int CalculateSpoonsOfBeansToUse(int strength)
		{
			int spoonOfBeans = 0;

			if (strength <= 2)
			{
				spoonOfBeans = 1;
			}
			else if (strength > 2 && strength <= 4)
			{
				spoonOfBeans = 2;
			}
			else if (strength > 4 && strength <= 6)
			{
				spoonOfBeans = 3;
			}
			else if (strength > 6 && strength <= 8)
			{
				spoonOfBeans = 4;
			}
			else if (strength > 8)
			{
				spoonOfBeans = 5;
			}

			return spoonOfBeans;
		}
	}
}
