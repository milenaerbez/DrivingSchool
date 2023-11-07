using Common;
using Repository.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        public void Add(IEntity entity)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"insert into {entity.TableName} {entity.InsertedColumns} output inserted.{entity.IdColumn} values ({entity.InsertedValues})");
            int id = (int)cmd.ExecuteScalar();
            entity.ID = id;
        }

        public void Close()
        {
           DbConnectionFactory.Instance.GetDbConnection().Close();  
        }

        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Delete(IEntity entity)
        {
            SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"Delete from {entity.TableName} where ID={entity.ID} ");
            command.ExecuteNonQuery();

        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"select * from {entity.TableNameJoin}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetList(reader);
            reader.Close();



            return result;
        }

        public void RollBack()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();

        }

        public List<IEntity> Search(IEntity entity, string condition)
        {
            List<IEntity> result;
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"select * from {entity.TableNameJoin} where {condition}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetList(reader);
            reader.Close();
        
          

            return result;

        }
        public List<IEntity> Pretrazi(IEntity entity, string condition)
        {
            List<IEntity> result;
          
             SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"select * from {entity.TableName} where {condition}");
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetList(reader);
            reader.Close();
            return result;

        }

        public    void Update(IEntity entity, string setValues)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"update {entity.TableName} set {setValues} where {entity.IdColumn}= {entity.ID}");
            cmd.ExecuteNonQuery();
        }
    }
}
