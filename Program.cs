using JurnalModul4_103082400047;

namespace JurnalModul4_103082400047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =============================================
            // BAGIAN A: TABLE DRIVEN (KodeBuah)
            // =============================================
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

            // =============================================
            // BAGIAN B: STATE-BASED CONSTRUCTION
            // =============================================
            Console.WriteLine("\n\n=========================================");
            Console.WriteLine("=== STATE-BASED CONSTRUCTION ===");
            Console.WriteLine("=========================================");

            // GANTI ANGKA 47 INI DENGAN 3 DIGIT TERAKHIR NIM ANDA!
            // Contoh: Jika NIM Anda 103082400047, maka 3 digit terakhir = 47
            int tigaDigitTerakhirNIM = 47; // <--- UBAH SESUAI NIM ANDA

            PosisiKarakterGame karakter = new PosisiKarakterGame(tigaDigitTerakhirNIM);

            Console.WriteLine("\n--- SIMULASI 1: Berdiri -> Terbang -> Jongkok ---");
            karakter.TombolW(); // Berdiri -> Terbang
            karakter.TombolS(); // Terbang -> Jongkok

            Console.WriteLine("\n--- SIMULASI 2: Jongkok -> Berdiri -> Jongkok -> Tengkurap ---");
            karakter.TombolW(); // Jongkok -> Berdiri
            karakter.TombolS(); // Berdiri -> Jongkok
            karakter.TombolS(); // Jongkok -> Tengkurap

            Console.WriteLine("\n--- SIMULASI 3: Tengkurap -> Jongkok -> Berdiri -> Terbang ---");
            karakter.TombolW(); // Tengkurap -> Jongkok
            karakter.TombolW(); // Jongkok -> Berdiri
            karakter.TombolW(); // Berdiri -> Terbang

            Console.WriteLine("\n--- SIMULASI 4: Terbang -> Jongkok -> Tengkurap ---");
            karakter.TombolS(); // Terbang -> Jongkok
            karakter.TombolS(); // Jongkok -> Tengkurap

            Console.WriteLine("\n=========================================");
            Console.WriteLine("=== SIMULASI SELESAI ===");
            Console.WriteLine($"State akhir: {karakter.GetCurrentState()}");

            Console.ReadLine(); // Agar console tidak langsung tertutup
        }
    }
}