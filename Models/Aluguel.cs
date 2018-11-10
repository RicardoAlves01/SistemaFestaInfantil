using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Aluguel
    {
        private string nomeCliente;
        private string enderecoCliente;
        private float valorAluguel;
        private DateTime dataFesta;
        private string horaInicio;
        private string horaFim;
        private int numeroPessoas;
        private string temaFesta;

        //construtores
        public Aluguel(string nomeCliente, string enderecoCliente, float valorAluguel, DateTime dataFesta, string horaInicio, string horaFim, int numeroPessoas, string temaFesta)
        {
            this.nomeCliente = nomeCliente;
            this.enderecoCliente = enderecoCliente;
            this.valorAluguel = valorAluguel;
            this.dataFesta = dataFesta;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.numeroPessoas = numeroPessoas;
            this.temaFesta = temaFesta;
        }

        public Aluguel()
        {
        }

        //gets e sets
        public string TemaFesta
        {
            get { return temaFesta; }
            set { temaFesta = value; }
        }

        public int NumeroPessoas
        {
            get { return numeroPessoas; }
            set { numeroPessoas = value; }
        }


        public string HoraFim
        {
            get { return horaFim; }
            set { horaFim = value; }
        }

        public string HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public DateTime DataFesta
        {
            get { return dataFesta; }
            set { dataFesta = value; }
        }


        public float ValorAluguel
        {
            get { return valorAluguel; }
            set { valorAluguel = value; }
        }


        public string EnderecoCliente
        {
            get { return enderecoCliente; }
            set { enderecoCliente = value; }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }
    }
}
