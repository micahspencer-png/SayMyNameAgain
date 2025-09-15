namespace SayMyNameAgain
{

    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Say My Name Again Program
    //https://github.com/micahspencer-png/SayMyNameAgain.git

    internal class Program
    {
        static void Main(string[] args)
        {
            //sets variable
            string userName;

            //prompts user for name
            Console.WriteLine("What is your Name?");
            userName = Console.ReadLine();

            //creates standard message for emily and joe
            if (userName == "Joe") 
            {
                Console.WriteLine($"Hello,{userName}!");
            }

            else if (userName == "Emily")
            {
                Console.WriteLine($"Hello,{userName}!");
            }
            //creates unique message for my name
            else if (userName == "Micah")
            {
                Console.WriteLine($"Amazing Name, {userName}!!! You are unique like me!!!");
            }
           
            //creates generic message for every other name
            else
            {
                Console.WriteLine($"Greetings, {userName}");
            }
            //creates pause
            Console.Read();
        }
    }
}
