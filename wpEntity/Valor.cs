using System;
using System.Collections.Generic;
using System.Text;

namespace wpEntity
{
    public class Valor : Base
    {
        public Transportadora transportadora { get; set; }
        public CEP cep { get; set; }
        public Propiedade propiedade { get; set; }
        public Double valor { get; set; }
    }
}
