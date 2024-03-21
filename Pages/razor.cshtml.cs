using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tp02_.net.Model;

namespace Tp02_.net.Pages
{
    public class razorModel : PageModel
    {
        public List<Pessoa> pessoas = [];

        public void OnGet()
        {
            for (int i = 1; i <= 10; i++)
            {
                pessoas.Add(new Pessoa
                {
                    Nome = $"Pessoa {i}",
                    Idade = i + 18,
                    Cpf = $"{i * 98754321}"
                });
            }
        }
    }
}
