using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithma
{
    class Program
    {
        //int, digunakan untuk menyatakan suatu bilangan bulat, positif maupun negatif
        //Array yang akan dicari
        int[] arr = new int[20];
        //Jumlah elemen dalam array
        int n;
        //Dapatkan jumlah elemen untuk disimpan dalam array
        int i;

        /*mengimput sebuah array
        *Kata kunci public adalah pengubah akses untuk jenis dan anggota jenis.
        *Akses publik merupakan tingkat akses yang paling permisif.
        *Tidak ada batasan untuk mengakses anggota publik*/
        public void input()
        {
            while (true)
            {
                /*Fungsi WriteLine() akan menampilkan teks dalam satu baris atau baris baru, 
                 * sedangkan Write() tidak akan membuat baris baru.*/
                Console.Write("Masukkan jumlah elemen dalam array: ");
                //string adalah objek yang nilainya berupa teks.
                //Fungsi ReadLine() akan membaca teks yang kita ketik dalam satu baris (teks).
                string s = Console.ReadLine();
                /* int.parse adalah metode yang mengubah representasi 
                 * string menjadi nilai integer numerik yang sesuai.*/
                n = Int32.Parse(s);
                //membatasi nilai integer
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray harus memiliki minimal 1 dan maksimal 20 elemen.\n");
            }
            //Terima elemen array
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Memasukkan elemen array ");
            Console.WriteLine("----------------------");
            /*membaca input dari pengguna dan menyimpannya ke dalam 
             * sebuah array yang berisi bilangan bulat (integer).*/
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            /* Deklarasi char ch digunakan untuk membuat sebuah variabel 
             * dengan tipe data karakter yang bernama ch. Variabel ini dapat 
             * digunakan untuk menyimpan atau memproses sebuah karakter dalam program.*/
            char ch;
            do
            {
                //menerima nomor yang akan dicari
                Console.Write("\nMasukkan elemen yang ingin Anda cari : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //menerapkan pencarian biner
                int lowerbound = 0;
                int upperbound = n - 1;

                //mendapatkan indeks elemen tengah
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop untuk mencari elemen dalam array
                while ((item != arr[mid]) && (lowerbound < upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                //To string digunakan untuk mengonversi objek menjadi string. 
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " ditemukan pada posisi " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " tidak ditemukan dalam larik\n");
                Console.WriteLine("\nJumlah perbandingan : " + ctr);
                Console.Write("\nLanjutkan pencarian (y/n):");
                // char.Parse digunakan untuk mengonversi string dengan panjang satu menjadi karakter tunggal yang sesuai.
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            //mencari jumlah perbandingan
            int ctr;
            do
            {
                //menerima nomor yang akan dicari
                Console.Write("\nMasukkan elemen yang ingin Anda cari: ");
                // convert.ToInt32 digunakan untuk mengonversi tipe data numerik atau string menjadi tipe data integer 32-bit.
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " ditemukan pada posisi " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " tidak ditemukan dalam larik");
                Console.WriteLine("\nJumlah perbandingan : " + ctr);
                /*untuk melanjutkan pencarian atau tidak dengan membaca input 
                 * dari pengguna menggunakan*/
                Console.Write("\nLanjutkan pencarian (y/n):");
                ch = char.Parse(Console.ReadLine());
            } /*Jika input yang diberikan oleh pengguna bukan 'y' atau 'Y', 
               * maka loop akan berhenti dan program akan selesai.*/
            while ((ch == 'y') || (ch == 'Y'));
        }
        /*static void Main(string[] args) merupakan titik awal eksekusi 
         * program dan akan dieksekusi pertama kali ketika program dijalankan.*/
        static void Main(string[] args)
        {
            /* sebuah objek untuk mengakses seluruh 
             * method, property, dan variabel yang ada dalam class tersebut.*/
            Program myList = new Program();
            /*program yang digunakn untuk memilih antara dua jenis
             *pencarian (Linear Search dan Binary Search) atau keluar dari program.*/
            int pilihanmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("===================");
                Console.WriteLine("1.Linear Search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());
                //switch digunakan untuk memilih aksi yang akan dilakukan berdasarkan nilai dari sebuah variabel atau ekspresi.
                switch (pilihanmenu)
                {
                    /*case digunakan pada struktur kontrol switch pada bahasa pemrograman 
                     * untuk menentukan aksi yang akan dieksekusi berdasarkan nilai dari variabel atau ekspresi.*/
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("....................");
                        Console.WriteLine("Linear Search");
                        Console.WriteLine("....................");
                        myList.input();
                        myList.LinearSearch();
                        //untuk menghentikan eksekusi dari sebuah loop atau struktur kontrol seperti switch-case.
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("....................");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("....................");
                        myList.input();
                        myList.BinarySearch();
                        break;
                    case 3:

                        Console.WriteLine("exit.");
                        break;
                    /*digunakan untuk menentukan aksi yang akan dieksekusi jika tidak ada case yang cocok
                     * dengan nilai dari variabel atau ekspresi yang dievaluasi pada switch.*/
                    default:
                        Console.WriteLine("error");
                        break;

                }
                // untuk keluar dari konsol
                Console.WriteLine("\n\nPress Return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
