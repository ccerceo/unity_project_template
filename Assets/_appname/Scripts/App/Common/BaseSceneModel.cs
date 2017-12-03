using Appname.Domain;

namespace Appname.App
{
    public abstract class BaseSceneModel
    {
        public GameState PreviousGameState { get; private set; }

        private BaseSceneModel() {}

        protected BaseSceneModel(GameState previousGameState)
        {
            PreviousGameState = previousGameState;
        }
    }
}
