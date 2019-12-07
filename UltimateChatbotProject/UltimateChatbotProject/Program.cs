﻿using System;
using System.Threading;

namespace UltimateChatbotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            Console.WriteLine("Welcome to Assistant. I'm your chatbot today. What do you want to do (R = RockPaperScissors, C = iChatbot, Q = Quit)");
            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.R)
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                Console.WriteLine("Type R (Rock), P (Paper), or S (Scissors)!");
                
                string compchoices = "";

                string userchoices = "";

                ConsoleKeyInfo userchoice = Console.ReadKey();



                int compchoice = gen.Next(0, 4);



                // If compchoice statements  



                if (compchoice == 1)



                {



                    compchoices = "Rock";



                }



                else



                {



                    if (compchoice == 2)



                    {



                        compchoices = "Paper";



                    }



                    else



                    {



                        if (compchoice == 3)



                        {



                            compchoices = "Scissors";



                        }



                        else



                        {



                            Console.WriteLine("Quitting...");



                            Environment.Exit(0);



                        }



                    }



                }



                // If userchoice statements  



                if (userchoice.Key == ConsoleKey.R)



                {



                    userchoices = "Rock";



                }
                else if (userchoice.Key == ConsoleKey.P)
                {
                    userchoices = "Paper";
                }
                else if (userchoice.Key == ConsoleKey.S)
                {
                    userchoices = "Scissors";
                }

                // If userchoice and compchoice statements  



                if (userchoices == "Rock" && compchoices == "Rock")



                {



                    Console.WriteLine("It's a draw!!");



                }



                else



                {



                    if (userchoices == "Rock" && compchoices == "Paper")



                    {



                        Console.WriteLine("The computer wins!");



                    }



                    else



                    {



                        if (userchoices == "Rock" && compchoices == "Scissors")



                        {



                            Console.WriteLine("The User wins!");



                        }



                        else



                        {



                            if (userchoices == "Paper" && compchoices == "Rock")

                            {

                                Console.WriteLine("The User Wins!");

                            }

                            else

                            {

                                if (userchoices == "Paper" && compchoices == "Scissors")

                                {

                                    Console.WriteLine("The Computer Wins!");

                                }

                                else

                                {

                                    if (userchoices == "Paper" && compchoices == "Paper")

                                    {

                                        Console.WriteLine("It's a Draw!");

                                    }

                                    else

                                    {

                                        if (userchoices == "Scissors" && compchoices == "Scissors")

                                        {

                                            Console.WriteLine("It's a Draw!");

                                        }

                                        else

                                        {

                                            if (userchoices == "Scissors" && compchoices == "Paper")

                                            {

                                                Console.WriteLine("The User Wins");

                                            }

                                            else

                                            {

                                                if (userchoices == "Scissors" && compchoices == "Rock")

                                                {

                                                    Console.WriteLine("The Computer Wins!");

                                                }

                                                else

                                                {

                                                    Console.WriteLine("Quitting...");

                                                    Environment.Exit(0);

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
            //The chatbot software below
            else if (button.Key == ConsoleKey.C)
            {
                Console.WriteLine("");
                Console.WriteLine("iChatbot is loading...");
                Thread.Sleep(5000);
                Console.WriteLine("Let's Introduce Ourselves");
                Console.WriteLine("My name is Siri. What's yours?");
                string name = Console.ReadLine();

                if (name == "Siri")
                {
                    Console.WriteLine("Hmmm");
                }
                else
                {
                    Console.WriteLine("Hello" + name + "nice to meet you");
                }

                Console.WriteLine("How old are you");
                var age = Console.ReadLine();

                if (Convert.ToInt32(age) == 14)
                {
                    Console.WriteLine("Me too!");
                    Console.WriteLine("What year are you in ?");
                    var year = Console.ReadLine();
                    if (Convert.ToInt16(year) == 10)
                    {
                        Console.WriteLine("Same!");
                    }
                    else
                    {
                        Console.WriteLine("I'm in year 10!");
                    }
                }
                else
                {
                    Console.WriteLine("I'm 14 years old");

                    if (Convert.ToInt16(age) > Convert.ToInt16(14))
                    {
                        Console.WriteLine("I'm younger than you");
                    }
                    else
                    {
                        Console.WriteLine("I'm older than you");
                    }
                }
                Console.WriteLine("What's your favorite TV Show");
                string Show = Console.ReadLine();

                if (Show == "Designated Survivor")
                {
                    Console.WriteLine("That's a great TV Show");
                }

                else
                {
                    Console.WriteLine("I haven't watched that yet");
                    Console.WriteLine("Is it available on Netflix?");
                    ConsoleKeyInfo yesbutton = Console.ReadKey();
                    if (yesbutton.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("I'll check it out");
                    }
                    else
                    {
                        Console.WriteLine("I'll try to watch it somehow");
                    }
                }

                Console.WriteLine("What's your favorite song?");
                string song = Console.ReadLine();

                if (song == "Secreto")
                {
                    Console.WriteLine("I love that song!");
                }
                else
                {
                    Console.WriteLine("Is it on Spotify?");
                    var spotifybutton = Console.ReadKey();
                    if (spotifybutton.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("I'll listen to it soon.");
                    }
                    else if (spotifybutton.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("I'll try to listen to it sometime.");
                    }
                }

                Console.WriteLine(name + " do you have any pets?");
                ConsoleKeyInfo pets = Console.ReadKey();


                if (pets.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Do you have a cat or a dog " + name + " ?" + " (C/D) ");
                    ConsoleKeyInfo catdog = Console.ReadKey();

                    if (catdog.Key == ConsoleKey.C)
                    {
                        Console.WriteLine("I have a cat");
                        Console.WriteLine("Is your cat big/small? (B/S)");
                        ConsoleKeyInfo catsize = Console.ReadKey();
                        if (catsize.Key == ConsoleKey.B)
                        {
                            Console.WriteLine("I like big cats.");
                        }
                        else if (catsize.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("Small cats are cute!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("I don't like dogs");
                    }
                }
                else if (pets.Key == ConsoleKey.N)
                {
                    Console.WriteLine("I understand");
                }

                Console.WriteLine("How did you enjoy this chatbot out of 1-10?");
                var rating = Console.ReadLine();

                if (Convert.ToInt16(rating) > 5)
                {
                    Console.WriteLine("Thank you for the nice rating!");
                }
                else
                {
                    Console.WriteLine("I hope to improve for next time.");
                }
                
            }
            else if (button.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Quitting...");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        
        //Prevent the application from quitting automatically on completion.
        Console.ReadLine();
        }
    }
}