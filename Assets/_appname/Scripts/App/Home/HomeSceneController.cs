using Appname.Domain;

namespace Appname.App
{
    public class HomeSceneController : BaseSceneController<HomeSceneModel>
    {
        protected override GameState GameState { get { return GameState.Home; } }

        public HomeSceneController(GameController gameController)
            : base(gameController)
        {
        }
    }
}