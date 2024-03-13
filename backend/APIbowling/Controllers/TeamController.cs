using APIbowling.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIbowling.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public TeamController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            var teamData = _bowlingRepository.Teams.ToArray();
            return teamData;
        }
    }
}

