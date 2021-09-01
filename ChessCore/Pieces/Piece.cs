using System.Collections.Generic;
using System.Linq;

namespace ChessCore.Pieces
{
    public abstract class Piece
    {
        public int id ;
        public Position position { get; set; }
        public Map parentMap { get; set; }
        public bool isAlive { get; set; }
        public Color color { get; set; }
        public List<Movement> movementHistory {get;set;}
        public Piece(int id, Position position, Map parentmap,bool isAlive,Color color,Movement[] movementHistory){
            this.id=id;
            this.position=position;
            this.parentMap=parentmap;
            this.isAlive=isAlive;
            this.color=color;
            this.movementHistory=movementHistory.ToList();
        }
        public Piece(int id, Position position,bool isAlive,Color color){
            this.id=id;
            this.position=position;
            this.isAlive=isAlive=true;
            this.color=color;
        }
        /*added this so that the tests work for now */
        public Piece(){

        }
        public MovementMap Mapmovements(){
            MovementMap map = new MovementMap();
            for (int i = 0; i < (int)Direction.Left; i++)
            {
                map = emulateMovement((Direction)i,map);
            }
            return map;
        }
        public MovementMap emulateMovement(Direction d,MovementMap pmap){
            if(d==Direction.Top){
                return MakeMovement(new Position(0,1),pmap);
            }
            else if(d==Direction.Right){
                return MakeMovement(new Position(1,0),pmap);
            }
            else if(d==Direction.Bottom){
                return MakeMovement(new Position(0,-1),pmap);
            }
            else{
                return MakeMovement(new Position(-1,0),pmap);
            }
        }
        public abstract MovementMap MakeMovement(Position p,MovementMap map);
        public bool CheckForPiece(Position p){
            if(parentMap.choosePiece(p)!=null){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
