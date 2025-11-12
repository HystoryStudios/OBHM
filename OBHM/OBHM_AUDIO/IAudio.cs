

namespace OBHM.AUDIO
{
    public interface IAudio
    {
        string Name { get; }
        void Init();
        void LoadMusic(string path);
        void UnLoadMusic(string path);
        void PlayMusic();
        void StopMusic();
        float GetMusicTime();
        float GetMusicTimePlayed();
        void UpdateMusic();
        void SetMusicTime(float time);
    }
}
