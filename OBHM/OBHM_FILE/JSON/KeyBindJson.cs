using System.Text.Json;
using OBHM.GAMESETTINGS;

namespace OBHM.FILE.JSON
{
    public class KeyBindJson
    {
        public string FileName = "KeyBind";

        public KeyBinds BasicKB = new KeyBinds()
        {
            Up = INPUT.Keys.Up_Arrow,
            Down = INPUT.Keys.Down_Arrow,
            Left = INPUT.Keys.Left_Arrow,
            Right = INPUT.Keys.Right_Arrow,
            Speed = INPUT.Keys.Left_Shift
        };
        public KeyBinds Read()
        {
            try
            {
                string keyBind = File.ReadAllText($"{FileName}.json");
                KeyBinds kb = JsonSerializer.Deserialize<KeyBinds>(keyBind);
                return kb;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message); // just for debug
            }
            return BasicKB;
        }
    }
}
