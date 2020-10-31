using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class BaseString
    {
        string str;
        int strLength;

        public double getForLength()
        {
            var str = Console.ReadLine();
            return int.Parse(str);
        }
        public double getNum()
        {
            var str = Console.ReadLine();
            return double.Parse(str);
        }
        public BaseString()
        {

        }

        public BaseString(string str)
        {
            this.str = str;
            strLength = str.Length;
        }
        public int GetLength()
        {
            return strLength;
        }
        public string ClearString()
        {
            str = null;
            return str;
        }
    }
    class OctString : BaseString
    {
        string strOct;
        string checkSum = "01234567";

        public OctString (string str)
        {
            strOct = str;
            CompareString();
        }

        public CompareString()
        {
            for (int i = 0; i < strOct.Length; i++)
            {
                if (!(checkSum.Contains(strOct[i])))
                {
                    strOct = null;
                    break;
                }
            }

        int Translate()
            {
                return Convert.ToInt32(strOct, 8);
            };
        }
    }

    class Program
    {
        public static void Main(string[] args)
        { 
            OctString snova = new OctString();
            tyt = Console.WriteLine("Введите длину строки: ");
            int strOct = int.Parse(Console.ReadLine());
            int enterNumber;
            while (!int.TryParse(compares, out ofchtoto))
            {
                Console.WriteLine("Введено не число.");
                numbs = EnterNumber();
            }
            Console.WriteLine(strOct);
            Console.ReadKey();
        }
        }

}
