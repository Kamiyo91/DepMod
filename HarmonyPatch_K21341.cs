using HarmonyLib;

namespace DepMod
{
    [HarmonyPatch]
    public class HarmonyPatch_K21341
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(HallWorld), nameof(HallWorld.RoleFinishModuleCheck))]
        public static void HallWorld_RoleFinishModuleCheck(ref bool __result)
        {
            __result = false;
        }
    }
}