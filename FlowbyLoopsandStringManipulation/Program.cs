using System.Security.Cryptography.X509Certificates;

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
          //6. Creating a method that holds a function, that will be called from inside the switch
          //statement number 1.
          //7. Back tracking to improve menu, and what is shown to user.
          //8. Testing so far, menues are ok.

            Console.WriteLine("Welcome to the main menu!");
            Console.WriteLine("Please navigate the menu by choosing a number:");
            Console.WriteLine("1. Purchase single movie ticket.");
            Console.WriteLine("2. Purchase group movie tickets.");
            Console.WriteLine("3. The repeat game! ");
            Console.WriteLine("4. The word game! ");
            Console.WriteLine("99. Back to Main Menu");
            Console.WriteLine("0. Exit");
            string selectedAction = Console.ReadLine();

            static void purchaseMovieTicket()
            {
                Console.WriteLine("Please navigate the menu by choosing a number:");
                Console.WriteLine("1. Purschase single ticket");
                Console.WriteLine("99. Back to Main Menu");
                Console.WriteLine("0. Exit");
                string ticket = Console.ReadLine();

                while (ticket != null)
                {
                    switch (ticket)
                    {
                        case "0":
                            Console.WriteLine("Closing down the menu.");
                            //Fix: Does not actually close application.
                            break;
                        case "1":
                            Console.WriteLine("Enter your age: ");
                            break;
                        case "99":
                            Console.WriteLine("Welcome back to the main menu!");
                            Console.WriteLine("1. Purchase movie tickets ");
                            Console.WriteLine("2. The repeat game! ");
                            Console.WriteLine("3. The word game! ");
                            Console.WriteLine("99. Back to Main Menu");
                            Console.WriteLine("0. Exit");
                            break;
                        default:
                            Console.WriteLine("Wrong input, please try again!");
                            break;
                    }
                    ticket = Console.ReadLine();
                }
                Console.WriteLine("Closing down the application.");
            }

            while (selectedAction != "0")
            {
                switch (selectedAction)
                {
                    case "0":
                        Console.WriteLine("Closing down the menu.");
                        break;
                    case "1":
                        Console.WriteLine("Welcome to Farah´s Cinema!");
                        purchaseMovieTicket();
                        break;
                    case "99":
                        Console.WriteLine("Welcome back to the main menu!");
                        Console.WriteLine("1. Purchase movie tickets ");
                        Console.WriteLine("2. The repeat game! ");
                        Console.WriteLine("3. The word game! ");
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