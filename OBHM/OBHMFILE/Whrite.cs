using Raylib_CsLo;
using System.Numerics;

namespace OBHM.OBHMFILE
{
    public class Whrite
    {
        private Music Music { get; set; }
        public Dictionary<double, List<Patern>> Notes {  get; set; }
        public string LevelPath;
        public float CurrentTime;
        public Whrite(Dictionary<double, List<Patern>> notes, string levelpath) 
        {
            Notes = notes;
            LevelPath = levelpath;
        }
        public void LunchMusic(string musicpath)
        {
            Music = Raylib.LoadMusicStream(musicpath);
            Raylib.PlayMusicStream(Music);
        }
        public void Unload()
        {
            Raylib.UnloadMusicStream(Music);
            Raylib.StopMusicStream(Music);
        }
        public void Update(Vector2 pp, int ps)
        {
            Raylib.UpdateMusicStream(Music);

            CurrentTime = Raylib.GetMusicTimePlayed(Music);
            foreach (var note in Notes)
            {
                if (note.Key <= CurrentTime)
                {
                    foreach (var nt in note.Value)
                    {
                        nt.Update(pp, ps);
                    }
                }
            }
        }
        public void Draw()
        {
            Raylib.UpdateMusicStream(Music);

            CurrentTime = Raylib.GetMusicTimePlayed(Music);
            foreach (var note in Notes)
            {
                if (note.Key <= CurrentTime)
                {
                    foreach (var nt in note.Value)
                    {
                        nt.Draw();
                    }
                }
            }
        }
    }
}
