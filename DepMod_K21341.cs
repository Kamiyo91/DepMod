using BepInEx;
using HarmonyLib;

namespace DepMod
{
    [BepInPlugin("Dep.Kamiyo.Mods", "Dep Mod", "1.0")]
    public class DepMod_K21341 : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("Dep.Kamiyo.Mods").CreateClassProcessor(typeof(HarmonyPatch_K21341)).Patch();
        }
    }
}