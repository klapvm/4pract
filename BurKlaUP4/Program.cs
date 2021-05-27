using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace BurKlaUP4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 5, 'd', 2, 'D', 64, 's', 'D', 21, 13, 'K', 'g', 'q', 22, 'A' };
            ArrayList list1 = new ArrayList();
            string a = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (Char.IsNumber(list[i].ToString().ToCharArray()[0]) == false)
                {
                    if (Char.IsUpper(list[i].ToString().ToCharArray()[0]))
                    {
                        list1.Add(list[i]);
                    }
                    list.RemoveAt(i);
                    i--;
                }
                else
                {
                    a += list[i] + "  ";
                }
            }
            Console.WriteLine(a);
            a = "";
            for (int i = 0; i < list1.Count; i++)
            {
                a += list1[i] + "  ";
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
