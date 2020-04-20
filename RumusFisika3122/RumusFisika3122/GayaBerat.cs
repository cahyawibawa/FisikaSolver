using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFisika3122
{
    class GayaBerat
    {
        public void gb()
        {
            Console.Write("Masukkan nilai massa (kg) : ");
            int massa = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai gravitasi (m3) : ");
            int gravitasi = int.Parse(Console.ReadLine());

            double nilaiGberat = massa * gravitasi;
            Console.WriteLine("Beratnya adalah adalah (n): " + (nilaiGberat));
        }

    }
}