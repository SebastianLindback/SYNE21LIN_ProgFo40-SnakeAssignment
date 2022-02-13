 using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    public class Position
    {
            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set;}
            public int Y { get; set;}
    }
    abstract class GameObject
    {
        public static Position pos = new Position(50 / 2, 20 / 2);
        public static List<Position> SnakeObject = new List<Position>();
        public static Position FoodPos { get; set; }

        char Appearance = '#';

        void Update()
        {
        }
        // TODO
    }

    /*
    Skapa klassen Player som ärver från GameObject. 
    Ge den en ordentlig konstruktor och en variabel som håller reda på spelarens riktning (upp, ner, vänster, höger - det kan vara en sträng eller en enum). 
    Implementera metoden Update() så att den, beroende på spelarens riktning, flyttar sin position ett steg i rätt riktning.
    */

    class Player : GameObject
    {
        public static Direction direction = new Direction();
        public static List<Tuple<int,int>> historyPosition = new List<Tuple<int,int>>();
        public Player()
        {
            direction = Direction.Right;
            
        }
        
        public void Update()
        {
            
            if (direction == Direction.Down)
            {
                GameObject.pos.Y++;
            }
            if (direction == Direction.Up)
            {
                GameObject.pos.Y--;
            }
            if (direction == Direction.Left)
            {
                GameObject.pos.X--;
            }
            if (direction == Direction.Right)
            {
                GameObject.pos.X++;
            }
            foreach (var item in GameObject.SnakeObject)
            { 
                historyPosition.Insert(0, (Tuple.Create(item.X, item.Y)));
                if (historyPosition.Count > 100){historyPosition.RemoveAt(100);}
            }
        }
    }
    class Food : GameObject
    {
        public Food()
        {
        }
        public void Update()
        {
            Random rand = new Random();
            FoodPos = new Position(rand.Next(0, Console.WindowWidth), rand.Next(0, Console.WindowHeight));
        }
    }
}
