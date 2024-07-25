using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformSerice.Models;
using PlatformService.Data;
using PlatformService.DTO;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController: ControllerBase
    {
        private readonly IPlatformRep _rep;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRep rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDTO>> GetPlatforms()
        {
            var platforms = _rep.GetAllPlatform();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDTO>>(platforms));
        }
    }
}
