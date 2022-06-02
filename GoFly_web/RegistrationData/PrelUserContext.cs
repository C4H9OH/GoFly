namespace GoFly_web.RegistrationData
{
    public class PrelUserContext
    {
        public List<PrelUser> mailsAndGuids { get; set; }

        public PrelUserContext()
        {
            mailsAndGuids = new List<PrelUser>();
        }
    }
}
