﻿using KaffeMaskine.MainParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
	class Program
	{
		static void Main(string[] args)
		{
			CoffeeMaker.Instance.IsOn = true;
			CoffeeMaker.Instance.RunCoffeeMaker();
		}
	}
}
