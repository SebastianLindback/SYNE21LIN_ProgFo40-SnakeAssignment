using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    class GameWorld
    {
        Player player = new Player();
        Food food = new Food();
        public static bool matredo = true;

        public void Update()
        {
            player.Update();

            if (matredo)
            {
                food.Update();
                matredo = !matredo;
            }
        }
    }
}
