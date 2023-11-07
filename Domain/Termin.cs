using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Termin : IEntity
    {
        public override string ToString()
        {
            return Vreme.ToString();
        }

        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public Grupa Grupa { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Vreme { get; set; }
        public string TematskaJedinica { get; set; }
        [Browsable(false)]
        public string TableName { get; set; } = "Termin";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Termin";
        [Browsable(false)]
        public string InsertedValues => $"{Grupa.ID},'{Datum}','{Vreme}','{TematskaJedinica}'";
        [Browsable(false)]
        public string InsertedColumns => "(GrupaID, Datum, VremeOd, TematskaJedinica)";

        string IEntity.IdColumn { get; set; } = "ID";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> Result = new List<IEntity>();
            while (reader.Read())
            {
                Termin t = new Termin();
                t.ID = reader.GetInt32(0);
                Grupa g=new Grupa();
                g.ID = reader.GetInt32(1);
                t.Grupa = g;
                t.Datum = reader.GetDateTime(2);
                t.Vreme = reader.GetTimeSpan(3);
                t.TematskaJedinica = reader.GetString(4);
                Result.Add(t);
                
            }
            return Result;
        }

        List<IEntity> IEntity.GetList2(SqlDataReader reader)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
