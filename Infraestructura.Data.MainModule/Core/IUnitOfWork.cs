namespace Infraestructura.Data.MainModule.Core
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void SaveChanges();
    }
}
