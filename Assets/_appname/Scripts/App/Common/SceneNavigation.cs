using System;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Appname.App
{
    public class SceneNavigation
    {
        public void LoadScene(int sceneIndex, Action callback)
        {
            UnityAction<Scene, Scene> wrappedCallback = delegate{};
            wrappedCallback = (s1, s2) => {
                SceneManager.activeSceneChanged -= wrappedCallback;
                callback();
            };
            SceneManager.activeSceneChanged += wrappedCallback;
            SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
        }
    }
}
