namespace Jogo_De_Xadrez.chessboard
{
    class Chessboard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces;

        public Chessboard(int lines, int columns)
        {
            this.Lines = lines;
            this.Columns = columns;
            pieces = new Piece[lines, columns];
        }
    }
}
