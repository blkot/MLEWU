using System;
using UnityEngine;
using Xanta.Application.Framework.UI;
using Xanta.Application.Framework.UI.Core;

public class Tester : MonoBehaviour

{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Router.GoToMainMenu();
        }
    }
}