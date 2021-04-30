# How to install?
Download the zip file from latest release or from [here](https://github.com/ccir2429/AmongUsModInstaller/releases/download/1.1.1/AUModInstaller.zip)

Simply unzip the file and double click on the  AmongUsModLauncher exe.
# How to install a mod?
## Install from a list of compatible mods
1. Select a mod from the combo box
2. Click the download button.
3. * optionally you can check the "Start game after install" checkbox. now you just have to wait for the instalation to finish, and the game automatically starts.
## Install a custom mod 
 - this functionality was disabled, as it was considered obsolette.
# I get an error when I try to use the app!
The reason might be one of the following:
- You are missing the "CompatibleMods" json file => download the json again, and put it in the same folder as the app.
- Your steamapps folder is wrong => try using the settings button in the top left side and change the Steam\steamapps\common\ folder properly.
- - This will be fixed in future update, so the app knows where steam and among us are installed.
- Your internet connection is not stable. either fix it, or try again until it works.
- - future update will have an indicator so you can see if your connection is bad or not.
If you tried all the above and you still get an error, post it as a new issue in the Issues tab [here](https://github.com/ccir2429/AmongUsModLauncher/issues)
# I can't find the Mod 
The mods will be installed in the Steam\steamapps\common\ folder, It will be created in a Among Us Mods folder. If you can't find it, call a friend, or post an issue.
# How to add custom mods to the combobox?
# Modifying the JSON file 
In the app folder you will find a "CompatibleMods" JSON file. The JSON file should have an example of a custom version and a latest version mod JObject. 
- The JObject used is an extension of the Git Api object. 
- More infos about each property can be found in the ModModel class.
- THIS FUNCTIONALITY IS CONSIDERED OBSOLETTE, consider updating the json at your own risk.
