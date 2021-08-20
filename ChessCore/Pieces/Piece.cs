using System.Collections.Generic;

namespace ChessCore.Pieces
{
    public abstract class Piece
    {
        #warning REMEMBER THIS 
        //TODO: implement search algorithm
        //TODO: add recursive call so that pieces can be a simple implementation of movement patterns 
        //TODO: implement movementMap Getting
        //TODO: add a stack of positions instead of just a movementmap
        public Position position { get; set; }
        public Map parentMap { get; set; }
        public bool isAlive { get; set; }
        public Color color { get; set; }
        public List<Movement> movementHistory {get;set;}
        public MovementMap Mapmovements(){
            MovementMap map = new MovementMap();
            for (int i = 0; i < (int)Direction.Left; i++)
            {
                map = emulateMovement((Direction)i,map);
            }
            return map;
        }
        public MovementMap emulateMovement(Direction d,MovementMap map){
            if(d==Direction.Top){
                return MakeMovement(0,1,map);
            }
            else if(d==Direction.Right){
                return MakeMovement(1,0,map);
            }
            else if(d==Direction.Bottom){
                return MakeMovement(0,-1,map);
            }
            else{
                return MakeMovement(-1,0,map);
            }
        }
        public abstract MovementMap MakeMovement(int x, int y,MovementMap map);
              // public  MovementMap GetMovements(){
        //     return null;
        // }
        
        // public Stack<Position> getPossiblePositions(){
        //     return null;
        // }

    }
}