
using UnityEngine;

public class Hacker : MonoBehaviour
{

    //Game Config

    string[] Level1Password = { "mobile", "karate", "tablet", "console", "friends" };
    string[] Level2Password = { "firefighter", "politician", "quarterback", "headmaster", "astronaut" };
    string[] Level3Password = { "from russia with love", "diamonds are forever", "the man with the golden gun", "never say never again", "quantum of solace" };


    //Game state
    int level;

    enum Screen {Intro, Menu, Password, Win};
    Screen currentScreen;

    string password;

    // Start is called before the first frame update
    void Start()
    {

        Terminal.WriteLine("Hello! Type 'menu' to play!");

        string name = "Player";

        currentScreen = Screen.Intro;

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

        if(input == "Menu" || input == "menu")
        {
            currentScreen = Screen.Menu;
            Terminal.ClearScreen();
            ShowMainMenu("Player");
        }
        else if(currentScreen == Screen.Menu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            Level(input);
        }
        else if(currentScreen == Screen.Win)
        {
            WinScreen();
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1" || input == "2" || input == "3")
        {
            level = int.Parse(input);

            int index = Random.Range(0, Level1Password.Length);

            if (input == "1")
            {
                password = Level1Password[index];
            }
            else if(input == "2")
            {
                password = Level2Password[index];
            }
            else if(input == "3")
            {
                password = Level3Password[index];
            }
            else
            {
                Debug.LogError("Invalid Level Number");
            }

            StartGame();
            currentScreen = Screen.Password;
        }
        else if (input == "WahCheater")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Level 1: mobile, karate, tablet, console, friends\n" +
                               "Level 2: firefighter, politician, quarterback, headmaster, astronaut\n" +
                               "Level 3: from russia with love, diamonds are forever, the man with the golden gun, never say never again, quantum of solace");
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

    void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("\nType the password to proceed!\nHint:" + password.Anagram());
    }

    void Level(string input)
    {
        if(level == 1 && input == password || level == 2 && input == password || level == 3 && input == password)
        {
            currentScreen = Screen.Win;
            WinScreen();
        }
        else
        {
            StartGame();
        }
    }


    void WinScreen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("GGWP, type menu to go back.");

        if(level == 1)
        {
            Terminal.WriteLine(@"
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
 XXXXXXXXXXXXXXXXXX         XXXXXXXX
XXXXXXXXXXXXXXXX              XXXXXXX
XXXXXXXXXXXXX                   XXXXX
 XXX     _________ _________     XXX
  XX    I  _xxxxx I xxxxx_  I    XX
 ( X----I         I         I----X )
( +I    I      00 I 00      I    I+ )
 ( I    I    __0  I  0__    I    I )
  (I    I______ /   \_______I    I)
   I           ( ___ )           I
   I    _  :::::::::::::::  _    i
    \    \___ ::::::::: ___/    /
     \_      \_________/      _/
       \        \___,        /
         \                 /
          |\             /|
          |  \_________/  |");
        }
        else if(level == 2)
        {
            Terminal.WriteLine(@"
                _____    ____
             .#########.#######..
          .#######################.
        .############################.
       .################################.
      .#########,##,#####################.
     .#########-#,'########## ############.
    .######'#-##' # ##'### #. `####:#######.
    #####:'# #'###,##' # # +#. `###:':######
   .####,'###,##  ###  # # #`#. -####`######.
  .####+.' ,'#  ##' #   # # #`#`.`#####::####
  ####'    #  '##'  #   #_'# #.## `#######;##
  #:##'      '       #   # ``..__# `#######:#
  #:##'  .#######s.   #.  .s######.\`#####:##
  #:##   .'______'''    '''_____''. `.#####:#
 .#:##   ><'(##)'> )    ( <'(##)`><   `####;#
 ##:##  , , -==-' '.    .` `-==- . \  ######'
 #|-'| / /      ,  :    : ,       \ ` :####:'
 :#  |: '  '   /  .     .  .  `    `  |`####
 #|  :|   /   '  '       `  \   . ,   :  #:# 
 #L. | | ,  /   `.-._ _.-.'   .  \ \  : ) J##
###\ `  /  '                   \  : : |  /##
 ## #|.:: '       _    _        ` | | |'####
 #####|\  |  (.-'.__`-'__.`-.)   :| ' ######
 ######\:      `-...___..-' '     :: /######
 #######\``.                   ,'|  /#######
.# ######\  \       ___       / /' /#######
# #'#####|\  \    -     -    /  ,'|### #. #.
`#  #####| '-.`             ' ,-'  |### #  #
    #' `#|    '._         ,.-'     #`#`#.
         |       .'------' :       |#   #
         |       :         :       |
         |       :         :       |
                 :         :         ");
        }
        else if(level ==3)
        {
            Terminal.WriteLine(@"
            _...._
        _.dMMMMMMMMMb.
    ..dMMMMMMMMMMMMMMMb
  .dMMMMMMMMMMMMMMMMMMMMb.
 dMMMMMMMMMMMMMMMMMMMMMMMM.
 MMMMMMMP'`YMMMMMMMMMMMMMMMb
 MMMMMMP    MMMMMMMMMMMMMMMM
dMMMMMP     `MMMMMMMMMMMMMMMb
MMMMMM~=,,_  `MMMMMMMMMMMMMMM
MMMMMMP,6;    `MMMMMMMMMMMMMMb
MMMMMM|         ```^YMMMMMMMMM
MMMMMM:   -~        / |MMMMMMMb
`MMMMM/\  _.._     /  |MMMMMMMM
  `YMM\_`.`~--'    \__/MMMMMMMM!
    MMMMMM\       _.' _sS}MMMMMb
    `YMMMMMb.__.sP.---.  MMMMMMM
      ``YMMMMMMMP'        \MMMMMb
          ``MMMd;          MMMMMM
              dP|          :MMMMMb.
          _.sP'             :MMMMMM
      _.s888P'   ,  .-. .-. |MMMMM}
   .s888888P    ,_|(  fsc  )|MMMM
 .d88888888;     `\ `-._.-' ;;M'
 8888888888|       :         :;,
 8888888888;       |         |`;,_
 `Y88888888b     _,:         |/Y\;
    `^Y88888ssssSP~':        ; SsP /
        '''\        |         ;
            ;       |         |
            ;       ;         |
           /      .'          |
         .'    .-'            ;
        / _...-'             .'\
      .'              _..-'     :
     /        __.--""            :
            ");
        }
    }

}
