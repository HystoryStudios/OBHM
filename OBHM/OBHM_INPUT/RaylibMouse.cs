using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OBHM.INPUT
{
    public class RaylibMouse : IMouse
    {
        public Vector2 GetMousePosition()
        {
            return Raylib.GetMousePosition();
        }
        public bool IsMouseButtonDown(int button)
        {
            if (button == 0) return Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT);
            else if (button == 1) return Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_RIGHT);
            else if (button == 2) return Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_MIDDLE);
            else return false;
        }
        public bool IsMouseButtonUp(int button)
        {
            if (button == 0) return Raylib.IsMouseButtonUp(MouseButton.MOUSE_BUTTON_LEFT);
            else if (button == 1) return Raylib.IsMouseButtonUp(MouseButton.MOUSE_BUTTON_RIGHT);
            else if (button == 2) return Raylib.IsMouseButtonUp(MouseButton.MOUSE_BUTTON_MIDDLE);
            else return false;
        }
    }
}
