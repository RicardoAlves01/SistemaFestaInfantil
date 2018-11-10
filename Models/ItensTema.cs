using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class ItensTema
    {
        private string nomeItem;
        private float valorItem;

        public ItensTema(string nomeItem, float valorItem)
        {
            this.nomeItem = nomeItem;
            this.valorItem = valorItem;
        }

        //gets e sets
        public float ValorItem
        {
            get { return valorItem; }
            set { valorItem = value; }
        }


        public string Nomeitem
        {
            get { return nomeItem; }
            set { nomeItem = value; }
        }

    }
}
