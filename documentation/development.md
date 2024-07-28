## Development Environment

1. **Setup Visual Studio 2022**

   - Ensure Visual Studio 2022 is installed with .NET Framework 4.8.
   - Open the `NoCrosshair.sln` file in Visual Studio.

2. **Project Configuration**
   - Right-click on the project and select "Properties."
   - Go to the "Build" section and select the "Debug" configuration.
   - Scroll down to the "Output" section and fix the output path to the location where your mods are loaded.
   - This location is specified by `UserDataFolder` in the `%appdata%\7DaysToDie\launchersettings.json` file.
   - Configure this using `7dLauncher.exe` and add the following in the "Additional parameters" field: `-UserDataFolder=C:\vortex_udf_7_days_to_die`.

### References (Libraries)

To build the DLL in Visual Studio, you need the following references. These libraries are also useful for checking the definitions of various game functions.

- **Fixing Library Paths**:

  - Due to potential mismatches between different development machines, the reference paths might be broken.
  - In the Solution Explorer, expand the "References" section.
  - Right-click on each reference and update the path in the properties window.

- **Required References**:
  - `7DaysToDie_Data\Managed\Assembly-CSharp.dll` (e.g., to import `IModApi`, `Mod`).
  - `Mods\0_TFP_Harmony\0Harmony.dll` (for importing `HarmonyLib`).
  - `7DaysToDie_Data\Managed\LogLibrary.dll` (for logging).

### Release

To build and zip the mod, follow these steps using NodeJS 20:

1. **Install NodeJS 20**: [Download NodeJS 20](https://github.com/coreybutler/nvm-windows)
2. **Build the Mod**:
   ```sh
   npm ci
   npm run build # generates the mod in zip format
   npm run generate_readme # generates markdown and bbcode for NexusMods
   ```
