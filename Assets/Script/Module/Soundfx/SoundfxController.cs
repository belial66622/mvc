using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using ExampleGame.Module.SaveData;
using ExampleGame.Message;
using System;

namespace ExampleGame.Module.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {

        public void OnUpdateCoin()
        {
            Debug.Log("Play Sound fx");
        }


    }
}
