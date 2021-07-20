namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        } 

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }


        //Coloca peça na posição correta dado que é uma matriz e usa linhas e colunas para demarcar posições
        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            //dizer que a minha peça agora tem uma posição pos que é igual a posição colocada
            p.posicao = pos;
        }
    }
}
