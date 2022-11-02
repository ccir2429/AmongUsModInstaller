NOTE: This app will no longer be developed. It works good enough to solve my problem, and it has not been used by anyone else(from my knowledge).
If you ever ned any help installing a mod, I'd recommend asking in the official discord server of the mod you're trying to install.

# How to install?
Download the zip file from latest release or from [here](https://github.com/ccir2429/AmongUsModInstaller/releases/download/v1.2.3/AUModInstaller.v1.2.3.zip)

Simply unzip the file and double click on the  AUInstaller application file.
# How to use the app?
## Install from a list of compatible mods
1. Select a mod from the combo box
2. Select mod version (default is Latest)
2. Click the download button.
3. Optionally you can check the "Start game after install" checkbox. Now you just have to wait for the instalation to finish, and the game automatically starts.
## Install a custom mod 
 - This functionality was disabled, as it was considered obsolette.
## Start modded among us
 - If you already have a mod installed, you only need to select the version you want to play from the versions combo box, and click the play button.
# I get an error when I try to use the app!
The reason might be one of the following:
- Your windows defender wrongly detects the app as a risk. simply click on show more info, and then click run anyway.
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
