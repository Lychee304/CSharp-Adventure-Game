using CSharp_Adventure_Console_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class WaterStone
    {
        // ██

        // dont forget adding _ before these private vars


        // when our mike wazowski talks :)


        // Console.ForegroundColor = ConsoleColor.Cyan;
        // TextUtilities.Type("nuh uhh, AYO CHAT CLIP THAT", 40);
        // Console.ForegroundColor = ConsoleColor.White;


        private string _jake;

        private int _baja = 0;

        private string _playerName = "";

        private int _pHP = 50; // player health points

        private int _pAP = 2; // player attack points

        public void WaterStonePV()
        {
            Console.ResetColor();

            // logo :D

            Console.ForegroundColor = ConsoleColor.Green; // testing     its like 9 months later i dont even remember what i was testing here
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("                                                                                         Like.. 70% AI FREE!!!!                                            ");
            Console.WriteLine("                                                                                                                                                           ");
            Console.WriteLine("     ██      ███      ██   ████████   ██████████   ████████    ██████         ████████   ██████████    ██████     ██      ██   ████████                    ");
            Console.WriteLine("      ██    ██ ██    ██    ██    ██       ██       ██          ██    ██       ██             ██      ██      ██   ████    ██   ██                          ");
            Console.WriteLine("       ██  ██   ██  ██     ████████       ██       ████████    ██████         ████████       ██      ██      ██   ██  ██  ██   ████████                    ");
            Console.WriteLine("        ████     ████      ██    ██       ██       ██          ██   ██              ██       ██      ██      ██   ██    ████   ██                          ");
            Console.WriteLine("         ██       ██       ██    ██       ██       ████████    ██     ██      ████████       ██        ██████     ██      ██   ████████        The Original");
            Console.WriteLine("                                                                                                                                                           ");
            Console.WriteLine("            *insert water dropping sfx here*                                                                                                               ");

            Console.ResetColor();
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                     ");
            Console.WriteLine(" well... i was gonna make undertale, but i am creative too! i think.. anyways enjoy? ");
            Console.WriteLine("                                                                                     ");
            // line six seven
            Console.ForegroundColor = ConsoleColor.White; // the default is light grey, not sure why
                
            Console.WriteLine("just real quick: your voice is cyan-colored, when a '*' is before and at the end of a sentence, youre thinking in your mind.    *:3*");
            Console.WriteLine(" ");
            Console.WriteLine(" wanna hear the intro? (Y) for yes, (N) for no (please man i spend a lot of time on it)");
            String input = Console.ReadLine();

            if (input == "Y")
            {
                Console.Clear();
                TextUtilities.Type("i dont care if you wanted to skip, the function doesnt work anyway. Alright so, long long ago in a mysterious place, a person was born, he had 1 goal he said:", 50);
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                TextUtilities.Type("goo goo ga ga", 80);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();

                TextUtilities.Type("what did you expect? its a baby!", 50);
                Console.ReadLine();

                TextUtilities.Type("anyways, fast forward 17 years, you (yes, you!) is inspired by this sword fighter who defended the village, sometimes on his own, his name?", 50);
                Console.ReadLine();

                TextUtilities.Type(". . .", 160);
                Console.ReadLine();

                TextUtilities.Type("uhh, what was his name again? you must know it! enter his name here: ", 50);

                Console.WriteLine(" ");


                Console.ForegroundColor = ConsoleColor.Cyan;
                String jake = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" ");

                // story continues at line 148 \/

                if (jake == "")
                {
                    _jake = "Jake";
                    TextUtilities.Type("you dont know either? OH! I REMEMBER! His name is Jake, because he jake breaks the end game oooooooooh-", 50); // ran a random character generator and this came out. lol
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    TextUtilities.Type("i uhhh... you werent... hey look a ball!", 50);

                    Console.WriteLine(" ");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TextUtilities.Type("*its a cartoon bomb, and its lit*", 50);
                    Console.WriteLine(" ");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;

                    TextUtilities.Type("i can assure you. it is not a bomb! anyways i am just quickly gonna stand behind that conveniently shaped lamp", 50);
                    Console.WriteLine(" ");
                    Console.ReadLine();


                    TextUtilities.Type("oh.. papyrus didnt show up. do you think he's in the royal guard?", 50);
                    Console.WriteLine(" ");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    TextUtilities.Type("*the bomb exploded.. really how did i fall for that?*", 50);
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("you survived but got hit by a astroid and died lmao");
                    Environment.Exit(0);

                }
                else
                {
                    TextUtilities.Type("ohh yea! '" + jake + "'! hell, " + jake + " over here is so respected, Carl Johnson from the 2004 hit video game 'Grand Theft Auto: San Andreas' actually hangs out with him from time to time", 50); // told ya i was creative, altough i used AI to check spelling, not generate content!
                    Console.ReadLine();

                    TextUtilities.Type("come to think of it, whats your name actually? enter it here:  ", 50);

                    Console.WriteLine(" ");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    String _playerName = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");

                    // at line 320 the story continues if a name is provided \/

                    if (_playerName == "")
                    {
                        _playerName = "Mike Wazowski";
                        TextUtilities.Type("i'm sorry, you dont know your own name? guess i'll call you : " + _playerName, 50);
                        Console.ReadLine();
                        TextUtilities.Type("i find it quite funny, but it'll probably get annoying at the end game", 50);

                        Console.ReadLine();
                        TextUtilities.Type(". . .", 160);

                        Console.ReadLine();
                        TextUtilities.Type("i uhh, you heard nothing ok!?", 50);

                        Console.WriteLine("");



                        Console.Write("A: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("no nothing :)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");


                        Console.Write("B: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("nuh uhh, AYO CHAT CLIP THAT");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");


                        Console.Write("C: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("*stay silent*");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        String heardThat = Console.ReadLine();

                        if (heardThat == "A")
                        {


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("no nothing :)", 50);
                            Console.ForegroundColor = ConsoleColor.White;

                            TextUtilities.Type("good boi :3", 50);
                            Console.ReadLine();


                            TextUtilities.Type("so anyway...", 50);
                            Console.ReadLine();


                            TextUtilities.Type("WATCH OUT FOR THAT 'very conveniently placed sensitive landmine' NOOO", 50);
                            Console.WriteLine("your dead, atleast you were the bomb, haha get it?");


                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(0);

                        }
                        else if (heardThat == "B")
                        {

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("nuh uhh, AYO CHAT CLIP THAT", 40);
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine(" ");
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Red;
                            TextUtilities.Type("i said, you did not hear that, RIGHT?", 15);
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("A: ohh oh nah i aint see nothing. Ha, i aint see nothing. Matter of fact, i'm deaf in my left ear, and 43% deaf in my right ear, i dont see much of nothing, A matter of fact i cant even hear you sir "); // no one is gonna get this refrence
                            Console.WriteLine("B: nahh what endgame, run that back i wanna hear it again");
                            String youGonDie = Console.ReadLine();

                            if (youGonDie == "A")
                            {


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("ohh oh nah i aint see nothing. Ha, i aint see nothing. Matter of fact, i'm deaf in my left ear, and 43% deaf in my right ear, i dont see much of nothing, A matter of fact i cant even hear you sir", 50);
                                Console.ForegroundColor = ConsoleColor.White;

                                TextUtilities.Type("thats right, im not gonna do anything :>", 50);
                                Console.ReadLine();


                                TextUtilities.Type("no no no no. im so sorry my child, or... student?", 50);
                                Console.ReadLine();


                                TextUtilities.Type("what are you actually? oh right... i know what you are to me!", 50);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Red;
                                TextUtilities.Type("you are dead to me", 160);
                                Console.ReadLine();

                                Console.WriteLine("ur ded lol");

                                Console.ForegroundColor = ConsoleColor.White;
                                Environment.Exit(0);
                            }
                            else if (youGonDie == "B")
                            {


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("nahh what endgame, run that back i wanna hear it again", 40);
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.Red;
                                TextUtilities.Type("i'm sorry, you have to go, due to my misspeaking. I CAST FIREBALL", 50);
                                Console.WriteLine("u die lol");


                                Console.ForegroundColor = ConsoleColor.White;
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                TextUtilities.Type("i'm sorry, do you think staying silent will work? toodoloo! i will take ur xbox live", 50);
                                Console.WriteLine("u die lol");

                                Console.ForegroundColor = ConsoleColor.White;
                                Environment.Exit(0);

                            }
                        }
                        else if (heardThat == "C")
                        {

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type(". . .", 160);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");
                                                                                                    // mr worldwide mr 305
                            TextUtilities.Type("i'm so sorry, i lose my temper sometimes", 50);  
                            Console.ReadLine();

                            TextUtilities.Type("i am still gonna call you Mike Wazowski", 50);
                            Console.ReadLine();

                            TextUtilities.Type("here are some baja blasts as a apology", 50);
                            Console.ReadLine();

                            _baja = 66;
                        }
                    }
                    else
                    {
                        TextUtilities.Type("ooooh! '" + _playerName + "', thats a nice name!", 50);
                        Console.ReadLine();

                    }


                    TextUtilities.Type(". . .", 160);
                    Console.ReadLine();

                    TextUtilities.Type("my name? its not important, your name is so much nicer!", 50);
                    Console.ReadLine();


                    TextUtilities.Type("so, the village, it has sadly not been doing good", 50);
                    Console.ReadLine();

                    TextUtilities.Type("economically and stable wise, those poor horsies :( ", 50);
                    Console.ReadLine();

                    TextUtilities.Type("oh yeah and its people are fed up with the king so yeah its unstable too!", 50);
                    Console.ReadLine();

                    TextUtilities.Type("long story short, " + jake + " overthrew the king and became the leader of PearlHill! thats your kingdom! your hometown! or well.. your homevillage!", 50);
                    Console.ReadLine();

                    TextUtilities.Type("you were 17 at the time, so you couldn't join him in the overthrowing of the king, but you knew he was victorious!", 50);
                    Console.ReadLine();

                    TextUtilities.Type("fast forward 1 day after your 18th birthday, you knew it was time for you to join him!", 50);
                    Console.ReadLine();

                    TextUtilities.Type("on your way to " + jake + "'s castle, you stopped at the local taco bell, which strangly your village of 2300 just has for some reason", 50);
                    Console.ReadLine();

                    _baja += 2;

                    TextUtilities.Type("and then... ", 90);
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    TextUtilities.Type("AN ANGRY DRAGON CAME TO ATTACK PEARLHILL!", 10);
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    TextUtilities.Type("You looked at aw how " + jake + " fights the dragon with his army of 4, you watch as you consume your Spicy Chicken Doritos Locos Taco Gordita Crunch and watch how 5 people fight a dragon.", 50);
                    Console.ReadLine();

                    TextUtilities.Type("you think 5 isn't enough to fight a dragon the size of a Boeing 737-800", 50);
                    Console.ReadLine();

                    TextUtilities.Type("seeing them fight makes you filled with motivation to join them! oh yea CJ was there doing cheats so idk", 50);
                    Console.ReadLine();

                    TextUtilities.Type("they went away as soon as the dragon retreated, where did it retread to? its probably not important!", 50);
                    Console.ReadLine();

                    TextUtilities.Type("so you got to " + jake + "'s castle and asked to join, then.. there he was!", 50);
                    String choiceOptions = Console.ReadLine();

                    if (choiceOptions == "" || input == "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        TextUtilities.Type("so, you want to join huh?", 80);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        TextUtilities.Type(jake + " asked, what do you tell him?", 50);
                        Console.WriteLine(" ");


                        Console.Write("A: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Yes! please take me!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");


                        Console.Write("B: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("if you do let me join, i'll slide you a cup of Mountain Dew Baja Blast");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" (-1 baja blast)");                      // using 3 colors in 1 line makes me feel like hackerman :]
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");


                        Console.Write("C: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("no i'm here to look at the ceiling, ofcourse i wanna join dumbass!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("you have " + _baja + " Baja Blasts left");
                        Console.WriteLine(" ");



                        String joinOptions = Console.ReadLine();

                        // join option B at line 1435 that way \/ 

                        // join option C at line 1657 that way \/ 

                        if (joinOptions == "A")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("Yes! please take me!", 80);

                            Console.WriteLine(" ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("Very well! follow me", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.White;
                            TextUtilities.Type("so you joined him, and you trained like there was no tomorrow", 50);
                            Console.ReadLine();

                            TextUtilities.Type("you cranked 90s, learned how to 360 no scope (with a sword?) and also learned how to make the best scrameled eggs ever, y'know, just in case", 50);
                            _pAP += 2;
                            _pHP += 10; // you eat da eggs :]

                            Console.ReadLine();

                            TextUtilities.Type("and then your first battle!", 50);

                            Console.ReadLine();

                            TextUtilities.Type("against a... magikarp?", 50);

                            Console.ReadLine();

                            TextUtilities.Type("well, if it isnt going to beat you. Nintendo's lawyers definitly will", 50);
                            Console.ReadLine();

                            TextUtilities.Type("but Pearlhill does not posses impeccable copyright laws or a proper functioning juridical order", 50);
                            Console.ReadLine();

                            TextUtilities.Type("i may or may not used ChatGPT for that sentence..", 50); // to be fair, i used it for 'juridical order'

                            Console.Clear();

                            Console.ReadLine();
                            TextUtilities.Type("that aside, go for it! oh here is a baja blast", 50);

                            _baja++;

                            // story continues at line ??? \/

                            // should have 69 baja blasts if Hy apologized, nice

                            int _fAttemp1 = 0; // flee attempt

                            Magikarp magikarp1 = new Magikarp("Magikarp", 10, 2, "Magikarp: Magikarp karp", "Magikarp: karp karp", "Magikarp: Magikarp!", "magikarrrrp :c");

                            for (int i = 0; magikarp1.Health >= 0; i++) // letting it go to 0 so it can display its death message
                            {

                                Console.Clear();

                                if (magikarp1.Health == 0)
                                {
                                    magikarp1.LastWord();
                                    break;
                                }

                                if(_pHP <= 0)
                                {
                                    Console.WriteLine("you lost to a magikarp, just turn off your pc and eat fish to assert dominance");
                                    Console.WriteLine("oh yeah your still dead");
                                    Environment.Exit(0);
                                }


                                Random brnd = new Random(); // battle random
                                int mattack = brnd.Next(1, 11); // miss attack

                                Console.WriteLine(magikarp1.Talk());

                                Console.WriteLine("");
                                Console.WriteLine("Magikarp's health: " + magikarp1.Health);
                                Console.WriteLine(_playerName + " health: " + _pHP);


                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine("What will you do?");
                                Console.WriteLine(" ");

                                Console.WriteLine("A: Attack");

                                Console.Write("B: Heal");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(" (-1 baja blast)");                      
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");

                                Console.WriteLine("C: Run away");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine("you have " + _baja + " Baja Blasts left");
                                Console.WriteLine(" ");

                                String bOption1 = Console.ReadLine(); // battle option

                                if (bOption1 == "A")
                                {

                                    if (mattack > 9)
                                    {
                                        Console.WriteLine("you missed!    noob");
                                        TextUtilities.Type("          ", 50);
                                    }
                                    else
                                    {
                                        magikarp1.Health -= _pAP;
                                        Console.WriteLine("Magikarp got hit!");
                                        TextUtilities.Type("          ", 50);

                                    }
                                }
                                else if (bOption1 == "B")
                                {
                                    if (_baja > 0)
                                    {
                                        Console.WriteLine("Would you like to use a Baja Blast to heal 10 HP? you have " + _baja + " baja blasts left (Y = yes, N = no)");
                                        string bOption2 = Console.ReadLine();

                                        if (bOption2 == "Y")
                                        {
                                            _baja--;
                                            Console.WriteLine("healed up! you have " + _pHP + " HP!");
                                            TextUtilities.Type("          ", 50);
                                        }
                                        else if (bOption2 == "N")
                                        {
                                            Console.WriteLine("ok then not? i guess...");
                                            TextUtilities.Type("          ", 50);
                                        } else
                                        {
                                            Console.WriteLine("magikarp doesnt like it when you do that, so it hits you");
                                            _pHP--;
                                            TextUtilities.Type("          ", 50);
                                        }
                                    }
                                }
                                else if (bOption1 == "C")
                                {
                                    _fAttemp1++;
                                    if (_fAttemp1 > 4)
                                    {

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        TextUtilities.Type("are you really gonna run away from.. actually you know what, im tired from you fleeing. MAGIKARP USE AIRSTRIKE", 80);
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;

                                        Console.WriteLine(" ");
                                        Console.WriteLine("you died cuz of a airstrike initiated by a magikarp. thats going on your tombstone lmao");

                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        TextUtilities.Type("are you really gonna run away from a fish?", 80);
                                        TextUtilities.Type("          ", 50);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                else
                                {
                                    TextUtilities.Type("soooooo apparently the magikarp didnt like you cheating, so it orbital cannond you from its facility", 50); //  gta online style
                                    Console.WriteLine("you died, because of a fish. They are gonna laugh at you when the townsvolk hear this");
                                    Environment.Exit(0);
                                }

                                Console.WriteLine("Magikarp's turn");


                                if (mattack > 7)
                                {
                                    Console.WriteLine("it missed, i mean how can it.. whatever");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    _pHP -= magikarp1.Attack();
                                    Console.WriteLine("magikarp hit you! it did 2 damage");
                                    Console.ReadLine();
                                }
                            }


                            magikarp1.LastWord();

                            Console.WriteLine(" ");


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("Soooo.. did i do good?", 80);

                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("yes! very nice", 80);
                            Console.ReadLine();


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("does this mean i am part of the team?", 80);

                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("yeah, let me introduce them!", 80);
                            Console.ReadLine();


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("*oh my god, oh my god, oh my god*", 80);

                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("this is Carl Johnson, y'know, from Los Santos", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            TextUtilities.Type("Welcome to San Andreas, I'm CJ from Grove Street", 70); // Land of the heinous gang bangers and cold heat. In Los Santos, neighbors get no sleep. Beefing with anybody competin', even police    EVEN THE TEXT IS GREEN OMG ITS A SIGN
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("this is the stickman from those animator vs animation videos from 2008", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            TextUtilities.Type("hello, my pc break count is like 50", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("that is Cleveland Brown, known from the popular tv show 'family guy'", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            TextUtilities.Type("aww c'mon man i had my own show too!", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("and ofcourse who can forget Mr Beast", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            TextUtilities.Type("i am Mr Beast pls subscribe and buy feastables and lunchables", 80); // do lunchables even exist anymore?
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("so yeah.. HEY SHALL WE BEAT UP A DRAGON!? we will need the help of " + _playerName + " or else we cant take the one dragon on", 80);
                            Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.White;
                            TextUtilities.Type("hey listen, i know youre happy to roll with them. But please dont let them. like please stop them from attacking a dragon", 80);
                            Console.ReadLine();

                            TextUtilities.Type("trust me.. please :3", 80);
                            Console.ReadLine();


                            TextUtilities.Type("oh btw they cant hear me, just you", 80);
                            Console.ReadLine();

                            Console.Write("A: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("ok fine, i wont join them");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");


                            Console.Write("B: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("please i wanted to roll with them for a long time :c");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");


                            Console.Write("C: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("*i am going to abandon everyone and live in the mountains as a sheep*");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");

                            string _hardChoice = Console.ReadLine();


                            // hard choice option B at line 1144 that way \/

                            // hard choice option C at line 1341 that way \/


                            if(_hardChoice == "A")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("well.. cant we kill like a very very very bad person in PearlHill?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("we kinda did that already", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("how about we watch something together?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextUtilities.Type("lets watch mr beast", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("noooo! i wanna kill a dragon", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("i'd rather not, y'know we gotta get out there and its like raining a lot", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("*oh wait it hasnt rained in over 3 days.. oh no*", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("wait.. are you pro dragons? because if you are.. we are gonna have a big problem", 80);
                                Console.ReadLine();

                                Console.Write("A: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("well, yeah i am");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");


                                Console.Write("B: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("ofcourse not!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");


                                Console.Write("C: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("im a furry, wanna see my fursuit? :3");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" ");

                                string _dragon = Console.ReadLine();

                                if(_dragon == "A")
                                {


                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("well, yeah i am", 80);
                                    Console.ReadLine();


                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("oh, well you know pro dragons gotta go", 80);
                                    Console.ReadLine();


                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("ok well gotta go cya later-", 80);
                                    Console.WriteLine(" ");


                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("nooo noo no no no, i meant like we gotta kill you know", 80);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Red;
                                    TextUtilities.Type("YOU LET " + _playerName + " GO RIGHT NOW!", 100);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("OH MY GOD ITS THE DRAGON", 80);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("wait, you were a dragon?", 80);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Red;
                                    TextUtilities.Type("yeah, my name is 'Hy', because i used to be a hydra but " + jake + " CUT OFF MY 2 OTHER HEADS", 100);
                                    Console.ReadLine();



                                    TextUtilities.Type("kinda nice to talk in red letters now instead of that white", 80);
                                    Console.ReadLine();
                                    


                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    TextUtilities.Type("My name is Cleveland Brown and I am proud to be-", 80);
                                    Console.WriteLine(" ");



                                    Console.ForegroundColor = ConsoleColor.Red;
                                    TextUtilities.Type("Cleveland, shut up. Anyways if you fight him, i'll stay with him", 100);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("BRING IT ON!", 80);
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.White;



                                    int _fAttemp2 = 0; // flee attempt

                                    TheJakes jakes = new TheJakes(jake + "'s group", 500, 30, "Cleveland: No No No No No Noooo", jake + ": i thought i could trust you..", "Mr Beast: I am Mr Beast", "this isnt the last time you hear from us!");

                                    _pAP += 50; // dragon helps
                                    _pHP += 100; // dragon helps yet again

                                    for (int i = 0; jakes.Health >= 0; i++) // letting it go to 0 so it can display its death message
                                    {

                                        Console.Clear();

                                        if (jakes.Health == 0)
                                        {
                                            jakes.LastWord();
                                            break;
                                        }

                                        if (_pHP <= 0)
                                        {
                                            Console.WriteLine("you lost to " + jake + ", just like get good or somethin");
                                            Console.WriteLine("you had a good run to be honest");
                                            Environment.Exit(0);
                                        }


                                        Random brnd = new Random(); // battle random
                                        int mattack = brnd.Next(1, 11); // miss attack

                                        Console.WriteLine(jakes.Talk());

                                        Console.WriteLine(" ");
                                        Console.WriteLine(jake + "'s group health: " + jakes.Health);
                                        Console.WriteLine(_playerName + " health: " + _pHP);


                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("What will you do?");
                                        Console.WriteLine(" ");

                                        Console.WriteLine("A: Attack");

                                        Console.Write("B: Heal");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write(" (-1 baja blast)");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("");

                                        Console.WriteLine("C: Run away");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("you have " + _baja + " Baja Blasts left");
                                        Console.WriteLine(" ");

                                        String bOption1 = Console.ReadLine(); // battle option

                                        if (bOption1 == "A")
                                        {

                                            if (mattack > 8)
                                            {
                                                Console.WriteLine("you missed! no really, how do you miss five guys? you not hungry.. lol");
                                                TextUtilities.Type("          ", 50);
                                            }
                                            else
                                            {
                                                jakes.Health -= _pAP;
                                                Console.WriteLine("Jake's group got hit!");
                                                TextUtilities.Type("          ", 50);

                                            }
                                        }
                                        else if (bOption1 == "B")
                                        {
                                            if (_baja > 0)
                                            {
                                                Console.WriteLine("Would you like to use a Baja Blast to heal 10 HP? you have " + _baja + " baja blasts left (Y = yes, N = no)");
                                                string bOption2 = Console.ReadLine();

                                                if (bOption2 == "Y")
                                                {
                                                    _baja--;
                                                    Console.WriteLine("healed up! you have " + _pHP + " HP!");
                                                    TextUtilities.Type("          ", 50);
                                                }
                                                else if (bOption2 == "N")
                                                {
                                                    Console.WriteLine("ok then not? i guess...");
                                                    TextUtilities.Type("          ", 50);
                                                }
                                                else
                                                {
                                                    Console.WriteLine(_jake + "'s group doesnt like it when you do that, so it hits you");
                                                    _pHP--;
                                                    TextUtilities.Type("          ", 50);
                                                }
                                            }
                                        }
                                        else if (bOption1 == "C")
                                        {
                                            _fAttemp2++;
                                            if (_fAttemp2 > 9)
                                            {
                                                
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                TextUtilities.Type("well.. i know you tried to protect me.. so let me help you fly while i still can", 80);
                                                Console.ReadLine();
                                                Console.ForegroundColor = ConsoleColor.White;

                                                Console.WriteLine(" ");
                                                Console.WriteLine("you lived happly after,       just kidding, Hy kinda forgot you were riding her and she just did a barrel roll for fun, causing you to fall to your death");

                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                TextUtilities.Type("tryna run away huh? come back here", 80);
                                                TextUtilities.Type("          ", 50);
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else
                                        {
                                            TextUtilities.Type("nope, aint no way your doing this", 50);
                                            Console.WriteLine("you died, you dont know your abc's, while theyre right infront of you?");
                                            Environment.Exit(0);
                                        }

                                        Console.WriteLine(jake + "'s group turn");


                                        if (mattack > 7)
                                        {
                                            Console.WriteLine(jake + "'s group missed, somehow all 5 of them");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            _pHP -= jakes.Attack();
                                            Console.WriteLine(jake + "'s hit you! it did 2 damage");
                                            Console.ReadLine();
                                        }
                                    }
                                    Console.Clear();


                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("i'm sorry", 80);
                                    Console.ReadLine();


                                    Console.ForegroundColor = ConsoleColor.Red;
                                    TextUtilities.Type("aww thanks :) oh dont be sorry", 80);
                                    Console.ReadLine();

                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("You won! oh yeah you became the king after " + jake + " left");
                                    Console.WriteLine("you got " + _baja + " baja blasts left");


                                } else if(_dragon == "B")
                                {

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("ofcourse not!", 80);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("sooo why are you so hesetant?", 80);
                                    Console.ReadLine();



                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("because i havent finished my Spicy Chicken Doritos Locos Taco Gordita Crunch", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("if you finished that, will you fight a dragon?", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("naaahh", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("well, i guess if it doesnt attack us, we wont attack him, or her, or it. what do dragons go by?", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("they are probably drag queens, haha get it? like dragon and queen... im sorry", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("whatever", 80);
                                    Console.ReadLine();




                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("you won, an actual good ending. You got to stay with them and you listend to the white voice"); 

                                    Console.WriteLine("you had " + _baja + " baja blasts left");
                                    Console.ReadLine();


                                    TextUtilities.Type("well, thank you very much", 80);
                                    Console.ReadLine();


                                    TextUtilities.Type("before you go, i guess i should tell you who i am", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    TextUtilities.Type("im Hy, i am a hydra dragon who got their 2 necks cut off by " + jake, 80);
                                    Console.ReadLine();


                                    TextUtilities.Type("havent got much else to say... im going now", 80);
                                    Console.ReadLine();


                                    TextUtilities.Type("oh yea here are some baja blasts for saving me life", 80);
                                    _baja = 999999999;                                                                      // gtx 1080 TI lol
                                    Console.ReadLine();
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.White;


                                    Console.WriteLine(" ");

                                    Console.WriteLine("you won, an actual good ending. You got to stay with them and you listend to the white.. or well red voice");

                                    Console.WriteLine("you had " + _baja + " baja blasts left, oh my goodness"); // plankton style

                                    Console.ReadLine();

                                    Environment.Exit(0);


                                } else if(_dragon == "C")
                                {


                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("im a furry, wanna see my fursuit? :3", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("actually?", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type(":3", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("im happy for you.. but we cant have dragons here", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    TextUtilities.Type("ok bye", 80);
                                    Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TextUtilities.Type("wait no", 80);
                                    Console.ReadLine();

                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("you won! somehow... oh well, enjoy being a furry"); // met een volledige fursuit naar de supermarkt zou wel lit zijn, niet dat ik een furry ben ofzo..

                                    Console.WriteLine("you had " + _baja + " baja blasts left");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Environment.Exit(0);
                                }


                            }


                            // hard choice option A at line 716 that way /\

                            // hard choice option C at line 1341 that way \/


                            else if (_hardChoice == "B")
                            {

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("boy hell yeah", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("alright alright, there is one right there", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Red;
                                TextUtilities.Type(_playerName + "... you betrayed me :c", 120);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("waaaaait, you 2 know each other", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("no, never saw-", 80);
                                Console.WriteLine(" ");

                                Console.ForegroundColor = ConsoleColor.Red;
                                TextUtilities.Type("dont lie to me, im Hy", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("so " + _playerName + ", you betrayed someone?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("thats messed up, hey dragon do you wanna beat " + _playerName + " up?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Red;
                                TextUtilities.Type("sure >:)", 80);
                                Console.ReadLine();




                                int _fAttemp3 = 0; // flee attempt

                                JakeAndHy JakeHy = new JakeAndHy(jake + "'s group and Hy", 600, 80, "Hy: why :c", jake + ": i thought i could trust you..", "Mr Beast: I am Mr Beast", "o noooo!");


                                for (int i = 0; JakeHy.Health >= 0; i++) // letting it go to 0 so it can display its death message
                                {

                                    Console.Clear();

                                    if (JakeHy.Health == 0)
                                    {
                                        JakeHy.LastWord();
                                        break;
                                    }

                                    if (_pHP <= 0)
                                    {
                                        Console.WriteLine("you lost to " + JakeHy + ", next time dont betray maybe?");
                                        Console.WriteLine("you couldnt even get a good run lol");
                                        Environment.Exit(0);
                                    }


                                    Random brnd = new Random(); // battle random
                                    int mattack = brnd.Next(1, 11); // miss attack

                                    Console.WriteLine(JakeHy.Talk());

                                    Console.WriteLine(" ");
                                    Console.WriteLine(JakeHy + "'s group and Hy health: " + JakeHy.Health);
                                    Console.WriteLine(_playerName + " health: " + _pHP);


                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("What will you do?");
                                    Console.WriteLine(" ");

                                    Console.WriteLine("A: Attack");

                                    Console.Write("B: Heal");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(" (-1 baja blast)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("");

                                    Console.WriteLine("C: Run away");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("you have " + _baja + " Baja Blasts left");
                                    Console.WriteLine(" ");

                                    String bOption1 = Console.ReadLine(); // battle option

                                    if (bOption1 == "A")
                                    {

                                        if (mattack > 9)
                                        {
                                            Console.WriteLine("you missed! no really, how do you miss five guys? AND a dragon");
                                            TextUtilities.Type("          ", 50);
                                        }
                                        else
                                        {
                                            JakeHy.Health -= _pAP;
                                            Console.WriteLine("Jake's group and Hy got hit!");
                                            TextUtilities.Type("          ", 50);

                                        }
                                    }
                                    else if (bOption1 == "B")
                                    {
                                        if (_baja > 0)
                                        {
                                            Console.WriteLine("Would you like to use a Baja Blast to heal 10 HP? you have " + _baja + " baja blasts left (Y = yes, N = no)");
                                            string bOption2 = Console.ReadLine();

                                            if (bOption2 == "Y")
                                            {
                                                _baja--;
                                                Console.WriteLine("healed up! you have " + _pHP + " HP!");
                                                TextUtilities.Type("          ", 50);
                                            }
                                            else if (bOption2 == "N")
                                            {
                                                Console.WriteLine("ok then not? i guess...");
                                                TextUtilities.Type("          ", 50);
                                            }
                                            else
                                            {
                                                Console.WriteLine(_jake + "'s group and Hy doesnt like it when you do that, so they hits you");
                                                _pHP--;
                                                TextUtilities.Type("          ", 50);
                                            }
                                        }
                                    }
                                    else if (bOption1 == "C")
                                    {
                                        _fAttemp3++;
                                        if (_fAttemp3 > 9)
                                        {

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            TextUtilities.Type("wait im a dragon, i can shoot flames", 80);
                                            Console.ReadLine();
                                            Console.ForegroundColor = ConsoleColor.White;

                                            Console.WriteLine(" ");
                                            Console.WriteLine("you got toasted to death");

                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            TextUtilities.Type("tryna run away huh? lmao cant even run", 80);
                                            TextUtilities.Type("          ", 50);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                    else
                                    {
                                        TextUtilities.Type("nope, aint no way your doing this", 50);
                                        Console.WriteLine("you died, you dont know your abc's, while theyre right infront of you?");
                                        Environment.Exit(0);
                                    }

                                    Console.WriteLine(jake + "'s group and Hy's turn");


                                    if (mattack > 8)
                                    {
                                        Console.WriteLine(jake + "'s group missed, somehow all 6 of them");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        _pHP -= JakeHy.Attack();
                                        Console.WriteLine(jake + " hit you! it did a lot of damage");
                                        Console.ReadLine();
                                    }
                                }
                            }


                            // hard choice option A at line 716 that way /\

                            // hard choice option B at line 1144 that way /\


                            else if (_hardChoice == "C")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("hear me out...", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("what?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("so you know how sheep are just like, standing there?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("where?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("idk just anywhere", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("what about it?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("why arent we sheep?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextUtilities.Type("I am Mr Beast", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("does Mr Beast keep saying Mr Beast?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextUtilities.Type("Mr Beast", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("i guess.. what was that about sheep anyway?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextUtilities.Type("Mr Beast", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("uhh hey-", 100);
                                Console.WriteLine(" ");

                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextUtilities.Type("Mr Beast", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("isnt it weird how right behind you guys is a dragon", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("WHERE!?", 30);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("*baaa :3*", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextUtilities.Type("Mr Beast", 80); // he is just a pokemon at this point
                                Console.ReadLine();

                                Console.Clear();

                                Console.WriteLine("you won.. somehow? you live peacefully in the mountains among other sheep");
                                Console.WriteLine("you had " + _baja + " baja blasts left");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Environment.Exit(0);
                            }

                        }




                        // join option A at line 422  that way /\

                        // join option C at line 1657  that way \/



                        else if (joinOptions == "B")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("if you do let me join, i'll slide you a cup of Mountain Dew Baja Blast", 80);

                            Console.ReadLine();
                            Console.WriteLine(" ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("Do you think i will accept that? you're absolutly right, follow me!", 80);
                            

                            Console.ReadLine();
                            _baja--;
                            TextUtilities.Type("ssssssip!", 80);

                            Console.ForegroundColor = ConsoleColor.White;

                            TextUtilities.Type("You joined " + _jake + ", but because you bribed your way in. you wont get training... maybe that i'll teach ya to not bribe", 50);
                            Console.ReadLine();


                            TextUtilities.Type("So anyway, fast forward like 5 days and you were gonna battle for the first time", 50);
                            Console.ReadLine();

                            TextUtilities.Type("against the enderdragon!!??", 120);
                            Console.ReadLine();

                            TextUtilities.Type("yeaaaah, so as it turns out, the dragon mistook you for a high skilled fighter. because " + jake + " didnt tell the dragon you were new... this is the consequence of bribing", 50);
                            Console.ReadLine();

                            Console.Clear();
                            TextUtilities.Type("oh well, have fun getting yo ass whooped without any beds, golden apples, notch apples, totems of undying, water buckets, ender pearls, bows, swords, axes and absolutly NO snowballs", 50);
                            Console.ReadLine();

                            TextUtilities.Type("you havent got snowballs because... you- you dont-", 50);
                            Console.ReadLine();

                            TextUtilities.Type("you dont got.. got the balls", 20);
                            Console.ReadLine();

                            TextUtilities.Type("HAHAAAAAAA GOTTEM", 50);
                            Console.ReadLine();


                            // you'll be left with six seven baja blasts if you choose to not enter a name

                            int _fAttemp2 = 0; // flee attempt

                            EnderDragon enderDragon = new EnderDragon("Ender Dragon", 500, 15, "Ender Dragon: RAAAAH", "Ender Dragon: Poof", "Ender Dragon: i am a dragon!", "egg cracking noises");

                            for (int i = 0; enderDragon.Health >= 0; i++) // letting it go to 0 so it can display its death message
                            {

                                Console.Clear();

                                if (enderDragon.Health == 0)
                                {
                                    enderDragon.LastWord();
                                    break;
                                }

                                if (_pHP <= 0)
                                {
                                    Console.WriteLine("you lost to the ender dragon, now to be fair, what the hell did you think was gonna happen");
                                    Console.WriteLine("oh yeah your still dead lol");
                                    Environment.Exit(0);
                                }


                                Random brnd = new Random(); // battle random
                                int mattack = brnd.Next(1, 11); // miss attack

                                Console.WriteLine(enderDragon.Talk());

                                Console.WriteLine(" ");
                                Console.WriteLine("Ender Dragon's health: " + enderDragon.Health);
                                Console.WriteLine(_playerName + " health: " + _pHP); // lol


                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine("What will you do?");
                                Console.WriteLine(" ");

                                Console.WriteLine("A: Attack");

                                Console.Write("B: Heal");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(" (-1 baja blast)");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");

                                Console.WriteLine("C: Run away");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine("you have " + _baja + " Baja Blasts left");
                                Console.WriteLine(" ");


                                String bOption1 = Console.ReadLine(); // battle option

                                if (bOption1 == "A")
                                {

                                    if (mattack > 6)
                                    {
                                        Console.WriteLine("you missed!    lol");
                                        TextUtilities.Type("          ", 50);
                                    }
                                    else
                                    {
                                        enderDragon.Health -= _pAP;
                                        Console.WriteLine("The Ender Dragon got hit!");
                                        TextUtilities.Type("          ", 50);

                                    }
                                }
                                else if (bOption1 == "B")
                                {
                                    if (_baja > 0)
                                    {
                                        Console.WriteLine("Would you like to use a Baja Blast to heal 10 HP? you have " + _baja + " baja blasts left (Y = yes, N = no)");
                                        string bOption2 = Console.ReadLine();

                                        if (bOption2 == "Y")
                                        {
                                            _baja--;
                                            Console.WriteLine("healed up! you have " + _pHP + " HP!");
                                            TextUtilities.Type("          ", 50);
                                        }
                                        else if (bOption2 == "N")
                                        {
                                            Console.WriteLine("ok then not? i guess...");
                                            TextUtilities.Type("          ", 50);
                                        }
                                        else
                                        {
                                            Console.WriteLine("The Ender Dragon doesnt like it when you do that, so it hits you");
                                            _pHP--;
                                            TextUtilities.Type("          ", 50);
                                        }
                                    }
                                }
                                else if (bOption1 == "C")
                                {
                                    _fAttemp2++;
                                    if (_fAttemp2 > 4)
                                    {

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        TextUtilities.Type("well, i thought you would be better than this", 80);
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;

                                        Console.WriteLine(" ");
                                        Console.WriteLine("you died because the ender dragon shot you 100 meters in the air");

                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        TextUtilities.Type("come back, you can do this!", 80);
                                        TextUtilities.Type("          ", 50);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                else
                                {
                                    TextUtilities.Type("what, did you think there was gonna be a 4th option?", 50);
                                    Console.WriteLine("the ender dragon was confused and just hit you off the end island, which is odd because pearlhill sits in between mountains on the mainland... oh well");
                                    Environment.Exit(0);
                                }

                                Console.WriteLine("Ender Dragon's turn");


                                if (mattack > 9)
                                {
                                    Console.WriteLine("it missed, consider yourself lucky");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    _pHP -= enderDragon.Attack();
                                    Console.WriteLine("the ender dragon hit you.. does it hurt?");
                                    Console.ReadLine();
                                }
                            }

                                TextUtilities.Type("WHA- HUH HOW, I- DAAAMMNNN", 50);
                                Console.ReadLine();


                                TextUtilities.Type("actually you know what, nevermind everything, you are the king of everything", 50);
                                Console.ReadLine();


                                TextUtilities.Type("im not gonna fight with you... you are you", 50);
                                Console.ReadLine();

                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine(" ");
                                Console.WriteLine("you have " + _baja + " baja blast left... thats.. wowie");

                            

                        }






                        // join option A at line 422  that way /\

                        // join option B at line 1435  that way /\




                        else if (joinOptions == "C")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("no i'm here to look at the ceiling, ofcourse i wanna join dumbass!", 80);

                            Console.WriteLine(" ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            TextUtilities.Type("Dumbass!? who the hell are you calling a dumbass!? get lost kid your not welcome here!", 80);

                            Console.ReadLine();


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            TextUtilities.Type("lmao bye have fun getting your Xbox Live account hacked", 80);
                            Console.ReadLine();


                            Console.ForegroundColor = ConsoleColor.White;
                            TextUtilities.Type("honestly, what did you expect?", 80);
                            Console.ReadLine();


                            TextUtilities.Type(jake + " does talk like that to his crew but, y'know", 80);
                            Console.ReadLine();


                            TextUtilities.Type("so you went home and booted up twitter, yes twitter i refuse to call it X", 80);
                            Console.ReadLine();


                            TextUtilities.Type("you checked the account of " + jake + " and then you saw something incredible", 80);
                            Console.ReadLine();


                            TextUtilities.Type("he left out his password on a note, on his tweet about his pet turtle walking over a pencil for the first time", 60);
                            Console.ReadLine();


                            TextUtilities.Type("you instantly screenshot the tweet and analyse it", 80);
                            Console.ReadLine();


                            TextUtilities.Type("now before anything, a turtle stepping over a pencil is like very difficult for a turtle to do so thats cool i guess", 80);
                            Console.ReadLine();


                            TextUtilities.Type("anyways, his password is 'SofaClimber3000'", 80);
                            Console.ReadLine();


                            TextUtilities.Type("because his turtle also climbed up a sofa", 80);
                            Console.ReadLine();


                            TextUtilities.Type("how the hell do turtles scale entire sofa's?", 80);
                            Console.ReadLine();


                            TextUtilities.Type("that entire thing aside, you checked and yeah, it is the actual password for his account", 80);
                            Console.ReadLine();


                            TextUtilities.Type("funly enough, when you check the other accounts, it is the same passwords being used", 80);
                            Console.ReadLine();


                            TextUtilities.Type("which is where today's sponser LastPass comes in! lastpa-", 80);
                            Console.WriteLine(" ");


                            TextUtilities.Type("nahh im kidding there aint no way any company wants to sponsor us", 80);
                            Console.ReadLine();


                            TextUtilities.Type("well.. what will you do with this new found power?", 80);
                            Console.ReadLine();


                            Console.Write("A: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("amma go full cyberleek on " + jake);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");

                            Console.Write("B: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("im going to tell him");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");

                            Console.Write("C: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("i will give it to the U.S. Department of Homeland Security");
                            Console.WriteLine(" ");

                            string _fPassword = Console.ReadLine(); // found password
                            // Console.ForegroundColor = ConsoleColor.White;


                            // password option B at line 1853 \/

                            // password option C at line 1959 \/


                            if (_fPassword == "A")
                            {
                                TextUtilities.Type("amma go full cyberleek on " + jake, 80);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();


                                TextUtilities.Type("hell yeah", 80);
                                Console.ReadLine();


                                TextUtilities.Type("lemme hack into his stuff too!", 80);
                                Console.ReadLine();

                                Console.Clear();

                                TextUtilities.Type("ooooo my god, " + _playerName + "you gotta see this", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("what?", 80);
                                Console.ReadLine();

                               
                                TextUtilities.Type("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO WE JUST HIT A HOMERUN, thats a good clip", 30);
                                Console.ReadLine();


                                TextUtilities.Type("*its " + jake + " in a maid dress, he looks ridiculous*", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.White;
                                TextUtilities.Type("hey, lets leak this!", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("lol ok", 80);
                                Console.ReadLine();

                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.White;
                                TextUtilities.Type("so we leaked the maid dress picture, and he wasnt happy, but like screw him", 80);
                                Console.ReadLine();

                                
                                TextUtilities.Type("whats that noise?", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Yellow;
                                TextUtilities.Type("FBI OPEN UP!", 30);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.White;
                                TextUtilities.Type("OMG ITS CLEVELAND BROWN.. wait whats he doing here?", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Yellow;
                                TextUtilities.Type("hey fellas :) " + jake + " wanted you in jail and he would give me a 1999 Lincoln Navigator with chromed out wheels if i catched yall", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("well guess what? we-", 80);
                                Console.WriteLine(" ");


                                Console.ForegroundColor = ConsoleColor.White;
                                TextUtilities.Type("we will fly away lmao bye", 80);
                                Console.ReadLine();

                                Console.Clear();

                                Console.WriteLine("you 2 escaped succesfully and won.. you might or might not hit Cleveland's house and made his bathtub fall down");
                                Console.WriteLine(" ");
                                Console.WriteLine("you have " + _baja + " baja blast left");

                            }


                            // password option A at line 1763 /\

                            // password option C at line 1959 \/


                            else if (_fPassword == "B")
                            {
                                TextUtilities.Type("im going to tell him", 80);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();


                                TextUtilities.Type("aww youre no fun :c", 80);
                                Console.ReadLine();





                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("                                                                                                                                                                       ");
                                Console.WriteLine("                                                                 █████████      █████████   █████████   ██      ████      ██                                           ");
                                Console.WriteLine("                                                                 ██     ██      ██          ██           ██    ██  ██    ██                                            ");
                                Console.WriteLine("                                                                 █████████      █████       █████████     ██  ██    ██  ██                                             ");
                                Console.WriteLine("                                                                 ██     ██      ██          ██             ████      ████                                              ");
                                Console.WriteLine("                                                                 ██     ██      ██          █████████       ██        ██                                               ");
                                Console.WriteLine("                                                                                                                                                                       ");
                                Console.WriteLine("                                                                                                                                                                       ");
                                Console.WriteLine("                                                                                                                                                                       ");
                                Console.WriteLine("        ██████  ██████      ██████      ██████  ██████    █████████    ██████    ██████████   ████████      ██           █████████   ██████████   █████████   ██████   ");
                                Console.WriteLine("       ██    ████    ██   ██      ██   ██    ████    ██   ██          ██    ██       ██       ██            ██           ██     ██       ██       ██          ██    ██ ");
                                Console.WriteLine("       ██     ██     ██   ██      ██   ██     ██     ██   █████████   ██    ██       ██       ████████      ██           █████████       ██       █████████   ███████  ");
                                Console.WriteLine("       ██     ██     ██   ██      ██   ██     ██     ██   ██          ██    ██       ██             ██      ██           ██     ██       ██       ██          ██    ██ ");
                                Console.WriteLine("       ██     ██     ██     ██████     ██     ██     ██   █████████   ██    ██       ██       ████████      ██████████   ██     ██       ██       █████████   ██     ██");
                                Console.WriteLine("                                                                                                                                                                       ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Black;




                                TextUtilities.Type("                                                           ", 60);

                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("ay waddup fam", 80);
                                Console.ReadLine();


                                TextUtilities.Type("mister 'SofaClimber3000'", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("what are you talking about? and your still not welcome here", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("your password is SofaClimber3000 isnt it? its like all over internet and you dont even know", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("yeah? ok well thanks for telling i am going to change it", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("no problem, can i have king status now?", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("no? why would i give it to you?", 80);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("because your sonic oc from 12 years ago is in your google drive", 80);
                                Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("O_O", 1);
                                Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TextUtilities.Type("and your fanfiction of-", 80);
                                Console.WriteLine(" ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                TextUtilities.Type("yes yes ok here is king status, just dont tell anyone", 80);

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();
                                Console.Clear();


                                Console.WriteLine("you have won the game and are king of pearlhill");
                                Console.WriteLine(" ");
                                Console.WriteLine("you have " + _baja + " baja blast left, dont forget to change your password before those baja blasts are stolen too");
                            }


                            // password option A at line 1763 /\

                            // password option B at line 1853 /\


                            else if (_fPassword == "C")
                            {
                                TextUtilities.Type("i will give it to the U.S. Department of Homeland Security", 80);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;


                                TextUtilities.Type("lmao ok", 80);
                                Console.ReadLine();
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;

                                TextUtilities.Type("so we gave the passwords and info of " + jake + " to homeland security, and didnt have to wait long until something happend", 80);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                TextUtilities.Type("oh wow look at that U.S. Army UH-60M Black Hawk", 80);
                                Console.ReadLine();


                                TextUtilities.Type("*thats a helicopter, a cool one at that*", 80);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;

                                TextUtilities.Type("they came really quick, what was in " + jake + "'s accounts?", 80);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                Console.Clear();

                                Console.WriteLine("'Creedence Clearwater Revival - Fortunate Son' starts playing");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.Write("This is ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("The United ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("St");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("at");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("es ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("of ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Am");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("er");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("ic");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("a       *Bald Eagle ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Screech*");
                                Console.WriteLine(" ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Here is some freedom y'all!");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.ReadLine();


                                TextUtilities.Type("yeah i see why they came", 80);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                TextUtilities.Type("why?", 80);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;     // line number = current year!

                                TextUtilities.Type(jake + " had tried to blackmail the C.I.A", 80);
                                Console.ReadLine();

                                TextUtilities.Type("without a VPN as well, which is where our sponse-", 80);
                                Console.WriteLine(" ");

                                TextUtilities.Type("this joke is getting old, but yeah he is somewhere in a black van owned by the C.I.A", 80);
                                Console.ReadLine();

                                TextUtilities.Type("i dont even know WHY out of everyone he tried to blackmail the C.I.A, but well you won", 80);
                                Console.WriteLine("you have " + _baja + " baja blasts left");

                            }


                        }
                    }

                }
            }
        }
    }






    // code to let the text type itself instead of write(line) which just shows all of it at once

    class TextUtilities
    {
        public static void Type(string p_input, int p_delay)
        {
            char[] letters = p_input.ToCharArray();

            foreach (char c in letters)
            {
                Console.Write(c);
                Thread.Sleep(p_delay);
            }
            Console.Write("\n");
        }
    }
}

// wow, how such a journey this was.. im tired now, sleep well :)