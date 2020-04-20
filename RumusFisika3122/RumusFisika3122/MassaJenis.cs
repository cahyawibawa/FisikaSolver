using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFisika3122
{
    class MassaJenis
    { 
   public void mj()
    {
        Console.Write("\tMasukkan nilai Massa (kg)  : ");
        float massa = int.Parse(Console.ReadLine());
        Console.Write("\tMasukkan Volume (m3) : ");
        float vol = int.Parse(Console.ReadLine());

        double nilaiMjenis = massa / vol;
        Console.WriteLine("\tBesarnya Massa Jenis adalah : " + (nilaiMjenis));
    }

}
}