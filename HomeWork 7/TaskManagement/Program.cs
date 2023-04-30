using TaskManagement.Common;
using TaskManagement.Common.Validators;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
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
            
                string primaryCommands = "Zehmet olmasa, emrlerden birini seçin";
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

                string Command = "Emr:";
                Command.TextTranslator();
                string inputCommand = Console.ReadLine()!;

                
                
               if(User.Language == CurrentLanguage.Default)
               {
                    switch (inputCommand)
                    {
                    case "/Qeydiyyatdan keçin":
                        string registerCommand = "/Qeydiyyatdan keçin";
                        registerCommand.TextTranslator();
                        RegisterCommand RegisterCommand = new RegisterCommand();
                        RegisterCommand.Handle();
                        break;
                    case "/Daxil olun":
                        string loginCommand = "/Daxil olun";
                        loginCommand.TextTranslator();  
                        LoginCommand LoginCommand = new LoginCommand();
                        LoginCommand.Handle();
                        break;
                    case "/Dil seçimleri":
                        string changeLanguageCommand = "/Dil seçimleri";
                        changeLanguageCommand.TextTranslator(); 
                        ChangeLanguageCommand ChangeLanguageCommand = new ChangeLanguageCommand();
                        ChangeLanguageCommand.Handle();
                            break; 
                    case "/Çıx":
                        string exitCommand = "/Çıx";
                        exitCommand.TextTranslator();
                        string byebye = "İstifade etdiyiniz üçün teşekkür edirik.Sagholun...";
                        byebye.TextTranslator();
                        
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;


                    }
               }

                if(User.Language == CurrentLanguage.English)
                {
                    switch (inputCommand)
                    {
                        case "/Register":
                            string registerCommand = "/Qeydiyyatdan keçin";
                            registerCommand.TextTranslator();
                            RegisterCommand RegisterCommand = new RegisterCommand();
                            RegisterCommand.Handle();
                            break;
                        case "/Login":
                            string loginCommand = "/Daxil olun";
                            loginCommand.TextTranslator();
                            LoginCommand LoginCommand = new LoginCommand();
                            LoginCommand.Handle();
                            break;
                        case "/Update-language-preference":
                            string changeLanguageCommand = "/Dil seçimleri";
                            changeLanguageCommand.TextTranslator();
                            ChangeLanguageCommand ChangeLanguageCommand = new ChangeLanguageCommand();
                            ChangeLanguageCommand.Handle();
                            break;
                        case "/Exit":
                            string exitCommand = "/Çıx";
                            exitCommand.TextTranslator();
                            string byebye = "İstifadə etdiyiniz üçün təşəkkür edirik.Sagholun...";
                            byebye.TextTranslator();

                            return;
                        default:
                            Console.WriteLine("Invalid command, pls try again");
                            break;

                    }

                }
                    if(User.Language == CurrentLanguage.Russian)
                    {
                        switch (inputCommand)
                        {
                            case "/Pегистр":
                                string registerCommand = "/Qeydiyyatdan keçin";
                                registerCommand.TextTranslator();
                                RegisterCommand RegisterCommand = new RegisterCommand();
                                RegisterCommand.Handle();
                                break;
                            case "/Bходить":
                                string loginCommand = "/Daxil olun";
                                loginCommand.TextTranslator();
                                LoginCommand LoginCommand = new LoginCommand();
                                LoginCommand.Handle();
                                break;
                            case "/Языковые настройки":
                                string changeLanguageCommand = "/Dil seçimleri";
                                changeLanguageCommand.TextTranslator();
                                ChangeLanguageCommand ChangeLanguageCommand = new ChangeLanguageCommand();
                                ChangeLanguageCommand.Handle();
                                break;
                            case "/Выход":
                                string exitCommand = "/Çıx";
                                exitCommand.TextTranslator();
                                string byebye = "İstifadə etdiyiniz üçün təşəkkür edirik.Sagholun...";
                                byebye.TextTranslator();

                                return;
                            default:
                                Console.WriteLine("Invalid command, pls try again");
                                break;

                        } 














                    }













                
            }
        }
    }
}
