using System;

namespace NetDelegatesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitterMessagingService = new TwitterMessagingService((msg) => !msg.Contains("facebook"),
                (config) =>
                {
                    config.Username = "Diego";
                    config.Password = "abc123";
                }
            );
            twitterMessagingService.MessageReceived += (sender, msg) => Console.WriteLine(msg);

        }
    }
}
