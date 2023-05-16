namespace SistemaAula.Entidades
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Login { get; set; } = null!;
        public string Senha { get; set; } = null!;

        protected Usuario() { } 

        public Usuario(string login, string senha) {
         
            Login = login;
            Senha = senha;  

        }    
    }
}
