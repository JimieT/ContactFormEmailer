using Newtonsoft.Json;

namespace ContactFormEmailer.Web.Transports
{
    public class SendGridRequest
    {
        public Personalizations[] Personalizations { get; set; }
        public EmailInfo From { get; set; }

        [JsonProperty(PropertyName = "Reply_to")]
        public EmailInfo ReplyTo { get; set; }

        public string Subject { get; set; }
        public Content[] Content { get; set; }

        public SendGridRequest()
        {
            Personalizations = new Personalizations[] {};
            From = new EmailInfo();
            ReplyTo = new EmailInfo();
            Content = new Content[] {};
        }
    }
}
