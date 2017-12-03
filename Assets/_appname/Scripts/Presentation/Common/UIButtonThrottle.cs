using UnityEngine;
using UnityEngine.UI;

namespace Appname.Presentation
{
    [RequireComponent(typeof(Button))]
    public class UIButtonThrottle : MonoBehaviour
    {
        private Button _button;
        private float _timeDisabled = 0f;
        private bool _reset;

        private const float DISABLE_TIME = 0.25f;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void Update()
        {
            if (_reset && !_button.interactable && Time.time - _timeDisabled > DISABLE_TIME)
            {
                _reset = false;
                _button.interactable = true;
            }
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
            _reset = true;
            _timeDisabled = Time.time;
            _button.interactable = false;
        }
    }
}
