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
                throw new IOException("ERRO:NAO FOI POSSIVEL CONVERTER COR");
            }
        }
        private DisplayPiece ConvertToDisplayPiece(Piece p)
        {
            return new DisplayPiece(
                    new DisplayPosition(ConvertToCharacter(p.position.x),p.position.y),
                    p.color.ToString()
                );
        }

        private Piece ConvertToPiece(DisplayPiece dpiece){
            Piece p = new Pawn{
                id=dpiece.id,
                color = ConvertToColor(dpiece.color),
                isAlive=dpiece.isAlive,
                position= new Position(ConvertToNumber(dpiece.dPosition.x),dpiece.dPosition.y)
            };
            return p;
            
        }
    }
}
