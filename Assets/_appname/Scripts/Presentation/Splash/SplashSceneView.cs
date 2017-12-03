using Appname.App;
using UnityEngine;
using Zenject;
using UnityEngine.UI;

namespace Appname.Presentation
{
    public class SplashSceneView : MonoBehaviour
    {
        [SerializeField] private GameObject _sceneContainer;
        [SerializeField] private Button _continueButton;

        private SplashSceneController _splashSceneController;

        [Inject]
        private void Construct(SplashSceneController splashSceneController)
        {
            _splashSceneController = splashSceneController;
        }

        private void OnEnable()
        {
            _splashSceneController.OnSceneEnabled += HandleSceneEnabled;
            _splashSceneController.OnSceneDisabled += HandleSceneDisabled;
            _continueButton.onClick.AddListener(HandleContinueButtonClicked);
        }

        private void OnDisable()
        {
            _splashSceneController.OnSceneEnabled -= HandleSceneEnabled;
            _splashSceneController.OnSceneDisabled -= HandleSceneDisabled;
            _continueButton.onClick.RemoveListener(HandleContinueButtonClicked);
        }

        private void HandleSceneEnabled(SplashSceneModel sceneModel)
        {
            _sceneContainer.SetActive(true);
        }

        private void HandleSceneDisabled(SplashSceneModel sceneModel)
        {
            _sceneContainer.SetActive(false);
        }

        private void HandleContinueButtonClicked()
        {
            _splashSceneController.LoadHomeScene();
        }
    }
}
