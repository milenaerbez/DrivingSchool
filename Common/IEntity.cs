using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IEntity 
    {

        int ID { get; set; }
        string TableName { get; set; }
        string TableNameJoin { get; set; }  
        string InsertedValues {get;  }
        string InsertedColumns { get; }
        string IdColumn { get; set; }

        
        List<IEntity> GetList(SqlDataReader reader);
        List<IEntity> GetList2(SqlDataReader reader);
    }
}
