using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b
{

    //}
    class Program
    {
        
        static void Main(string[] args)
        {
            bool showMenu = true;            
            Player MP3 = new Player();
            do
            {
                Console.WriteLine("** Music Player **");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Add new song");
                Console.WriteLine("3. Remove song");
                Console.WriteLine("0. Exit");

                int userChoice = checkValidInput("\nEnter your selection: ",
                                                    "Wrong input! please dont enter any string here: ",
                                                    "Wrong input! Please enter a valid number in the list: ", 0, 3);

                if (userChoice == 0)
                {
                    break;
                }
                else
                {

                    switch (userChoice)
                    {
                        case 1:
                            MP3.AutoPlay();
                            break;
                        case 2:
                            getNewSong(MP3);

                            break;
                        case 3:                            
                            
                            break;
                        
                        default:
                            break;
                    }
                }


            } while (showMenu);






        }
        private static Player getNewSong(Player MP3)
        {
            Console.Clear();          
            string titleInput, authorInput, genresInput;
            
            do
            {
                Console.Write("Song's title: ");
                titleInput = Console.ReadLine();

                Console.Write("Song's author: ");
                authorInput = Console.ReadLine();

                Console.Write("Song's genre: ");
                genresInput = Console.ReadLine().ToLower();

                switch (genresInput)
                {
                    case "rock":
                        MP3.Add(new Rock(titleInput, authorInput));
                        break;
                    case "alternative rock":
                        MP3.Add(new AlternativeRock(titleInput, authorInput));
                        break;
                    case "heavy metal rock":
                        MP3.Add(new HeavyMetalRock(titleInput, authorInput));
                        break;
                    case "indie alternative rock":
                        MP3.Add(new IndieAlternativeRock(titleInput, authorInput));
                        break;
                    case "doom metal rock":
                        MP3.Add(new DoomMetalRock(titleInput, authorInput));
                        break;
                    case "blue":
                        MP3.Add(new Blue(titleInput, authorInput));
                        break;
                    case "jazz blue":
                        MP3.Add(new JazzBlue(titleInput, authorInput));
                        break;
                    case "blue rock":
                        MP3.Add(new JazzBlue(titleInput, authorInput));
                        break;
                    default:
                        Console.WriteLine("Sorry we dont have this gerne in the library");
                        break;
                }

            } while (askUserToContinue("\nDo you want too add more song [Y/N]? "));
            return MP3;
        }
        static private int checkValidInput(string messenge, string errorMessenge_1, string errorMessenge_2, int inputMin = 0, int inputMax = 0)
        {
            int userChoice = 0;
            Console.Write(messenge);
            do
            {
                if (tryGetNumberInput(out userChoice))
                {
                    if (userChoice < inputMin || userChoice > inputMax)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);                        
                        Console.Write(errorMessenge_2);
                        continue;
                    }
                    break;
                }

                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop-1);
                    Console.Write(errorMessenge_1);
                }
            } while (true);

            return userChoice;
        }

        private static bool askUserToContinue(string messenge)
        {
           while(true)
           {
                Console.Write(messenge);
                string answer = Console.ReadLine().ToUpper();                
                Console.WriteLine();
                if (answer == "Y")
                {
                    return true;
                }
                if (answer == "N")
                {
                    Console.Clear();                    
                    return false;
                }
                Console.SetCursorPosition(0, Console.CursorTop - 1);

            }

        }      

        private static bool tryGetNumberInput(out int input)
        {
            return int.TryParse(Console.ReadLine(), out input);
        }

    }

}
