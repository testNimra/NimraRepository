using Newtonsoft.Json;
using OpenPop.Pop3;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Net.Imap4;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Fyp_Arshi.Helper_Functions
{
    public static class HelperFunction
    {
        public static string AccessToken = string.Empty;

        public static string GetEmailAuthenticationCode(string username, string password)
        {
            using (Pop3Client client = new Pop3Client())
            {
                // Connect to the server
                client.Connect("pop.gmail.com", 995, true);

                // Authenticate ourselves towards the server
                client.Authenticate(username, password, AuthenticationMethod.UsernameAndPassword);

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // We want to download all messages
                List<string> allMessages = new List<string>(messageCount);

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number

                var message = client.GetMessage(messageCount);
                var body = message.FindFirstHtmlVersion().GetBodyAsText();
                var authenticationCode = Regex.Match(body, @"\d+").Value;

                return authenticationCode;

            }
        }

        private static Imap4Client client;
       
       

        public static string GetEmailAuthenticationCode2(string username, string password)
        {
            client = new Imap4Client();
            client.Connect("imap.gmail.com", 993, true);

            client.SendAuthUserPass(username, password, Imap4Client.AuthTypes.Plain);
            var folders = client.ListFolders();
            client.SelectFolder("Inbox");
            //var currentFolder = client.CurrentFolder;
            var emailCount = client.GetEmailCount();
            //var unreadEmails = client.UnreadEmails; 
            //uint availableType = client.AvailableEmails;
            var message = client.GetEmail(emailCount);
            var body = message.Body;
            var authenticationCode = Regex.Match(body, @"\d+").Value;
            client.Disconnect();

            return authenticationCode;
        }


    }
}
