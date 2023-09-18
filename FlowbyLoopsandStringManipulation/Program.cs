using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FlowbyLoopsandStringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        { //1. Creating menu options.
          //2. Creating switch statement for 0.Exit menu and default for "Wrong user input".
          //3. Testing application so far, realizing need of loop around switch.
          //4. Adding a while loop around the switch statement so that user can always come
          //back to main menu if not choosing 0.Exit menu.
          //5. Testing application after adding loop, adding Console.WriteLine outside of loop
          //to inform user that application will close down when input is 0.
          //6. Creating a method for purchaseMovieTicket, that will be called from inside the main
          //menu switch statement number 1.
          //7. Creating a method for purchaseMultipleMovieTickets, that will be called from inside
          //the main menu switch statement number 2.
          //8. Crating a method for askForAge to be called from inside method purchaseMultipleMovieTickets,
          //asking for age * number of tickets.
          //9. Building menu option nr 3, the repeat game. Using for loop to repeat userInput x 10.
          //10. Building menu option nr 4, the word game. Using user input, limited to minum of 3 characters,
          //to always pick out the 3rd word, Using the 'space' between characters to split the sentence and
          //detect the 3rd word.
          //11. Going back to building purchaseMultipleMovieTickets, created a method to be called from main menu 
          //number 4.
          //Defined ticket price per age, asked user for input on amount of tickets and age per ticket
          //calculated total cost for all tickets sold and displayed information to user.

            Console.WriteLine("Welcome to the main menu!");
            Console.WriteLine("Please navigate the menu by choosing a number:");
            Console.WriteLine("1. Purchase single movie ticket.");
            Console.WriteLine("2. Purchase group movie tickets.");
            Console.WriteLine("3. The repeat game! ");
            Console.WriteLine("4. The word game! ");
            Console.WriteLine("99. Back to Main Menu");
            Console.WriteLine("0. Exit");
            string selectedAction = Console.ReadLine();

            static void purchaseSingleMovieTicket()
            {
                Console.WriteLine("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                switch(age)
                {
                    case < 20:
                        Console.WriteLine(80 + "sek");
                        break;
                    case > 64:
                        Console.WriteLine(90 + "sek");
                        break;
                    default:
                        Console.WriteLine(120 + "sek");
                        break;
                }
            }

            static void purchaseMultipleMovieTickets()
            {
                int youthTicket = 80; 
                int seniorTicket = 90; 
                int standardTicket = 120; 

                int numberOfTickets;
                int[] ticketAge;

                Console.WriteLine("Please enter amount of tickets: ");
                numberOfTickets = int.Parse(Console.ReadLine());
                ticketAge = new int[numberOfTickets];

                for (int i = 0; i < numberOfTickets; i++)
                {
                    Console.WriteLine($"Enter the age of ticket #{i + 1}: ");
                    ticketAge[i] = int.Parse(Console.ReadLine());
                }

                int totalAmount = 0;
                for (int i = 0; i < numberOfTickets; i++ ) 
                {
                    int age = ticketAge[i];
                    if (age <= 19) 
                    { 
                    totalAmount += youthTicket;
                    }
                    else if (age >= 63)
                    {
                        totalAmount += seniorTicket;
                    }
                    else
                    {
                        totalAmount += standardTicket;
                    }
                }
                Console.WriteLine($"Number of tickets sold: {numberOfTickets}");
                Console.WriteLine($"Total cost: {totalAmount:F2}sek");
            }

            //static int askForAge()
            //{
            //    Console.WriteLine("Insert age for this ticket: ");
            //    int askForAge = int.Parse(Console.ReadLine());
            //    int storePrice = int.Parse(Console.ReadLine());

            //    while(askForAge != 0) 
            //    {
            //        switch(askForAge)
            //        {
            //            case < 20:
            //                Console.WriteLine(80);
            //                break;
            //            case > 64:
            //                Console.WriteLine(90);
            //                break;
            //            default:
            //                Console.WriteLine(120);
            //                break;
            //        }
            //        return storePrice;
            //    }
            //    return askForAge;
            //}

            static void repeatTenTimes()
            {
                Console.WriteLine("Insert a word: ");
                string userInput = Console.ReadLine();
                int repeatNumber = 10;

                StringBuilder repeatString = new StringBuilder();

                for (int  i = 0; i < repeatNumber; i++) 
                {
                    repeatString.Append(userInput);
                }
                string result = repeatString.ToString();
                Console.WriteLine(result);
            }

            static void picCorrectWord()
            {
                Console.WriteLine("Write a sentence: ");
                string sentenceUserInput = Console.ReadLine();

               string[] words = sentenceUserInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 3)
                {
                    Console.WriteLine("The third word is: " + words[2]);
                } else
                {
                    Console.WriteLine("Please make sure the sentence is no less than three words.");
                }
            }

            while(selectedAction != "0")
            {
                switch(selectedAction)
                {
                    case "0":
                        Console.WriteLine("Closing down the menu.");
                        break;
                    case "1":
                        Console.WriteLine("Welcome to Farah´s Cinema!");
                        purchaseSingleMovieTicket();
                        break;
                    case "2":
                        Console.WriteLine("Welcome to Farah´s Cinema!");
                        purchaseMultipleMovieTickets();
                        break;
                    case "3":
                        Console.WriteLine("Welcome to the Repeat Game!");
                        repeatTenTimes();
                        break;
                    case "4":
                        Console.WriteLine("Welcome to the Word Game");
                        picCorrectWord();
                        break;
                    case "99":
                        Console.WriteLine("Welcome back to the main menu!");
                        Console.WriteLine("1. Purchase single movie ticket.");
                        Console.WriteLine("2. Purchase group movie tickets.");
                        Console.WriteLine("3. The repeat game! ");
                        Console.WriteLine("4. The word game! ");
                        Console.WriteLine("99. Back to Main Menu");
                        Console.WriteLine("0. Exit");
                        break;
                    default:
                        Console.WriteLine("Wrong input, please try again!");
                        break;
                }
                selectedAction = Console.ReadLine();
            }
            Console.WriteLine("Closing down the application.");
        }
    }
}