namespace Appname.Domain
{
    public class PlayerService
    {
        private PlayerRepository _playerRepository;

        public PlayerService(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
    }
}
