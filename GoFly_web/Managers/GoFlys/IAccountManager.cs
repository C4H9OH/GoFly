using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IAccountManager
    {
         User  Login(string email, string password);

        Task Logout();

        Task Register(string firstName, string lastName, string email, string password, string gender,
            string phoneNumber, int age,string language);

        Task MailConfirmation(string mailConfirmation);
    }
}
