using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackManager _manager;




        public FeedbackController(IFeedbackManager manager)
        {
            _manager = manager;
        }
      

        public async Task<IActionResult> Feedback()
        {
            var feedbacks = await _manager.GetAll();
            return View(feedbacks);
        }

        [HttpPost]
        public IActionResult CreateFeedback(string description)
        {
            
              
             _manager.CreateFeedback("taiwan.profiler@mail.ru", description);
            return RedirectToAction(nameof(Feedback));
        }
    }
}