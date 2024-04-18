using Minidev.Core;
using Minidev.Core.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameplaySceneContext : MonoInstaller
{
    public override void InstallBindings()
    {
        //Container.Bind<GameplayLogic>().FromNew().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<GameplayLogic>().AsSingle();
        Container.Bind<SaveLoadService>().FromNew().AsSingle();
    }
}
