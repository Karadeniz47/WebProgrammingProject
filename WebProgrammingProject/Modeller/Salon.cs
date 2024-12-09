namespace WebProgrammingProject.Modeller // Namespace'inizi kontrol edin
{
    public class Salon
    {
        public int Id { get; set; } // Birincil Anahtar
        public string Name { get; set; } // Salon ad�
        public string Location { get; set; } // Konum
        public string Description { get; set; } // A��klama

        // �li�kiler (Opsiyonel olarak eklenebilir)
        public List<Worker> Workers { get; set; } // Salona ba�l� �al��anlar
    }
}

