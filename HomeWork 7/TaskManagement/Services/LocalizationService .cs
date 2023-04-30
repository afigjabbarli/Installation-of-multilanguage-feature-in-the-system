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
                if (message == "Emr:")
                    Console.Write(message);
                if(message != "Emr:")
                    Console.WriteLine(message);
            }

            if(User.Language == CurrentLanguage.English)
            {
                
                switch(message)
                {
                    case "Zehmet olmasa, emrlerden birini seçin":
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
                    case "Emr:":
                        Console.Write(message.Replace(message, Translated_texts.COMMAND_ENG));
                        break;
                    case "İstifade etdiyiniz üçün teşekkür edirik.Sagholun...":
                        Console.WriteLine(message.Replace(message, Translated_texts.BAY_BAY_MESSAGE_ENG));
                        break;
                    case "Zəhmət olmasa istifadeçi adınızı daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.INPUT_FIRST_NAME_ENG));
                        break;
                    case "Siz sehv məlumat daxil etmisiniz. Yeniden daxil olun...":
                        Console.WriteLine(message.Replace(message, Translated_texts.FIRST_NAME_INFO_ENG));
                        break;
                    case "Zehmet olmasa soyadınızı daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.INPUT_LAST_NAME_ENG));
                        break;
                    case "Zehmet olmasa shifrenizi daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.PASSWORD_ENG));
                        break;
                    case "Zehmet olmasa tesdiq parolunu daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.CONFIRMPASSWORD_ENG));
                        break;
                    case "Zehmet olmasa elektron pocht unvaninizi daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.EMAIL_ENG));
                        break;
                    case "E-poçt unikal olmalıdır...":
                        Console.WriteLine(message.Replace(message, Translated_texts.UNIQUE_EMAIL_ENG));
                        break;



                }
            }

            if(User.Language == CurrentLanguage.Russian)
            {
                switch (message)
                {
                    case "Zehmet olmasa, emrlerden birini seçin":
                        Console.WriteLine(message.Replace(message, Translated_texts.PRIMARY_COMMAND_RUS));
                        break;
                    case "/Qeydiyyatdan keçin":
                        Console.WriteLine(message.Replace(message, Translated_texts.REGISTER_RUS));
                        break;
                    case "/Daxil olun":
                        Console.WriteLine(message.Replace(message, Translated_texts.LOGIN_RUS));
                        break;
                    case "/Dil seçimleri":
                        Console.WriteLine(message.Replace(message, Translated_texts.LANGUAGE_RUS));
                        break;
                    case "/Çıx":
                        Console.WriteLine(message.Replace(message, Translated_texts.EXIT_RUS));
                        break;
                    case "Emr:":
                        Console.Write(message.Replace(message, Translated_texts.COMMAND_RUS));
                        break;
                    case "İstifadə etdiyiniz üçün təşəkkür edirik.Sagholun...":
                        Console.WriteLine(message.Replace(message, Translated_texts.BAY_BAY_MESSAGE_RUS));
                        break;
                    case "Zəhmət olmasa istifadeçi adınızı daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.INPUT_FIRST_NAME_RUS));
                        break;
                    case "Siz sehv məlumat daxil etmisiniz. Yeniden daxil olun...":
                        Console.WriteLine(message.Replace(message, Translated_texts.FIRST_NAME_INFO_RUS));
                        break;
                    case "Zehmet olmasa soyadınızı daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.INPUT_LAST_NAME_RUS));
                        break;
                    case "Zehmet olmasa shifrenizi daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.PASSWORD_RUS));
                        break;
                    case "Zehmet olmasa tesdiq parolunu daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.CONFIRMPASSWORD_RUS));
                        break;
                    case "Zehmet olmasa elektron pocht unvaninizi daxil edin:":
                        Console.Write(message.Replace(message, Translated_texts.CONFIRMPASSWORD_RUS));
                        break;
                    case "E-poçt unikal olmalıdır...":
                        Console.WriteLine(message.Replace(message, Translated_texts.UNIQUE_EMAIL_RUS));
                        break;


                }
            }



































        }


    }

} 

















