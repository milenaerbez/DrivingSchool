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
    public class Grupa : IEntity
    {
        public int ID { get; set; }
        public DateTime DatumPocetka { get; set; }
        public string Kategorija { get; set; }
        public Korisnik Predavac { get; set; }

        public List<Termin> Termini=new List<Termin>();

        [Browsable(false)]
        public string TableName { get; set; } = "Grupa";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Grupa g join Korisnik k on g.Predavac=k.ID";
        [Browsable(false)]
        public string InsertedValues => $" '{DatumPocetka}', '{Kategorija}', {Predavac.ID}  ";
        [Browsable(false)]
        public string InsertedColumns => " (DatumPolaska, Kategorija, Predavac)";

        string IEntity.IdColumn { get; set; } = "ID";

        public override string ToString()
        {
            return ID.ToString();
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> rezultat = new List<IEntity>();
            while (reader.Read())
            {
                Grupa gr = new Grupa();
                gr.ID = reader.GetInt32(0);
                gr.DatumPocetka = reader.GetDateTime(1);
                gr.Kategorija = reader.GetString(2);
                Korisnik k = new Korisnik();
                k.ID=reader.GetInt32(3);
                k.KorisnickoIme = reader.GetString(7);
                gr.Predavac = k;
                rezultat.Add(gr);
            }
            return rezultat;
        }
        List<IEntity> IEntity.GetList2(SqlDataReader reader)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
