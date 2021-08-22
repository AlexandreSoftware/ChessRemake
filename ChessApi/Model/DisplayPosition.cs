namespace ChessApi.Model
{
    public class DisplayPosition
    {
        public char x {get;set;}
        public int y {get;set;}   
        public DisplayPosition(char x, int y){
            this.x=x;
            this.y=y;
        }
    }   
}