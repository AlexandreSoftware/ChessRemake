namespace ChessCore
{
    public class Position
    {
        private int _x;
        private int _y;
        public int x { get{return _x;} set{_x=value-1;} }
        public int y { get{return _y;} set{_y=value-1;} }
        public Position(int x,int y){
            this.x=x;
            this.y=y;
        }
    }
}