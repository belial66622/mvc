using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        protected override ILoad GetLoader()
        {
            return Sceneloader.Instance;
        }

        protected override IMain GetMain()
        {
            return gamemain.Instance;
        }

    }
}
