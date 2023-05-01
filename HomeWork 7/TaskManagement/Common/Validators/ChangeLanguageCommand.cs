using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Common.Validators
{
    public class ChangeLanguageCommand : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine();
            string languageMessage = "Zehmet olmasa ekranda gösterilen dillerden birini seçin";
            languageMessage.TextTranslator();
            Console.WriteLine();
            string languageAz = "Azerbaycan dili";
            languageAz.TextTranslator();
            string languageRus = "Rus dili";
            languageRus.TextTranslator();
            string languageEng = "Ingilis dili";
            languageEng.TextTranslator();
            string exitLanguageMenu = "Dil menyusundan çıxın";
            exitLanguageMenu.TextTranslator();
            Console.WriteLine();
            while (true)
            {
                string languageCommand = "Dil:"; languageCommand.TextTranslator();
                string language = Console.ReadLine()!;
                Console.WriteLine();
                if (User.Language == CurrentLanguage.Default)
                {

                    switch (language)
                    {
                        case "Azerbaycan dili":
                            User.Language = CurrentLanguage.Default;
                            return;
                        case "Rus dili":
                            User.Language = CurrentLanguage.Russian;
                            return;
                        case "Ingilis dili":
                            User.Language = CurrentLanguage.English;
                            return;
                        case "Dil menyusundan çıxın":
                            return;
                        default:
                            string languageNotFound = "Bu dil sistemde mövcud deyil...";
                            languageNotFound.TextTranslator();
                            Console.WriteLine();
                            break;

                    }
                }

                if (User.Language == CurrentLanguage.English)
                {
                    
                    switch (language)
                    {
                        case "Azerbaijan language":
                            User.Language = CurrentLanguage.Default;
                            return;
                        case "Russian language":
                            User.Language = CurrentLanguage.Russian;
                            return;
                        case "English language":
                            User.Language = CurrentLanguage.English;
                            return;
                        case "Exit the language menu":
                            return;
                        default:
                            string languageNotFound = "Bu dil sistemde mövcud deyil...";
                            languageNotFound.TextTranslator();
                            Console.WriteLine();
                            break;

                    }
                }
                    
                    if (User.Language == CurrentLanguage.Russian)
                    {
                        
                        switch (language)
                        {
                            case "Aзербайджанский язык":
                                User.Language = CurrentLanguage.Default;
                                return;
                            case "Pусский язык":
                                User.Language = CurrentLanguage.Russian;
                                return;
                            case "английский язык":
                                User.Language = CurrentLanguage.English;
                                return;
                            case "Выйти из языкового меню":
                                return;
                            default:
                                string languageNotFound = "Bu dil sistemde mövcud deyil...";
                                languageNotFound.TextTranslator();
                                Console.WriteLine();
                                break;

                        }

                    }








                    
















            }
        }
    }
}
