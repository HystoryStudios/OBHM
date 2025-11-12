using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
