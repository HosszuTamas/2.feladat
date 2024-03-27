using ClassLibrary.Data;
using ClassLibrary.Models;
using System;

namespace Konzol
{
    static public class Program
    {
        static void KiIr(IEnumerable<object> adatok)
        {
            foreach (var item in adatok)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
             Kontext db = new Kontext();

            if (!db.Emberek.Any())
            {
                var sorok = File.ReadAllLines(@"c:\users\diak\downloads\4.csv").Skip(1);
                foreach (var line in sorok)
                    db.Emberek.Add(new Emberek(line));
                db.SaveChanges();
            }
        }
