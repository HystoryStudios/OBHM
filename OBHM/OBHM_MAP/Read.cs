using OBHM.RENDER;
using OBHM.CORE;
using OBHM.AUDIO;

namespace OBHM.MAP
{
    public class Read
    {
        public string Path { get; set; }
        public Music Music { get; set; }
        public Read(string path)
        {
            Path = path;
        }

        public Dictionary<double, List<Patern>> ReadFile()
        {
            Dictionary<double, List<Patern>> level = new Dictionary<double, List<Patern>>();
            foreach (var line in File.ReadAllLines(Path))
            {
                string[] item = line.Split(" ");
                if (item[0] == "#")
                {
                    continue;
                }
                if (item[0] == "#MUSIC")
                {
                    Music = new Music() { FilePath = item[1] };
                }
                if (item.Length == 0)
                {
                    continue;
                }
                string clean = item[0].Trim('[', ']');

                TimeSpan ts = TimeSpan.ParseExact(clean, @"mm\:ss\.fff", null);

                double timeInSeconds = ts.TotalSeconds;

                Patern patern = new Patern(int.Parse(item[2]), int.Parse(item[3]), int.Parse(item[4]), int.Parse(item[5]), int.Parse(item[6]), Color.Red, item[1]);

                // Ajout à la liste associée à ce timestamp
                if (!level.ContainsKey(timeInSeconds))
                {
                    level[timeInSeconds] = new List<Patern>();
                }

                level[timeInSeconds].Add(patern);
            }
            return level;
        }
    }
}
