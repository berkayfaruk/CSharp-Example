using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dışarıdan_Girilen_Saya_En_yakın
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Önceki sayi {0} dir.", kucukAsalaYuvarla(sayi));
            Console.WriteLine("Sonraki sayi {0} dir.",buyukAsalaYuvarla(sayi));
            Console.ReadLine();
        }

        private static int buyukAsalaYuvarla(int sayi)
        {
            int sonrakiAsal=0;
            for (int i = sayi; i >sayi-1 ; i++)
            {
                int flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag==0)
                {
                    sonrakiAsal = i;
                    break;
                } 

            }
            return sonrakiAsal;
        }
        private static int kucukAsalaYuvarla(int sayi)
        {
            int oncekiAsal = 0;
            for (int i = sayi; i < sayi+1; i--)
            {
                int flag = 0;
                for (int  j = 2;  j < i;  j++)
                {
                    if (i%j==0)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag==0)
                {
                    oncekiAsal = i;
                    break;
                }
            }
            return oncekiAsal;

        }
    }
}
