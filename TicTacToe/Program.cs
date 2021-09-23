using System;

namespace TicTacToe
{
    public class Program
    {
        static int[] arkerja = new int[10];
        static int pemain = 1;
        static int main = 1;
        static int nomorArea;

        public static void Main(string[] args)
        {
            while (main == 1)
            {
                CetakArray();
                nomorArea = Int32.Parse(Console.ReadLine());
                if (arkerja[nomorArea] == 0)
                {
                    arkerja[nomorArea] = pemain;
                    TukarPemain();
                    CekPemenang();
                }
                else
                {
                    Console.WriteLine(" Pilih Area Yang Masih Kosong");
                    Console.WriteLine(" Press Any Key ");
                    Console.ReadLine();
                }

                if (main == 0)
                {
                    int i = 1;
                    while (i == 1)
                    {
                        string tombol;
                        Console.WriteLine(" Permaian Baru ? Y/N");
                        tombol = Console.ReadLine();
                        if (tombol == "Y" || tombol == "y")
                            main = 1; i = 0; ResetArray();
                        if (tombol == "N" || tombol == "n")
                            i = 0; Console.WriteLine(" Permainan Berakhir "); Console.ReadLine();
                    }
                }
            }
        }

        static void CetakArray()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(" TIC TAC TOE ");
            Console.WriteLine(" Pemain " + pemain + " Pilih Lokasi (1-9) ");
            Console.WriteLine("");
            Console.WriteLine("   " + arkerja[1] + "  |  " + arkerja[2] + "  |  " + arkerja[3]);
            Console.WriteLine("   -----------------");
            Console.WriteLine("   " + arkerja[4] + "  |  " + arkerja[5] + "  |  " + arkerja[6]);
            Console.WriteLine("   -----------------");
            Console.WriteLine("   " + arkerja[7] + "  |  " + arkerja[8] + "  |  " + arkerja[9]);
            Console.WriteLine("   -----------------");
            Console.WriteLine("");
            Console.WriteLine("Lokasi Yang Dipilih : ");
        }

        static void TukarPemain()
        {
            if (pemain == 1)
                pemain = 2;
            else
                pemain = 1;
        }

        static void CekPemenang()
        {
            if (arkerja[1] == 1 && arkerja[2] == 1 && arkerja[3] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[4] == 1 && arkerja[5] == 1 && arkerja[6] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[7] == 1 && arkerja[8] == 1 && arkerja[9] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[1] == 1 && arkerja[4] == 1 && arkerja[7] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[2] == 1 && arkerja[5] == 1 && arkerja[8] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[3] == 1 && arkerja[6] == 1 && arkerja[9] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[1] == 1 && arkerja[5] == 1 && arkerja[9] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }
            if (arkerja[3] == 1 && arkerja[5] == 1 && arkerja[7] == 1) { Console.WriteLine(" Pemain 1 Menang"); main = 0; }


            if (arkerja[1] == 2 && arkerja[2] == 2 && arkerja[3] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[4] == 2 && arkerja[5] == 2 && arkerja[6] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[7] == 2 && arkerja[8] == 2 && arkerja[9] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[1] == 2 && arkerja[4] == 2 && arkerja[7] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[2] == 2 && arkerja[5] == 2 && arkerja[8] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[3] == 2 && arkerja[6] == 2 && arkerja[9] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[1] == 2 && arkerja[5] == 2 && arkerja[9] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
            if (arkerja[3] == 2 && arkerja[5] == 2 && arkerja[7] == 2) { Console.WriteLine(" Pemain 2 Menang"); main = 0; }
        }
        static void ResetArray()
        {
            for (int i = 1; i < 10; i++)
                arkerja[i] = 0;
        }
    }
}
