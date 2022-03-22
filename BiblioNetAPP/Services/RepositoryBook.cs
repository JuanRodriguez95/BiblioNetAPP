using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{

    public interface IRepositoryBook
    {
        public void Create(Book book);
    }
    public class RepositoryBook : IRepositoryBook
    {
        private readonly string connectionString;

        public RepositoryBook(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(Book book)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO Books (BookName,Author,Price) VALUES (@BookName,@Author,@Price); SELECT SCOPE_IDENTITY();", book);
            book.Id = id;
        }
    }
}
