//validasyon eklendi
using System.ComponentModel.DataAnnotations;

public class Candidate 
{
    //Required attribute'u belirli bir alanın doldurulması gerektiğini ifade eder.
    //Burada Email, FirstName ve LastName alanlarına bu kısıtlama getirilmiş. Bu alanlar boş olursa, belirlenen hata mesajı kullanıcıya gösterilecek.
    [Required(ErrorMessage = "Email area is required.")]
    public String? Email { get; set; } = String.Empty;
    [Required(ErrorMessage = "First Name area is required.")]
    public String? FirstName { get; set; } = String.Empty;
    [Required(ErrorMessage = "Last Name area is required.")]
    public String? LastName { get; set; } = String.Empty;
    public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
    public int? Age { get; set; }
    public String? SelectedCourse { get; set; } = String.Empty;
    public DateTime ApplyAt { get; set; } 

    public Candidate()
    {
        // Nesne her oluşturulduğunda, güncel tarih ve saat atanır.
        //ApplyAt, adayın başvuru yaptığı tarih ve saati tutuyor. Sınıf oluşturulduğunda (constructor çalıştığında) bu alan otomatik olarak o anki tarih ve saat ile dolduruluyor.
        ApplyAt = DateTime.Now;
    }
}
