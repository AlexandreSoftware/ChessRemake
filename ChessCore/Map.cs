using ChessCore.Pieces;
using System.Collections.Generic;
namespace ChessCore
{
    public class Map
    {
        public Piece[,] map { get; set; }
        public HashSet<Piece> capturedPieces {get; set;}
    }
}