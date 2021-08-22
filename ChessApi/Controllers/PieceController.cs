using Microsoft.AspNetCore.Mvc;
using ChessApi.Model;
namespace ChessApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PieceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPiece(int id ){
            
        }
        [HttpPost]
        public IActionResult AddPiece(string x,int y,string color){
            DisplayPiece p = new DisplayPiece(x[0],y,color);
            return Ok(p);
        }
        
    }
}