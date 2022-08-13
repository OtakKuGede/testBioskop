using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.Studio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Bioskop.Controllers
{
    [Route("api/MsStudio/")]
    [ApiController]
    public class MsStudioController : ControllerBase
    {
        private readonly IMsStudioService MsStudioService;

        public MsStudioController(IMsStudioService ser)
        {
            MsStudioService = ser;
        }

        [HttpGet]
        [Route("[Action]")]
        [Route("GetStudios")]
        public StudioResponseDto GetStudio()
        {
            StudioResponseDto Studio = MsStudioService.GetStudio();
            return Studio;
        }

        [HttpPost]
        [Route("[Action]")]
        [Route("GetStudios")]
        public StudioResponseDto2 AddStudio([FromBody]MsStudio po)
        {
            StudioResponseDto2 x = MsStudioService.AddStudio(po);
            return x;
        }
        
        [HttpPatch]
        [Route("[Action]")]
        [Route("UpdateStudios")]
        public StudioResponseDto2 UpdateStudio([FromBody] MsStudio o)
        {
            StudioResponseDto2 x = MsStudioService.UpdateStudio(o);
            return x;
        }

        [HttpDelete]
        [Route("[Action]")]
        [Route("DeleteStudios")]
        public StudioResponseDto2 DeleteStudio([FromQuery]Guid IdStudio)
        {
            StudioResponseDto2 x = MsStudioService.DeleteStudio(IdStudio);
            return x;
        }
    }
}
