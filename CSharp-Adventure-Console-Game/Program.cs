using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Program
    {
         // ██


        String Jake = "Jake"; // default name for intro skippers (whyyyy D:> )
        String introDiaSkip = "";

        String playerName = "Man-with-no-name"; // if you skip the intro, it has a default name, except this one is just funny lol

        public void WaterStonePV()
        {
            Console.ResetColor();

            // logo :D

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("                                                                                         Like.. 99% AI FREE!!!!                            ");
            Console.WriteLine("                                                                                                                                           ");
            Console.WriteLine("     ██      ███      ██   ████████   ██████████   ████████    ██████         ████████   ██████████    ██████     ██      ██   ████████    ");
            Console.WriteLine("      ██    ██ ██    ██    ██    ██       ██       ██          ██    ██       ██             ██      ██      ██   ████    ██   ██          ");
            Console.WriteLine("       ██  ██   ██  ██     ████████       ██       ████████    ██████         ████████       ██      ██      ██   ██  ██  ██   ████████    ");
            Console.WriteLine("        ████     ████      ██    ██       ██       ██          ██   ██              ██       ██      ██      ██   ██    ████   ██          ");
            Console.WriteLine("         ██       ██       ██    ██       ██       ████████    ██     ██      ████████       ██        ██████     ██      ██   ████████    ");
            Console.WriteLine("                                                                                                                                           ");
            Console.WriteLine("            *insert water dropping sfx here*                                                                                               ");

            Console.ResetColor();
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                     ");
            Console.WriteLine(" well... i was gonna make undertale, but i am creative too! i think.. anyways enjoy? ");
            Console.WriteLine("                                                                                     ");
            Console.ResetColor();


            Console.WriteLine(" wanna hear the intro? (Y) for yes, (N) for no (please man i spend a lot of time on it)");
            String input = Console.ReadLine();

            if (input == "Y")
            {
                Console.Clear();
                TextUtilities.Type("Alright so, long long ago in a mysterious place, a person was born, he had 1 goal he said:", 50);
                String introDia = Console.ReadLine();

                if (introDia == "")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TextUtilities.Type("'goo goo ga ga'", 80);
                    String introDia1 = Console.ReadLine();

                    if (introDia1 == "")
                    {
                        Console.ResetColor();
                        TextUtilities.Type("what did you expect? its a baby!", 50);
                        String introDia2 = Console.ReadLine();

                        if (introDia2 == "")
                        {
                            TextUtilities.Type("anyways, fast forward 17 years, you (yes, you!) is inspired by this sword fighter who defended the village, sometimes on his own, his name?", 50);
                            String introDia3 = Console.ReadLine();

                            if (introDia3 == "")
                            {

                                TextUtilities.Type(". . .", 160);
                                String introDia4 = Console.ReadLine();

                                if (introDia4 == "")
                                {

                                    TextUtilities.Type("uhh, what was his name again? you must know it! enter his name here: ", 50);
                                    String introDia5 = Console.ReadLine();
                                    Jake = introDia5;

                                    if (introDiaSkip == "")
                                    {
                                        TextUtilities.Type("ohh yea! '" + Jake + "'! hell, " + Jake + " over here is so respected, Carl Johnson from the 2004 hit video game 'Grand Theft Auto: San Andreas' actually hangs out with him from time to time", 50); // told ya i was creative
                                        String introDia6 = Console.ReadLine();
                                        playerName = "";

                                        if (introDia6 == "")
                                        {

                                            TextUtilities.Type("come to think of it, whats your name actually? enter it here:  ", 50);
                                            String introDia7 = Console.ReadLine();
                                            playerName = introDia7;

                                            if (introDiaSkip == "")
                                            {

                                                TextUtilities.Type("ooooh! '" + playerName + "', thats a nice name!", 50);
                                                String introDia8 = Console.ReadLine();

                                                if (introDia8 == "")
                                                {

                                                    TextUtilities.Type(". . .", 160);
                                                    String introDia9 = Console.ReadLine();

                                                    if (introDia9 == "")
                                                    {

                                                        TextUtilities.Type("my name? its not important, your name is so much nicer!", 50);
                                                        String introDia10 = Console.ReadLine();


                                                        if (introDia10 == "")
                                                        {

                                                            TextUtilities.Type("so, the village, it has sadly not been doing good", 50);
                                                            String introDia11 = Console.ReadLine();


                                                            if (introDia11 == "")
                                                            {

                                                                TextUtilities.Type("economically and stable wise, those poor horsies :( ", 50);
                                                                String introDia12 = Console.ReadLine();


                                                                if (introDia12 == "")
                                                                {

                                                                    TextUtilities.Type("oh yeah and its people are fed up with the king so yeah its unstable too!", 50);
                                                                    String introDia13 = Console.ReadLine();


                                                                    if (introDia13 == "")
                                                                    {

                                                                        TextUtilities.Type("long story short, " + Jake + " overthrew the king and became the leader of PearlHill! thats your kingdom! your hometown! or well.. your homevillage!", 50);
                                                                        String introDia14 = Console.ReadLine();


                                                                        if (introDia14 == "")
                                                                        {

                                                                            TextUtilities.Type("you were 17 at the time, so you couldn't join him in the overthrowing of the king, but you knew he was victorious!", 50);
                                                                            String introDia15 = Console.ReadLine();


                                                                            if (introDia15 == "")
                                                                            {

                                                                                TextUtilities.Type("fast forward 1 day after your 18th birthday, you knew it was time for you to join him!", 50);
                                                                                String introDia16 = Console.ReadLine();


                                                                                if (introDia16 == "")
                                                                                {

                                                                                    TextUtilities.Type("on your way to " + Jake + "'s castle, you stopped at the local taco bell, which strangly your village of 2300 just has for some reason", 50);
                                                                                    String introDia17 = Console.ReadLine();


                                                                                    if (introDia17 == "")
                                                                                    {
                                                                                        TextUtilities.Type("and then... ", 90);
                                                                                        String introDia18 = Console.ReadLine();

                                                                                        if (introDia18 == "")
                                                                                        {
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            TextUtilities.Type("AN ANGRY DRAGON CAME TO ATTACK PEARLHILL!", 10);
                                                                                            String introDia19 = Console.ReadLine();

                                                                                            if (introDia19 == "")
                                                                                            {
                                                                                                Console.ResetColor();
                                                                                                TextUtilities.Type("You looked at aw how " + Jake + " fights the dragon with his army of 4, you watch as you consume your Spicy Chicken Doritos Locos Taco Gordita Crunch and watch how 5 people fight a dragon.", 50);
                                                                                                String introDia20 = Console.ReadLine();

                                                                                                if (introDia20 == "")
                                                                                                {
                                                                                                    TextUtilities.Type("you think 5 isn't enough to fight a dragon the size of a Boeing 737-800", 50);
                                                                                                    String introDia21 = Console.ReadLine();

                                                                                                    if (introDia21 == "")
                                                                                                    {
                                                                                                        TextUtilities.Type("seeing them fight makes you filled with motivation to join them! oh yea CJ was there doing cheats so idk", 50);
                                                                                                        String introDia22 = Console.ReadLine();

                                                                                                        if (introDia22 == "")
                                                                                                        {
                                                                                                            TextUtilities.Type("they went away as soon as the dragon retreated, where did it retread to? its probably not important!", 50);
                                                                                                            String introDia23 = Console.ReadLine();

                                                                                                            if (introDia23 == "")
                                                                                                            {
                                                                                                                TextUtilities.Type("so you got to " + Jake + "'s castle and asked to join, then.. there he was!", 50);
                                                                                                                String introDia24 = Console.ReadLine();

                                                                                                                if (introDia24 == "" || input == "N")
                                                                                                                {
                                                                                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                                                                                    TextUtilities.Type("'so, you want to join huh?'", 80);
                                                                                                                    Console.ResetColor();
                                                                                                                    TextUtilities.Type(Jake + " asked, what do you tell him?", 50);
                                                                                                                    Console.WriteLine(" ");
                                                                                                                    Console.WriteLine("A: Yes! please take me!");
                                                                                                                    Console.WriteLine("B: if you do let me join, i'll slide you a cup of Mountain Dew Baja Blast");
                                                                                                                    Console.WriteLine("C: no i'm here to look at the ceiling, ofcourse i wanna join dumbass!");

                                                                                                                    String introDia25 = Console.ReadLine();

                                                                                                                    if (introDia25 == "A")
                                                                                                                    {
                                                                                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                                                                                        TextUtilities.Type("Yes! please take me!", 80);

                                                                                                                        Console.WriteLine(" ");

                                                                                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                                                                                        TextUtilities.Type("Very well! follow me", 80);
                                                                                                                        String introDia26A = Console.ReadLine();

                                                                                                                        if (introDia26A == "")
                                                                                                                        {
                                                                                                                            TextUtilities.Type("they went away as soon as the dragon retreated, where did it retread to? its probably not important!", 50);
                                                                                                                            String introDia27A = Console.ReadLine();
                                                                                                                        }





                                                                                                                        else if (introDia25 == "B")
                                                                                                                        {
                                                                                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                                                                                            TextUtilities.Type("if you do let me join, i'll slide you a cup of Mountain Dew Baja Blast", 80);

                                                                                                                            Console.WriteLine(" ");

                                                                                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                                                                                            TextUtilities.Type("Do you think i will accept that? you're absolutly right, follow me!", 80);

                                                                                                                            String introDia26B = Console.ReadLine();
                                                                                                                        }





                                                                                                                        else if (introDia25 == "C")
                                                                                                                        {
                                                                                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                                                                                            TextUtilities.Type("no i'm here to look at the ceiling, ofcourse i wanna join dumbass!", 80);

                                                                                                                            Console.WriteLine(" ");

                                                                                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                                                                                            TextUtilities.Type("Dumbass!? who are you calling a dumbass!? get lost kid your not welcome here!", 80);

                                                                                                                            String introDia26C = Console.ReadLine();
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }





        static class TextUtilities
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
}
