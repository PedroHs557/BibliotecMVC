using System.ComponentModel.DataAnnotations;

namespace BibliotecMVC.LoginViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo Senha é obrigatório.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }
}