using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
   public class WSClients : NewShore
    {
        private string cadena;
        private string cadena1;

        public string Cadena { get => cadena; set => cadena = value; }
        public string Cadena1 { get => cadena1; set => cadena1 = value; }
    }
}