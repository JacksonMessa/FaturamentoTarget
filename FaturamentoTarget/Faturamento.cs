using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FaturamentoTarget
{
    class Faturamento
    {
        const string filePath = "../../../data/dados.json";

        public Dia[] dias { get; set; }
        public Faturamento()
        {
            loadData();
        }
        public void loadData()
        {
            string stringJson = File.ReadAllText(filePath);
            dias = JsonSerializer.Deserialize<Dia[]>(stringJson)!;
        }

        public double maiorValor()
        {
            double maior = 0;
            foreach (Dia dia in dias)
            {
                if (maior < dia.valor)
                {
                    maior = dia.valor;
                }
            }
            return maior;
        }

        public double menorValor()
        {
            double menor = 0;
            foreach (Dia dia in dias)
            {
                if (menor > dia.valor)
                {
                    menor = dia.valor;
                }
            }
            return menor;
        }

        public double menorValorSemContarZero()
        {
            double menor = 0;
            foreach (Dia dia in dias)
            {
                if ((menor > dia.valor || menor == 0) && dia.valor!=0)
                {
                    menor = dia.valor;
                }
            }
            return menor;
        }

        public double media()
        {
            double soma = 0;
            int num_dias = 0;
            foreach(Dia dia in dias)
            {
                if (dia.valor != 0)
                {
                    soma += dia.valor;
                    num_dias++;
                }
            }
            return soma / num_dias;
        }


        public int diasAcimaDaMedia()
        {
            double media = this.media();
            int num_dias = 0;
            foreach (Dia dia in dias)
            {
                if (dia.valor > media)
                {
                    num_dias++;
                }
            }
            return num_dias;
        }
    }


}
