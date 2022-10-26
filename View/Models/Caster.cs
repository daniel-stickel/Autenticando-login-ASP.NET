using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Models
{
    public static class Caster
    {
        public static Resposta ResponseToResposta(Response response)
        {
            return new Resposta(response.Message, response.Success, response.Element);
        }
    }
}
