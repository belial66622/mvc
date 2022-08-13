using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExampleGame.boot;
using ExampleGame.Module.SaveData;
using ExampleGame.Message;

namespace ExampleGame.Module.ClickGame
{
	public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
	{
		private SaveDataController _saveData;
		private void OnClickEarnCoin()
		{
			_model.AddCoin();
			Publish<UpdateCoinMessage>(new UpdateCoinMessage(_model.Coin));
		}


		private void OnClickSpendCoin()
		{
			_model.SubstractCoin();
			Publish<UpdateCoinMessage>(new UpdateCoinMessage(_model.Coin));
		}

		private void OnClickBack()
		{
			Sceneloader.Instance.LoadScene("Home");
		}

        public override void SetView(ClickGameView view)
        {
            base.SetView(view);
			view.SetCallbacks(OnClickEarnCoin, OnClickSpendCoin, OnClickBack);
        }

		public override IEnumerator Finalize()
		{
			yield return base.Finalize();
			_model.SetCoin(_saveData.Model.Coin);
		}


	}
}