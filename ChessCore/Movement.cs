using ChessCore.Pieces;

namespace ChessCore
{
    public class Movement
    {
        public int turn {get;set;}
        public Position initialPosition {get;set;}
        public Position endPosition {get;set;}
        public bool didCapturePiece {get;set;}
        public Piece movementMaker { get; set; }

        public Piece capturedPiece {get;set;}  
    }
}