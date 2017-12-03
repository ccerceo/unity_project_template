using Appname.App;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Appname.Presentation
{
    public class HomeSceneView : MonoBehaviour
    {
        [SerializeField] private GameObject _sceneContainer;
        [SerializeField] private Button _continueButton;

        private HomeSceneController _homeSceneController;

        [Inject]
        private void Construct(HomeSceneController homeSceneController)
        {
            _homeSceneController = homeSceneController;
        }

        private void OnEnable()
        {
            _homeSceneController.OnSceneEnabled += HandleSceneEnabled;
            _homeSceneController.OnSceneDisabled += HandleSceneDisabled;
            _continueButton.onClick.AddListener(HandleContinueButtonClicked);
        }

        private void OnDisable()
        {
            _homeSceneController.OnSceneEnabled -= HandleSceneEnabled;
            _homeSceneController.OnSceneDisabled -= HandleSceneDisabled;
            _continueButton.onClick.RemoveListener(HandleContinueButtonClicked);
        }

        private void HandleSceneEnabled(HomeSceneModel sceneModel)
        {
            _sceneContainer.SetActive(true);
        }

        private void HandleSceneDisabled(HomeSceneModel sceneModel)
        {
            _sceneContainer.SetActive(false);
        }

        private void HandleContinueButtonClicked()
        {
            Debug.LogError("not implemented");
        }
    }
}
