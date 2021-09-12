using HarmonyLib;
using PeterHan.PLib.Options;
using UnityEngine;

namespace SwapFlowColour
{
    [HarmonyPatch(typeof(BuildingCellVisualizerResources), "Initialize")]
    public class BuildingCellVisualizerResources_Patch
    {
        public static void Postfix(ref BuildingCellVisualizerResources __instance)
        {
            SwapFlowColourAssets.Options = POptions.ReadSettings<SwapFlowColourOptions>() ?? new SwapFlowColourOptions();

            if (SwapFlowColourAssets.Options.RedBlue)
                RedBlue(__instance);
            else
                SwapFlowColour(__instance);

        }

        static void RedBlue(BuildingCellVisualizerResources instance)
        {
            // Connections
            Color32 blueInputConnected     = Color.blue;
            Color32 blueInputDisconnected  = Color.blue;
            Color32 redOutputConnected     = Color.red;
            Color32 redOutputDisconnected  = Color.red;

            // Liquid
            instance.liquidIOColours.input.connected     = blueInputConnected;
            instance.liquidIOColours.input.disconnected  = blueInputDisconnected;
            instance.liquidIOColours.output.connected    = redOutputConnected;
            instance.liquidIOColours.output.disconnected = redOutputDisconnected;

            // Gas
            instance.gasIOColours.input.connected        = blueInputConnected;
            instance.gasIOColours.input.disconnected     = blueInputDisconnected;
            instance.gasIOColours.output.connected       = redOutputConnected;
            instance.gasIOColours.output.disconnected    = redOutputDisconnected;
        }

        static void SwapFlowColour(BuildingCellVisualizerResources instance)
        {
            BuildingCellVisualizerResources.ConnectedDisconnectedColours input = instance.liquidIOColours.input;
            instance.liquidIOColours.input  = instance.liquidIOColours.output;
            instance.liquidIOColours.output = input;

            BuildingCellVisualizerResources.ConnectedDisconnectedColours input2 = instance.gasIOColours.input;
            instance.gasIOColours.input  = instance.gasIOColours.output;
            instance.gasIOColours.output = input2;
        }
    }
}