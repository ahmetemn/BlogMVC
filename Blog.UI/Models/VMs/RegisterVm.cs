using System.ComponentModel.DataAnnotations;

namespace Blog.UI.Models.VMs
{
    public class RegisterVm
    {


        [Display(Name = "Mail Adresi"), Required(ErrorMessage = "Email  Boş Geçilemez.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]

        [Display(Name = "Kullanıcı Şifresi"), Required(ErrorMessage = "Şifre boş geçilemez.")]

        [StringLength(20, MinimumLength = 8, ErrorMessage = "Şifre en az 8, en fazla 20 karakter uzunluğunda olmalıdır.")]

        public string Password { get; set; }

        [Display(Name = "Kullanıcı Şifresi Tekrar Girmek Zorunludur")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]

        public string PasswordConfirm { get; set; }


    }
}
