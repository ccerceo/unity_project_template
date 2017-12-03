using Appname.App;
using Zenject;

namespace Appname.Presentation
{
    public class SplashSceneInstaller : MonoInstaller
    {
        public override void InstallBindings ()
        {
            Container.Bind<SplashSceneController>().AsSingle();
        }
    }
}
