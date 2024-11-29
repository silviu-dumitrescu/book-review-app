using mybookapp.Models;
using mybookapp.Repositories.Interfaces;

namespace mybookapp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MyBookAppContext _dbContext;
        private IAuthorRepository? _authorRepository;

        public IAuthorRepository AuthorRepository
        {
            get
            {
                if (_authorRepository == null)
                {
                    _authorRepository = new AuthorRepository(_dbContext);
                }

                return _authorRepository;
            }
        }

        public RepositoryWrapper(MyBookAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
