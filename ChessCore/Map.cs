using ChessCore.Pieces;
using System.Collections.Generic;
namespace ChessCore
{
    public class Map
    {
        public Piece[,] map { get; set; }
        public List<Piece> pieces {get;set;}
        
        public Map(){
            map = new Piece[8,8];
        }
        
        public void PlacePiece(Piece piece){
            var piecePosition = piece.position;
            map[piecePosition.x,piecePosition.y]=piece;
            piece.parentMap = this;
            pieces.Add(piece);
        }   
         
        public Piece choosePiece(Position position){
            return map[position.x,position.y];            
        }
        public Piece removePiece(Piece piece){
            var piecePosition = piece.position;
            map[piecePosition.x,piecePosition.y] = null;
            piece.position = null;
            piece.parentMap = null;
            return piece;
        }
        public void MovePiece(Piece piece, Position endPosition ){
            map[piece.position.x,piece.position.y]=null;
            map[endPosition.x,endPosition.y]=piece;
            piece.position = endPosition;
        }   
    }
}