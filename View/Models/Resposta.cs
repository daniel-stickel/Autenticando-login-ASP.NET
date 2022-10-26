using Model;

namespace View.Models
{
    public class Resposta : Response
    {
        public Resposta()
        {
        }

        public Resposta(string? message, bool success, object? element) : base(message, success, element)
        {
        }
    }
}
