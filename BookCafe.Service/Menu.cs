using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCafe.Service
{
    public class Menu
    {

        private decimal priceSum;

        public bool isAdded = false;
        
        public string[,] listBooks = 
        {
            {"O'tgan kunlar", "40000","Abdullo Qodiriy","utgan asr haqida"},
            {"Ufq", "60000","Said Ahmat","Urush haqida"},
            {"Dunyoning ishlari", "30000","O'tkir Xoshimov","Dunyoning g'aroyib ishlari"},
        };
        public string[,] bookList = new string[4, 4];


        public void AllSellBook()
        {
            Console.WriteLine($"Money: {this.priceSum}");
        }

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
            if (isAdded == false)
            {
                for (int i = 0; i < listBooks.Length / 4; i++)
                {
                    int count = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        if (listBooks[i, j] != null)
                        {
                            Console.WriteLine(listBooks[i, j]);

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
            else
            {

                for (int i = 0; i < bookList.Length / 4; i++)
                {
                    int count = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        if (bookList[i, j] != null)
                        {
                            Console.WriteLine(bookList[i, j]);

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

        public void AddOneBook
            (
             string book_name, 
             string book_price, 
             string author, 
             string discraption
            )
        {
            bool isfound = false;
            for (int i = 0; i < listBooks.Length / 4; i++)
            {
                for (int j = 0; j < 4; j += 3)
                {
                    //
                    if (listBooks[i, j] == book_name)
                    {
                        isfound = true;
                        Console.WriteLine("Bu kitob bazada bor");

                    }

                }

            }
            if (isfound == false)
            {
                isAdded = true;
                for (int i = 0; i < listBooks.Length / 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        bookList[i, j] = listBooks[i, j];

                    }

                }

                bookList[3, 0] = book_name;
                bookList[3, 1] = book_price;
                bookList[3, 2] = author;
                bookList[3, 3] = discraption;

                Console.WriteLine("Bazaga ma'lumot qushildi");

            }


        }
        //Topshiriq
        public void OneUpdateBook()
        {


        }

        


        public void SellBook(string book_name)
        {
            bool res = false;
            for (int i = 0; i < listBooks.Length / 4; i++)
            {
                for (int j = 0; j < 4; j+=3)
                {
                    if (listBooks[i, j].ToLower() == book_name.ToLower())
                    {
                        res = true;
                        priceSum += Convert.ToDecimal(listBooks[i, j + 1]);


                    }

                }

            }

            if (res == false)
            {
                Console.WriteLine("Not Found");

            }


        }






    }
}
