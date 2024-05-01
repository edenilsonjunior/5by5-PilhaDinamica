using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class PilhaLivros
    {
        Livro topo;
        int contador;

        public PilhaLivros()
        {
            topo = null;
            contador = 0;
        }

        public void Push(Livro aux)
        {
            if (IsEmpty())
            {
                topo = aux;
            }
            else
            {
                aux.SetAnterior(topo);
                topo = aux;
            }
            contador++;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                Console.WriteLine("Livro removido:");
                Console.WriteLine($"--> {topo}");
                topo = topo.GetAnterior();
                contador--;
            }
        }

        public bool Contains(string titulo)
        {
            Livro aux = topo;

            bool achou = false;
            if (IsEmpty())
            {
                Console.WriteLine("-->Pilha vazia!");
            }
            else
            {
                do
                {
                    if (aux.GetTitulo().Equals(titulo))
                    {
                        achou = true;
                    }
                    aux = aux.GetAnterior();

                } while (aux != null);
            }

            return achou;
        }

        public int GetQntLivros()
        {
            return contador;
        }

        public bool IsEmpty()
        {
            return topo == null;
        }

        public void Print()
        {
            Console.WriteLine("Conteudo da pilha:");
            Livro aux = topo;

            if (IsEmpty())
            {
                Console.WriteLine("-->Pilha vazia!");
            }
            else
            {
                Console.WriteLine($"Topo: {topo}");

                aux = aux.GetAnterior();
                while (aux != null)
                {
                    Console.WriteLine($"--> {aux}");
                    aux = aux.GetAnterior();
                }
            }
        }
    }
}
