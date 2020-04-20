using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFisika3122
{
    class Kecepatan
    {
        public void kec()
        {
            Console.Write("Masukkan nilai jarak (m) : ");
            int jarak = int.Parse(Console.ReadLine());
            Console.Write("Masukkan waktu (s) : ");
            int waktu = int.Parse(Console.ReadLine());

            double nilaiKecepatan = jarak / waktu;
            Console.WriteLine("Kecepatannya adalah (m/s): " + (nilaiKecepatan));
        }
    }
}
