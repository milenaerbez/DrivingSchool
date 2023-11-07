using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }


        public int ID { get; set; }
        public string TableName { get; set; } = "Korisnik";
        public string TableNameJoin { get; set; } = "Korisnik";
        public string InsertedValues { get; set; }

        public string InsertedColumns { get; }

        public string IDColumn {get;}

        string IEntity.IdColumn { get; set; }

        List<IEntity> IEntity.GetList(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Korisnik k = new Korisnik();
                k.ID = reader.GetInt32(0);
                k.Ime = reader.GetString(1);
                k.Prezime = reader.GetString(2);
                k.KorisnickoIme = reader.GetString(3);
                k.Lozinka = reader.GetString(4);
                result.Add(k);
              
            }
            return result;
        }

        public override string ToString()
        {
            return KorisnickoIme;
        }
        List<IEntity> IEntity.GetList2(SqlDataReader reader)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
