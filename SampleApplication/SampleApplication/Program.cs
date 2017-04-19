using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<string> messages = new List<string>();//
            //FieldInfo field = typeof(Constants).GetFields().FirstOrDefault(f => f.Name == "VALIDATION_CONCURRENCY");
            string strRev, strReal = null;
            Console.WriteLine("Enter the string..");
            strReal = Console.ReadLine();
            char[] tmpChar = strReal.ToCharArray();
            Array.Reverse(tmpChar);
            strRev = new string(tmpChar);
            if (strReal.Equals(strRev, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The string is pallindrome");
            }
            else
            {
                Console.WriteLine("The string is not pallindrome");
            }
            Console.ReadLine();
        }
    }
    public class Constants
    {
        static Constants()
        {

        }
        public const string VALIDATION_CONCURRENCY = "This project was been modified by another user, please reload and try again.";
        public const string VALIDATION_REQUIRED = "The field {0} is empty and must be completed.";

        public const string EMAIL_MESSAGE_STD = "Dear {0}, blahblah";
    }
}
