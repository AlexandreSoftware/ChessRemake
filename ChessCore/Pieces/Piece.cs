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
  
        public Position  ConvertDirectiontoXy(Direction d){
            return null;
        }
        public MovementMap MapMovements(Direction d){

        }
              // public  MovementMap GetMovements(){
        //     return null;
        // }
        
        // public Stack<Position> getPossiblePositions(){
        //     return null;
        // }

    }
}