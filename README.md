# wrsr-mod-installer

Mod Installer For Pirated Version Game "Workers Resources Soviet Republic"

## Installing

1. Clone this repository
2. Build the console application
   `dotnet build --configuration Release`
3. Go to folder `./bin/Release/{net5|netcoreapp3.1}/publish`
4. Create conf.json file if is not created, and insert in it this markup

   ```json
   {
     "root-game-folder": "{path to game folder}",
     "folder-of-mods": "{path to the folder with mod archives , default: ./mods}"
   }
   ```

5. Fill in all the field in conf.json file
6. Run "Workers Resources Soviet Republic Mods Installer.exe" file , to he created desired folders

## Using

1. You download any mods on Steam Workshop, through any SteamWorkshop [downloader](https://steamworkshopdownloader.io/)
2. Downloaded by you archive should have a name which should match the pattern "{numbers}\_{name}.zip"
3. Move Downloaded by you archive in folder which you specified in config.json file , or in ./mods
4. Run Run "Workers Resources Soviet Republic Mods Installer.exe" file , to he install all mods , in `{root-game-folder}/media_soviet/workshop_wip`
