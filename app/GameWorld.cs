using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    class GameWorld
    {
        public Direction direction = new Direction();
        public Player player = new Player();

        public void Update()
        {
            player.Update(direction);
        }
    }
}
