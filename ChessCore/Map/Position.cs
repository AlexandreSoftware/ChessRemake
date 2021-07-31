using System;
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
        private int x {
            get{
                return x+1;
            }
            set{
                if(value<=8&&value>0){
                    x=value-1;
                }
                else{
                    throw new IOException("Index out of max range for position");
                }
            }
        }
        private int y{
            get{
                return y+1;
            }
            set{
                if(value<=8&&value>0){
                    y=value-1;
                }
                else{
                    throw new IOException("Index out of max range for position");
                }
            }
        }
        public Position(int x,int y){
            this.x=x;
            this.y=y;
        }
    }
}