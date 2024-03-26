using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static string n;    //cipher
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyexit;
            string cipher = "Input words for code.";
            string uncipher = "Input words for uncode.";

            var cscipher = new Cscipher();

            do
            {
                Console.WriteLine($"Press N to {cipher.Remove(cipher.Length-1)}, " +
                    $"M to {uncipher.Remove(22)} or " +
                    "press Escape to close.");
                keyexit = Console.ReadKey(true);
                if(keyexit.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine(cipher);
                    n = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(n);

                    cscipher.Cipher();  //cipher (cipher.cs)

                    //end of cipher
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Pressed wrong key, try again.");
                }

            } while (keyexit.Key != ConsoleKey.Escape);
        }
    }
}
