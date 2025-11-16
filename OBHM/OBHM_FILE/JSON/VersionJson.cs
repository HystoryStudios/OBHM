using System.Text.Json;

namespace OBHM.FILE.JSON
{
    public class VersionJson
    {
        public string GameVersion { get; set; }
        public string FileName = "GameVersion";
        public VersionJson()
        {
            SetFile();
            GetData();
        }

        public void SetFile()
        {
            string jsonString = JsonSerializer.Serialize(GameVersion, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText($"{FileName}.json", jsonString);
        }
        public void GetData()
        {
            string jsonString = File.ReadAllText($"{FileName}.json");
            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                if (document.RootElement.TryGetProperty("GameVersion", out JsonElement GameVersionEll))
                {
                    GameVersion = GameVersionEll.GetString();
                }
            }
        }
    }
}
