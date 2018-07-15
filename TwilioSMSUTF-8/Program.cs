﻿// Get the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace YourNewConsoleApp
{
    class Example
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "AC117596442d700a77b3708ddcdeeeb989";
            const string authToken = "fb44c72c89e6c48afe326951b5f1520f";
            TwilioClient.Init(accountSid, authToken);

            Console.WriteLine("\nGet ready to send a text! ");

            Console.WriteLine("\nEnter your reciepient ");
            var rec = Console.ReadLine();

            Console.WriteLine("\nEnter your message? ");
            var text = Console.ReadLine();

            var to = new PhoneNumber(rec);
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("+17192496515"),
                body: text);

            Console.WriteLine(message.Sid);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}