using Microsoft.AspNetCore.Mvc;
using ChessService;
using ChessService.Model;
using System.IO;
using Microsoft.AspNetCore.Http;
using System;

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
            try{
                DisplayPiece p = new DisplayPiece(x[0],y,color,type);
                return Ok(ps.AddPiece(p));
            }
            catch(IOException e){
                return BadRequest(e.Message);
            }
            catch(Exception e){
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
        
    }
}