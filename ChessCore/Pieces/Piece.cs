using System.Collections.Generic;

namespace ChessCore.Pieces
{
    public abstract class Piece
    {

        public Position position { get; set; }
        public bool isAlive { get; set; }
        public List<Movement> movementHistory {get;set;}
        public abstract MovementMap GetMovements();
        public abstract void doMovement();
    }
}