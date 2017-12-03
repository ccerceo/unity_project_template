using Appname.Domain;
using System;

namespace Appname.App
{
    public abstract class BaseSceneController<T> where T : class
    {
        public event Action<T> OnSceneEnabled = delegate{};
        public event Action<T> OnSceneDisabled = delegate{};

        protected GameController _gameController;
        protected abstract GameState GameState { get; }

        protected BaseSceneController(GameController gameController)
        {
            _gameController = gameController;
            _gameController.OnGameStageChanged += HandleGameStageChanged;
        }

        protected virtual void HandleGameStageChanged(GameState gameState, object sceneModel)
        {
            if (gameState == GameState)
            {
                OnSceneEnabled(sceneModel as T);
            }
            else
            {
                OnSceneDisabled(sceneModel as T);
            }
        }
    }
}
