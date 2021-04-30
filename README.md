# How to install?
Download the zip file from latest release or from [here](https://github.com/ccir2429/AmongUsModLauncher/releases/download/beta-1.0.0/Among.Us.Mod.Installer.zip)

Simply unzip the file and double click on the  AmongUsModLauncher exe.
# How to install a mod?
## Install from a list of compatible mods
1. Select a mod from the combo box
2. Click the "Add Mod" button.
## Install a custom mod 
Select "Add custom mod" from the combo box, Type in the mod developer name and the mod name in the corresponding text boxes and click the "Add Mod" button 
# I get an error when I try to use the app!
The reason might be one of the following:
- You are missing the "CompatibleMods" json file => download the json again, and put it in the same folder as the app.
- Your steamapps folder is wrong => try using the settings button in the top left side and change the Steam\steamapps\common\ folder properly.
- Your internet connection is not stable. either fix it, or try again until it works.
If you tried all the above and you still get an error, post it as a new issue in the Issues tab [here](https://github.com/ccir2429/AmongUsModLauncher/issues)
# I can't find the Mod 
The mods will be installed in the Steam\steamapps\common\ folder, It will be created in a Among Us Mods folder. 
# How to add custom mods to the combobox?
# Modifying the JSON file 
In the app folder you will find a "CompatibleMods" JSON file. The JSON file should have an example of a custom version and a latest version mod JObject. 
- The JObject used is an extension of the Git Api object. 
- More infos about each property can be found in the ModModel class.
