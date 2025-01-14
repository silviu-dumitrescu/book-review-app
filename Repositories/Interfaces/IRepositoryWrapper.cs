namespace mybookapp.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAuthorRepository AuthorRepository { get; }

        void Save();
    }
}
