using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ExerciciosList.Exercicio02
{
    internal class ConteudoPassado
    {
        public void Executar()
        {
            //a.Adicionar o conteúdo "Como fazer um bolo"
            //b.Listar conteúdos
            //c.Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que
            //se alimentam”
            //d.Adicionar o conteúdo "variáveis"
            //e.Adicionar o conteúdo "Mais para frente"
            //f.Alterar o conteúdo “Mais para frente" por "If com E"
            //g.Adicionar o conteúdo "If com OU”;
            //h.Adicionar o conteúdo "While";
            //i.Adicionar o conteúdo "For"
            //j.Listar conteúdos
            //k.Adicionar o conteúdo "Vetor"
            //l.Adicionar o conteúdo "Vetor”
            //m.Apagar os conteúdos "Vetor"
            //n.Adicionar o conteúdo "Vetor"
            //o.Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida”
            //p.Listar conteúdos
            //q.Adicionar o conteúdo "Classe propriedades e métodos"
            //r.Listar conteúdos
            List<string> conteudo = new List<string>();
            conteudo.Add("Como fazer um bolo");
            Console.WriteLine("[0]: " + conteudo[0]);
            conteudo[0] = "Algoritmos onde vivem? Do quese alimentam";
            conteudo.Add("variáveis");
            conteudo.Add("Mais para frente");
            conteudo[2] = ("If com E");
            conteudo.Add("If com Ou");
            conteudo.Add("While");
            conteudo.Add("For");
            Console.WriteLine("[0]: " + conteudo[0]+
                "\n[1]: " + conteudo[1]+
                "\n[2]: " + conteudo[2]+
                "\n[3]: " + conteudo[3]+
                "\n[4]: " + conteudo[4]+
                "\n[5]: " + conteudo[5]);
            conteudo.Add("Vetor");
            conteudo.Add("Vetor");
            conteudo.Remove("Vetor");
            conteudo.Remove("Vetor");
            conteudo.Add("Vetor");
            conteudo[6] = "Vetor com For um amor na minha vida";
            Console.WriteLine("[0]: " + conteudo[0] +
                "\n[1]: " + conteudo[1] +
                "\n[2]: " + conteudo[2] +
                "\n[3]: " + conteudo[3] +
                "\n[4]: " + conteudo[4] +
                "\n[5]: " + conteudo[5] +
                "\n[6]: " + conteudo[6]);
            conteudo.Add("Classe propriedades e métodos"); 
            Console.WriteLine("[0]: " + conteudo[0] +
                "\n[1]: " + conteudo[1] +
                "\n[2]: " + conteudo[2] +
                "\n[3]: " + conteudo[3] +
                "\n[4]: " + conteudo[4] +
                "\n[5]: " + conteudo[5] +
                "\n[6]: " + conteudo[6] +
                "\n[7]: " + conteudo[7]);
        }
    }
}
