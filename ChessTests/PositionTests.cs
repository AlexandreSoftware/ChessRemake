using ChessCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ChessTests
{
    [TestClass]
    public class PositionTests
    {
        /*Dummy class for future tests*/
        [TestMethod]
        public void Position_Equal_AreEqualPosition(){
            Position p = new Position (3,5);
            Assert.IsTrue(p.x==2&&p.y==4);
        }
    }   
}
