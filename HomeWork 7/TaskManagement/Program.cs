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
                        
                        RegisterCommand RegisterCommand = new RegisterCommand();
                        RegisterCommand.Handle();
                        break;
                    case "/Daxil olun":
                        
                        LoginCommand LoginCommand = new LoginCommand();
                        LoginCommand.Handle();
                        break;
                    case "/Dil seçimleri":
                        
                        ChangeLanguageCommand ChangeLanguageCommand = new ChangeLanguageCommand();
                        ChangeLanguageCommand.Handle();
                            break; 
                    case "/Çıx":
                       
                        string byebye = "İstifade etdiyiniz üçün teşekkür edirik.Sagholun...";
                        byebye.TextTranslator();
                        
                        return;
                    default:
                       
                        string invalid = "Yanlış əmr, xahiş edirəm yenidən cəhd edin";
                        invalid.TextTranslator();
                        break;


                    }
               }

                if(User.Language == CurrentLanguage.English)
                {
                    switch (inputCommand)
                    {
                        case "/Register":
                           
                            RegisterCommand RegisterCommand = new RegisterCommand();
                            RegisterCommand.Handle();
                            break;
                        case "/Login":
                            
                            LoginCommand LoginCommand = new LoginCommand();
                            LoginCommand.Handle();
                            break;
                        case "/Update-language-preference":
                           
                            ChangeLanguageCommand ChangeLanguageCommand = new ChangeLanguageCommand();
                            ChangeLanguageCommand.Handle();
                            break;
                        case "/Exit":
                           
                            string byebye = "İstifadə etdiyiniz üçün təşəkkür edirik.Sagholun...";
                            byebye.TextTranslator();

                            return;
                        default:
                            string invalid = "Yanlış əmr, xahiş edirəm yenidən cəhd edin";
                            invalid.TextTranslator();
                            break;

                    }

                }
                    if(User.Language == CurrentLanguage.Russian)
                    {
                        switch (inputCommand)
                        {
                            case "/Pегистр":
                                
                                RegisterCommand RegisterCommand = new RegisterCommand();
                                RegisterCommand.Handle();
                                break;
                            case "/Bходить":
                               
                                LoginCommand LoginCommand = new LoginCommand();
                                LoginCommand.Handle();
                                break;
                            case "/Языковые настройки":
                                
                                ChangeLanguageCommand ChangeLanguageCommand = new ChangeLanguageCommand();
                                ChangeLanguageCommand.Handle();
                                break;
                            case "/Выход":
                                
                                string byebye = "İstifadə etdiyiniz üçün təşəkkür edirik.Sagholun...";
                                byebye.TextTranslator();

                                return;
                            default:
                                string invalid = "Yanlış əmr, xahiş edirəm yenidən cəhd edin";
                                invalid.TextTranslator();
                                break;
                             
                        } 














                    }













                
            }
        }
    }
}
