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

        public const string IVALID_COMMAND_AZ = "Yanlış əmr, xahiş edirəm yenidən cəhd edin";
        public const string INVALID_COMMAND_ENG = "Invalid command, please try again";
        public const string INVALID_COMMAND_RUS = "Неверная команда, попробуйте еще раз";

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

        public const string LANGUAGE_COMMAND_AZ = "Zehmet olmasa ekranda gösterilen dillerden birini seçin";
        public const string LANGUAGE_COMMAND_ENG = "Please choose one of the languages shown on the screen";
        public const string LANGUAGE_COMMAND_RUS = "Пожалуйста, выберите один из языков, отображаемых на экране";

        public const string AZERBAIJAN_LANGUAGE_AZ = "Azerbaycan dili";
        public const string AZERBAIJAN_LANGUAGE_ENG = "Azerbaijan language";
        public const string AZERBAIJAN_LANGUAGE_RUS = "Aзербайджанский язык";

        public const string RUSSIAN_LANGUAGE_AZ = "Rus dili";
        public const string RUSSIAN_LANGUAGE_ENG = "Russian language";
        public const string RUSSIAN_LANGUAGE_RUS = "Pусский язык";

        public const string ENGLISH_LANGUAGE_AZ = "Ingilis dili";
        public const string ENGLISH_LANGUAGE_ENG = "English language";
        public const string ENGLISH_LANGUAGE_RUS = "английский язык";

        public const string EXIT_LANGUAGE_MENU_AZ = "Dil menyusundan çıxın";
        public const string EXIT_LANGUAGE_MENU_ENG = "Exit the language menu";
        public const string EXIT_LANGUAGE_MENU_RUS = "Выйти из языкового меню";

        public const string LANGUAGECOMMAND_AZ = "Dil:";
        public const string LANGUAGECOMMAND_ENG = "Language:";
        public const string LANGUAGECOMMAND_RUS = "Язык:";

        public const string LANGUAGE_NOT_FOUND_AZ = "Bu dil sistemde mövcud deyil...";
        public const string LANGUAGE_NOT_FOUND_ENG = "This language is not available in the system...";
        public const string LANGUAGE_NOT_FOUND_RUS = "Этот язык недоступен в системе...";

        public const string BAN_MESSAGE_AZ = "Hesabınız qadağan edilib, siz qoşula bilməzsiniz";
        public const string BAN_MESSAGE_ENG = "Your account is banned, you can't join";
        public const string BAN_MESSAGE_RUS = "Ваш аккаунт заблокирован, вы не можете присоединиться";

        public const string EMAIL_TRUE_AZ = "E-poçtunuz olmalıdır, ....";
        public const string EMAIL_TRUE_ENG = "You email should conta";
        public const string EMAIL_TRUE_RUS = "Ваша электронная почта должна содержать";

        public const string ADMIN_HELLO_AZ = "Salam hörmətli admin...";
        public const string ADMIN_HELLO_ENG = "Hello dear admin...";
        public const string ADMIN_HELLO_RUS = "Здравствуйте уважаемый админ...";

        public const string SHOW_USERS_AZ = "/İstifadeçilerin gosterilmesi";
        public const string SHOW_USERS_ENG = "/show-users";
        public const string SHOW_USERS_RUS = "/Отображение пользователей";

        public const string SHOW_USERS_BY_EMAIL_AZ = "/İstifadeçilerin e-pocht unvanina uyghun gosterilmesi";
        public const string SHOW_USERS_BY_EMAIL_ENG = "/show-user-by-email";
        public const string SHOW_USERS_BY_EMAIL_RUS = "/Отображение пользователей по их адресу электронной почты";

        public const string SHOW_USERS_BY_ID_AZ = "/İstifadeçilerin identifikasiya koduna uyghun gosterilmesi";
        public const string SHOW_USERS_BY_ID_ENG = "/show-user-by-id";
        public const string SHOW_USERS_BY_ID_RUS = "/Отображение в соответствии с идентификационным кодом пользователя";

        public const string ADD_USER_AZ = "/Istifadechi elave etmek";
        public const string ADD_USER_ENG = "/add-user";
        public const string ADD_USER_RUS = "/Добавить пользователя";


    }
}