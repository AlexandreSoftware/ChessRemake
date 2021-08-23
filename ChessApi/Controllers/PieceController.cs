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
        public IActionResult AddPiece(string x,int y,string color,string type){
            DisplayPiece p = new DisplayPiece(x[0],y,color,type);
            p.type=type;
            return Ok(ps.AddPiece(p));
        }
        
    }
}