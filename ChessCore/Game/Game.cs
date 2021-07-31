using System.Collections.Generic;
using ChessCore.Pieces;

namespace ChessCore
{
    public class Game
    {
        public Player[] players { get; set; }
        public Map gameMap { get;set;}
        public int currentTurn { get; set; }
        public HashSet<Piece> capturedPieces {get; set;}
     
    }
}