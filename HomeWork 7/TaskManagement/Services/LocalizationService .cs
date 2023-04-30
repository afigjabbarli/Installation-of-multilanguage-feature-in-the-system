using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;

namespace TaskManagement.Services
{
    public static class LocalizationService
    {
        public static void TextTranslator(this string message)
        {
            
            if(User.Language == CurrentLanguage.Default)
            {
                Console.WriteLine(message);
            }

            if(User.Language == CurrentLanguage.English)
            {
                
                switch(message)
                {
                    case "Zehmet olmasa, emrlerdən birini seçin":
                        Console.WriteLine(message.Replace(message, Translated_texts.PRIMARY_COMMAND_ENG));
                        break;
                    case "/Qeydiyyatdan keçin":
                        Console.WriteLine(message.Replace(message, Translated_texts.REGISTER_ENG));
                        break;
                    case "/Daxil olun":
                        Console.WriteLine(message.Replace(message, Translated_texts.LOGIN_ENG));
                        break;
                    case "/Dil seçimleri":
                        Console.WriteLine(message.Replace(message, Translated_texts.LANGUAGE_ENG));
                        break;
                    case "/Çıx":
                        Console.WriteLine(message.Replace(message, Translated_texts.EXIT_ENG));
                        break;
                }
            }
























        }


    }

} 

















