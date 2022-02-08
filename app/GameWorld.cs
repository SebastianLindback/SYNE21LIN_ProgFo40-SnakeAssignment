using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    class GameWorld
    {
        Player player = new Player();
        Food food = new Food();

        public void Update()
        {
            player.Update();
            food.Update();
        }
    }
}
