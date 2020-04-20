using System;

namespace RumusFisika3122
{
    class Program
    {
        static void Main(string[] args)
        {
            MassaJenis yanga = new MassaJenis();
            Tekanan yangb = new Tekanan();
            GayaBerat yangc = new GayaBerat();
            Kecepatan yangd = new Kecepatan();
            EnergiPotensial yange = new EnergiPotensial();

            Console.WriteLine("PROGRAM KALKULATOR FISIKA !\n");
            Console.WriteLine("a. Menghitung Massa Jenis");
            Console.WriteLine("b. Menghitung Tekanan");
            Console.WriteLine("c. Menghitung Gaya berat");
            Console.WriteLine("d. Menghitung Kecepatan");
            Console.WriteLine("e. Menghitung Energi Potensial\n");
            Console.WriteLine("Mau pilih yang mana ? : ");
            char pilih = char.Parse(Console.ReadLine());


            if (pilih == 'a')
            {
                Console.WriteLine();
                yanga.mj();
            }
            if (pilih == 'b')
            {
                Console.WriteLine();
                yangb.tek();
            }
            if (pilih == 'c')
            {
                Console.WriteLine();
                yangc.gb();
            }
            if (pilih == 'd')
            {
                Console.WriteLine();
                yangd.kec();
            }
            if (pilih == 'e')
            {
                Console.WriteLine();
                yange.ep();
            }
            Console.WriteLine("\nProgram Selesai - Terima Kasih");
        }
    }
}
        
