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
        private readonly string _sendGridApiKey = ConfigurationManager.AppSettings["SendGridAPIKey"];
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

        public void Send(string sentFromEmailAddress, string sendToEmailAddress, string subject, ContactUsInfo contactInfo)
        {
            var request = new RestRequest
            {
                Resource = "/mail/send",
                Method = Method.POST,
                RequestFormat = DataFormat.Json,
                JsonSerializer = new JsonNetSerializer()
            };
            request.AddHeader("Authorization", $"Bearer {_sendGridApiKey}");
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
                    Email = "do-not-reply@wirelesswave.ca",
                    Name = "WIRELESSWAVE.ca"
                },
                Personalizations = new[] {
                    new Personalizations
                    {
                        To = new[]
                        {
                            new EmailInfo
                            {
                                Email = sendToEmailAddress
                            }
                        },
                        Subject = subject
                    },
                },
                ReplyTo = new EmailInfo()
                {
                    Email = "do-not-reply@wirelesswave.ca"
                },
                Subject = subject
            };

            request.AddBody(sendGridRequest);
            var response = RestClient.Execute(request);
        }
    }
}