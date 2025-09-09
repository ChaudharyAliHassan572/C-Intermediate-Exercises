using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C__Intermediate_Exercises.Exercises
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage...");
        }
    }

    public class CallEncodingService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling third-party encoding service...");
        }
    }

    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to video owner...");
        }
    }

    public class UpdateStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Updating video status to 'Processing' in database...");
        }
    }
}
