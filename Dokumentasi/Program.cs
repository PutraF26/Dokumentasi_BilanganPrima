using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumentasi_bilangan_prima
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class mian dapat menentukan bilangan prima dan bilangan bukan prima</remarks>
    class Program
    {
        /// <summary>
        /// menentuka bilangan prima
        /// </summary>
        /// <param name="args">menggunakan array</param>
        /// <param name="angka">angka yang di masukan untuk menentukan bilangan prtima</param>
        /// <param name="i">increment karena biasanya berisi increment operasi seperti i++ , yang sama dengan i = i+1,dalam setiap perulangan naikkan variabel sebanyak 1 angka </param>
        /// <param name="x">angka % i </param>
        static void Main(string[] args)
        {
            int angka;
            int i, x;
            Console.WriteLine("Program Sederhana Bilangan Prima");
            Console.Write("Masukkan Angka =");
            angka = int.Parse(Console.ReadLine());
            if (angka == 1)
            {
                Console.WriteLine("Bukan Bilangan Prima");
            }
            else if (angka == 2)
            {
                Console.WriteLine("Bilangan Prima");
            }

            else
            {
                for (i = 2; i < angka; i++)
                {
                    x = angka % i;

                    if (x == 0)
                    {
                        Console.WriteLine("Bukan Bilangan Prima");

                        Console.Read();
                    }
                }
                Console.WriteLine("Bilangan Prima");
            }
            Console.ReadKey();
        }
    }
}