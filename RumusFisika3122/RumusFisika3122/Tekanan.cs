using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFisika3122
{
    class Tekanan
    {
        public void tek()
        {
            Console.Write("Masukkan nilai Gaya (n) : ");
            int gaya = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Luas Penampang (m2) : ");
            int luas = int.Parse(Console.ReadLine());

            double nilaiTekanan = gaya / luas;
            Console.WriteLine("Besarnya Tekanan adalah : " + (nilaiTekanan));
        }
    }
}

