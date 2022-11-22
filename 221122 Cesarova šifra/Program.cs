using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221122_Cesarova_šifra
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Encrypt("ahoj maki", 12);
            Console.WriteLine(s);
            Console.WriteLine(Decrypt(s, 12));
            Console.ReadLine();
        }

        static string Encrypt(string message, int key)
        {
            string encryptedMessage = "";
            int i = 0;
            foreach (char item in message)
            {
                if (!(item < 97 || item > 122))
                {
                    i = item + key;
                    if (i > 122)
                        i -= 26;
                    encryptedMessage += (char)i;
                }
            }

            return encryptedMessage;
        }

        static string Decrypt(string message, int key)
        {
            string decryptedMessage = "";
            int i = 0;
            foreach (char item in message)
            {
                if (!(item < 97 || item > 122))
                {
                    i = item - key;
                    if (i < 97)
                        i += 26;
                    decryptedMessage += (char)i;
                }
            }

            return decryptedMessage;
        }
    }
}
