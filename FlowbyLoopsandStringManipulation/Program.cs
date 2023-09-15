namespace FlowbyLoopsandStringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the main menu!");
            Console.WriteLine("Please navigate the menu by choosing a number:");
            Console.WriteLine("1. Purchase movie tickets ");
            Console.WriteLine("2. The repeat game! ");
            Console.WriteLine("3. The word game! ");
            Console.WriteLine("0. Exit");
            string selectedAction = Console.ReadLine();

            switch (selectedAction)
            {
                case "0":
                    Console.WriteLine("Closing down the menu.");
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again!");
                    break;
            }
        }
    }
}