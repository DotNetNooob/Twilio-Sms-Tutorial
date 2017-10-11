using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Twilio_Sms_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your Account SID from twilio.com/console
            var accountSid = "AC66c6ae920b1c0db9acfe2cbf945f607a";
            // Your Auth Token from twilio.com/console
            var authToken = "64434993502cc71a95f188516ffc544f";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber("+923458638040"),
                from: new PhoneNumber("+1 208-314-3389 "),
                body: "Hello from C#");

            Console.WriteLine(message.Sid);
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
