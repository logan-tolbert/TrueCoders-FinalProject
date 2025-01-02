using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGateway
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure = false);
        void SaveData<U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure = false);
    }
}
