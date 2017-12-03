using Appname.App;
using Zenject;

namespace Appname.Presentation
{
    public class HomeSceneInstaller : MonoInstaller
    {
        public override void InstallBindings ()
        {
            Container.Bind<HomeSceneController>().AsSingle();
        }
    }
}
