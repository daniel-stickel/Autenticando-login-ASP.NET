
using DAL;
using Model;
using static System.Net.Mime.MediaTypeNames;

namespace BAL
{
    public static class CadastroBAL
    {
        private static bool ConfirmaEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ConfereIgualdade(string login, string password)
        {
            if (login == password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool ConfereTamanho(string value, int tamanho)
        {
            if (value.Length > tamanho)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // conferir se o elemento ja esta cadastrado

        public static Response Insert(string email, string userLogin, string userPassword)
        {
            Response res = new Response();

            // string.IsNullOrEmpty(texto)
            // retorna True caso o texto seja vazio
            // retorna False caso o texto seja diferente de vazio
            if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(userLogin) && !String.IsNullOrEmpty(userPassword))
            {
                if (ConfirmaEmail(email))
                {
                    if (ConfereIgualdade(userLogin, userPassword))
                    {
                        if (ConfereTamanho(email, 100) && ConfereTamanho(userLogin, 45) && ConfereTamanho(userPassword, 45))
                        {
                            res = CadastroDAL.Insert(email, userLogin, userPassword);

                        }
                        else
                        {
                            res.Message = "Algo esta grande de mais";
                            res.Success = false;
                        }
                    }
                    else
                    {
                        res.Message = "Login e Senha devem ser diferentes";
                        res.Success = false;
                    }
                }
                else
                {
                    res.Message = "Email inválido";
                    res.Success = false;
                }
            }
            else
            {
                res.Message = "Todos os campos devem ser preenchidos";
                res.Success = false;
            }

            return res;
        }

        public static Response Select(string userLogin, string userPassword)
        {
            Response res = new Response();

            // string.IsNullOrEmpty(texto)
            // retorna True caso o texto seja vazio
            // retorna False caso o texto seja diferente de vazio
            if (!String.IsNullOrEmpty(userLogin) && !String.IsNullOrEmpty(userPassword))
            {
                if (ConfereIgualdade(userLogin, userPassword))
                {
                    if (ConfereTamanho(userLogin, 45) && ConfereTamanho(userPassword, 45))
                    {
                        res = CadastroDAL.Select(userLogin, userPassword);

                    }
                    else
                    {
                        res.Message = "Algo esta grande de mais";
                        res.Success = false;
                    }
                }
                else
                {
                    res.Message = "Login e Senha devem ser diferentes";
                    res.Success = false;
                }

            }
            else
            {
                res.Message = "Todos os campos devem ser preenchidos";
                res.Success = false;
            }

            return res;
        }
    }
}