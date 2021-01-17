using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace Workers_Resources_Soviet_RepublicModsInstaller
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Config config = await Config.GetConfig();

            string RootGameModsFolder = config.RootGameFolder + "\\media_soviet\\workshop_wip";
            string FolderWithMods = config.FolderOfMods.Length != 0 ? config.FolderOfMods : Directory.GetCurrentDirectory() + "\\mods";

            if (!Directory.Exists(RootGameModsFolder)) Directory.CreateDirectory(RootGameModsFolder);
            if (!Directory.Exists(FolderWithMods)) Directory.CreateDirectory(FolderWithMods);

            string[] ModsList = Directory.GetFiles(FolderWithMods);

            if (ModsList.Length == 0)
            {
                System.Console.WriteLine("Mods folder is empty");
                System.Console.ReadKey();
                return;
            }

            foreach (var item in ModsList)
            {
                string PathToFolderWithMod = item.Split("_")[0];
                string[] ArrayFolderNamesPath = PathToFolderWithMod.Split("\\");
                string ForlderNameWithMod = PathToFolderWithMod.Split("\\")[ArrayFolderNamesPath.Length - 1];
                string PathToWorkshopFloder = RootGameModsFolder + $"\\{ForlderNameWithMod}";

                try
                {
                    ZipFile.ExtractToDirectory(item, PathToWorkshopFloder);

                    System.Console.WriteLine($"Installed MOD {ForlderNameWithMod}");
                }
                catch (System.IO.IOException)
                {
                    System.Console.WriteLine($"Mod {ForlderNameWithMod} already exists");
                }
            }
            System.Console.WriteLine("Successfully");
            System.Console.ReadKey();
        }
    }
}