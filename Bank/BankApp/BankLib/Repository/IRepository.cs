using BankLib.Model;
using System.Collections.Generic;

namespace BankLib.Repository
{
    public interface IRepository<T> where T : class
    {
        bool Add(T obj);
        List<T> Get();
        bool Update(T obj);
        bool Delete(T obj);
        void Commit();
        T GetByName(string uName);
    }
}
