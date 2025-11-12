using Raylib_CsLo;

namespace OBHM.INPUT
{
    public class Raylib_Key : IKeyboard
    {
        public string Name => "Raylib";
        private static Dictionary<Keys, KeyboardKey> _map = new Dictionary<Keys, KeyboardKey>
        {
            // Lettres
            { Keys.A, KeyboardKey.KEY_A },
            { Keys.B, KeyboardKey.KEY_B },
            { Keys.C, KeyboardKey.KEY_C },
            { Keys.D, KeyboardKey.KEY_D },
            { Keys.E, KeyboardKey.KEY_E },
            { Keys.F, KeyboardKey.KEY_F },
            { Keys.G, KeyboardKey.KEY_G },
            { Keys.H, KeyboardKey.KEY_H },
            { Keys.I, KeyboardKey.KEY_I },
            { Keys.J, KeyboardKey.KEY_J },
            { Keys.K, KeyboardKey.KEY_K },
            { Keys.L, KeyboardKey.KEY_L },
            { Keys.M, KeyboardKey.KEY_M },
            { Keys.N, KeyboardKey.KEY_N },
            { Keys.O, KeyboardKey.KEY_O },
            { Keys.P, KeyboardKey.KEY_P },
            { Keys.Q, KeyboardKey.KEY_Q },
            { Keys.R, KeyboardKey.KEY_R },
            { Keys.S, KeyboardKey.KEY_S },
            { Keys.T, KeyboardKey.KEY_T },
            { Keys.U, KeyboardKey.KEY_U },
            { Keys.V, KeyboardKey.KEY_V },
            { Keys.W, KeyboardKey.KEY_W },
            { Keys.X, KeyboardKey.KEY_X },
            { Keys.Y, KeyboardKey.KEY_Y },
            { Keys.Z, KeyboardKey.KEY_Z },

            // Chiffres (ligne supérieure)
            { Keys.D0, KeyboardKey.KEY_ZERO },
            { Keys.D1, KeyboardKey.KEY_ONE },
            { Keys.D2, KeyboardKey.KEY_TWO },
            { Keys.D3, KeyboardKey.KEY_THREE },
            { Keys.D4, KeyboardKey.KEY_FOUR },
            { Keys.D5, KeyboardKey.KEY_FIVE },
            { Keys.D6, KeyboardKey.KEY_SIX },
            { Keys.D7, KeyboardKey.KEY_SEVEN },
            { Keys.D8, KeyboardKey.KEY_EIGHT },
            { Keys.D9, KeyboardKey.KEY_NINE },

            // Touches spéciales
            { Keys.Space, KeyboardKey.KEY_SPACE },
            { Keys.Tab, KeyboardKey.KEY_TAB },
            { Keys.Escape, KeyboardKey.KEY_ESCAPE },
            { Keys.Enter, KeyboardKey.KEY_ENTER },
            { Keys.Backspace, KeyboardKey.KEY_BACKSPACE },
            { Keys.Left_Shift, KeyboardKey.KEY_LEFT_SHIFT },
            { Keys.Right_Shift, KeyboardKey.KEY_RIGHT_SHIFT },
            { Keys.Left_Control, KeyboardKey.KEY_LEFT_CONTROL },
            { Keys.Right_Control, KeyboardKey.KEY_RIGHT_CONTROL },
            { Keys.Left_Alt, KeyboardKey.KEY_LEFT_ALT },
            { Keys.Right_Alt, KeyboardKey.KEY_RIGHT_ALT },
            { Keys.Left_Super, KeyboardKey.KEY_LEFT_SUPER },
            { Keys.Right_Super, KeyboardKey.KEY_RIGHT_SUPER },
            { Keys.Caps_Lock, KeyboardKey.KEY_CAPS_LOCK },
            { Keys.Num_Lock, KeyboardKey.KEY_NUM_LOCK },
            { Keys.Scroll_Lock, KeyboardKey.KEY_SCROLL_LOCK },
            { Keys.Print_Screen, KeyboardKey.KEY_PRINT_SCREEN },
            { Keys.Insert, KeyboardKey.KEY_INSERT },
            { Keys.Delete, KeyboardKey.KEY_DELETE },
            { Keys.Home, KeyboardKey.KEY_HOME },
            { Keys.End, KeyboardKey.KEY_END },
            { Keys.Page_Up, KeyboardKey.KEY_PAGE_UP },
            { Keys.Page_Down, KeyboardKey.KEY_PAGE_DOWN },

            // Flèches directionnelles
            { Keys.Up_Arrow, KeyboardKey.KEY_UP },
            { Keys.Down_Arrow, KeyboardKey.KEY_DOWN },
            { Keys.Left_Arrow, KeyboardKey.KEY_LEFT },
            { Keys.Right_Arrow, KeyboardKey.KEY_RIGHT },

            // Pavé numérique
            { Keys.Num_0, KeyboardKey.KEY_KP_0 },
            { Keys.Num_1, KeyboardKey.KEY_KP_1 },
            { Keys.Num_2, KeyboardKey.KEY_KP_2 },
            { Keys.Num_3, KeyboardKey.KEY_KP_3 },
            { Keys.Num_4, KeyboardKey.KEY_KP_4 },
            { Keys.Num_5, KeyboardKey.KEY_KP_5 },
            { Keys.Num_6, KeyboardKey.KEY_KP_6 },
            { Keys.Num_7, KeyboardKey.KEY_KP_7 },
            { Keys.Num_8, KeyboardKey.KEY_KP_8 },
            { Keys.Num_9, KeyboardKey.KEY_KP_9 },
            { Keys.Num_Divide, KeyboardKey.KEY_KP_DIVIDE },
            { Keys.Num_Multiply, KeyboardKey.KEY_KP_MULTIPLY },
            { Keys.Num_Subtract, KeyboardKey.KEY_KP_SUBTRACT },
            { Keys.Num_Add, KeyboardKey.KEY_KP_ADD },
            { Keys.Num_Decimal, KeyboardKey.KEY_KP_DECIMAL },
            { Keys.Num_Enter, KeyboardKey.KEY_KP_ENTER },

            // Touches de fonction
            { Keys.F1, KeyboardKey.KEY_F1 },
            { Keys.F2, KeyboardKey.KEY_F2 },
            { Keys.F3, KeyboardKey.KEY_F3 },
            { Keys.F4, KeyboardKey.KEY_F4 },
            { Keys.F5, KeyboardKey.KEY_F5 },
            { Keys.F6, KeyboardKey.KEY_F6 },
            { Keys.F7, KeyboardKey.KEY_F7 },
            { Keys.F8, KeyboardKey.KEY_F8 },
            { Keys.F9, KeyboardKey.KEY_F9 },
            { Keys.F10, KeyboardKey.KEY_F10 },
            { Keys.F11, KeyboardKey.KEY_F11 },
            { Keys.F12, KeyboardKey.KEY_F12 },

            // Autres symboles
            { Keys.Tilde, KeyboardKey.KEY_GRAVE },
            { Keys.Minus, KeyboardKey.KEY_MINUS },
            { Keys.Equal, KeyboardKey.KEY_EQUAL },
            { Keys.Left_Bracket, KeyboardKey.KEY_LEFT_BRACKET },
            { Keys.Right_Bracket, KeyboardKey.KEY_RIGHT_BRACKET },
            { Keys.Backslash, KeyboardKey.KEY_BACKSLASH },
            { Keys.Semicolon, KeyboardKey.KEY_SEMICOLON },
            { Keys.Apostrophe, KeyboardKey.KEY_APOSTROPHE },
            { Keys.Comma, KeyboardKey.KEY_COMMA },
            { Keys.Period, KeyboardKey.KEY_PERIOD },
            { Keys.Slash, KeyboardKey.KEY_SLASH },
};


        public bool IsKeyDown(Keys key)
        {
            _map.TryGetValue(key, out KeyboardKey Rkey);
            return Raylib.IsKeyDown(Rkey);
        }
        public bool IsKeyPressed(Keys key)
        {
            _map.TryGetValue(key, out KeyboardKey Rkey);
            return Raylib.IsKeyPressed(Rkey);
        }

        public bool IsKeyUp(Keys key)
        {
            _map.TryGetValue(key, out KeyboardKey Rkey);
            return Raylib.IsKeyUp(Rkey);
        }

        public void Update()
        {

        }
    }
}
