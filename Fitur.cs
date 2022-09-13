using System;
using System.Collections.Generic;
using System.Threading;

namespace Aplikasi_Data_Pegawai
{
    //Inheritance

    public class Fitur : Abstract
    {
        //Encapsulation
        private static int pilihan;

        public int getpilihan()
        {
            pilihan = Convert.ToInt32(Console.ReadLine());
            return pilihan;
        }

        public int Hitunggaji(int c)
        {
            if (masakerja[c] > 12) { gajibulanan[c] = gajipokok[c] * 2; }
            else { gajibulanan[c] = gajipokok[c]; }
            return gajibulanan[c];
        }

        //polymorph : overload
        public void DisplayPegawai(List<string> pegawai, List<string> nik, List<int> masakerjapegawai, List<string> posisi, List<int> gaji, int a)
        {
            Hitunggaji(a);
            Console.WriteLine("ID [" + (a + 1) + "]");
            Console.WriteLine("Nama Pegawai: " + pegawai[a]);
            Console.WriteLine("Nik: " + nik[a]);
            Console.WriteLine("Masa Kerja: " + masakerjapegawai[a] + "bulan");
            Console.WriteLine("Jabatan: " + posisi[a]);
            Console.WriteLine("Gaji: " + "Rp. " + gaji[a]);
            Console.WriteLine(" ");
            Console.WriteLine("=======================================================");
            Console.WriteLine(" ");
        }

        //Polymorph
        public void DisplayPegawai(List<string> pegawai, List<string> nik, List<int> masakerjapegawai, List<string> posisi, List<int> gaji)
        {
            Console.Clear();
            Console.WriteLine("Daftar Pegawai");
            Console.WriteLine(" ");
            int b = pegawai.Count;
            for (int a = 0; a < b; a++)
            {
                Hitunggaji(a);
                Console.WriteLine("ID [" + (a + 1) + "]");
                Console.WriteLine("Nama Pegawai: " + pegawai[a]);
                Console.WriteLine("Nik: " + nik[a]);
                Console.WriteLine("Masa Kerja: " + masakerjapegawai[a] + "bulan");
                Console.WriteLine("Jabatan: " + posisi[a]);
                Console.WriteLine("Gaji: " + "Rp. " + gaji[a]);
                Console.WriteLine(" ");
                Console.WriteLine("=======================================================");
                Console.WriteLine(" ");
            }
        }
        public void HapusPegawai()
        {
            Console.Clear();
            Console.WriteLine("Hapus Pegawai");
            Console.WriteLine(" ");
            int b = pegawai.Count;
            for (int a = 0; a < b; a++)
            {
                Console.WriteLine("ID [" + (a + 1) + "] " + pegawai[a]);
            }
            Console.Write("No Pegawai : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= pegawai.Count && pegawai.Count != 0)
            {
                Console.WriteLine("Apakah yakin menghapus ID [" + input + "] ");
                DisplayPegawai(pegawai, nik, masakerja, jabatan, gajibulanan, input - 1);
                Console.Write("Y / N? ");
                string konfirmasi = Console.ReadLine();
                if (konfirmasi == "y" || konfirmasi == "y")
                {
                    Console.WriteLine("Apakah yakin menghapus ID [" + input + "] = ");
                    DisplayPegawai(pegawai, nik, masakerja, jabatan, gajibulanan, input - 1);
                    Console.Write("Y / N? ");
                    string Konfirmasi = Console.ReadLine();
                    if (konfirmasi == "y" || konfirmasi == "y")
                    {
                        pegawai.RemoveAt(input - 1);
                        nik.RemoveAt(input - 1);
                        masakerja.RemoveAt(input - 1);
                        jabatan.RemoveAt(input - 1);
                        gajibulanan.RemoveAt(input - 1);
                        gajipokok.RemoveAt(input - 1);
                        Console.WriteLine("Data Pegawai berhasil dihapus!");
                    }
                }
                else
                {
                    Console.WriteLine("ID tidak ditemukan!");
                    Thread.Sleep(1000);
                }
                Console.ReadKey();
            }

            public void JumlahPegawai()
            {
                Console.Clear();
                Console.WriteLine("JUMLAH PEGAWAI");
                Console.WriteLine(" ");
                int jumlah = pegawai.Count;
                Console.WriteLine("Jumlah Pegawai + jumlah + orang");
            }

            public static void Tambahpegawai()
            {
                Console.Clear();
                Console.WriteLine("TAMBAH Pegawai");
                Console.WriteLine(" ");
                Console.Write("Nama Pegawai : ");
                string inputpegawai = Console.ReadLine();
                pegawai.Add(inputpegawai);
                Console.Write("Nama Pegawai : ");
                string inputnik = Console.ReadLine();
                nik.Add(inputnik);
                Console.Write("Masa kerja (bulan): ");
                int inputmasakerja = Convert.ToInt32(Console.ReadLine());
                masakerja.Add(inputmasakerja);
                Console.Write("Jabatan : ");
                string inputjabatan = Console.ReadLine();
                jabatan.Add(inputjabatan);
                Console.Write("Gaji : ");
                int inputgaji = Convert.ToInt32(Console.ReadLine());
                gaji.Add(inputgaji);
                
            }

            public void Halamanutama()
            {
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine(" ");
                Console.WriteLine("Aplikasi Data Pegawai");
                Console.WriteLine("PT. Jaya");
                Console.WriteLine(" ");
                Console.WriteLine("=======================================================");
                Console.WriteLine(" ");
                Console.WriteLine("Silahkan pilih salah satu fitur: ");
                Console.WriteLine("1. Menampilkan data ");
                Console.WriteLine("2. Menghapus data pegawai");
                Console.WriteLine("3. Menampilkan jumlah pegawai");
                Console.WriteLine("4. Menambah pegawai");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("Pilihan anda : ");
            }
        }
    }