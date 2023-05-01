using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Common.Validators;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Common
{
    public class LoginCommand : ICommandHandler
    {
        public void Handle() //use alias
        {
            Console.WriteLine();
            string inputemail = "zehmet olmasa elektron pocht unvaninizi daxil edin:"; inputemail.TextTranslator();
            string email = Console.ReadLine()!;

            string inputpassword = "zehmet olmasa shifrenizi daxil edin:"; inputpassword.TextTranslator();
            string password = Console.ReadLine()!;
            Console.WriteLine();
            ClassicUserValidator userValidator = new ClassicUserValidator();
            userValidator.GetAndValidateEmail();
            userValidator.GetAndValidatePassword();
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];

                if (user.Email == email && user.Password == password)
                {
                    if (user.IsBanned)
                    {
                        string banMessage = "Hesabınız qadağan edilib, siz qoşula bilməzsiniz";
                        banMessage.TextTranslator();
                        return;
                    }

                    UserService.CurrentUser = user;

                    if (user.Role == UserRole.Admin)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Introduction();
                    }
                    else
                    {
                        ClientDashboard clientDashboard = new ClientDashboard();
                        clientDashboard.Introduction();
                    }
                }
            }
        }
    }
}
