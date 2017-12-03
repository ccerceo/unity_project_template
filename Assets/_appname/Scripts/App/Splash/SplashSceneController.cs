using Appname.Domain;

namespace Appname.App
{
    public class SplashSceneController : BaseSceneController<SplashSceneModel>
    {
        protected override GameState GameState { get { return GameState.Splash; } }

        public SplashSceneController(GameController gameController)
            : base(gameController)
        {
        }

        public void LoadHomeScene()
        {
            _gameController.LoadHomeScene();
        }
    }
}