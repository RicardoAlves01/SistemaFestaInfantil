using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Tema
    {
        private string temaFesta;
        private string corToalhaMesa;

        //construtores
        public Tema()
        {
        }

        public Tema(string temaFesta, string corToalhaMesa)
        {
            this.temaFesta = temaFesta;
            this.corToalhaMesa = corToalhaMesa;
        }

        //gets e sets
        public string CorToalhaMesa
        {
            get { return corToalhaMesa; }
            set { corToalhaMesa = value; }
        }

        public string TemaFesta
        {
            get { return temaFesta; }
            set { temaFesta = value; }
        }
    }
}
