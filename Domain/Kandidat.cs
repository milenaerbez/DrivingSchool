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
    public class Kandidat : IEntity
    {
        public override string ToString()
        {
            return Ime;
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojLicneKarte { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public Grupa Grupa { get; set; }
       

        [Browsable(false)]
        public int ID { get; set; }
        [Browsable(false)]
        public string TableName { get; set; } = "Kandidat";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Kandidat k join Grupa g on k.GrupaID=g.ID";
        [Browsable(false)]
        public string InsertedValues => $" '{Ime}', '{Prezime}', '{DatumRodjenja}', '{BrojLicneKarte}', {Grupa.ID} ";
        [Browsable(false)]
        public string InsertedColumns => "(Ime, Prezime, DatumRodjenja, BrLicneKarte, GrupaID)";

        // public string IDColumn { get; }
        [Browsable(false)]
        string IEntity.IdColumn { get; set; } = "ID";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> rezultat = new List<IEntity>();
            while (reader.Read())
            {
                Kandidat k = new Kandidat();
                k.ID = reader.GetInt32(0);
                k.Ime = reader.GetString(1);
                k.Prezime = reader.GetString(2);
                k.DatumRodjenja = reader.GetDateTime(3);
                k.BrojLicneKarte = reader.GetString(4);
                if (!reader.IsDBNull(5))
                {
                    Grupa g = new Grupa();
                    g.ID = reader.GetInt32(5);
                    g.DatumPocetka = reader.GetDateTime(7);
                    k.Grupa = g;
                }
                else
                {
                    k.Grupa = null; 
                }
                rezultat.Add(k);
            }
            return rezultat;
        }

        public List<IEntity> GetList2(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
