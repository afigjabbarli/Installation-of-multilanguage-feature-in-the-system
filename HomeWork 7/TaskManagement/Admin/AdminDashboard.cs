using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.ShowUser;
using TaskManagement.Admin.UserManagement;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Admin
{
    public class AdminDashboard : IDashboard
    {
        public void Introduction()
        {
            string adminHello = "Salam hörmətli admin...";
            adminHello.TextTranslator();

            string primaryCommands = "Zehmet olmasa, emrlerden birini seçin";
            primaryCommands.TextTranslator();

            string showUsers = "/İstifadeçilerin gosterilmesi";
            showUsers.TextTranslator();
            string showUsersByEmail = "/İstifadeçilerin e-pocht unvanina uyghun gosterilmesi";
            showUsersByEmail.TextTranslator();
            string showUserById = "/İstifadeçilerin identifikasiya koduna uyghun gosterilmesi";
            showUserById.TextTranslator();
            string addUser = "/Istifadechi elave etmek";
            addUser.TextTranslator();
            string logout = "/Çıx";
            logout.TextTranslator();


            while (true)
            {
                string Command = "Emr:";
                Command.TextTranslator();
                string command = Console.ReadLine()!;
                if(User.Language == Contants.CurrentLanguage.Default)
                switch (command)
                {
                    case "/İstifadeçilerin gosterilmesi":
                        ShowUsersCommand showUsersCommand = new ShowUsersCommand();
                        showUsersCommand.Handle();
                        break;
                    case "/İstifadeçilerin e-pocht unvanina uyghun gosterilmesi":
                        ShowUserByEmailCommand showUserByEmailCommand = new ShowUserByEmailCommand();
                        showUserByEmailCommand.Handle();
                        break;
                    case "/İstifadeçilerin identifikasiya koduna uyghun gosterilmesi":
                        ShowUserByIdCommand showUserByIdCommand = new ShowUserByIdCommand();
                        showUserByIdCommand.Handle();
                        break;
                    case "/Istifadechi elave etmek":
                        AddUserCommand addUserCommand = new AddUserCommand();
                        addUserCommand.Handle();
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
                if(User.Language == Contants.CurrentLanguage.English)
                    switch (command)
                    {
                        case "/show-users":
                            ShowUsersCommand showUsersCommand = new ShowUsersCommand();
                            showUsersCommand.Handle();
                            break;
                        case "/show-user-by-email":
                            ShowUserByEmailCommand showUserByEmailCommand = new ShowUserByEmailCommand();
                            showUserByEmailCommand.Handle();
                            break;
                        case "/show-user-by-id":
                            ShowUserByIdCommand showUserByIdCommand = new ShowUserByIdCommand();
                            showUserByIdCommand.Handle();
                            break;
                        case "/add-user":
                            AddUserCommand addUserCommand = new AddUserCommand();
                            addUserCommand.Handle();
                            break;
                        case "/logout":
                            string byebye = "İstifade etdiyiniz üçün teşekkür edirik.Sagholun...";
                            byebye.TextTranslator();
                            return;
                        default:
                            string invalid = "Yanlış əmr, xahiş edirəm yenidən cəhd edin";
                            invalid.TextTranslator();
                            break;

                    }
                if(User.Language == Contants.CurrentLanguage.Russian)
                    switch (command)
                    {
                        case "/Отображение пользователей":
                            ShowUsersCommand showUsersCommand = new ShowUsersCommand();
                            showUsersCommand.Handle();
                            break;
                        case "/Отображение пользователей по их адресу электронной почты":
                            ShowUserByEmailCommand showUserByEmailCommand = new ShowUserByEmailCommand();
                            showUserByEmailCommand.Handle();
                            break;
                        case "/Отображение в соответствии с идентификационным кодом пользователя":
                            ShowUserByIdCommand showUserByIdCommand = new ShowUserByIdCommand();
                            showUserByIdCommand.Handle();
                            break;
                        case "/Добавить пользователя":
                            AddUserCommand addUserCommand = new AddUserCommand();
                            addUserCommand.Handle();
                            break;
                        case "/Выход":
                            string byebye = "İstifade etdiyiniz üçün teşekkür edirik.Sagholun...";
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
