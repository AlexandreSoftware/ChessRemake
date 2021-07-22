namespace ChessCore
{
    public class Player
    {
        public string username { get; set; }
        public string name { get; set; }
        public GameHistory ActiveGames {get;set;}
        public GameHistory TotalGames {get;set;}
               
    }
}