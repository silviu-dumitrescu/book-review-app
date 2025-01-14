using mybookapp.Models;
using mybookapp.Repositories.Interfaces;
using mybookapp.Services.Interfaces;

namespace mybookapp.Services
{
    public class AuthorService : IAuthorService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public AuthorService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void Create(Author author)
        {
            _repositoryWrapper.AuthorRepository.Create(author);
            _repositoryWrapper.Save();
        }

        public void Update(Author author)
        {
            _repositoryWrapper.AuthorRepository.Update(author);
            _repositoryWrapper.Save();
        }

        public Author? Get(int? id)
        {
            return _repositoryWrapper.AuthorRepository.FindByCondition(x => x.AuthorId == id).FirstOrDefault();
        }

        public void Delete(Author author)
        {
            _repositoryWrapper.AuthorRepository.Delete(author);
            _repositoryWrapper.Save();
        }

        public IQueryable<Author> GetAll()
        {
            return _repositoryWrapper.AuthorRepository.FindAll();
        }
    }
}
