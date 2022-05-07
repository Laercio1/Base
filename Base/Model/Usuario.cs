namespace Model
{
    public class Usuario
    {
        private string nomeUsuario;
        private int id;
        private bool ativo;
        private string senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }


    }
}
