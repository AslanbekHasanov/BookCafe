using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCafe.Service
{
    public class Menu
    {

        public string[,] listBooks =
        {
            {"O'tgan kunlar", "40000","Abdullo Qodiriy","utgan asr haqida"},
            {"Ufq", "60000","Said Ahmat","Urush haqida"},
            {"Dunyoning ishlari", "30000","O'tkir Xoshimov","Dunyoning g'aroyib ishlari"}
        };



        public void IsDeleteInfo(string book_name)
        {
            bool isfound = false;
            for (int i = 0; i < listBooks.Length / 4; i++)
            {
                for (int j = 0; j < 4; j += 3)
                {
                    if (listBooks[i, j] == book_name)
                    {
                        isfound = true;
                        //code delete
                        listBooks[i, j] = null;
                        listBooks[i, (j + 1)] = null;
                        listBooks[i, (j + 2)] = null;
                        listBooks[i, (j + 3)] = null;


                    }

                }

            }
            if (isfound == false)
            {
                Console.WriteLine("Not Found");

            }

        }
        public void GetAllInfo()
        {
            
            for (int i = 0; i < listBooks.Length / 4; i++)
            {
                int count = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (listBooks[i, j] != null )
                    {
                        Console.Write(listBooks[i, j] + "  ");

                    }
                    else
                    {
                        count++;
                    }

                }
                if (count != 4)
                {
                    Console.WriteLine();                

                }
                

            }

        }

        public void ClearAllInfo()
        {
            if (listBooks != null)
            {
                for (int i = 0; i < listBooks.Length / 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        listBooks[i, j] = null;


                    }

                }

            }
            else
            {
                Console.WriteLine("Baza mavjud emas");
            }


        }

    }
}
