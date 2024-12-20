using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Classes
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public int Quantity { get; set; }

        public Book(int bookId, string title, string author, string iSBN, string genre, int publicationYear, int quantity)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            ISBN = iSBN;
            Genre = genre;
            PublicationYear = publicationYear;
            Quantity = quantity;
        }
    }

    public class manageBooks
    {
       public bool AddBook(Book book)
        {
            string query = "INSERT into tbl_book(title,author,isbn,genre,publication_year,quantity) values(@title,@author,@isbn,@genre,@publicationyear,@quantity)";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@title", book.Title);
                    cmd.Parameters.AddWithValue("@author", book.Author);
                    cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                    cmd.Parameters.AddWithValue("@genre", book.Genre);
                    cmd.Parameters.AddWithValue("@publicationyear", book.PublicationYear);
                    cmd.Parameters.AddWithValue("@quantity", book.Quantity);
                    int checkrow = cmd.ExecuteNonQuery();
                    return checkrow > 0;
                }
            }
        }

        public bool UpdateBook(Book book)
        {
            string query = "UPDATE tbl_book SET title = @title, author = @author, isbn = @isbn, genre = @genre, publication_year = @publicationyear, quantity = @quantity WHERE book_id = @bookid";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@bookid", book.BookId);
                    cmd.Parameters.AddWithValue("@title", book.Title);
                    cmd.Parameters.AddWithValue("@author", book.Author);
                    cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                    cmd.Parameters.AddWithValue("@genre", book.Genre);
                    cmd.Parameters.AddWithValue("@publicationyear", book.PublicationYear);
                    cmd.Parameters.AddWithValue("@quantity", book.Quantity);
                    int checkrow = cmd.ExecuteNonQuery();
                    return checkrow > 0;
                }
            }
        }
    }
}
