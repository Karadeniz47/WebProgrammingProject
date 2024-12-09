namespace WebProgrammingProject.Modeller // Namespace'inizi kontrol edin
{
    public class Salon
    {
        public int Id { get; set; } // Birincil Anahtar
        public string Name { get; set; } // Salon adý
        public string Location { get; set; } // Konum
        public string Description { get; set; } // Açýklama

        // Ýliþkiler (Opsiyonel olarak eklenebilir)
        public List<Worker> Workers { get; set; } // Salona baðlý çalýþanlar
    }
}

