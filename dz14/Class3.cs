using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl
{
	public class ClDevice
	{
		public string NameDevice { get; set; }
		public string ManufacturerDevice { get; set; }
		public Decimal PriceDevice { get; set; }
		public ClDevice(string NameDevice, string ManufacturerDevice, Decimal PriceDevice)
		{
			this.NameDevice = NameDevice;
			this.ManufacturerDevice = ManufacturerDevice;
			this.PriceDevice = PriceDevice;
		}

		public override string ToString()
		{
			return $"\nName device: {NameDevice},\nmanufacturer: {ManufacturerDevice},\nprice: {PriceDevice} UAH\n";
		}

	}
}
