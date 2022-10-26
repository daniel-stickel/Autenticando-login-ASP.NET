using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class BDConnection
    {

        private static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\Desktop\aula inicial arquivo professor\AulaInicial\DAL\AulaInicialBD.mdf"";Integrated Security=True");// esse campo precisar mmodifacdo toda vez em que precisar compilar em outro computador 

        public static SqlConnection Conn { get => conn; private set => conn = value; }

    }
}
