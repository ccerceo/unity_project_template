using Zenject;
using Appname.App;

namespace Appname.Presentation
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings ()
        {
            Container.Bind<GameController>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            Container.Bind<SceneNavigation>().AsSingle();
        }
    }   
}
