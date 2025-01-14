using mybookapp.Models;

namespace mybookapp.Services.Interfaces
{
    public interface IAuthorService
    {
        void Create(Author author);
        Author? Get(int? id);
        void Update(Author author);
        void Delete(Author author);
        IQueryable<Author> GetAll();
    }
}
