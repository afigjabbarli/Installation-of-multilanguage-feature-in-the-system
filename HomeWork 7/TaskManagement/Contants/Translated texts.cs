using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Contants
{
    public static class Translated_texts
    {
        public const string PRIMARY_COMMAND_AZ = "Zehmet olmasa, emrlerden birini seçin";
        public const string PRIMARY_COMMAND_ENG = "Please choose one of the commands";
        public const string PRIMARY_COMMAND_RUS = "Пожалуйста, выберите одну из команд";

        public const string REGISTER_AZ = "/Qeydiyyatdan keçin";
        public const string REGISTER_ENG = "/Register";
        public const string REGISTER_RUS = "/Pегистр";

        public const string LOGIN_AZ = "/Daxil olun";
        public const string LOGIN_ENG = "/Login";
        public const string LOGIN_RUS = "/Bходить";

        public const string LANGUAGE_AZ = "/Dil seçimleri";
        public const string LANGUAGE_ENG = "/Update-language-preference";
        public const string LANGUAGE_RUS = "/Языковые настройки";

        public const string EXIT_AZ = "/Çıx";
        public const string EXIT_ENG = "/Exit";
        public const string EXIT_RUS = "/Выход";

        public const string COMMAND_AZ = "Emr:";
        public const string COMMAND_ENG = "Command:";
        public const string COMMAND_RUS = "Kоманд:";

        public const string BAY_BAY_MESSAGE_AZ = "İstifade etdiyiniz üçün teşekkür edirik.Sagholun...";
        public const string BAY_BAY_MESSAGE_ENG = "Thank you for using.Bye-Bye...";
        public const string BAY_BAY_MESSAGE_RUS = "Спасибо за использование.До свидания...";

        public const string INPUT_FIRST_NAME_AZ = "Zəhmət olmasa istifadeçi adınızı daxil edin:";
        public const string INPUT_FIRST_NAME_ENG = "Pls user enter your first name:";
        public const string INPUT_FIRST_NAME_RUS = "Пожалуйста, введите свое имя:";

        public const string FIRST_NAME_INFO_AZ = "Siz sehv məlumat daxil etmisiniz. Yeniden daxil olun...";
        public const string FIRST_NAME_INFO_ENG = "The information you entered is incorrect. Please re-enter...";
        public const string FIRST_NAME_INFO_RUS = "Вы ввели неверную информацию. Пожалуйста, введите еще раз...";

        public const string INPUT_LAST_NAME_AZ = "Zehmet olmasa soyadınızı daxil edin:";
        public const string INPUT_LAST_NAME_ENG = "Please enter your last name:";
        public const string INPUT_LAST_NAME_RUS = "Пожалуйста, введите свою фамилию:";

        public const string PASSWORD_AZ = "Zehmet olmasa shifrenizi daxil edin:";
        public const string PASSWORD_ENG = "Please enter your password:";
        public const string PASSWORD_RUS = "Пожалуйста введите ваш пароль:";
        
        public const string CONFIRMPASSWORD_AZ = "Zehmet olmasa tesdiq shifrenizi daxil edin:";
        public const string CONFIRMPASSWORD_ENG = "Please enter your confirm password:";
        public const string CONFIRMPASSWORD_RUS = "Пожалуйста, введите проверочный код:";

        public const string EMAIL_AZ = "Zehmet olmasa elektron pocht unvaninizi daxil edin:";
        public const string EMAIL_ENG = "Please enter your email address:";
        public const string EMAIL_RUS = "Пожалуйста, введите Ваш адрес электронной почты:";

        public const string UNIQUE_EMAIL_AZ = "E-poçt unikal olmalıdır...";
        public const string UNIQUE_EMAIL_ENG = "Email must be unique...";
        public const string UNIQUE_EMAIL_RUS = "Электронная почта должна быть уникальной...";

    }
}