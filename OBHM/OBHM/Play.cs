using OBHM.MAP;
using OBHM.AUDIO;

namespace OBHM
{
    public class Play
    {
        Read Read {  get; set; }
        Write Write { get; set; }

        public Play(string mapPath, IAudio audio) 
        {
            Read = new Read(mapPath);
            Write = new Write(Read.ReadFile(), mapPath, audio);
        }
    }
}
