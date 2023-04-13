namespace tabuleiro
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

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            //Primeiro valida a posição
            validarPosicao(pos);
            //Verifica se a posição em questão possui ou não uma peça
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            //Verifica se não tem peça onde quer inserir 
            if(existePeca(pos))
            {
                throw new TabuleiroException("Já existe peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p; //Adiciona a peça na matriz de peças na posição desejada
            p.posicao = pos; //Guarda a posiçã da peça na própria peça
        }


        //Verifica se a posição passada é válida
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha<0 || pos.linha>=linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }

            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
