using KaffeMaskine.Heaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KaffeMaskine.Heaters
{
	class StandardHeater : IHeater
	{
		public int MaxTemperature { get; private set; }
		public int CurrentTemperature { get; private set; }
		public bool IsReady { get; private set; }

		public StandardHeater()
		{
			MaxTemperature = 90;
		}

		public void CoolDown()
		{
			for (int i = CurrentTemperature; i > 0; i--)
			{
				Console.Clear();
				Console.WriteLine("Maskinen køler ned vent venligst...\n\n{0} grader", i);
				Thread.Sleep(300);
			}

			// Set heater to not ready and update current temp...
			IsReady = false;
			CurrentTemperature = 0;
		}

		public void HeatUp()
		{
			// Simulate upvarmning...
			for (int i = CurrentTemperature; i < MaxTemperature; i++)
			{
				Console.Clear();
				Console.WriteLine("Maskinen varmer op vent venligst...\n\n{0} grader", i);
				Thread.Sleep(200);
			}

			// Mark heater as ready and set current temp...
			IsReady = true;
			CurrentTemperature = MaxTemperature;

		}
	}
}
