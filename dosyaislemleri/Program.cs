using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyaislemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = @"C:\Users\Hp\Desktop\deneme.txt";

            // Kullanıcıdan dosyaya yazılacak metni al
            Console.Write("Dosyaya yazmak istediğiniz metni girin: ");
            string metin = Console.ReadLine();

            // Dosyaya yazma
            File.WriteAllText(dosyaYolu, metin);
            Console.WriteLine("\nMetin dosyaya yazıldı.\n");

            // Dosyayı okuma
            if (File.Exists(dosyaYolu))
            {
                string icerik = File.ReadAllText(dosyaYolu);
                Console.WriteLine("Dosya içeriği: " + icerik);
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı.");
            }

            // Dosya silme işlemi
            Console.Write("\nDosyayı silmek için 'k' tuşuna basın: ");
            ConsoleKeyInfo tus = Console.ReadKey();

            if (tus.KeyChar == 'k')
            {
                if (File.Exists(dosyaYolu))
                {
                    File.Delete(dosyaYolu);
                    Console.WriteLine("\nDosya silindi.");
                }
                else
                {
                    Console.WriteLine("\nDosya bulunamadığı için silinemedi.");
                }
            }
            else
            {
                Console.WriteLine("\nDosya silinmedi.");
            }

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
