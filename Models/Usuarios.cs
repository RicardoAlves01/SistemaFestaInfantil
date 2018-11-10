using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Usuarios
    {
        private int id;
        private string nome;
        private string cpf;
        private int telefone;
        private int privilegio;
        private string endereco;

        //construtores
        public Usuarios()
        {
        }

        public Usuarios(int id, string nome, string cpf, int telefone, int privilegio, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.privilegio = privilegio;
            this.endereco = endereco;
        }

        //gets e sets
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        public int Privilegio
        {
            get { return privilegio; }
            set { privilegio = value; }
        }


        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
