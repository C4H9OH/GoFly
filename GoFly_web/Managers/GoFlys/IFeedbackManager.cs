using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IFeedbackManager
    {
        Task<IList<Feedback>> GetAll();

        Task CreateFeedback(string userMail, string description );
    }
}
