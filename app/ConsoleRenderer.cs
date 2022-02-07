using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    class ConsoleRenderer
    {
        private GameWorld world;

        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera Console-fönstret enligt världens storlek
            // med hjälp av Console.SetWindowSize(int, int)
            Console.SetWindowSize(50, 20);
            
            world = gameWorld;
        }

        public void Render()
        {
            Console.Clear();
            
            

            // TODO Rendera spelvärlden (och poängräkningen) t.ex. såhär:
            /*
            foreach (var obj in world.AllObjects)
            {
                Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                Console.Write(obj.Appearance);
            }
            */
        }
    }
}
