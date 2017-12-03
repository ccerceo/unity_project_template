using System;
using System.Linq;
using UnityEngine;

namespace Appname.Presentation
{
    public class InputSystem : MonoBehaviour
    {
        private int _touchId1;
        private int _touchId2;
        private Quaternion _targetRot;

        private Touch _touch1;
        private Touch _touch2;
        private bool HasTouch1
        {
            get { return _touchId1 >= 0; }
        }

        private bool HasTouch2
        {
            get { return _touchId2 >= 0; }
        }

        private bool HasTouch1And2 { get { return HasTouch1 && HasTouch2; } }


        protected virtual void BeginOneTouch(Touch touch) { OnOneTouchBegan(touch); }
        protected virtual void BeginTwoTouch(Touch touch1, Touch touch2) { OnTwoTouchBegan(touch1, touch2); }
        protected virtual void UpdateOneTouch(Touch touch) { OnOneTouchUpdated(touch); }
        protected virtual void UpdateTwoTouch(Touch touch1, Touch touch2) { OnTwoTouchUpdated(touch1, touch2); }
        protected virtual void FinishOneTouch() { OnOneTouchFinished(); }
        protected virtual void FinishTwoTouch() { OnTwoTouchFinished(); }

        public event Action<Touch> OnOneTouchBegan = delegate{};
        public event Action<Touch, Touch> OnTwoTouchBegan = delegate{};
        public event Action<Touch> OnOneTouchUpdated = delegate{};
        public event Action<Touch, Touch> OnTwoTouchUpdated = delegate{};
        public event Action OnOneTouchFinished = delegate{};
        public event Action OnTwoTouchFinished = delegate{};

        private void Update()
        {
            var prevHasTouch1 = HasTouch1;
            var prevHasTouch2 = HasTouch2;

            #if UNITY_EDITOR
            DetectMouse();
            #else
            DetectTouches();
            #endif

            UpdateTouch(prevHasTouch1, prevHasTouch2);
        }

        private void OnEnable()
        {
            _touchId1 = -1;
            _touchId2 = -1;
        }

        private void OnDisable()
        {
            _touchId1 = -1;
            _touchId2 = -1;
        }

        private void UpdateTouch(bool prevHasTouch1, bool prevHasTouch2)
        {
            if (!prevHasTouch1 && HasTouch1 && !HasTouch2)
            {
                BeginOneTouch(_touch1);
            }
            else if (!prevHasTouch2 && HasTouch1And2)
            {
                BeginTwoTouch(_touch1, _touch2);
            }
            else if (HasTouch1 && !HasTouch2)
            {
                UpdateOneTouch(_touch1);
            }
            else if (HasTouch1And2)
            {
                UpdateTwoTouch(_touch1, _touch2);
            }

            if (prevHasTouch2 && !HasTouch2)
            {
                FinishTwoTouch();
            }

            if (prevHasTouch1 && !HasTouch1)
            {
                FinishOneTouch();
            }
        }

        private void DetectMouse()
        {
            Vector3 touch1Pos = Vector3.zero;
            Vector3 touch1DeltaPos = Vector3.zero;
            if (!HasTouch1 && Input.GetMouseButtonDown(0))
            {
                touch1Pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                touch1DeltaPos = Vector3.zero;
                _touchId1 = 0;
            }
            else if (HasTouch1 && Input.GetMouseButton(0))
            {
                var mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                touch1Pos = mousePosition;
                touch1DeltaPos = mousePosition - _touch1.position;
            }
            else if(HasTouch1 && Input.GetMouseButtonUp(0))
            {
                _touchId1 = -1;
            }

            _touch1 = new Touch{ fingerId = _touchId1, position = touch1Pos, deltaPosition = touch1DeltaPos, deltaTime = Time.deltaTime };
            _touch2 = default(Touch);
        }

        private void DetectTouches()
        {
            if (HasTouch1 && !Input.touches.Any(t => t.fingerId == _touchId1))
            {
                _touchId1 = -1;
            }

            if (HasTouch2 && !Input.touches.Any(t => t.fingerId == _touchId2))
            {
                _touchId2 = -1;
            }

            if ((HasTouch1And2 && Input.touchCount != 2) ||
                (!HasTouch1 && HasTouch2))
            {
                _touchId1 = -1;
                _touchId2 = -1;
            }

            if (!HasTouch1 && !HasTouch2 && Input.touchCount > 0 && Input.touchCount < 3)
            {
                _touchId1 = Input.GetTouch(0).fingerId;
            }

            if (HasTouch1 && !HasTouch2 && Input.touchCount == 2)
            {
                var touch = Input.touches.First(t => t.fingerId != _touchId1);
                _touchId2 = touch.fingerId;
            }

            _touch1 = Input.touches.FirstOrDefault(t => t.fingerId == _touchId1);
            _touch2 = Input.touches.FirstOrDefault(t => t.fingerId == _touchId2);
        }
    }   
}
