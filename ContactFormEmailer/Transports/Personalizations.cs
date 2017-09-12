namespace ContactFormEmailer.Transports
{
    public class Personalizations
    {
        public EmailInfo[] To { get; set; }
        public string Subject { get; set; }

        public Personalizations()
        {
            To = new EmailInfo[] {};
        }
    }
}
