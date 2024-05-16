using cl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace clComp
{
	class ClDeviceManufacturerComparer : IEqualityComparer<ClDevice>
	{
		public bool Equals(ClDevice x, ClDevice y)
		{
			return x.ManufacturerDevice == y.ManufacturerDevice;
		}
		public int GetHashCode(ClDevice obj)
		{
			return obj.ManufacturerDevice.GetHashCode();
		}
	}

}
