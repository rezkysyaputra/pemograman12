using System;
using System.Reflection;

namespace pemrog12
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi dan inisialisasi array 'arrNim' dengan tiga elemen bertipe int
            int[] arrNim = { 1234, 5678, 9101 };

            // Deklarasi dan inisialisasi array 'arrNilai' dengan tiga elemen bertipe int
            int[] arrNilai = { 30, 75, 90 };

            // Deklarasi dan inisialisasi array 'arrNama' dengan tiga elemen bertipe string
            string[] arrNama = { "Asep", "Budi", "Lape" };

            // Menampilkan header tabel
            Console.WriteLine("NO.      NIM     NAMA        NILAI");
            Console.WriteLine("==================================");

            // Loop untuk menampilkan data dalam tabel
            for (int i = 0; i < arrNama.Length; i++)
            {
                // Menampilkan data dalam format yang ditentukan
                Console.WriteLine("{0}.      {1}     {2}        {3}", i + 1, arrNim[i], arrNama[i], arrNilai[i]);
            }

            // Menunggu pengguna menekan tombol sebelum aplikasi berakhir
            Console.ReadKey();
        }
    }
}
