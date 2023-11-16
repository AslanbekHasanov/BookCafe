 using BookCafe.Service;

Menu menu = new Menu();


Console.WriteLine("======= Welcome our to the book cafe =======");
Console.WriteLine("1.View all books");
Console.WriteLine("2.This book discreption");
Console.WriteLine("3.Delete one book information");
Console.WriteLine("4.Add single book information");
Console.WriteLine("5.Sell one book");
Console.WriteLine("6.List of sold books");
belgi:
Console.Write("Enter command: ");
int command = int.Parse(Console.ReadLine());

if (command == 1)
{
    menu.GetAllInfo();

}
if (command == 4)
{
    Console.Write("Enter book name: ");
    string bookName = Console.ReadLine();
    Console.Write("Enter book price: ");
    string bookPrice = Console.ReadLine();
    Console.Write("Enter book author: ");
    string bookAuthor = Console.ReadLine();
    Console.Write("Enter book discreption: ");
    string bookDiscreption = Console.ReadLine();

    menu.AddOneBook(bookName, bookPrice, bookAuthor, bookDiscreption);
}
if (command == 5)
{
    Console.Write("Enter book name:");
    string name = Console.ReadLine();
    menu.SellBook(name);
    
}
if (command == 6)
{
    menu.AllSellBook();

}

Console.WriteLine("============================");
goto belgi;
