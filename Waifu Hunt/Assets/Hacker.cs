using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        Terminal.WriteLine("Hello! Type 'menu' to play!");

        string name = "Julian";

        ShowMainMenu(name);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowMainMenu(string name)
    {

        Terminal.ClearScreen();

        Terminal.WriteLine("Oh, not you nosy " + name + " again!\n\nLevel 1: Your Classmate Nathan\nLevel 2: Uncle Dennis\nLevel 3: Your Crush Vivienne\n\nPlease type the number of the level you want to access!");
        /*
        Terminal.WriteLine("");
        Terminal.WriteLine("Level 1: Your Classmate Nathan");
        Terminal.WriteLine("Level 2: Uncle Dennis");
        Terminal.WriteLine("Level 3: Your Crush Vivienne");
        Terminal.WriteLine("");
        Terminal.WriteLine("Please type the number of the level you want to access!");

        
        Terminal.WriteLine("You're supposed to be studying, not hacking into other peoples privacy!");
        Terminal.WriteLine("...");

        Terminal.WriteLine("Oh well, I guess I can't stop you now. But let me please just explain a few things before you break anything.");
        Terminal.WriteLine("You currently have IPs from 3 different people, congrats.");
        Terminal.WriteLine("...");
        Terminal.WriteLine("I have heard that Nathans computer password is pretty weak, so you should start with him. Not that I would know what you wanted from a classmates Computer...");
        Terminal.WriteLine("Next one you should work on is your uncle Dennis. He has some fine resources, I have heard.");
        Terminal.WriteLine("Last but definitely not least you can try and get into your crush's PC. What was her name again? Vivienne?");
        Terminal.WriteLine("...");
        Terminal.WriteLine("Nathan and Dennis use real passwords, the emphasis being on the word part. Vivienne almost uses sentences. But I spy with my little eye that it may be some good film title.");
        Terminal.WriteLine("...");
        Terminal.WriteLine("So just write down the name of the person you want to gain access to and try to find out their passphrase!");
        */
    }

    void OnUserInput(string input)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(input + ", eh?");
        print(input == "1");

        if(input == "Menu" || input == "menu")
        {
            Terminal.ClearScreen();
            ShowMainMenu(name);
        }
        else if(input == "I am a dirty cheater")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Level 1: mobile, karate, tablet, console, friends");
            Terminal.WriteLine("Level 2: firefighter, politician, quarterback, headmaster, astronaut");
            Terminal.WriteLine("Level 3: from russia with love, diamonds are forever, the man with the golden gun, never say never again, quantum of solace");
        }
        else if (input == "GG" || input == "Gg" || input == "gg" || input == "gG")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine(input + " WP");
        }
        else
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Please type 'Menu' to proceed!");
        }


    }

}
