using System;

namespace MysteryTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
             /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type YES or NO:");
      string noiseChoice = Console.ReadLine();
      string loudNoise = noiseChoice.ToUpper();
      if(loudNoise == "NO"){
        Console.WriteLine("Not much of an adventure if you don't leave your room! The End."); 
        } else if (loudNoise == "YES"){
          Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      }
      Console.WriteLine("Type OPEN or KNOCK:");
      string doorChoice = Console.ReadLine();
      string loudDoor = doorChoice.ToUpper();
      if(loudDoor == "KNOCK"){
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: ");
        Console.WriteLine("Poor people have. Rich people need it. If you eat it you die. What is it?");
      } else if(loudDoor == "OPEN"){
        Console.WriteLine("derp");
      }
        }
    }
}
