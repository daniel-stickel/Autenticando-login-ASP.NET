namespace Model
{
    public class Cadastro
    {
        public Cadastro(int iD, string email, string userLogin, string userPassword)
        {
            ID = iD;
            Email = email;
            UserLogin = userLogin;
            UserPassword = userPassword;
        }
        public Cadastro() { }

        public int ID { get; set; }
        public string? Email { get; set; }
        public string? UserLogin { get; set; }
        public string? UserPassword { get; set; }
    }
}