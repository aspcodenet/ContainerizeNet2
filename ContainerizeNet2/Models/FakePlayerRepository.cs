
namespace ContainerizeNet2.Models
{
    public class FakePlayerRepository
    {
        private static List<Player> players = new()
        {
            new Player{ Id=1, JerseyNumber=21, Born=1973,PlayerName="Peter Forsberg",TeamName="Colorado" },
            new Player{ Id=2, JerseyNumber=13, Born=1971,PlayerName="Mats Sundin",TeamName="Toronto" },
            new Player{ Id=3, JerseyNumber=5, Born=1970,PlayerName="Niklas Lidström",TeamName="Detroit" }
        };

        public List<Player> FindAll()
        {
            return players;
        }

    }
}
