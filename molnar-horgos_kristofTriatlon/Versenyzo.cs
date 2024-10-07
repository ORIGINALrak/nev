using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace molnar_horgos_kristofTriatlon
{
    internal class Versenyzo
    {
            public string nev { get; set; }
            public int szulev { get; set; }
            public int rajtszam { get; set; }
            public string neme { get; set; }
            public string csoport { get; set; }
            public TimeSpan uszas { get; set; }
            public TimeSpan elsodepo { get; set; }
            public TimeSpan kerekpar { get; set; }
            public TimeSpan masodikdepo { get; set; }
            public TimeSpan futas { get; set; }

        public Versenyzo(string row)
        {
            var sor = row.Split(';');
            nev = (sor[0]);
            szulev = int.Parse(sor[1]);
            rajtszam = int.Parse(sor[2]);
            neme = (sor[3]);
            csoport = sor[4];
            uszas = TimeSpan.Parse(sor[5]);
            elsodepo = TimeSpan.Parse(sor[6]);
            kerekpar = TimeSpan.Parse(sor[7]);
            masodikdepo = TimeSpan.Parse(sor[8]);
            futas = TimeSpan.Parse(sor[9]);

        }
        //public override string ToString()
        //{
        //    return $"{nev} ({szulev} évben született {rajtszam} rajtszama {(neme ? "n" : "m")} {csoport} csoportja {uszas} {elsodepo} {kerekpar}{masodikdepo}{futas})";
        //}
    }
}
