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
        public void Map_NewMap_EqualArrays()
        {
            var compareMap = new Piece[8,8];
            CollectionAssert.AreEqual(testMap.map,compareMap);
        }
        [TestMethod]
        public void Map_NewMap_DifferentArrays()
        {
            var compareMap = new Piece[7,4];
            CollectionAssert.AreNotEqual(testMap.map,compareMap);
        }
        [TestMethod]
        public void Map_CheckPositions_EqualPieces(){
            testMap.PlacePiece(p);
            var testp=testMap.choosePiece(p.position);
            Assert.AreSame(p,testp);
        }
        [TestMethod]
        public void PlacePiece_AddingPieces_EqualArrays(){
            testMap.PlacePiece(p);
            var compareMap = new Piece[8,8];
            compareMap[0,1] = p;
            CollectionAssert.AreEqual(testMap.map,compareMap);
        }
        [TestMethod]
        public void PlacePiece_AddingDifferentPieces_DifferentArrays(){
            testMap.PlacePiece(p);
            var compareMap = new Piece[8,8];
            compareMap[1,2] =new Pawn{position=new Position(1,2)}; 
            CollectionAssert.AreNotEqual(testMap.map,compareMap);
        }
        [TestMethod]
        public void PlacePiece_AddingPiecesDifferentPlaces_DifferentArrays(){
            testMap.PlacePiece(p);
            var compareMap = new Piece[8,8];
            compareMap[5,4] = p;
            CollectionAssert.AreNotEqual(testMap.map,compareMap);
        }
        [TestMethod]
        public void MovePiece_MovingPieces_EqualArrays(){
            testMap.PlacePiece(p);
            testMap.MovePiece(p,new Position(2,4));
            var compareMap = new Piece[8,8];
            compareMap[1,3] = p;
            CollectionAssert.AreEqual(testMap.map,compareMap);

        } 
        [TestMethod]
        public void MovePiece_MovingPiecesWrongPlace_DifferentArrays(){
            testMap.PlacePiece(p);
            Piece p1 = new Pawn{
                position = new Position(4,2)
            };
            testMap.MovePiece(p,new Position(2,4));
            var compareMap = new Piece[8,8];
            compareMap[4,6] = p;
            CollectionAssert.AreNotEqual(testMap.map,compareMap);
        } 
         [TestMethod]
        public void MovePiece_MovingPiecesWrongPiece_DifferentArrays(){
            Piece p1 = new Pawn{
                position = new Position(4,2)
            };
            testMap.PlacePiece(p);
            testMap.PlacePiece(p1);
            testMap.MovePiece(p1,new Position(2,4));
            var compareMap = new Piece[8,8];
            compareMap[4,2] = p;
            CollectionAssert.AreNotEqual(testMap.map,compareMap);
        } 
        [TestMethod]
        public void removePiece_RemovingPieces_EqualArrays(){
            testMap.PlacePiece(p);
            Piece p1 = new Pawn{
                position = new Position(4,2)
            };
            testMap.PlacePiece(p);
            testMap.PlacePiece(p1);
            testMap.removePiece(p);
            var compareMap = new Piece[8,8];
            compareMap[3,1] = p1;
            CollectionAssert.AreEqual(testMap.map,compareMap);
        }
        [TestMethod]
        public void removePiece_RemovingPiecesWrongPiece_DifferentArrays(){
            testMap.PlacePiece(p);
            Piece p1 = new Pawn{
                position = new Position(4,2)
            };
            testMap.PlacePiece(p);
            testMap.PlacePiece(p1);
            testMap.removePiece(p1);
            var compareMap = new Piece[8,8];
            compareMap[4,2] = p;
            CollectionAssert.AreNotEqual(testMap.map,compareMap);
        }

    }
}
