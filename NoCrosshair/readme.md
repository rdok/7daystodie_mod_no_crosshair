## Development Setup

- Visual Studio 2022 with .NET Framework 4.8. Open NoCrosshair.sln
- Right click on the project and select Properties. Select Build Section
- Change output to the location from where your mods are loaded. Which is either in the Mods folder of the game directory or a custom path specified by the `UserDataFolder` in the `%appdata%\7DaysToDie\launchersettings.json` file.
- Fix imported libraries.

## References

Import the following references (libraries). Modify their properties to do not include on their build. `Copy Local`. These have already been imported, but you'll have to correct the path to the steam folder. Expand References in the solution explorer window, right click on each, and fix the path in the properties window.

- 7DaysToDie_Data\Managed\Assembly-CSharp.dll e.g. to import IModApi, Mod.
- Mods\0_TFP_Harmony\0Harmony.dll for to import HarmonyLib
- 7DaysToDie_Data\Managed\LogLibrary.dll for logg
