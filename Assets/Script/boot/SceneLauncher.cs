using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.boot { 
public abstract class SceneLauncher<Tlauncher, Tview> : BaseLauncher<Tlauncher, Tview>
    where Tlauncher : SceneLauncher<Tlauncher, Tview>
    where Tview : BaseSceneView
{
        protected override ILoad GetLoader()
        {
            return Sceneloader.Instance;
        }

        protected override IMain GetMain()
        {
            return gamemain.Instance;
        }

        protected override ISplash GetSplash()
        {
            return SplashScreen.Instance;
        }
    }
}