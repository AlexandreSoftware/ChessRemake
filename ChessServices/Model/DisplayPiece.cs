using System;
using System.IO;
using ChessCore.Pieces;

namespace ChessService.Model
{
    public class DisplayPiece
    {
        public int id { get; set; }
        public DisplayPosition dPosition {get;set;}
        public bool isAlive {get;set;}
        public string color {get;set;}
        public string type {get;set;}
        public DisplayPiece(DisplayPosition dpos,string color,string type){
            
            this.dPosition=new DisplayPosition(dpos.x,dpos.y);
            this.color = color;
            this.isAlive = true;
            this.type = type;
        }
          public DisplayPiece(char x,int y,string color,string type){
            this.dPosition=new DisplayPosition(x,y);
            this.color = color;
            this.type=type;
        }
        
    }
}