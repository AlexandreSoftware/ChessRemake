using System.IO;
namespace ChessCore
{
    public class Position
    {
        /*
            These are the kind of usecases that really make me bitter about C# typing

            the ideal solution for the y prop would be to store an int 
            which is equal to the position of the int on the array, 
            but on the input it can take a string input and convert it to a integer
            that way the size of the data is way smaller

        */
        public int x {get;set;}
        public int y {get;set;}
        public Position(int x,int y){
            this.x=x-1; this.y=y-1;
        }
    }
}