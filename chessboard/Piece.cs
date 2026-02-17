
using chessboard;

namespace Jogo_De_Xadrez.chessboard
{
    class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qntMoviments { get; protected set; }
        public Chessboard chessboard { get; protected set; }

        public Piece(Position position, Chessboard chessboard, Color color)
        {
            this.position = null;
            this.chessboard = chessboard;
            this.color = color;
            this.qntMoviments = 0;
        }
    }
}
