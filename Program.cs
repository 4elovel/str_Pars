using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str_Pars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Впишіть рядок:");
            string str = Console.ReadLine();
            int flag = 0;
            int start=0, end=0;
            //index;id;text;author_id;created_at;newest_id;oldest_id;result_count;next_token;geo
            //0;1375081017007083525; @telegram @apple @GooglePlay;875607916480311296;;;;;;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ';')
                {
                    if (flag == 3)
                    {
                        end = i;
                        Console.WriteLine("Author_id: ");
                        Console.Write(str.Substring(start, end - start));
                        break;
                    }
                    flag++;
                    if (flag == 3)
                    {
                        start = i + 1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
