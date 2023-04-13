namespace tauleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //Define a quantidade de linhas e colunas do tabuleiro e também cria a matriz de peças (Cada posição pode ter ou não uma peça)
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }

        //retorna a peca na posição desejada (se tiver)
        public Peca peca(int linha,int coluna)
        {
            return pecas[linha,coluna];
        } 
    }
}
