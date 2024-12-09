namespace WebProgrammingProject.Modeller // Kendi projenizin namespace'ini kulland���n�zdan emin olun
{
    public class Worker
    {
        public int Id { get; set; } // Birincil anahtar
        public string FirstName { get; set; } // �al��an�n ad�
        public string LastName { get; set; } // �al��an�n soyad�
        public string Specialization { get; set; } // �al��an�n uzmanl�k alan� (�rn: Sa� Kesimi, Boyama)
        public bool IsAvailable { get; set; } // �al��an�n m�saitlik durumu
        public int SalonId { get; set; } // �al��an�n ba�l� oldu�u salonun ID'si (Yabanc� anahtar)

        // Navigation Property (�li�ki)
        public Salon Salon { get; set; } // �al��an�n ait oldu�u salon
    }
}
