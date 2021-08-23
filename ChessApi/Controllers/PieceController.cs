using Microsoft.AspNetCore.Mvc;
using ChessService;
using ChessService.Model;
namespace ChessApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PieceController : ControllerBase
    {

        PieceService ps = new PieceService();
        [HttpGet]
        public IActionResult GetPiece(int id ){
            return null;
        }
        [HttpPost]
        public IActionResult AddPiece(string x,int y,string color){
            DisplayPiece p = new DisplayPiece(x[0],y,color);
            return Ok(ps.AddPiece(p));
        }
        
    }
}