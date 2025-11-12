using OBHM.AUDIO;
using OBHM.CORE;
using OBHM.RENDER;
using System.Numerics;

namespace OBHM.MAP
{
    public class Write
    {
        private Music Music { get; set; }
        public Dictionary<double, List<Patern>> Notes {  get; set; }
        public string LevelPath;
        public float CurrentTime;
        private IAudio Audio { get; set; }
        public Write(Dictionary<double, List<Patern>> notes, string levelpath, IAudio audio) 
        {
            Notes = notes;
            LevelPath = levelpath;
            Audio = audio;
        }
        public void LunchMusic(string musicpath)
        {
            Audio.LoadMusic(musicpath);
            Audio.PlayMusic();
        }
        public void Unload()
        {
            Audio.StopMusic();
            Audio.UnLoadMusic(Music.FilePath);
        }
        public void Update(Vector2 pp, int ps, IRender render)
        {
            Audio.UpdateMusic();
            CurrentTime = Audio.GetMusicTimePlayed();
            foreach (var note in Notes)
            {
                if (note.Key <= CurrentTime)
                {
                    foreach (var nt in note.Value)
                    {
                        nt.Update(pp, ps, render);
                    }
                }
            }
        }
        public void Draw(IRender render)
        {
            CurrentTime = Audio.GetMusicTimePlayed();
            foreach (var note in Notes)
            {
                if (note.Key <= CurrentTime)
                {
                    foreach (var nt in note.Value)
                    {
                        nt.Draw(render);
                    }
                }
            }
        }
    }
}
