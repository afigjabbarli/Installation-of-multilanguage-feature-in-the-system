using TaskManagement.Admin;
using TaskManagement.Common;
using TaskManagement.Common.Validators;
using TaskManagement.Database;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the commands");
            Console.WriteLine();
            Console.WriteLine("/Register");
            Console.WriteLine("/Login");
            Console.WriteLine("/Update-language-preference");
            Console.WriteLine("/Exit");
            Console.WriteLine();
            
            while (true)
            {
                Console.Write("Command:"); string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/Register":
                        RegisterCommand registerCommand = new RegisterCommand();
                        registerCommand.Handle();
                        break;
                    case "/Login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle();
                        break;
                    case "/Update-language-preference":
                        ChangeLanguageCommand changeLanguageCommand = new ChangeLanguageCommand();
                        changeLanguageCommand.Handle();
                        break;
                    case "/Exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;

                }
            }
        }
    }
}
