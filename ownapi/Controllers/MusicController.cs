using Microsoft.AspNetCore.Mvc;
using ownapi.Models;



namespace ownapi.Controllers;

[ApiController]
[Route("api/Music")]
public class MusicController : ControllerBase
{
    private readonly MusicfinderdbContext DB;
    public  MusicController(MusicfinderdbContext db)
    {
        this.DB = db;

    }
  [HttpGet("GetAllMusic/{Music}")]
  public Musicfinder GetAllMusic(int Music)
  {
    try
    {
        return DB.Musicfinders.Where(y =>y.Id.Equals(Music)).FirstOrDefault();

    }
    catch(System.Exception)
    {
        throw;
    }
  }
}