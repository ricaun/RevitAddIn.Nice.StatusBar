# RevitAddIn.Nice.StatusBar

Sample with [Nice3point Template](https://github.com/Nice3point/RevitTemplates/wiki) with a status bar using [ricaun.Revit.UI.StatusBar](https://github.com/ricaun-io/ricaun.Revit.UI.StatusBar).

### Build project

Use the command ```.nuke/build.cmd Compile``` to build locally.

### Commands

The command `StatusBar` show a progress bar to test the library, the `Normal` command do the same but runs in the main default `Context`.

### Problem with Revit 2025

If you are using Revit 2025, you need to use the `ExternalCommand` from the toolkit, the Revit interface `IExternalCommand` can't be used.

When you run the command `StatusBar` and `Normal` after, you have the issue.

![image](https://github.com/user-attachments/assets/16630951-2851-4b1b-95ef-434f94e5ae03)

This should happen with any `xaml` if was loaded in the default `Context` and the plugin `Context`.

---