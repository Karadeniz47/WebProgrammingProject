namespace WebProgrammingProject.Modeller // Kendi projenizin namespace'ini kullandýðýnýzdan emin olun
{
    public class Worker
    {
        public int Id { get; set; } // Birincil anahtar
        public string FirstName { get; set; } // Çalýþanýn adý
        public string LastName { get; set; } // Çalýþanýn soyadý
        public string Specialization { get; set; } // Çalýþanýn uzmanlýk alaný (Örn: Saç Kesimi, Boyama)
        public bool IsAvailable { get; set; } // Çalýþanýn müsaitlik durumu
        public int SalonId { get; set; } // Çalýþanýn baðlý olduðu salonun ID'si (Yabancý anahtar)

        // Navigation Property (Ýliþki)
        public Salon Salon { get; set; } // Çalýþanýn ait olduðu salon
    }
}
