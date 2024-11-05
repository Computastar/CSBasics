using System;

public class Book
{
    public string Title { get; set; }
    public int Pages {  get; set; }
    public int CurrentPage { get; set; } = 1;

    public Book(string title, int pages)
	{
        Title = title;
        Pages = pages;


	}

    public void TurnPage(int pagesToTurn = 1)
    {
        for (int i = 0; i < pagesToTurn; i++)
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
                Console.WriteLine(CurrentPage);
            }
            else
            {
                Console.WriteLine("The book is finished.");
                break;
            }
        }

       
    }




	
}
