using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFisika3122
{
    class EnergiPotensial
    {
        public void ep()
        {
            Console.Write("\tMasukkan nilai Massa (kg)  : ");
            float massa = float.Parse(Console.ReadLine());
            Console.Write("\tMasukkan percepatan gravitasi (m2) : ");
            float gravitasi = float.Parse(Console.ReadLine());
            Console.Write("\tMasukkan tinggi benda dari permuk tanah (m) : ");
            float tinggi = float.Parse(Console.ReadLine());

            double nilaiMjenis = massa * gravitasi * tinggi ;
            Console.WriteLine("\tmaka energi potensialnya adalah (j) : " + (nilaiMjenis));
        }

    }
}