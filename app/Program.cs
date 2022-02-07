using System.Threading;
using GruppInlUpp2kelett;

// Hjälpfunktion för att läsa knapptryckningar
// utan att bromsa upp spelet, som Console.ReadLine() gör
ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

// TODO Presentera eventuellt någon info eller meny här

// Initialisera spelet
const int frameRate = 5;
GameWorld world = new GameWorld();
ConsoleRenderer renderer = new ConsoleRenderer(world);

// TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
// ...
Player p = new Player(1);
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
            
            // TODO Lägg till logik för andra knapptryckningar
            // ...
    }

    // Uppdatera världen och rendera om
    world.Update();
    renderer.Render();

    // Mät hur lång tid det tog
    double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
    if (frameTime > 0)
    {
        // Vänta rätt antal millisekunder innan loopens nästa varv
        Thread.Sleep((int)frameTime);
    }
}