using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FaturamentoTarget
{
    class Dia
    {
        public Dia()
        {

        }
        public Dia(int dia, double valor)
        {
            this.dia = dia;
            this.valor = valor;
        }

        public int dia { get; set; }
        public double valor { get; set; }

        

    }
}
