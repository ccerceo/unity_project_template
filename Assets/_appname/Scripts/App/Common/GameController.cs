using System;
using Appname.Domain;
using UnityEngine;
using Zenject;

namespace Appname.App
{
    public class GameController : MonoBehaviour 
    {
        private GameModel _gameModel;
        private SceneNavigation _sceneNavigation;

        public event Action<GameState, object> OnGameStageChanged = delegate{};

        [Inject]
        private void Construct(SceneNavigation sceneNavigation)
        {
            _gameModel = new GameModel();
            _sceneNavigation = sceneNavigation;

            Application.targetFrameRate = 30;

            LoadSplashScene();
        }

        public void LoadSplashScene()
        {
            _sceneNavigation.LoadScene((int)GameState.Splash, () => {
                var sceneModel = new SplashSceneModel(_gameModel.GameState);
                UpdateGameState(GameState.Splash, sceneModel);
            });
        }

        public void LoadHomeScene()
        {
            _sceneNavigation.LoadScene((int)GameState.Home, () => {
                var sceneModel = new HomeSceneModel(_gameModel.GameState);
                UpdateGameState(GameState.Home, sceneModel);
            });
        }

        private void Start()
        {
            LoadSplashScene();
        }

        private void UpdateGameState(GameState gameState, object sceneModel)
        {
            _gameModel.GameState = gameState;

            OnGameStageChanged(gameState, sceneModel);
        }
    }   
}
