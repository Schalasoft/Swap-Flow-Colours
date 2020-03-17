using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PeterHan.PLib;

namespace SwapFlowColour
{
		[JsonObject]
		public class SwapFlowColourOptions
		{
		[Option("Red/Blue", "Blue input, red output.")]
		public bool RedBlue { get; set; } = false;
	}
}
