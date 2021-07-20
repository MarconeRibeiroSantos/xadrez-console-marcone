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

        //Sobrecarga do método peca para receber a posição ao invés da linha e coluna
        public Peca peca(Posicao pos)
        {

            return pecas[pos.linha, pos.coluna];
        }

        //Dado que tenho uma matriz com peça, quando executar o método validarPosicao , então valida se existe peça em determinada posição
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //Dado que quero colocar peça, quando tentar colocar a peça em uma posição com peça, então retorna já existe peça na posiçao
        public void colocarPeca(Peca p, Posicao pos)
        {

            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;

            p.posicao = pos;
        }

        //Dado que tenho uma matriz 00x77(8x8), Quando colocar peça na posição, então a peça não pode estar fora da faixa 8x8
        public bool posicaoValida(Posicao pos)
        {

            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {

                return false;
            }
            return true;
        }

        //Dado que a posição não seja válida, quando executar o método de validação de posição, então retorna que a posição é inválida
        public void validarPosicao(Posicao pos)
        {

            if (!posicaoValida(pos))
            {

                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
