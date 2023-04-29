using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Common.Validators
{
    public class ChangeLanguageCommand: ICommandHandler
    {
        public void Handle()
        {
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
                    break;
                  case "Russian language":
                    break;
                  case "English language":
                    break;
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
