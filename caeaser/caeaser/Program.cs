using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caeaser
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ATTACKon   TITAN";
            int key = 3;
            Program ob = new Program();
            string x= ob.encription(txt,key);
            Console.WriteLine(x);
            Console.WriteLine("\n");
            string v = ob.decription(x,key);
            Console.WriteLine(v);
            Console.ReadKey();

        }
        string encription(string txt, int key)
        {
            string r = "";
            for (int i = 0; i < txt.Length; i++)
            {
               
                if (char.IsUpper(txt[i]))
                {
                    r = r + (char)((int)(txt[i] + key - 65)%26+65);
                }
                else
                {
                    r = r + (char)((int)(txt[i]+key-97)%26+97);
                }


            }
            return r;
        }
        string decription(string txt, int key)
        {
            string r = "";
            for (int i = 0; i < txt.Length; i++)
            {

                if (char.IsUpper(txt[i]))
                {
                    r = r + (char)((int)(txt[i] - key - 65) % 26 + 65);
                }
                else
                {
                    r = r + (char)((int)(txt[i] - key - 97) % 26 + 97);
                }


            }
            return r;
        }
    }
}
