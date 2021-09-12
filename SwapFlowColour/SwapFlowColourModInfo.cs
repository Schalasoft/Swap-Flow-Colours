using HarmonyLib;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;

namespace SwapFlowColour
{
    public class SwapFlowColourModInfo : KMod.UserMod2
    {
        internal static POptions pOption { get; private set; }

        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            PUtil.InitLibrary(false);
            pOption = new POptions();
            pOption.RegisterOptions(this, typeof(SwapFlowColourOptions));
        }
    }
}