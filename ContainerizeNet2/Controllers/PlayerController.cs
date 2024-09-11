using ContainerizeNet2.DTO;
using ContainerizeNet2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContainerizeNet2.Controllers
{
    [ApiController]
    [Route("/api/")]
    public class PlayerController : ControllerBase
    {
        private FakePlayerRepository fakePlayerRepository;

        public PlayerController(FakePlayerRepository fakePlayerRepository)
        {
            this.fakePlayerRepository = fakePlayerRepository;
        }


        [Route("player")]
        [HttpGet]
        public IEnumerable<PlayerDTO> Get()
        {
            return fakePlayerRepository.FindAll().Select(p => new PlayerDTO { Id = p.Id, BornYear = p.Born, Jersey = p.JerseyNumber, PlayerName = p.PlayerName, TeamName = p.TeamName })
                .ToArray();
        }
    }
}
