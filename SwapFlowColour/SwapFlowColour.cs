using System;
using Harmony;

namespace SwapFlowColour
{
    [HarmonyPatch(typeof(BuildingCellVisualizerResources), "Initialize")]
    public class BuildingCellVisualizerResources_Patch
    {
        public static void Postfix(ref BuildingCellVisualizerResources __instance)
        {
            BuildingCellVisualizerResources.ConnectedDisconnectedColours input = __instance.liquidIOColours.input;
            __instance.liquidIOColours.input = __instance.liquidIOColours.output;
            __instance.liquidIOColours.output = input;

            BuildingCellVisualizerResources.ConnectedDisconnectedColours input2 = __instance.gasIOColours.input;
            __instance.gasIOColours.input = __instance.gasIOColours.output;
            __instance.gasIOColours.output = input2;
        }
    }
}