using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";


            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.WriteLine("Pilih menu Aplikasi\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection

            Console.WriteLine("Tambah Data Customer\n");

            Customer customer = new Customer();

            Console.Write("Kode Customer:\t");
            customer.KodeCustomer=Console.ReadLine();

            Console.Write("Nama Customer:\t");
            customer.NamaCustomer = Console.ReadLine();

            Console.Write("Total Piutang:\t");
            customer.Piutang = Convert.ToDouble(Console.ReadLine());

            daftarCustomer.Add(customer);            

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection

            Console.WriteLine("Hapus Data Customer");

            Console.Write("\nKode Customer: ");

            string hapus = Console.ReadLine();

            if (daftarCustomer.Any(list1 => list1.KodeCustomer == hapus))
            {
                daftarCustomer.RemoveAll(list2 => list2.KodeCustomer == hapus);

                Console.WriteLine("\nData Customer berhasil dihapus\n");
            }
            else
            {
                Console.WriteLine("\nKode Customer tidak ditemukan\n");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection

            Console.WriteLine("Data Customer\n");

            int show = 1;

            foreach (Customer customer in daftarCustomer)
            {

                Console.WriteLine("{0}. {1}, {2}, {3}", show, customer.KodeCustomer, customer.NamaCustomer, customer.Piutang);
            
                show++;
            
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
