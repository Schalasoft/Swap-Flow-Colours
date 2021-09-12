using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace SwapFlowColour
{
		[JsonObject]
		public class SwapFlowColourOptions : KMod.UserMod2
		{
		[Option("Red/Blue", "Blue input, red output.")]
		public bool RedBlue { get; set; } = false;
	}
}
