namespace FlowbyLoopsandStringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        { //1. Creating menu options.
          //2. Creating switch statement for 0.Exit menu and default for "Wrong user input".
          //3. Testing application so far, realizing need of loop aroun switch.
          //4. Adding a while loop around the switch statement so that user can always come
          //back to main menu if not choosing 0.Exit menu.
          //5. Testing application after adding loop, adding Console.WriteLine outside of loop
          //to inform user that application will close down after input of 0.
            Console.WriteLine("Welcome to the main menu!");
            Console.WriteLine("Please navigate the menu by choosing a number:");
            Console.WriteLine("1. Purchase movie tickets ");
            Console.WriteLine("2. The repeat game! ");
            Console.WriteLine("3. The word game! ");
            Console.WriteLine("0. Exit");
            string selectedAction = Console.ReadLine();

            while (selectedAction != "0")
            {
                switch (selectedAction)
                {
                    case "0":
                        Console.WriteLine("Closing down the menu.");
                        break;
                    default:
                        Console.WriteLine("Wrong input, please try again!");
                        break;
                }
                Console.WriteLine("Welcome back to the main menu!");
                Console.WriteLine("Please navigate the menu by choosing a number:");
                Console.WriteLine("1. Purchase movie tickets ");
                Console.WriteLine("2. The repeat game! ");
                Console.WriteLine("3. The word game! ");
                Console.WriteLine("0. Exit");
                selectedAction = Console.ReadLine();
            }
            Console.WriteLine("Closing down the application.");
        }
    }
}