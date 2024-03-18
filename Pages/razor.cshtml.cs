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
                    Nome = $"nome {i}",
                    Idade = i * 10,
                    Cpf = $"{i + 1}{i + 2}{i + 3}"
                });
            }
        }
    }
}
