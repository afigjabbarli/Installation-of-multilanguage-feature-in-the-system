using TaskManagement.Common;
using TaskManagement.Common.Validators;
using TaskManagement.Contants;
using TaskManagement.Services;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
            
                string primaryCommands = "Zehmet olmasa, emrlerdən birini seçin";
                primaryCommands.TextTranslator();
                

                Console.WriteLine();
                string registr = "/Qeydiyyatdan keçin";
                registr.TextTranslator();
                string login = "/Daxil olun";
                login.TextTranslator();
                string usingLanguage = "/Dil seçimleri";
                usingLanguage.TextTranslator();
                string exit = "/Çıx";
                exit.TextTranslator();
                Console.WriteLine();

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
                    case "/Dil seçimleri":
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
