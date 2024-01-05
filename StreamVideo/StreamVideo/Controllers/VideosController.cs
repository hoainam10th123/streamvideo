using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace StreamVideo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        // <video autoPlay controls src="http://localhost:5006/api/Videos"></video>
        [HttpGet]
        public IActionResult GetVideo()
        {
            var filename = "socketChat.mp4";
            string path = Path.Combine("wwwroot", "videos", filename);
            var filestream = System.IO.File.OpenRead(path);
            return File(filestream, 
                contentType: "video/mp4", 
                fileDownloadName: filename, 
                enableRangeProcessing: true);
        }
    }
}
