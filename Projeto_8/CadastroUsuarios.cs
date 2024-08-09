using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_8
{
    internal class CadastroUsuarios
    {
        private static Usuário[] usuarios =
        {
            new Usuário(){Nome = "cesar", Senha = "1234" },
            new Usuário(){Nome = "Ian", Senha = "forms123"},
            new Usuário(){Nome = "Iza", Senha = "beli1234" }

        };

        private static Usuário _userLogado = null;

        public static Usuário UsuarioLogado
        { get { return _userLogado; } set { _userLogado = value; } }

    public static bool Login(string nome, string password)
    {
        foreach (Usuário usuario in usuarios)
        {
        if(usuario.Nome == nome && usuario.Senha == password)
            {
                UsuarioLogado = usuario;
                return true;
            }

        }
        return false;

    }
    }

    
}
