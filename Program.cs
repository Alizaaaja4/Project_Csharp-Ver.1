using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForceField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uname, pass; 
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("= = = = = = = = = = FORCE FIELD = = = = = = = = = =");
            Console.WriteLine("---------------------------------------------------\n");
            Console.Write("\t\t Username: "); uname = Console.ReadLine();
            Console.Write("\t\t Password: "); pass = Console.ReadLine();
            Console.WriteLine("\n---------------------------------------------------\n");

            if ( uname == "porce" && pass == "444")
            {
                Console.WriteLine("\t   Verifikasi sedang berlangsung"); Thread.Sleep(3000);
                Console.WriteLine("\t      Akses login diterima!!!\n"); Thread.Sleep(2000); menuUtama();
            }
            else
            {
                Console.WriteLine("\t   Verifikasi sedang berlangsung"); Thread.Sleep(3000);
                Console.WriteLine("\t      Akses login ditolak!!!\n"); Thread.Sleep(3000);
                Console.Clear();
                Main(args);
            }
        }

        static void menuUtama()
        {
            int jawab;
            Console.Clear();
            Console.WriteLine("================================================================");
            Console.WriteLine("- - - - - - - - - - - KALKULATOR FISIKA - - - - - - - - - - - -");
            Console.WriteLine("================================================================");
            Console.WriteLine("System: Haii.. kenalin nama aku Aliza dengan kode asisten ALL 😊");
            Console.WriteLine("        saya adalah asisten praktikum dari Daskom Laboratory.\n"); Thread.Sleep(2000);
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("System: Harapan saya program ini dalam membantu praktikan untuk");
            Console.WriteLine("        menghitung nilai nilai dengan sangat mudah :) "); Thread.Sleep(2000);
            Console.WriteLine("----------------------------------------------------------------\n\n");
            Console.WriteLine("\t   Program akan berjalan dalam 5 detik!!"); Thread.Sleep(5000); Console.Clear();

            Console.WriteLine("================================================================");
            Console.WriteLine("- - - - - - - - - - - KALKULATOR FISIKA - - - - - - - - - - - -");
            Console.WriteLine("================================================================");
            Console.WriteLine("= = [1]. Modul Semester Ganjil                               = =");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("= = [0]. Kembali                                             = =");
            Console.WriteLine("================================================================");
            Console.Write("\t\t Input /> "); jawab = Convert.ToInt32(Console.ReadLine());

            switch (jawab)
            {
                case 0: Console.WriteLine("\n\t     Program akan berhenti dalam 5 detik"); Thread.Sleep(5000); Console.Clear(); break;
                case 1: menuS1(); break;
                default: Console.WriteLine("\n\t\t Option tidak terdeteksi!!"); Thread.Sleep(3000);  menuUtama(); break;
            }

        }

        static void menuS1()
        {
            string jawab;
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("- - - - - - - - - - KALKULATOR FISIKA - - - - - - - - - - -");
            Console.WriteLine("===========================================================");
            Console.WriteLine("= [A]. Gerak Lurus Berubah beraturan (GLBB)               =");
            Console.WriteLine("= [B]. Gerak Lurus Beraturan (GLB)                        =");
            Console.WriteLine("= [C]. Gerak Jatuh Bebas (GJB)                            =");
            Console.WriteLine("= [D]. Momen Inersia                                      =");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("= [Z]. Kembali                                            =");
            Console.WriteLine("===========================================================");
            Console.Write("\t\t Input /> "); jawab = Console.ReadLine();

            if (jawab == "A" || jawab == "a")
            {
                glbb();
            } else if (jawab == "B" || jawab == "b")
            {
                glb();
            } else if (jawab == "C" || jawab =="c")
            {
                gjb();
            } else if (jawab == "D" || jawab=="d")
            {
                mi();
            } else if (jawab == "Z" || jawab == "z")
            {
                menuUtama();
            }
            else
            {
                Console.WriteLine("\n\t\t Option tidak valid...."); Thread.Sleep(3000); Console.Clear(); menuS1();
            }
        }

        static void glbb()
        {
            int menu; float St, Vt, a, s, So, Vo, t; string jawab;
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("- - - - - - - - - -  KALKULATOR GLBB - - - - - - - - - - -");
            Console.WriteLine("===========================================================");
            Console.WriteLine(" [1]. Menghitung Posisi akhir  ");
            Console.WriteLine(" [2]. Menghitung Kecepatan akhir");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" [0]. Kembali");
            Console.WriteLine("===========================================================");
            Console.Write("\t\t Input /> "); menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 0: menuS1(); break;
                case 1: Console.Clear(); Console.Write("Input posisi awal So: "); So = float.Parse(Console.ReadLine());
                    Console.Write("Input kecepatan akhir (Vo): "); Vo = float.Parse(Console.ReadLine());
                    Console.Write("Input percepatan (a): "); a = float.Parse(Console.ReadLine());
                    Console.Write("Input Waktu (t): "); t = float.Parse(Console.ReadLine());

                    St = So + Vo + (float)(0.5 * a * Math.Pow(t, 2));

                    Console.WriteLine("St = " + St + " m\n");

                    Console.Write("Kembali ke menu (y)? "); jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        Thread.Sleep(3000); glbb();
                    }  
                    break;

                case 2: Console.Clear(); Console.Write("Input kecepatan akhit (Vo): "); Vo = float.Parse(Console.ReadLine());
                    Console.Write("Input percepatan (a): "); a = float.Parse(Console.ReadLine());
                    Console.Write("Input waktu (t): "); t = float.Parse(Console.ReadLine());

                    Vt = Vo + (a * t);

                    Console.WriteLine("Vt = " + Vt + " m/s\n");

                    Console.Write("Kembali ke menu (y)? "); jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        Thread.Sleep(3000); glbb();
                    }
                    break;

                default: Console.WriteLine("\n\t\t Option tidak valid...."); Thread.Sleep(3000); glbb(); break;
            }
        }

        static void glb()
        {
            int menu; float St, v, So, t; string jawab;
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("- - - - - - - - - - - KALKULATOR GLB - - - - - - - - - - - -");
            Console.WriteLine("===========================================================");
            Console.WriteLine(" [1]. Menghitung Posisi akhir  ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" [0]. Kembali");
            Console.WriteLine("===========================================================");
            Console.Write("\t\t Input /> "); menu = Convert.ToInt32(Console.ReadLine());

            switch(menu)
            {
                case 0: menuS1(); break;
                case 1: Console.Clear(); Console.Write("Input posisi awal (So): "); So = float.Parse(Console.ReadLine());
                    Console.Write("Input kecepatan (v): "); v = float.Parse(Console.ReadLine());
                    Console.Write("Input waktu (t): "); t = float.Parse(Console.ReadLine());

                    St = So + (v * t);

                    Console.WriteLine("St = " + St + " m\n");

                    Console.Write("Kembali ke menu (y)? "); jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        Thread.Sleep(3000); glb();
                    }
                    break;

                default:
                    Console.WriteLine("\n\t\t Option tidak valid...."); Thread.Sleep(3000); glb(); break;
            }
        }

        static void gjb()
        {
            int menu; float h, t,Vt; const float g = 10.0f; string jawab, jawab2;
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("- - - - - - - - - - - KALKULATOR GJB - - - - - - - - - - - -");
            Console.WriteLine("===========================================================");
            Console.WriteLine(" [1]. Menghitung ketinggian  ");
            Console.WriteLine(" [2]. Menghitung Kecepatan akhir");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" [0]. Kembali");
            Console.WriteLine("===========================================================");
            Console.Write("\t\t Input /> "); menu = Convert.ToInt32(Console.ReadLine());

            switch(menu)
            {
                case 0: menuS1(); break;
                case 1: Console.Clear(); Console.Write("Input waktu (t): "); t = float.Parse(Console.ReadLine());
                        
                        h = (float)(0.5 * g * Math.Pow(t, 2));

                    Console.WriteLine("h = " + h + " m\n"); Thread.Sleep(3000);

                    Console.Write("Kembali ke menu (y)? "); jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        Thread.Sleep(3000); gjb();
                    }
                    break;

                case 2: Console.Clear(); Console.Write("Apakah tinggi nya diketahui (h)? "); jawab = Console.ReadLine();
                     if (jawab == "y" || jawab == "Y")
                    {
                        Console.Clear(); Console.Write("Input ketinggian (h): "); h = float.Parse(Console.ReadLine());

                        Vt = 2 * g * h;

                        Console.WriteLine("Vt = " + Vt + " m/s\n"); Thread.Sleep(3000);

                        Console.Write("Kembali ke menu (y)? "); jawab2 = Console.ReadLine();
                        if (jawab2 == "y" || jawab2 == "Y")
                        {
                            Thread.Sleep(3000); gjb();
                        }

                    } else if (jawab == "n" || jawab == "N")
                    {
                        Console.Clear(); Console.Write("Input waktu (t): "); t = float.Parse(Console.ReadLine());

                        Vt = g * t;

                        Console.WriteLine("Vt = " + Vt + " m/s\n"); Thread.Sleep(3000);

                        Console.Write("Kembali ke menu (y)? "); jawab2 = Console.ReadLine();
                        if (jawab2 == "y" || jawab2 == "Y")
                        {
                            Thread.Sleep(3000); gjb();
                        }

                    } else
                    {
                        Console.WriteLine("\n\t\t Option tidak valid...."); Thread.Sleep(3000); gjb();
                    }
                    break;

                default:
                    Console.WriteLine("\n\t\t Option tidak valid...."); Thread.Sleep(3000); gjb(); break;

            }
        }

        static void mi()
        {
            int menu; float I, r, m, t, F; ; string jawab;
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("- - - - - - - - - - - KALKULATOR MI - - - - - - - - - - - -");
            Console.WriteLine("===========================================================");
            Console.WriteLine(" [1]. Menghitung momen gaya/ torka");
            Console.WriteLine(" [2]. Menghitung momen inersia");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" [0]. Kembali");
            Console.WriteLine("===========================================================");
            Console.Write("\t\t Input /> "); menu = Convert.ToInt32(Console.ReadLine());

            switch(menu)
            {
                case 0: menuS1(); break;
                case 1: Console.Clear(); Console.Write("Input vektor posisi pd lengan (r): "); r = float.Parse(Console.ReadLine());
                    Console.Write("Input vektor gaya (F): "); F = float.Parse(Console.ReadLine());

                    t = r * F;

                    Console.WriteLine("t = " + t + " Nm\n"); Thread.Sleep(3000);

                    Console.Write("Kembali ke menu (y)? "); jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        Thread.Sleep(3000); mi();
                    }
                    break;

                case 2: Console.Clear(); Console.Write("Input massa (kg): "); m = float.Parse(Console.ReadLine());
                    Console.Write("Input jarak benda terhadap poros (r): "); r = float.Parse(Console.ReadLine());

                    I = (float)(m * Math.Pow(r, 2));

                    Console.WriteLine("I = " + I + " Kg/m^2\n"); Thread.Sleep(3000);

                    Console.Write("Kembali ke menu (y)? "); jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        Thread.Sleep(3000); mi();
                    }
                    break;

                default:
                    Console.WriteLine("\n\t\t Option tidak valid...."); Thread.Sleep(3000); mi(); break;
            }
        }

    }
}
