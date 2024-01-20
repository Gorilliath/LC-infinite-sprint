using GameNetcodeStuff;
using HarmonyLib;

namespace Gorilliath.InfiniteSprint.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void Update(ref float ___sprintMeter)
        {
            ___sprintMeter = 1f;
        }
    }
}
