using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> tagallamok = new List<string[]>();

            using (StreamReader sr = new StreamReader("EUcsatlakozas.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] tomb = sor.Split(';');
                    tagallamok.Add(tomb);
                }
            }
            DateTime alap = new DateTime(1900, 01, 01);

            for (int i = 0; i < tagallamok.Count; i++)
            {
                int ev = Int32.Parse(tagallamok[i][1].Substring(0, 4));
                int ev = Int32.Parse(tagallamok[i][1].Substring(0, 4));
            }                      

            Console.ReadKey(true);
        }
    }
}
