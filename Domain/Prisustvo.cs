using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Prisustvo : IEntity
    {
        public int ID { get; set; } 

        public Grupa Grupa { get; set; }
        public Termin Termin { get; set; }
        public Kandidat Kandidat { get; set; }
        public bool Status { get; set; }

        [Browsable(false)]
        public string TableName { get; set; } = "Prisustvo";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Prisustvo";
        [Browsable(false)]

        public string InsertedValues => $"{Grupa.ID},{Termin.ID},{Kandidat.ID},{(Status ? 1:0)}";
        [Browsable(false)]

        public string InsertedColumns => "(Grupa,Termin,Kandidat,Status)";
        [Browsable(false)]
        public string IdColumn { get; set; } = "ID";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> prisustva = new List<IEntity>();
            while (reader.Read())
            {
                Prisustvo prisustvo = new Prisustvo();
                prisustvo.ID = reader.GetInt32(0);
                Grupa g = new Grupa();
                g.ID = reader.GetInt32(1);
                prisustvo.Grupa = g;
                Termin t = new Termin();
                t.ID = reader.GetInt32(2);
                prisustvo.Termin = t;
                Kandidat k = new Kandidat();
                k.ID = reader.GetInt32(3);
                prisustvo.Kandidat= k;
                prisustva.Add(prisustvo);

            }
            return prisustva;
           
        }
        List<IEntity> IEntity.GetList2(SqlDataReader reader)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
