using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OBHM.INPUT
{
    public interface IMouse
    {
        Vector2 GetMousePosition();
        bool IsMouseButtonDown(int button);
        bool IsMouseButtonUp(int button);
    }
}
