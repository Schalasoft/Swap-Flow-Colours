using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace SwapFlowColour
{
    [JsonObject(MemberSerialization.OptIn)]
    //[ModInfo("https://www.github.com/peterhaneve/ONIMods")]
    public class SwapFlowColourOptions
    {
        [Option("Red/Blue", "Blue input, red output.")]
        [JsonProperty]
        public bool RedBlue { get; set; } = false;
    }
}
