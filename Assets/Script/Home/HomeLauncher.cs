using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExampleGame.boot;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.Home
{
	public class HomeLauncher : SceneLauncher<HomeLauncher, HomeView>
	{
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(OnClickPlayButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        public override string SceneName => "Home";
        private void OnClickPlayButton()
        {
            Sceneloader.Instance.LoadScene("Gameplay");
        }
        
    }
}