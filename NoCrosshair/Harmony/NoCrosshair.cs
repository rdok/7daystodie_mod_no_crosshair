using HarmonyLib;

public class NoCrosshair
{
    public class NoCrosshairInit : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            Log.Out("Loading Patch: " + GetType());
            var harmony = new Harmony(GetType().ToString());
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(NGuiWdwInGameHUD), "Start")]
    public static class StartPatch
    {
        public static void Postfix(NGuiWdwInGameHUD nGuiWdwInGameHUD)
        {
            nGuiWdwInGameHUD.showCrosshair = false;
        }
    }
}

