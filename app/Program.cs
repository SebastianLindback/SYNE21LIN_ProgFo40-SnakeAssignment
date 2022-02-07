using System.Threading;
using GruppInlUpp2kelett;

// Hjälpfunktion för att läsa knapptryckningar
// utan att bromsa upp spelet, som Console.ReadLine() gör
ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;


// Initialisera spelet
const int frameRate = 5;
GameWorld world = new GameWorld();
ConsoleRenderer renderer = new ConsoleRenderer(world);

Console.WriteLine("Press 'Enter' To Start!");
while (!(ReadKeyIfExists() == ConsoleKey.Enter))
{
    Thread.Sleep(50);
}

// TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
// ...
Player p = new Player();

// Huvudloopen
bool running = true;

while (running)
{
    // Kom ihåg vad klockan var i början
    DateTime before = DateTime.Now;

    // Hantera knapptryckningar från användaren
    ConsoleKey key = ReadKeyIfExists();
    switch (key)
    {
        case ConsoleKey.Q:
            running = false;
            break;

        // Ner
        case ConsoleKey.DownArrow:
            world.direction = Direction.Down;
            break;

        // Upp
        case ConsoleKey.UpArrow:
            world.direction = Direction.Up;
            break;

        // Höger
        case ConsoleKey.RightArrow:
            world.direction = Direction.Right;
            break;

        case ConsoleKey.LeftArrow:
            // Vänster
            world.direction = Direction.Left;
            break;
    }


    // Uppdatera världen och rendera om
    world.Update();

    running = renderer.Render();

    // Mät hur lång tid det tog
    double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
    if (frameTime > 0)
    {
        // Vänta rätt antal millisekunder innan loopens nästa varv
        Thread.Sleep((int)frameTime);
    }
}
Console.WriteLine("Game over!");
Thread.Sleep(5000);
enum Direction
{
    Up,
    Down,
    Right,
    Left
}
