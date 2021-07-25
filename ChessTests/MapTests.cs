using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessCore;
using ChessCore.Pieces;

namespace ChessTests
{
    [TestClass]
    public class MapTests
    {
        private Map testMap= new Map();
        Piece p = new Pawn{position=new Position(1,2),};
        [TestInitialize]
        public void Setup()
        {
            testMap=new Map();
            p = new Pawn{position=new Position(1,2)};
        }
        [TestMethod]
        public void Map_NewMap_EquivalentArrays()
        {
            var compareMap = new Piece[8,8];
            CollectionAssert.AreEquivalent(testMap.map,compareMap);
        }
        [TestMethod]
        public void PlacePiece_AddingPieces_EquivalentArrays(){
            testMap.PlacePiece(p);
            var compareMap = new Piece[8,8];
            compareMap[1,2] = p;
            CollectionAssert.AreEquivalent(testMap.map,compareMap);
        }
        [TestMethod]
        public void MovePiece_MovingPieces_EquivalentArrays(){
            testMap.PlacePiece(p);
            testMap.MovePiece(p,new Position(2,4));
            var compareMap = new Piece[8,8];
            compareMap[2,4] = p;
            CollectionAssert.AreEquivalent(testMap.map,compareMap);

        } 
        [TestMethod]
        public void removePiece_RemovingPieces_EquivalentArrays(){
            testMap.PlacePiece(p);
            Piece p1 = new Pawn{
                position = new Position(4,2)
            };
            testMap.PlacePiece(p);
            testMap.PlacePiece(p1);
            testMap.removePiece(p);
            var compareMap = new Piece[8,8];
            compareMap[4,2] = p1;
        
        }
    }
}
