using mybookapp.Models;
using mybookapp.Repositories.Interfaces;

namespace mybookapp.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(MyBookAppContext context)
            : base(context)
        {
        }
    }
}
