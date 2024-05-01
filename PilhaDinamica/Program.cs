namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivros pilha = new PilhaLivros();

            while (true)
            {
                int opcao = Menu();
                ImprimirLinha();

                switch (opcao)
                {
                    case 1:
                        pilha.Push(CriarLivro());
                        break;
                    case 2:
                        pilha.Pop();
                        break;
                    case 3:
                        pilha.Print();
                        break;
                    case 4:
                        VerificarLivro(pilha);
                        break;
                    case 5:
                        Console.WriteLine("Quantidade de livros:");
                        Console.WriteLine($"--> {pilha.GetQntLivros()}");
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                ImprimirLinha();
                Console.WriteLine("Digite qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("======Pilha de livros======");

            Console.WriteLine("Escolha uma opcao");
            Console.WriteLine("1- Adicionar um livro");
            Console.WriteLine("2- Remover um livro");
            Console.WriteLine("3- Imprimir todos os livros");
            Console.WriteLine("4- Procurar livro por nome");
            Console.WriteLine("5- Saber quantidade de livros");
            Console.WriteLine("6- Sair");
            Console.Write("R: ");
            int option = int.Parse(Console.ReadLine());

            if (option < 1 || option > 6)
                return Menu();

            return option;
        }

        static Livro CriarLivro()
        {
            Console.WriteLine("===Inserir Livro na pilha====");

            Console.Write("Digite o titulo do livro: ");
            string titulo = Console.ReadLine();

            return new Livro(titulo);
        }

        static void VerificarLivro(PilhaLivros pilha)
        {
            Console.WriteLine("===Procurar Livro====");

            Console.Write("Digite o titulo do livro: ");
            string titulo = Console.ReadLine();

            if (pilha.Contains(titulo))
            {
                Console.WriteLine("O livro está na pilha!");
            }
            else
            {
                Console.WriteLine("O livro não está na pilha!");
            }
        }

        static void ImprimirLinha()
        {
            Console.WriteLine("=============================");
        }
    }
}
