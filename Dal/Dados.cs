using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Dal
{
    public class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDLojaInfantil;Data Source=DESKTOP-V02ORJ2\\SQLEXPRESS01";
            }
        }
    }
}
