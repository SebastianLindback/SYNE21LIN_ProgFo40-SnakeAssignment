using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    class ConsoleRenderer
    {
        private GameWorld world = new GameWorld();

        public ConsoleRenderer(GameWorld gameWorld)
        {
            Console.Title = "Snake | Gruppuppgift";
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            world = gameWorld;
        }

        public bool Render()
        {
            Console.Clear();

            GameObject.SnakeObject.Clear();
            GameObject.SnakeObject.Add(new Position(GameObject.pos.X, GameObject.pos.Y));

            try
            {
                Console.SetCursorPosition(GameObject.pos.X, GameObject.pos.Y);
            }
            catch
            {
                return false;
            }

            for (int i = 0; i < GameObject.SnakeObject.Count(); i++)
            {
                Console.SetCursorPosition(GameObject.SnakeObject[i].X, GameObject.SnakeObject[i].Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("■");
                Console.SetCursorPosition(0, 0);
            }
            return true;
        }
    }
}
