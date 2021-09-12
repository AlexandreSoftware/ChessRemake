namespace ChessCore.Pieces{
    public class King:Piece
    {   

        public King(int id, Position position, Map parentmap,bool isAlive,Color color,Movement[] movementHistory) :base(id,position,parentmap,isAlive,color,movementHistory){

        }
        public King(int id, Position position,bool isAlive,Color color):base(id,position,isAlive,color){
        
        }
        public King():base(){}
        public override MovementMap TryMakeMovement(Position p, MovementMap pmap){
            return null;
        }
        
    }
}