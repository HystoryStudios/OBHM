using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBHM.OBHMFILE
{
    public class Read
    {
        public string Path { get; set; }
        public Read(string path)
        {
            Path = path;
            ReadFile(path);
        }

        private Dictionary<float, PaternCircle> ReadFile(string path)
        {
            Dictionary<float, PaternCircle> level = new Dictionary<float, PaternCircle>();
            foreach (var line in File.ReadAllLines(path))
            {
                string[] item = line.Split(" ");
            }
            return level;
        }
    }
}
