using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;

namespace Models.Repositories
{

    interface IRepository<T>
    {
        bool Add(T t);
        bool Update(T t);
        bool Delete(T t);
        List<T> GetAll();
        T Get(T t);
        List<T> FilterBy(string condicion);
    }

}