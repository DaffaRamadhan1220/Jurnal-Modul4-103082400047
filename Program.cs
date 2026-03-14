using JurnalModul4_103082400047;

namespace JurnalModul4_103082400047
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("=========================================");
            Console.WriteLine("=== TABLE-DRIVEN (KODE BUAH) ===");
            Console.WriteLine("=========================================");

            KodeBuah kodeBuah = new KodeBuah();

            Console.WriteLine("Kode buah untuk Apel      : " + kodeBuah.getKodeBuah("Apel"));
            Console.WriteLine("Kode buah untuk Aprikot   : " + kodeBuah.getKodeBuah("Aprikot"));
            Console.WriteLine("Kode buah untuk Alpukat   : " + kodeBuah.getKodeBuah("Alpukat"));
            Console.WriteLine("Kode buah untuk Pisang    : " + kodeBuah.getKodeBuah("Pisang"));
            Console.WriteLine("Kode buah untuk Paprika   : " + kodeBuah.getKodeBuah("Paprika"));
            Console.WriteLine("Kode buah untuk Blackberry: " + kodeBuah.getKodeBuah("Blackberry"));
            Console.WriteLine("Kode buah untuk Ceri      : " + kodeBuah.getKodeBuah("Ceri"));
            Console.WriteLine("Kode buah untuk Kelapa    : " + kodeBuah.getKodeBuah("Kelapa"));
            Console.WriteLine("Kode buah untuk Jagung    : " + kodeBuah.getKodeBuah("Jagung"));
            Console.WriteLine("Kode buah untuk Kurma     : " + kodeBuah.getKodeBuah("Kurma"));
            Console.WriteLine("Kode buah untuk Durian    : " + kodeBuah.getKodeBuah("Durian"));
            Console.WriteLine("Kode buah untuk Anggur    : " + kodeBuah.getKodeBuah("Anggur"));
            Console.WriteLine("Kode buah untuk Melon     : " + kodeBuah.getKodeBuah("Melon"));
            Console.WriteLine("Kode buah untuk Semangka  : " + kodeBuah.getKodeBuah("Semangka"));

            
            Console.WriteLine("\n\n=========================================");
            Console.WriteLine("=== STATE-BASED CONSTRUCTION ===");
            Console.WriteLine("=========================================");

            
            int tigaDigitTerakhirNIM = 47; 

            PosisiKarakterGame karakter = new PosisiKarakterGame(tigaDigitTerakhirNIM);

            Console.WriteLine("\n--- SIMULASI 1: Berdiri -> Terbang -> Jongkok ---");
            karakter.TombolW(); 
            karakter.TombolS(); 

            Console.WriteLine("\n--- SIMULASI 2: Jongkok -> Berdiri -> Jongkok -> Tengkurap ---");
            karakter.TombolW(); 
            karakter.TombolS(); 
            karakter.TombolS(); 

            Console.WriteLine("\n--- SIMULASI 3: Tengkurap -> Jongkok -> Berdiri -> Terbang ---");
            karakter.TombolW(); 
            karakter.TombolW(); 
            karakter.TombolW(); 

            Console.WriteLine("\n--- SIMULASI 4: Terbang -> Jongkok -> Tengkurap ---");
            karakter.TombolS(); 
            karakter.TombolS(); 

            Console.WriteLine("\n=========================================");
            Console.WriteLine("=== SIMULASI SELESAI ===");
            Console.WriteLine($"State akhir: {karakter.GetCurrentState()}");

            Console.ReadLine(); 
        }
    }
}
