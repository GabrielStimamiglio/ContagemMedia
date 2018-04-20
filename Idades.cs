using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemMedia
{
    class Idades
    {
        double media;
        int soma;
        List<int> idade = new List<int>();

        public Idades()
        {
            
        }

        public double getMedia()
        {
            return media;
        }
        public int getSoma()
        {
            return soma;
        }
        public void calcularMedia()
        {
            media = media / indice;
        }

        public void somar(int idade)
        {
            soma = soma + idade;
        }

        public void cadastrarIdade(int novaIdade)
        {
            idade.Add(novaIdade);  
        }

    }
}
