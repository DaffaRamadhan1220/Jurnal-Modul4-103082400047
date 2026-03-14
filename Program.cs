using JurnalModul4_103082400047;

static void Main(string[] args)
{
    KodeBuah kodeBuah = new KodeBuah();

    Console.WriteLine("=== Table-Driven (Kode Buah) ===");
    Console.WriteLine("Kode buah untuk Apel: " + kodeBuah.getKodeBuah("Apel"));
    Console.WriteLine("Kode buah untuk Pisang: " + kodeBuah.getKodeBuah("Pisang"));
    Console.WriteLine("Kode buah untuk Durian: " + kodeBuah.getKodeBuah("Durian"));
    Console.WriteLine("Kode buah untuk Semangka: " + kodeBuah.getKodeBuah("Semangka"));
}