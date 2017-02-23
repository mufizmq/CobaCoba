using System;

namespace Coba_Coba
{
    class Program
    {
        static void LuasLingkaran() //bareng Faruq dan Roziq
        {
            //Ini merupakan mencari luas lingkaran
            const double phi = 3.14;
            double jari_jari;
            double luas;
            Console.Write("Masukkan jari-jari lingkaran : ");
            jari_jari = Convert.ToDouble(Console.ReadLine()); //untuk membaca input dari pengguna dan merubahnya menjadi Double
            luas = phi * jari_jari * jari_jari;
            Console.WriteLine(luas);

            Console.ReadKey();
        }

        static void NilaiRata()
        {
            //Program nilai rata
            int x, N, k, jumlah;
            double nilai_rata;

            Console.Write("Masukkan jumlah sampel : ");
            N = Convert.ToInt32(Console.ReadLine());
            k = 1;
            jumlah = 0;
            while (k <= N)
            {
                Console.Write("Masukkan X : ");
                x = Convert.ToInt16(Console.ReadLine());
                jumlah = jumlah + x;
                k = k + 1;
            }

            nilai_rata = jumlah / N;
            Console.WriteLine("Nilai rata-ratanya adalah : {0}", nilai_rata);
        }

        static void utamaBlas()
        {
            Console.WriteLine("WELCOME TO THE XETO WORLDS");
        }
        
        static void HitungSegiTiga() //bareng Hasan
        {
            //definisi variabel
            double luas, alas, tinggi;
           
            //deskripsi
            Console.WriteLine("-----PROGRAM SEGITIGA GAJE-----");
            Console.Write("masukkan alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan tinggi =  ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            luas = (alas * tinggi) / 2;
            Console.WriteLine(luas + "cm");

            Console.ReadKey();
        }
        
        static void DatabasePengguna() //coba-coba di MRP
        {
            int Nomor_pegawai;
            string Nama, TgLahir, Tempat_Lahir, Jen_kelamin, Agama, Status, Pangkat, jawab;

            Console.WriteLine("----SELAMAT DATANG DI APLIKASI DATABASE PEGAWAI----");
            Console.WriteLine("--------------BY XETO CREATIVE STUDIO--------------\n");

            Console.Write("Silahkan masukkan nomor pegawai anda : ");
            Nomor_pegawai = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nSilahkan masukkan nama anda : ");
            Nama = Console.ReadLine();

            Console.Write("\nSilahkan masukkan Tanggal Lahir anda : ");
            TgLahir = Console.ReadLine();

            Console.Write("\nSilahkan masukkan Tempat Lahir anda : ");
            Tempat_Lahir = Console.ReadLine();

            Console.Write("\nSilahkan masukkan Jenis Kelamin anda : ");
            Jen_kelamin = Console.ReadLine();

            Console.Write("\nSilahkan masukkan Agama anda : ");
            Agama = Console.ReadLine();

            Console.Write("\nSilahkan masukkan Status anda : ");
            Status = Console.ReadLine();

            Console.Write("\nSilahkan masukkan Pangkat anda : ");
            Pangkat = Console.ReadLine();

            Console.Write("\nApakah anda ingin menampilkan data anda (Y/N) : ");
            jawab = Console.ReadLine();
            if (jawab == "Y")
            {
                Console.WriteLine(Nomor_pegawai);
                Console.WriteLine(Nama);
                Console.WriteLine(TgLahir);
                Console.WriteLine(Tempat_Lahir);
                Console.WriteLine(Jen_kelamin);
                Console.WriteLine(Agama);
                Console.WriteLine(Status);
                Console.WriteLine(Pangkat);
                Console.Write("\nTerima Kasih telah menggunakan aplikasi kami \nXeto Creative Studio");
                Console.ReadLine();
            }
            else if (jawab == "N")
            {
                Console.Write("\nTerima Kasih telah menggunakan aplikasi kami \nXeto Creative Studio");
            }

            Console.ReadKey();
        }

        static void CtoF() //di MRP version 2
        {
            double C, F;
            Console.Write("Masukkan suhu dalam Celcius : ");
            C = Convert.ToDouble(Console.ReadLine());
            F = 1.8 * C + 32;
            Console.Write("\nSuhu dalam Farenheit adalah : {0} sedangkan Celcius adalah {1}", F, C);
            Console.ReadKey();
        }

        static void MintaPengguna()
        {
            double nilai_tugas, nilai_UTS, nilai_UAS, nilai_final;

            Console.Write("Masukkan nilai tugas (maksimal 100) : ");
            nilai_tugas = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMasukkan nilai UTS (maksimal 100) : ");
            nilai_UTS = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMasukkan nilai UAS (maksimal 100) : ");
            nilai_UAS = Convert.ToDouble(Console.ReadLine());

            nilai_final = (nilai_tugas * 0.2) + (nilai_UTS * 0.3) + (nilai_UAS * 0.5);

            Console.WriteLine("\nNilai final anda adalah : {0}", nilai_final);

            Console.ReadKey();
        }

        static void Main()
        {
            Program.ifthen();
            Console.ReadKey();
        }

        static void LuasSegitiga()
        {
            double T, S1, S2, S3, luas;

            Console.Write("masukkan sisi satu = ");
            S1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan sisi dua = ");
            S2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan sisi tiga = ");
            S3 = Convert.ToDouble(Console.ReadLine());

            T = (S1 + S2 + S3) / 2;

            luas = Math.Sqrt(T * (T - S1) * (T - S2) * (T - S3));

            Console.WriteLine("Jadi, luas segitiga adalah {0}", luas);

            Console.ReadKey();
        }
        
        static void DaftarMenu() //Hasan Made
        {   
            double pembelian, burger, pizza, kentang_goreng, soft_drink, milkshake, air_mineral, bu, pi, ke, so, mi, ai, total;

            burger = 5000;
            pizza = 4500;
            kentang_goreng = 3000;
            soft_drink = 2500;
            milkshake = 4000;
            air_mineral = 1500;

            Console.Write("Jumlah Burger = ");
            bu = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah Pizza = ");
            pi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah Kentang Goreng = ");
            ke = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah Softdrink = ");
            so = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah Milkshake = ");
            mi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah Air Mineral = ");
            ai = Convert.ToDouble(Console.ReadLine());

            pembelian = (bu * burger) + (pi * pizza) + (ke * kentang_goreng) + (so * soft_drink) + (mi * milkshake) + (ai * air_mineral);
            total = pembelian + (pembelian * 0.1);

            Console.WriteLine("Jadi Total Harga Pesanan = {0}", total);

            Console.ReadKey();
        }
        
        static void DaftarHarga()
        {
            double burger = 5000;
            double pizza = 4500;
            double kentang = 3000;
            double soft_drink = 2500;
            double milkShake = 4000;
            double air_mineral = 1500;
            double pembelian;

            int jmlBurger, jmlPizza, jmlKentang, jmlSoftDrink, jmlMikShake, jmlAir;

            string jawabanUser;

            Console.WriteLine("SELAMAT DATANG DI PROGRAM DAFTAR "+
                              "\n   HARGA MAKANAN DAN MINUMAN");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("=======DAFTAR HARGA=======");
            Console.WriteLine("Burger          Rp. 5000,-");
            Console.WriteLine("Pizza Slice     Rp. 4500,-");
            Console.WriteLine("Kentang Goreng  Rp. 3000,-");
            Console.WriteLine("Soft Drink      Rp. 2500,-");
            Console.WriteLine("Milkshake       Rp. 4000,-");
            Console.WriteLine("Air Mineral     Rp. 1500,-");

            Console.Write("\nSetelah melihat harga, Apakah anda akan melakukan pembelian ? (Y/N) : ");
            jawabanUser = Console.ReadLine();
            jawabanUser = null; //membuat jawaban user kembali bernilai NULL

            if (jawabanUser == "Y")
            {
                jawabanUser = null; //membuat jawaban user kembali bernilai NULL
                Console.Write("\nPesan BURGER berapa banyak ? : ");
                jmlBurger = Convert.ToInt16(Console.ReadLine());
                Console.Write("\nPesan PIZZA SLICE berapa banyak ? : ");
                jmlPizza = Convert.ToInt16(Console.ReadLine());
                Console.Write("\nPesan KENTANG GOREN berapa banyak ? : ");
                jmlKentang = Convert.ToInt16(Console.ReadLine());
                Console.Write("\nPesan SOFT DRINK berapa banyak ? : ");
                jmlSoftDrink = Convert.ToInt16(Console.ReadLine());
                Console.Write("\nPesan MILKSHAKE berapa banyak ? : ");
                jmlMikShake = Convert.ToInt16(Console.ReadLine());
                Console.Write("\nPesan AIR MINERAL berapa banyak ? : ");
                jmlAir = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\nRINCIAN PEMBELIAN : ");
                Console.WriteLine("--------------------");
                Console.WriteLine("Burger          x {0} = Rp. {1}", jmlBurger, jmlBurger * burger);
                Console.WriteLine("Pizza Slice     x {0} = Rp. {1}", jmlPizza, jmlPizza * pizza);
                Console.WriteLine("Kentang Goreng  x {0} = Rp. {1}", jmlKentang, jmlKentang * kentang);
                Console.WriteLine("Soft Drink      x {0} = Rp. {1}", jmlSoftDrink, jmlSoftDrink * soft_drink);
                Console.WriteLine("Milkshake       x {0} = Rp. {1}", jmlMikShake, jmlMikShake * milkShake);
                Console.WriteLine("Air Mineral     x {0} = Rp. {1}", jmlAir, jmlAir * air_mineral);
                Console.WriteLine("----------------------------------------");
                pembelian = (jmlBurger * burger) +
                            (jmlPizza * pizza) +
                            (jmlKentang * kentang) +
                            (jmlSoftDrink * soft_drink) +
                            (jmlMikShake * milkShake) +
                            (jmlAir * air_mineral);
                Console.WriteLine("Total Pembelian              = Rp. {0}", pembelian);
                Console.WriteLine("Total Pembelian + PPN (10 %) = Rp. {0}", pembelian + (pembelian * 0.1));

                Console.WriteLine("\n\nTerima kasih telah menggunakan aplikasi kami");
                Console.WriteLine("------------XETO CREATIVE STUDIO------------");

                Console.Write("\n\n\nApakah anda ingin melakukan perhitungan kembali ? (Y/N) : ");
                jawabanUser = null; //membuat jawaban user kembali bernilai NULL
                jawabanUser = Console.ReadLine();

                if (jawabanUser == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("SELAMAT DATANG DI PROGRAM DAFTAR " +
                                      "\n   HARGA MAKANAN DAN MINUMAN");
                    Console.WriteLine("--------------------------------\n");
                    Console.WriteLine("=======DAFTAR HARGA=======");
                    Console.WriteLine("Burger          Rp. 5000,-");
                    Console.WriteLine("Pizza Slice     Rp. 4500,-");
                    Console.WriteLine("Kentang Goreng  Rp. 3000,-");
                    Console.WriteLine("Soft Drink      Rp. 2500,-");
                    Console.WriteLine("Milkshake       Rp. 4000,-");
                    Console.WriteLine("Air Mineral     Rp. 1500,-");

                    Console.Write("\nSetelah melihat harga, Apakah anda akan melakukan pembelian ? (Y/N) : ");
                    jawabanUser = Console.ReadLine();

                    Console.Write("\nPesan BURGER berapa banyak ? : ");
                    jmlBurger = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nPesan PIZZA SLICE berapa banyak ? : ");
                    jmlPizza = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nPesan KENTANG GOREN berapa banyak ? : ");
                    jmlKentang = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nPesan SOFT DRINK berapa banyak ? : ");
                    jmlSoftDrink = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nPesan MILKSHAKE berapa banyak ? : ");
                    jmlMikShake = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nPesan AIR MINERAL berapa banyak ? : ");
                    jmlAir = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("\nRINCIAN PEMBELIAN : ");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Burger          x {0} = Rp. {1}", jmlBurger, jmlBurger * burger);
                    Console.WriteLine("Pizza Slice     x {0} = Rp. {1}", jmlPizza, jmlPizza * pizza);
                    Console.WriteLine("Kentang Goreng  x {0} = Rp. {1}", jmlKentang, jmlKentang * kentang);
                    Console.WriteLine("Soft Drink      x {0} = Rp. {1}", jmlSoftDrink, jmlSoftDrink * soft_drink);
                    Console.WriteLine("Milkshake       x {0} = Rp. {1}", jmlMikShake, jmlMikShake * milkShake);
                    Console.WriteLine("Air Mineral     x {0} = Rp. {1}", jmlAir, jmlAir * air_mineral);
                    Console.WriteLine("----------------------------------------");
                    pembelian = (jmlBurger * burger) +
                                (jmlPizza * pizza) +
                                (jmlKentang * kentang) +
                                (jmlSoftDrink * soft_drink) +
                                (jmlMikShake * milkShake) +
                                (jmlAir * air_mineral);
                    Console.WriteLine("Total Pembelian              = Rp. {0}", pembelian);
                    Console.WriteLine("Total Pembelian + PPN (10 %) = Rp. {0}", pembelian + (pembelian * 0.1));

                    Console.WriteLine("\n\nTerima kasih telah menggunakan aplikasi kami");
                    Console.WriteLine("------------XETO CREATIVE STUDIO------------");
                }
                else if (jawabanUser == "N")
                {
                    jawabanUser = null; //membuat jawaban user kembali bernilai NULL
                    Console.Clear();
                    Console.WriteLine("\n\nTerima kasih telah menggunakan aplikasi kami");
                    Console.WriteLine("------------XETO CREATIVE STUDIO------------");
                }
                else
                {
                    jawabanUser = null; //membuat jawaban user kembali bernilai NULL
                    Console.Beep();
                    Console.Clear();                    
                    Console.WriteLine("Ups! JAWABAN YANG ANDA MASUKKAN SALAH KISANAK!!");
                }
            }
            else if (jawabanUser == "N")
            {
                jawabanUser = null; //membuat jawaban user kembali bernilai NULL
                Console.WriteLine("\n\nTerima kasih telah menggunakan aplikasi kami");
                Console.WriteLine("------------XETO CREATIVE STUDIO------------");
            }
            else
            {
                jawabanUser = null; //membuat jawaban user kembali bernilai NULL
                Console.Beep();
                Console.Clear();                
                Console.WriteLine("Ups! JAWABAN YANG ANDA MASUKKAN SALAH KISANAK!!");
            }
        }

        static void AngkaTerbesar2()
        {
            int angka1, angka2;

            Console.Write("Masukkan angka yang pertama : ");
            angka1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan angka yang kedua : ");
            angka2 = Convert.ToInt16(Console.ReadLine());

            if (angka1 > angka2)
            {
                Console.WriteLine("Angka terbesar dari {0} dan {1} adalah {2}", angka1, angka2, angka1);
            }
            else
                Console.WriteLine("Angka terbesar dari {0} dan {1} adalah {2}", angka1, angka2, angka2);
        }

        static void AngkaTerbesarN()
        {
            int N, maks, indeks;

            //Menginisiasi N sampel sebagai jumlah array angka
            Console.Write("Masukkan jumlah sampel : ");
            N = Convert.ToInt16(Console.ReadLine());

            int[] angka = new int[N];

            //Memasukkan anggota himpunan angka
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Masukkan angka ke-{0} : ", i);
                angka[i] = Convert.ToInt16(Console.ReadLine()); //something missing
            }

            //Anggaplah maks adalah angka pertama
            maks = angka[1];
            indeks = 1;

            //bandingkan maks dengan setiap angka dalam himpunan
            while (indeks <N)
            {
                indeks += 1;
                if (angka[indeks] > maks)
                    maks = angka[indeks];
            }

            Console.WriteLine("Angka terbesar adalah {0}", maks);
        }

        static void contoh1()
        {
            double harga, pajak, total;

            Console.Write("Masukkan harga barang : ");
            harga = Convert.ToDouble(Console.ReadLine());

            pajak = 0.125 * harga;
            total = harga + pajak;

            Console.WriteLine("Harga : {0} dan Pajaknya : {1}", harga, pajak);
            Console.WriteLine("Total : {0}", total);
        }

        static void contoh2()
        {
            string nama, alamat, email, telepon;

            Console.Write("Masukkan nama anda : ");
            nama = Console.ReadLine();
            Console.Write("Di mana alamatnya : ");
            alamat = Console.ReadLine();
            Console.Write("No telepon : ");
            telepon = Console.ReadLine();
            Console.Write("Alamat email :");
            email = Console.ReadLine();

            //menampilkan output
            Console.WriteLine(nama);
            Console.WriteLine(alamat + "/" + telepon);
            Console.WriteLine(email);
        }

        static void contoh3()
        {
            string nama, alamat, email;
            string telepon;

            Console.Write("Masukkan nama anda : ");
            nama = Console.ReadLine();
            Console.Write("Di mana alamatnya : ");
            alamat = Console.ReadLine();
            Console.Write("No telepon : ");
            telepon = Console.ReadLine();
            Console.Write("Alamat email : ");
            email = Console.ReadLine();

            //menampilkan output 
            Console.WriteLine(nama);
            Console.WriteLine(alamat);
            Console.WriteLine(telepon);
            Console.WriteLine(email); 
        }

        static void ifthen()
        {
            string jawaban;

            Console.Write("Apakah anda suka makan ? (Y/N): ");
            jawaban = Console.ReadLine();
            if (jawaban == "Y")
            {
                Console.WriteLine("Raimu senengane badok ae!");
            }
            else if (jawaban == "N")
            {
                Console.WriteLine("Gak uwoong!");
            }
            else
            {
                Console.WriteLine("Jawabanmu salah ndul!");
            }
        }

    }
}