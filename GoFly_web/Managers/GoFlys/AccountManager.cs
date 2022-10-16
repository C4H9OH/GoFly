using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Web;

namespace GoFly_web.Managers.GoFlys
{
    public class AccountManager : IAccountManager
    {
        private readonly GOflyContext _context;
        private readonly ILogger<AccountManager> _logger;

        private string mailConfirmation;


        public AccountManager(GOflyContext context, ILogger<AccountManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public User Login(string email, string password)
        {
            try
            {
                var _email = _context.Users.FirstOrDefault(U => U.Email == email);
                var _password = _context.Users.FirstOrDefault(U => U.Password == password);
                if ((_password != null) & (_email != null))
                {
                    if (password == _password.Password)
                    {

                        return _email;
                    }
                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) { }

            return null;

        }

        public async Task Logout()
        {
            throw new NotImplementedException();
        }

        public async Task  Register(string firstName, string lastName, string email, string password, string gender, string phoneNumber, int age)
        {
            var _email = _context.Users.FirstOrDefault(U => U.Email == email);
            if (_email == null)
            {
              

                  try
                {
                    mailConfirmation = Guid.NewGuid().ToString();
                    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                    message.IsBodyHtml = true; //тело сообщения в формате HTML
                    message.From = new MailAddress("sardarovvadim123@gmail.com", "Mail Confirmation"); //отправитель сообщения
                    message.To.Add(email); //адресат сообщения
                    message.Subject = "Mail Confirmation"; //тема сообщения
                    message.Body = mailConfirmation; //тело сообщения
                                                                                                  // message.Attachments.Add(new Attachment("... путь к файлу ...")); //добавить вложение к письму при необходимости

                    using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com")) //используем сервера Google
                    {
                        client.Credentials = new NetworkCredential("sardarovvadim123@gmail.com", "Vadimchik2002"); //логин-пароль от аккаунта
                        client.Port = 587; //порт 587 либо 465
                        client.EnableSsl = true; //SSL обязательно

                        client.Send(message);
                        _logger.LogInformation("Сообщение отправлено успешно!");
                    }
                   


                }
                catch (Exception e)
                {
                    _logger.LogError(e.GetBaseException().Message);
                }


                finally {
                    var user = new User
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Password = password,
                        Gender = gender,
                        OrdersCount = 0,
                        PhoneNumber = phoneNumber,
                        Age = age,
                        RegCode = mailConfirmation
                    };
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return;
            }
        }

        public async Task MailConfirmation(string mailConfirmation)
        {
            var user = _context.Users.FirstOrDefault(U => U.RegCode == mailConfirmation);

            //if (user == null)
            //{
            //    _context.Users.Remove(user);
            //    await _context.SaveChangesAsync();
            //}
        }
    }
}
