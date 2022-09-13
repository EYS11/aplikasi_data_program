using System;
using System.Threading;

namespace Aplikasi_Data_Pegawai
{
    //Inheritance
    class Program : Abstract
    {
        static void Main(string[] args)
        {
            bool ulang = true;
            while (ulang == true);
        {
        //Membuat object
        Fitur fitur = new Fitur();
        fitur.Halamanutama();
            int pilihan = fitur.getpilihan();
            switch (pilihan)
            {
            case 1:
            fitur.DisplayPegawai(pegawai, masakerja, jabatan, gajibulanan);
            break;
            
            case 2:
            fitur.HapusPegawai();
            break;
            
            case 3:
            fitur.JumlahPegawai();
            break;
            
            case 4: 
            fitur.TambahPegawai();
            break;
            
            case 5:
            ulang = false;
            Console.Clear();
            Console.WriteLine("Terima Kasih");
            Thread.Sleep(2000);
            break;
            default :
            Console.WriteLine("Pilihan Tidak Ada");
            Thread.Sleep(2000);
            break;
            }

            Console.ReadKey();
        }
    }
}
}