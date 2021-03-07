using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Dao
{
    interface IDao<T>
    {
        int insert(T obj);
    }
}
