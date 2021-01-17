using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Workers_Resources_Soviet_RepublicModsInstaller
{
    public class Config
    {
        [JsonPropertyName("root-game-folder")]
        public string RootGameFolder { get; set; }

        [JsonPropertyName("folder-of-mods")]
        public string FolderOfMods { get; set; }

        public async static Task<Config> GetConfig(string path = null)
        {
            using (FileStream fs = new FileStream(path != null ? path : Directory.GetCurrentDirectory() + "\\conf.json", FileMode.OpenOrCreate))
            {
                return await JsonSerializer.DeserializeAsync<Config>(fs);
            }
        }
    }
}
