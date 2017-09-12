using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using ContactFormEmailer.Transports;
using ContactFormEmailer.Web.Helpers.Serializers;
using ContactFormEmailer.Web.Models;
using RestSharp;

namespace ContactFormEmailer.Web.Helpers
{
    public class EmailSender : IEmailSender
    {
        private static readonly string SendGridApiKey = ConfigurationManager.AppSettings["SendGridAPIKey"];
        private static readonly string SentFromEmailAddress = ConfigurationManager.AppSettings["SentFromEmailAddress"];
        private static readonly string SentFromName = ConfigurationManager.AppSettings["SentFromName"];
        private static readonly string SendToEmailAddress = ConfigurationManager.AppSettings["SendToEmailAddress"];
        private static readonly string EmailSubject = ConfigurationManager.AppSettings["EmailSubject"];
        private IRestClient _restClient;

        public IRestClient RestClient
        {
            get { return _restClient ?? (_restClient = new RestClient { FollowRedirects = false }); }
            set { _restClient = value; }
        }

        public EmailSender()
        {
            RestClient.BaseUrl = new Uri(ConfigurationManager.AppSettings["SendGridURI"]);
        }

        public void Send(dynamic contactInfo)
        {
            var request = new RestRequest
            {
                Resource = "/mail/send",
                Method = Method.POST,
                RequestFormat = DataFormat.Json,
                JsonSerializer = new JsonNetSerializer()
            };
            request.AddHeader("Authorization", $"Bearer {SendGridApiKey}");
            var sendGridRequest = GenerateSendGridRequest(contactInfo);
            request.AddBody(sendGridRequest);
            var response = RestClient.Execute(request);
        }

        private static SendGridRequest GenerateSendGridRequest(dynamic contactInfo)
        {
            var sendGridRequest = new SendGridRequest
            {
                Content = new[]
                {
                    new Content
                    {
                        Type = "text/html",
                        Value = "<html>" +
                                "<p>The following was entered through WIRELESSWAVE.ca website:<p>" +
                                "<p>Name: " + contactInfo.Name + "</p>" +
                                "<p>City: " + contactInfo.City + "</p>" +
                                "<p>Reason for Message: " + contactInfo.ReasonForMessage + "</p>" +
                                "<p>Mobile Number: " + contactInfo.MobileNumber + "</p>" +
                                "<p>Email Address: " + contactInfo.EmailAddress + "</p>" +
                                "<p>Message: " + Regex.Replace(contactInfo.Message, @"\r\n?|\n", "<br />") + "</p>" +
                                "</html>"
                    }
                },
                From = new EmailInfo
                {
                    Email = SentFromEmailAddress,
                    Name = SentFromName
                },
                Personalizations = new[] {
                    new Personalizations
                    {
                        To = new[]
                        {
                            new EmailInfo
                            {
                                Email = SendToEmailAddress
                            }
                        },
                        Subject = EmailSubject
                    },
                },
                ReplyTo = new EmailInfo()
                {
                    Email = SentFromEmailAddress
                },
                Subject = EmailSubject
            };
            return sendGridRequest;
        }
    }
}