namespace Appname.Domain
{
    public class GameModel
    {
        public GameState GameState { get; set; }

        public GameModel()
        {
            GameState = GameState.Bootstrap;
        }
    }
}
