using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.boot { 
public class Sceneloader : BaseLoader<Sceneloader>
{

        protected override string SplashScene => "SplashScreen";
    }
}