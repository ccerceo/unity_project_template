using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Appname.Presentation
{
    [RequireComponent(typeof(Button))]
    public class UIButtonSfx : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private AudioPlayer _audioPlayer;

        private Button _button;
        private float _lastButtonClickSfx;

        public void OnPointerDown(PointerEventData eventData)
        {
            // IsInteractable will check the hierarchy, while interactable property is only self
            if (_button.IsInteractable())
            {
                _audioPlayer.PlaySfx(null);
            }
        }

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(HandleButtonClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(HandleButtonClick);
        }

        private void HandleButtonClick()
        {
            _audioPlayer.PlaySfx(null);
        }
    }
}
