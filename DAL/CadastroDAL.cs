using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class CadastroDAL
    {
        public static Response Insert(string email, string userLogin, string userPassword)
        {
            Response res = new Response();
            string commandText = $"INSERT into dbo.Cadastro (Email,UserLogin,UserPassword) values ('{email}','{userLogin}','{userPassword}')";

            SqlCommand cmd = new SqlCommand(commandText, BDConnection.Conn);

            try
            {
                BDConnection.Conn.Open();

                cmd.ExecuteNonQuery();

                BDConnection.Conn.Close();
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Success = false;
                return res;
            }

            res.Message = $"Cadastro Efetuado {email}";
            res.Success = true;
            return res;
        }

        public static Response Select(string user, string password)
        {
            Response res = new Response();

            string select = $"SELECT ID,Email,UserLogin from dbo.Cadastro WHERE UserLogin = {user} AND UserPassword = {password}";
            SqlCommand cmd = new SqlCommand(select, BDConnection.Conn);
            try
            {
                BDConnection.Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    res.Message = "O login existe";
                    res.Success = true;
                    res.Element = new Cadastro(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), "");
                    //res.Element = typeof(Cadastro);
                }
                BDConnection.Conn.Close();
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Success = false;
                BDConnection.Conn.Close();                
            }
            return res;
        }

    }
}