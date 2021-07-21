using System.Collections.Generic;

namespace ChessCore.Pieces
{
    public class Piece
    {
        public Position position { get; set; }
        public bool isAlive { get; set; }
        public List<Movement> movementHistory {get;set;}
        
    }
}