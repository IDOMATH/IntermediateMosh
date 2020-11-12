namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly MailService _mailservice;

        public VideoEncoder()
        {
            _mailservice = new MailService();
        }
        public void Encode(Video video)
        {
            // Video encoding logic
            _mailservice.Send(new Mail());
        }
    }
}
