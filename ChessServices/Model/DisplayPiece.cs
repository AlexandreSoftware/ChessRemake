using System;
using System.IO;

namespace ChessService.Model
{
    public class DisplayPiece
    {
        public int id { get; set; }
        public DisplayPosition dPosition {get;set;}
        public bool isAlive {get;set;}
        public string color {get;set;}
        public DisplayPiece(DisplayPosition dpos,string color){
            
            this.dPosition=new DisplayPosition(dpos.x,dpos.y);
            this.color = color;
            isAlive = true;
        }
          public DisplayPiece(char x,int y,string color){
            this.dPosition=new DisplayPosition(x,y);
            this.color = color;
        }
    }
}