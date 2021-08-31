using System;
using System.IO;
using ChessCore;
using ChessCore.Pieces;
using ChessService.Interface;
using ChessService.Model;
namespace ChessService
{
    public class PieceService : IPieceService
    {
        public DisplayPiece AddPiece(DisplayPiece dpiece)
        {
            Piece p = ConvertToPiece(dpiece);
            return ConvertToDisplayPiece(p);
        }

        private int ConvertToNumber(char c)
        {
            c=char.ToUpper(c);
            if( c >= 'A' && c <= 'H' ){
                return (c - 64);
            }
            else{
                throw new IOException("VALUE OUT OF RANGE OR INVALID, PLEASE TRY AGAIN");
            }       
        }
        private char ConvertToCharacter(int n)
        {
            if(n<=8&&n>=0){
                char c = 'a';
                return (char)(c+(n-1));
            }
            else throw new IOException("number out of range");
        }
        private Color ConvertToColor(string c)
        {
            Color color;
            if(Enum.TryParse<Color>(c,true, out color)){
                return color;
            }            
            else{
                throw new IOException("ERROR: Couldn't convert to color");
            }
        }
        private DisplayPiece ConvertToDisplayPiece(Piece p)
        {
            return new DisplayPiece(
                    new DisplayPosition(ConvertToCharacter(p.position.x),p.position.y),
                    p.color.ToString(),
                    ConvertToString(p)
                );
        }
        private string ConvertToString(Piece t){
            return nameof(t); 
        }
        private Position ConvertToPosition(DisplayPosition dpi){
            return new Position(ConvertToNumber(dpi.x),dpi.y);
        }
        public Piece ConvertToPiece(DisplayPiece dpiece){
            switch(dpiece.type.ToLower()){
                case "pawn":
                    return new Pawn(
                        dpiece.id
                    ,ConvertToPosition( dpiece.dPosition)
                    ,dpiece.isAlive
                    ,ConvertToColor(dpiece.color)
                    );

                default:
                    throw new IOException("ERROR: Invalid Type");
            }
        }
    }
}
