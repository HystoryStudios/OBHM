using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OBHM.OBHMFILE
{
    public class Whrite
    {
        private Music Music { get; set; }
        public Dictionary<double, List<Patern>> Notes {  get; set; }
        public float CurrentTime;
        public Whrite(Dictionary<double, List<Patern>> notes) 
        {
            Notes = notes;
        }
        public void LunchMusic(string musicpath)
        {
            Music = Raylib.LoadMusicStream(musicpath);
            Raylib.PlayMusicStream(Music);
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
