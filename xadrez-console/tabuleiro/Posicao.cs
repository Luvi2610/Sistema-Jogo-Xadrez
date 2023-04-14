namespace tabuleiro
{
    class Posicao
    {
       public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //Permite manipular mais facilmente o objeto para que possa definir valores em uma linha
        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }



    }
}
