using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T GetLast();
        string GetToString(int id);
        void Create(T ent);
        void Update(int id, T ent);
        void Delete(int id);
        void SaveToJson(string filePath);
        void LoadFromJson(string filePath);
    }
}
