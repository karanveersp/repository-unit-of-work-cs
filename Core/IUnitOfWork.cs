using System.Threading.Tasks;
using PocketBook.Core.IRepository;

namespace PocketBook.Core
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task CompleteAsync();
    }
}