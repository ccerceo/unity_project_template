using Zenject;
using Appname.App;

namespace Appname.Presentation
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings ()
        {
            var goCreationParams = new GameObjectCreationParameters();
            goCreationParams.Name = typeof(GameController).Name;
            Container.Bind<GameController>().FromNewComponentOnNewGameObject(goCreationParams).AsSingle().NonLazy();
            Container.Bind<SceneNavigation>().AsSingle();
        }
    }   
}
