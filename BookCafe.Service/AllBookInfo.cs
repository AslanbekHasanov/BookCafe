using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCafe.Service
{
    public class AllBookInfo
    {
       
        public void SearchBook(string bookName)
        {
            Menu menu = new Menu();
            bool isThisBook = false;
            int i_value = 0, j_value = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < menu.listBooks.Length / 4; j+= 3)
                {
                    if (menu.listBooks[i, j].ToLower() == bookName.ToLower())
                    {
                        i_value = i;
                        j_value = j;
                        isThisBook = true;
                        
                    }
                }
                Console.WriteLine();

            }
            if (isThisBook == true)
            {

                Console.WriteLine("Name: " + menu.listBooks[i_value, j_value]);
                Console.WriteLine("Price: " + menu.listBooks[i_value, j_value + 1]);
                Console.WriteLine("Author: " + menu.listBooks[i_value, j_value + 2]);
                Console.WriteLine("Name: " + menu.listBooks[i_value, j_value + 3]);

            }
            else
            {
                Console.WriteLine("This is not book");
            }
        }

    }
}
