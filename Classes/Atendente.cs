using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Atendente : Usuarios
    {
        private string login;
        private int senha;

        //construtores
        public Atendente()
        {
        }

        public Atendente(string login, int senha)
        {
            this.login = login;
            this.senha = senha;
        }

        //gets e sets
        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string MyProperty
        {
            get { return login; }
            set { login = value; }
        }

       
    }
}
