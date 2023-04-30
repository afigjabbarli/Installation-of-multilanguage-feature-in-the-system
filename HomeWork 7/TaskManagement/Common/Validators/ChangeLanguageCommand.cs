using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;

namespace TaskManagement.Common.Validators
{
    public class ChangeLanguageCommand: ICommandHandler 
    {
        public void Handle()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose one of the languages shown on the screen");
            Console.WriteLine();
            Console.WriteLine("Azerbaijan language(default)");
            Console.WriteLine("Russian language");
            Console.WriteLine("English language"); 
            Console.WriteLine("Exit the language menu");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Language:"); string language = Console.ReadLine()!;
                Console.WriteLine();
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
                  default: Console.WriteLine("This language is not available in the system...");
                        Console.WriteLine();
                    break;
                        
                }

            }







        }
    }
}
