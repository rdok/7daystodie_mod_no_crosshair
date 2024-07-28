using HarmonyLib;
using System.Reflection;

public class NoCrosshair
{
    public class NoCrosshairInit : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            Log.Out(" Loading Patch: " + GetType());
            var harmony = new HarmonyLib.Harmony(GetType().ToString());
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(ItemClass))]
    [HarmonyPatch("GetCrosshairType")]
    public class NoCrosshair_ItemClass_Crosshair
    {
        private static ItemClass.EnumCrosshairType Postfix(ItemClass.EnumCrosshairType __result)
        {
            return ItemClass.EnumCrosshairType.None;
        }
    }
}
