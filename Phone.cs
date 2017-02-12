using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phonenumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string[] arr = Console.ReadLine().Split();

            while (!arr[0].Equals("done"))
            {
                string command = arr[0];
                string nameOrPhone = arr[1];
                string result = string.Empty;
                int sum = 0;
                int difference = 0;
                for (int i = 0; i < phonenumbers.Length; i++)
                {
                    if (phonenumbers[i].Equals(nameOrPhone))
                    {
                        result = phonenumbers[i];
                        sum = GetSum(phonenumbers[i]);
                        difference = GetDifference(phonenumbers[i]);
                        result = names[i];
                        break;
                    }
                }

                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Equals(nameOrPhone))
                    {
                        result = phonenumbers[i];
                        sum = GetSum(phonenumbers[i]);
                        difference = GetDifference(phonenumbers[i]);
                        break;
                    }
                }

                switch (command)
                {
                    case "call":
                        Console.WriteLine("calling {0}...", result);
                        int minutes = sum / 60;
                        int seconds = sum % 60;
                        string strToPrint = string.Format("{0:0#}:{1:0#}", minutes, seconds);
                        if (sum % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            Console.WriteLine("call ended. duration: {0}", strToPrint);
                        }
                        break;
                    case "message":
                        Console.WriteLine("sending sms to {0}...", result);
                        if (difference % 2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }
                        break;
                }

                arr = Console.ReadLine().Split();
            }
        }

        static int GetSum(string phonenumbers)
        {
            int sum = 0;
            char[] ch = phonenumbers.ToCharArray();

            for (int j = 0; j < ch.Length; j++)
            {
                if ((ch[j] >= 48) && (ch[j] <= 57))
                {
                    sum += ch[j] - 48;
                }
            }

            return sum;
        }

        static int GetDifference(string phonenumbers)
        {
            int difference = 0;
            char[] ch = phonenumbers.ToCharArray();

            for (int j = 0; j < ch.Length; j++)
            {
                if ((ch[j] >= 48) && (ch[j] <= 57))
                {
                    difference -= ch[j] - 48;
                }
            }

            return difference;
        }
    }
}

