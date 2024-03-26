using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cscipher
    {
        public void Cipher()
        {
            string k = Program.n;
            int namount = k.Length;
            int namount1 = 0;
            var aramount = new char[namount];

            for (int i = 0; i < aramount.Length; i++)
            {
                if (k[i] == 'z')
                {
                    namount1 = k.IndexOf("z");
                    Console.Write("{0}", k.Substring('a'));
                }
                aramount[i] = Convert.ToChar(k[i] + 3);
            }
            Console.WriteLine(new string(aramount));

            /*string k = Program.n;
            int lenghtMoving = 3;
            k = string.Format("{0}{1}", k.Substring(k.Length - lenghtMoving),
                k.Substring(0, k.Length - lenghtMoving));
            Console.WriteLine(k);*/
        }
    }
}
