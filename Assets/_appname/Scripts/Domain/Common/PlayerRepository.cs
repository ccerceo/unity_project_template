using Appname.Infrastructure;
using Zenject;

namespace Appname.Domain
{
    public class PlayerRepository
    {
        private Player _player;

        private Player Player
        {
            get 
            {
                if (_player == null)
                {
                    _player = LocalStorage.Get<Player>(Constants.PLAYER_DATA_KEY) ?? (_player = _container.Instantiate<Player>());
                    _container.Inject(_player);
                }

                return _player;
            }
        }

        private DiContainer _container;

        public PlayerRepository(DiContainer container)
        {
            _container = container;
        }

        public Player GetPlayer()
        {
            return Player;
        }

        public void Save(Player player)
        {
            LocalStorage.Set(Constants.PLAYER_DATA_KEY, player);
        }
    }
}
