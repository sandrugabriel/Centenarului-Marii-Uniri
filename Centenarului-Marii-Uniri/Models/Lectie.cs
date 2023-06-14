using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centenarului_Marii_Uniri.Models
{
    internal class Lectie
    {

        private int id;
        private int idUtilizator;
        private string titlu;
        private string regiune;
        private DateTime dataCreare;
        private string numeImagine;

        public Lectie(int id, int idUtilizator, string titlu, string regiune, DateTime dataCreare, string numeImagine)
        {
            this.id = id;
            this.idUtilizator = idUtilizator;
            this.titlu = titlu;
            this.regiune = regiune;
            this.dataCreare = dataCreare;
            this.numeImagine = numeImagine;
        }

        public Lectie(string text)
        {

            string[] prop = text.Split('*');

            this.id = int.Parse(prop[0]);
            this.idUtilizator = int.Parse(prop[1]);
            this.titlu = prop[2];
            this.regiune = prop[3];
            this.dataCreare = DateTime.Parse(prop[4]);
            this.numeImagine = prop[5];

        }

        public int getId()
        {
            return id;
        }

        public int getIdUtilizator()
        {
            return idUtilizator;
        }

        public string getTitlu()
        {
            return titlu;
        }

        public string getRegiune()
        {
            return regiune;
        }

        public DateTime getDataCreare()
        {
            return dataCreare;
        }

        public string getNumeImagine()
        {
            return numeImagine;
        }

    }
}
