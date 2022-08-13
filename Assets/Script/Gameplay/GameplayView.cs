using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExampleGame.boot;
using ExampleGame.Home;
using Agate.MVC.Base;
using ExampleGame.Module.ClickGame;

namespace ExampleGame.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public ClickGameView ClickGameView;

    }
}