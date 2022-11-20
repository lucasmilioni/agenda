using System.ComponentModel.DataAnnotations;

namespace Agenda.Presentation.Models.Validators
{
    /// <summary>
    /// Classe de validação custumizada para campos de senha
    /// </summary>
    public class PasswordValidator : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                //Capturar o valor do campo que está sendo validado
                var password = value.ToString();

                return password.Length >= 8 //Minimo de 8 caracteres
                    && password.Length <= 20 //Maximo de 20 caracteres
                    && password.Any(char.IsUpper) //Pelo menos uma letra maiuscula
                    && password.Any(char.IsLower) //Pelo menos uma letra minuscula
                    && password.Any(char.IsDigit) //Pelo menos um digito numérico
                    && ( //Pelo menos um dos caracteres especiais abaixo 
                    password.Contains("!") ||
                    password.Contains("@") ||
                    password.Contains("#") ||
                    password.Contains("$") ||
                    password.Contains("%") ||
                    password.Contains('&')
                    );
            }
            else
            {
                return false;
            }
        }
    }
}
