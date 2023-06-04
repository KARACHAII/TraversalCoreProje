using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen mail Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Parola Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Paroloyı tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Parola aynı değil !")]
		public string ConfirmPassword { get; set; }

	}
}
