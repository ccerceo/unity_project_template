using UnityEngine;
using UnityEngine.UI;

namespace Appname.Presentation
{
    [RequireComponent(typeof(Text))]
    public class FPSDisplay : MonoBehaviour
    {
        private Text _text;
        private float _deltaTime = 0.0f;

        private void Start()
        {
            _text = GetComponent<Text>();
        }

        private void Update()
        {
            _deltaTime += (Time.deltaTime - _deltaTime) * 0.1f;
            float msec = _deltaTime * 1000.0f;
            float fps = 1.0f / _deltaTime;
            string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
            _text.text = text;
        }
    }    
}
