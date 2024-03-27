using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Ember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public string Nemzetiseg { get; set; }
        public string Foglalkozas { get; set; }
        public string ErdeklodesiKor { get; set; }

        public Ember()
        {
        }

        public Ember(string sor)
        {
            string[] t=sor.Split(';');
            Nev = t[0];
            Eletkor =Convert.ToInt32(t[1]);
            Nemzetiseg = t[2];
            Foglalkozas = t[3];
            ErdeklodesiKor = t[4];
        }
        public override string? ToString()
        {
            return $"{Nev},{Eletkor},{Nemzetiseg},{Foglalkozas},{ErdeklodesiKor}";
        }
    }
}