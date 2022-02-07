using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    public class Position{
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
        public Position pos = new Position(0,0);
        char Appearance = '#';

        void Update(){

        }


        // TODO
        
    }
    /*
    Skapa klassen Player som ärver från GameObject. 
    Ge den en ordentlig konstruktor och en variabel som håller reda på spelarens riktning (upp, ner, vänster, höger - det kan vara en sträng eller en enum). 
    Implementera metoden Update() så att den, beroende på spelarens riktning, flyttar sin position ett steg i rätt riktning.
    */
    
    class Player : GameObject{
        public Player(int dir)
        {
            direction = dir;
        }
        public int direction { get; set;}
        void Update(){
            // Upp
            if(direction == 0)
            pos.Y++;
            // Ner
            if(direction == 1)
            pos.Y--;
            // Höger
            if(direction == 2)
            pos.X++;
            // Vänster
            if(direction == 3)
            pos.X--;
        }
    }
}
