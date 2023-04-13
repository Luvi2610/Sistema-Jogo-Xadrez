using tauleiro;

namespace xadrez_console {
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8); //Inicializa a matriz com nulo em todos os valores

            Tela.imprimirTabuleiro(tab);
        }
    }
}
