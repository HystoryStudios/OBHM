

namespace OBHM.INPUT
{
    public interface IKeyboard
    {
        string Name { get; }
        bool IsKeyDown(Keys key);
        bool IsKeyUp(Keys key);
        bool IsKeyPressed(Keys key);
        void Update(); // Useless for a lot of framework
    }
}
