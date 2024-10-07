using Microsoft.VisualBasic;
using molnar_horgos_kristofTriatlon;
using System.Text;

List<Versenyzo> versenyzok = [];

using StreamReader sr = new(path: @"..\..\..\bin\forras.txt", encoding: Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream)
{
    versenyzok.Add(new(sr.ReadLine()!));
}

Console.WriteLine($"1. feladat: versenyző fejezte be a versenyt szama: {versenyzok.Count}");

var lnCnt = versenyzok.Count(v => v.csoport == "elit");
Console.WriteLine($"Elit versenyzők száma: {lnCnt} db");


var lnnoi = versenyzok.Where(v => v.neme == "n");
var lnnoiavg = lnnoi.Average(v => v.szulev);
Console.WriteLine($"Női versenyzők versenyzők átlag életkora: {DateTime.Now.Year - lnnoiavg:00}");

var lnkerekpar = TimeSpan.FromSeconds(versenyzok.Sum(v => v.kerekpar.TotalSeconds));
Console.WriteLine($"A versenyzők kerékpározással töltött összideje órában: {lnkerekpar.TotalHours:00}");


var lnelit = versenyzok.Where(v => v.csoport == "elit junior");
var lnelitavg = TimeSpan.FromSeconds(lnelit.Average(v => v.uszas.TotalSeconds));

Console.WriteLine($"Az átlagos úszással eltöltött idő az elit junior kategóriában: {lnelitavg}");

var lnferfi = versenyzok.Where(v => v.neme == "f");
var lnferfigyoztes = lnferfi.MinBy(v => v.kerekpar.TotalSeconds + v.futas.TotalSeconds + v.uszas.TotalSeconds + v.elsodepo.TotalSeconds + v.masodikdepo.TotalSeconds);

Console.WriteLine($"A férfi győztes: {lnferfigyoztes.nev}");

//var linqByCsoport = versenyzok.GroupBy(v => v.csoport);
//var linqOrderByCsoport = linqByCsoport.Count(v => v.);

//foreach (var group in linqByCsoport)
//{

//    Console.WriteLine($"\t{group.Key}");
//}