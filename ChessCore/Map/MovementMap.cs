using ChessCore.Pieces;

namespace ChessCore
{
    public class MovementMap
    {
        public Piece caller{get;set;}
        public Map map{get;set;}
        public Piece[,] possibleMovements{get;set;}

    }
}