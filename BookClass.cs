using System;
using System.Security.Cryptography.X509Certificates;

public class Book
{
    public string Title { get;}
    public int Pages {  get; }
    public int CurrentPage { get; } = 1;

    public Book(string title, int pages)
	{
        Title = title;
        Pages = pages;


	}

    public void TurnPage(int pagesToTurn = 1)
    {
        int currentPage = CurrentPage;
        
        for (int i = 0; i < pagesToTurn; i++)
        {
            if (currentPage < Pages)
            {
                currentPage++;
                Console.WriteLine(currentPage);
            }
            else
            {
                Console.WriteLine("The book is finished.");
                break;
            }
        }

       
    }




	
}
