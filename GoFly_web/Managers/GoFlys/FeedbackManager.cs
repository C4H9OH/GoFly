using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class FeedbackManager : IFeedbackManager
    {
        private readonly GOflyContext _context;

        public FeedbackManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task CreateFeedback(string userMail, string description)
        {
            var _user = _context.Users.FirstOrDefault(u => u.Email == userMail);

            var feedback = new Feedback 
            { User = _user,
              Description = description };

            _context.Feedbacks.Add(feedback);

            await _context.SaveChangesAsync();
        }

        public async Task<IList<Feedback>> GetAll() => await _context.Feedbacks.ToListAsync();
    }
}
