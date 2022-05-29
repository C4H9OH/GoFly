using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace GoFly_web.Controllers
{
    public class ArrivalCountryController : Controller
    {

        private readonly IArrivalCountryManager _manager;

        private readonly ILogger<ArrivalCountryController> logger;



        public ArrivalCountryController(IArrivalCountryManager manager, ILogger<ArrivalCountryController> logger)
        {
            _manager = manager;
            this.logger = logger;
        }

        public async Task<IActionResult> Page()
        {
            var countries = await _manager.GetAll();
            return View(countries);
        }

        public RedirectResult GoToDepCountry()
        {
            return Redirect("/DepartureCountry/Page");
        }

        public RedirectResult GoToAdminHome()
        {
            return Redirect("/AdminHome/Index");
        }


        [HttpPost]
        public IActionResult DeleteCountry(int countryId)
        {
            _manager.DeleteCountry(countryId);
            return RedirectToAction(nameof(Page));
        }

        [HttpPost]
        public IActionResult CreateCountry(string name)
        {
            _manager.CreateCountry(name);
            return RedirectToAction(nameof(Page));
        }



        public IActionResult SendEmailDefault()
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.IsBodyHtml = true; //тело сообщения в формате HTML
                message.From = new MailAddress("wgofly@gmail.com", "Привет беброид!!!"); //отправитель сообщения
                message.To.Add("erdogan33@mail.ru"); //адресат сообщения
                message.Subject = "Сообщение от System.Net.Mail"; //тема сообщения
                message.Body = "<div style=\"color: red;\">Сообщение от сервиса GoFly</div>"; //тело сообщения
               // message.Attachments.Add(new Attachment("... путь к файлу ...")); //добавить вложение к письму при необходимости

                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com")) //используем сервера Google
                {
                    client.Credentials = new NetworkCredential("wgofly@gmail.com", "WeWant100"); //логин-пароль от аккаунта
                    client.Port = 587; //порт 587 либо 465
                    client.EnableSsl = true; //SSL обязательно

                    client.Send(message);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }

            return RedirectToAction(nameof(Page));
        }
    }
}
