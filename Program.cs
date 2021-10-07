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
        Console.WriteLine("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        string loudAnswer = riddleAnswer.ToUpper();
        if(loudAnswer == "NOTHING"){
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
          } else {
            Console.WriteLine("You answered incorrectly. The door does not open.  THE END.");;
        }
      } else if(loudDoor == "OPEN"){
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.WriteLine("Enter a number between 1 and 3");
        string keyChoice = Console.ReadLine();
        string loudKey = keyChoice.ToUpper();
        switch(loudKey){
          case "1":
            Console.WriteLine("You chose the first key. Lucky you. The door opens and NOTHING is there. Strange...   THE END.");
            break;
          case "2":
            Console.WriteLine("You chose the second key. The door does not open.  THE END.");
            break;
          case "3":
            Console.WriteLine("You chose the third key. The door does not open.  THE END.");
            break;
          default:
            Console.WriteLine("Nope. You invalid. THE END.");
                break;
        }
      }
        }
    }
}
