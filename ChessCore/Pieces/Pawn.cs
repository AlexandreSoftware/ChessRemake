namespace ChessCore.Pieces{
    public class Pawn:Piece
    {
        public bool enPassant = false;
        /*i know im literally hardcoding this, but this makes the code more readable, while avoiding redundancy, 
        altough it wastes 3 loops"*/
        #warning TODO: add en passant support

        public Pawn(int id, Position position, Map parentmap,bool isAlive,Color color,Movement[] movementHistory) :base(id,position,parentmap,isAlive,color,movementHistory){

        }
        public Pawn(int id, Position position,bool isAlive,Color color):base(id,position,isAlive,color){
        
        }
        public Pawn():base(){}

        public override MovementMap TryMakeMovement(Position p, MovementMap pmap){
            if(this.color==Color.White){
                p= new Position(0,1);
            }
            else{
                p= new Position(0,-1);
            }
            pmap.possibleMovements[p.x,p.y]=!(CheckForPiece(p));
            pmap.possibleMovements[p.x-1,p.y]=!(CheckForPiece(p));
            pmap.possibleMovements[p.x+1,p.y]=!(CheckForPiece(p));
            if(this.movementHistory.Capacity==0){
                p= new Position(0,p.y*2);
                pmap.possibleMovements[p.x,p.y]=!(CheckForPiece(p));
                enPassant=true;
            }
            return null;
        }
        
    }
}