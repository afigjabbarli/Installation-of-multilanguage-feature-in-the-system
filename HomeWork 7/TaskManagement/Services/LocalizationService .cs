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
                    case "Yanlış əmr, xahiş edirəm yenidən cəhd edin":
                        Console.WriteLine(message.Replace(message, Translated_texts.INVALID_COMMAND_ENG));
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
                    case "Zehmet olmasa ekranda gösterilen dillerden birini seçin":
                        Console.WriteLine(message.Replace(message, Translated_texts.LANGUAGECOMMAND_ENG));
                        break;
                    case "Azerbaycan dili":
                        Console.WriteLine(message.Replace(message, Translated_texts.AZERBAIJAN_LANGUAGE_ENG));
                        break;
                    case "Rus dili":
                        Console.WriteLine(message.Replace(message, Translated_texts.RUSSIAN_LANGUAGE_ENG));
                        break;
                    case "Ingilis dili":
                        Console.WriteLine(message.Replace(message, Translated_texts.ENGLISH_LANGUAGE_ENG));
                        break;
                    case "Dil menyusundan çıxın":
                        Console.WriteLine(message.Replace(message, Translated_texts.EXIT_LANGUAGE_MENU_ENG));
                        break;
                    case "Dil:":
                        Console.Write(message.Replace(message, Translated_texts.LANGUAGE_ENG));
                        break;
                    case "Bu dil sistemde mövcud deyil...":
                        Console.WriteLine(message.Replace(message, Translated_texts.LANGUAGE_NOT_FOUND_ENG));
                        break;
                    case "Hesabınız qadağan edilib, siz qoşula bilməzsiniz":
                        Console.WriteLine(message.Replace(message, Translated_texts.BAN_MESSAGE_ENG));
                        break;
                   
                    case "E-poçtunuz olmalıdır, ....":
                        Console.WriteLine(message.Replace(message, Translated_texts.EMAIL_TRUE_ENG));
                        break;
                    case "Salam hörmətli admin...":
                        Console.WriteLine(message.Replace(message, Translated_texts.ADMIN_HELLO_ENG));
                        break;
                    case "/İstifadeçilerin gosterilmesi":
                        Console.WriteLine(message.Replace(message, Translated_texts.SHOW_USERS_ENG));
                        break;
                    case "/İstifadeçilerin e-pocht unvanina uyghun gosterilmesi":
                        Console.WriteLine(message.Replace(message, Translated_texts.SHOW_USERS_BY_EMAIL_ENG));
                        break;
                    case "/İstifadeçilerin identifikasiya koduna uyghun gosterilmesi":
                        Console.WriteLine(message.Replace(message, Translated_texts.SHOW_USERS_BY_ID_ENG));
                        break;
                    case "/Istifadechi elave etmek":
                        Console.WriteLine(message.Replace(message, Translated_texts.ADD_USER_ENG));
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
                    case "Yanlış əmr, xahiş edirəm yenidən cəhd edin":
                        Console.WriteLine(message.Replace(message, Translated_texts.INVALID_COMMAND_RUS));
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
                    case "Zehmet olmasa ekranda gösterilen dillerden birini seçin":
                        Console.WriteLine(message.Replace(message, Translated_texts.LANGUAGECOMMAND_RUS));
                        break;
                    case "Azerbaycan dili":
                        Console.WriteLine(message.Replace(message, Translated_texts.AZERBAIJAN_LANGUAGE_RUS));
                        break;
                    case "Rus dili":
                        Console.WriteLine(message.Replace(message, Translated_texts.RUSSIAN_LANGUAGE_RUS));
                        break;
                    case "Ingilis dili":
                        Console.WriteLine(message.Replace(message, Translated_texts.ENGLISH_LANGUAGE_RUS));
                        break;
                    case "Dil menyusundan çıxın":
                        Console.WriteLine(message.Replace(message, Translated_texts.EXIT_LANGUAGE_MENU_RUS));
                        break;
                    case "Dil:":
                        Console.Write(message.Replace(message, Translated_texts.LANGUAGE_RUS));
                        break;
                    case "Bu dil sistemde mövcud deyil...":
                        Console.WriteLine(message.Replace(message, Translated_texts.LANGUAGE_NOT_FOUND_RUS));
                        break;
                    case "Hesabınız qadağan edilib, siz qoşula bilməzsiniz":
                        Console.WriteLine(message.Replace(message, Translated_texts.BAN_MESSAGE_RUS));
                        break;
                    case "E-poçtunuz olmalıdır, ....":
                        Console.WriteLine(message.Replace(message, Translated_texts.EMAIL_TRUE_RUS));
                        break;
                    case "Salam hörmətli admin...":
                        Console.WriteLine(message.Replace(message, Translated_texts.ADMIN_HELLO_RUS));
                        break;
                    case "/İstifadeçilerin gosterilmesi":
                        Console.WriteLine(message.Replace(message, Translated_texts.SHOW_USERS_RUS));
                        break;
                    case "/İstifadeçilerin e-pocht unvanina uyghun gosterilmesi":
                        Console.WriteLine(message.Replace(message, Translated_texts.SHOW_USERS_BY_EMAIL_RUS));
                        break;
                    case "/İstifadeçilerin identifikasiya koduna uyghun gosterilmesi":
                        Console.WriteLine(message.Replace(message, Translated_texts.SHOW_USERS_BY_ID_RUS));
                        break;
                    case "/Istifadechi elave etmek":
                        Console.WriteLine(message.Replace(message, Translated_texts.ADD_USER_RUS));
                        break;




                }
            }



































        }


    }

} 

















